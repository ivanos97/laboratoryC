using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;

namespace Laboratory56.Models
{
    class Expendable
    {


        public int Id_raskhod_nakl { get => Id_raskhod_nakl; set => Id_raskhod_nakl = value; }
        public DateTime Date { get => Date; set => Date = value; }
        public List<string> Sklad { get => Sklad; set => Sklad = value; }
        public string Inventar { get => Inventar; set => Inventar = value; }
        public string Kolich_yedinitsa { get => Kolich_yedinitsa; set => Kolich_yedinitsa = value; }
        public string Sotrudnik { get => Sotrudnik; set => Sotrudnik = value; }

        public Expendable(int id_raskhod_nakl, DateTime date, List<string> sklad, string inventar, string kolich_yedinitsa, string sotrudnik)
        {
            Id_raskhod_nakl = id_raskhod_nakl;
            Date = date;
            Sklad = sklad;
            Inventar = inventar;
            Kolich_yedinitsa = kolich_yedinitsa;
            Sotrudnik = sotrudnik;
        }

        public Expendable()
        {
            Id_raskhod_nakl = 0;
            Date = new DateTime();
            Sklad = new List<string>();
            Inventar = "";
            Kolich_yedinitsa = "";
            Sotrudnik = "";
        }
    }
}
