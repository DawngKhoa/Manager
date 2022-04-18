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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            BuySomething buysomething = new BuySomething()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None,
            };
            this.panel3.Controls.Add(buysomething);
            buysomething.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Bills bills = new Bills()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None,
            };
            this.panel3.Controls.Add(bills);
            bills.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to sign out?", "Sign out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                SignIn signin = new SignIn();
                signin.ShowDialog();
                this.Close();
            }
        }
    }
}
