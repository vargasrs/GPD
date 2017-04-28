namespace ContasPagar
{
  partial class frmListagemTitulo
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
   this.lbl_listagemTitulo = new System.Windows.Forms.Label();
   this.dgv_titulo = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.dgv_titulo)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_listagemTitulo
   // 
   this.lbl_listagemTitulo.AutoSize = true;
   this.lbl_listagemTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lbl_listagemTitulo.Location = new System.Drawing.Point(29, 26);
   this.lbl_listagemTitulo.Name = "lbl_listagemTitulo";
   this.lbl_listagemTitulo.Size = new System.Drawing.Size(192, 25);
   this.lbl_listagemTitulo.TabIndex = 0;
   this.lbl_listagemTitulo.Text = "Listagem de títulos";
   // 
   // dgv_titulo
   // 
   this.dgv_titulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgv_titulo.Location = new System.Drawing.Point(34, 54);
   this.dgv_titulo.Name = "dgv_titulo";
   this.dgv_titulo.Size = new System.Drawing.Size(843, 396);
   this.dgv_titulo.TabIndex = 1;
   this.dgv_titulo.SelectionChanged += new System.EventHandler(this.dgv_titulo_SelectionChanged);
   // 
   // frmListagemTitulo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(889, 479);
   this.Controls.Add(this.dgv_titulo);
   this.Controls.Add(this.lbl_listagemTitulo);
   this.Name = "frmListagemTitulo";
   this.Text = "Listagem de títulos";
   this.Load += new System.EventHandler(this.frmListagemTitulo_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgv_titulo)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_listagemTitulo;
    private System.Windows.Forms.DataGridView dgv_titulo;
  }
}