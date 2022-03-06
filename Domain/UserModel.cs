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
        public bool LoginUser(string usuario, string senha)
        {
            return userDao.Login(usuario, senha);
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
