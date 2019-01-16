using System;
using System.Collections.Generic;

namespace GixDotnet.Entities
{
    public class Contract
    {
        public Comprador comprador { get; set; }
        public Vendedor vendedor { get; set; }
        public Corredor corredor { get; set; }
        public int codigoActividadComprador { get; set; }
        public int codigoActividadVendedor { get; set; }
        public Procedencia procedencia { get; set; }
        public Destino destino { get; set; }
        public Producto producto { get; set; }
        public int codigoBolsa { get; set; }
        public int numeroRegistroBolsa { get; set; }
        public DateTime fechaConcertacion { get; set; }
        public DateTime fechaRegistracion { get; set; }
        public DateTime fechaInstrumentacion { get; set; }
        public DateTime fechaPresentacion { get; set; }
        public DateTime fechaFacturacion { get; set; }
        public DateTime fechaDisponibleAFacturar { get; set; }
        public object fechaAnulacion { get; set; }
        public string numeroContratoComprador { get; set; }
        public string numeroContratoVendedor { get; set; }
        public string numeroContratoCorredor { get; set; }
        public string codigoUnidadMedida { get; set; }
        public int cantidadDesde { get; set; }
        public int cantidadHasta { get; set; }
        public int codigoAjuste { get; set; }
        public int cantidadCamiones { get; set; }
        public string codigoMedioTransporte { get; set; }
        public int codigoAPrecio { get; set; }
        public int codigoTipoContrato { get; set; }
        public int codigoTipoOperacion { get; set; }
        public object codigoOperatoria { get; set; }
        public object codigoOperatoriaOriginal { get; set; }
        public int codigoMercaderiaOperacionPropia { get; set; }
        public int codigoModalidadOperacion { get; set; }
        public int codigoEsCompradorFinal { get; set; }
        public double porcentajeMercaderiaParcial { get; set; }
        public DateTime fechaEntregaDesde { get; set; }
        public DateTime fechaEntregaHasta { get; set; }
        public int codigoCondicionPago { get; set; }
        public int codigoOpcionFijacion { get; set; }
        public int precio { get; set; }
        public int codigoMoneda { get; set; }
        public int fechaConvenidaPago { get; set; }
        public int cantidadFijacionMinima { get; set; }
        public int cantidadFijacionMaxima { get; set; }
        public string codigoUnidadMedidaFijacion { get; set; }
        public int codigoFijacionPeriodo { get; set; }
        public DateTime fechaFijacionDesde { get; set; }
        public DateTime fechaFijacionHasta { get; set; }
        public int codigoRegistracionAFIP { get; set; }
        public object codigoEstadoContrato { get; set; }
        public string observaciones { get; set; }
        public IEnumerable<DatosAuxiliare> datosAuxiliares { get; set; } = new List<DatosAuxiliare>();
    }
}