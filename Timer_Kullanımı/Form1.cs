using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Timer_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer'in belirlediğiniz period'a göre çalışan metodu
         


           DialogResult result= MessageBox.Show("Tetiklendim","Dikkat",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
            if(result== DialogResult.No)
            {

                timer1.Stop();
            }
            else { timer1.Interval = 200; }
        }
        int a = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // milisaniye cinsinden değer alır 1000 milisaniye 1 saniyedir.

        
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(textBox1.Text);
            timer1.Start();

            timer2.Interval = 1000;
            timer2.Start();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a++;
            label1.Text = (Convert.ToInt32(textBox1.Text) / 1000-a).ToString();
            if (Convert.ToInt32(label1.Text) == 0)
            {

                label1.Text = "0";
            }
        }
    }
}
