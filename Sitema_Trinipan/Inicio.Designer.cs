namespace Sitema_Trinipan
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.bnt_INICIAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_INICIAR
            // 
            this.bnt_INICIAR.AutoSize = true;
            this.bnt_INICIAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnt_INICIAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_INICIAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_INICIAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bnt_INICIAR.FlatAppearance.BorderSize = 3;
            this.bnt_INICIAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bnt_INICIAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bnt_INICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_INICIAR.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_INICIAR.Image = ((System.Drawing.Image)(resources.GetObject("bnt_INICIAR.Image")));
            this.bnt_INICIAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_INICIAR.Location = new System.Drawing.Point(41, 265);
            this.bnt_INICIAR.Name = "bnt_INICIAR";
            this.bnt_INICIAR.Size = new System.Drawing.Size(205, 72);
            this.bnt_INICIAR.TabIndex = 5;
            this.bnt_INICIAR.Text = "INICIO";
            this.bnt_INICIAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnt_INICIAR.UseVisualStyleBackColor = false;
            this.bnt_INICIAR.Click += new System.EventHandler(this.bnt_INICIAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(289, 360);
            this.Controls.Add(this.bnt_INICIAR);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 399);
            this.MinimumSize = new System.Drawing.Size(305, 399);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_INICIAR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}