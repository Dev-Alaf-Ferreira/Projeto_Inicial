using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        //Atributos
        private int usuario_ID;
        private string loginName;
        private string senha;
        private string primeiroNome;
        private string sobreNome;
        private string cargo;
        private string email;

        public UserModel(int usuario_ID, string loginName, string senha, string primeiroNome, string sobreNome, string cargo, string email)
        {
            this.usuario_ID = usuario_ID;
            this.loginName = loginName;
            this.senha = senha;
            this.primeiroNome = primeiroNome;
            this.sobreNome = sobreNome;
            this.cargo = cargo;
            this.email = email;
        }
        public UserModel()
        {

        }

        UserDao userDao1 = new UserDao();
        //Atributos editConsultas
        private int id_contatos;
        private string nome;
        private string endereco;
        private string telefone;
        private string Email;
        /// /
        /// 
        public string editUserProfile()
        {
            
            try
            {
                userDao.editProfile(usuario_ID, loginName, senha, primeiroNome, sobreNome, email);
                LoginUser(loginName, senha);
                return "Perfil atualizado com sucesso";
            }
            catch(Exception ex)
            {
                return "Usuário já está registrado, tente novamente";
            }
        }
        public string editUserConsultas()
        {

            try
            {
                userDao1.editConsultas(id_contatos, nome, endereco, telefone, Email);
                LoginUser(loginName, senha);
                return "Consulta atualizada com sucesso";
            }
            catch (Exception ex)
            {
                return "Usuário não existente, tente novamente";
            }
        }
        public bool LoginUser(string usuario, string senha)
        {
            return userDao.Login(usuario, senha);
        }
        public string Recuperarsenha(string userRequesting)
        {
            return userDao.RecuperarSenha(userRequesting);
        }
        public void AnyMethod()
        {
            //Seguranças e Permissões
            if (UserCache.Cargo == Cargo.Administrador)
            {
                //Codes
            }
            if (UserCache.Cargo == Cargo.Recepcionista || UserCache.Cargo == Cargo.Administracao || UserCache.Cargo == Cargo.Designer || UserCache.Cargo == Cargo.Contador)
            {
                //Codes
            }
        }
    }
}
