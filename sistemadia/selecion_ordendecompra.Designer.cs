namespace sistemadia
{
    partial class selecion_ordendecompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selecion_ordendecompra));
            this.dtView_proveedores = new System.Windows.Forms.DataGridView();
            this.btn_Selecionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dtView_proveedores.Location = new System.Drawing.Point(109, 62);
            this.dtView_proveedores.Name = "dtView_proveedores";
            this.dtView_proveedores.RowHeadersVisible = false;
            this.dtView_proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtView_proveedores.Size = new System.Drawing.Size(637, 430);
            this.dtView_proveedores.TabIndex = 11;
            this.dtView_proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.terminaredit);
            this.dtView_proveedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.terminaredit);
            this.dtView_proveedores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtView_proveedores_CellFormatting);
            this.dtView_proveedores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtView_proveedores_MouseClick);
            // 
            // btn_Selecionar
            // 
            this.btn_Selecionar.BackColor = System.Drawing.Color.Green;
            this.btn_Selecionar.FlatAppearance.BorderSize = 0;
            this.btn_Selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Selecionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Selecionar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Selecionar.Image")));
            this.btn_Selecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Selecionar.Location = new System.Drawing.Point(809, 224);
            this.btn_Selecionar.Name = "btn_Selecionar";
            this.btn_Selecionar.Size = new System.Drawing.Size(163, 31);
            this.btn_Selecionar.TabIndex = 12;
            this.btn_Selecionar.Text = "selecionar";
            this.btn_Selecionar.UseVisualStyleBackColor = false;
            this.btn_Selecionar.Click += new System.EventHandler(this.btn_Selecionar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(963, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // selecion_ordendecompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Selecionar);
            this.Controls.Add(this.dtView_proveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selecion_ordendecompra";
            this.Text = "selecion_ordendecompra";
            this.Load += new System.EventHandler(this.selecion_ordendecompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Selecionar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dtView_proveedores;
    }
}