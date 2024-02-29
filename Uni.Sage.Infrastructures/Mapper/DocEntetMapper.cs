using Uni.Sage.Application.Contrats.Requests;
using Uni.Sage.Application.Contrats.Responses;
using Uni.Sage.Domain.Entities;
using Uni.Sage.Shared.Extention;

namespace Uni.Sage.Infrastructures.Mapper
{
    public class DocEntetMapper
    {
        public static DocEnteteResponse Adapts(F_DOCENTETE f_DOCENTETE)
        {
            var result = new DocEnteteResponse();
            //    result.Affaire = f_DOCENTETE.CA_Num;
            //    result.Commentaires = "CHAMP LIBRE";
            //    result.Representant = f_DOCENTETE.CO_No;
            //    result.NumeroDocument = f_DOCENTETE.DO_Piece;
            //    result.CategorieTarifaire = f_DOCENTETE.DO_Tarif;
            //    result.CodeDepot = f_DOCENTETE.DE_No;
            //    result.CodeTiers = f_DOCENTETE.DO_Tiers;
            //    result.Date = f_DOCENTETE.DO_Date;
            //    result.Devise = f_DOCENTETE.DO_Devise.ToString();
            //    result.Entete1 = f_DOCENTETE.DO_Coord01;
            //    result.Entete2 = f_DOCENTETE.DO_Coord02;
            //    result.Entete3 = f_DOCENTETE.DO_Coord03;
            //    result.Entete4 = f_DOCENTETE.DO_Coord04;
            //    result.Reference = f_DOCENTETE.DO_Ref;
            // result.DocLignes =
            //var oLignes = f_DOCENTETE.

            return result;
        }

        public static F_DOCENTETE Adapt(DocEnteteRequest Request, short doDomaine, short doType)
        {
            //using var db = _QueryService.NewDbConnection(Request.ConnectionName);
            var result = new F_DOCENTETE();
            result.DO_Type = doType;
            result.DO_DocType = doType;
            result.DO_Domaine = doDomaine;
            result.DO_Date = Request.Date.OnlyDate();
            //result.DO_Piece = Request.NumeroDocument;
            result.DO_Ref = Request.Reference;
            //result.DO_Tiers = Request.CodeTiers;
            //result.CO_No = Request.CodeRepresentant;
            //result.DE_No = Request.CodeDepot;
            result.cbDE_No =result.DE_No;
            result.CT_NumPayeur = "C00001";
            //result.CA_Num = Request.ReferenceAffaire;
            //result.DO_Coord01 = Request.Entete1;
            //result.DO_Coord02 = Request.Entete2;
            //result.DO_Coord03 = Request.Entete3;
            //result.DO_Coord04 = Request.Entete4;
            //result.DO_Statut = (short)Request.Status;
            //result.DO_Tarif =(short)Request.CodeCategorieTarifaire;

            for (int i = 0; i < Request.DocLignes.Count; i++)
            {
                var oLine = Request.DocLignes[i];
                F_DOCLIGNE docligne = new F_DOCLIGNE();
                docligne.DO_Domaine = doDomaine;
                docligne.DO_Type = doType;
                //docligne.CT_Num = Request.CodeTiers;
                //docligne.DO_Piece = Request.NumeroDocument;
                docligne.DO_Date = result.DO_Date;

                docligne.DL_Ligne = (i + 1) * 1000;
                docligne.DO_Ref = Request.Reference;
                //docligne.CA_Num = Request.ReferenceAffaire;
                //docligne.CO_No = Request.CodeRepresentant;
                //docligne.DE_No = Request.CodeDepot;
                docligne.AR_Ref = oLine.Reference;
                docligne.DL_Design = oLine.Designation;
                docligne.DL_Qte = oLine.Quantite;
                //docligne.DL_QteBL = oLine.Quantite;
                docligne.DL_QtePL = oLine.Quantite;
                docligne.EU_Qte = oLine.Quantite;
                //if (oLine.Remise != 0 )
                //{
                //    docligne.DL_Remise01REM_Valeur = oLine.Remise*100;
                //    docligne.DL_Remise01REM_Type=1;
                //}
                
                //docligne.AG_No1 = oLine.CodeGamme1;
                //docligne.AG_No2 = oLine.CodeGamme2;
                //if (oLine.IsTTC)
                //{
                    
                    docligne.DL_PUTTC = oLine.Prix;
                    docligne.DL_TTC = 1;
                //}
                //else
                //{
                //    docligne.DL_PrixUnitaire = oLine.Prix;
                //    docligne.DL_TTC = 0;
                //}

                if (doType == 1)
                {
                    docligne.DL_DateBC = result.DO_Date;
                    docligne.DL_QteBC = oLine.Quantite;

                    docligne.DL_DateDE = result.DO_Date;
                    docligne.DL_QteDE = oLine.Quantite;
                    docligne.DL_MvtStock= 0;
                }

                docligne.DO_DocType = doType;
                docligne.DL_MontantTTC = oLine.MontantTTC;
                result.F_DOCLIGNEs.Add(docligne);
            }
            return result;
        }
    }
}