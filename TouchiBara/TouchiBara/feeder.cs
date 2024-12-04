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
    public partial class feeder : Form
    {
        Magazin magazin;
        public feeder()
        {       
            InitializeComponent();
        }
        public void update()
        {
            
            int count=52;
            magazin = new Magazin();
            int count1 = magazin.foodick.qualities;
            label1.Text =magazin.foodick.name+" "+count;
        }
        private void feeder_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(magazin.foodick.qualities.ToString());
            update();
        }
    }
}
