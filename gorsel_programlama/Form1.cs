using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace gorsel_programlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bilgiler.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand ara = new OleDbCommand("select count(*) from kayitbilgileri where kimlik='" + textBox1.Text + "'", baglanti);
            if (ara.ExecuteScalar().ToString() == "1")
            {
                OleDbCommand sifre = new OleDbCommand("select sifre from kayitbilgileri where kimlik='" + textBox1.Text + "'", baglanti);
                if (maskedTextBox1.Text == sifre.ExecuteScalar().ToString())
                {
                    

                    Form2 frm2 = new Form2();
                    frm2.textBox1.Text = textBox1.Text;
                    this.Hide();
                    frm2.Show();
                  
                }
                else
                    MessageBox.Show("Girdiğiniş şifre hatalıdır.Lütfen tekrar deneyiniz...");
            }
            else
                MessageBox.Show("Girdiğiniz kullanıcı adı bulunamadı...");
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(3000, "LifeWindow", "İyi Günler", ToolTipIcon.Info);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                    if(textBox2.Text=="11111111111"&& maskedTextBox1.Text=="123")
                {
                    Form3 frm3 = new Form3();
                    this.Hide();
                    frm3.Show();
                }
            }


            else if (radioButton2.Checked == true)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;
            }
            else if (radioButton3.Checked == true)
            {
                panel3.Visible = true;
                panel2.Visible = false;
                panel1.Visible = false;
                
            }
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[time];
            if (time==ımageList1.Images.Count -1) {
                time = 0;
            }
            else { 
                time++; 
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult formrenk = colorDialog1.ShowDialog();
            if (formrenk == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
