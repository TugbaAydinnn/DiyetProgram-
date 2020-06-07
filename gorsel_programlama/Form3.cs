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
using System.Data.SqlClient;


namespace gorsel_programlama
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
        }
        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bilgiler.mdb");
        OleDbConnection besinBaglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=besinbilgiler.mdb");
        DataTable tablo = new DataTable();
        DataTable besinTablo = new DataTable();
        private void listele()
        {

            besinBaglanti.Open();
            OleDbDataAdapter adtr1 = new OleDbDataAdapter("select * from besinbilgiler", besinBaglanti);
            adtr1.Fill(besinTablo);
            dataGridView2.DataSource = besinTablo;
            besinBaglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select kimlik,ad,soyad,kilo,boy,indeks,durum from kayitbilgileri1",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            besinBaglanti.Open();
            OleDbCommand besinKomut = new OleDbCommand("insert into besinbilgiler(besin_id,ad,kalori,tur) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+comboBox1.Text+"')", besinBaglanti);
            besinKomut.ExecuteNonQuery();
            besinBaglanti.Close();
            MessageBox.Show("Kayıt başarıyla yapılmıştır...");
            besinTablo.Clear();
            listele();
            for(int i = 0; i <this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                    Controls[i].Text = "";

            }
            comboBox1.Text = "";
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from besinbilgiler where besin_id=@besin_id ";
            komut = new OleDbCommand(sorgu, besinBaglanti);
          
            komut.Parameters.AddWithValue("@besin_id", dataGridView2.CurrentRow.Cells[0].Value);
            besinBaglanti.Open();
            komut.ExecuteNonQuery();
            besinBaglanti.Close();
            MessageBox.Show("Kayıt başarıyla silinmiştir...");
            besinTablo.Clear();
            listele();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            besinBaglanti.Open();
            OleDbDataAdapter adtr1 = new OleDbDataAdapter("select * from besinbilgiler where ad like'"+textBox5.Text+"%'", besinBaglanti);
            DataTable tablo2 = new DataTable();
            adtr1.Fill(tablo2);
            dataGridView2.DataSource =tablo2;
            besinBaglanti.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells["besin_id"].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells["ad"].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells["kalori"].Value.ToString();
           comboBox1.Text = dataGridView2.CurrentRow.Cells["besin_id"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "update besinbilgiler set ad=@ad,kalori=@kalori,tur=@tur where besin_id=@besin_id ";
            komut = new OleDbCommand(sorgu, besinBaglanti);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@kalori", textBox3.Text);
            komut.Parameters.AddWithValue("@tur", comboBox1.Text);
            komut.Parameters.AddWithValue("@besin_id", Convert.ToInt32(textBox1.Text));
            besinBaglanti.Open();
            komut.ExecuteNonQuery();
            besinBaglanti.Close();
            MessageBox.Show("Kayıt başarıyla güncellenmiştir...");
            besinTablo.Clear();
            listele();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }
      
        private void button7_Click(object sender, EventArgs e)
        {


            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();




        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            


        }
    }
}
