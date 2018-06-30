namespace sistemadia
{
    partial class frm_ordencomprafaltante
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
            this.dtView_ordenesdecomprafaltantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_ordenesdecomprafaltantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtView_ordenesdecomprafaltantes
            // 
            this.dtView_ordenesdecomprafaltantes.AllowUserToAddRows = false;
            this.dtView_ordenesdecomprafaltantes.AllowUserToDeleteRows = false;
            this.dtView_ordenesdecomprafaltantes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtView_ordenesdecomprafaltantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtView_ordenesdecomprafaltantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView_ordenesdecomprafaltantes.BackgroundColor = System.Drawing.Color.White;
            this.dtView_ordenesdecomprafaltantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtView_ordenesdecomprafaltantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView_ordenesdecomprafaltantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtView_ordenesdecomprafaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView_ordenesdecomprafaltantes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtView_ordenesdecomprafaltantes.EnableHeadersVisualStyles = false;
            this.dtView_ordenesdecomprafaltantes.GridColor = System.Drawing.SystemColors.Control;
            this.dtView_ordenesdecomprafaltantes.Location = new System.Drawing.Point(98, 88);
            this.dtView_ordenesdecomprafaltantes.Name = "dtView_ordenesdecomprafaltantes";
            this.dtView_ordenesdecomprafaltantes.ReadOnly = true;
            this.dtView_ordenesdecomprafaltantes.RowHeadersVisible = false;
            this.dtView_ordenesdecomprafaltantes.Size = new System.Drawing.Size(552, 274);
            this.dtView_ordenesdecomprafaltantes.TabIndex = 6;
            // 
            // frm_ordencomprafaltante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtView_ordenesdecomprafaltantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ordencomprafaltante";
            this.Text = "frm_ordencomprafaltante";
            this.Load += new System.EventHandler(this.frm_ordencomprafaltante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_ordenesdecomprafaltantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dtView_ordenesdecomprafaltantes;
    }
}