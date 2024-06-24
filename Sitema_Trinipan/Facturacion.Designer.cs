namespace Sitema_Trinipan
{
    partial class Facturacion
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
            this.components = new System.ComponentModel.Container();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_vendedor = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.bnt_Facturar = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Colocar = new System.Windows.Forms.Button();
            this.TexBox_CodigoCliente = new LibreriaDLL.ErrorTexBox();
            this.TexBox_NombreCliente = new LibreriaDLL.ErrorTexBox();
            this.TexBox_CodigoArticulo = new LibreriaDLL.ErrorTexBox();
            this.TexBox_DescripcionArticulo = new LibreriaDLL.ErrorTexBox();
            this.TexBox_PrecioArticulo = new LibreriaDLL.ErrorTexBox();
            this.TexBox_CantidadArticulo = new LibreriaDLL.ErrorTexBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(968, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(665, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "Precio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(315, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Descripcion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Codigo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(399, 31);
            this.label10.TabIndex = 52;
            this.label10.Text = "Ingresa los datos del articulo:";
            // 
            // lbl_vendedor
            // 
            this.lbl_vendedor.BackColor = System.Drawing.Color.White;
            this.lbl_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendedor.Location = new System.Drawing.Point(115, 110);
            this.lbl_vendedor.Name = "lbl_vendedor";
            this.lbl_vendedor.Size = new System.Drawing.Size(308, 25);
            this.lbl_vendedor.TabIndex = 51;
            this.lbl_vendedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.AutoSize = true;
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(1139, 286);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(87, 30);
            this.btn_Nuevo.TabIndex = 50;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.BackColor = System.Drawing.Color.White;
            this.lbl_Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(993, 821);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(243, 30);
            this.lbl_Total.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(915, 822);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 48;
            this.label9.Text = "Total:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1007, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "Importe";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 39);
            this.label5.TabIndex = 42;
            this.label5.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 39);
            this.label4.TabIndex = 41;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 39);
            this.label3.TabIndex = 40;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 39);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(581, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 238);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Importe});
            this.dataGridView1.Location = new System.Drawing.Point(21, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 364);
            this.dataGridView1.TabIndex = 46;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 244;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 246;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 244;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 248;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 246;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Vendedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cliente:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.AutoSize = true;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(812, 286);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(83, 30);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // bnt_Facturar
            // 
            this.bnt_Facturar.AutoSize = true;
            this.bnt_Facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Facturar.Location = new System.Drawing.Point(1026, 286);
            this.bnt_Facturar.Name = "bnt_Facturar";
            this.bnt_Facturar.Size = new System.Drawing.Size(87, 30);
            this.bnt_Facturar.TabIndex = 36;
            this.bnt_Facturar.Text = "Facturar";
            this.bnt_Facturar.UseVisualStyleBackColor = true;
            this.bnt_Facturar.Click += new System.EventHandler(this.bnt_Facturar_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.AutoSize = true;
            this.btn_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Productos.Location = new System.Drawing.Point(690, 286);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(100, 30);
            this.btn_Productos.TabIndex = 35;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.AutoSize = true;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(447, 161);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 30);
            this.btn_Buscar.TabIndex = 34;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.AutoSize = true;
            this.btn_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.Location = new System.Drawing.Point(581, 286);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(84, 30);
            this.btn_Clientes.TabIndex = 33;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Colocar
            // 
            this.btn_Colocar.AutoSize = true;
            this.btn_Colocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Colocar.Location = new System.Drawing.Point(920, 286);
            this.btn_Colocar.Name = "btn_Colocar";
            this.btn_Colocar.Size = new System.Drawing.Size(81, 30);
            this.btn_Colocar.TabIndex = 32;
            this.btn_Colocar.Text = "Colocar";
            this.btn_Colocar.UseVisualStyleBackColor = true;
            this.btn_Colocar.Click += new System.EventHandler(this.btn_Colocar_Click);
            // 
            // TexBox_CodigoCliente
            // 
            this.TexBox_CodigoCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_CodigoCliente.Location = new System.Drawing.Point(115, 161);
            this.TexBox_CodigoCliente.Name = "TexBox_CodigoCliente";
            this.TexBox_CodigoCliente.Size = new System.Drawing.Size(308, 26);
            this.TexBox_CodigoCliente.TabIndex = 57;
            this.TexBox_CodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_CodigoCliente.Validar = true;
            this.TexBox_CodigoCliente.ValidarNumeros = true;
            this.TexBox_CodigoCliente.TextChanged += new System.EventHandler(this.TexBox_CodigoCliente_TextChanged);
            // 
            // TexBox_NombreCliente
            // 
            this.TexBox_NombreCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_NombreCliente.Location = new System.Drawing.Point(115, 215);
            this.TexBox_NombreCliente.Name = "TexBox_NombreCliente";
            this.TexBox_NombreCliente.Size = new System.Drawing.Size(308, 26);
            this.TexBox_NombreCliente.TabIndex = 58;
            this.TexBox_NombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_NombreCliente.Validar = true;
            this.TexBox_NombreCliente.ValidarNumeros = false;
            // 
            // TexBox_CodigoArticulo
            // 
            this.TexBox_CodigoArticulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_CodigoArticulo.Location = new System.Drawing.Point(97, 351);
            this.TexBox_CodigoArticulo.Name = "TexBox_CodigoArticulo";
            this.TexBox_CodigoArticulo.Size = new System.Drawing.Size(200, 26);
            this.TexBox_CodigoArticulo.TabIndex = 59;
            this.TexBox_CodigoArticulo.Validar = false;
            this.TexBox_CodigoArticulo.ValidarNumeros = false;
            // 
            // TexBox_DescripcionArticulo
            // 
            this.TexBox_DescripcionArticulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_DescripcionArticulo.Location = new System.Drawing.Point(429, 351);
            this.TexBox_DescripcionArticulo.Name = "TexBox_DescripcionArticulo";
            this.TexBox_DescripcionArticulo.Size = new System.Drawing.Size(200, 26);
            this.TexBox_DescripcionArticulo.TabIndex = 60;
            this.TexBox_DescripcionArticulo.Validar = false;
            this.TexBox_DescripcionArticulo.ValidarNumeros = false;
            // 
            // TexBox_PrecioArticulo
            // 
            this.TexBox_PrecioArticulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_PrecioArticulo.Location = new System.Drawing.Point(735, 348);
            this.TexBox_PrecioArticulo.Name = "TexBox_PrecioArticulo";
            this.TexBox_PrecioArticulo.Size = new System.Drawing.Size(200, 26);
            this.TexBox_PrecioArticulo.TabIndex = 61;
            this.TexBox_PrecioArticulo.Validar = false;
            this.TexBox_PrecioArticulo.ValidarNumeros = false;
            // 
            // TexBox_CantidadArticulo
            // 
            this.TexBox_CantidadArticulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_CantidadArticulo.Location = new System.Drawing.Point(1055, 348);
            this.TexBox_CantidadArticulo.Name = "TexBox_CantidadArticulo";
            this.TexBox_CantidadArticulo.Size = new System.Drawing.Size(200, 26);
            this.TexBox_CantidadArticulo.TabIndex = 62;
            this.TexBox_CantidadArticulo.Validar = false;
            this.TexBox_CantidadArticulo.ValidarNumeros = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(89, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(357, 47);
            this.label15.TabIndex = 63;
            this.label15.Text = "FACTURACIÓN";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 886);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TexBox_CantidadArticulo);
            this.Controls.Add(this.TexBox_PrecioArticulo);
            this.Controls.Add(this.TexBox_DescripcionArticulo);
            this.Controls.Add(this.TexBox_CodigoArticulo);
            this.Controls.Add(this.TexBox_NombreCliente);
            this.Controls.Add(this.TexBox_CodigoCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_vendedor);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.bnt_Facturar);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Clientes);
            this.Controls.Add(this.btn_Colocar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1291, 925);
            this.MinimumSize = new System.Drawing.Size(1291, 925);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_vendedor;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button bnt_Facturar;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Colocar;
        private LibreriaDLL.ErrorTexBox TexBox_CodigoCliente;
        private LibreriaDLL.ErrorTexBox TexBox_NombreCliente;
        private LibreriaDLL.ErrorTexBox TexBox_CodigoArticulo;
        private LibreriaDLL.ErrorTexBox TexBox_DescripcionArticulo;
        private LibreriaDLL.ErrorTexBox TexBox_PrecioArticulo;
        private LibreriaDLL.ErrorTexBox TexBox_CantidadArticulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label15;
    }
}