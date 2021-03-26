using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            if (user.Equals(txtusername.Text) && pass.Equals(txtpassword.Text))
            {
                MessageBox.Show("Ban Dang Nhap Thanh Cong");
            }
            else
            {
                MessageBox.Show("Ban Dang Nhap That bai");
            } 
                
        }
    }
}
