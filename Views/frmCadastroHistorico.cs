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
  public partial class frmCadastroHistorico : Form
  {
    public int? HistoricoID { get; set; }
    public Historico _Historico { get; set; }

    public frmCadastroHistorico(int? idHistorico)
    {
      InitializeComponent();

      if (idHistorico.HasValue)
      {
        HistoricoID = idHistorico;
        btn_excluir.Visible = true;
      }
      else
      {
        btn_excluir.Visible = false;
      }
    }

    private void CarregarFormulario()
    {
      if (HistoricoID.HasValue)
      {
        HistoricoController hisController = new HistoricoController();
        _Historico = hisController.Detalhes(HistoricoID.Value);

        if (_Historico != null)
        {
          txt_descricao.Text = _Historico.Descricao;
          cbx_Debcre.Text = _Historico.Debcre;
          btn_salvar.Text = "Atualizar";
        }
      }
      else
        LimparCampos();
    }

    public void LimparCampos()
    {
      HistoricoID = null;
      _Historico = null;
      txt_descricao.Clear();
      btn_salvar.Text = "Salvar";
    }

    private void Excluir()
    {
      if (HistoricoID.HasValue)
      {
        // 
        HistoricoController.ExcluirHistorico(HistoricoID.Value);
        MessageBox.Show("Historico excluido com sucesso");
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
          if (HistoricoID.HasValue)
          {
            // aqui instancio em ins_historico para atualizar no BD
            Historico ins_historico = new Historico();
            ins_historico.Descricao = txt_descricao.Text;
            ins_historico.Debcre    = cbx_Debcre.Text;
            HistoricoController.EditarHistorico(HistoricoID.Value, ins_historico);
            // mensagem
            MessageBox.Show("Historico alterado com sucesso");
            LimparCampos();
            this.Close();
          }
          else
          {
            // aqui instancio em ins_historico para depois adicionar no BD
            Historico ins_Historico = new Historico();
            ins_Historico.Descricao = txt_descricao.Text;
            ins_Historico.Debcre    = cbx_Debcre.Text;
            HistoricoController.AdicionarHistorico(ins_Historico);
            // mensagem
            MessageBox.Show("Historico cadastrado com sucesso");
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
      return !(string.IsNullOrEmpty(txt_descricao.Text));
    }

    private void btn_salvar_Click(object sender, EventArgs e)
    {
      Salvar();
    }

    private void btn_cancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btn_excluir_Click(object sender, EventArgs e)
    {
      Excluir();
    }

    private void frmCadastroHistorico_Load(object sender, EventArgs e)
    {
      CarregarFormulario();
    }

    private void cb_debcre_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
  }
}