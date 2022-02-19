using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_Oil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cafe_groupBox_Enter(object sender, EventArgs e)
        {
           
        }
        public Gasoline A_95 = new Gasoline()
        {
            Gas_name="A_95",
            Gas_price=1.50
        };
        public Gasoline A_92 = new Gasoline()
        {
            Gas_name = "A_92",
            Gas_price = 1.00
        };
        public Gasoline A_98 = new Gasoline()
        {
            Gas_name = "A_98",
            Gas_price = 1.80
        };
        public Gasoline dizel = new Gasoline()
        {
            Gas_name = "Dizel",
            Gas_price = 0.70
        };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GasPrice_textBox.Text = (comboBox1.SelectedItem as Gasoline).Gas_price.ToString();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(A_92);
            comboBox1.Items.Add(A_95);
            comboBox1.Items.Add(A_98);
            comboBox1.Items.Add(dizel);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Litr_textBox.Enabled = radioButton1.Checked;   
            Amount_textBox.Enabled = radioButton2.Checked;  

            if(radioButton1.Checked)
            {
                Amount_textBox.Text = "";
            }
            else
            {
                Litr_textBox.Text = "";
            }

        }

        private void Litr_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Litr_textBox.Text != "")
            {
                lbl_oil.Text = (double.Parse(Litr_textBox.Text) * (comboBox1.SelectedItem as Gasoline).Gas_price).ToString();
            }
            else
            {
                lbl_oil.Text = "0";
            }
        }

        private void Amount_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Amount_textBox.Text != "")
            {
                lbl_oil.Text = Amount_textBox.Text;
            }
            else
            {
                lbl_oil.Text = "0";
            }
        }

        private void HotDog_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            HotDog_textBox.Enabled = HotDog_checkBox.Checked;
        }

        private void Hamburger_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Hamburger_textBox.Enabled = Hamburger_checkBox.Checked;
        }

        private void IceCream_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            IceCream_textBox.Enabled = IceCream_checkBox.Checked;
        }

        private void CocaCola_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CocaCola_textBox.Enabled = CocaCola_checkBox.Checked;
        }


        double Ht_price = 0;
        double Hm_price = 0;
        double Ic_price = 0;
        double Coca_price = 0;
        double Cafe = 0;
        private void HotDog_textBox_TextChanged(object sender, EventArgs e)
        {
            if(HotDog_textBox.Text != "")
            {
                Ht_price = double.Parse(HotDog_textBox.Text) * 4.00;
                Hm_price = double.Parse(Hamburger_textBox.Text) * 5.40;
                Ic_price = double.Parse(IceCream_textBox.Text) * 3.50;
                Coca_price = double.Parse(CocaCola_textBox.Text) * 2.30;

                Cafe = Ht_price + Hm_price + Ic_price + Coca_price;
                lbl_cafe.Text = Cafe.ToString();    
            }
            
        }

        private void Hamburger_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Hamburger_textBox.Text != "")
            {
                Ht_price = double.Parse(HotDog_textBox.Text) * 4.00;
                Hm_price = double.Parse(Hamburger_textBox.Text) * 5.40;
                Ic_price = double.Parse(IceCream_textBox.Text) * 3.50;
                Coca_price = double.Parse(CocaCola_textBox.Text) * 2.30;

                Cafe = Ht_price + Hm_price + Ic_price + Coca_price;
                lbl_cafe.Text = Cafe.ToString();
            }
        }

        private void IceCream_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IceCream_textBox.Text != "")
            {
                Ht_price = double.Parse(HotDog_textBox.Text) * 4.00;
                Hm_price = double.Parse(Hamburger_textBox.Text) * 5.40;
                Ic_price = double.Parse(IceCream_textBox.Text) * 3.50;
                Coca_price = double.Parse(CocaCola_textBox.Text) * 2.30;

                Cafe = Ht_price + Hm_price + Ic_price + Coca_price;
                lbl_cafe.Text = Cafe.ToString();
            }
        }

        private void CocaCola_textBox_TextChanged(object sender, EventArgs e)
        {
            if (CocaCola_textBox.Text != "")
            {
                Ht_price = double.Parse(HotDog_textBox.Text) * 4.00;
                Hm_price = double.Parse(Hamburger_textBox.Text) * 5.40;
                Ic_price = double.Parse(IceCream_textBox.Text) * 3.50;
                Coca_price = double.Parse(CocaCola_textBox.Text) * 2.30;

                Cafe = Ht_price + Hm_price + Ic_price + Coca_price;
                lbl_cafe.Text = Cafe.ToString();
            }
        }

        private void lbl_oil_TextChanged(object sender, EventArgs e)
        {
            if(lbl_oil.Text != "")
            {
                lbl_total.Text = (double.Parse(lbl_oil.Text) + double.Parse(lbl_cafe.Text)).ToString();

            }
        }

        private void lbl_cafe_TextChanged(object sender, EventArgs e)
        {
            if (lbl_cafe.Text != "")
            {
                lbl_total.Text = (double.Parse(lbl_oil.Text) + double.Parse(lbl_cafe.Text)).ToString();

            }
        }

        private void Total_Click(object sender, EventArgs e)
        {
            Ht_price = 0;
            Hm_price = 0;
            Ic_price = 0;
            Coca_price = 0;
            Cafe = 0;
            Litr_textBox.Text = "0";
            Amount_textBox.Text = "0";  
            lbl_oil.Text = "0";
            lbl_cafe.Text = "0";
            lbl_total.Text = "0";
            Hamburger_checkBox.Checked = false; 
            HotDog_checkBox.Checked = false;
            IceCream_checkBox.Checked = false;  
            CocaCola_checkBox.Checked = false;  
            Hamburger_textBox.Text = "0";
            HotDog_textBox.Text = "0";
            IceCream_textBox.Text = "0";
            CocaCola_textBox.Text = "0";
        }
    }
}
