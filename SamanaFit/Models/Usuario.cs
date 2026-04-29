using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SamanaFit.Ui.Models;

public partial class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    public int? Edad { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Peso { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Altura { get; set; }

    public int? IdNivel { get; set; }

    public int? IdObjetivo { get; set; }

    public int? IdSexo { get; set; }

    [ForeignKey("IdNivel")]
    [InverseProperty("Usuarios")]
    public virtual Nivel? IdNivelNavigation { get; set; }

    [ForeignKey("IdObjetivo")]
    [InverseProperty("Usuarios")]
    public virtual Objetivo? IdObjetivoNavigation { get; set; }

    [ForeignKey("IdSexo")]
    [InverseProperty("Usuarios")]
    public virtual Sexo? IdSexoNavigation { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Rutina> Rutinas { get; set; } = new List<Rutina>();
}
