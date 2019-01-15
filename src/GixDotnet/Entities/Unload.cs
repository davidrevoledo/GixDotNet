using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public partial class Unload
    {
        /// <summary>
        ///     Cara de porte.
        /// </summary>
        [JsonProperty(PropertyName = "cartaPorte")]
        public int ConsignmentNote { get; set; }

        [JsonProperty(PropertyName = "numeroCEE")]
        public int CEENumber { get; set; }

        [JsonProperty(PropertyName = "fechaCarga")]
        public DateTime? LoadDate { get; set; }

        [JsonProperty(PropertyName = "fechaVencimiento")]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "numeroCTG")]
        public int CGTNumber { get; set; }

        [JsonProperty(PropertyName = "titular")]
        public Actor Owner { get; set; }

        [JsonProperty(PropertyName = "intermediario")]
        public Actor Intermediary { get; set; }

        [JsonProperty(PropertyName = "remitenteComercial")]
        public Actor CommercialSender { get; set; }

        [JsonProperty(PropertyName = "remitenteComercialActuaComoProductor")]
        public bool SenderActingAsProducer { get; set; }

        [JsonProperty(PropertyName = "corredorComprador")]
        public Actor BuyerBroker { get; set; }

        [JsonProperty(PropertyName = "corredorVendedor")]
        public Actor SellerBroker { get; set; }

        [JsonProperty(PropertyName = "mercadoATermino")]
        public Actor Market { get; set; }

        [JsonProperty(PropertyName = "intermediarioFlete")]
        public Actor IntermediaryFreight { get; set; }

        [JsonProperty(PropertyName = "entregador")]
        public Actor Deliverer { get; set; }

        [JsonProperty(PropertyName = "destinatario")]
        public Actor FinalRecipient { get; set; }

        [JsonProperty(PropertyName = "destino")]
        public Place Destiny { get; set; }

        [JsonProperty(PropertyName = "cartransportistataPorte")]
        public Actor Transporter { get; set; }

        [JsonProperty(PropertyName = "chofer")]
        public Actor Driver { get; set; }

        [JsonProperty(PropertyName = "vendedor")]
        public Actor Seller { get; set; }

        [JsonProperty(PropertyName = "comprador")]
        public Actor Buyer { get; set; }

        [JsonProperty(PropertyName = "vendedorTermino")]
        public Actor TermSeller { get; set; }

        [JsonProperty(PropertyName = "compradorTermino")]
        public Actor TermBuyer { get; set; }

        [JsonProperty(PropertyName = "corredorTermino")]
        public Actor TermBroker { get; set; }

        [JsonProperty(PropertyName = "localidadVendedor")]
        public Location SellerLocation { get; set; }

        [JsonProperty(PropertyName = "localidadComprador")]
        public Location BuyerLocation { get; set; }

        [JsonProperty(PropertyName = "procedencia")]
        public Place Origin { get; set; }

        [JsonProperty(PropertyName = "producto")]
        public Product Product { get; set; }

        [JsonProperty(PropertyName = "transporte")]
        public Transport Transport { get; set; }

        [JsonProperty(PropertyName = "numeroContratoVendedor")]
        public string SellerContractNumber { get; set; }

        [JsonProperty(PropertyName = "numeroContratoComprador")]
        public string BuyerContractNumber { get; set; }

        [JsonProperty(PropertyName = "numeroContratoCorredor")]
        public string BrokerContractNumber { get; set; }

        [JsonProperty(PropertyName = "kilosBrutosOrigen")]
        public int GrossOriginKgs { get; set; }

        [JsonProperty(PropertyName = "kilosTaraOrigen")]
        public int TareOriginKgs { get; set; }

        [JsonProperty(PropertyName = "kilosNetoOrigen")]
        public int NetOriginKgs { get; set; }

        [JsonProperty(PropertyName = "observacionesEnCartaPorte")]
        public string ConsignmentNoteObservations { get; set; }

        [JsonProperty(PropertyName = "observacionesGenerales")]
        public string GeneralObservations { get; set; }

        [JsonProperty(PropertyName = "alfanumericoCupo")]
        public string QuotaCode { get; set; }

        [JsonProperty(PropertyName = "kmARecorrer")]
        public int KmsToTravel { get; set; }

        [JsonProperty(PropertyName = "statusCamionEnPuerto")]
        public string PortTruckStatus { get; set; }

        [JsonProperty(PropertyName = "fechaDescarga")]
        public DateTime? DownloadDate { get; set; }

        [JsonProperty(PropertyName = "kilosBrutosDestino")]
        public int GrossDestinyKgs { get; set; }

        [JsonProperty(PropertyName = "kilosTaraDestino")]
        public int TareDestinyKgs { get; set; }

        [JsonProperty(PropertyName = "kilosNetoDestino")]
        public int NetDestinyKgs { get; set; }

        [JsonProperty(PropertyName = "porcentajeHumedad")]
        public double HumidityPercentage { get; set; }

        [JsonProperty(PropertyName = "kilosMermaHumedad")]
        public int DropBecauseHumidityKgs { get; set; }

        [JsonProperty(PropertyName = "kilosMermaCalidad")]
        public int DropBecauseQualityKgs { get; set; }

        [JsonProperty(PropertyName = "kilosMermaVolatil")]
        public int DropBecauseVolatileKgs { get; set; }

        [JsonProperty(PropertyName = "kilosMermaZaranda")]
        public int DropBecauseGroundShakerKgs { get; set; }

        [JsonProperty(PropertyName = "kilosFinalesDescarga")]
        public int DownloadTotalKgs { get; set; }

        [JsonProperty(PropertyName = "kilosConfirmadosDefinitivosCTG")]
        public int ConfirmedCTGKgs { get; set; }

        [JsonProperty(PropertyName = "fechaConfirmacionCTG")]
        public DateTime? CGTConfirmationDate { get; set; }

        [JsonProperty(PropertyName = "conformidad")]
        public string Accordance { get; set; }

        [JsonProperty(PropertyName = "codigoBolsaAnalisisCalidad")]
        public int StockExchangeQualityAnalysisCode { get; set; }

        [JsonProperty(PropertyName = "grado")] public string Grade { get; set; }

        [JsonProperty(PropertyName = "calidad")]
        public IEnumerable<Quality> QualityInformation { get; set; } = new List<Quality>();

        [JsonProperty(PropertyName = "servicios")]
        public IEnumerable<Service> ServiceInformation { get; set; } = new List<Service>();

        [JsonProperty(PropertyName = "biotecnologia")]
        public IEnumerable<BioTechnology> BioTechnologyInformation { get; set; } = new List<BioTechnology>();

        [JsonProperty(PropertyName = "datosAuxiliares")]
        public IEnumerable<AuxiliaryData> AuxiliaryInformation { get; set; } = new List<AuxiliaryData>();
    }
}