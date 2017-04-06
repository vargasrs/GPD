namespace ContasPagar
{
  partial class frmListagemHistorico
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
      this.lbl_lishis = new System.Windows.Forms.Label();
      this.dgv_historico = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).BeginInit();
      this.SuspendLayout();
      // 
      // lbl_lishis
      // 
      this.lbl_lishis.AutoSize = true;
      this.lbl_lishis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_lishis.Location = new System.Drawing.Point(24, 13);
      this.lbl_lishis.Name = "lbl_lishis";
      this.lbl_lishis.Size = new System.Drawing.Size(171, 25);
      this.lbl_lishis.TabIndex = 0;
      this.lbl_lishis.Text = "Listagem Histórico";
      // 
      // dgv_historico
      // 
      this.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_historico.Location = new System.Drawing.Point(29, 41);
      this.dgv_historico.Name = "dgv_historico";
      this.dgv_historico.Size = new System.Drawing.Size(543, 337);
      this.dgv_historico.TabIndex = 1;
      this.dgv_historico.SelectionChanged += new System.EventHandler(this.dgv_historico_SelectionChanged);
      // 
      // frmListagemHistorico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 390);
      this.Controls.Add(this.dgv_historico);
      this.Controls.Add(this.lbl_lishis);
      this.Name = "frmListagemHistorico";
      this.Text = "Listagem Histórico";
      this.Load += new System.EventHandler(this.frmListagemHistorico_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_lishis;
    private System.Windows.Forms.DataGridView dgv_historico;
  }
}