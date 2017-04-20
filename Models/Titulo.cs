using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  [Table("Titulo")]
  public class Titulo
  {
    [Key]
    public int TituloID { get; set; }

    [StringLength(15)]
    public string TituloDoc { get; set; }

    [StringLength(01)]
    public string TituloLetra { get; set; }

    [Required]
    public DateTime DataEmissao { get; set; }

    [Required]
    public DateTime DataVencto { get; set; }

    [Required]
    public DateTime DataLiquida { get; set; }

    [Required]
    public Decimal VlrTitulo { get; set; }

    [Required]
    public int TipoDocumentoID { get; set; }  // FK de TipoDocumento
    [ForeignKey("TipoDocumentoID")]
    // aqui facilita o carregamento. Faz carregamento lazy load
    // ao carregar o titulo carrega junto o fornecedor do titulo
    public virtual TipoDocumento _TipoDocumento { get; set; }
    
    [Required]
    public int FornecedorID { get; set; }  // FK de Fornecedor
    [ForeignKey("FornecedorID")]
    public virtual Fornecedor _Fornecedor { get; set; }

  }
}
