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
  public partial class frmFormPrincipal : Form
  {
    public frmFormPrincipal()
    {
      InitializeComponent();
    }

    private void tsp_forcad_Click(object sender, EventArgs e)
    {
      frmCadastroFornecedor cadFornecedor = new frmCadastroFornecedor(null);
      cadFornecedor.MdiParent = this;
      cadFornecedor.Show();
    }

    private void tsp_forlis_Click(object sender, EventArgs e)
    {
      frmListagemFornecedor listagem_fornecedor = new frmListagemFornecedor();
      listagem_fornecedor.MdiParent = this;
      listagem_fornecedor.Show();
     }

    private void tsp_tdocad_Click(object sender, EventArgs e)
    {
      frmCadastroTipodocumento cadTipodocumento = new frmCadastroTipodocumento(null);
      cadTipodocumento.MdiParent = this;
      cadTipodocumento.Show();
    }

    private void tsp_tdolis_Click(object sender, EventArgs e)
    {
      frmListagemTipodocumento listagem_tipodocumento = new frmListagemTipodocumento();
      listagem_tipodocumento.MdiParent = this;
      listagem_tipodocumento.Show();
    }



 }
}
