namespace sistemadia
{
    partial class detalleOrdenDeCompra
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.dtView_DetalleOrdenCompra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_DetalleOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Green;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.Location = new System.Drawing.Point(200, 376);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(91, 31);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.Green;
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_confirmar.Location = new System.Drawing.Point(499, 376);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(109, 31);
            this.btn_confirmar.TabIndex = 2;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // dtView_DetalleOrdenCompra
            // 
            this.dtView_DetalleOrdenCompra.AllowUserToAddRows = false;
            this.dtView_DetalleOrdenCompra.AllowUserToDeleteRows = false;
            this.dtView_DetalleOrdenCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtView_DetalleOrdenCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtView_DetalleOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView_DetalleOrdenCompra.BackgroundColor = System.Drawing.Color.White;
            this.dtView_DetalleOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtView_DetalleOrdenCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView_DetalleOrdenCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtView_DetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView_DetalleOrdenCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtView_DetalleOrdenCompra.EnableHeadersVisualStyles = false;
            this.dtView_DetalleOrdenCompra.GridColor = System.Drawing.SystemColors.Control;
            this.dtView_DetalleOrdenCompra.Location = new System.Drawing.Point(87, 62);
            this.dtView_DetalleOrdenCompra.Name = "dtView_DetalleOrdenCompra";
            this.dtView_DetalleOrdenCompra.ReadOnly = true;
            this.dtView_DetalleOrdenCompra.RowHeadersVisible = false;
            this.dtView_DetalleOrdenCompra.Size = new System.Drawing.Size(616, 274);
            this.dtView_DetalleOrdenCompra.TabIndex = 4;
            this.dtView_DetalleOrdenCompra.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtView_DetalleOrdenCompra_CellFormatting);
            // 
            // detalleOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtView_DetalleOrdenCompra);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detalleOrdenDeCompra";
            this.Text = "detalleOrdenDeCompra";
            this.Load += new System.EventHandler(this.detalleOrdenDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_DetalleOrdenCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        public System.Windows.Forms.DataGridView dtView_DetalleOrdenCompra;
    }
}