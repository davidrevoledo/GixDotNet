using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GixDotnet.Infrastructure;
using GixDotnet.Infrastructure.Services;
using GixDotnet.Services.Options;

namespace GixDotnet.Services
{
    /// <summary>
    ///     Services for unload movements methods.
    /// </summary>
    public class UnloadServices : BaseServices
    {
        /// <summary>
        ///     Get unload with multiple params inside the filter.
        /// </summary>
        /// <param name="companyUrl">company urlBuilder</param>
        /// <param name="filter">Request object to get unload movements.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>a collection of unload movements.</returns>
        public Task<string> Get(
            Uri companyUrl,
            UnloadFilter filter,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            Guard.NotNull(companyUrl);
            Guard.NotNull(filter);

            return Execute(async () =>
            {
                var urlBuilder = new GixUrlBuilder()
                    .CompanyUrl(companyUrl)
                    .MayorVersion(filter.Version)
                    .MinorVersion(filter.MinorVersion)
                    .Resource(Urls.GetUnloads);

                TransformUri(urlBuilder, filter);
                var url = urlBuilder.ToString();

                await Task.Delay(1);

                return "";
            }, cancellationToken);
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
                .AddIfHasValue("vendedor.cuit", filter.SellerCUIT) // todo validate vomprador
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