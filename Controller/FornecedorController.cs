using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class FornecedorController
    {


        private static List<Fornecedor> listaFornecedor = new List<Fornecedor>();

        public void Adicionar(string nome, string pessoa, string registro)
        {
            Fornecedor frn = new Fornecedor();
            frn.ID = listaFornecedor.Count + 1;
            frn.Nome = nome;
            frn.Pessoa = pessoa;
            frn.Registro = registro;

            listaFornecedor.Add(frn);
        }
     

        private Fornecedor BuscarPorID(int id)
        {
            foreach (Fornecedor frn in listaFornecedor)
            {
                if (frn.ID == id)
                {
                    return frn;
                }
            }
            return null;
        }

        public Fornecedor Detalhes(int id)
        {
            return BuscarPorID(id);
        }

        public void Editar(int id, string novoNome, string novoPessoa, string novoRegistro)
        {
            Fornecedor frn = BuscarPorID(id);

            if(frn != null)
            {
                frn.Nome     = novoNome;
                frn.Pessoa   = novoPessoa;
                frn.Registro = novoRegistro;
            }
        }

        public void Excluir(int id)
        {
            foreach (Fornecedor frn in listaFornecedor)
            {
                if (frn.ID == id)
                {
                    listaFornecedor.Remove(frn);
                    break;
                }
            }
        }

        public List<Fornecedor> Listar()
        {
            return listaFornecedor;
        }


    }
}
