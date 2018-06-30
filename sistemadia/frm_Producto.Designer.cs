namespace sistemadia
{
    partial class frm_Producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Producto));
            this.GridVw_producto = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Nuevo_Producto = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Codigo_Producto = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.lbl_disponibilidad = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.tipotxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.preciotxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.disponibilidadtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.nombreproductotxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.codigo_productotxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridVw_producto
            // 
            this.GridVw_producto.AllowUserToAddRows = false;
            this.GridVw_producto.AllowUserToOrderColumns = true;
            this.GridVw_producto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridVw_producto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridVw_producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVw_producto.BackgroundColor = System.Drawing.Color.White;
            this.GridVw_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVw_producto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVw_producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridVw_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVw_producto.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridVw_producto.EnableHeadersVisualStyles = false;
            this.GridVw_producto.GridColor = System.Drawing.SystemColors.Control;
            this.GridVw_producto.Location = new System.Drawing.Point(24, 78);
            this.GridVw_producto.Name = "GridVw_producto";
            this.GridVw_producto.RowHeadersVisible = false;
            this.GridVw_producto.Size = new System.Drawing.Size(621, 510);
            this.GridVw_producto.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Nuevo_Producto
            // 
            this.lbl_Nuevo_Producto.AutoSize = true;
            this.lbl_Nuevo_Producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nuevo_Producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.lbl_Nuevo_Producto.Location = new System.Drawing.Point(117, 25);
            this.lbl_Nuevo_Producto.Name = "lbl_Nuevo_Producto";
            this.lbl_Nuevo_Producto.Size = new System.Drawing.Size(158, 23);
            this.lbl_Nuevo_Producto.TabIndex = 16;
            this.lbl_Nuevo_Producto.Text = "Nuevo Producto";
           
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Tipo.Location = new System.Drawing.Point(178, 395);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(30, 13);
            this.lbl_Tipo.TabIndex = 15;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // lbl_Codigo_Producto
            // 
            this.lbl_Codigo_Producto.AutoSize = true;
            this.lbl_Codigo_Producto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Producto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Codigo_Producto.Location = new System.Drawing.Point(141, 185);
            this.lbl_Codigo_Producto.Name = "lbl_Codigo_Producto";
            this.lbl_Codigo_Producto.Size = new System.Drawing.Size(96, 13);
            this.lbl_Codigo_Producto.TabIndex = 14;
            this.lbl_Codigo_Producto.Text = "Codigo Producto";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Precio.Location = new System.Drawing.Point(178, 340);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(39, 13);
            this.lbl_Precio.TabIndex = 13;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_NombreProducto.Location = new System.Drawing.Point(141, 235);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(101, 13);
            this.lbl_NombreProducto.TabIndex = 12;
            this.lbl_NombreProducto.Text = "Nombre Producto";
            // 
            // lbl_disponibilidad
            // 
            this.lbl_disponibilidad.AutoSize = true;
            this.lbl_disponibilidad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disponibilidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_disponibilidad.Location = new System.Drawing.Point(154, 286);
            this.lbl_disponibilidad.Name = "lbl_disponibilidad";
            this.lbl_disponibilidad.Size = new System.Drawing.Size(83, 13);
            this.lbl_disponibilidad.TabIndex = 11;
            this.lbl_disponibilidad.Text = "Disponibilidad";
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.Green;
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(113, 453);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(166, 32);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuCards1.Controls.Add(this.tipotxt);
            this.bunifuCards1.Controls.Add(this.preciotxt);
            this.bunifuCards1.Controls.Add(this.disponibilidadtxt);
            this.bunifuCards1.Controls.Add(this.nombreproductotxt);
            this.bunifuCards1.Controls.Add(this.codigo_productotxt);
            this.bunifuCards1.Controls.Add(this.lbl_Nuevo_Producto);
            this.bunifuCards1.Controls.Add(this.lbl_Tipo);
            this.bunifuCards1.Controls.Add(this.lbl_Codigo_Producto);
            this.bunifuCards1.Controls.Add(this.lbl_Precio);
            this.bunifuCards1.Controls.Add(this.lbl_NombreProducto);
            this.bunifuCards1.Controls.Add(this.lbl_disponibilidad);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.Guardar);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(680, 165);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(370, 534);
            this.bunifuCards1.TabIndex = 5;
            // 
            // tipotxt
            // 
            this.tipotxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tipotxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.tipotxt.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.tipotxt.BorderThickness = 2;
            this.tipotxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tipotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tipotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tipotxt.isPassword = false;
            this.tipotxt.Location = new System.Drawing.Point(113, 412);
            this.tipotxt.Margin = new System.Windows.Forms.Padding(4);
            this.tipotxt.Name = "tipotxt";
            this.tipotxt.Size = new System.Drawing.Size(166, 25);
            this.tipotxt.TabIndex = 20;
            this.tipotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // preciotxt
            // 
            this.preciotxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.preciotxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.preciotxt.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.preciotxt.BorderThickness = 2;
            this.preciotxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.preciotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.preciotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.preciotxt.isPassword = false;
            this.preciotxt.Location = new System.Drawing.Point(113, 359);
            this.preciotxt.Margin = new System.Windows.Forms.Padding(4);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(166, 32);
            this.preciotxt.TabIndex = 19;
            this.preciotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
    
            this.preciotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preciotxt_KeyPress);
            // 
            // disponibilidadtxt
            // 
            this.disponibilidadtxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.disponibilidadtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.disponibilidadtxt.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.disponibilidadtxt.BorderThickness = 2;
            this.disponibilidadtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.disponibilidadtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.disponibilidadtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.disponibilidadtxt.isPassword = false;
            this.disponibilidadtxt.Location = new System.Drawing.Point(113, 303);
            this.disponibilidadtxt.Margin = new System.Windows.Forms.Padding(4);
            this.disponibilidadtxt.Name = "disponibilidadtxt";
            this.disponibilidadtxt.Size = new System.Drawing.Size(166, 33);
            this.disponibilidadtxt.TabIndex = 18;
            this.disponibilidadtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.disponibilidadtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disponibilidadtxt_KeyPress);
            // 
            // nombreproductotxt
            // 
            this.nombreproductotxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nombreproductotxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.nombreproductotxt.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.nombreproductotxt.BorderThickness = 2;
            this.nombreproductotxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombreproductotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nombreproductotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nombreproductotxt.isPassword = false;
            this.nombreproductotxt.Location = new System.Drawing.Point(113, 252);
            this.nombreproductotxt.Margin = new System.Windows.Forms.Padding(4);
            this.nombreproductotxt.Name = "nombreproductotxt";
            this.nombreproductotxt.Size = new System.Drawing.Size(166, 30);
            this.nombreproductotxt.TabIndex = 17;
            this.nombreproductotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // codigo_productotxt
            // 
            this.codigo_productotxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.codigo_productotxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.codigo_productotxt.BorderColorMouseHover = System.Drawing.Color.DarkBlue;
            this.codigo_productotxt.BorderThickness = 2;
            this.codigo_productotxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codigo_productotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.codigo_productotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codigo_productotxt.isPassword = false;
            this.codigo_productotxt.Location = new System.Drawing.Point(113, 202);
            this.codigo_productotxt.Margin = new System.Windows.Forms.Padding(4);
            this.codigo_productotxt.Name = "codigo_productotxt";
            this.codigo_productotxt.Size = new System.Drawing.Size(166, 29);
            this.codigo_productotxt.TabIndex = 6;
            this.codigo_productotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Black;
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.pictureBox2);
            this.bunifuCards2.Controls.Add(this.panel1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(795, 12);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(137, 147);
            this.bunifuCards2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(54, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "lab";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 35);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // frm_Producto
            // 
            this.AcceptButton = this.Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 680);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.GridVw_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Producto";
            this.Text = "frm_Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVw_producto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label lbl_disponibilidad;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_Codigo_Producto;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.Label lbl_Nuevo_Producto;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tipotxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox preciotxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox disponibilidadtxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox nombreproductotxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox codigo_productotxt;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}