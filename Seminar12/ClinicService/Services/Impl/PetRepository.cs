using ClinicService.Models;
using System.Data.SQLite;

namespace ClinicService.Services.Impl
{
    public class PetRepository : IPetRepository
    {
        private const string connectionString = "Data Source = clinic.db; Version = 3; Pooling = true; Max Pool Size = 100;";
        public int Create(Pet item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на добавление данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO Pets(ClientId, Name, Birthday) VALUES(@ClientId, @Name, @Birthday)";
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public int Update(Pet item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на обновление данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "UPDATE Pets SET ClientId = @ClientId, Name = @Name, Birthday = @Birthday WHERE PetId = @PetId";
                command.Parameters.AddWithValue("@PetId", item.PetId);
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public int Delete(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на удаление данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "DELETE FROM Pets WHERE PetId=@PetId";
                command.Parameters.AddWithValue("@PetId", id);
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public IList<Pet> GetAll()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            List<Pet> list = new List<Pet>();
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на получение данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM Pets";
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pet pet = new Pet
                    {
                        PetId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        Birthday = new DateTime(reader.GetInt64(3))
                    };

                    list.Add(pet);
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public Pet GetById(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на получение данных по конкретному клиенту
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM Pets WHERE PetId=@PetId";
                command.Parameters.AddWithValue("@PetId", id);
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read()) // Если удалось что-то прочитать
                {
                    // возвращаем прочитанное
                    return new Pet
                    {
                        PetId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        Birthday = new DateTime(reader.GetInt64(3))
                    };
                }
                else
                {
                    // Не нашлась запись по идентификатору
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
