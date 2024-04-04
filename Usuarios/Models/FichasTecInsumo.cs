namespace Usuarios.Models;

public partial class FichasTecInsumo
{
    public int IdFichaTecIns { get; set; }

    public int? IdFicha { get; set; }

    public int? IdInsumo { get; set; }

    public int? Cantidad { get; set; }

    public virtual FichasTecnica? IdFichaNavigation { get; set; }

    public virtual Insumo? IdInsumoNavigation { get; set; }
}
