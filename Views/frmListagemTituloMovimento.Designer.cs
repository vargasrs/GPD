namespace ContasPagar
{
 partial class frmListagemTituloMovimento
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
      this.lbl_listagemtitulomovimento = new System.Windows.Forms.Label();
      this.dgv_titulomovimento = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_titulomovimento)).BeginInit();
      this.SuspendLayout();
      // 
      // lbl_listagemtitulomovimento
      // 
      this.lbl_listagemtitulomovimento.AutoSize = true;
      this.lbl_listagemtitulomovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_listagemtitulomovimento.Location = new System.Drawing.Point(7, 13);
      this.lbl_listagemtitulomovimento.Name = "lbl_listagemtitulomovimento";
      this.lbl_listagemtitulomovimento.Size = new System.Drawing.Size(291, 25);
      this.lbl_listagemtitulomovimento.TabIndex = 5;
      this.lbl_listagemtitulomovimento.Text = "Listagem movimento de título";
      // 
      // dgv_titulomovimento
      // 
      this.dgv_titulomovimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_titulomovimento.Location = new System.Drawing.Point(12, 50);
      this.dgv_titulomovimento.Name = "dgv_titulomovimento";
      this.dgv_titulomovimento.Size = new System.Drawing.Size(843, 344);
      this.dgv_titulomovimento.TabIndex = 4;
      this.dgv_titulomovimento.SelectionChanged += new System.EventHandler(this.dgv_titulomovimento_SelectionChanged);
      // 
      // frmListagemTituloMovimento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(628, 406);
      this.Controls.Add(this.lbl_listagemtitulomovimento);
      this.Controls.Add(this.dgv_titulomovimento);
      this.Name = "frmListagemTituloMovimento";
      this.Text = "Listagem movimento de título";
      this.Load += new System.EventHandler(this.frmListagemTituloMovimento_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_titulomovimento)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_listagemtitulomovimento;
  private System.Windows.Forms.DataGridView dgv_titulomovimento;
 }
}