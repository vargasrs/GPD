namespace ContasPagar
{
  partial class frmCadastroHistorico
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
      this.lbl_debcre = new System.Windows.Forms.Label();
      this.txt_descricao = new System.Windows.Forms.TextBox();
      this.txt_debcre = new System.Windows.Forms.TextBox();
      this.btn_cancelar = new System.Windows.Forms.Button();
      this.btn_salvar = new System.Windows.Forms.Button();
      this.btn_excluir = new System.Windows.Forms.Button();
      this.cb_debcre = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // lbl_descricao
      // 
      this.lbl_descricao.AutoSize = true;
      this.lbl_descricao.Location = new System.Drawing.Point(26, 22);
      this.lbl_descricao.Name = "lbl_descricao";
      this.lbl_descricao.Size = new System.Drawing.Size(55, 13);
      this.lbl_descricao.TabIndex = 0;
      this.lbl_descricao.Text = "Descrição";
      // 
      // lbl_debcre
      // 
      this.lbl_debcre.AutoSize = true;
      this.lbl_debcre.Location = new System.Drawing.Point(33, 143);
      this.lbl_debcre.Name = "lbl_debcre";
      this.lbl_debcre.Size = new System.Drawing.Size(48, 13);
      this.lbl_debcre.TabIndex = 1;
      this.lbl_debcre.Text = "Deb/Cre";
      // 
      // txt_descricao
      // 
      this.txt_descricao.Location = new System.Drawing.Point(88, 14);
      this.txt_descricao.Name = "txt_descricao";
      this.txt_descricao.Size = new System.Drawing.Size(292, 20);
      this.txt_descricao.TabIndex = 2;
      // 
      // txt_debcre
      // 
      this.txt_debcre.Location = new System.Drawing.Point(88, 143);
      this.txt_debcre.Name = "txt_debcre";
      this.txt_debcre.Size = new System.Drawing.Size(21, 20);
      this.txt_debcre.TabIndex = 3;
      // 
      // btn_cancelar
      // 
      this.btn_cancelar.Location = new System.Drawing.Point(304, 262);
      this.btn_cancelar.Name = "btn_cancelar";
      this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
      this.btn_cancelar.TabIndex = 4;
      this.btn_cancelar.Text = "Cancelar";
      this.btn_cancelar.UseVisualStyleBackColor = true;
      this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
      // 
      // btn_salvar
      // 
      this.btn_salvar.Location = new System.Drawing.Point(73, 262);
      this.btn_salvar.Name = "btn_salvar";
      this.btn_salvar.Size = new System.Drawing.Size(75, 23);
      this.btn_salvar.TabIndex = 5;
      this.btn_salvar.Text = "Salvar";
      this.btn_salvar.UseVisualStyleBackColor = true;
      this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
      // 
      // btn_excluir
      // 
      this.btn_excluir.Location = new System.Drawing.Point(211, 262);
      this.btn_excluir.Name = "btn_excluir";
      this.btn_excluir.Size = new System.Drawing.Size(75, 23);
      this.btn_excluir.TabIndex = 6;
      this.btn_excluir.Text = "Excluir";
      this.btn_excluir.UseVisualStyleBackColor = true;
      this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
      // 
      // cb_debcre
      // 
      this.cb_debcre.FormattingEnabled = true;
      this.cb_debcre.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
      this.cb_debcre.Location = new System.Drawing.Point(88, 103);
      this.cb_debcre.Name = "cb_debcre";
      this.cb_debcre.Size = new System.Drawing.Size(121, 21);
      this.cb_debcre.TabIndex = 7;
      this.cb_debcre.SelectedIndexChanged += new System.EventHandler(this.cb_debcre_SelectedIndexChanged);
      // 
      // frmCadastroHistorico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(448, 302);
      this.Controls.Add(this.cb_debcre);
      this.Controls.Add(this.btn_excluir);
      this.Controls.Add(this.btn_salvar);
      this.Controls.Add(this.btn_cancelar);
      this.Controls.Add(this.txt_debcre);
      this.Controls.Add(this.txt_descricao);
      this.Controls.Add(this.lbl_debcre);
      this.Controls.Add(this.lbl_descricao);
      this.Name = "frmCadastroHistorico";
      this.Text = "Cadastro Histórico";
      this.Load += new System.EventHandler(this.frmCadastroHistorico_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_descricao;
    private System.Windows.Forms.Label lbl_debcre;
    private System.Windows.Forms.TextBox txt_descricao;
    private System.Windows.Forms.TextBox txt_debcre;
    private System.Windows.Forms.Button btn_cancelar;
    private System.Windows.Forms.Button btn_salvar;
    private System.Windows.Forms.Button btn_excluir;
    private System.Windows.Forms.ComboBox cb_debcre;
  }
}