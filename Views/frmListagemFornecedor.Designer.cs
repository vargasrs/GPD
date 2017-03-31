namespace ContasPagar
{
 partial class frmListagemFornecedor
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
   this.lbl_listagemfornecedor = new System.Windows.Forms.Label();
   this.dgv_fornecedor = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedor)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_listagemfornecedor
   // 
   this.lbl_listagemfornecedor.AutoSize = true;
   this.lbl_listagemfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lbl_listagemfornecedor.Location = new System.Drawing.Point(12, 9);
   this.lbl_listagemfornecedor.Name = "lbl_listagemfornecedor";
   this.lbl_listagemfornecedor.Size = new System.Drawing.Size(215, 25);
   this.lbl_listagemfornecedor.TabIndex = 0;
   this.lbl_listagemfornecedor.Text = "Listagem Fornecedor";
   // 
   // dgv_fornecedor
   // 
   this.dgv_fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgv_fornecedor.Location = new System.Drawing.Point(17, 37);
   this.dgv_fornecedor.Name = "dgv_fornecedor";
   this.dgv_fornecedor.Size = new System.Drawing.Size(486, 313);
   this.dgv_fornecedor.TabIndex = 1;
   this.dgv_fornecedor.SelectionChanged += new System.EventHandler(this.dgv_fornecedor_SelectionChanged);
   // 
   // frmListagemFornecedor
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(515, 372);
   this.Controls.Add(this.dgv_fornecedor);
   this.Controls.Add(this.lbl_listagemfornecedor);
   this.Name = "frmListagemFornecedor";
   this.Text = "Listagem Fornecedor";
   this.Load += new System.EventHandler(this.frmListagemFornecedor_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedor)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_listagemfornecedor;
  private System.Windows.Forms.DataGridView dgv_fornecedor;
 }
}