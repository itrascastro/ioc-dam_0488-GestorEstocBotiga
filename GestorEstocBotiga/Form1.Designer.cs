namespace GestorEstocBotiga;

partial class Form1
{
    private System.ComponentModel.IContainer components = null!;

    private System.Windows.Forms.MenuStrip menuPrincipal = null!;
    private System.Windows.Forms.ToolStripMenuItem menuFitxer = null!;
    private System.Windows.Forms.ToolStripMenuItem menuSortir = null!;
    private System.Windows.Forms.ToolStripMenuItem menuAjuda = null!;
    private System.Windows.Forms.ToolStripMenuItem menuQuantA = null!;

    private System.Windows.Forms.SplitContainer splitPrincipal = null!;
    private System.Windows.Forms.DataGridView dgvProductes = null!;

    private System.Windows.Forms.GroupBox grpDetall = null!;
    private System.Windows.Forms.TableLayoutPanel layoutDetall = null!;
    private System.Windows.Forms.Label lblNomProducte = null!;
    private GestorEstocBotiga.IndicadorEstoc indicadorEstoc1 = null!;
    private System.Windows.Forms.Panel panellAjust = null!;
    private System.Windows.Forms.Label lblAjustEstoc = null!;
    private System.Windows.Forms.NumericUpDown nudEstoc = null!;
    private System.Windows.Forms.FlowLayoutPanel layoutBotons = null!;
    private System.Windows.Forms.Button btnReaprovisiona = null!;
    private System.Windows.Forms.Button btnDesa = null!;

    private System.Windows.Forms.StatusStrip statusPrincipal = null!;
    private System.Windows.Forms.ToolStripStatusLabel lblEstatGeneral = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();

        this.menuPrincipal = new System.Windows.Forms.MenuStrip();
        this.menuFitxer = new System.Windows.Forms.ToolStripMenuItem();
        this.menuSortir = new System.Windows.Forms.ToolStripMenuItem();
        this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
        this.menuQuantA = new System.Windows.Forms.ToolStripMenuItem();

        this.splitPrincipal = new System.Windows.Forms.SplitContainer();
        this.dgvProductes = new System.Windows.Forms.DataGridView();

        this.grpDetall = new System.Windows.Forms.GroupBox();
        this.layoutDetall = new System.Windows.Forms.TableLayoutPanel();
        this.lblNomProducte = new System.Windows.Forms.Label();
        this.indicadorEstoc1 = new GestorEstocBotiga.IndicadorEstoc();
        this.panellAjust = new System.Windows.Forms.Panel();
        this.lblAjustEstoc = new System.Windows.Forms.Label();
        this.nudEstoc = new System.Windows.Forms.NumericUpDown();
        this.layoutBotons = new System.Windows.Forms.FlowLayoutPanel();
        this.btnReaprovisiona = new System.Windows.Forms.Button();
        this.btnDesa = new System.Windows.Forms.Button();

        this.statusPrincipal = new System.Windows.Forms.StatusStrip();
        this.lblEstatGeneral = new System.Windows.Forms.ToolStripStatusLabel();

