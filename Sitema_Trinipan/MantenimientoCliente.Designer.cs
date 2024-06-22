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
            this.TexBox_Precio = new LibreriaDLL.ErrorTexBox();
            this.TexBox_Descripcion = new LibreriaDLL.ErrorTexBox();
            this.TexBox_idProducto = new LibreriaDLL.ErrorTexBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // TexBox_Precio
            // 
            this.TexBox_Precio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Precio.Location = new System.Drawing.Point(192, 260);
            this.TexBox_Precio.Name = "TexBox_Precio";
            this.TexBox_Precio.Size = new System.Drawing.Size(237, 26);
            this.TexBox_Precio.TabIndex = 46;
            this.TexBox_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_Precio.Validar = true;
            this.TexBox_Precio.ValidarNumeros = false;
            // 
            // TexBox_Descripcion
            // 
            this.TexBox_Descripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Descripcion.Location = new System.Drawing.Point(192, 212);
            this.TexBox_Descripcion.Name = "TexBox_Descripcion";
            this.TexBox_Descripcion.Size = new System.Drawing.Size(237, 26);
            this.TexBox_Descripcion.TabIndex = 45;
            this.TexBox_Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_Descripcion.Validar = true;
            this.TexBox_Descripcion.ValidarNumeros = false;
            // 
            // TexBox_idProducto
            // 
            this.TexBox_idProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_idProducto.Location = new System.Drawing.Point(192, 164);
            this.TexBox_idProducto.Name = "TexBox_idProducto";
            this.TexBox_idProducto.Size = new System.Drawing.Size(237, 26);
            this.TexBox_idProducto.TabIndex = 44;
            this.TexBox_idProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_idProducto.Validar = true;
            this.TexBox_idProducto.ValidarNumeros = true;
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
            this.Controls.Add(this.TexBox_Precio);
            this.Controls.Add(this.TexBox_Descripcion);
            this.Controls.Add(this.TexBox_idProducto);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.TexBox_idProducto, 0);
            this.Controls.SetChildIndex(this.TexBox_Descripcion, 0);
            this.Controls.SetChildIndex(this.TexBox_Precio, 0);
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
        private LibreriaDLL.ErrorTexBox TexBox_Precio;
        private LibreriaDLL.ErrorTexBox TexBox_Descripcion;
        private LibreriaDLL.ErrorTexBox TexBox_idProducto;
    }
}