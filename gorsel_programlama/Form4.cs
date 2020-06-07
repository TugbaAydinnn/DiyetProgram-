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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bilgiler.mdb");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into kayitbilgileri(kimlik,ad,soyad,sifre,kilo,boy) values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" +maskedTextBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglanti);
            komut.ExecuteReader();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla yapılmıştır...");
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Orange;
            label2.ForeColor = Color.Orange;
            label3.ForeColor = Color.Orange;
            label5.ForeColor = Color.Orange;
            label6.ForeColor = Color.Orange;
            label7.ForeColor = Color.Orange;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Pink;
            label2.ForeColor = Color.Pink;
            label3.ForeColor = Color.Pink;
            label5.ForeColor = Color.Pink;
            label6.ForeColor = Color.Pink;
            label7.ForeColor = Color.Pink;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("  ",9);
            label2.Font = new Font("  ", 9);
            label3.Font = new Font("  ", 9);
            label5.Font = new Font("  ", 9);
            label6.Font = new Font("  ", 9);
            label7.Font = new Font("  ", 9);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("  ", 10);
            label2.Font = new Font("  ", 10);
            label3.Font = new Font("  ", 10);
            label5.Font = new Font("  ", 10);
            label6.Font = new Font("  ", 10);
            label7.Font = new Font("  ", 10);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("  ", 11);
            label2.Font = new Font("  ", 11);
            label3.Font = new Font("  ", 11);
            label5.Font = new Font("  ", 11);
            label6.Font = new Font("  ", 11);
            label7.Font = new Font("  ", 11);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("  ", 12);
            label2.Font = new Font("  ", 12);
            label3.Font = new Font("  ", 12);
            label5.Font = new Font("  ", 12);
            label6.Font = new Font("  ", 12);
            label7.Font = new Font("  ", 12);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("  ", 13);
            label2.Font = new Font("  ", 13);
            label3.Font = new Font("  ", 13);
            label5.Font = new Font("  ", 13);
            label6.Font = new Font("  ", 13);
            label7.Font = new Font("  ", 13);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("arial", 8);
            label2.Font = new Font("arial", 8);
            label3.Font = new Font("arial", 8);
            label5.Font = new Font("arial", 8);
            label6.Font = new Font("arial", 8);
            label7.Font = new Font("arial", 8);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("times new roman", 8);
            label2.Font = new Font("times new roman", 8);
            label3.Font = new Font("times new roman", 8);
            label5.Font = new Font("times new roman", 8);
            label6.Font = new Font("times new roman", 8);
            label7.Font = new Font("times new roman", 8);

        }

        private void comicSansMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("comic sans ms", 8);
            label2.Font = new Font("comic sans ms", 8);
            label3.Font = new Font("comic sans ms", 8);
            label5.Font = new Font("comic sans ms", 8);
            label6.Font = new Font("comic sans ms", 8);
            label7.Font = new Font("comic sans ms", 8);
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Bold);
            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Bold);
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Bold);
            label5.Font = new Font(label5.Font.FontFamily, label5.Font.Size, FontStyle.Bold);
            label6.Font = new Font(label6.Font.FontFamily, label6.Font.Size, FontStyle.Bold);
            label7.Font = new Font(label7.Font.FontFamily, label7.Font.Size, FontStyle.Bold);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Regular);
            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Regular);
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Regular);
            label5.Font = new Font(label5.Font.FontFamily, label5.Font.Size, FontStyle.Regular);
            label6.Font = new Font(label6.Font.FontFamily, label6.Font.Size, FontStyle.Regular);
            label7.Font = new Font(label7.Font.FontFamily, label7.Font.Size, FontStyle.Regular);
        }

        private void dikregularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Regular);
            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Regular);
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Regular);
            label5.Font = new Font(label5.Font.FontFamily, label5.Font.Size, FontStyle.Regular);
            label6.Font = new Font(label6.Font.FontFamily, label6.Font.Size, FontStyle.Regular);
            label7.Font = new Font(label7.Font.FontFamily, label7.Font.Size, FontStyle.Regular);
        }

        private void ıtalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Italic);
            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Italic);
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Italic);
            label5.Font = new Font(label5.Font.FontFamily, label5.Font.Size, FontStyle.Italic);
            label6.Font = new Font(label6.Font.FontFamily, label6.Font.Size, FontStyle.Italic);
            label7.Font = new Font(label7.Font.FontFamily, label7.Font.Size, FontStyle.Italic);
        }

        private void altıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Underline);
            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Underline);
            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Underline);
            label5.Font = new Font(label5.Font.FontFamily, label5.Font.Size, FontStyle.Underline);
            label6.Font = new Font(label6.Font.FontFamily, label6.Font.Size, FontStyle.Underline);
            label7.Font = new Font(label7.Font.FontFamily, label7.Font.Size, FontStyle.Underline);

        }

        private void üstüÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
