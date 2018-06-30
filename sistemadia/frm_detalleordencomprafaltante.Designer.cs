namespace sistemadia
{
    partial class frm_detalleordencomprafaltante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_detalleordencomprafaltante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_relizarnuevaordencompra = new System.Windows.Forms.Button();
            this.dtView_detallefaltante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_detallefaltante)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Green;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(211, 364);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(136, 35);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_relizarnuevaordencompra
            // 
            this.btn_relizarnuevaordencompra.BackColor = System.Drawing.Color.Green;
            this.btn_relizarnuevaordencompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relizarnuevaordencompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relizarnuevaordencompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_relizarnuevaordencompra.Image = ((System.Drawing.Image)(resources.GetObject("btn_relizarnuevaordencompra.Image")));
            this.btn_relizarnuevaordencompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_relizarnuevaordencompra.Location = new System.Drawing.Point(512, 364);
            this.btn_relizarnuevaordencompra.Name = "btn_relizarnuevaordencompra";
            this.btn_relizarnuevaordencompra.Size = new System.Drawing.Size(132, 35);
            this.btn_relizarnuevaordencompra.TabIndex = 2;
            this.btn_relizarnuevaordencompra.Text = "Comprar";
            this.btn_relizarnuevaordencompra.UseVisualStyleBackColor = false;
            this.btn_relizarnuevaordencompra.Click += new System.EventHandler(this.btn_relizarnuevaordencompra_Click);
            // 
            // dtView_detallefaltante
            // 
            this.dtView_detallefaltante.AllowUserToAddRows = false;
            this.dtView_detallefaltante.AllowUserToDeleteRows = false;
            this.dtView_detallefaltante.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtView_detallefaltante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtView_detallefaltante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView_detallefaltante.BackgroundColor = System.Drawing.Color.White;
            this.dtView_detallefaltante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtView_detallefaltante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView_detallefaltante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtView_detallefaltante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView_detallefaltante.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtView_detallefaltante.EnableHeadersVisualStyles = false;
            this.dtView_detallefaltante.GridColor = System.Drawing.SystemColors.Control;
            this.dtView_detallefaltante.Location = new System.Drawing.Point(88, 60);
            this.dtView_detallefaltante.Name = "dtView_detallefaltante";
            this.dtView_detallefaltante.ReadOnly = true;
            this.dtView_detallefaltante.RowHeadersVisible = false;
            this.dtView_detallefaltante.Size = new System.Drawing.Size(605, 274);
            this.dtView_detallefaltante.TabIndex = 5;
            // 
            // frm_detalleordencomprafaltante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.dtView_detallefaltante);
            this.Controls.Add(this.btn_relizarnuevaordencompra);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_detalleordencomprafaltante";
            this.Text = "frm_detalleordencomprafaltante";
            this.Load += new System.EventHandler(this.frm_detalleordencomprafaltante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_detallefaltante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_relizarnuevaordencompra;
        public System.Windows.Forms.DataGridView dtView_detallefaltante;
    }
}