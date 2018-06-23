namespace sistemadia
{
    partial class frm_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_stock));
            this.GridVw_producto = new System.Windows.Forms.DataGridView();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.tipotxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.preciotxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.disponibilidadtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.nombreproductotxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.codigo_productotxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_Nuevo_Producto = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Codigo_Producto = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.lbl_disponibilidad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.bnt_stock = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_producto)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.GridVw_producto.Location = new System.Drawing.Point(47, 116);
            this.GridVw_producto.Name = "GridVw_producto";
            this.GridVw_producto.RowHeadersVisible = false;
            this.GridVw_producto.Size = new System.Drawing.Size(616, 453);
            this.GridVw_producto.TabIndex = 3;
            this.GridVw_producto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVw_producto_CellContentClick);
            this.GridVw_producto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridVw_producto_CellFormatting);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuCards1.Controls.Add(this.btn_eliminar);
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
            this.bunifuCards1.Location = new System.Drawing.Point(683, 116);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(370, 534);
            this.bunifuCards1.TabIndex = 6;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Green;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(123, 481);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(166, 32);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.tipotxt.Location = new System.Drawing.Point(123, 411);
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
            this.preciotxt.Location = new System.Drawing.Point(123, 358);
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
            this.disponibilidadtxt.Location = new System.Drawing.Point(123, 302);
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
            this.nombreproductotxt.Location = new System.Drawing.Point(123, 251);
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
            this.codigo_productotxt.Location = new System.Drawing.Point(123, 201);
            this.codigo_productotxt.Margin = new System.Windows.Forms.Padding(4);
            this.codigo_productotxt.Name = "codigo_productotxt";
            this.codigo_productotxt.Size = new System.Drawing.Size(166, 29);
            this.codigo_productotxt.TabIndex = 6;
            this.codigo_productotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.codigo_productotxt.OnValueChanged += new System.EventHandler(this.codigo_productotxt_OnValueChanged);
            // 
            // lbl_Nuevo_Producto
            // 
            this.lbl_Nuevo_Producto.AutoSize = true;
            this.lbl_Nuevo_Producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nuevo_Producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.lbl_Nuevo_Producto.Location = new System.Drawing.Point(71, 20);
            this.lbl_Nuevo_Producto.Name = "lbl_Nuevo_Producto";
            this.lbl_Nuevo_Producto.Size = new System.Drawing.Size(247, 23);
            this.lbl_Nuevo_Producto.TabIndex = 16;
            this.lbl_Nuevo_Producto.Text = "Mantenimiento productos";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Tipo.Location = new System.Drawing.Point(188, 394);
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
            this.lbl_Codigo_Producto.Location = new System.Drawing.Point(151, 184);
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
            this.lbl_Precio.Location = new System.Drawing.Point(188, 339);
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
            this.lbl_NombreProducto.Location = new System.Drawing.Point(151, 234);
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
            this.lbl_disponibilidad.Location = new System.Drawing.Point(164, 285);
            this.lbl_disponibilidad.Name = "lbl_disponibilidad";
            this.lbl_disponibilidad.Size = new System.Drawing.Size(83, 13);
            this.lbl_disponibilidad.TabIndex = 11;
            this.lbl_disponibilidad.Text = "Disponibilidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.Guardar.Location = new System.Drawing.Point(123, 443);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(166, 32);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Actualiza[Enter]";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_selecionar.FlatAppearance.BorderSize = 0;
            this.btn_selecionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_selecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selecionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_selecionar.Image = ((System.Drawing.Image)(resources.GetObject("btn_selecionar.Image")));
            this.btn_selecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_selecionar.Location = new System.Drawing.Point(64, 599);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(226, 32);
            this.btn_selecionar.TabIndex = 7;
            this.btn_selecionar.Text = "Selecionar [F9]";
            this.btn_selecionar.UseVisualStyleBackColor = false;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // bnt_stock
            // 
            this.bnt_stock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bnt_stock.FlatAppearance.BorderSize = 0;
            this.bnt_stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.bnt_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bnt_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_stock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnt_stock.Image = ((System.Drawing.Image)(resources.GetObject("bnt_stock.Image")));
            this.bnt_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_stock.Location = new System.Drawing.Point(373, 599);
            this.bnt_stock.Name = "bnt_stock";
            this.bnt_stock.Size = new System.Drawing.Size(226, 32);
            this.bnt_stock.TabIndex = 8;
            this.bnt_stock.Text = "stocks bajos";
            this.bnt_stock.UseVisualStyleBackColor = false;
            this.bnt_stock.Click += new System.EventHandler(this.bnt_stock_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_buscar.HintForeColor = System.Drawing.Color.Empty;
            this.txt_buscar.HintText = "";
            this.txt_buscar.isPassword = false;
            this.txt_buscar.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_buscar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.txt_buscar.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txt_buscar.LineThickness = 3;
            this.txt_buscar.Location = new System.Drawing.Point(166, 55);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(379, 33);
            this.txt_buscar.TabIndex = 11;
            this.txt_buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_buscar.OnValueChanged += new System.EventHandler(this.txt_buscar_OnValueChanged);
            // 
            // frm_stock
            // 
            this.AcceptButton = this.Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1078, 657);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bnt_stock);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.GridVw_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_stock";
            this.Text = "frm_stock";
            this.Load += new System.EventHandler(this.frm_stock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_stock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_producto)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVw_producto;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tipotxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox preciotxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox disponibilidadtxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox nombreproductotxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox codigo_productotxt;
        private System.Windows.Forms.Label lbl_Nuevo_Producto;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_Codigo_Producto;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.Label lbl_disponibilidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Button bnt_stock;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_buscar;
    }
}