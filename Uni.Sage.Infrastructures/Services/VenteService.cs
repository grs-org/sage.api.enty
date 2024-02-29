using Dapper;
using Microsoft.VisualBasic;
using Serilog;
using System.Numerics;
using Uni.Sage.Api.Enty.Services;
using Uni.Sage.Application.Contrats.Requests;
using Uni.Sage.Application.Contrats.Responses;
using Uni.Sage.Domain.Entities;
using Uni.Sage.Domain.Extentions;
using Uni.Sage.Infrastructures.Mapper;
using Uni.Sage.Shared.Exceptions;
using Uni.Sage.Shared.Extention;
using Uni.Sage.Shared.Wrapper;

namespace Uni.Sage.Infrastructures.Services
{
    public interface IVenteService
    {
        Task<IResult<DocumentResponse>> CreateCommande(DocEnteteRequest commande);
    }

    public partial class VenteService : IVenteService
    {
        private readonly IQueryService _QueryService;


        public VenteService(IQueryService queryService)
        {
            _QueryService = queryService;
        }





        public async Task<IResult<DocumentResponse>> CreateCommande(DocEnteteRequest Request)
        {
            var Result = new Result<DocumentResponse>();

            try
            {
                Serilog.Log.Debug($" count of list : {Request.DocLignes.Count}");
                using var db = _QueryService.NewDbConnection(Request.ConnectionName);

                using Repositories.SageRepository Repo = _QueryService.NewRepository(Request.ConnectionName);

                
                //Existence client

                var oClient = await Repo.QueryFirstOrDefaultAsync<ClientResponse>("SELECT_CLIENT_BYID", new { CodeClient = "C00001" });
                if (oClient == null)
                {
                    throw new ApiException("Client introuvable!");
                }
                if (oClient.EnSommeil == 1)
                {
                    throw new ApiException("Client en sommeil!");
                }

                F_DOCENTETE oF_DOCENTETE = DocEntetMapper.Adapt(Request, 0, 1);

                oF_DOCENTETE.CG_Num = "4110000";
                oF_DOCENTETE.DO_Tiers = "C00001";
                oF_DOCENTETE.DO_Tarif=(short)oClient.CodeTarif;
                oF_DOCENTETE.CA_Num = "953FRAN";
                //oF_DOCENTETE.Source_BC = "DEV";
                if (oF_DOCENTETE.DO_Tarif == 0) oF_DOCENTETE.DO_Tarif= 1;
               

                for (int i = 0; i < oF_DOCENTETE.F_DOCLIGNEs.Count; i++)
                {
                    var oLine = oF_DOCENTETE.F_DOCLIGNEs[i];

                    var oArticle = await Repo.QueryFirstOrDefaultAsync<ArticleResponse>("SELECT_ARTICLE_MIN_BY_ID", new { Reference = oLine.AR_Ref });

                    if (oArticle != null && oArticle.EnSommiel == 0)
                    {
                        var oStock = await Repo.QueryFirstOrDefaultAsync<ArticleParDepotResponse>("SELECT_ARTICLE_PAR_DEPOT_BY_ID", new { Reference = oLine.AR_Ref, CodeDepot = oF_DOCENTETE.DE_No });
                        var oTaxe = await Repo.QueryFirstOrDefaultAsync<TaxeResponse>("SELECT_TAXE_FAM_ART", new { CodeArticle = oLine.AR_Ref, CodeClient = oClient.CodeClient, CatCompta = oClient.CodeTarif });

                        oLine.DL_PoidsNet = oArticle.PoidsNet * oLine.DL_Qte;
                        oLine.DL_PoidsBrut = oArticle.PoidsBrut * oLine.DL_Qte;
                        oLine.EU_Enumere = oArticle.Unite;

                        //if (oStock?.QuantiteReel != 0) oLine.DL_PrixRU = oStock.Montant / oStock.QuantiteReel;
                        if (oStock != null && oStock.QuantiteReel != 0) oLine.DL_CMUP = oStock.Montant / oStock.QuantiteReel;
                        if (oTaxe != null) oLine.DL_Taxe1 = oTaxe.Taux;
                        if (oTaxe != null) oLine.DL_CodeTaxe1 = oTaxe.CodeTaxe;
                        //oLine.DL_Taxe1 = 20;
                        ////oLine.DL_CodeTaxe1 = "02";
                        //oLine.DL_CodeTaxe1 = "C20";
                    }
                    else if (oArticle == null)
                    {
                        Result.Errors.Add($"Article {oLine.AR_Ref } est inexistent");
                    }
                    else
                    {
                        Result.Errors.Add($"Article {oLine.AR_Ref } est  en sommiel");
                    }
                }

                if (Result.Errors.Count > 0)
                {
                    Result.Succeeded=false;
                    return Result;
                }

                //  DocEntetMapper.Adapt(Request);
                oF_DOCENTETE.Calculate();



                // insertion to F_Docentete
                using var insertRepo = _QueryService.NewRepository(Request.ConnectionName) ;
               
                using (var dbContextTransaction = insertRepo.BeginTransaction())
                {

                    try
                    {
                        oF_DOCENTETE.DO_Piece =await insertRepo.ExecuteScalarAsync<string>("SELECT_F_DOCCURRENTPIECE",
                            new
                            {
                                DC_Souche = oF_DOCENTETE.DO_Souche,
                                DC_Domaine = oF_DOCENTETE.DO_Domaine,
                                DC_IdCol = oF_DOCENTETE.DO_Type
                            });
                        oF_DOCENTETE.CT_NumPayeur = "C00001";
                        await insertRepo.QueryAsync<int>("INSERT_F_DOCENTETE", oF_DOCENTETE);

                        F_DOCREGLE f_DOCREGLE = new F_DOCREGLE(oF_DOCENTETE);
                        await insertRepo.QueryAsync<int>("INSERT_F_DOCREGL", f_DOCREGLE);

                       

                        // insertion to F_DOCLIGNE
                        var oDlNo = await insertRepo.ExecuteScalarAsync<int>("SELECT_F_DOCLIGNE_MAX_DL_NO");
                        foreach (var oLine in oF_DOCENTETE.F_DOCLIGNEs)
                        {
                            oLine.CT_Num = oF_DOCENTETE.DO_Tiers;
                            oLine.DO_Piece = oF_DOCENTETE.DO_Piece;
                            oLine.DL_No = oDlNo;
                            oLine.DO_Piece=oF_DOCENTETE.DO_Piece;
                            oLine.cbDE_No =  oLine.DE_No=oF_DOCENTETE.DE_No;
                            await insertRepo.QueryAsync<int>("INSERT_F_DOCLIGNE", oLine);
                            oDlNo++;
                            
                          // update Quantite reserve

                          var exeQuery = await insertRepo.QueryAsync<StockArticleResponse>("SELECT_STOCK_ARTICLE", new { Reference = oLine.AR_Ref, CodeDepot = oF_DOCENTETE.DE_No }) ;
                            var oStockReserve = exeQuery?.ToList();

                            if (oStockReserve.Count == 0)
                            {
                                F_ARTSTOCK f_Artstock = new F_ARTSTOCK();
                                f_Artstock.AR_Ref = oLine.AR_Ref;
                                f_Artstock.AS_QteRes = oLine.DL_Qte;
                                await insertRepo.QueryAsync<int>("INSERT_ARTSTOCK", f_Artstock);
                                // insert to artstock
                            }
                            else
                            {
                                var QuantiteReserve = oStockReserve[0].QuantiteReserve + oLine.DL_Qte;
                                await insertRepo.QueryAsync<int>("UPDATE_QTE_RESERVE",
                                   new
                                   {
                                       QuantiteReserve = QuantiteReserve,
                                       Reference = oLine.AR_Ref,
                                       CodeDepot = oF_DOCENTETE.DE_No
                                   });

                            }

                        }

                        // update numero de piece
                        await insertRepo.QueryAsync<int>("UPDATE_F_DOCCURRENTPIECE",
                           new
                           {
                               DC_Piece = oF_DOCENTETE.DO_Piece.Increment(),
                               DC_Souche = oF_DOCENTETE.DO_Souche,
                               DC_Domaine = oF_DOCENTETE.DO_Domaine,
                               DC_IdCol = oF_DOCENTETE.DO_Type
                           });

                        
                        dbContextTransaction.Commit();
                        Result.Data = new DocumentResponse() { Piece = oF_DOCENTETE.DO_Piece};
                        return Result;
                    }
                    catch (Exception ex)
                    {
                       
                        dbContextTransaction.Rollback();
                        throw;
                    }
                }
            }
            catch (System.Exception ex)
            {
                Log.Fatal(ex, " Insert into commande vente societe {0}  error : {1}", Request.ConnectionName, ex.ToString());
                return await Result<DocumentResponse>.FailAsync(ex);
            }
        }

        
    }
}