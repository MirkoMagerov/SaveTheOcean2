using SaveTheOcean2.Connections;
using SaveTheOcean2.DAO;
using SaveTheOcean2.Model;
using System.Xml;

namespace SaveTheOcean2
{
    public partial class Form3 : Form
    {
        public string nombreJugador { get; set; }
        public string rolJugador { get; set; }
        public Jugador jugador { get; set; }
        public AnimalDAO animalDAO { get; set; }
        public RescateDAO rescateDAO { get; set; }
        public Rescate rescate { get; set; }
        public AAnimal animal { get; set; }
        private int finalGA;

        public Form3()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            jugador = new Jugador(nombreJugador);
            animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            rescateDAO = new RescateDAO(NpgsqlUtils.OpenConnection());

            int random = new Random().Next(0, 3);

            switch (random)
            {
                case 0:
                    rescate = Rescate.GenerarRescateAleatorio("Cetaceo");
                    break;
                case 1:
                    rescate = Rescate.GenerarRescateAleatorio("Ave Marina");
                    break;
                case 2:
                    rescate = Rescate.GenerarRescateAleatorio("Tortuga Marina");
                    break;
                default:
                    rescate = null;
                    break;
            }

            switch (random)
            {
                case 0:
                    animal = new Cetaceo();
                    break;
                case 1:
                    animal = new AveMarina();
                    break;
                case 2:
                    animal = new TortugaMarina();
                    break;
                default:
                    animal = null;
                    break;
            }

            idLabel.Text = rescate.NumeroRescate.ToString();
            fechaLabel.Text = rescate.FechaRescate.ToString();
            superfamiliaResLabel.Text = rescate.Superfamilia.ToString();
            gaResLabel.Text = rescate.GradoAfectacion.ToString();
            localizacionLabel.Text = rescate.Localizacion.ToString();

            animalDAO.AddAnimal(animal);
            rescateDAO.AddRescate(rescate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratarAnimal("Localizacion");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TratarAnimal("En el CRAM");
        }

        private void TratarAnimal(string localizacion)
        {
            finalGA = animal.AplicarTratamiento(localizacion, rescate.GradoAfectacion);

            if (finalGA <= 30)
            {
                MessageBox.Show($"- INFO DEL ANIMAL -\nNombre: {animal.Nombre} | Especie: {animal.Especie}\nPeso aproximado: {animal.PesoAproximado} | GA final: {finalGA}.");
                jugador.GanarExperiencia(50);
            }
            else
            {
                MessageBox.Show($"- INFO DEL ANIMAL -\nNombre: {animal.Nombre} | Especie: {animal.Especie}\nPeso aproximado: {animal.PesoAproximado} | GA final: {finalGA}.");
                jugador.PerderExperiencia(20);
            }

            SaveUserDataToXML(jugador.Nombre, rolJugador, jugador.Experiencia);

            // Cerrar todos los forms
            Form[] openForms = Application.OpenForms.OfType<Form>().ToArray();
            foreach (Form form in openForms)
            {
                form.Close();
            }
        }

        private void SaveUserDataToXML(string nombre, string rol, int exp)
        {
            const string path = "./../../../Users/userdata.xml";

            if (!File.Exists(path))
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlDeclaration xmlDecl = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlNode rootNode = xmlDoc.CreateElement("usuarios");
                xmlDoc.InsertBefore(xmlDecl, xmlDoc.DocumentElement);
                xmlDoc.AppendChild(rootNode);
                xmlDoc.Save(path);
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlElement usuarioElement = doc.CreateElement("usuario");

            XmlElement nombreElement = doc.CreateElement("nombre");
            nombreElement.InnerText = nombre;
            usuarioElement.AppendChild(nombreElement);

            XmlElement rolElement = doc.CreateElement("rol");
            rolElement.InnerText = rol;
            usuarioElement.AppendChild(rolElement);

            XmlElement xpElement = doc.CreateElement("experiencia");
            xpElement.InnerText = exp.ToString();
            usuarioElement.AppendChild(xpElement);

            doc.DocumentElement.AppendChild(usuarioElement);

            doc.Save(path);
        }
    }
}