        this.menuPrincipal.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).BeginInit();
        this.splitPrincipal.Panel1.SuspendLayout();
        this.splitPrincipal.Panel2.SuspendLayout();
        this.splitPrincipal.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvProductes)).BeginInit();
        this.grpDetall.SuspendLayout();
        this.layoutDetall.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudEstoc)).BeginInit();
        this.layoutBotons.SuspendLayout();
        this.statusPrincipal.SuspendLayout();
        this.SuspendLayout();
        //
        // menuPrincipal
        //
        this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFitxer,
            this.menuAjuda});
        this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
        this.menuPrincipal.Name = "menuPrincipal";
        this.menuPrincipal.Size = new System.Drawing.Size(900, 24);
        this.menuPrincipal.TabIndex = 0;
        //
        // menuFitxer
        //
        this.menuFitxer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSortir});
        this.menuFitxer.Name = "menuFitxer";
        this.menuFitxer.Text = "&Fitxer";
        //
        // menuSortir
        //
        this.menuSortir.Name = "menuSortir";
        this.menuSortir.Text = "&Sortir";
        this.menuSortir.Click += new System.EventHandler(this.MenuSortir_Click);
        //
        // menuAjuda
        //
        this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuantA});
        this.menuAjuda.Name = "menuAjuda";
        this.menuAjuda.Text = "A&juda";
        //
        // menuQuantA
        //
        this.menuQuantA.Name = "menuQuantA";
        this.menuQuantA.Text = "&Quant a...";
        this.menuQuantA.Click += new System.EventHandler(this.MenuQuantA_Click);
        //
        // splitPrincipal
        //
        this.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitPrincipal.Location = new System.Drawing.Point(0, 24);
        this.splitPrincipal.Name = "splitPrincipal";
        //
        // splitPrincipal.Panel1
        //
        this.splitPrincipal.Panel1.Controls.Add(this.dgvProductes);
        //
        // splitPrincipal.Panel2
        //
        this.splitPrincipal.Panel2.Controls.Add(this.grpDetall);
        this.splitPrincipal.Size = new System.Drawing.Size(900, 476);
        this.splitPrincipal.SplitterDistance = 500;
        this.splitPrincipal.TabIndex = 1;
        //
        // dgvProductes
        //
        this.dgvProductes.AllowUserToAddRows = false;
        this.dgvProductes.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvProductes.Location = new System.Drawing.Point(0, 0);
        this.dgvProductes.Name = "dgvProductes";
        this.dgvProductes.ReadOnly = true;
        this.dgvProductes.RowHeadersWidth = 25;
        this.dgvProductes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvProductes.MultiSelect = false;
        this.dgvProductes.Size = new System.Drawing.Size(500, 476);
        this.dgvProductes.TabIndex = 0;
        this.dgvProductes.SelectionChanged += new System.EventHandler(this.DgvProductes_SelectionChanged);
        //
        // grpDetall
        //
        this.grpDetall.Controls.Add(this.layoutDetall);
        this.grpDetall.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpDetall.Location = new System.Drawing.Point(0, 0);
        this.grpDetall.Name = "grpDetall";
        this.grpDetall.Padding = new System.Windows.Forms.Padding(10);
        this.grpDetall.Size = new System.Drawing.Size(396, 476);
        this.grpDetall.TabIndex = 0;
        this.grpDetall.TabStop = false;
        this.grpDetall.Text = "Detall del producte seleccionat";
        //
        // layoutDetall
        //
        this.layoutDetall.ColumnCount = 1;
        this.layoutDetall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.layoutDetall.Dock = System.Windows.Forms.DockStyle.Fill;
        this.layoutDetall.RowCount = 4;
        this.layoutDetall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
        this.layoutDetall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
        this.layoutDetall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        this.layoutDetall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
        this.layoutDetall.Location = new System.Drawing.Point(10, 23);
        this.layoutDetall.Name = "layoutDetall";
        this.layoutDetall.Controls.Add(this.lblNomProducte, 0, 0);
        this.layoutDetall.Controls.Add(this.indicadorEstoc1, 0, 1);
        this.layoutDetall.Controls.Add(this.panellAjust, 0, 2);
        this.layoutDetall.Controls.Add(this.layoutBotons, 0, 3);
        this.layoutDetall.Size = new System.Drawing.Size(376, 443);
        this.layoutDetall.TabIndex = 0;
        //
        // lblNomProducte
        //
        this.lblNomProducte.AutoSize = true;
        this.lblNomProducte.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblNomProducte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblNomProducte.Location = new System.Drawing.Point(3, 0);
        this.lblNomProducte.Name = "lblNomProducte";
        this.lblNomProducte.Text = "(cap producte seleccionat)";
        this.lblNomProducte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // indicadorEstoc1
        //
        this.indicadorEstoc1.Dock = System.Windows.Forms.DockStyle.Top;
        this.indicadorEstoc1.Location = new System.Drawing.Point(3, 35);
        this.indicadorEstoc1.Name = "indicadorEstoc1";
        this.indicadorEstoc1.PercentatgeEstoc = 0;
        this.indicadorEstoc1.Size = new System.Drawing.Size(240, 28);
        this.indicadorEstoc1.TabIndex = 1;
        //
        // panellAjust
        //
        this.panellAjust.Controls.Add(this.nudEstoc);
        this.panellAjust.Controls.Add(this.lblAjustEstoc);
        this.panellAjust.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panellAjust.Location = new System.Drawing.Point(3, 95);
        this.panellAjust.Name = "panellAjust";
        //
        // lblAjustEstoc
        //
        this.lblAjustEstoc.AutoSize = true;
        this.lblAjustEstoc.Location = new System.Drawing.Point(3, 3);
        this.lblAjustEstoc.Name = "lblAjustEstoc";
        this.lblAjustEstoc.Text = "Ajustar estoc:";
        //
        // nudEstoc
        //
        this.nudEstoc.Location = new System.Drawing.Point(3, 24);
        this.nudEstoc.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        this.nudEstoc.Name = "nudEstoc";
        this.nudEstoc.Width = 120;
        this.nudEstoc.ValueChanged += new System.EventHandler(this.NudEstoc_ValueChanged);
        //
        // layoutBotons
        //
        this.layoutBotons.Controls.Add(this.btnReaprovisiona);
        this.layoutBotons.Controls.Add(this.btnDesa);
        this.layoutBotons.Dock = System.Windows.Forms.DockStyle.Fill;
        this.layoutBotons.Location = new System.Drawing.Point(3, 399);
        this.layoutBotons.Name = "layoutBotons";
        //
        // btnReaprovisiona
        //
        this.btnReaprovisiona.AutoSize = true;
        this.btnReaprovisiona.Name = "btnReaprovisiona";
        this.btnReaprovisiona.Text = "Reaprovisiona";
        this.btnReaprovisiona.Click += new System.EventHandler(this.BtnReaprovisiona_Click);
        //
        // btnDesa
        //
        this.btnDesa.AutoSize = true;
        this.btnDesa.Name = "btnDesa";
        this.btnDesa.Text = "Desa";
        this.btnDesa.Click += new System.EventHandler(this.BtnDesa_Click);
        //
        // statusPrincipal
        //
        this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstatGeneral});
        this.statusPrincipal.Location = new System.Drawing.Point(0, 500);
        this.statusPrincipal.Name = "statusPrincipal";
        this.statusPrincipal.Size = new System.Drawing.Size(900, 22);
        this.statusPrincipal.TabIndex = 2;
        //
        // lblEstatGeneral
        //
        this.lblEstatGeneral.Name = "lblEstatGeneral";
        this.lblEstatGeneral.Text = "Estat: -";
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 522);
        this.Controls.Add(this.splitPrincipal);
        this.Controls.Add(this.statusPrincipal);
        this.Controls.Add(this.menuPrincipal);
        this.MainMenuStrip = this.menuPrincipal;
        this.MinimumSize = new System.Drawing.Size(700, 400);
        this.Name = "Form1";
        this.Text = "GestorEstocBotiga - Control d'estoc de la botiga";
        this.menuPrincipal.ResumeLayout(false);
        this.menuPrincipal.PerformLayout();
        this.splitPrincipal.Panel1.ResumeLayout(false);
        this.splitPrincipal.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).EndInit();
        this.splitPrincipal.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvProductes)).EndInit();
        this.grpDetall.ResumeLayout(false);
        this.layoutDetall.ResumeLayout(false);
        this.layoutDetall.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudEstoc)).EndInit();
        this.layoutBotons.ResumeLayout(false);
        this.layoutBotons.PerformLayout();
        this.statusPrincipal.ResumeLayout(false);
        this.statusPrincipal.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
