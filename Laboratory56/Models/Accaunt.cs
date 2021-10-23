using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory56.Models
{
    class Accaunt
    {
        public int Num_Accaunt { get => Num_Accaunt; set => Num_Accaunt = value; }
        public string Login { get => Login; set => Login = value; }
        public string Password { get => Password; set => Password = value; }

        public Accaunt(int num_Accaunt, string login, string password)
        {
            Num_Accaunt = num_Accaunt;
            Login = login;
            Password = password;
        }

        public Accaunt()
        {
            Num_Accaunt = 0;
            Login = "";
            Password = "";
        }
    }
}
