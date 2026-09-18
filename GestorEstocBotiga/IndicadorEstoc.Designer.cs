namespace GestorEstocBotiga
{
    partial class IndicadorEstoc
    {
        private System.ComponentModel.IContainer components = null!;
        private System.Windows.Forms.Panel iconaEstat = null!;
        private System.Windows.Forms.ProgressBar barraEstoc = null!;
        private System.Windows.Forms.Label lblPercentatge = null!;
        private System.Windows.Forms.ToolTip toolTipEstoc = null!;

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
            this.iconaEstat = new System.Windows.Forms.Panel();
            this.barraEstoc = new System.Windows.Forms.ProgressBar();
            this.lblPercentatge = new System.Windows.Forms.Label();
            this.toolTipEstoc = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            //
            // iconaEstat
            //
            this.iconaEstat.BackColor = System.Drawing.Color.Firebrick;
            this.iconaEstat.Location = new System.Drawing.Point(3, 3);
            this.iconaEstat.Name = "iconaEstat";
            this.iconaEstat.Size = new System.Drawing.Size(20, 20);
            this.iconaEstat.TabIndex = 0;
            //
            // barraEstoc
            //
            this.barraEstoc.Location = new System.Drawing.Point(29, 3);
            this.barraEstoc.Name = "barraEstoc";
            this.barraEstoc.Size = new System.Drawing.Size(160, 20);
            this.barraEstoc.TabIndex = 1;
            //
            // lblPercentatge
            //
            this.lblPercentatge.AutoSize = true;
            this.lblPercentatge.Location = new System.Drawing.Point(195, 7);
            this.lblPercentatge.Name = "lblPercentatge";
            this.lblPercentatge.Size = new System.Drawing.Size(35, 15);
            this.lblPercentatge.TabIndex = 2;
            this.lblPercentatge.Text = "0 %";
            //
            // IndicadorEstoc
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPercentatge);
            this.Controls.Add(this.barraEstoc);
            this.Controls.Add(this.iconaEstat);
            this.Name = "IndicadorEstoc";
            this.Size = new System.Drawing.Size(240, 28);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
