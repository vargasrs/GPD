using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
  public class FornecedorController
  {
    // ver se esse fica
    private static List<Fornecedor> listaFornecedor = new List<Fornecedor>();
    
    // busca todos os fornecedores 
    public static List<Fornecedor> BuscarTodos()
    {
      using (Contexto ctx = new Contexto())
      {
        return ctx.Fornecedores.ToList();
      }
    }

    public static void AdicionarFornecedor(Fornecedor fornecedor)
    {
      using (Contexto ctx = new Contexto())
      {
        ctx.Fornecedores.Add(fornecedor);
        ctx.SaveChanges();
      }
    }
    
    public Fornecedor Detalhes(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        return BuscarFornecedorPorID(id,ctx);
      }
    }

    private static Fornecedor BuscarFornecedorPorID(int id, Contexto ctx)
    {
      return ctx.Fornecedores.Find(id);
    }


    public static void EditarFornecedor(int id, Fornecedor novosDadosFornecedor)
    {
      using (Contexto ctx = new Contexto())
      {
        Fornecedor dadosAntigosFornecedor = BuscarFornecedorPorID(id, ctx);
        if (dadosAntigosFornecedor != null)
        {
          dadosAntigosFornecedor.Nome = novosDadosFornecedor.Nome;
          dadosAntigosFornecedor.Pessoa = novosDadosFornecedor.Pessoa;
          dadosAntigosFornecedor.Registro = novosDadosFornecedor.Registro;
          ctx.Entry(dadosAntigosFornecedor).State = System.Data.Entity.EntityState.Modified;
          ctx.SaveChanges();
        }
      }
    }

    public static void ExcluirFornecedor(int id)
    {
      using (Contexto ctx = new Contexto())
      {
        Fornecedor a = BuscarFornecedorPorID(id, ctx);
        if (a != null)
        {
          ctx.Entry(a).State = System.Data.Entity.EntityState.Deleted;
          ctx.SaveChanges();
        }
      }
    }


    


  }
}
