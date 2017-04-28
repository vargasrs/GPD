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
  public partial class frmListagemTitulo : Form
  {
    public frmListagemTitulo()
    {
      InitializeComponent();
    }

    private void CarregarGridViewTitulo()
    {
      // aqui faz leitura na tabela titulor para carregar na grid
      dgv_titulo.DataSource = null;
      dgv_titulo.DataSource = TituloController.BuscarTodos();
    }

    private void dgv_titulo_SelectionChanged(object sender, EventArgs e)
    {
      if (((DataGridView)sender).SelectedRows.Count > 0)
      {
        int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);
        frmCadastroTitulo cadTitulo = new frmCadastroTitulo(idSelecionado);
        cadTitulo.ShowDialog();
        CarregarGridViewTitulo();
      }
    }

    private void frmListagemTitulo_Load(object sender, EventArgs e)
    {
      CarregarGridViewTitulo();
    }
  }
}
