using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_laixuatnganhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double laisuat = Double.Parse(txtlaisuat.Text.Replace("%", "")) / 100;
            Double sotien, ketqua,sonam;
            sotien = Convert.ToDouble(txtsotien.Text);
            sonam = Convert.ToDouble(txtsonam.Text);
            for (int i = 1; i <=sonam ; i++)
            {
                ketqua = sotien * laisuat;
                lxbketqua.Items.Add("năm\t\t"+i+"\t\t"+sotien+"\t\t"+ketqua);
                sotien += ketqua;
                
            }
            
            
            }
        }
    }
