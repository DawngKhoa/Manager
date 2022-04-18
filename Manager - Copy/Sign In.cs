using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, pass;
            username = textBox1.Text;
            pass = textBox2.Text;
            if(username == "Khoa" & pass == "1234")
            {
                this.Hide();
                Management management = new Management();
                management.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Passwork is wrong");
            }
        }
    }
}
