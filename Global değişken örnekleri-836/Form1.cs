using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_değişken_örnekleri_836
{
    public partial class Form1 : Form
    {
        //Burada ki değişkenler globaldir.
        double bakiye = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = "Bakiye: "+ bakiye.ToString();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            bakiye+= 50;
            lblBakiye.Text ="Bakiye: "+ bakiye.ToString();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            bakiye -= 8;
            lblBakiye.Text = "Bakiye: " + bakiye.ToString();
            if (bakiye <=7 && bakiye>=0)
            {
                MessageBox.Show("bakiye yetersiz binemezsin");
            }
        }
    }
}
