namespace sistemadia
{
    partial class Frm_orden_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_orden_compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtView_ordendecompra = new System.Windows.Forms.DataGridView();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_agregaproducto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_vender = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbox_proveedores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_ordendecompra)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtView_ordendecompra
            // 
            this.dtView_ordendecompra.AllowUserToAddRows = false;
            this.dtView_ordendecompra.AllowUserToDeleteRows = false;
            this.dtView_ordendecompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView_ordendecompra.BackgroundColor = System.Drawing.Color.White;
            this.dtView_ordendecompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtView_ordendecompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView_ordendecompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtView_ordendecompra.ColumnHeadersHeight = 25;
            this.dtView_ordendecompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView_ordendecompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtView_ordendecompra.Enabled = false;
            this.dtView_ordendecompra.EnableHeadersVisualStyles = false;
            this.dtView_ordendecompra.GridColor = System.Drawing.Color.LightGray;
            this.dtView_ordendecompra.Location = new System.Drawing.Point(97, 83);
            this.dtView_ordendecompra.Name = "dtView_ordendecompra";
            this.dtView_ordendecompra.RowHeadersVisible = false;
            this.dtView_ordendecompra.Size = new System.Drawing.Size(455, 322);
            this.dtView_ordendecompra.TabIndex = 1;
            this.dtView_ordendecompra.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Navy;
            this.bunifuCards1.Controls.Add(this.btn_agregaproducto);
            this.bunifuCards1.Controls.Add(this.pictureBox2);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.btn_vender);
            this.bunifuCards1.Controls.Add(this.eliminar);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(569, 202);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(343, 397);
            this.bunifuCards1.TabIndex = 14;
            // 
            // btn_agregaproducto
            // 
            this.btn_agregaproducto.BackColor = System.Drawing.Color.Green;
            this.btn_agregaproducto.Enabled = false;
            this.btn_agregaproducto.FlatAppearance.BorderSize = 0;
            this.btn_agregaproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_agregaproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregaproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregaproducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregaproducto.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregaproducto.Image")));
            this.btn_agregaproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregaproducto.Location = new System.Drawing.Point(102, 184);
            this.btn_agregaproducto.Name = "btn_agregaproducto";
            this.btn_agregaproducto.Size = new System.Drawing.Size(181, 32);
            this.btn_agregaproducto.TabIndex = 14;
            this.btn_agregaproducto.Text = "Agregar producto";
            this.btn_agregaproducto.UseVisualStyleBackColor = false;
            this.btn_agregaproducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(114, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 20);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Hacer compra";
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.Color.Green;
            this.btn_vender.FlatAppearance.BorderSize = 0;
            this.btn_vender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_vender.Image = ((System.Drawing.Image)(resources.GetObject("btn_vender.Image")));
            this.btn_vender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vender.Location = new System.Drawing.Point(102, 318);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(181, 32);
            this.btn_vender.TabIndex = 11;
            this.btn_vender.Text = "COMPRA[Fin]";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Green;
            this.eliminar.Enabled = false;
            this.eliminar.FlatAppearance.BorderSize = 0;
            this.eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar.Location = new System.Drawing.Point(102, 251);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(181, 32);
            this.eliminar.TabIndex = 10;
            this.eliminar.Text = "Eliminar[F4]";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbox_proveedores
            // 
            this.cmbox_proveedores.FormattingEnabled = true;
            this.cmbox_proveedores.Location = new System.Drawing.Point(215, 9);
            this.cmbox_proveedores.Name = "cmbox_proveedores";
            this.cmbox_proveedores.Size = new System.Drawing.Size(121, 21);
            this.cmbox_proveedores.TabIndex = 16;
            this.cmbox_proveedores.SelectedIndexChanged += new System.EventHandler(this.cmbox_proveedores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccione Proveedor:";
            // 
            // Frm_orden_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbox_proveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.dtView_ordendecompra);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_orden_compra";
            this.Text = "Frm_orden_compra";
            this.Load += new System.EventHandler(this.Frm_orden_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_ordendecompra)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtView_ordendecompra;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button btn_agregaproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbox_proveedores;
        private System.Windows.Forms.Label label2;
    }
}