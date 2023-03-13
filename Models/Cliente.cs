using System;
using System.Collections.Generic;

namespace Creditos.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoP { get; set; }

    public string? ApellidoM { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public DateTime? Fecha { get; set; }

    public short? DiaCobro { get; set; }

    public int? Mes { get; set; }

    public short? Intereses { get; set; }
}
