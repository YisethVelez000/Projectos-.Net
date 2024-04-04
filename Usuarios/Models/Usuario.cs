namespace Usuarios.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NombreCompleto { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Contrasena { get; set; }

    public int? IdRol { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual Role? IdRolNavigation { get; set; }
}
