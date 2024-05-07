using SaveTheOcean2.Model;

namespace SaveTheOcean2.Helper
{
    public static class Helper
    {
        public static bool EleccionCorrecta(int valorMinimo, int valorMaximo, int eleccion)
        {
            return eleccion <= valorMaximo && eleccion >= valorMinimo;
        }

        public static AAnimal GenerarAnimal(int random)
        {
            switch (random)
            {
                case 0:
                    return new Cetaceo();
                case 1:
                    return new AveMarina();
                case 2:
                    return new TortugaMarina();
                default:
                    return null;
            }
        }

        public static Rescate GenerarRescate(int random)
        {
            switch (random)
            {
                case 0:
                    return Rescate.GenerarRescateAleatorio("Cetaceo");
                case 1:
                    return Rescate.GenerarRescateAleatorio("Ave Marina");
                case 2:
                    return Rescate.GenerarRescateAleatorio("Tortuga Marina");
                default:
                    return null;
            }
        }
    }
}
