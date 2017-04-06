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
  public partial class frmListagemHistorico : Form
  {
    public frmListagemHistorico()
    {
      InitializeComponent();
    }

    private void CarregarGridViewHistorico()
    {
      dgv_historico.DataSource = null;
      HistoricoController hisController = new HistoricoController();
      dgv_historico.DataSource = hisController.Listar();
    }
    

    private void frmListagemHistorico_Load(object sender, EventArgs e)
    {
      CarregarGridViewHistorico();
    }

    private void dgv_historico_SelectionChanged(object sender, EventArgs e)
    {
      if (((DataGridView)sender).SelectedRows.Count > 0)
      {
        int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);
        frmCadastroHistorico cadhistorico = new frmCadastroHistorico(idSelecionado);
        cadhistorico.ShowDialog();
        CarregarGridViewHistorico();
      }
    }
  }
}
