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
  public partial class frmCadastroTipoDocumento : Form
  {
        // com int? permite receber parametro nulo
        public int? TipodocumentoID { get; set; }
        public TipoDocumento _Tipodocumento { get; set; }

        public frmCadastroTipoDocumento(int? idTipodocumento)
        {
            InitializeComponent();

            if (idTipodocumento.HasValue)
                TipodocumentoID = idTipodocumento;
        }

        private void CarregarFormulario()
        {
            if (TipodocumentoID.HasValue)
            {
                TipoDocumentoController tdoController = new TipoDocumentoController();
                _Tipodocumento = tdoController.Detalhes(TipodocumentoID.Value);

                if (_Tipodocumento != null)
                {
                    txt_descricao.Text = _Tipodocumento.Descricao;
                    txt_sigla.Text     = _Tipodocumento.Sigla;
                    btn_salvar.Text    = "Atualizar";
                }
            }
            else
                LimparCampos();
        }

        public void LimparCampos()
        {
            TipodocumentoID = null;
            _Tipodocumento = null;
            txt_descricao.Clear();
            txt_sigla.Clear();
            btn_salvar.Text = "Salvar";
        }
     

        private void Salvar()
        {
            try
            {
                if (Validar())
                {
                    if (TipodocumentoID.HasValue)
                    {
                        // aqui instancio em ins_fornecedor para atualizar no BD
                        TipoDocumento ins_TipoDocumento = new TipoDocumento();
                        ins_TipoDocumento.Descricao = txt_descricao.Text;
                        ins_TipoDocumento.Sigla     = txt_sigla.Text;
                        TipoDocumentoController.EditarTipoDocumento(TipodocumentoID.Value,ins_TipoDocumento);
                        // mensagem
                        MessageBox.Show("Tipo de documento alterado com sucesso");
                        LimparCampos();
                        this.Close();
                    }
                    else
                    {
                        // aqui instancio em ins_fornecedor para depois adicionar no BD
                        TipoDocumento ins_TipoDocumento = new TipoDocumento();
                        ins_TipoDocumento.Descricao = txt_descricao.Text;
                        ins_TipoDocumento.Sigla     = txt_sigla.Text;
                        TipoDocumentoController.AdicionarTipoDocumento(ins_TipoDocumento);
                        // mensagem
                        MessageBox.Show("Tipo de documento cadastrado com sucesso");
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

    private void Excluir()
    {
      if (TipodocumentoID.HasValue)
      {
        TipoDocumentoController.ExcluirTipoDocumento(TipodocumentoID.Value);
        MessageBox.Show("Tipo documento excluido com sucesso");
        LimparCampos();
        this.Close();
      }
    }



    private bool Validar()
        {
            return !(string.IsNullOrEmpty(txt_descricao.Text) || string.IsNullOrEmpty(txt_sigla.Text) );
        }


    private void btn_salvar_Click(object sender, EventArgs e)
    {
      Salvar();
    }

    private void btn_cancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmCadastroTipodocumento_Load(object sender, EventArgs e)
    {
      CarregarFormulario();
    }

    private void btn_excluir_Click(object sender, EventArgs e)
    {
      Excluir();
    }
  }
}
