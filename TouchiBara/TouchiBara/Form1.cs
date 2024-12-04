using System.Timers;

namespace TouchiBara
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g = 0;
            Magazin magazin = new Magazin();
            magazin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            feeder feeder = new feeder();
            feeder.Show();
        }
    }
}
