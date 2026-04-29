using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SamanaFit.Ui.Models;

public partial class Objetivo
{
    [Key]
    public int IdObjetivo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdObjetivoNavigation")]
    public virtual ICollection<Rutina> Rutinas { get; set; } = new List<Rutina>();

    [InverseProperty("IdObjetivoNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
