namespace ContasPagar
{
 partial class frmListagemTipodocumento
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
   this.lbl_listagem = new System.Windows.Forms.Label();
   this.dgv_tipodocumento = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.dgv_tipodocumento)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_listagem
   // 
   this.lbl_listagem.AutoSize = true;
   this.lbl_listagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lbl_listagem.Location = new System.Drawing.Point(13, 13);
   this.lbl_listagem.Name = "lbl_listagem";
   this.lbl_listagem.Size = new System.Drawing.Size(240, 25);
   this.lbl_listagem.TabIndex = 0;
   this.lbl_listagem.Text = "Listagem Tipo Documento";
   // 
   // dgv_tipodocumento
   // 
   this.dgv_tipodocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgv_tipodocumento.Location = new System.Drawing.Point(18, 41);
   this.dgv_tipodocumento.Name = "dgv_tipodocumento";
   this.dgv_tipodocumento.Size = new System.Drawing.Size(549, 338);
   this.dgv_tipodocumento.TabIndex = 1;
   this.dgv_tipodocumento.SelectionChanged += new System.EventHandler(this.dgv_tipodocumento_SelectionChanged);
   // 
   // frmListagemTipodocumento
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(579, 391);
   this.Controls.Add(this.dgv_tipodocumento);
   this.Controls.Add(this.lbl_listagem);
   this.Name = "frmListagemTipodocumento";
   this.Text = "Listagem Tipo Documento";
   this.Load += new System.EventHandler(this.frmListagemTipodocumento_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgv_tipodocumento)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_listagem;
  private System.Windows.Forms.DataGridView dgv_tipodocumento;
 }
}