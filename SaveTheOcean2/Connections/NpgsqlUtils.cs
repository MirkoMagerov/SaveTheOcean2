using Microsoft.Extensions.Configuration;
using Npgsql;
using SaveTheOcean2.Model;

namespace SaveTheOcean2.Connections
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // He cambiado el modo de conseguir la connexión para poder usar rutas relativas
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(baseDir, "../../../"))
                .AddJsonFile("Connections/appsettings.json")
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static Cetaceo GetCetaceo(NpgsqlDataReader reader)
        {
            Cetaceo cetaceo = new Cetaceo()
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                Superfamilia = reader.GetString(reader.GetOrdinal("superfamilia")),
                Especie = reader.GetString(reader.GetOrdinal("especie")),
                PesoAproximado = reader.GetInt32(reader.GetOrdinal("pesoaproximado")),
            };

            return cetaceo;
        }

        public static AveMarina GetAveMarina(NpgsqlDataReader reader)
        {
            AveMarina aveMarina = new AveMarina()
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                Superfamilia = reader.GetString(reader.GetOrdinal("superfamilia")),
                Especie = reader.GetString(reader.GetOrdinal("especie")),
                PesoAproximado = reader.GetInt32(reader.GetOrdinal("pesoaproximado")),
            };

            return aveMarina;
        }

        public static TortugaMarina GetTortugaMarina(NpgsqlDataReader reader)
        {
            TortugaMarina tortugaMarina = new TortugaMarina()
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                Superfamilia = reader.GetString(reader.GetOrdinal("superfamilia")),
                Especie = reader.GetString(reader.GetOrdinal("especie")),
                PesoAproximado = reader.GetInt32(reader.GetOrdinal("pesoaproximado")),
            };

            return tortugaMarina;
        }

        public static Rescate GetRescate(NpgsqlDataReader reader)
        {
            Rescate rescate = new Rescate()
            {
                NumeroRescate = reader.GetString(reader.GetOrdinal("numerorescate")),
                FechaRescate = reader.GetDateTime(reader.GetOrdinal("fecharescate")),
                Superfamilia = reader.GetString(reader.GetOrdinal("superfamilia")),
                GradoAfectacion = reader.GetInt32(reader.GetOrdinal("gradoafectacion")),
                Localizacion = reader.GetString(reader.GetOrdinal("localizacion"))
            };

            return rescate;
        }
    }
}
