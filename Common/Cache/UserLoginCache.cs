using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int Usuario_ID { get; set; }
        public static string PrimeiroNome { get; set; }
        public static string SobreNome { get; set; }
        public static string Email { get; set; }
        public static string Cargo { get; set; }
    }
}
