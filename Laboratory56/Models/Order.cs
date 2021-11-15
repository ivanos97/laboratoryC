using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory56.Models
{
    class Order
    {
        public int Id_zayavka { get => Id_zayavka; set => Id_zayavka = value; }
        public string Invantar { get => Invantar; set => Invantar = value; }
        public string Type_inventar { get => Type_inventar; set => Type_inventar = value; }
        public int Kolich_yedinitsa { get => Kolich_yedinitsa; set => Kolich_yedinitsa = value; }
        public Warehouse Sklad { get => Sklad; set => Sklad = value; }

        public Order(int id_zayavka, string invantar, string type_inventar, int kolich_yedinitsa, Warehouse sklad)
        {
            Id_zayavka = id_zayavka;
            Invantar = invantar;
            Type_inventar = type_inventar;
            Kolich_yedinitsa = kolich_yedinitsa;
            Sklad = sklad;
        }

        public Order()
        {
            Id_zayavka = 0;
            Invantar = "";
            Type_inventar = "";
            Kolich_yedinitsa = 0;
            Sklad = new Warehouse();
        }
    }
}
