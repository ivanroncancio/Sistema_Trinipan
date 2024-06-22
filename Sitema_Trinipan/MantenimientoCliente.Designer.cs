namespace Sitema_Trinipan
{
    partial class MantenimientoCliente
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TexBox_ApellidoCliente = new LibreriaDLL.ErrorTexBox();
            this.TexBox_NombreCliente = new LibreriaDLL.ErrorTexBox();
            this.TexBox_idCliente = new LibreriaDLL.ErrorTexBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 45);
            this.label4.TabIndex = 50;
            this.label4.Text = "CLIENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Id Cliente:";
            // 
            // TexBox_ApellidoCliente
            // 
            this.TexBox_ApellidoCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_ApellidoCliente.Location = new System.Drawing.Point(192, 260);
            this.TexBox_ApellidoCliente.Name = "TexBox_ApellidoCliente";
            this.TexBox_ApellidoCliente.Size = new System.Drawing.Size(237, 26);
            this.TexBox_ApellidoCliente.TabIndex = 46;
            this.TexBox_ApellidoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_ApellidoCliente.Validar = true;
            this.TexBox_ApellidoCliente.ValidarNumeros = false;
            // 
            // TexBox_NombreCliente
            // 
            this.TexBox_NombreCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_NombreCliente.Location = new System.Drawing.Point(192, 212);
            this.TexBox_NombreCliente.Name = "TexBox_NombreCliente";
            this.TexBox_NombreCliente.Size = new System.Drawing.Size(237, 26);
            this.TexBox_NombreCliente.TabIndex = 45;
            this.TexBox_NombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_NombreCliente.Validar = true;
            this.TexBox_NombreCliente.ValidarNumeros = false;
            // 
            // TexBox_idCliente
            // 
            this.TexBox_idCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_idCliente.Location = new System.Drawing.Point(192, 164);
            this.TexBox_idCliente.Name = "TexBox_idCliente";
            this.TexBox_idCliente.Size = new System.Drawing.Size(237, 26);
            this.TexBox_idCliente.TabIndex = 44;
            this.TexBox_idCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_idCliente.Validar = true;
            this.TexBox_idCliente.ValidarNumeros = true;
            this.TexBox_idCliente.TextChanged += new System.EventHandler(this.TexBox_idCliente_TextChanged);
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TexBox_ApellidoCliente);
            this.Controls.Add(this.TexBox_NombreCliente);
            this.Controls.Add(this.TexBox_idCliente);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Controls.SetChildIndex(this.btn_Consultar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.TexBox_idCliente, 0);
            this.Controls.SetChildIndex(this.TexBox_NombreCliente, 0);
            this.Controls.SetChildIndex(this.TexBox_ApellidoCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LibreriaDLL.ErrorTexBox TexBox_ApellidoCliente;
        private LibreriaDLL.ErrorTexBox TexBox_NombreCliente;
        private LibreriaDLL.ErrorTexBox TexBox_idCliente;
    }
}