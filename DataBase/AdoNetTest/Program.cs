using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AdoNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AsteroidsDB-test;Integrated Security=True";

             //DbConnectionStringBuilder builder = new DbConnectionStringBuilder();
             //var new_connectionstring = builder.ConnectionString;

             var sql_server_connectio_string_builder = new SqlConnectionStringBuilder(connection_string);
             sql_server_connectio_string_builder.IntegratedSecurity = false;
             sql_server_connectio_string_builder.UserID = "User";
             sql_server_connectio_string_builder.Password = "Password";
             sql_server_connectio_string_builder.InitialCatalog = "TestDB123";

             var new_connection_string = sql_server_connectio_string_builder.ConnectionString;*/

            const string connection_string_name = "DefaultConnection";

            var connection_string = ConfigurationManager.ConnectionStrings[connection_string_name].ConnectionString;

            ExecuteNonQuery(connection_string);

            Console.ReadLine();
        }

        private const string __SqlCreateTablePlayer = @"CREATE TABLE[dbo].[Player]
        (
     [Id] INT (1, 1) NOT NULL,
     [Name] NVARCHAR(MAX) COLLATE Cyrillic_General_CI_AS NOT NULL,
     [Email]  NVARCHAR(MAX) NULL,
     [Brithday] NVARCHAR(MAX) NULL,
     PRIMARY KEY CLUSTERED([Id] ASC)
        );";

        private const string _SqlInsertToPlayerTable = @"INSERT INTO [dbo].[Player] (Name,Biryhday,Email) VALUES (N'{0}','{1}','{2}','{3}';";

        private static void ExecuteNonQuery(string ConnectionString) { }

        private const string __SqlCountPlayers = @"SELECT COUNT(*) FROM [dbo].[Player]";

        private static void ExecuteScalar(string ConnectionString)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var count_command = new SqlCommand(__SqlCountPlayers, connection);
                if(!(count_command.ExecuteScalar() is int count))
                    throw new InvalidOperationException("Ошибка в результате выполнения команды подсчета числа строк в таблице игроков - возвращенное значение не является  значением Int123");             
            }
        }

        private const string __SqlSelectFromPlayer = @"SELECT COUNT(*) FROM [dbo].[Player]";
        private static void ExcuteReader(string ConnectionString)
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var select_comand = new SqlCommand(__SqlSelectFromPlayer, connection);

                using (var reader = select_command.ExecuteReader())
                    if(reader.HasRows)
                        while (reader.Read())
                        {
                            while id = (int) reader.GetValue(0);
                            var name = reader.GetString;
                            var email = reader["Email"] as string;
                            Console.WriteLine();
                        }
            }
        }
    }
}
