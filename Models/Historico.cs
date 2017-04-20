using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  [Table("Historico")]
  public class Historico
  {
    [Key]
    public int HistoricoID { get; set; }

    [Required, StringLength(30)]
    public string Descricao { get; set; }

    [Required, StringLength(01)]
    public string Debcre { get; set; }
  }
}
