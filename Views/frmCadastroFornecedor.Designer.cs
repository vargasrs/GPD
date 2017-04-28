namespace ContasPagar
{
 partial class frmCadastroFornecedor
 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   this.lbl_nome = new System.Windows.Forms.Label();
   this.lbl_pessoa = new System.Windows.Forms.Label();
   this.lbl_registro = new System.Windows.Forms.Label();
   this.txt_nome = new System.Windows.Forms.TextBox();
   this.txt_pessoa = new System.Windows.Forms.TextBox();
   this.txt_registro = new System.Windows.Forms.TextBox();
   this.btn_salvar = new System.Windows.Forms.Button();
   this.btn_cancelar = new System.Windows.Forms.Button();
   this.btn_excluir = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // lbl_nome
   // 
   this.lbl_nome.AutoSize = true;
   this.lbl_nome.Location = new System.Drawing.Point(37, 36);
   this.lbl_nome.Name = "lbl_nome";
   this.lbl_nome.Size = new System.Drawing.Size(35, 13);
   this.lbl_nome.TabIndex = 0;
   this.lbl_nome.Text = "Nome";
   // 
   // lbl_pessoa
   // 
   this.lbl_pessoa.AutoSize = true;
   this.lbl_pessoa.Location = new System.Drawing.Point(37, 74);
   this.lbl_pessoa.Name = "lbl_pessoa";
   this.lbl_pessoa.Size = new System.Drawing.Size(42, 13);
   this.lbl_pessoa.TabIndex = 1;
   this.lbl_pessoa.Text = "Pessoa";
   // 
   // lbl_registro
   // 
   this.lbl_registro.AutoSize = true;
   this.lbl_registro.Location = new System.Drawing.Point(37, 109);
   this.lbl_registro.Name = "lbl_registro";
   this.lbl_registro.Size = new System.Drawing.Size(46, 13);
   this.lbl_registro.TabIndex = 2;
   this.lbl_registro.Text = "Registro";
   // 
   // txt_nome
   // 
   this.txt_nome.Location = new System.Drawing.Point(92, 28);
   this.txt_nome.Name = "txt_nome";
   this.txt_nome.Size = new System.Drawing.Size(298, 20);
   this.txt_nome.TabIndex = 3;
   // 
   // txt_pessoa
   // 
   this.txt_pessoa.Location = new System.Drawing.Point(92, 66);
   this.txt_pessoa.Name = "txt_pessoa";
   this.txt_pessoa.Size = new System.Drawing.Size(17, 20);
   this.txt_pessoa.TabIndex = 4;
   // 
   // txt_registro
   // 
   this.txt_registro.Location = new System.Drawing.Point(92, 101);
   this.txt_registro.Name = "txt_registro";
   this.txt_registro.Size = new System.Drawing.Size(165, 20);
   this.txt_registro.TabIndex = 5;
   // 
   // btn_salvar
   // 
   this.btn_salvar.Location = new System.Drawing.Point(136, 293);
   this.btn_salvar.Name = "btn_salvar";
   this.btn_salvar.Size = new System.Drawing.Size(75, 23);
   this.btn_salvar.TabIndex = 6;
   this.btn_salvar.Text = "Salvar";
   this.btn_salvar.UseVisualStyleBackColor = true;
   this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
   // 
   // btn_cancelar
   // 
   this.btn_cancelar.Location = new System.Drawing.Point(419, 293);
   this.btn_cancelar.Name = "btn_cancelar";
   this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
   this.btn_cancelar.TabIndex = 7;
   this.btn_cancelar.Text = "Cancelar";
   this.btn_cancelar.UseVisualStyleBackColor = true;
   this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
   // 
   // btn_excluir
   // 
   this.btn_excluir.Location = new System.Drawing.Point(230, 293);
   this.btn_excluir.Name = "btn_excluir";
   this.btn_excluir.Size = new System.Drawing.Size(75, 23);
   this.btn_excluir.TabIndex = 8;
   this.btn_excluir.Text = "Excluir";
   this.btn_excluir.UseVisualStyleBackColor = true;
   this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
   // 
   // frmCadastroFornecedor
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(538, 352);
   this.Controls.Add(this.btn_excluir);
   this.Controls.Add(this.btn_cancelar);
   this.Controls.Add(this.btn_salvar);
   this.Controls.Add(this.txt_registro);
   this.Controls.Add(this.txt_pessoa);
   this.Controls.Add(this.txt_nome);
   this.Controls.Add(this.lbl_registro);
   this.Controls.Add(this.lbl_pessoa);
   this.Controls.Add(this.lbl_nome);
   this.Name = "frmCadastroFornecedor";
   this.Text = "Cadastro Fornecedor";
   this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_nome;
  private System.Windows.Forms.Label lbl_pessoa;
  private System.Windows.Forms.Label lbl_registro;
  private System.Windows.Forms.TextBox txt_nome;
  private System.Windows.Forms.TextBox txt_pessoa;
  private System.Windows.Forms.TextBox txt_registro;
  private System.Windows.Forms.Button btn_salvar;
  private System.Windows.Forms.Button btn_cancelar;
    private System.Windows.Forms.Button btn_excluir;
  }
}