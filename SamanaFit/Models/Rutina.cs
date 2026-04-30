using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamanaFit.Ui.Models;

public partial class Rutina
{
    [Key]
    public int IdRutina { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdObjetivo { get; set; }

    public int? IdNivel { get; set; }

    public int? DuracionSemanas { get; set; }

    [StringLength(255)]
    public string? Observaciones { get; set; }

    [InverseProperty("IdRutinaNavigation")]
    public virtual ICollection<DetalleRutina> DetalleRutinas { get; set; } = new List<DetalleRutina>();

    [ForeignKey("IdNivel")]
    [InverseProperty("Rutinas")]
    public virtual Nivel? IdNivelNavigation { get; set; }

    [ForeignKey("IdObjetivo")]
    [InverseProperty("Rutinas")]
    public virtual Objetivo? IdObjetivoNavigation { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("Rutinas")]
    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
