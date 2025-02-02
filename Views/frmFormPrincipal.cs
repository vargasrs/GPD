﻿using System;
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
      frmCadastroTipoDocumento cadTipodocumento = new frmCadastroTipoDocumento(null);
      cadTipodocumento.MdiParent = this;
      cadTipodocumento.Show();
    }

    private void tsp_tdolis_Click(object sender, EventArgs e)
    {
      frmListagemTipoDocumento listagem_tipodocumento = new frmListagemTipoDocumento();
      listagem_tipodocumento.MdiParent = this;
      listagem_tipodocumento.Show();
    }

    private void tsp_hiscad_Click(object sender, EventArgs e)
    {
      frmCadastroHistorico cadHistorico = new frmCadastroHistorico(null);
      cadHistorico.MdiParent = this;
      cadHistorico.Show();
    }

    private void tsp_hislis_Click(object sender, EventArgs e)
    {
      frmListagemHistorico listagem_historico = new frmListagemHistorico();
      listagem_historico.MdiParent = this;
      listagem_historico.Show();
    }

    private void tsp_titulocad_Click(object sender, EventArgs e)
    {
      frmCadastroTitulo cadTitulo = new frmCadastroTitulo(null);
      cadTitulo.MdiParent = this;
      cadTitulo.Show();
    }

    private void tsp_titulolis_Click(object sender, EventArgs e)
    {
      frmListagemTitulo listagem_titulo = new frmListagemTitulo();
      listagem_titulo.MdiParent = this;
      listagem_titulo.Show();
    }

    private void tsp_titulomovimentocad_Click(object sender, EventArgs e)
    {
      frmCadastroTituloMovimento cadTituloMovimento = new frmCadastroTituloMovimento(null);
      cadTituloMovimento.MdiParent = this;
      cadTituloMovimento.Show();
    }

    private void tsp_titulomovimentolis_Click(object sender, EventArgs e)
    {
      frmListagemTituloMovimento listagem_titulomovimento = new frmListagemTituloMovimento();
      listagem_titulomovimento.MdiParent = this;
      listagem_titulomovimento.Show();
    }


 }
}
