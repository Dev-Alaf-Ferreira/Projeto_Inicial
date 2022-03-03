using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;


namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {
        public bool Login(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from UsuariosAdm where LoginName = @usuario and Senha = @senha";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            UserLoginCache.Usuario_ID = reader.GetInt32(0);
                            UserLoginCache.PrimeiroNome = reader.GetString(3);
                            UserLoginCache.SobreNome = reader.GetString(4);
                            UserLoginCache.Email = reader.GetString(5);
                            UserLoginCache.Cargo = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;

                }
            }
        }
    }
}
