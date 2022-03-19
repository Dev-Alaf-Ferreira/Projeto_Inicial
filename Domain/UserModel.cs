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

        public UserModel(int Usuario_ID, string LoginName, string Senha, string PrimeiroNome, string SobreNome, string Cargo, string Email)
        {
            this.Usuario_ID = Usuario_ID;
            this.LoginName = LoginName;
            this.Senha = Senha;
            this.PrimeiroNome = PrimeiroNome;
            this.SobreNome = SobreNome;
            this.Cargo = Cargo;
            this.Email = Email;
        }
        public UserModel()
        {

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
        /*public void AnyMethod()
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
        }*/
    }
}
