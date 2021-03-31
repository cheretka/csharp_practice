using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Magnetic : Form
    {
        public Magnetic()
        {
            InitializeComponent();
        }

        private void recoverElectricParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form01 f = new Form01();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form02 f = new Form02();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form03 f = new Form03();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form04 f = new Form04();
            f.Show();
        }
    }
}
