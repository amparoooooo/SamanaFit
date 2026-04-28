using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SamanaFit.Data.Models;

[Table("Sexo")]
[Index("Nombre", Name = "UQ_Sexo_Nombre", IsUnique = true)]
public partial class Sexo
{
    [Key]
    public int IdSexo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("IdSexoNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
