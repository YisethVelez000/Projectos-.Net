namespace Usuarios.Models;

public partial class ComprasInsumo
{
    public int IdCompInsu { get; set; }

    public int? IdCompras { get; set; }

    public int? IdInsumo { get; set; }

    public int? CantidadIns { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Total { get; set; }

    public virtual Compra? IdComprasNavigation { get; set; }

    public virtual Insumo? IdInsumoNavigation { get; set; }
}
