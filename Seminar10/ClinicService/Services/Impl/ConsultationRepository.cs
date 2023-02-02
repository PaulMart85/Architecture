using ClinicService.Models;
using System.Data.SQLite;

namespace ClinicService.Services.Impl
{
    public class ConsultationRepository : IConsultationRepository
    {
        private const string connectionString = "Data Source = clinic.db; Version = 3; Pooling = true; Max Pool Size = 100;";

        public int Create(Consultation item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на добавление данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = @"INSERT INTO Consultations(ClientId, PetId, ConsultationDate, Description) 
                                        VALUES(@ClientId, @PetId, @ConsultationDate, @Description)";
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@PetId", item.PetId);
                command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate.Ticks);
                command.Parameters.AddWithValue("@Description", item.Description);
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
        public int Update(Consultation item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на обновление данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = @"UPDATE Consultations SET ClientId = @ClientId, PetId = @PetId, 
                                        ConsultationDate = @ConsultationDate, Description = @Description
                                        WHERE ConsultationId = @ConsultationId";
                command.Parameters.AddWithValue("@ConsultationId", item.ConsultationId);
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@PetId", item.PetId);
                command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate.Ticks);
                command.Parameters.AddWithValue("@Description", item.Description);
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
                command.CommandText = "DELETE FROM Consultations WHERE ConsultationId = @ConsultationId";
                command.Parameters.AddWithValue("@ConsultationId", id);
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

        public IList<Consultation> GetAll()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            List<Consultation> list = new List<Consultation>();
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на получение данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM Consultations";
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Consultation consult = new Consultation
                    {
                        ConsultationId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        PetId = reader.GetInt32(2),
                        ConsultationDate = new DateTime(reader.GetInt64(3)),
                        Description = reader.GetString(4)
                    };

                    list.Add(consult);
                }
            }
            finally
            {
                connection.Close();
            }
            return list;

        }

        public Consultation GetById(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на получение данных по конкретному клиенту
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM Consultations WHERE ConsultationId = @ConsultationId";
                command.Parameters.AddWithValue("@ConsultationId", id);
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read()) // Если удалось что-то прочитать
                {
                    // возвращаем прочитанное
                    return new Consultation
                    {
                        ConsultationId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        PetId = reader.GetInt32(2),
                        ConsultationDate = new DateTime(reader.GetInt64(3)),
                        Description = reader.GetString(4)
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
