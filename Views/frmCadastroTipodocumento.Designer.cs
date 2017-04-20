namespace ContasPagar
{
 partial class frmCadastroTipoDocumento
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
      this.lbl_descricao = new System.Windows.Forms.Label();
      this.lbl_sigla = new System.Windows.Forms.Label();
      this.btn_salvar = new System.Windows.Forms.Button();
      this.btn_cancelar = new System.Windows.Forms.Button();
      this.txt_descricao = new System.Windows.Forms.TextBox();
      this.txt_sigla = new System.Windows.Forms.TextBox();
      this.btn_excluir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbl_descricao
      // 
      this.lbl_descricao.AutoSize = true;
      this.lbl_descricao.Location = new System.Drawing.Point(29, 30);
      this.lbl_descricao.Name = "lbl_descricao";
      this.lbl_descricao.Size = new System.Drawing.Size(55, 13);
      this.lbl_descricao.TabIndex = 0;
      this.lbl_descricao.Text = "Descrição";
      // 
      // lbl_sigla
      // 
      this.lbl_sigla.AutoSize = true;
      this.lbl_sigla.Location = new System.Drawing.Point(32, 71);
      this.lbl_sigla.Name = "lbl_sigla";
      this.lbl_sigla.Size = new System.Drawing.Size(30, 13);
      this.lbl_sigla.TabIndex = 1;
      this.lbl_sigla.Text = "Sigla";
      // 
      // btn_salvar
      // 
      this.btn_salvar.Location = new System.Drawing.Point(72, 235);
      this.btn_salvar.Name = "btn_salvar";
      this.btn_salvar.Size = new System.Drawing.Size(75, 23);
      this.btn_salvar.TabIndex = 2;
      this.btn_salvar.Text = "Salvar";
      this.btn_salvar.UseVisualStyleBackColor = true;
      this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
      // 
      // btn_cancelar
      // 
      this.btn_cancelar.Location = new System.Drawing.Point(295, 235);
      this.btn_cancelar.Name = "btn_cancelar";
      this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
      this.btn_cancelar.TabIndex = 3;
      this.btn_cancelar.Text = "Cancelar";
      this.btn_cancelar.UseVisualStyleBackColor = true;
      this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
      // 
      // txt_descricao
      // 
      this.txt_descricao.Location = new System.Drawing.Point(90, 23);
      this.txt_descricao.Name = "txt_descricao";
      this.txt_descricao.Size = new System.Drawing.Size(280, 20);
      this.txt_descricao.TabIndex = 4;
      // 
      // txt_sigla
      // 
      this.txt_sigla.Location = new System.Drawing.Point(90, 63);
      this.txt_sigla.Name = "txt_sigla";
      this.txt_sigla.Size = new System.Drawing.Size(57, 20);
      this.txt_sigla.TabIndex = 5;
      // 
      // btn_excluir
      // 
      this.btn_excluir.Location = new System.Drawing.Point(172, 235);
      this.btn_excluir.Name = "btn_excluir";
      this.btn_excluir.Size = new System.Drawing.Size(75, 23);
      this.btn_excluir.TabIndex = 6;
      this.btn_excluir.Text = "Excluir";
      this.btn_excluir.UseVisualStyleBackColor = true;
      this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
      // 
      // frmCadastroTipoDocumento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(405, 289);
      this.Controls.Add(this.btn_excluir);
      this.Controls.Add(this.txt_sigla);
      this.Controls.Add(this.txt_descricao);
      this.Controls.Add(this.btn_cancelar);
      this.Controls.Add(this.btn_salvar);
      this.Controls.Add(this.lbl_sigla);
      this.Controls.Add(this.lbl_descricao);
      this.Name = "frmCadastroTipoDocumento";
      this.Text = "Cadastro Tipo Documento";
      this.Load += new System.EventHandler(this.frmCadastroTipodocumento_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_descricao;
  private System.Windows.Forms.Label lbl_sigla;
  private System.Windows.Forms.Button btn_salvar;
  private System.Windows.Forms.Button btn_cancelar;
  private System.Windows.Forms.TextBox txt_descricao;
  private System.Windows.Forms.TextBox txt_sigla;
    private System.Windows.Forms.Button btn_excluir;
  }
}