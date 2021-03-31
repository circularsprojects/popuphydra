using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace messagebox_hydra
{
    public partial class main : Form
    {
        public int count = 0;
        public int modifier = 2;

        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            popup popup = new popup(this);
            popup.Show();
        }

        public void redCount()
        {
            count--;
            label1.Text = "Open Windows: " + count;
        }

        public void incCount()
        {
            count++;
            label1.Text = "Open Windows: " + count;
        }

        public int getModifier()
        {
            return modifier;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            modifier = trackBar1.Value;
        }
    }
}
