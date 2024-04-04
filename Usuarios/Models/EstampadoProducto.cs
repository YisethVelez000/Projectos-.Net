namespace Usuarios.Models;

public partial class EstampadoProducto
{
    public int IdEstampadoProducto { get; set; }

    public int? IdCatalogoP { get; set; }

    public int? IdEstampado { get; set; }

    public string? Ubicacion { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual CatalogoProducto? IdCatalogoPNavigation { get; set; }
}
