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
  public partial class frmListagemTipoDocumento : Form
  {
    public frmListagemTipoDocumento()
    {
      InitializeComponent();
    }

    private void CarregarGridViewTipodocumento()
    {
      // aqui faz leitura na tabela fornecedor para carregar na grid
      dgv_tipodocumento.DataSource = null;
      dgv_tipodocumento.DataSource = TipoDocumentoController.BuscarTodos();
    }

    private void dgv_tipodocumento_SelectionChanged(object sender, EventArgs e)
    {
      if(((DataGridView)sender).SelectedRows.Count > 0)
      {
        int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);
        frmCadastroTipoDocumento cadTipodocumento = new frmCadastroTipoDocumento(idSelecionado);
        cadTipodocumento.ShowDialog();
        CarregarGridViewTipodocumento();
      }
    }

    private void frmListagemTipodocumento_Load(object sender, EventArgs e)
    {
      CarregarGridViewTipodocumento();
    }


 }
}
