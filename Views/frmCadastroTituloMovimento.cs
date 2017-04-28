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
  public partial class frmCadastroTituloMovimento : Form
  {
    public int? MovTitID { get; set; }
    public TituloMovimento _TituloMovimento { get; set; }

    public frmCadastroTituloMovimento(int? idMovTit)
    {
      InitializeComponent();
      cbx_Historico.DisplayMember = "Descricao";
      cbx_Historico.ValueMember   = "HistoricoID";
      // carregar combo historico
      cbx_Historico.DataSource = HistoricoController.BuscarTodos();
      if (idMovTit.HasValue)
      {
        MovTitID = idMovTit;
        btn_excluir.Visible = true;
      }
      else
      {
        btn_excluir.Visible = false;
      }
    }

    private void btn_cancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void CarregarFormulario()
    {
      if (MovTitID.HasValue)
      {
        TituloMovimentoController movController = new TituloMovimentoController();
        _TituloMovimento = movController.Detalhes(MovTitID.Value);
        // se encontrou carrega
        if (_TituloMovimento != null)
        {
          txt_tituloid.Text       = Convert.ToString(_TituloMovimento.TituloID);
          txt_doctonumero.Text    = _TituloMovimento.DoctoNumero;
          dtp_datadigitacao.Value = _TituloMovimento.DataDigitacao;
          dtp_datacontabil.Value  = _TituloMovimento.DataContabil;
          cbx_Historico.SelectedValue = _TituloMovimento.HistoricoID;
          txt_vlrlancto.Text      = Convert.ToString(_TituloMovimento.VlrLancto);
          btn_salvar.Text = "Atualizar";
        }
      }
      else
        LimparCampos();
    }

    public void LimparCampos()
    {
      MovTitID = null;
      _TituloMovimento = null;
      txt_tituloid.Clear();
      txt_doctonumero.Clear();
      dtp_datadigitacao.Value = DateTime.Now;
      dtp_datacontabil.Value = DateTime.Now;
      txt_vlrlancto.Clear();
      btn_salvar.Text = "Salvar";
    }

    private void Excluir()
    {
      if (MovTitID.HasValue)
      {
        TituloMovimentoController.ExcluirTituloMovimento(MovTitID.Value);
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
          if (MovTitID.HasValue)
          {
            // aqui instancio em mov_titulo para atualizar no BD
            TituloMovimento mov_titulo = new TituloMovimento();
            mov_titulo.TituloID      = Convert.ToInt32(txt_tituloid.Text);
            mov_titulo.DoctoNumero   = txt_doctonumero.Text;
            mov_titulo.DataDigitacao = dtp_datadigitacao.Value;
            mov_titulo.DataContabil  = dtp_datacontabil.Value;
            mov_titulo.HistoricoID   = Convert.ToInt32(cbx_Historico.SelectedValue);
            mov_titulo.VlrLancto     = Convert.ToDecimal(txt_vlrlancto.Text);
            TituloMovimentoController.EditarTituloMovimento(MovTitID.Value, mov_titulo);
            // mensagem
            MessageBox.Show("Lançamento alterado com sucesso");
            LimparCampos();
            this.Close();
          }
          else
          {
            // aqui instancio em mov_titulo para depois adicionar no BD
            TituloMovimento mov_titulo = new TituloMovimento();
            mov_titulo.TituloID      = Convert.ToInt32(txt_tituloid.Text);
            mov_titulo.DoctoNumero   = txt_doctonumero.Text;
            mov_titulo.DataDigitacao = dtp_datadigitacao.Value;
            mov_titulo.DataContabil  = dtp_datacontabil.Value;
            mov_titulo.HistoricoID   = Convert.ToInt32(cbx_Historico.SelectedValue);
            mov_titulo.VlrLancto     = Convert.ToDecimal(txt_vlrlancto.Text);
            TituloMovimentoController.AdicionarTituloMovimento(mov_titulo);
            // mensagem
            MessageBox.Show("Lançamento cadastrado com sucesso");
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
      return !(string.IsNullOrEmpty(txt_tituloid.Text));
    }

    private void btn_salvar_Click(object sender, EventArgs e)
    {
      Salvar();
    }

    private void btn_excluir_Click(object sender, EventArgs e)
    {
      Excluir();
    }

    private void frmCadastroTituloMovimento_Load(object sender, EventArgs e)
    {
      CarregarFormulario();
    }



 }
}
