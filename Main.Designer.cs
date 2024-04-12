namespace DxSlotGame
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticoneControlBox1 = new ns1.SiticoneControlBox();
            this.siticoneElipse1 = new ns1.SiticoneElipse(this.components);
            this.siticoneGradientPanel1 = new ns1.SiticoneGradientPanel();
            this.siticonePictureBox1 = new ns1.SiticonePictureBox();
            this.siticoneGradientPanel2 = new ns1.SiticoneGradientPanel();
            this.siticonePictureBox2 = new ns1.SiticonePictureBox();
            this.siticoneGradientPanel3 = new ns1.SiticoneGradientPanel();
            this.siticonePictureBox3 = new ns1.SiticonePictureBox();
            this.siticoneElipse2 = new ns1.SiticoneElipse(this.components);
            this.siticoneElipse3 = new ns1.SiticoneElipse(this.components);
            this.siticonePictureBox4 = new ns1.SiticonePictureBox();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.siticoneGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).BeginInit();
            this.siticoneGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Animated = false;
            this.siticoneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(3)))), ((int)(((byte)(16)))));
            this.siticoneButton1.BorderThickness = 5;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(93)))));
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(302, 343);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(171, 45);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.Text = "SPIN";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(3)))), ((int)(((byte)(16)))));
            this.siticoneControlBox1.BorderThickness = 3;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(93)))));
            this.siticoneControlBox1.Location = new System.Drawing.Point(596, 238);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 5;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 55;
            this.siticoneElipse1.TargetControl = this.siticoneGradientPanel1;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.Controls.Add(this.siticonePictureBox1);
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(43)))), ((int)(((byte)(17)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(20)))), ((int)(((byte)(13)))));
            this.siticoneGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(262, 193);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(82, 120);
            this.siticoneGradientPanel1.TabIndex = 7;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(79, 120);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            // 
            // siticoneGradientPanel2
            // 
            this.siticoneGradientPanel2.Controls.Add(this.siticonePictureBox2);
            this.siticoneGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(43)))), ((int)(((byte)(17)))));
            this.siticoneGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(20)))), ((int)(((byte)(13)))));
            this.siticoneGradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(352, 193);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.ShadowDecoration.Parent = this.siticoneGradientPanel2;
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(87, 120);
            this.siticoneGradientPanel2.TabIndex = 8;
            // 
            // siticonePictureBox2
            // 
            this.siticonePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox2.Image")));
            this.siticonePictureBox2.Location = new System.Drawing.Point(-2, -3);
            this.siticonePictureBox2.Name = "siticonePictureBox2";
            this.siticonePictureBox2.ShadowDecoration.Parent = this.siticonePictureBox2;
            this.siticonePictureBox2.Size = new System.Drawing.Size(89, 120);
            this.siticonePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox2.TabIndex = 1;
            this.siticonePictureBox2.TabStop = false;
            // 
            // siticoneGradientPanel3
            // 
            this.siticoneGradientPanel3.Controls.Add(this.siticonePictureBox3);
            this.siticoneGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(43)))), ((int)(((byte)(17)))));
            this.siticoneGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(20)))), ((int)(((byte)(13)))));
            this.siticoneGradientPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGradientPanel3.Location = new System.Drawing.Point(455, 193);
            this.siticoneGradientPanel3.Name = "siticoneGradientPanel3";
            this.siticoneGradientPanel3.ShadowDecoration.Parent = this.siticoneGradientPanel3;
            this.siticoneGradientPanel3.Size = new System.Drawing.Size(74, 120);
            this.siticoneGradientPanel3.TabIndex = 9;
            // 
            // siticonePictureBox3
            // 
            this.siticonePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox3.Image")));
            this.siticonePictureBox3.Location = new System.Drawing.Point(0, 0);
            this.siticonePictureBox3.Name = "siticonePictureBox3";
            this.siticonePictureBox3.ShadowDecoration.Parent = this.siticonePictureBox3;
            this.siticonePictureBox3.Size = new System.Drawing.Size(74, 120);
            this.siticonePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox3.TabIndex = 2;
            this.siticonePictureBox3.TabStop = false;
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.BorderRadius = 55;
            this.siticoneElipse2.TargetControl = this.siticoneGradientPanel2;
            // 
            // siticoneElipse3
            // 
            this.siticoneElipse3.BorderRadius = 55;
            this.siticoneElipse3.TargetControl = this.siticoneGradientPanel3;
            // 
            // siticonePictureBox4
            // 
            this.siticonePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox4.Image")));
            this.siticonePictureBox4.Location = new System.Drawing.Point(-2, -38);
            this.siticonePictureBox4.Name = "siticonePictureBox4";
            this.siticonePictureBox4.ShadowDecoration.Parent = this.siticonePictureBox4;
            this.siticonePictureBox4.Size = new System.Drawing.Size(794, 573);
            this.siticonePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox4.TabIndex = 6;
            this.siticonePictureBox4.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(790, 452);
            this.Controls.Add(this.siticoneGradientPanel3);
            this.Controls.Add(this.siticoneGradientPanel2);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticonePictureBox4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DxSlotGame";
            this.siticoneGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.siticoneGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).EndInit();
            this.siticoneGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticonePictureBox siticonePictureBox1;
        private ns1.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Timer timer1;
        private ns1.SiticonePictureBox siticonePictureBox2;
        private ns1.SiticonePictureBox siticonePictureBox3;
        private ns1.SiticoneControlBox siticoneControlBox1;
        private ns1.SiticonePictureBox siticonePictureBox4;
        private ns1.SiticoneElipse siticoneElipse1;
        private ns1.SiticoneGradientPanel siticoneGradientPanel1;
        private ns1.SiticoneGradientPanel siticoneGradientPanel2;
        private ns1.SiticoneGradientPanel siticoneGradientPanel3;
        private ns1.SiticoneElipse siticoneElipse2;
        private ns1.SiticoneElipse siticoneElipse3;
    }
}

