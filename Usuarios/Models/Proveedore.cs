namespace Usuarios.Models;

public partial class Proveedore
{
    public int IdProveedor { get; set; }

    public string? NombreProv { get; set; }

    public string? NombreContac { get; set; }

    public string? Direccion { get; set; }

    public string? Correo { get; set; }

    public long? Telefono { get; set; }

    public bool? EstadoProv { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
