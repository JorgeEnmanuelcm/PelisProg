namespace PelisProg
{
    partial class CrystalReportForm
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
            this.PelicrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PelicrystalReportViewer
            // 
            this.PelicrystalReportViewer.ActiveViewIndex = -1;
            this.PelicrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PelicrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PelicrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PelicrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PelicrystalReportViewer.Name = "PelicrystalReportViewer";
            this.PelicrystalReportViewer.Size = new System.Drawing.Size(481, 391);
            this.PelicrystalReportViewer.TabIndex = 0;
            // 
            // CrystalReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 391);
            this.Controls.Add(this.PelicrystalReportViewer);
            this.Name = "CrystalReportForm";
            this.Text = "CrystalReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer PelicrystalReportViewer;
    }
}