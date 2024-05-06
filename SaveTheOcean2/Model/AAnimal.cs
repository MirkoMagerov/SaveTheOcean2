namespace SaveTheOcean2.Model
{
    public abstract class AAnimal : ITransportable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Superfamilia { get; set; }
        public string Especie { get; set; }
        public double PesoAproximado { get; set; }

        public AAnimal(string nombre, string superfamilia, string especie, double peso)
        {
            Nombre = nombre;
            Superfamilia = superfamilia;
            Especie = especie;
            PesoAproximado = peso;
        }

        /// <summary>
        /// Método que sobreescribe el ToString mostrando todos los atributos del animal
        /// </summary>
        /// <returns>Devuelve un string</returns>
        public override string ToString()
        {
            return $"Información del Animal:\n" +
                    $"------------------------\n" +
                    $"Nombre: {Nombre}\n" +
                    $"Superfamilia: {Superfamilia}\n" +
                    $"Especie: {Especie}\n" +
                    $"Peso Aproximado: {PesoAproximado} kg";
        }

        public abstract int AplicarTratamiento(string localizacion, int gradoAfectacion);
    }
}
