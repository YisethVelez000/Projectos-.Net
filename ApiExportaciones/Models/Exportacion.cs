namespace ApiExportacion.Models
{
    public class Exportacion
    {
        public Guid ProductoId { get; set;}
        public string ProductoNombre { get; set;}

        public decimal Kilos {get; set;}
        public decimal PrecioKilo {get; set;}

        public decimal PrecioDolar {get; set;}
    }
}
