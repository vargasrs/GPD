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
  public partial class frmCadastroTitulo : Form
  {
    public int? TituloID { get; set; }
    public Titulo _Titulo { get; set; }
    
    public frmCadastroTitulo(int? idTitulo)
    {
      InitializeComponent();
      cbx_TipoDocumento.DisplayMember = "Descricao";
      cbx_TipoDocumento.ValueMember   = "TipoDocumentoID";
      // carregar combo tipo documento
      cbx_TipoDocumento.DataSource = TipoDocumentoController.BuscarTodos();
      if (idTitulo.HasValue)
      {
        TituloID = idTitulo;
        btn_excluir.Visible = true;
      }
      else
      {
        btn_excluir.Visible = false;
      }
    }

    private void CarregarFormulario()
    {
      if (TituloID.HasValue)
      {
        TituloController titController = new TituloController();
        _Titulo = titController.Detalhes(TituloID.Value);
        // se encontrou carrega
        if (_Titulo != null)
        {
          txt_titulodoc.Text    = _Titulo.TituloDoc;
          txt_tituloletra.Text  = _Titulo.TituloLetra;
          dtp_dataemissao.Value = _Titulo.DataEmissao;
          dtp_datavencto.Value  = _Titulo.DataVencto;
          dtp_dataliquida.Value = _Titulo.DataLiquida;
          txt_vlrtitulo.Text    = Convert.ToString(_Titulo.VlrTitulo);
          cbx_TipoDocumento.SelectedValue = _Titulo.TipoDocumentoID;
          txt_fornecedorid.Text    = Convert.ToString(_Titulo.FornecedorID);
          btn_salvar.Text = "Atualizar";
        }
      }
      else
        LimparCampos();
    }

    public void LimparCampos()
    {
      TituloID = null;
      _Titulo = null;
      txt_titulodoc.Clear();
      txt_tituloletra.Clear();
      dtp_dataemissao.Value = DateTime.Now;
      dtp_datavencto.Value = DateTime.Now;
      dtp_dataliquida.Value = DateTime.Now;
      txt_vlrtitulo.Clear();
      txt_fornecedorid.Clear();
      btn_salvar.Text = "Salvar";
    }


    private void Excluir()
    {
      if (TituloID.HasValue)
      {
        TituloController.ExcluirTitulo(TituloID.Value);
        MessageBox.Show("Titulo excluido com sucesso");
        LimparCampos();
        this.Close();
      }
    }

    private void Salvar()
    {
      try
      {
        if (Validar())
        {
          if (TituloID.HasValue)
          {
            // aqui instancio em ins_titulo para atualizar no BD
            Titulo ins_titulo = new Titulo();
            ins_titulo.TituloDoc   = txt_titulodoc.Text;
            ins_titulo.TituloLetra = txt_tituloletra.Text;
            ins_titulo.DataEmissao = dtp_dataemissao.Value;
            ins_titulo.DataVencto  = dtp_datavencto.Value;
            ins_titulo.DataLiquida = dtp_dataliquida.Value;
            ins_titulo.VlrTitulo   = Convert.ToDecimal(txt_vlrtitulo.Text);
            ins_titulo.TipoDocumentoID = Convert.ToInt32(cbx_TipoDocumento.SelectedValue);
            ins_titulo.FornecedorID    = Convert.ToInt32(txt_fornecedorid.Text);
            TituloController.EditarTitulo(TituloID.Value, ins_titulo);
            // mensagem
            MessageBox.Show("Titulo alterado com sucesso");
            LimparCampos();
            this.Close();
          }
          else
          {
            // aqui instancio em ins_titulo para depois adicionar no BD
            Titulo ins_titulo = new Titulo();
            ins_titulo.TituloDoc   = txt_titulodoc.Text;
            ins_titulo.TituloLetra = txt_tituloletra.Text;
            ins_titulo.DataEmissao = dtp_dataemissao.Value;
            ins_titulo.DataVencto  = dtp_datavencto.Value;
            ins_titulo.DataLiquida = dtp_dataliquida.Value;
            ins_titulo.VlrTitulo   = Convert.ToDecimal(txt_vlrtitulo.Text);
            ins_titulo.TipoDocumentoID = Convert.ToInt32(cbx_TipoDocumento.SelectedValue);
            ins_titulo.FornecedorID    = Convert.ToInt32(txt_fornecedorid.Text);
            TituloController.AdicionarTitulo(ins_titulo);
            // mensagem
            MessageBox.Show("Titulo cadastrado com sucesso");
            LimparCampos();
          }
        }
        else
        {
          MessageBox.Show("Todos campos são obrigatórios");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "ERRO");
      }
    }

    private bool Validar()
    {
      return !(string.IsNullOrEmpty(txt_titulodoc.Text));
    }


    private void btn_salvar_Click(object sender, EventArgs e)
    {
      Salvar();
    }

    private void btn_excluir_Click(object sender, EventArgs e)
    {
      Excluir();
    }

    private void btn_cancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmCadastroTitulo_Load(object sender, EventArgs e)
    {
      CarregarFormulario();
    }
  }
}
