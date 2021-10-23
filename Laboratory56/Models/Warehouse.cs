using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory56.Models
{
    class Warehouse
    {
        private int Nomer_sklad { get => Nomer_sklad; set => Nomer_sklad = value; }
        private string Name_sklad { get => Name_sklad; set => Name_sklad = value; }
        private string Num_phone_sklad { get => Num_phone_sklad; set => Num_phone_sklad = value; }

        public Warehouse(int nomer_sklad, string name_sklad, string num_phone_sklad)
        {
            Nomer_sklad = nomer_sklad;
            Name_sklad = name_sklad;
            Num_phone_sklad = num_phone_sklad;
        }

        public Warehouse()
        {
            Nomer_sklad = 0;
            Name_sklad = "";
            Num_phone_sklad = "";
        }


    }
}
