namespace sistemadia
{
    partial class frm_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes));
            this.dtView_Clientes = new System.Windows.Forms.DataGridView();
            this.btn_nuevoCliente = new System.Windows.Forms.Button();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cmbox_tipo = new System.Windows.Forms.ComboBox();
            this.txtbox_idCliente = new System.Windows.Forms.TextBox();
            this.btn_eliminarCliente = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtbox_email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtbox_apellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBox_nombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_Clientes)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtView_Clientes
            // 
            this.dtView_Clientes.AllowUserToAddRows = false;
            this.dtView_Clientes.AllowUserToDeleteRows = false;
            this.dtView_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView_Clientes.BackgroundColor = System.Drawing.Color.White;
            this.dtView_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtView_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtView_Clientes.EnableHeadersVisualStyles = false;
            this.dtView_Clientes.GridColor = System.Drawing.SystemColors.Control;
            this.dtView_Clientes.Location = new System.Drawing.Point(43, 227);
            this.dtView_Clientes.Name = "dtView_Clientes";
            this.dtView_Clientes.RowHeadersVisible = false;
            this.dtView_Clientes.Size = new System.Drawing.Size(586, 394);
            this.dtView_Clientes.TabIndex = 0;
            this.dtView_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.terminaredit);
            this.dtView_Clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCelldobleclick);
            this.dtView_Clientes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtView_Clientes_OnCambiodevalor);
            // 
            // btn_nuevoCliente
            // 
            this.btn_nuevoCliente.BackColor = System.Drawing.Color.Green;
            this.btn_nuevoCliente.FlatAppearance.BorderSize = 0;
            this.btn_nuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_nuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevoCliente.Image")));
            this.btn_nuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevoCliente.Location = new System.Drawing.Point(74, 323);
            this.btn_nuevoCliente.Name = "btn_nuevoCliente";
            this.btn_nuevoCliente.Size = new System.Drawing.Size(195, 34);
            this.btn_nuevoCliente.TabIndex = 9;
            this.btn_nuevoCliente.Text = "GUARDAR";
            this.btn_nuevoCliente.UseVisualStyleBackColor = false;
            this.btn_nuevoCliente.Click += new System.EventHandler(this.btn_nuevoUsuario_Click);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(156, 265);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(32, 17);
            this.lbl_tipo.TabIndex = 8;
            this.lbl_tipo.Text = "Tipo";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(149, 204);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(39, 17);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(139, 146);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(58, 17);
            this.lbl_apellido.TabIndex = 6;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(141, 86);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(56, 17);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Nombre";
            // 
            // cmbox_tipo
            // 
            this.cmbox_tipo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbox_tipo.FormattingEnabled = true;
            this.cmbox_tipo.Location = new System.Drawing.Point(74, 285);
            this.cmbox_tipo.Name = "cmbox_tipo";
            this.cmbox_tipo.Size = new System.Drawing.Size(195, 21);
            this.cmbox_tipo.TabIndex = 4;
            this.cmbox_tipo.SelectedIndexChanged += new System.EventHandler(this.cmbox_tipo_SelectedIndexChanged);
            // 
            // txtbox_idCliente
            // 
            this.txtbox_idCliente.Location = new System.Drawing.Point(226, 146);
            this.txtbox_idCliente.Name = "txtbox_idCliente";
            this.txtbox_idCliente.Size = new System.Drawing.Size(100, 20);
            this.txtbox_idCliente.TabIndex = 1;
            this.txtbox_idCliente.Visible = false;
            this.txtbox_idCliente.TextChanged += new System.EventHandler(this.txtbox_idCliente_TextChanged);
            // 
            // btn_eliminarCliente
            // 
            this.btn_eliminarCliente.BackColor = System.Drawing.Color.Green;
            this.btn_eliminarCliente.Enabled = false;
            this.btn_eliminarCliente.FlatAppearance.BorderSize = 0;
            this.btn_eliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_eliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminarCliente.Image")));
            this.btn_eliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarCliente.Location = new System.Drawing.Point(74, 372);
            this.btn_eliminarCliente.Name = "btn_eliminarCliente";
            this.btn_eliminarCliente.Size = new System.Drawing.Size(195, 33);
            this.btn_eliminarCliente.TabIndex = 2;
            this.btn_eliminarCliente.Text = "Eliminar";
            this.btn_eliminarCliente.UseVisualStyleBackColor = false;
            this.btn_eliminarCliente.Click += new System.EventHandler(this.btn_eliminarCliente_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(130)))));
            this.bunifuCards1.Controls.Add(this.txtbox_email);
            this.bunifuCards1.Controls.Add(this.txtbox_apellido);
            this.bunifuCards1.Controls.Add(this.txtBox_nombre);
            this.bunifuCards1.Controls.Add(this.btn_eliminarCliente);
            this.bunifuCards1.Controls.Add(this.btn_nuevoCliente);
            this.bunifuCards1.Controls.Add(this.lbl_tipo);
            this.bunifuCards1.Controls.Add(this.lbl_email);
            this.bunifuCards1.Controls.Add(this.txtbox_idCliente);
            this.bunifuCards1.Controls.Add(this.lbl_apellido);
            this.bunifuCards1.Controls.Add(this.cmbox_tipo);
            this.bunifuCards1.Controls.Add(this.lbl_nombre);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(658, 227);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(328, 441);
            this.bunifuCards1.TabIndex = 10;
            // 
            // txtbox_email
            // 
            this.txtbox_email.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtbox_email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbox_email.BorderColorMouseHover = System.Drawing.Color.Red;
            this.txtbox_email.BorderThickness = 3;
            this.txtbox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbox_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_email.isPassword = false;
            this.txtbox_email.Location = new System.Drawing.Point(74, 225);
            this.txtbox_email.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(195, 41);
            this.txtbox_email.TabIndex = 13;
            this.txtbox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbox_apellido
            // 
            this.txtbox_apellido.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtbox_apellido.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbox_apellido.BorderColorMouseHover = System.Drawing.Color.Red;
            this.txtbox_apellido.BorderThickness = 3;
            this.txtbox_apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbox_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_apellido.isPassword = false;
            this.txtbox_apellido.Location = new System.Drawing.Point(74, 167);
            this.txtbox_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_apellido.Name = "txtbox_apellido";
            this.txtbox_apellido.Size = new System.Drawing.Size(195, 41);
            this.txtbox_apellido.TabIndex = 12;
            this.txtbox_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBox_nombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBox_nombre.BorderColorMouseHover = System.Drawing.Color.Red;
            this.txtBox_nombre.BorderThickness = 3;
            this.txtBox_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBox_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_nombre.isPassword = false;
            this.txtBox_nombre.Location = new System.Drawing.Point(74, 107);
            this.txtBox_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(195, 41);
            this.txtBox_nombre.TabIndex = 11;
            this.txtBox_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.bunifuCards2.Location = new System.Drawing.Point(254, 74);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(137, 147);
            this.bunifuCards2.TabIndex = 15;
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
            this.label1.Location = new System.Drawing.Point(37, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // frm_Clientes
            // 
            this.AcceptButton = this.btn_nuevoCliente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 788);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.dtView_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Clientes";
            this.Text = "frm_Clientes";
            this.Load += new System.EventHandler(this.frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_Clientes)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtView_Clientes;
        private System.Windows.Forms.Button btn_nuevoCliente;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ComboBox cmbox_tipo;
        private System.Windows.Forms.TextBox txtbox_idCliente;
        private System.Windows.Forms.Button btn_eliminarCliente;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbox_email;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbox_apellido;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBox_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}