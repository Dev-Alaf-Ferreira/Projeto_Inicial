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
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void editProfile(int id, string loginName, string senha, string primeiroNome, string sobreNome, string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update UsuariosAdm set " +
                        "LoginName=@username, Senha=@senha, PrimeiroNome=@Pnome, SobreNome=@Sbnome, Email=@mail where Usuario_ID=@id";
                    command.Parameters.AddWithValue("@username", loginName);
                    command.Parameters.AddWithValue("@senha", senha);
                    command.Parameters.AddWithValue("@Pnome", primeiroNome);
                    command.Parameters.AddWithValue("@Sbnome", sobreNome);
                    command.Parameters.AddWithValue("@mail", email);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
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
                            UserCache.Usuario_ID = reader.GetInt32(0);
                            UserCache.LoginName = reader.GetString(1);
                            UserCache.Senha = reader.GetString(2);
                            UserCache.PrimeiroNome = reader.GetString(3);
                            UserCache.SobreNome = reader.GetString(4);
                            UserCache.Cargo = reader.GetString(6);
                            UserCache.Email = reader.GetString(5);

                        }
                        return true;
                    }
                    else
                        return false;

                }
            }
        }
        //
        public string RecuperarSenha(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from UsuariosAdm where LoginName= @usuario or Email=@mail";
                    command.Parameters.AddWithValue("@usuario", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string usuarioName = reader.GetString(3) + " " + reader.GetString(4);
                        string usuarioMail = reader.GetString(6);
                        string contaSenha = reader.GetString(2);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.SendMail(
                            subject: "SYSTEM: Password recovery request",
                            body: "Olá, " + usuarioName + "\n você pediu para recuperar sua senha. \n" + "sua senha atual é: " + contaSenha +
                                  "\nNo entanto, pedimos que você altere sua senha imediatamente assim que entrar no sistema",
                            recipientMail: new List<string> { usuarioMail }
                            );
                        return "Olá, " + usuarioName + "\nVocê pediu para recuperar sua senha. \n"
                               + "Por favor cheque o seu E-mail: " + usuarioMail +
                               "\nNo entanto, pedimos que você altere sua senha imediatamente assim que entrar no sistema";
                    }
                    else
                        return "Desculpe, você não tem uma conta com esse e-mail ou nome de usuário";
                }
            }
        }
        public void editConsultas(string nome, string endereco, string telefone, string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var comando = new SqlCommand())
                {

                    comando.Connection = connection;
                    comando.CommandText = "InserirContatos";
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@endereco", endereco);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    comando.Connection.Close();

                }
            }
        }
        public DataTable Mostrar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = "MostrarContatos";
                    comando.CommandType = CommandType.StoredProcedure;
                    leer = comando.ExecuteReader();
                    tabla.Load(leer);
                    connection.Close();
                    return tabla;
                }
            }
        }
        public void BtEditar(string nome, string endereco, string telefone, string email, int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = "EditarContatos";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@endereco", endereco);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    comando.Connection.Close();
                }
            }
        }
        public void Eliminar(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = "EliminarContato";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idCont", id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    comando.Connection.Close();
                }
            }
        }
        public void AnyMethod()
        {
            if (UserCache.Cargo == Cargo.Administrador)
            {
                //Codes
            }
            if (UserCache.Cargo == Cargo.Recepcionista || UserCache.Cargo == Cargo.Administracao || UserCache.Cargo == Cargo.Designer
                || UserCache.Cargo == Cargo.Contador)
            {
                //Codes
            }
        }
    }
}
    

