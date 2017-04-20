using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  [Table("TituloMovimento")]
  public class TituloMovimento
  {
    [Key]
    public int MovTitID { get; set; }

    [Required]
    public int TituloID { get; set; } // FK de Titulo

    [ForeignKey("TituloID")]
    public virtual Titulo _Titulo { get; set; }

    [StringLength(15)]
    public string DoctoNumero { get; set; }

    [Required]
    public DateTime DataDigitacao { get; set; }

    [Required]
    public DateTime DataContabil { get; set; }

    [Required]
    public int HistoricoID { get; set; }  // FK de Historico

    [ForeignKey("HistoricoID")]
    public virtual Historico _Historico { get; set; }
    
    [Required]
    public Decimal VlrLancto { get; set; }

  }
}


