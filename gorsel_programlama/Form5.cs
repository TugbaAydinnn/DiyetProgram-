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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bilgiler.mdb");
        DataTable tablo = new DataTable();
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {


            
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select durum,COUNT(*) from kayitbilgileri1 group by durum", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
                textBox1.Text = dataGridView1.Rows[7].Cells[1].Value.ToString();
                textBox8.Text = dataGridView1.Rows[6].Cells[1].Value.ToString();

                textBox7.Text = dataGridView1.Rows[5].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[4].Cells[1].Value.ToString();

                textBox3.Text = dataGridView1.Rows[3].Cells[1].Value.ToString();

                textBox6.Text = dataGridView1.Rows[2].Cells[1].Value.ToString();

                textBox5.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();

                textBox4.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();



   

            chart1.Series["Hastalar"].Points.AddXY(label8.Text, textBox8.Text);
            chart1.Series["Hastalar"].Points.AddXY(label7.Text, textBox7.Text);
            chart1.Series["Hastalar"].Points.AddXY(label6.Text, textBox6.Text);
            chart1.Series["Hastalar"].Points.AddXY(label5.Text, textBox5.Text);
            chart1.Series["Hastalar"].Points.AddXY(label4.Text, textBox4.Text);
            chart1.Series["Hastalar"].Points.AddXY(label3.Text, textBox3.Text);
            chart1.Series["Hastalar"].Points.AddXY(label2.Text, textBox2.Text);
            chart1.Series["Hastalar"].Points.AddXY(label1.Text, textBox1.Text);
            baglanti.Close();





        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
