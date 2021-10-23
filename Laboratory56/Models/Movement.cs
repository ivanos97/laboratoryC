using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory56.Models
{
    class Movement
    {
        public string Priem_nakl { get => Priem_nakl; set => Priem_nakl = value; }
        public string Raskhod_nakl { get => Raskhod_nakl; set => Raskhod_nakl = value; }

        public Movement(string priem_nakl, string raskhod_nakl)
        {
            Priem_nakl = priem_nakl;
            Raskhod_nakl = raskhod_nakl;
        }

        public Movement()
        {
            Priem_nakl = "";
            Raskhod_nakl = "";
        }
    }
}
