
namespace basket
{
    partial class Form1
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbbrger = new System.Windows.Forms.Label();
            this.lbpanel = new System.Windows.Forms.Panel();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pz1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toplam = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pricelb = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.panellb = new System.Windows.Forms.Panel();
            this.ras = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Label();
            this.showmenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showmenuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showmenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showmenuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbprice);
            this.panel1.Controls.Add(this.lbbrger);
            this.panel1.Controls.Add(this.lbpanel);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(106, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 173);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.guna2Transition1.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbprice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbprice.Location = new System.Drawing.Point(88, 149);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(24, 17);
            this.lbprice.TabIndex = 2;
            this.lbprice.Text = "90";
            // 
            // lbbrger
            // 
            this.lbbrger.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbbrger, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbbrger.Location = new System.Drawing.Point(3, 127);
            this.lbbrger.Name = "lbbrger";
            this.lbbrger.Size = new System.Drawing.Size(106, 17);
            this.lbbrger.TabIndex = 1;
            this.lbbrger.Text = "SHARP BURGER";
            // 
            // lbpanel
            // 
            this.lbpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbpanel.BackgroundImage")));
            this.lbpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Transition1.SetDecoration(this.lbpanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbpanel.Location = new System.Drawing.Point(3, 25);
            this.lbpanel.Name = "lbpanel";
            this.lbpanel.Size = new System.Drawing.Size(133, 100);
            this.lbpanel.TabIndex = 0;
            this.lbpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.Interval = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pz1);
            this.panel3.Controls.Add(this.panel4);
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(276, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 173);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.guna2Transition1.SetDecoration(this.button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button2.Location = new System.Drawing.Point(6, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(88, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "70";
            // 
            // pz1
            // 
            this.pz1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.pz1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pz1.Location = new System.Drawing.Point(3, 128);
            this.pz1.Name = "pz1";
            this.pz1.Size = new System.Drawing.Size(48, 17);
            this.pz1.TabIndex = 1;
            this.pz1.Text = "PASTA";
            this.pz1.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Transition1.SetDecoration(this.panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(3, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 100);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel5);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(450, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 173);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.guna2Transition1.SetDecoration(this.button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button3.Location = new System.Drawing.Point(4, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(88, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "34";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "KHAVE";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Transition1.SetDecoration(this.panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(3, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(133, 100);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toplam
            // 
            this.toplam.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.toplam, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toplam.Location = new System.Drawing.Point(754, 401);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(16, 17);
            this.toplam.TabIndex = 2;
            this.toplam.Text = "0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.pricelb);
            this.panel6.Controls.Add(this.namelb);
            this.panel6.Controls.Add(this.panellb);
            this.guna2Transition1.SetDecoration(this.panel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(623, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(138, 173);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.guna2Transition1.SetDecoration(this.button4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button4.Location = new System.Drawing.Point(6, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pricelb
            // 
            this.pricelb.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.pricelb, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pricelb.Location = new System.Drawing.Point(88, 149);
            this.pricelb.Name = "pricelb";
            this.pricelb.Size = new System.Drawing.Size(43, 17);
            this.pricelb.TabIndex = 2;
            this.pricelb.Text = "10 TL";
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.namelb, Guna.UI2.AnimatorNS.DecorationType.None);
            this.namelb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(3, 128);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(42, 18);
            this.namelb.TabIndex = 1;
            this.namelb.Text = "MILK";
            // 
            // panellb
            // 
            this.panellb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panellb.BackgroundImage")));
            this.panellb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Transition1.SetDecoration(this.panellb, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panellb.Location = new System.Drawing.Point(3, 25);
            this.panellb.Name = "panellb";
            this.panellb.Size = new System.Drawing.Size(133, 100);
            this.panellb.TabIndex = 0;
            this.panellb.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ras
            // 
            this.ras.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.ras, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ras.Location = new System.Drawing.Point(209, 281);
            this.ras.Name = "ras";
            this.ras.Size = new System.Drawing.Size(42, 17);
            this.ras.TabIndex = 3;
            this.ras.Text = "label2";
            // 
            // button5
            // 
            this.guna2Transition1.SetDecoration(this.button5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button5.Location = new System.Drawing.Point(197, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // read
            // 
            this.read.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.read, Guna.UI2.AnimatorNS.DecorationType.None);
            this.read.Location = new System.Drawing.Point(124, 250);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(43, 17);
            this.read.TabIndex = 5;
            this.read.Text = "32 TL";
            // 
            // showmenuBindingSource
            // 
            this.showmenuBindingSource.DataSource = typeof(basket.showmenu);
            // 
            // showmenuBindingSource1
            // 
            this.showmenuBindingSource1.DataSource = typeof(basket.showmenu);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 575);
            this.Controls.Add(this.read);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ras);
            this.Controls.Add(this.toplam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showmenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showmenuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel lbpanel;
        public System.Windows.Forms.Label lbbrger;
        public System.Windows.Forms.Label lbprice;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label pz1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label toplam;
        private System.Windows.Forms.BindingSource showmenuBindingSource;
        private System.Windows.Forms.BindingSource showmenuBindingSource1;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label pricelb;
        public System.Windows.Forms.Label namelb;
        public System.Windows.Forms.Panel panellb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label ras;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label read;
    }
}

