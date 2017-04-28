namespace ContasPagar
{
 partial class frmCadastroTituloMovimento
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
   this.lbl_tituloid = new System.Windows.Forms.Label();
   this.lbl_vlrlancto = new System.Windows.Forms.Label();
   this.lbl_historicoid = new System.Windows.Forms.Label();
   this.lbl_datacontabil = new System.Windows.Forms.Label();
   this.lbl_datadigitacao = new System.Windows.Forms.Label();
   this.lbl_doctonumero = new System.Windows.Forms.Label();
   this.txt_tituloid = new System.Windows.Forms.TextBox();
   this.txt_doctonumero = new System.Windows.Forms.TextBox();
   this.dtp_datadigitacao = new System.Windows.Forms.DateTimePicker();
   this.dtp_datacontabil = new System.Windows.Forms.DateTimePicker();
   this.txt_vlrlancto = new System.Windows.Forms.TextBox();
   this.btn_excluir = new System.Windows.Forms.Button();
   this.btn_cancelar = new System.Windows.Forms.Button();
   this.btn_salvar = new System.Windows.Forms.Button();
   this.cbx_Historico = new System.Windows.Forms.ComboBox();
   this.SuspendLayout();
   // 
   // lbl_tituloid
   // 
   this.lbl_tituloid.AutoSize = true;
   this.lbl_tituloid.Location = new System.Drawing.Point(37, 27);
   this.lbl_tituloid.Name = "lbl_tituloid";
   this.lbl_tituloid.Size = new System.Drawing.Size(49, 13);
   this.lbl_tituloid.TabIndex = 0;
   this.lbl_tituloid.Text = "ID Título";
   // 
   // lbl_vlrlancto
   // 
   this.lbl_vlrlancto.AutoSize = true;
   this.lbl_vlrlancto.Location = new System.Drawing.Point(37, 160);
   this.lbl_vlrlancto.Name = "lbl_vlrlancto";
   this.lbl_vlrlancto.Size = new System.Drawing.Size(93, 13);
   this.lbl_vlrlancto.TabIndex = 1;
   this.lbl_vlrlancto.Text = "Valor Lançamento";
   // 
   // lbl_historicoid
   // 
   this.lbl_historicoid.AutoSize = true;
   this.lbl_historicoid.Location = new System.Drawing.Point(37, 134);
   this.lbl_historicoid.Name = "lbl_historicoid";
   this.lbl_historicoid.Size = new System.Drawing.Size(48, 13);
   this.lbl_historicoid.TabIndex = 2;
   this.lbl_historicoid.Text = "Histórico";
   // 
   // lbl_datacontabil
   // 
   this.lbl_datacontabil.AutoSize = true;
   this.lbl_datacontabil.Location = new System.Drawing.Point(37, 108);
   this.lbl_datacontabil.Name = "lbl_datacontabil";
   this.lbl_datacontabil.Size = new System.Drawing.Size(70, 13);
   this.lbl_datacontabil.TabIndex = 3;
   this.lbl_datacontabil.Text = "Data contábil";
   // 
   // lbl_datadigitacao
   // 
   this.lbl_datadigitacao.AutoSize = true;
   this.lbl_datadigitacao.Location = new System.Drawing.Point(37, 80);
   this.lbl_datadigitacao.Name = "lbl_datadigitacao";
   this.lbl_datadigitacao.Size = new System.Drawing.Size(76, 13);
   this.lbl_datadigitacao.TabIndex = 4;
   this.lbl_datadigitacao.Text = "Data digitação";
   // 
   // lbl_doctonumero
   // 
   this.lbl_doctonumero.AutoSize = true;
   this.lbl_doctonumero.Location = new System.Drawing.Point(37, 54);
   this.lbl_doctonumero.Name = "lbl_doctonumero";
   this.lbl_doctonumero.Size = new System.Drawing.Size(74, 13);
   this.lbl_doctonumero.TabIndex = 5;
   this.lbl_doctonumero.Text = "Nr documento";
   // 
   // txt_tituloid
   // 
   this.txt_tituloid.Location = new System.Drawing.Point(139, 19);
   this.txt_tituloid.Name = "txt_tituloid";
   this.txt_tituloid.Size = new System.Drawing.Size(60, 20);
   this.txt_tituloid.TabIndex = 6;
   // 
   // txt_doctonumero
   // 
   this.txt_doctonumero.Location = new System.Drawing.Point(139, 47);
   this.txt_doctonumero.Name = "txt_doctonumero";
   this.txt_doctonumero.Size = new System.Drawing.Size(83, 20);
   this.txt_doctonumero.TabIndex = 7;
   // 
   // dtp_datadigitacao
   // 
   this.dtp_datadigitacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtp_datadigitacao.Location = new System.Drawing.Point(139, 73);
   this.dtp_datadigitacao.Name = "dtp_datadigitacao";
   this.dtp_datadigitacao.Size = new System.Drawing.Size(83, 20);
   this.dtp_datadigitacao.TabIndex = 8;
   // 
   // dtp_datacontabil
   // 
   this.dtp_datacontabil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtp_datacontabil.Location = new System.Drawing.Point(139, 102);
   this.dtp_datacontabil.Name = "dtp_datacontabil";
   this.dtp_datacontabil.Size = new System.Drawing.Size(83, 20);
   this.dtp_datacontabil.TabIndex = 9;
   // 
   // txt_vlrlancto
   // 
   this.txt_vlrlancto.Location = new System.Drawing.Point(139, 160);
   this.txt_vlrlancto.Name = "txt_vlrlancto";
   this.txt_vlrlancto.Size = new System.Drawing.Size(83, 20);
   this.txt_vlrlancto.TabIndex = 11;
   // 
   // btn_excluir
   // 
   this.btn_excluir.Location = new System.Drawing.Point(130, 236);
   this.btn_excluir.Name = "btn_excluir";
   this.btn_excluir.Size = new System.Drawing.Size(75, 23);
   this.btn_excluir.TabIndex = 20;
   this.btn_excluir.Text = "Excluir";
   this.btn_excluir.UseVisualStyleBackColor = true;
   this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
   // 
   // btn_cancelar
   // 
   this.btn_cancelar.Location = new System.Drawing.Point(319, 236);
   this.btn_cancelar.Name = "btn_cancelar";
   this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
   this.btn_cancelar.TabIndex = 19;
   this.btn_cancelar.Text = "Cancelar";
   this.btn_cancelar.UseVisualStyleBackColor = true;
   this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
   // 
   // btn_salvar
   // 
   this.btn_salvar.Location = new System.Drawing.Point(36, 236);
   this.btn_salvar.Name = "btn_salvar";
   this.btn_salvar.Size = new System.Drawing.Size(75, 23);
   this.btn_salvar.TabIndex = 18;
   this.btn_salvar.Text = "Salvar";
   this.btn_salvar.UseVisualStyleBackColor = true;
   this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
   // 
   // cbx_Historico
   // 
   this.cbx_Historico.FormattingEnabled = true;
   this.cbx_Historico.Location = new System.Drawing.Point(139, 128);
   this.cbx_Historico.Name = "cbx_Historico";
   this.cbx_Historico.Size = new System.Drawing.Size(326, 21);
   this.cbx_Historico.TabIndex = 21;
   // 
   // frmCadastroTituloMovimento
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(528, 302);
   this.Controls.Add(this.cbx_Historico);
   this.Controls.Add(this.btn_excluir);
   this.Controls.Add(this.btn_cancelar);
   this.Controls.Add(this.btn_salvar);
   this.Controls.Add(this.txt_vlrlancto);
   this.Controls.Add(this.dtp_datacontabil);
   this.Controls.Add(this.dtp_datadigitacao);
   this.Controls.Add(this.txt_doctonumero);
   this.Controls.Add(this.txt_tituloid);
   this.Controls.Add(this.lbl_doctonumero);
   this.Controls.Add(this.lbl_datadigitacao);
   this.Controls.Add(this.lbl_datacontabil);
   this.Controls.Add(this.lbl_historicoid);
   this.Controls.Add(this.lbl_vlrlancto);
   this.Controls.Add(this.lbl_tituloid);
   this.Name = "frmCadastroTituloMovimento";
   this.Text = "Cadastro Título Movimento";
   this.Load += new System.EventHandler(this.frmCadastroTituloMovimento_Load);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_tituloid;
  private System.Windows.Forms.Label lbl_vlrlancto;
  private System.Windows.Forms.Label lbl_historicoid;
  private System.Windows.Forms.Label lbl_datacontabil;
  private System.Windows.Forms.Label lbl_datadigitacao;
  private System.Windows.Forms.Label lbl_doctonumero;
  private System.Windows.Forms.TextBox txt_tituloid;
  private System.Windows.Forms.TextBox txt_doctonumero;
  private System.Windows.Forms.DateTimePicker dtp_datadigitacao;
  private System.Windows.Forms.DateTimePicker dtp_datacontabil;
  private System.Windows.Forms.TextBox txt_vlrlancto;
  private System.Windows.Forms.Button btn_excluir;
  private System.Windows.Forms.Button btn_cancelar;
  private System.Windows.Forms.Button btn_salvar;
  private System.Windows.Forms.ComboBox cbx_Historico;
 }
}