using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamanaFit.Ui.Models;

[Table("Nivel")]
public partial class Nivel
{
    [Key]
    public int IdNivel { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [InverseProperty("IdNivelNavigation")]
    public virtual ICollection<Ejercicio> Ejercicios { get; set; } = new List<Ejercicio>();

    [InverseProperty("IdNivelNavigation")]
    public virtual ICollection<Rutina> Rutinas { get; set; } = new List<Rutina>();

    [InverseProperty("IdNivelNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
