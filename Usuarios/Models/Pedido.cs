﻿namespace Usuarios.Models;

public partial class Pedido
{
    public int NumeroPedido { get; set; }

    public int? IdCliente { get; set; }

    public float? TotalPedido { get; set; }

    public bool? EstadoPedido { get; set; }

    public string? DireccionEnvio { get; set; }

    public DateOnly? FechaPedido { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public string? FormaPago { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }
}
