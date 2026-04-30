using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamanaFit.Ui.Models;

public partial class Ejercicio
{
    [Key]
    public int IdEjercicio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GrupoMuscular { get; set; }

    public int? IdNivel { get; set; }

    public int? DuracionMinutos { get; set; }

    public int? CaloriasQuemadas { get; set; }

    [StringLength(255)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdEjercicioNavigation")]
    public virtual ICollection<DetalleRutina> DetalleRutinas { get; set; } = new List<DetalleRutina>();

    [ForeignKey("IdNivel")]
    [InverseProperty("Ejercicios")]
    public virtual Nivel? IdNivelNavigation { get; set; }
}
