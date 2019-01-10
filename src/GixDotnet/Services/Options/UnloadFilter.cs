using System;
using GixDotnet.Infrastructure.Services;

namespace GixDotnet.Services.Options
{
    /// <summary>
    ///     Params to make a unload get call.
    /// </summary>
    public class UnloadFilter : BaseGetFilter
    {
        public int? ConsignmentNote { get; set; }

        public int? CGTNumber { get; set; }

        public int? BuyerBrokerCUIL { get; set; }

        public int? SellerBrokerCUIL { get; set; }

        public int? BuyerCUIT { get; set; }

        public int? SellerCUIT { get; set; }

        public int? ProductCode { get; set; }

        public string BuyerContractNumber { get; set; }

        public string SellerContractNumber { get; set; }

        public string BrokerContractNumber { get; set; }

        public string QuotaNumber { get; set; }

        public int? DestinyPlantOncaCode { get; set; }

        public DateTime? UnloadDate { get; set; }

        public DateTime? LoadDateStart { get; set; }

        public DateTime? LoadDateEnd { get; set; }

        public string TruckStatusInThePort { get; set; }
    }
}