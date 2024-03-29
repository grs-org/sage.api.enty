﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Uni.Sage.Application.Contrats.Requests;
using Uni.Sage.Application.Contrats.Responses;
using Uni.Sage.Infrastructures.Services;
using Uni.Sage.Shared.Wrapper;

namespace Uni.Sage.Api.Enty.Controllers
{
    public partial class VenteController : BaseController
    {
        private readonly IVenteService _VenteService;

        public VenteController(IVenteService venteService) : base()
        {

            _VenteService = venteService;

        }



        //[HttpPost(nameof(CreateDevis))]

        //public async Task<IResult<List<DocumentResponse>>> CreateDevis(DocEnteteRequest devis)
        //{
        //    var result = await _VenteService.CreateDevis(devis);
        //    return result;
        //}

        [HttpPost(nameof(CreateCommande))]

        public async Task<IResult<DocumentResponse>> CreateCommande(DocEnteteRequest Commande)
        {
            var result = await _VenteService.CreateCommande(Commande);
            return result;
        }





    }
}
