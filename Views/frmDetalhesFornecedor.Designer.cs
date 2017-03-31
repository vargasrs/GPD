namespace ContasPagar
{
 partial class frmDetalhesFornecedor
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
   this.lbl_id = new System.Windows.Forms.Label();
   this.lbl_registro = new System.Windows.Forms.Label();
   this.lbl_pessoa = new System.Windows.Forms.Label();
   this.lbl_nome = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // lbl_id
   // 
   this.lbl_id.AutoSize = true;
   this.lbl_id.Location = new System.Drawing.Point(29, 31);
   this.lbl_id.Name = "lbl_id";
   this.lbl_id.Size = new System.Drawing.Size(18, 13);
   this.lbl_id.TabIndex = 0;
   this.lbl_id.Text = "ID";
   // 
   // lbl_registro
   // 
   this.lbl_registro.AutoSize = true;
   this.lbl_registro.Location = new System.Drawing.Point(29, 121);
   this.lbl_registro.Name = "lbl_registro";
   this.lbl_registro.Size = new System.Drawing.Size(46, 13);
   this.lbl_registro.TabIndex = 1;
   this.lbl_registro.Text = "Registro";
   // 
   // lbl_pessoa
   // 
   this.lbl_pessoa.AutoSize = true;
   this.lbl_pessoa.Location = new System.Drawing.Point(29, 93);
   this.lbl_pessoa.Name = "lbl_pessoa";
   this.lbl_pessoa.Size = new System.Drawing.Size(42, 13);
   this.lbl_pessoa.TabIndex = 2;
   this.lbl_pessoa.Text = "Pessoa";
   // 
   // lbl_nome
   // 
   this.lbl_nome.AutoSize = true;
   this.lbl_nome.Location = new System.Drawing.Point(29, 62);
   this.lbl_nome.Name = "lbl_nome";
   this.lbl_nome.Size = new System.Drawing.Size(35, 13);
   this.lbl_nome.TabIndex = 3;
   this.lbl_nome.Text = "Nome";
   // 
   // frmDetalhesFornecedor
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(511, 363);
   this.Controls.Add(this.lbl_nome);
   this.Controls.Add(this.lbl_pessoa);
   this.Controls.Add(this.lbl_registro);
   this.Controls.Add(this.lbl_id);
   this.Name = "frmDetalhesFornecedor";
   this.Text = "Detalhes Fornecedor";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_id;
  private System.Windows.Forms.Label lbl_registro;
  private System.Windows.Forms.Label lbl_pessoa;
  private System.Windows.Forms.Label lbl_nome;
 }
}