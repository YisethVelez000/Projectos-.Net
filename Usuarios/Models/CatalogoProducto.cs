namespace Usuarios.Models;

public partial class CatalogoProducto
{
    public int IdcatalogoProducto { get; set; }

    public string? NombreProducto { get; set; }

    public int? IdFichaTecnica { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? TipoEstampado { get; set; }

    public string? Color { get; set; }

    public int? Stock { get; set; }

    public string? TamanoEstampado { get; set; }

    public decimal? PrecioProducto { get; set; }

    public string? TipoCatalogo { get; set; }

    public virtual ICollection<EstampadoProducto> EstampadoProductos { get; set; } = new List<EstampadoProducto>();

    public virtual FichasTecnica? IdFichaTecnicaNavigation { get; set; }
}
