using SaveTheOcean2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheOcean2
{
    public partial class Form3 : Form
    {
        public string PlayerName { get; set; }
        public string PlayerRol { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
