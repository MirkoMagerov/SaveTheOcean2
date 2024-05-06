using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SaveTheOcean2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userDataSaveButton_Click(object sender, EventArgs e)
        {
            string nombre = userName.Text;
            string rol = userRolComboBox.Text;

            Form3 form3 = new Form3();
            form3.PlayerName = nombre;
            form3.PlayerRol = rol;
            form3.Show();
        }
    }
}
