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
            // Cerrar todos los forms
            Form[] openForms = Application.OpenForms.OfType<Form>().ToArray();
            foreach (Form form in openForms)
            {
                form.Close();
            }
        }

        private void userDataSaveButton_Click(object sender, EventArgs e)
        {
            string nombre = userName.Text;
            string rol = userRolComboBox.Text;

            if (nombre.Length <= 2)
            {
                errorProvider1.SetError(userName, "El nombre del jugador debe tener mínimo 3 carácteres.");
                return;
            }
            else
            {
                errorProvider1.SetError(userName, null);
            }
            if (rol == string.Empty)
            {
                errorProvider1.SetError(userRolComboBox, "Debes escoger un rol.");
                return;
            }
            else
            {
                errorProvider1.SetError(userRolComboBox, null);
            }

            Form3 form3 = new Form3();
            form3.nombreJugador = nombre;
            form3.rolJugador = rol;
            form3.Show();
        }
    }
}
