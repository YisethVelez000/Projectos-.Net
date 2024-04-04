namespace Usuarios.Models;

public partial class DetalleOrdenProduccion
{
    public int IdDetalleOrdenProduccion { get; set; }

    public int? NroOrdenProduccion { get; set; }

    public string? Tallas { get; set; }

    public string? Productos { get; set; }

    public int? Cantidad { get; set; }

    public virtual OrdenProduccion? NroOrdenProduccionNavigation { get; set; }
}
