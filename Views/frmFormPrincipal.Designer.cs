namespace ContasPagar
{
  partial class frmFormPrincipal
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
      this.mnu_principal = new System.Windows.Forms.MenuStrip();
      this.tsp_for = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_forcad = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_forlis = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_tdc = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_tdocad = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_tdolis = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_his = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_hiscad = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_hislis = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_titulo = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_titulocad = new System.Windows.Forms.ToolStripMenuItem();
      this.tsp_titulolis = new System.Windows.Forms.ToolStripMenuItem();
      this.mnu_principal.SuspendLayout();
      this.SuspendLayout();
      // 
      // mnu_principal
      // 
      this.mnu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_for,
            this.tsp_tdc,
            this.tsp_his,
            this.tsp_titulo});
      this.mnu_principal.Location = new System.Drawing.Point(0, 0);
      this.mnu_principal.Name = "mnu_principal";
      this.mnu_principal.Size = new System.Drawing.Size(762, 24);
      this.mnu_principal.TabIndex = 0;
      this.mnu_principal.Text = "Menu Principal";
      // 
      // tsp_for
      // 
      this.tsp_for.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_forcad,
            this.tsp_forlis});
      this.tsp_for.Name = "tsp_for";
      this.tsp_for.Size = new System.Drawing.Size(79, 20);
      this.tsp_for.Text = "Fornecedor";
      // 
      // tsp_forcad
      // 
      this.tsp_forcad.Name = "tsp_forcad";
      this.tsp_forcad.Size = new System.Drawing.Size(152, 22);
      this.tsp_forcad.Text = "Cadastro";
      this.tsp_forcad.Click += new System.EventHandler(this.tsp_forcad_Click);
      // 
      // tsp_forlis
      // 
      this.tsp_forlis.Name = "tsp_forlis";
      this.tsp_forlis.Size = new System.Drawing.Size(152, 22);
      this.tsp_forlis.Text = "Listagem";
      this.tsp_forlis.Click += new System.EventHandler(this.tsp_forlis_Click);
      // 
      // tsp_tdc
      // 
      this.tsp_tdc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_tdocad,
            this.tsp_tdolis});
      this.tsp_tdc.Name = "tsp_tdc";
      this.tsp_tdc.Size = new System.Drawing.Size(125, 20);
      this.tsp_tdc.Text = "Tipo de Documento";
      // 
      // tsp_tdocad
      // 
      this.tsp_tdocad.Name = "tsp_tdocad";
      this.tsp_tdocad.Size = new System.Drawing.Size(152, 22);
      this.tsp_tdocad.Text = "Cadastro";
      this.tsp_tdocad.Click += new System.EventHandler(this.tsp_tdocad_Click);
      // 
      // tsp_tdolis
      // 
      this.tsp_tdolis.Name = "tsp_tdolis";
      this.tsp_tdolis.Size = new System.Drawing.Size(152, 22);
      this.tsp_tdolis.Text = "Listagem";
      this.tsp_tdolis.Click += new System.EventHandler(this.tsp_tdolis_Click);
      // 
      // tsp_his
      // 
      this.tsp_his.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_hiscad,
            this.tsp_hislis});
      this.tsp_his.Name = "tsp_his";
      this.tsp_his.Size = new System.Drawing.Size(67, 20);
      this.tsp_his.Text = "Histórico";
      // 
      // tsp_hiscad
      // 
      this.tsp_hiscad.Name = "tsp_hiscad";
      this.tsp_hiscad.Size = new System.Drawing.Size(152, 22);
      this.tsp_hiscad.Text = "Cadastro";
      this.tsp_hiscad.Click += new System.EventHandler(this.tsp_hiscad_Click);
      // 
      // tsp_hislis
      // 
      this.tsp_hislis.Name = "tsp_hislis";
      this.tsp_hislis.Size = new System.Drawing.Size(152, 22);
      this.tsp_hislis.Text = "Listagem";
      this.tsp_hislis.Click += new System.EventHandler(this.tsp_hislis_Click);
      // 
      // tsp_titulo
      // 
      this.tsp_titulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_titulocad,
            this.tsp_titulolis});
      this.tsp_titulo.Name = "tsp_titulo";
      this.tsp_titulo.Size = new System.Drawing.Size(50, 20);
      this.tsp_titulo.Text = "Título";
      // 
      // tsp_titulocad
      // 
      this.tsp_titulocad.Name = "tsp_titulocad";
      this.tsp_titulocad.Size = new System.Drawing.Size(152, 22);
      this.tsp_titulocad.Text = "Cadastro";
      this.tsp_titulocad.Click += new System.EventHandler(this.tsp_titulocad_Click);
      // 
      // tsp_titulolis
      // 
      this.tsp_titulolis.Name = "tsp_titulolis";
      this.tsp_titulolis.Size = new System.Drawing.Size(152, 22);
      this.tsp_titulolis.Text = "Listagem";
      // 
      // frmFormPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(762, 443);
      this.Controls.Add(this.mnu_principal);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.mnu_principal;
      this.Name = "frmFormPrincipal";
      this.Text = "Contas a Pagar";
      this.mnu_principal.ResumeLayout(false);
      this.mnu_principal.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

  #endregion

  private System.Windows.Forms.MenuStrip mnu_principal;
  private System.Windows.Forms.ToolStripMenuItem tsp_for;
  private System.Windows.Forms.ToolStripMenuItem tsp_forcad;
  private System.Windows.Forms.ToolStripMenuItem tsp_tdc;
  private System.Windows.Forms.ToolStripMenuItem tsp_tdocad;
  private System.Windows.Forms.ToolStripMenuItem tsp_forlis;
  private System.Windows.Forms.ToolStripMenuItem tsp_tdolis;
    private System.Windows.Forms.ToolStripMenuItem tsp_his;
    private System.Windows.Forms.ToolStripMenuItem tsp_hiscad;
    private System.Windows.Forms.ToolStripMenuItem tsp_hislis;
    private System.Windows.Forms.ToolStripMenuItem tsp_titulo;
    private System.Windows.Forms.ToolStripMenuItem tsp_titulocad;
    private System.Windows.Forms.ToolStripMenuItem tsp_titulolis;
  }
}

