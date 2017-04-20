using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL
{
  public class Contexto : DbContext
  {
    public Contexto() : base("strConn")
    {


    }
    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<Historico> Historicos { get; set; }
    public DbSet<TipoDocumento> TipoDocumentos { get; set; }
    public DbSet<Titulo> Titulos { get; set; }
    public DbSet<TituloMovimento> TituloMovimentos { get; set; }

  }
}
