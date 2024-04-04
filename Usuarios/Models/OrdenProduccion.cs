namespace Usuarios.Models;

public partial class OrdenProduccion
{
    public int NroOrdenProduccion { get; set; }

    public DateOnly? FechaEstimada { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<DetalleOrdenProduccion> DetalleOrdenProduccions { get; set; } = new List<DetalleOrdenProduccion>();
}
