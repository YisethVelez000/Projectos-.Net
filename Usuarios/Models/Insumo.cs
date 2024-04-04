namespace Usuarios.Models;

public partial class Insumo
{
    public int IdInsumo { get; set; }

    public string? NombreInsumo { get; set; }

    public double? StockInsumo { get; set; }

    public int? CantidadInsumo { get; set; }

    public string? MedidaInsumo { get; set; }

    public int? StockMinInsumo { get; set; }

    public int? StockMaxInsumo { get; set; }

    public double? ValorInsumo { get; set; }

    public double? Iva { get; set; }

    public bool? EstadoInsumo { get; set; }

    public virtual ICollection<ComprasInsumo> ComprasInsumos { get; set; } = new List<ComprasInsumo>();

    public virtual ICollection<FichasTecInsumo> FichasTecInsumos { get; set; } = new List<FichasTecInsumo>();
}
