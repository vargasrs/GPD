using Controller;
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
   public partial class frmListagemFornecedor : Form
   {
        public frmListagemFornecedor()
        {
          InitializeComponent();
        }
  
        private void CarregarGridViewFornecedor()
        {
            dgv_fornecedor.DataSource = null;
            FornecedorController forController = new FornecedorController();
            dgv_fornecedor.DataSource = forController.Listar();
        }

      

        private void frmListagemFornecedor_Load(object sender, EventArgs e)
        {
          CarregarGridViewFornecedor();
        }

  

        private void dgv_fornecedor_SelectionChanged(object sender, EventArgs e)
        {
            if(((DataGridView)sender).SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);
                frmCadastroFornecedor cadFornecedor = new frmCadastroFornecedor(idSelecionado);
                cadFornecedor.ShowDialog();
                CarregarGridViewFornecedor();
            }
        }



 }

}
