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
    public partial class BuySomething : Form
    {
        public int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, totals, billNo = 1;

        public double prBu = 30000, prBC = 25000, prSa = 25000, prNa = 25000, prTa = 25000, prCo = 20000;

        public double toBu, toBC, toSa, toNa, toTa, toCo;

        public string name1, name2, name3, name4, name5, name6;

        public static int Quan, BuNo, BCNo, SaNo, NaNo, TaNo, CoNo, Totals;

        private Bills bills = new Bills(); 

        public BuySomething()
        {
            InitializeComponent();
        }

        private void BuySomething_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count1 > 0)
            {
                count1 -= 1;
            }
            label1.Text = count1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count1 += 1;
            label1.Text = count1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count2 > 0)
            {
                count2 -= 1;
            }
            label2.Text = count2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count2 += 1;
            label2.Text = count2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count3 > 0)
            {
                count3 -= 1;
            }
            label3.Text = count3.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count3 += 1;
            label3.Text = count3.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count4 > 0)
            {
                count4 -= 1;
            }
            label4.Text = count4.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count4 += 1;
            label4.Text = count4.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count5 > 0)
            {
                count5 -= 1;
            }
            label5.Text = count5.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            count5 += 1;
            label5.Text = count5.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (count6 > 0)
            {
                count6 -= 1;
            }
            label6.Text = count6.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            count6 += 1;
            label6.Text = count6.ToString();
        }

        public void button13_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (count1 > 0)
            {
                name1 = "Burger";
                toBu = prBu * count1;
                var item1 = new ListViewItem(new string[] {name1, prBu.ToString(), count1.ToString(), toBu.ToString() });
                listView1.Items.Add(item1);
            }
            if (count2 > 0)
            {
                name2 = "Berry Cake";
                toBC = prBC * count2;
                var item2 = new ListViewItem(new string[] {name2, prBC.ToString(), count2.ToString(), toBC.ToString() });
                listView1.Items.Add(item2);
            }
            if (count3 > 0)
            {
                name3 = "Sanwich";
                toSa = prSa * count3;
                var item3 = new ListViewItem(new string[] {name3, prSa.ToString(), count3.ToString(), toSa.ToString() });
                listView1.Items.Add(item3);
            }
            if (count4 > 0)
            {
                name4 = "Nachos";
                toNa = prNa * count4;
                var item4 = new ListViewItem(new string[] {name4, prNa.ToString(), count4.ToString(), toNa.ToString() });
                listView1.Items.Add(item4);
            }
            if (count5 > 0)
            {
                name5 = "Taco";
                toTa = prTa * count5;
                var item5 = new ListViewItem(new string[] {name5, prTa.ToString(), count5.ToString(), toTa.ToString() });
                listView1.Items.Add(item5);
            }
            if (count6 > 0)
            {
                name6 = "Coffee";
                toCo = prCo * count6;
                var item6 = new ListViewItem(new string[] {name6, prCo.ToString(), count6.ToString(), toCo.ToString() });
                listView1.Items.Add(item6);
            }
            if (count1 > 0 | count2 > 0 | count3 > 0 | count4 > 0 | count5 > 0 | count6 > 0)
            {
                totals = (int)toBu + (int)toBC + (int)toSa + (int)toNa + (int)toTa + (int)toCo;
                label14.Text = totals.ToString();
            }
            else
            {
                MessageBox.Show("You haven't order yet!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (totals > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to purchase what you have chosen?", "Purchase", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Purchase successful");
                    BuNo = count1;
                    BCNo = count2;
                    SaNo = count3;
                    NaNo = count4;
                    TaNo = count5;
                    CoNo = count6;
                    Quan = BuNo + BCNo + SaNo + NaNo + TaNo + CoNo;
                    Totals = totals;
                    var item = new ListViewItem(new string[] 
                    { billNo.ToString(), Quan.ToString(), BuNo.ToString(), BCNo.ToString(), SaNo.ToString(), NaNo.ToString(), TaNo.ToString(), CoNo.ToString(), Totals.ToString() });

                    billNo = billNo + 1;
                    listView1.Items.Clear();
                    count1 = count2 = count3 = count4 = count5 = count6 = 0;
                    label1.Text = label2.Text = label3.Text = label4.Text = label5.Text = label6.Text = "0";
                    label14.Text = "";
                }
            }
            else
            {
                MessageBox.Show("You haven't order yet!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
