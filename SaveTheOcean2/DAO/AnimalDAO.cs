using Npgsql;
using SaveTheOcean2.Connections;
using SaveTheOcean2.Model;

namespace SaveTheOcean2.DAO
{
    public class AnimalDAO : IAnimalDAO
    {
        private readonly string connectionString;

        public AnimalDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddAnimal(AAnimal animal)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO animals (nombre, superfamilia, especie, pesoaproximado) VALUES(@nombre, @superfamilia, @especie, @pesoaproximado)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("nombre", animal.Nombre);
                    command.Parameters.AddWithValue("superfamilia", animal.Superfamilia);
                    command.Parameters.AddWithValue("especie", animal.Especie);
                    command.Parameters.AddWithValue("pesoaproximado", animal.PesoAproximado);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAnimal(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM animals WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<AAnimal> GetAllAnimals()
        {
            List<AAnimal> animals = new List<AAnimal>();

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
                            if (reader.GetString(reader.GetOrdinal("superfamilia")) == "Cetaceo")
                            {
                                animals.Add(NpgsqlUtils.GetCetaceo(reader));
                            }
                            else if (reader.GetString(reader.GetOrdinal("superfamilia")) == "Ave Marina")
                            {
                                animals.Add(NpgsqlUtils.GetAveMarina(reader));
                            }
                            else
                            {
                                animals.Add(NpgsqlUtils.GetTortugaMarina(reader));
                            }
                        }
                    }
                }
            }

            return animals;
        }

        public AAnimal GetAnimalById(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM animals WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetString(reader.GetOrdinal("superfamilia")) == "Cetaceo")
                            {
                                return NpgsqlUtils.GetCetaceo(reader);
                            }
                            else if (reader.GetString(reader.GetOrdinal("superfamilia")) == "Ave Marina")
                            {
                                return NpgsqlUtils.GetAveMarina(reader);
                            }
                            else
                            {
                                return NpgsqlUtils.GetTortugaMarina(reader);
                            }
                        }
                        return null;
                    }
                }
            }
        }

        public void UpdateAnimal(AAnimal animal)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE animals SET nombre = @nombre, especie = @especie, pesoaproximado = @pesoaproximado WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("nombre", animal.Nombre);
                    command.Parameters.AddWithValue("especie", animal.Especie);
                    command.Parameters.AddWithValue("pesoaproximado", animal.PesoAproximado);
                    command.Parameters.AddWithValue("id", animal.Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
