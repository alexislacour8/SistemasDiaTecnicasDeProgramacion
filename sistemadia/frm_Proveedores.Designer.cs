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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtView_proveedores)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(119, 121);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(61, 17);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(119, 194);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(69, 17);
            this.lbl_Direccion.TabIndex = 5;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(137, 308);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(43, 17);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(119, 251);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(62, 17);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView_proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtView_proveedores.ColumnHeadersHeight = 25;
            this.dtView_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView_proveedores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtView_proveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtView_proveedores.EnableHeadersVisualStyles = false;
            this.dtView_proveedores.GridColor = System.Drawing.SystemColors.Control;
            this.dtView_proveedores.Location = new System.Drawing.Point(22, 141);
            this.dtView_proveedores.Name = "dtView_proveedores";
            this.dtView_proveedores.RowHeadersVisible = false;
            this.dtView_proveedores.Size = new System.Drawing.Size(637, 430);
            this.dtView_proveedores.TabIndex = 10;
            this.dtView_proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.terminaredit);
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
            this.bunifuCards1.Location = new System.Drawing.Point(694, 141);
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
            this.txtbox_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.txtbox_Email.MouseLeave += new System.EventHandler(this.txtbox_Email_MouseLeave);
            // 
            // txtbox_Telefono
            // 
            this.txtbox_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtbox_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Telefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.txtbox_Telefono.OnValueChanged += new System.EventHandler(this.txtbox_Telefono_OnValueChanged);
            this.txtbox_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Telefono_KeyPress);
            // 
            // txtbox_Direccion
            // 
            this.txtbox_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtbox_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Direccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.txtbox_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            // frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 788);
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
            this.ResumeLayout(false);

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
    }
}