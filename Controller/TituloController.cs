using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
  public class TituloController
  {
    // ver se esse fica
    private static List<Titulo> listaTitulo = new List<Titulo>();

    // busca todos titulos 
    public static List<Titulo> BuscarTodos()
    {
      using (Contexto ctx = new Contexto())
      {
        return ctx.Titulos.ToList();
      }
    }

    public static void AdicionarTitulo(Titulo Titulo)
    {
      using (Contexto ctx = new Contexto())
      {
        ctx.Titulos.Add(Titulo);
        ctx.SaveChanges();
      }
    }
    
    public Titulo Detalhes(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        return BuscarTituloPorID(id, ctx);
      }
    }


    private static Titulo BuscarTituloPorID(int id, Contexto ctx)
    {
      return ctx.Titulos.Find(id);
    }

    public static void EditarTitulo(int id, Titulo novosDadosTitulo)
    {
      using (Contexto ctx = new Contexto())
      {
        Titulo dadosAntigosTitulo = BuscarTituloPorID(id, ctx);
        if (dadosAntigosTitulo != null)
        {
          dadosAntigosTitulo.TituloDoc       = novosDadosTitulo.TituloDoc;
          dadosAntigosTitulo.TituloLetra     = novosDadosTitulo.TituloLetra;
          dadosAntigosTitulo.DataEmissao     = novosDadosTitulo.DataEmissao;
          dadosAntigosTitulo.DataVencto      = novosDadosTitulo.DataVencto;
          dadosAntigosTitulo.DataLiquida     = novosDadosTitulo.DataLiquida;
          dadosAntigosTitulo.VlrTitulo       = novosDadosTitulo.VlrTitulo;
          dadosAntigosTitulo.FornecedorID    = novosDadosTitulo.FornecedorID;
          dadosAntigosTitulo.TipoDocumentoID = novosDadosTitulo.TipoDocumentoID;
          
          ctx.Entry(dadosAntigosTitulo).State = System.Data.Entity.EntityState.Modified;
          ctx.SaveChanges();
        }
      }
    }

    public static void ExcluirTitulo(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        Titulo a = BuscarTituloPorID(id, ctx);
        if (a != null)
        {
          ctx.Entry(a).State = System.Data.Entity.EntityState.Deleted;
          ctx.SaveChanges();
        }
      }
    }












  }
}
