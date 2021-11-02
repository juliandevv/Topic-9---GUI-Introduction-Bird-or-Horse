using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___GUI_Introduction_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            imgHorse.Image = Properties.Resources.Bird;
        }

        private void btnHorse_Click(object sender, EventArgs e)
        {
            
            
            imgHorse.Image = Properties.Resources.Horse;
        }
    }
}
