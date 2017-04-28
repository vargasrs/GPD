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
   this.dgv_fornecedor = new System.Windows.Forms.DataGridView();
   this.label1 = new System.Windows.Forms.Label();
   ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedor)).BeginInit();
   this.SuspendLayout();
   // 
   // dgv_fornecedor
   // 
   this.dgv_fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgv_fornecedor.Location = new System.Drawing.Point(17, 46);
   this.dgv_fornecedor.Name = "dgv_fornecedor";
   this.dgv_fornecedor.Size = new System.Drawing.Size(535, 260);
   this.dgv_fornecedor.TabIndex = 2;
   this.dgv_fornecedor.SelectionChanged += new System.EventHandler(this.dgv_fornecedor_tab_SelectionChanged);
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(12, 9);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(310, 25);
   this.label1.TabIndex = 3;
   this.label1.Text = "Listagem Fornecedor da tabela";
   // 
   // frmListagemFornecedor
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(564, 318);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.dgv_fornecedor);
   this.Name = "frmListagemFornecedor";
   this.Text = "Listagem Fornecedor";
   this.Load += new System.EventHandler(this.frmListagemFornecedor_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedor)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion
  private System.Windows.Forms.DataGridView dgv_fornecedor;
    private System.Windows.Forms.Label label1;
  }
}