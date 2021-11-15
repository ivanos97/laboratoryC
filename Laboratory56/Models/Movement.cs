using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory56.Models
{
    class Movement
    {
        public Reception Priem_nakl { get => Priem_nakl; set => Priem_nakl = value; }
        public Expendable Raskhod_nakl { get => Raskhod_nakl; set => Raskhod_nakl = value; }

        public Movement(Reception priem_nakl, Expendable raskhod_nakl)
        {
            Priem_nakl = priem_nakl;
            Raskhod_nakl = raskhod_nakl;
        }

        public Movement()
        {
            Priem_nakl = new Reception();
            Raskhod_nakl = new Expendable();
        }
    }
}
