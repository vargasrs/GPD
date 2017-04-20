using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
      [Key]
      public int FornecedorID { get; set; }

      [Required(ErrorMessage = "Nome não pode ser branco."), StringLength(50)]
      public string Nome { get; set; }

      [Required, StringLength(01)]
      public string Pessoa { get; set; }

      [Required, StringLength(20)]
      public string Registro { get; set; }
    }
}
