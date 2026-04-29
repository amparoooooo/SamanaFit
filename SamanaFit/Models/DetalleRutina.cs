using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SamanaFit.Ui.Models;

[Table("DetalleRutina")]
public partial class DetalleRutina
{
    [Key]
    public int IdDetalle { get; set; }

    public int? IdRutina { get; set; }

    public int? IdEjercicio { get; set; }

    public int? Series { get; set; }

    public int? Repeticiones { get; set; }

    public int? Descanso { get; set; }

    [ForeignKey("IdEjercicio")]
    [InverseProperty("DetalleRutinas")]
    public virtual Ejercicio? IdEjercicioNavigation { get; set; }

    [ForeignKey("IdRutina")]
    [InverseProperty("DetalleRutinas")]
    public virtual Rutina? IdRutinaNavigation { get; set; }
}
