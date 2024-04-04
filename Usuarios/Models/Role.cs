namespace Usuarios.Models;

public partial class Role
{
    public int IdRol { get; set; }

    public string? NombreRol { get; set; }

    public bool? EstadoRol { get; set; }

    public virtual ICollection<PermisosRole> PermisosRoles { get; set; } = new List<PermisosRole>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
