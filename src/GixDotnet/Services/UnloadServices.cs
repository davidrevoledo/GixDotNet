using System.Collections.Generic;
using System.Threading.Tasks;
using GixDotnet.Entities;
using GixDotnet.Infrastructure;
using GixDotnet.Infrastructure.Http;
using GixDotnet.Infrastructure.Services;
using GixDotnet.Services.Options;

namespace GixDotnet.Services
{
    /// <summary>
    ///     Services for unload movements methods.
    /// </summary>
    internal class UnloadServices : BaseServices
    {
        public UnloadServices()
        {
        }

        public UnloadServices(GixRequestOptions defaultOptions) :base(defaultOptions)
        {
            
        }

        /// <summary>
        ///     Get unload with multiple params inside the filter.
        /// </summary>
        /// <param name="filter">Request object to get unload movements.</param>
        /// <param name="options">options to call the request.</param>
        /// <returns>a collection of unload movements.</returns>
        public async Task<IEnumerable<Unload>> Get(UnloadFilter filter, GixRequestOptions options = null)
        {
            Guard.NotNull(filter);
            var configs = SetupRequestOptions(options);

            var urlBuilder = new GixUrlBuilder()
                .CompanyUrl(configs.BaseUrl)
                .MayorVersion(filter.Version)
                .Resource(Urls.GetUnloads);

            TransformUri(urlBuilder, filter);
            var url = urlBuilder.ToString();

            var unloadMovements =
                await Requestor.GetStringAsync<IEnumerable<Unload>>(url, configs)
                    .ConfigureAwait(false);

            return unloadMovements.Data;
        }

        private static void TransformUri(GixUrlBuilder urlBuilder, UnloadFilter filter)
        {
            var urlParams = BaseUrlParams.Create();

            urlParams.Add("page", filter.Page.ToString());
            urlParams
                .AddIfHasValue("cartaPorte", filter.ConsignmentNote)
                .AddIfHasValue("numeroCTG", filter.CGTNumber)
                .AddIfHasValue("corredorComprador", filter.SellerBrokerCUIL)
                .AddIfHasValue("corredorVendedor.cuit", filter.SellerBrokerCUIL)
                .AddIfHasValue("vendedor.cuit", filter.SellerCUIT)
                .AddIfHasValue("comprador.cuitfilter", filter.BuyerCUIT)
                .AddIfHasValue("producto.codigo", filter.ProductCode)
                .AddIfNotNullOrEmpty("numeroContratoComprador", filter.BuyerContractNumber)
                .AddIfNotNullOrEmpty("numeroContratoVendedor", filter.BuyerContractNumber)
                .AddIfNotNullOrEmpty("numeroContratoCorredor", filter.BrokerContractNumber)
                .AddIfNotNullOrEmpty("alfanumericoCupo", filter.QuotaNumber)
                .AddIfHasValue("destino.codigoPlantaOncca", filter.DestinyPlantOncaCode)
                .AddIfHasValue("fechaDescarga", filter.UnloadDate)
                .AddIfHasValue("fechaCargaDesde", filter.LoadDateStart)
                .AddIfHasValue("fechaCargaHasta", filter.LoadDateEnd)
                .AddIfNotNullOrEmpty("statusCamionEnPuerto", filter.TruckStatusInThePort)
                ;

            urlBuilder.Filters(urlParams);
        }
    }
}