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
  public partial class frmListagemTituloMovimento : Form
  {
    public frmListagemTituloMovimento()
    {
      InitializeComponent();
    }

    private void CarregarGridViewTituloMovimento()
    {
      dgv_titulomovimento.DataSource = null;
      dgv_titulomovimento.DataSource = TituloMovimentoController.BuscarTodos();
    }

    private void dgv_titulomovimento_SelectionChanged(object sender, EventArgs e)
    {
      if (((DataGridView)sender).SelectedRows.Count > 0)
      {
        int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);
        frmCadastroTituloMovimento cadTituloMovimento = new frmCadastroTituloMovimento(idSelecionado);
        cadTituloMovimento.ShowDialog();
        CarregarGridViewTituloMovimento();
      }
    }

    private void frmListagemTituloMovimento_Load(object sender, EventArgs e)
    {
      CarregarGridViewTituloMovimento();
    }



 }
}
