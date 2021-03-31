using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Windows;

namespace messagebox_hydra
{
    public partial class popup : Form
    {
        private main _parentForm = null;
        public popup(main parent)
        {
            InitializeComponent();
            _parentForm = parent;
        }
        public popup()
        {
            InitializeComponent();
        }

        private void popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < _parentForm.getModifier(); i++)
            {
                popup popup = new popup(_parentForm);
                popup.Show();
                Thread.Sleep(50);
            }
            _parentForm.redCount();
            /*
            popup popup1 = new popup(_parentForm);
            popup popup2 = new popup(_parentForm);
            popup1.Show();
            Thread.Sleep(50);
            popup2.Show();
            */
        }

        private void popup_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int width = rnd.Next((Convert.ToInt32(SystemParameters.VirtualScreenWidth) - Width) + 1);
            int height = rnd.Next((Convert.ToInt32(SystemParameters.VirtualScreenHeight) - Height) + 1);
            Location = new Point(width, height);
            _parentForm.incCount();
            int red = rnd.Next(256);
            int green = rnd.Next(256);
            int blue = rnd.Next(256);
            BackColor = Color.FromArgb(red, green, blue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
