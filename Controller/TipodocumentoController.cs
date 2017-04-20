using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
  public class TipoDocumentoController
  {
    // ver se esse fica
    private static List<TipoDocumento> listaTipodocumento = new List<TipoDocumento>();

    // busca todos os Tipo Documentos 
    public static List<TipoDocumento> BuscarTodos()
    {
      using (Contexto ctx = new Contexto())
      {
        return ctx.TipoDocumentos.ToList();
      }
    }


    public static void AdicionarTipoDocumento(TipoDocumento TipoDocumento)
    {
      using (Contexto ctx = new Contexto())
      {
        ctx.TipoDocumentos.Add(TipoDocumento);
        ctx.SaveChanges();
      }
    }

    public TipoDocumento Detalhes(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        return BuscarTipoDocumentoPorID(id, ctx);
      }
    }
    
    private static TipoDocumento BuscarTipoDocumentoPorID(int id, Contexto ctx)
    {
      return ctx.TipoDocumentos.Find(id);
    }

    public static void EditarTipoDocumento(int id, TipoDocumento novosDadosTipoDocumento)
    {
      using (Contexto ctx = new Contexto())
      {
        TipoDocumento dadosAntigosTipoDocumento = BuscarTipoDocumentoPorID(id, ctx);
        if (dadosAntigosTipoDocumento != null)
        {
          dadosAntigosTipoDocumento.Descricao = novosDadosTipoDocumento.Descricao;
          dadosAntigosTipoDocumento.Sigla     = novosDadosTipoDocumento.Sigla;
          ctx.Entry(dadosAntigosTipoDocumento).State = System.Data.Entity.EntityState.Modified;
          ctx.SaveChanges();
        }
      }
    }

    public static void ExcluirTipoDocumento(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        TipoDocumento a = BuscarTipoDocumentoPorID(id, ctx);
        if (a != null)
        {
          ctx.Entry(a).State = System.Data.Entity.EntityState.Deleted;
          ctx.SaveChanges();
        }
      }
    }

    

  }
}
