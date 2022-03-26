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
                            UserCache.UsuarioID = reader.GetInt32(0);
                            UserCache.LoginName = reader.GetString(1);
                            UserCache.Senha = reader.GetString(2);
                            UserCache.PrimeiroNome = reader.GetString(3);
                            UserCache.SobreNome = reader.GetString(4);
                            UserCache.Email = reader.GetString(5);
                            UserCache.Cargo = reader.GetString(6);
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
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from UsuariosAdm where LoginName= @usuario or Email=@mail";
                    command.Parameters.AddWithValue("@usuario", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType= CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string usuarioName = reader.GetString(3) + " " + reader.GetString(4);
                        string usuarioMail = reader.GetString(5);
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
                        return "Sorry, you do not have an account with that mail or username";
                }
            }
        }
        public DataTable editConsultas(int id_contatos, string nome, string endereco, string telefone, string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    DataTable dt = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "ListaConsulta";
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@endereço", endereco);
                    command.Parameters.AddWithValue("@telefone", telefone);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@id_contatos", id_contatos);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    return dt;
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
                ||  UserCache.Cargo == Cargo.Contador)
            {
                //Codes
            }
        }
    }
}
