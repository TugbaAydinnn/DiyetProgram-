namespace gorsel_programlama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(458, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 259);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(165, 112);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tc Kimlik Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Girişi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.maskedTextBox2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(458, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 259);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(164, 112);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PasswordChar = '*';
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tc Kimlik Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Diyetisyen Girişi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(458, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 259);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hesabınız yok mu ?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 28);
            this.button3.TabIndex = 0;
            this.button3.Text = "Kayıt Ol";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hasta Girişi";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(45, 106);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Diyetisten Girişi";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Lütfen Seçim Yapınız";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(45, 147);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 21);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Kayıt Ol";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton1);
            this.panel4.Controls.Add(this.radioButton3);
            this.panel4.Controls.Add(this.radioButton2);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(135, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 259);
            this.panel4.TabIndex = 9;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Diyet Programı";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 76);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 324);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iconfinder_fruiticons_buttons_grape_1844710.png");
            this.ımageList1.Images.SetKeyName(1, "iconfinder_fruiticons_buttons_lemon_1844708.png");
            this.ımageList1.Images.SetKeyName(2, "iconfinder_fruiticons_buttons_pear_1844703.png");
            this.ımageList1.Images.SetKeyName(3, "iconfinder_fruiticons_buttons_pineapple_1844707.png");
            this.ımageList1.Images.SetKeyName(4, "iconfinder_fruiticons_buttons_pomegrante_1844709.png");
            this.ımageList1.Images.SetKeyName(5, "iconfinder_fruiticons_buttons_strawberry_1844706.png");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(688, 666);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(688, 591);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 51);
            this.button5.TabIndex = 12;
            this.button5.Text = "Sayfanın Arkaplanını Ayarlamak İçin Tıklayınız";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 700);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LifeWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

