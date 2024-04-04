namespace Usuarios.Models;

public partial class PrivegioPermiso
{
    public int IdPriPer { get; set; }

    public int? IdPermiso { get; set; }

    public int? IdPrivilegio { get; set; }

    public virtual Permiso? IdPermisoNavigation { get; set; }

    public virtual Privilegio? IdPrivilegioNavigation { get; set; }
}
