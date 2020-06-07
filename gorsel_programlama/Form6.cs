using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_programlama
{
    public partial class Form6 : Form
    {
        int sayac;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 100;
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value != progressBar1.Maximum)

                progressBar1.Value++;
            else
            {
                timer1.Stop();
                this.Hide();
                Form5 frm5 = new Form5();
                frm5.Show();
            }
        }
        }
    }

