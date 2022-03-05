using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserCache
    {
        public static int UsuarioID { get; set; }
        public static string PrimeiroNome { get; set; }
        public static string SobreNome { get; set; }
        public static string Email { get; set; }
        public static string Cargo { get; set; }
    }
}
