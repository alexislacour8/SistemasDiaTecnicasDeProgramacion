namespace sistemadia
{
    partial class frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.usertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contraseñatxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(369, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(369, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(732, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(26, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(192, 172);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox4);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(245, 442);
            this.bunifuGradientPanel1.TabIndex = 8;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // login
            // 
            this.login.ActiveBorderThickness = 1;
            this.login.ActiveCornerRadius = 20;
            this.login.ActiveFillColor = System.Drawing.Color.DeepPink;
            this.login.ActiveForecolor = System.Drawing.Color.White;
            this.login.ActiveLineColor = System.Drawing.Color.DeepPink;
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.ButtonText = "Login";
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.SeaGreen;
            this.login.IdleBorderThickness = 1;
            this.login.IdleCornerRadius = 20;
            this.login.IdleFillColor = System.Drawing.Color.White;
            this.login.IdleForecolor = System.Drawing.Color.DeepPink;
            this.login.IdleLineColor = System.Drawing.Color.DarkViolet;
            this.login.Location = new System.Drawing.Point(434, 308);
            this.login.Margin = new System.Windows.Forms.Padding(5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(200, 41);
            this.login.TabIndex = 9;
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            this.login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuThinButton21_KeyPress);
            // 
            // usertxt
            // 
            this.usertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usertxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usertxt.HintForeColor = System.Drawing.Color.Empty;
            this.usertxt.HintText = "";
            this.usertxt.isPassword = false;
            this.usertxt.LineFocusedColor = System.Drawing.Color.Crimson;
            this.usertxt.LineIdleColor = System.Drawing.Color.Blue;
            this.usertxt.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.usertxt.LineThickness = 3;
            this.usertxt.Location = new System.Drawing.Point(431, 166);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(203, 45);
            this.usertxt.TabIndex = 10;
            this.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usertxt.OnValueChanged += new System.EventHandler(this.usertxt_OnValueChanged);
            this.usertxt.MouseEnter += new System.EventHandler(this.usertxt_MouseEnter);
            this.usertxt.MouseLeave += new System.EventHandler(this.usertxt_MouseLeave);
            // 
            // contraseñatxt
            // 
            this.contraseñatxt.BackColor = System.Drawing.Color.White;
            this.contraseñatxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contraseñatxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contraseñatxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contraseñatxt.HintForeColor = System.Drawing.Color.Empty;
            this.contraseñatxt.HintText = "";
            this.contraseñatxt.isPassword = true;
            this.contraseñatxt.LineFocusedColor = System.Drawing.Color.Crimson;
            this.contraseñatxt.LineIdleColor = System.Drawing.Color.Blue;
            this.contraseñatxt.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.contraseñatxt.LineThickness = 3;
            this.contraseñatxt.Location = new System.Drawing.Point(431, 234);
            this.contraseñatxt.Margin = new System.Windows.Forms.Padding(4);
            this.contraseñatxt.Name = "contraseñatxt";
            this.contraseñatxt.Size = new System.Drawing.Size(203, 45);
            this.contraseñatxt.TabIndex = 11;
            this.contraseñatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contraseñatxt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            this.contraseñatxt.MouseEnter += new System.EventHandler(this.contraseñatxt_MouseEnter);
            this.contraseñatxt.MouseLeave += new System.EventHandler(this.contraseñatxt_MouseLeave);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 442);
            this.Controls.Add(this.contraseñatxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.login);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usertxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contraseñatxt;
    }
}

