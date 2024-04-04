namespace Usuarios.Models;

public partial class ProductoTerminado
{
    public int IdProductoTerminado { get; set; }

    public int? IdFichaTec { get; set; }

    public int? IdEstampado { get; set; }

    public string? TipoEstampado { get; set; }

    public virtual FichasTecnica? IdFichaTecNavigation { get; set; }
}
