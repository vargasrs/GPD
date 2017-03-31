using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
  public class TipodocumentoController
  {
        private static List<Tipodocumento> listaTipodocumento = new List<Tipodocumento>();

        public void Adicionar(string descricao, string sigla)
        {
            Tipodocumento tdo = new Tipodocumento();
            tdo.ID        = listaTipodocumento.Count + 1;
            tdo.Descricao = descricao;
            tdo.Sigla     = sigla;
           
            listaTipodocumento.Add(tdo);
        }
     

        private Tipodocumento BuscarPorID(int id)
        {
            foreach (Tipodocumento tdo in listaTipodocumento)
            {
                if (tdo.ID == id)
                {
                    return tdo;
                }
            }
            return null;
        }

        public Tipodocumento Detalhes(int id)
        {
            return BuscarPorID(id);
        }

        public void Editar(int id, string novoDescricao, string novoSigla)
        {
            Tipodocumento tdo = BuscarPorID(id);

            if(tdo != null)
            {
                tdo.Descricao = novoDescricao;
                tdo.Sigla     = novoSigla;
            }
        }

        public void Excluir(int id)
        {
            foreach (Tipodocumento tdo in listaTipodocumento)
            {
                if (tdo.ID == id)
                {
                    listaTipodocumento.Remove(tdo);
                }
            }
        }

        public List<Tipodocumento> Listar()
        {
          return listaTipodocumento;
        }



  }
}
