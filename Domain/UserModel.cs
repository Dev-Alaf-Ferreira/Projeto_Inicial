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
        private int Usuario_ID;
        private string LoginName;
        private string Senha;
        private string PrimeiroNome;
        private string SobreNome;
        private string Cargo;
        private string Email;

        public UserModel(int usuario_ID, string loginName, string senha, string primeiroNome, string sobreNome, string cargo, string email)
        {
            Usuario_ID = usuario_ID;
            LoginName = loginName;
            Senha = senha;
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
            Cargo = cargo;
            Email = email;
        }
        
        public string editUserProfile()
        {
            
            try
            {
                userDao.editProfile(Usuario_ID, LoginName, Senha, PrimeiroNome, SobreNome, Email);
                LoginUser(LoginName, Senha);
                return "Perfil atualizado com sucesso";
            }
            catch(Exception ex)
            {
                return "Usuário já está registrado, tente novamente";
            }
        }
        public bool LoginUser(string usuario, string senha)
        {
            return userDao.Login(usuario, senha);
        }
        public string RecuperarSenha(string userRequesting)
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
