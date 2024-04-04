namespace Usuarios.Models;

public partial class PermisosRole
{
    public int IdPermisoRol { get; set; }

    public int? IdPermiso { get; set; }

    public int? IdRol { get; set; }

    public virtual Permiso? IdPermisoNavigation { get; set; }

    public virtual Role? IdRolNavigation { get; set; }
}
