using Npgsql;
using SaveTheOcean2.Connections;
using SaveTheOcean2.Model;

namespace SaveTheOcean2.DAO
{
    public class RescateDAO : IRescateDAO
    {
        private readonly string connectionString;

        public RescateDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddRescate(Rescate rescate)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO rescates (numerorescate, fecharescate, superfamilia, gradoafectacion, localizacion) VALUES(@numRescate, @fechaRescate, @superFamilia, @GA, @localizacion)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("numRescate", rescate.NumeroRescate);
                    command.Parameters.AddWithValue("fechaRescate", rescate.FechaRescate);
                    command.Parameters.AddWithValue("superFamilia", rescate.Superfamilia);
                    command.Parameters.AddWithValue("GA", rescate.GradoAfectacion);
                    command.Parameters.AddWithValue("localizacion", rescate.Localizacion);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRescate(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM rescates WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Rescate> GetAllRescates()
        {
            List<Rescate> rescates = new List<Rescate>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM rescates";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rescates.Add(NpgsqlUtils.GetRescate(reader));
                        }
                    }
                }
            }

            return rescates;
        }

        public Rescate GetRescateById(int id)
        {
            Rescate rescate = null;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM rescates WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rescate = NpgsqlUtils.GetRescate(reader);
                        }
                    }
                }
            }

            return rescate;
        }

        public void UpdateRescate(Rescate rescate)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE rescates SET fechaRescate = @fechaRescate, superFamilia = @superFamilia, GA = @GA, localizacion = @localizacion WHERE numRescate = @numRescate AND id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("fechaRescate", rescate.FechaRescate);
                    command.Parameters.AddWithValue("superFamilia", rescate.Superfamilia);
                    command.Parameters.AddWithValue("GA", rescate.GradoAfectacion);
                    command.Parameters.AddWithValue("localizacion", rescate.Localizacion);
                    command.Parameters.AddWithValue("id", rescate.Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
