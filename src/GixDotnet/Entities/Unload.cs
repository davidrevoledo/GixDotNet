using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public partial class Unload
    {
        /// <summary>
        ///    Number of the principal document to transport commodity.
        ///    translate: Cara de porte.
        /// </summary>
        [JsonProperty(PropertyName = "cartaPorte")]
        public int ConsignmentNote { get; set; }

        /// <summary>
        ///     translate: CCE numero.
        /// </summary>
        [JsonProperty(PropertyName = "numeroCEE")]
        public int CEENumber { get; set; }

        /// <summary>
        ///    translate:  Fecha de carga.
        /// </summary>
        [JsonProperty(PropertyName = "fechaCarga")]
        public DateTime? LoadDate { get; set; }

        /// <summary>
        ///    translate: Fecha de vencimiento.
        /// </summary>
        [JsonProperty(PropertyName = "fechaVencimiento")]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        ///     translate: Codigo de CGT (Mainly transport labor union in Argentina).
        /// </summary>
        [JsonProperty(PropertyName = "numeroCTG")]
        public int CGTNumber { get; set; }

        /// <summary>
        ///     translate: Titular.
        /// </summary>
        [JsonProperty(PropertyName = "titular")]
        public Actor Owner { get; set; }

        /// <summary>
        ///     translate: Intermediario.
        /// </summary>
        [JsonProperty(PropertyName = "intermediario")]
        public Actor Intermediary { get; set; }

        /// <summary>
        ///     translate: Remitente Comercial.
        /// </summary>
        [JsonProperty(PropertyName = "remitenteComercial")]
        public Actor CommercialSender { get; set; }

        /// <summary>
        ///     translate: remitenteComercialActuaComoProductor.
        /// </summary>
        [JsonProperty(PropertyName = "remitenteComercialActuaComoProductor")]
        public bool SenderActingAsProducer { get; set; }

        /// <summary>
        ///     translate: corredorComprador.
        /// </summary>
        [JsonProperty(PropertyName = "corredorComprador")]
        public Actor BuyerBroker { get; set; }

        /// <summary>
        ///     translate: corredorVendedor.
        /// </summary>
        [JsonProperty(PropertyName = "corredorVendedor")]
        public Actor SellerBroker { get; set; }

        /// <summary>
        ///     translate: mercadoATermino.
        /// </summary>
        [JsonProperty(PropertyName = "mercadoATermino")]
        public Actor Market { get; set; }

        /// <summary>
        ///     translate: intermediarioFlete.
        /// </summary>
        [JsonProperty(PropertyName = "intermediarioFlete")]
        public Actor IntermediaryFreight { get; set; }

        /// <summary>
        ///     translate: entregador.
        /// </summary>
        [JsonProperty(PropertyName = "entregador")]
        public Actor Deliverer { get; set; }

        /// <summary>
        ///     translate: destinatario.
        /// </summary>
        [JsonProperty(PropertyName = "destinatario")]
        public Actor FinalRecipient { get; set; }

        /// <summary>
        ///     translate: destino.
        /// </summary>
        [JsonProperty(PropertyName = "destino")]
        public Place Destiny { get; set; }

        /// <summary>
        ///     translate: cartransportistataPorte.
        /// </summary>
        [JsonProperty(PropertyName = "cartransportistataPorte")]
        public Actor Transporter { get; set; }

        /// <summary>
        ///     translate: chofer.
        /// </summary>
        [JsonProperty(PropertyName = "chofer")]
        public Actor Driver { get; set; }

        /// <summary>
        ///     translate: vendedor.
        /// </summary>
        [JsonProperty(PropertyName = "vendedor")]
        public Actor Seller { get; set; }

        /// <summary>
        ///     translate: comprador.
        /// </summary>
        [JsonProperty(PropertyName = "comprador")]
        public Actor Buyer { get; set; }

        /// <summary>
        ///     translate: vendedorTermino.
        /// </summary>
        [JsonProperty(PropertyName = "vendedorTermino")]
        public Actor TermSeller { get; set; }

        /// <summary>
        ///     translate: compradorTermino.
        /// </summary>
        [JsonProperty(PropertyName = "compradorTermino")]
        public Actor TermBuyer { get; set; }

        /// <summary>
        ///     translate: corredorTermino.
        /// </summary>
        [JsonProperty(PropertyName = "corredorTermino")]
        public Actor TermBroker { get; set; }

        /// <summary>
        ///     translate: localidadVendedor.
        /// </summary>
        [JsonProperty(PropertyName = "localidadVendedor")]
        public Location SellerLocation { get; set; }

        /// <summary>
        ///     translate: localidadComprador.
        /// </summary>
        [JsonProperty(PropertyName = "localidadComprador")]
        public Location BuyerLocation { get; set; }

        /// <summary>
        ///     translate: procedencia.
        /// </summary>
        [JsonProperty(PropertyName = "procedencia")]
        public Place Origin { get; set; }

        /// <summary>
        ///     translate: producto.
        /// </summary>
        [JsonProperty(PropertyName = "producto")]
        public Product Product { get; set; }

        /// <summary>
        ///     translate: transporte.
        /// </summary>
        [JsonProperty(PropertyName = "transporte")]
        public Transport Transport { get; set; }

        /// <summary>
        ///     translate: numeroContratoVendedor.
        /// </summary>
        [JsonProperty(PropertyName = "numeroContratoVendedor")]
        public string SellerContractNumber { get; set; }

        /// <summary>
        ///     translate: numeroContratoComprador.
        /// </summary>
        [JsonProperty(PropertyName = "numeroContratoComprador")]
        public string BuyerContractNumber { get; set; }

        /// <summary>
        ///     translate: numeroContratoCorredor.
        /// </summary>
        [JsonProperty(PropertyName = "numeroContratoCorredor")]
        public string BrokerContractNumber { get; set; }

        /// <summary>
        ///     translate: kilosBrutosOrigen.
        /// </summary>
        [JsonProperty(PropertyName = "kilosBrutosOrigen")]
        public int GrossOriginKgs { get; set; }

        /// <summary>
        ///     translate: kilosTaraOrigen.
        /// </summary>
        [JsonProperty(PropertyName = "kilosTaraOrigen")]
        public int TareOriginKgs { get; set; }

        /// <summary>
        ///     translate: kilosNetoOrigen.
        /// </summary>
        [JsonProperty(PropertyName = "kilosNetoOrigen")]
        public int NetOriginKgs { get; set; }

        /// <summary>
        ///     translate: observacionesEnCartaPorte.
        /// </summary>
        [JsonProperty(PropertyName = "observacionesEnCartaPorte")]
        public string ConsignmentNoteObservations { get; set; }

        /// <summary>
        ///     translate: observacionesGenerales.
        /// </summary>
        [JsonProperty(PropertyName = "observacionesGenerales")]
        public string GeneralObservations { get; set; }

        /// <summary>
        ///     translate: alfanumericoCupo.
        /// </summary>
        [JsonProperty(PropertyName = "alfanumericoCupo")]
        public string QuotaCode { get; set; }

        /// <summary>
        ///     translate: kmARecorrer.
        /// </summary>
        [JsonProperty(PropertyName = "kmARecorrer")]
        public int KmsToTravel { get; set; }

        /// <summary>
        ///     translate: statusCamionEnPuerto.
        /// </summary>
        [JsonProperty(PropertyName = "statusCamionEnPuerto")]
        public string PortTruckStatus { get; set; }

        /// <summary>
        ///     translate: fechaDescarga.
        /// </summary>
        [JsonProperty(PropertyName = "fechaDescarga")]
        public DateTime? DownloadDate { get; set; }

        /// <summary>
        ///     translate: kilosBrutosDestino.
        /// </summary>
        [JsonProperty(PropertyName = "kilosBrutosDestino")]
        public int GrossDestinyKgs { get; set; }

        /// <summary>
        ///     translate: kilosTaraDestino.
        /// </summary>
        [JsonProperty(PropertyName = "kilosTaraDestino")]
        public int TareDestinyKgs { get; set; }

        /// <summary>
        ///     translate: kilosNetoDestino.
        /// </summary>
        [JsonProperty(PropertyName = "kilosNetoDestino")]
        public int NetDestinyKgs { get; set; }

        /// <summary>
        ///     translate: porcentajeHumedad.
        /// </summary>
        [JsonProperty(PropertyName = "porcentajeHumedad")]
        public double HumidityPercentage { get; set; }

        /// <summary>
        ///     translate: kilosMermaHumedad.
        /// </summary>
        [JsonProperty(PropertyName = "kilosMermaHumedad")]
        public int DropBecauseHumidityKgs { get; set; }

        /// <summary>
        ///     translate: kilosMermaCalidad.
        /// </summary>
        [JsonProperty(PropertyName = "kilosMermaCalidad")]
        public int DropBecauseQualityKgs { get; set; }

        /// <summary>
        ///     translate: kilosMermaVolatil.
        /// </summary>
        [JsonProperty(PropertyName = "kilosMermaVolatil")]
        public int DropBecauseVolatileKgs { get; set; }

        /// <summary>
        ///     translate: kilosMermaZaranda.
        /// </summary>
        [JsonProperty(PropertyName = "kilosMermaZaranda")]
        public int DropBecauseGroundShakerKgs { get; set; }

        /// <summary>
        ///     translate: kilosFinalesDescarga.
        /// </summary>
        [JsonProperty(PropertyName = "kilosFinalesDescarga")]
        public int DownloadTotalKgs { get; set; }

        /// <summary>
        ///     translate: kilosConfirmadosDefinitivosCTG.
        /// </summary>
        [JsonProperty(PropertyName = "kilosConfirmadosDefinitivosCTG")]
        public int ConfirmedCTGKgs { get; set; }

        /// <summary>
        ///     translate: fechaConfirmacionCTG.
        /// </summary>
        [JsonProperty(PropertyName = "fechaConfirmacionCTG")]
        public DateTime? CGTConfirmationDate { get; set; }

        /// <summary>
        ///     translate: conformidad.
        /// </summary>
        [JsonProperty(PropertyName = "conformidad")]
        public string Accordance { get; set; }

        /// <summary>
        ///     translate: codigoBolsaAnalisisCalidad.
        /// </summary>
        [JsonProperty(PropertyName = "codigoBolsaAnalisisCalidad")]
        public int StockExchangeQualityAnalysisCode { get; set; }

        /// <summary>
        ///     translate: grado.
        /// </summary>
        [JsonProperty(PropertyName = "grado")]
        public string Grade { get; set; }

        /// <summary>
        ///     translate: calidad.
        /// </summary>
        [JsonProperty(PropertyName = "calidad")]
        public IEnumerable<Quality> QualityInformation { get; set; } = new List<Quality>();

        /// <summary>
        ///     translate: servicios.
        /// </summary>
        [JsonProperty(PropertyName = "servicios")]
        public IEnumerable<Service> ServiceInformation { get; set; } = new List<Service>();

        /// <summary>
        ///     translate: biotecnologia.
        /// </summary>
        [JsonProperty(PropertyName = "biotecnologia")]
        public IEnumerable<BioTechnology> BioTechnologyInformation { get; set; } = new List<BioTechnology>();

        /// <summary>
        ///     translate: datosAuxiliares.
        /// </summary>
        [JsonProperty(PropertyName = "datosAuxiliares")]
        public IEnumerable<AuxiliaryData> AuxiliaryInformation { get; set; } = new List<AuxiliaryData>();
    }
}