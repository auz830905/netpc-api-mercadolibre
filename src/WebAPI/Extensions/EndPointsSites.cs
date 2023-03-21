using NETPC.ApiMercadoLibre.Core.Entities;
using NETPC.ApiMercadoLibre.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace NETPC.ApiMercadoLibre.WebAPI.Extensions
{
    public static class EndPointsSites
    {
        public static void AddEndPointsPlayerBalanceExtension(this WebApplication app)
        {
            app.MapGet("/api/getsites", GetSites)
               .WithName("GetSites")
               .WithTags("Categorías y Publicaciones")
               .Produces(StatusCodes.Status400BadRequest)
               .Produces(StatusCodes.Status401Unauthorized)
               .Produces(StatusCodes.Status404NotFound)
               .Produces(StatusCodes.Status500InternalServerError)
               .Produces<Site>(StatusCodes.Status200OK);

            app.MapGet("/api/get_information_domain_by_site_id", GetInfoDomainBySite)
               .WithName("GetInfoDomainBySite")
               .WithTags("Categorías y Publicaciones")
               .Produces(StatusCodes.Status400BadRequest)
               .Produces(StatusCodes.Status401Unauthorized)
               .Produces(StatusCodes.Status404NotFound)
               .Produces(StatusCodes.Status500InternalServerError)
               .Produces<Site>(StatusCodes.Status200OK);

            app.MapGet("/api/get_categories_by_site_id", GetCategoriesBySite)
              .WithName("GetCategoriesBySite")
              .WithTags("Categorías y Publicaciones")
              .Produces(StatusCodes.Status400BadRequest)
              .Produces(StatusCodes.Status401Unauthorized)
              .Produces(StatusCodes.Status404NotFound)
              .Produces(StatusCodes.Status500InternalServerError)
              .Produces<Site>(StatusCodes.Status200OK);

            app.MapGet("/api/get_products_by_category_id", GetProductsByCategoryId)
              .WithName("GetProductsByCategoryId")
              .WithTags("Categorías y Publicaciones")
              .Produces(StatusCodes.Status400BadRequest)
              .Produces(StatusCodes.Status401Unauthorized)
              .Produces(StatusCodes.Status404NotFound)
              .Produces(StatusCodes.Status500InternalServerError)
              .Produces<Site>(StatusCodes.Status200OK);
        }

        //[SwaggerOperation(Summary = "Get player balance by Player Identifier")]
        //[SwaggerResponse(StatusCodes.Status200OK, "Request Successful", typeof(Shared.DTOs.Balance))]
        //[SwaggerResponse(StatusCodes.Status400BadRequest, "Possible errors = {Player not valid. The identifier cannot be a number less than zero.}")]
        //[SwaggerResponse(StatusCodes.Status401Unauthorized, "Possible errors = {Player is disabled}")]
        //[SwaggerResponse(StatusCodes.Status404NotFound, "Possible errors = {Player does not exist}")]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, "Possible errors = {Internal server error}")]
        public static async Task<IResult> GetSites(IUnitOfWork unit) => Results.Ok(await unit.Site.GetAll("/sites"));

        public static async Task<IResult> GetInfoDomainBySite(IUnitOfWork unit, string siteId)
            => Results.Ok(await unit.Domain.GetAll($"/sites/{siteId}/listing_types"));

        public static async Task<IResult> GetCategoriesBySite(IUnitOfWork unit, string siteId)
            => Results.Ok(await unit.Base.GetAll($"/sites/{siteId}/categories"));

        public static async Task<IResult> GetProductsByCategoryId(IUnitOfWork unit, string siteId, string categoryId)
            => Results.Ok(await unit.Category.Get($"/sites/{siteId}/search?category={categoryId}"));

    }
}
