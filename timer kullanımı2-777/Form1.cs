using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_kullanımı2_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ToString içine @ ile formatlı şekilde yazdırabilirsiniz.

            label1.Text = DateTime.Now.ToString(@"O");
            label2.Text = DateTime.Now.ToString(@"U");
            label3.Text = DateTime.Now.ToString(@"yyyy-MM-dd HH:mm");
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
