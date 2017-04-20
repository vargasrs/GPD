using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  [Table("TipoDocumento")]
  public class TipoDocumento
  {
    [Key]
    public int TipoDocumentoID { get; set; }

    [Required, StringLength(30)]
    public string Descricao { get; set; }

    [Required, StringLength(06)]
    public string Sigla { get; set; }

  }
}
