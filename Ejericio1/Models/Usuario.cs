using System;
using System.Collections.Generic;

namespace Ejericio1.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? NombreUsuario { get; set; }

    public string? CorreoElectronico { get; set; }

    public int? Rol { get; set; }

    public virtual Role? RolNavigation { get; set; }
}
