using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchiBara
{
    public partial class Magazin : Form
    {
        Kapibara Kapibara;
        int money;
        public Foodick foodick = new Foodick("клубничка",1,0,10);
        public Foodick foodick2 = new Foodick("мандаринка", 5,0, 30);
        public Foodick foodick3 = new Foodick("арбузик", 10,0, 50);
        public Magazin()
        {
            InitializeComponent();
            Kapibara = new Kapibara(52);
            money = Kapibara.Money();
            
            label4.Text = money.ToString();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (money > 0) 
            {
                money -= foodick.price;
                MessageBox.Show("Спасибо за покупку");
                label4.Text = money.ToString();
                foodick.qualities += 1;
            }
            else
            {
                MessageBox.Show("У вас недостаточно средств");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money > 0)
            {
                money -= foodick2.price;
                MessageBox.Show("Спасибо за покупку");
                label4.Text = money.ToString();
                foodick2.qualities += 1;
            }
            else
            {
                MessageBox.Show("У вас недостаточно средств");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (money > 0)
            {
                money -= foodick3.price;
                MessageBox.Show("Спасибо за покупку");
                label4.Text = money.ToString();
                foodick3.qualities += 1;
            }
            else
            {
                MessageBox.Show("У вас недостаточно средств");
            }
        }
    }
}
