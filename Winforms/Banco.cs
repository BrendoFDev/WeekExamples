using Npgsql;
using System.Data;

namespace Winforms
{
    public class Banco
    {
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=Cadastro";

        public void InserirPessoa(People people)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = "INSERT INTO usuario (nome, idade, email) VALUES (@nome, @idade, @email)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nome", people.Name);
                    cmd.Parameters.AddWithValue("idade", people.Age);
                    cmd.Parameters.AddWithValue("email", people.Email);
                   
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable LoadDGV(DataTable dtPeople)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT * FROM usuario";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                   var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var row = dtPeople.NewRow();

                        row["Nome"] = reader[1];
                        row["Email"] = reader[2];
                        row["Idade"] = reader[3];

                        dtPeople.Rows.Add(row);
                    }
                }
                return dtPeople;
            }
        }
    }
}
