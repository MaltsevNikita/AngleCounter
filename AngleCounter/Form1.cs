using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double f;
        private void button1_Click(object sender, EventArgs e)
        {
            sec_textBox.Text = sec_textBox.Text.Replace(".", ",");

            
            double sec = Convert.ToDouble(sec_textBox.Text);
            double min = Convert.ToDouble(min_textBox.Text);
            double deg = Convert.ToDouble(deg_textBox.Text);

            if (sec <= 60 && min <= 60 && deg <= 360)
            {
                f = ((sec / 60 + min) / 60) + deg;
                f = Math.Round(f, 12);
                Result_label.Text = f.ToString();
            }
            else {
                Result_label.Text = "Не правильный ввод";
            }
        }

        private void Count2_button_Click(object sender, EventArgs e)
        {

            double deg;
            double min;
            double sec;


            DegToConvert_textBox.Text = DegToConvert_textBox.Text.Replace(".", ",");
            double angle = Convert.ToDouble(DegToConvert_textBox.Text);

            deg = (int)(angle);
            min = (int)((angle - deg) * 60);
            sec = Math.Round((((angle - deg) * 60) - min) * 60 , 9);

            ResultDD_textBox.Text = Convert.ToString(deg);
            ResultMM_textbox.Text = Convert.ToString(min);
            ResultSS_textBox.Text = Convert.ToString(sec);

        }   
    }       
}
