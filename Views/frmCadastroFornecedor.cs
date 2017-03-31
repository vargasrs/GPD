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
    public partial class frmCadastroFornecedor : Form
    {
        public int? FornecedorID { get; set; }
        public Fornecedor _Fornecedor { get; set; }

        public frmCadastroFornecedor(int? idFornecedor)
        {
            InitializeComponent();

        if (idFornecedor.HasValue)
        {
          FornecedorID = idFornecedor;
          btn_excluir.Visible = true;
        }
        else
        {
          btn_excluir.Visible = false;
        }



    }

     

        private void CarregarFormulario()
        {
            if (FornecedorID.HasValue)
            {
                FornecedorController forController = new FornecedorController();
                _Fornecedor = forController.Detalhes(FornecedorID.Value);

                if (_Fornecedor != null)
                {
                    txt_nome.Text     = _Fornecedor.Nome;
                    txt_pessoa.Text   = _Fornecedor.Pessoa;
                    txt_registro.Text = _Fornecedor.Registro;
                    btn_salvar.Text   = "Atualizar";
                }
            }
            else
                LimparCampos();
        }

        public void LimparCampos()
        {
            FornecedorID = null;
            _Fornecedor = null;
            txt_nome.Clear();
            txt_pessoa.Clear();
            txt_registro.Clear();
            btn_salvar.Text = "Salvar";
        }



        private void Excluir()
        {
          if (FornecedorID.HasValue)
          {
            FornecedorController forController = new FornecedorController();
            forController.Excluir(FornecedorID.Value);
            MessageBox.Show("Fornecedor excluido com sucesso");
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
                    if (FornecedorID.HasValue)
                    {
                        FornecedorController forController = new FornecedorController();
                        forController.Editar(FornecedorID.Value, txt_nome.Text, txt_pessoa.Text, txt_registro.Text);

                        MessageBox.Show("Fornecedor alterado com sucesso");
                        LimparCampos();
                        this.Close();
                    }
                    else
                    {
                        FornecedorController forController = new FornecedorController();
                        forController.Adicionar(txt_nome.Text, txt_pessoa.Text, txt_registro.Text);

                        MessageBox.Show("Fornecedor cadastrado com sucesso");
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
            return !(string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_pessoa.Text) || string.IsNullOrEmpty(txt_registro.Text)  );
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
           Salvar();
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
           CarregarFormulario();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
          Excluir();
        }
  }






}
