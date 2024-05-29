using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Restaurante.Models;

public partial class Libro
{
    public int Id { get; set; }
    [DisplayName("Nombre del libro")]
    public string? NombreLibro { get; set; }

    public string? Autor { get; set; }

    public DateOnly? Fecha { get; set; }
}
