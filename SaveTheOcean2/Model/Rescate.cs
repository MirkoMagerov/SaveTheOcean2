using System.Text.Json;

namespace SaveTheOcean2.Model
{
    public class Rescate
    {
        public int Id { get; set; }
        public string NumeroRescate { get; set; }
        public DateTime FechaRescate { get; set; }
        public string Superfamilia { get; set; }
        public int GradoAfectacion { get; set; }
        public string Localizacion { get; set; }

        public Rescate(string superfamilia, int gradoAfectacion, string localizacion)
        {
            NumeroRescate = "RES" + new Random().Next(0, 1001);
            FechaRescate = DateTime.Now;
            Superfamilia = superfamilia;
            GradoAfectacion = gradoAfectacion;
            Localizacion = localizacion;
        }

        public Rescate() { }

        /// <summary>
        /// Método estático que genera un rescate con valores aleatorios excepto por el nombre de superfamilia
        /// </summary>
        /// <param name="superFamilia">Como la superfamilia debe de ser la misma en el rescate como en la ficha del animal, se pasa como parámetro una vez creada la ficha del animal</param>
        /// <returns></returns>
        public static Rescate GenerarRescateAleatorio(string superFamilia)
        {
            int gradoAfectacion = new Random().Next(1, 100);
            string[] localizaciones = ["Viladecans", "Horta", "Sant Andreu"];
            string localizacion = localizaciones[new Random().Next(0, 3)];

            return new Rescate(superFamilia, gradoAfectacion, localizacion);
        }

        /// <summary>
        /// Método que devuelve los atributos del rescate en formato parecido a una tabla.
        /// </summary>
        /// <returns>Devuelve un cadena de texto con los valores de cada atributo</returns>
        public override string ToString()
        {
            return $"Información del Rescate:\n" +
                    $"------------------------\n" +
                    $"Número de Rescate: {NumeroRescate}\n" +
                    $"Fecha del Rescate: {FechaRescate}\n" +
                    $"Superfamilia: {Superfamilia}\n" +
                    $"Grado de Afectación: {GradoAfectacion}%\n" +
                    $"Localización: {Localizacion}";
        }
    }
}
