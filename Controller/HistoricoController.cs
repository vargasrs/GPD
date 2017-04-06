using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
  public class HistoricoController
  {
    private static List<Historico> listaHistorico = new List<Historico>();

    public void Adicionar(string descricao, string debcre)
    {
      Historico his = new Historico();
      his.ID = listaHistorico.Count + 1;
      his.Descricao = descricao;
      his.Debcre = debcre;
      listaHistorico.Add(his);
    }


    private Historico BuscarPorID(int id)
    {
      foreach (Historico his in listaHistorico)
      {
        if (his.ID == id)
        {
          return his;
        }
      }
      return null;
    }

    public Historico Detalhes(int id)
    {
      return BuscarPorID(id);
    }

    public void Editar(int id, string novoDescricao, string novoDebcre)
    {
      Historico his = BuscarPorID(id);

      if (his != null)
      {
        his.Descricao = novoDescricao;
        his.Debcre    = novoDebcre;
      }
    }

    public void Excluir(int id)
    {
      foreach (Historico his in listaHistorico)
      {
        if (his.ID == id)
        {
          listaHistorico.Remove(his);
          break;
        }
      }
    }

    public List<Historico> Listar()
    {
      return listaHistorico;
    }


  }
}
