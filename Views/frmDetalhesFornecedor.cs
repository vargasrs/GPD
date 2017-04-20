using Controller;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasPagar
{
 
    public partial class frmDetalhesFornecedor : Form
    {
        public frmDetalhesFornecedor(int clienteID)
        {
            InitializeComponent();

            FornecedorController forController = new FornecedorController();
            Fornecedor fornecedor = forController.Detalhes(clienteID);

            if (fornecedor != null)
            {
                // Preenchendo a tela com os dados do cliente encontrado
                lbl_id.Text       = fornecedor.FornecedorID.ToString();
                lbl_nome.Text     = fornecedor.Nome;
                lbl_pessoa.Text   = fornecedor.Pessoa;
                lbl_registro.Text = fornecedor.Registro;
                this.Show();
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado","Erro");
                this.Close();
            }
        }
    }






}
