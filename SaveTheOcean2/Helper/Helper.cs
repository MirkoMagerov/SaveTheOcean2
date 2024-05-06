namespace SaveTheOcean2.Helper
{
    public class Helper
    {
        public static bool EleccionCorrecta(int valorMinimo, int valorMaximo, int eleccion)
        {
            return eleccion <= valorMaximo && eleccion >= valorMinimo;
        }
    }
}
