using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
  public class TituloMovimentoController
  {
    // ver se esse fica
    private static List<TituloMovimento> listaTituloMovimento = new List<TituloMovimento>();

    // busca todos movimentos titulos 
    public static List<TituloMovimento> BuscarTodos()
    {
      using (Contexto ctx = new Contexto())
      {
        return ctx.TituloMovimentos.ToList();
      }
    }

    public static void AdicionarTituloMovimento(TituloMovimento TituloMovimento)
    {
      using (Contexto ctx = new Contexto())
      {
        ctx.TituloMovimentos.Add(TituloMovimento);
        ctx.SaveChanges();
      }
    }

    public TituloMovimento Detalhes(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        return BuscarTituloMovimentoPorID(id,ctx);
      }
    }

    private static TituloMovimento BuscarTituloMovimentoPorID(int id, Contexto ctx)
    {
      return ctx.TituloMovimentos.Find(id);
    }

    public static void EditarTituloMovimento(int id, TituloMovimento novosDadosTituloMovimento)
    {
      using (Contexto ctx = new Contexto())
      {
        TituloMovimento dadosAntigosTituloMovimento = BuscarTituloMovimentoPorID(id, ctx);
        if (dadosAntigosTituloMovimento != null)
        {
          dadosAntigosTituloMovimento.TituloID      = novosDadosTituloMovimento.TituloID;
          dadosAntigosTituloMovimento.DoctoNumero   = novosDadosTituloMovimento.DoctoNumero;
          dadosAntigosTituloMovimento.DataDigitacao = novosDadosTituloMovimento.DataDigitacao;
          dadosAntigosTituloMovimento.DataContabil  = novosDadosTituloMovimento.DataContabil;
          dadosAntigosTituloMovimento.HistoricoID   = novosDadosTituloMovimento.HistoricoID;
          dadosAntigosTituloMovimento.VlrLancto     = novosDadosTituloMovimento.VlrLancto;
          ctx.Entry(dadosAntigosTituloMovimento).State = System.Data.Entity.EntityState.Modified;
          ctx.SaveChanges();
        }
      }
    }

    public static void ExcluirTituloMovimento(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        TituloMovimento a = BuscarTituloMovimentoPorID(id, ctx);
        if (a != null)
        {
          ctx.Entry(a).State = System.Data.Entity.EntityState.Deleted;
          ctx.SaveChanges();
        }
      }
    }





  }
}
