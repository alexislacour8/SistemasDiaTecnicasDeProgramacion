namespace sistemadia
{
    partial class frm_facturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODIGO_PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoprotxt = new System.Windows.Forms.TextBox();
            this.productotxt = new System.Windows.Forms.TextBox();
            this.cantidadtxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.fechatxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtnombre = new System.Windows.Forms.Label();
            this.clientetxt = new System.Windows.Forms.TextBox();
            this.colocar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultadotxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_PROD,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(46, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(699, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CODIGO_PROD
            // 
            this.CODIGO_PROD.HeaderText = "COD_PRODUCTO";
            this.CODIGO_PROD.Name = "CODIGO_PROD";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRODCUTO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CANTIDAD";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PRECIO";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CODIGO_VEND";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "COD_CLIENTE";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "FECHA";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "IMPORTE";
            this.Column8.Name = "Column8";
            // 
            // codigoprotxt
            // 
            this.codigoprotxt.Location = new System.Drawing.Point(46, 171);
            this.codigoprotxt.Name = "codigoprotxt";
            this.codigoprotxt.Size = new System.Drawing.Size(87, 20);
            this.codigoprotxt.TabIndex = 1;
            // 
            // productotxt
            // 
            this.productotxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productotxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productotxt.Location = new System.Drawing.Point(139, 171);
            this.productotxt.Name = "productotxt";
            this.productotxt.Size = new System.Drawing.Size(81, 20);
            this.productotxt.TabIndex = 2;
            this.productotxt.TextChanged += new System.EventHandler(this.productotxt_TextChanged);
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.Location = new System.Drawing.Point(226, 171);
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(81, 20);
            this.cantidadtxt.TabIndex = 3;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(313, 171);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(78, 20);
            this.preciotxt.TabIndex = 4;
            // 
            // fechatxt
            // 
            this.fechatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechatxt.Location = new System.Drawing.Point(203, 72);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.Size = new System.Drawing.Size(118, 22);
            this.fechatxt.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtnombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtnombre.Location = new System.Drawing.Point(43, 71);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 6;
            this.txtnombre.Text = "label1";
            this.txtnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientetxt
            // 
            this.clientetxt.Location = new System.Drawing.Point(479, 171);
            this.clientetxt.Name = "clientetxt";
            this.clientetxt.Size = new System.Drawing.Size(92, 20);
            this.clientetxt.TabIndex = 7;
            // 
            // colocar
            // 
            this.colocar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.colocar.FlatAppearance.BorderSize = 0;
            this.colocar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colocar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colocar.Image = ((System.Drawing.Image)(resources.GetObject("colocar.Image")));
            this.colocar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colocar.Location = new System.Drawing.Point(55, 209);
            this.colocar.Name = "colocar";
            this.colocar.Size = new System.Drawing.Size(166, 32);
            this.colocar.TabIndex = 9;
            this.colocar.Text = "Colocar";
            this.colocar.UseVisualStyleBackColor = false;
            this.colocar.Click += new System.EventHandler(this.colocar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.colocar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(865, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 642);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(55, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "TICKET";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.eliminar.FlatAppearance.BorderSize = 0;
            this.eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar.Location = new System.Drawing.Point(55, 277);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(166, 32);
            this.eliminar.TabIndex = 10;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(577, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "TOTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultadotxt
            // 
            this.resultadotxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultadotxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultadotxt.Location = new System.Drawing.Point(676, 507);
            this.resultadotxt.Name = "resultadotxt";
            this.resultadotxt.Size = new System.Drawing.Size(69, 23);
            this.resultadotxt.TabIndex = 12;
            this.resultadotxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Facturas
            // 
            this.AcceptButton = this.colocar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1119, 642);
            this.Controls.Add(this.resultadotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientetxt);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.fechatxt);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.cantidadtxt);
            this.Controls.Add(this.productotxt);
            this.Controls.Add(this.codigoprotxt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox codigoprotxt;
        private System.Windows.Forms.TextBox productotxt;
        private System.Windows.Forms.TextBox cantidadtxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.TextBox fechatxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtnombre;
        private System.Windows.Forms.TextBox clientetxt;
        private System.Windows.Forms.Button colocar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultadotxt;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button button1;
    }
}