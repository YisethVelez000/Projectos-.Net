namespace Usuarios.Models;

public partial class Privilegio
{
    public int IdPrivilegio { get; set; }

    public string? NombrePrivilegio { get; set; }

    public virtual ICollection<PrivegioPermiso> PrivegioPermisos { get; set; } = new List<PrivegioPermiso>();
}
