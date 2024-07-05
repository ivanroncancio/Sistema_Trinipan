namespace Sitema_Trinipan
{
    partial class ReporteVentas
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
            this.reportViewer_ventas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_ventas
            // 
            this.reportViewer_ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_ventas.LocalReport.ReportEmbeddedResource = "Sitema_Trinipan.Report2.rdlc";
            this.reportViewer_ventas.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_ventas.Name = "reportViewer_ventas";
            this.reportViewer_ventas.ServerReport.BearerToken = null;
            this.reportViewer_ventas.Size = new System.Drawing.Size(645, 635);
            this.reportViewer_ventas.TabIndex = 0;
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 635);
            this.Controls.Add(this.reportViewer_ventas);
            this.Name = "ReporteVentas";
            this.Text = "ReporteVentas";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer_ventas;
    }
}