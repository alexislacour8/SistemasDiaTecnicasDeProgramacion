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
            this.GridVw_ordenesSinRevisar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_ordenesSinRevisar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridVw_ordenesSinRevisar
            // 
            this.GridVw_ordenesSinRevisar.AllowUserToAddRows = false;
            this.GridVw_ordenesSinRevisar.AllowUserToDeleteRows = false;
            this.GridVw_ordenesSinRevisar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridVw_ordenesSinRevisar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridVw_ordenesSinRevisar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVw_ordenesSinRevisar.BackgroundColor = System.Drawing.Color.White;
            this.GridVw_ordenesSinRevisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVw_ordenesSinRevisar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVw_ordenesSinRevisar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridVw_ordenesSinRevisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVw_ordenesSinRevisar.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridVw_ordenesSinRevisar.EnableHeadersVisualStyles = false;
            this.GridVw_ordenesSinRevisar.GridColor = System.Drawing.SystemColors.Control;
            this.GridVw_ordenesSinRevisar.Location = new System.Drawing.Point(47, 116);
            this.GridVw_ordenesSinRevisar.Name = "GridVw_ordenesSinRevisar";
            this.GridVw_ordenesSinRevisar.ReadOnly = true;
            this.GridVw_ordenesSinRevisar.RowHeadersVisible = false;
            this.GridVw_ordenesSinRevisar.Size = new System.Drawing.Size(616, 453);
            this.GridVw_ordenesSinRevisar.TabIndex = 3;
            this.GridVw_ordenesSinRevisar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.verdetalle);
            this.GridVw_ordenesSinRevisar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridVw_producto_CellFormatting);
            // 
            // frm_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1078, 657);
            this.Controls.Add(this.GridVw_ordenesSinRevisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_stock";
            this.Text = "frm_stock";
            this.Load += new System.EventHandler(this.frm_stock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_stock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_ordenesSinRevisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVw_ordenesSinRevisar;
    }
}