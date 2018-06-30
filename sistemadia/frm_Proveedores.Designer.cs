namespace sistemadia
{
    partial class frm_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Proveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dtView_proveedores = new System.Windows.Forms.DataGridView();
            this.btn_eliminarProveedores = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_Telefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_Direccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_Nombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_idproveedor = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_select = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deleteproductproveedor = new System.Windows.Forms.Button();
            this.btn_addproductproveedor = new System.Windows.Forms.Button();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.btn_addproducto = new System.Windows.Forms.Button();
            this.dtGridView_ProductosdelProveedor = new System.Windows.Forms.DataGridView();
            this.btn_deseleccionar = new System.Windows.Forms.Button();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.txt_Seleccionado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_proveedores)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_ProductosdelProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(119, 121);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(57, 16);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(119, 194);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(65, 16);
            this.lbl_Direccion.TabIndex = 5;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(137, 308);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(42, 16);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(119, 251);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(62, 16);
            this.lbl_Telefono.TabIndex = 7;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Green;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(73, 384);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(163, 31);
            this.btn_Guardar.TabIndex = 8;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dtView_proveedores
            // 
            this.dtView_proveedores.AllowUserToAddRows = false;
            this.dtView_proveedores.AllowUserToDeleteRows = false;
            this.dtView_proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView_proveedores.BackgroundColor = System.Drawing.Color.White;
            this.dtView_proveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtView_proveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView_proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtView_proveedores.ColumnHeadersHeight = 25;
            this.dtView_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView_proveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtView_proveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtView_proveedores.EnableHeadersVisualStyles = false;
            this.dtView_proveedores.GridColor = System.Drawing.SystemColors.Control;
            this.dtView_proveedores.Location = new System.Drawing.Point(22, 12);
            this.dtView_proveedores.Name = "dtView_proveedores";
            this.dtView_proveedores.RowHeadersVisible = false;
            this.dtView_proveedores.Size = new System.Drawing.Size(681, 239);
            this.dtView_proveedores.TabIndex = 10;
            this.dtView_proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.terminaredit);
            this.dtView_proveedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.terminaredit);
            this.dtView_proveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtView_proveedores_OnCellDoubleClick);
            this.dtView_proveedores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtView_proveedores_OnCambiodevalor);
            // 
            // btn_eliminarProveedores
            // 
            this.btn_eliminarProveedores.BackColor = System.Drawing.Color.Green;
            this.btn_eliminarProveedores.Enabled = false;
            this.btn_eliminarProveedores.FlatAppearance.BorderSize = 0;
            this.btn_eliminarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminarProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminarProveedores.Image")));
            this.btn_eliminarProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarProveedores.Location = new System.Drawing.Point(73, 436);
            this.btn_eliminarProveedores.Name = "btn_eliminarProveedores";
            this.btn_eliminarProveedores.Size = new System.Drawing.Size(163, 30);
            this.btn_eliminarProveedores.TabIndex = 11;
            this.btn_eliminarProveedores.Text = "Eliminar";
            this.btn_eliminarProveedores.UseVisualStyleBackColor = false;
            this.btn_eliminarProveedores.Click += new System.EventHandler(this.btn_eliminarProveedores_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Green;
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.txtbox_Email);
            this.bunifuCards1.Controls.Add(this.txtbox_Telefono);
            this.bunifuCards1.Controls.Add(this.txtbox_Direccion);
            this.bunifuCards1.Controls.Add(this.txtbox_Nombre);
            this.bunifuCards1.Controls.Add(this.txt_idproveedor);
            this.bunifuCards1.Controls.Add(this.btn_eliminarProveedores);
            this.bunifuCards1.Controls.Add(this.lbl_Email);
            this.bunifuCards1.Controls.Add(this.btn_Guardar);
            this.bunifuCards1.Controls.Add(this.lbl_Nombre);
            this.bunifuCards1.Controls.Add(this.lbl_Direccion);
            this.bunifuCards1.Controls.Add(this.lbl_Telefono);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(709, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(305, 508);
            this.bunifuCards1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtbox_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_Email.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_Email.HintText = "";
            this.txtbox_Email.isPassword = false;
            this.txtbox_Email.LineFocusedColor = System.Drawing.Color.Red;
            this.txtbox_Email.LineIdleColor = System.Drawing.Color.Blue;
            this.txtbox_Email.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtbox_Email.LineThickness = 3;
            this.txtbox_Email.Location = new System.Drawing.Point(73, 329);
            this.txtbox_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(163, 32);
            this.txtbox_Email.TabIndex = 15;
            this.txtbox_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbox_Telefono
            // 
            this.txtbox_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtbox_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_Telefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_Telefono.HintText = "";
            this.txtbox_Telefono.isPassword = false;
            this.txtbox_Telefono.LineFocusedColor = System.Drawing.Color.Red;
            this.txtbox_Telefono.LineIdleColor = System.Drawing.Color.Blue;
            this.txtbox_Telefono.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtbox_Telefono.LineThickness = 3;
            this.txtbox_Telefono.Location = new System.Drawing.Point(73, 272);
            this.txtbox_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_Telefono.Name = "txtbox_Telefono";
            this.txtbox_Telefono.Size = new System.Drawing.Size(163, 32);
            this.txtbox_Telefono.TabIndex = 14;
            this.txtbox_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Telefono_KeyPress);
            // 
            // txtbox_Direccion
            // 
            this.txtbox_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtbox_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_Direccion.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_Direccion.HintText = "";
            this.txtbox_Direccion.isPassword = false;
            this.txtbox_Direccion.LineFocusedColor = System.Drawing.Color.Red;
            this.txtbox_Direccion.LineIdleColor = System.Drawing.Color.Blue;
            this.txtbox_Direccion.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtbox_Direccion.LineThickness = 3;
            this.txtbox_Direccion.Location = new System.Drawing.Point(73, 215);
            this.txtbox_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_Direccion.Name = "txtbox_Direccion";
            this.txtbox_Direccion.Size = new System.Drawing.Size(163, 32);
            this.txtbox_Direccion.TabIndex = 13;
            this.txtbox_Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbox_Nombre
            // 
            this.txtbox_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtbox_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_Nombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_Nombre.HintText = "";
            this.txtbox_Nombre.isPassword = false;
            this.txtbox_Nombre.LineFocusedColor = System.Drawing.Color.Red;
            this.txtbox_Nombre.LineIdleColor = System.Drawing.Color.Blue;
            this.txtbox_Nombre.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtbox_Nombre.LineThickness = 3;
            this.txtbox_Nombre.Location = new System.Drawing.Point(73, 158);
            this.txtbox_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_Nombre.Name = "txtbox_Nombre";
            this.txtbox_Nombre.Size = new System.Drawing.Size(163, 32);
            this.txtbox_Nombre.TabIndex = 12;
            this.txtbox_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_idproveedor
            // 
            this.txt_idproveedor.Location = new System.Drawing.Point(203, 118);
            this.txt_idproveedor.Name = "txt_idproveedor";
            this.txt_idproveedor.Size = new System.Drawing.Size(100, 20);
            this.txt_idproveedor.TabIndex = 9;
            this.txt_idproveedor.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lbl_select.Location = new System.Drawing.Point(444, 306);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(93, 13);
            this.lbl_select.TabIndex = 13;
            this.lbl_select.Text = "SELECCIONADO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_deleteproductproveedor);
            this.panel1.Controls.Add(this.btn_addproductproveedor);
            this.panel1.Location = new System.Drawing.Point(709, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 159);
            this.panel1.TabIndex = 17;
            // 
            // btn_deleteproductproveedor
            // 
            this.btn_deleteproductproveedor.BackColor = System.Drawing.Color.Green;
            this.btn_deleteproductproveedor.Enabled = false;
            this.btn_deleteproductproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteproductproveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deleteproductproveedor.Location = new System.Drawing.Point(75, 102);
            this.btn_deleteproductproveedor.Name = "btn_deleteproductproveedor";
            this.btn_deleteproductproveedor.Size = new System.Drawing.Size(163, 34);
            this.btn_deleteproductproveedor.TabIndex = 1;
            this.btn_deleteproductproveedor.Text = "Eliminar Productos";
            this.btn_deleteproductproveedor.UseVisualStyleBackColor = false;
            this.btn_deleteproductproveedor.Click += new System.EventHandler(this.btn_deleteproductproveedor_Click);
            // 
            // btn_addproductproveedor
            // 
            this.btn_addproductproveedor.BackColor = System.Drawing.Color.Green;
            this.btn_addproductproveedor.Enabled = false;
            this.btn_addproductproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addproductproveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addproductproveedor.Location = new System.Drawing.Point(75, 31);
            this.btn_addproductproveedor.Name = "btn_addproductproveedor";
            this.btn_addproductproveedor.Size = new System.Drawing.Size(163, 35);
            this.btn_addproductproveedor.TabIndex = 0;
            this.btn_addproductproveedor.Text = "Guardar Productos";
            this.btn_addproductproveedor.UseVisualStyleBackColor = false;
            this.btn_addproductproveedor.Click += new System.EventHandler(this.btn_addproductproveedor_Click);
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lbl_producto.Location = new System.Drawing.Point(-1, 352);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(101, 13);
            this.lbl_producto.TabIndex = 19;
            this.lbl_producto.Text = "Producto a agregar:";
            // 
            // btn_addproducto
            // 
            this.btn_addproducto.BackColor = System.Drawing.Color.Green;
            this.btn_addproducto.Enabled = false;
            this.btn_addproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addproducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addproducto.Location = new System.Drawing.Point(275, 343);
            this.btn_addproducto.Name = "btn_addproducto";
            this.btn_addproducto.Size = new System.Drawing.Size(38, 32);
            this.btn_addproducto.TabIndex = 20;
            this.btn_addproducto.Text = "+";
            this.btn_addproducto.UseVisualStyleBackColor = false;
            this.btn_addproducto.Click += new System.EventHandler(this.btn_addproducto_Click);
            // 
            // dtGridView_ProductosdelProveedor
            // 
            this.dtGridView_ProductosdelProveedor.AllowUserToAddRows = false;
            this.dtGridView_ProductosdelProveedor.AllowUserToDeleteRows = false;
            this.dtGridView_ProductosdelProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView_ProductosdelProveedor.BackgroundColor = System.Drawing.Color.White;
            this.dtGridView_ProductosdelProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView_ProductosdelProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridView_ProductosdelProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridView_ProductosdelProveedor.ColumnHeadersHeight = 30;
            this.dtGridView_ProductosdelProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridView_ProductosdelProveedor.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridView_ProductosdelProveedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtGridView_ProductosdelProveedor.EnableHeadersVisualStyles = false;
            this.dtGridView_ProductosdelProveedor.GridColor = System.Drawing.SystemColors.Control;
            this.dtGridView_ProductosdelProveedor.Location = new System.Drawing.Point(12, 382);
            this.dtGridView_ProductosdelProveedor.Name = "dtGridView_ProductosdelProveedor";
            this.dtGridView_ProductosdelProveedor.RowHeadersVisible = false;
            this.dtGridView_ProductosdelProveedor.Size = new System.Drawing.Size(681, 239);
            this.dtGridView_ProductosdelProveedor.TabIndex = 21;
            this.dtGridView_ProductosdelProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.terminaredit);
            this.dtGridView_ProductosdelProveedor.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkboxeliminaractiva);
            // 
            // btn_deseleccionar
            // 
            this.btn_deseleccionar.BackColor = System.Drawing.Color.Green;
            this.btn_deseleccionar.FlatAppearance.BorderSize = 0;
            this.btn_deseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deseleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deseleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btn_deseleccionar.Image")));
            this.btn_deseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deseleccionar.Location = new System.Drawing.Point(496, 344);
            this.btn_deseleccionar.Name = "btn_deseleccionar";
            this.btn_deseleccionar.Size = new System.Drawing.Size(197, 31);
            this.btn_deseleccionar.TabIndex = 16;
            this.btn_deseleccionar.Text = "Cancelar Seleccion";
            this.btn_deseleccionar.UseVisualStyleBackColor = false;
            this.btn_deseleccionar.Click += new System.EventHandler(this.btn_deseleccionar_Click_1);
            // 
            // txt_Producto
            // 
            this.txt_Producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Producto.Location = new System.Drawing.Point(152, 352);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Producto.TabIndex = 22;
            // 
            // txt_Seleccionado
            // 
            this.txt_Seleccionado.Location = new System.Drawing.Point(544, 306);
            this.txt_Seleccionado.Name = "txt_Seleccionado";
            this.txt_Seleccionado.ReadOnly = true;
            this.txt_Seleccionado.Size = new System.Drawing.Size(100, 20);
            this.txt_Seleccionado.TabIndex = 23;
            // 
            // frm_Proveedores
            // 
            this.AcceptButton = this.btn_addproducto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 788);
            this.Controls.Add(this.txt_Seleccionado);
            this.Controls.Add(this.txt_Producto);
            this.Controls.Add(this.btn_deseleccionar);
            this.Controls.Add(this.dtGridView_ProductosdelProveedor);
            this.Controls.Add(this.btn_addproducto);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.dtView_proveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Proveedores";
            this.Text = "frm_Proveedores";
            this.Load += new System.EventHandler(this.frm_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_proveedores)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_ProductosdelProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dtView_proveedores;
        private System.Windows.Forms.Button btn_eliminarProveedores;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_Telefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_Direccion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_Nombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_Email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_idproveedor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deleteproductproveedor;
        private System.Windows.Forms.Button btn_addproductproveedor;
        private System.Windows.Forms.Button btn_addproducto;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Button btn_deseleccionar;
        private System.Windows.Forms.DataGridView dtGridView_ProductosdelProveedor;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.TextBox txt_Seleccionado;
    }
}