namespace Usuarios.Models;

public partial class FichasTecnica
{
    public int IdFicha { get; set; }

    public string? NombreProducto { get; set; }

    public bool? EstadoFicha { get; set; }

    public string? Talla { get; set; }

    public string? Color { get; set; }

    public virtual ICollection<CatalogoProducto> CatalogoProductos { get; set; } = new List<CatalogoProducto>();

    public virtual ICollection<FichasTecInsumo> FichasTecInsumos { get; set; } = new List<FichasTecInsumo>();

    public virtual ICollection<ProductoTerminado> ProductoTerminados { get; set; } = new List<ProductoTerminado>();
}
