using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory56.Models
{
    class Werehouse_registration_card
    {
        public int Id_karta_ucheta { get => Id_karta_ucheta; set => Id_karta_ucheta = value; }
        public Reception Priem_nakl { get => Priem_nakl; set => Priem_nakl = value; }
        public string Type_inventar { get => Type_inventar; set => Type_inventar = value; }
        public string Inventar { get => Inventar; set => Inventar = value; }
        public int Kolich_yedinitsa { get => Kolich_yedinitsa; set => Kolich_yedinitsa = value; }
        public Expendable Raskhod_nakl { get => Raskhod_nakl; set => Raskhod_nakl = value; }

        public Werehouse_registration_card(int id_karta_ucheta, Reception priem_nakl, string type_inventar, string inventar, int kolich_yedinitsa, Expendable raskhod_nakl)
        {
            Id_karta_ucheta = id_karta_ucheta;
            Priem_nakl = priem_nakl;
            Type_inventar = type_inventar;
            Inventar = inventar;
            Kolich_yedinitsa = kolich_yedinitsa;
            Raskhod_nakl = raskhod_nakl;
        }

        public Werehouse_registration_card()
        {
            Id_karta_ucheta = 0;
            Priem_nakl = new Reception();
            Type_inventar = "";
            Inventar = "";
            Kolich_yedinitsa = 0;
            Raskhod_nakl = new Expendable();
        }
    }
}
