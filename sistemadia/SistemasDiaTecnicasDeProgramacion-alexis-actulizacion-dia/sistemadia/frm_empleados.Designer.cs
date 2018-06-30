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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridVw_usuariosregistrados = new System.Windows.Forms.DataGridView();
            this.Guardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbox_newuserdni = new System.Windows.Forms.TextBox();
            this.txtbox_newuserpassword = new System.Windows.Forms.TextBox();
            this.txtbox_newusernombre = new System.Windows.Forms.TextBox();
            this.txtbox_newuserapellido = new System.Windows.Forms.TextBox();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_permiso = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_usuariosregistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(684, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GridVw_usuariosregistrados
            // 
            this.GridVw_usuariosregistrados.AllowUserToOrderColumns = true;
            this.GridVw_usuariosregistrados.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.GridVw_usuariosregistrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridVw_usuariosregistrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVw_usuariosregistrados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.GridVw_usuariosregistrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVw_usuariosregistrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVw_usuariosregistrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridVw_usuariosregistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVw_usuariosregistrados.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridVw_usuariosregistrados.EnableHeadersVisualStyles = false;
            this.GridVw_usuariosregistrados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridVw_usuariosregistrados.Location = new System.Drawing.Point(52, 168);
            this.GridVw_usuariosregistrados.Name = "GridVw_usuariosregistrados";
            this.GridVw_usuariosregistrados.RowHeadersVisible = false;
            this.GridVw_usuariosregistrados.Size = new System.Drawing.Size(630, 283);
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
            this.Guardar.Location = new System.Drawing.Point(705, 399);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(166, 32);
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
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(717, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // txtbox_newuserdni
            // 
            this.txtbox_newuserdni.Location = new System.Drawing.Point(717, 168);
            this.txtbox_newuserdni.Name = "txtbox_newuserdni";
            this.txtbox_newuserdni.Size = new System.Drawing.Size(132, 20);
            this.txtbox_newuserdni.TabIndex = 9;
            // 
            // txtbox_newuserpassword
            // 
            this.txtbox_newuserpassword.Location = new System.Drawing.Point(717, 195);
            this.txtbox_newuserpassword.Name = "txtbox_newuserpassword";
            this.txtbox_newuserpassword.Size = new System.Drawing.Size(132, 20);
            this.txtbox_newuserpassword.TabIndex = 10;
            // 
            // txtbox_newusernombre
            // 
            this.txtbox_newusernombre.Location = new System.Drawing.Point(717, 307);
            this.txtbox_newusernombre.Name = "txtbox_newusernombre";
            this.txtbox_newusernombre.Size = new System.Drawing.Size(132, 20);
            this.txtbox_newusernombre.TabIndex = 12;
            // 
            // txtbox_newuserapellido
            // 
            this.txtbox_newuserapellido.Location = new System.Drawing.Point(717, 333);
            this.txtbox_newuserapellido.Name = "txtbox_newuserapellido";
            this.txtbox_newuserapellido.Size = new System.Drawing.Size(132, 20);
            this.txtbox_newuserapellido.TabIndex = 13;
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.Location = new System.Drawing.Point(855, 171);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(26, 13);
            this.lbl_DNI.TabIndex = 14;
            this.lbl_DNI.Text = "DNI";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(855, 198);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 13);
            this.lbl_password.TabIndex = 15;
            this.lbl_password.Text = "Contraseña";
            // 
            // lbl_permiso
            // 
            this.lbl_permiso.AutoSize = true;
            this.lbl_permiso.Location = new System.Drawing.Point(855, 267);
            this.lbl_permiso.Name = "lbl_permiso";
            this.lbl_permiso.Size = new System.Drawing.Size(44, 13);
            this.lbl_permiso.TabIndex = 17;
            this.lbl_permiso.Text = "Permiso";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(855, 310);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 18;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(855, 336);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 19;
            this.lbl_apellido.Text = "Apellido";
            // 
            // frm_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(924, 534);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_permiso);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_DNI);
            this.Controls.Add(this.txtbox_newuserapellido);
            this.Controls.Add(this.txtbox_newusernombre);
            this.Controls.Add(this.txtbox_newuserpassword);
            this.Controls.Add(this.txtbox_newuserdni);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.GridVw_usuariosregistrados);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_empleados";
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_usuariosregistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox txtbox_newuserapellido;
        private System.Windows.Forms.TextBox txtbox_newusernombre;
        private System.Windows.Forms.TextBox txtbox_newuserpassword;
        private System.Windows.Forms.TextBox txtbox_newuserdni;
    }
}