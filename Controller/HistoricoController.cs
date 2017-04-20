using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
  public class HistoricoController
  {
    // ver se esse fica
    private static List<Historico> listaHistorico = new List<Historico>();

    // busca todos os HISTORICOS
    public static List<Historico> BuscarTodos()
    {
      using (Contexto ctx = new Contexto())
      {
        return ctx.Historicos.ToList();
      }
    }

    public static void AdicionarHistorico(Historico Historico)
    {
      using (Contexto ctx = new Contexto())
      {
        ctx.Historicos.Add(Historico);
        ctx.SaveChanges();
      }
    }

    public Historico Detalhes(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        return BuscarHistoricoPorID(id,ctx);
      }
    }


    private static Historico BuscarHistoricoPorID(int id, Contexto ctx)
    {
      return ctx.Historicos.Find(id);
    }

    public static void EditarHistorico(int id, Historico novosDadosHistorico)
    {
      using (Contexto ctx = new Contexto())
      {
        Historico dadosAntigosHistorico = BuscarHistoricoPorID(id, ctx);
        if (dadosAntigosHistorico != null)
        {
          dadosAntigosHistorico.Descricao = novosDadosHistorico.Descricao;
          dadosAntigosHistorico.Debcre = novosDadosHistorico.Debcre;
          ctx.Entry(dadosAntigosHistorico).State = System.Data.Entity.EntityState.Modified;
          ctx.SaveChanges();
        }
      }
    }

    public static void ExcluirHistorico(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        Historico a = BuscarHistoricoPorID(id, ctx);
        if (a != null)
        {
          ctx.Entry(a).State = System.Data.Entity.EntityState.Deleted;
          ctx.SaveChanges();
        }
      }
    }
   


  }
}
