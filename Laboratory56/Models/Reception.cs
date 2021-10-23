using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory56.Models
{
    class Reception
    {
        public int Id_priem_nakl { get => Id_priem_nakl; set => Id_priem_nakl = value; }
        public DateTime Date { get => Date; set => Date = value; }
        public List<string> Sklad { get => Sklad; set => Sklad = value; }
        public string Inventar { get => Inventar; set => Inventar = value; }
        public int Kolich_yedinitsa { get => Kolich_yedinitsa; set => Kolich_yedinitsa = value; }
        public string Sotrudnik { get => Sotrudnik; set => Sotrudnik = value; }

        public Reception(int id_priem_nakl, DateTime date, List<string> sklad, string inventar, int kolich_yedinitsa, string sotrudnik)
        {
            Id_priem_nakl = id_priem_nakl;
            Date = date;
            Sklad = sklad;
            Inventar = inventar;
            Kolich_yedinitsa = kolich_yedinitsa;
            Sotrudnik = sotrudnik;
        }

        public Reception()
        {
            Id_priem_nakl = 0;
            Date = new DateTime();
            Sklad = new List<string>();
            Inventar = "";
            Kolich_yedinitsa = 0;
            Sotrudnik = "";
        }
    }
}
