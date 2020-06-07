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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bilgiler.mdb");
        OleDbConnection besinBaglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=besinbilgiler.mdb");
        DataTable tablo = new DataTable();
        DataTable besintablo = new DataTable();
        private void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr=new OleDbDataAdapter("select kimlik,ad,soyad,kilo,boy from kayitbilgileri",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select kimlik,ad,soyad,kilo,boy from kayitbilgileri where kimlik='"+textBox1.Text+"'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float vki;//vki=vücut kitle indeksi
            float boy, kilo;
            kilo = Convert.ToInt32(textBox4.Text);
            boy = Convert.ToInt32(textBox5.Text);
            vki =(kilo / (boy * boy)*10000);
            textBox6.Text = vki.ToString();
            if (Convert.ToInt32(vki) < 18.5){
                label6.Visible = true;
                label6.Text = ("Zayıf");
            }
            else if ((18.5 <= Convert.ToInt32(vki))&&(Convert.ToInt32(vki) <= 24.9))
            {
                label6.Visible = true;
                label6.Text = ("Normal Kilolu");
            }
            else if ((25 < Convert.ToInt32(vki)) && (Convert.ToInt32(vki) <= 29.9))
            {
                label6.Visible = true;
                label6.Text = ("Fazla Kilolu");
            }
            else if ((30 < Convert.ToInt32(vki)) && (Convert.ToInt32(vki) <= 34.9))
            {
                label6.Visible = true;
                label6.Text = ("1. Derece Obezite");
            }
            else if ((35< Convert.ToInt32(vki)) && (Convert.ToInt32(vki) <= 39.9))
            {
                label6.Visible = true;
                label6.Text = ("2. Derece Obezite");
            }
            else if ((40 < Convert.ToInt32(vki)) && (Convert.ToInt32(vki) <= 49.9))
            {
                label6.Visible = true;
                label6.Text = ("3. Derece Obezite");
            }
            else if ((50 < Convert.ToInt32(vki)) && (Convert.ToInt32(vki) <= 59.9))
            {
                label6.Visible = true;
                label6.Text = ("süper obezite");
            }
            else 
            {
                label6.Visible = true;
                label6.Text = ("süper süper obezite");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            OleDbCommand komut = new OleDbCommand("insert into kayitbilgileri1(kimlik,ad,soyad,kilo,boy,indeks,durum) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" +label6.Text+ "')", baglanti);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Verileriniz kaydedilmiştir...");
            dataGridView1.Refresh();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            besinBaglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select besin_id,ad,kalori from besinbilgiler", besinBaglanti);
            adtr.Fill(besintablo);
            dataGridView2.DataSource = besintablo;
            besinBaglanti.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            besinBaglanti.Open();
            OleDbDataAdapter adtrr = new OleDbDataAdapter("select * from besinbilgiler where ad like'" + textBox7.Text + "%'", besinBaglanti);
            DataTable tablo2 = new DataTable();
            adtrr.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            besinBaglanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "update kayitbilgileri1 set ad=@ad,soyad=@soyad,kilo=@kilo,boy=@boy,indeks=@indeks,durum=@durum where kimlik=@kimlik ";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@kilo", textBox4.Text);
            komut.Parameters.AddWithValue("@boy", textBox5.Text);
            komut.Parameters.AddWithValue("@indeks", textBox6.Text);
            komut.Parameters.AddWithValue("@durum", label6.Text);
            komut.Parameters.AddWithValue("@kimlik", Int64.Parse(textBox1.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla güncellenmiştir...");
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select kimlik,ad,soyad,kilo,boy,indeks,durum from kayitbilgileri1 where kimlik='" + textBox1.Text + "'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
