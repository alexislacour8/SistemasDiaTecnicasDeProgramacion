namespace sistemadia
{
    partial class frm_empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_empleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridVw_usuariosregistrados = new System.Windows.Forms.DataGridView();
            this.Guardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_permiso = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txtbox_newuserapellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_newusernombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_newuserpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_newuserdni = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_selecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_usuariosregistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GridVw_usuariosregistrados
            // 
            this.GridVw_usuariosregistrados.AllowUserToOrderColumns = true;
            this.GridVw_usuariosregistrados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridVw_usuariosregistrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridVw_usuariosregistrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVw_usuariosregistrados.BackgroundColor = System.Drawing.Color.White;
            this.GridVw_usuariosregistrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVw_usuariosregistrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVw_usuariosregistrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridVw_usuariosregistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVw_usuariosregistrados.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridVw_usuariosregistrados.EnableHeadersVisualStyles = false;
            this.GridVw_usuariosregistrados.GridColor = System.Drawing.SystemColors.Control;
            this.GridVw_usuariosregistrados.Location = new System.Drawing.Point(29, 212);
            this.GridVw_usuariosregistrados.Name = "GridVw_usuariosregistrados";
            this.GridVw_usuariosregistrados.RowHeadersVisible = false;
            this.GridVw_usuariosregistrados.Size = new System.Drawing.Size(598, 302);
            this.GridVw_usuariosregistrados.TabIndex = 1;
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
            this.Guardar.Location = new System.Drawing.Point(120, 408);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(156, 32);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DNI.Location = new System.Drawing.Point(175, 127);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(26, 13);
            this.lbl_DNI.TabIndex = 14;
            this.lbl_DNI.Text = "DNI";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(158, 188);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 13);
            this.lbl_password.TabIndex = 15;
            this.lbl_password.Text = "Contraseña";
            // 
            // lbl_permiso
            // 
            this.lbl_permiso.AutoSize = true;
            this.lbl_permiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_permiso.Location = new System.Drawing.Point(175, 242);
            this.lbl_permiso.Name = "lbl_permiso";
            this.lbl_permiso.Size = new System.Drawing.Size(44, 13);
            this.lbl_permiso.TabIndex = 17;
            this.lbl_permiso.Text = "Permiso";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(172, 285);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 18;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(175, 334);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 19;
            this.lbl_apellido.Text = "Apellido";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.bunifuCards1.Controls.Add(this.btn_modificar);
            this.bunifuCards1.Controls.Add(this.comboBox1);
            this.bunifuCards1.Controls.Add(this.txtbox_newuserapellido);
            this.bunifuCards1.Controls.Add(this.txtbox_newusernombre);
            this.bunifuCards1.Controls.Add(this.txtbox_newuserpassword);
            this.bunifuCards1.Controls.Add(this.txtbox_newuserdni);
            this.bunifuCards1.Controls.Add(this.lbl_apellido);
            this.bunifuCards1.Controls.Add(this.lbl_nombre);
            this.bunifuCards1.Controls.Add(this.lbl_permiso);
            this.bunifuCards1.Controls.Add(this.lbl_password);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.lbl_DNI);
            this.bunifuCards1.Controls.Add(this.Guardar);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(666, 162);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(372, 497);
            this.bunifuCards1.TabIndex = 20;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Green;
            this.btn_modificar.Enabled = false;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(121, 446);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(156, 32);
            this.btn_modificar.TabIndex = 25;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txtbox_newuserapellido
            // 
            this.txtbox_newuserapellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_newuserapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_newuserapellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_newuserapellido.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_newuserapellido.HintText = "";
            this.txtbox_newuserapellido.isPassword = false;
            this.txtbox_newuserapellido.LineFocusedColor = System.Drawing.Color.Red;
            this.txtbox_newuserapellido.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.txtbox_newuserapellido.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbox_newuserapellido.LineThickness = 3;
            this.txtbox_newuserapellido.Location = new System.Drawing.Point(121, 354);
            this.txtbox_newuserapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_newuserapellido.Name = "txtbox_newuserapellido";
            this.txtbox_newuserapellido.Size = new System.Drawing.Size(148, 31);
            this.txtbox_newuserapellido.TabIndex = 24;
            this.txtbox_newuserapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_newuserapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_newuserapellido_KeyPress);
            // 
            // txtbox_newusernombre
            // 
            this.txtbox_newusernombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_newusernombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_newusernombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_newusernombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_newusernombre.HintText = "";
            this.txtbox_newusernombre.isPassword = false;
            this.txtbox_newusernombre.LineFocusedColor = System.Drawing.Color.Red;
            this.txtbox_newusernombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.txtbox_newusernombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbox_newusernombre.LineThickness = 3;
            this.txtbox_newusernombre.Location = new System.Drawing.Point(120, 299);
            this.txtbox_newusernombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_newusernombre.Name = "txtbox_newusernombre";
            this.txtbox_newusernombre.Size = new System.Drawing.Size(148, 31);
            this.txtbox_newusernombre.TabIndex = 23;
            this.txtbox_newusernombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_newusernombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_newusernombre_KeyPress);
            // 
            // txtbox_newuserpassword
            // 
            this.txtbox_newuserpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_newuserpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_newuserpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_newuserpassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_newuserpassword.HintText = "";
            this.txtbox_newuserpassword.isPassword = true;
            this.txtbox_newuserpassword.LineFocusedColor = System.Drawing.Color.Red;
            this.txtbox_newuserpassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.txtbox_newuserpassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbox_newuserpassword.LineThickness = 3;
            this.txtbox_newuserpassword.Location = new System.Drawing.Point(121, 208);
            this.txtbox_newuserpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_newuserpassword.Name = "txtbox_newuserpassword";
            this.txtbox_newuserpassword.Size = new System.Drawing.Size(148, 30);
            this.txtbox_newuserpassword.TabIndex = 22;
            this.txtbox_newuserpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_newuserpassword.OnValueChanged += new System.EventHandler(this.txtbox_newuserpassword_OnValueChanged);
            // 
            // txtbox_newuserdni
            // 
            this.txtbox_newuserdni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_newuserdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbox_newuserdni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_newuserdni.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_newuserdni.HintText = "";
            this.txtbox_newuserdni.isPassword = false;
            this.txtbox_newuserdni.LineFocusedColor = System.Drawing.Color.Red;
            this.txtbox_newuserdni.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.txtbox_newuserdni.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbox_newuserdni.LineThickness = 3;
            this.txtbox_newuserdni.Location = new System.Drawing.Point(121, 147);
            this.txtbox_newuserdni.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_newuserdni.Name = "txtbox_newuserdni";
            this.txtbox_newuserdni.Size = new System.Drawing.Size(148, 37);
            this.txtbox_newuserdni.TabIndex = 21;
            this.txtbox_newuserdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_newuserdni.OnValueChanged += new System.EventHandler(this.txtbox_newuserdni_OnValueChanged);
            this.txtbox_newuserdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_newuserdni_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(744, 122);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(232, 25);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "Crear Nuevo Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(374, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.BackColor = System.Drawing.Color.Green;
            this.btn_selecionar.FlatAppearance.BorderSize = 0;
            this.btn_selecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_selecionar.Image = ((System.Drawing.Image)(resources.GetObject("btn_selecionar.Image")));
            this.btn_selecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_selecionar.Location = new System.Drawing.Point(189, 572);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(175, 32);
            this.btn_selecionar.TabIndex = 23;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = false;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // frm_empleados
            // 
            this.AcceptButton = this.Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 680);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.GridVw_usuariosregistrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_empleados";
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_usuariosregistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GridVw_usuariosregistrados;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_permiso;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_DNI;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_newusernombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_newuserpassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_newuserdni;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_newuserapellido;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Button btn_modificar;
    }
}