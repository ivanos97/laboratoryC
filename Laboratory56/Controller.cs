using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Laboratory56
{
    public static class Controller
    {
        public static MySqlConnection ConnectToDb()
        {
            //Строка для подключения к базе
            string connString = "server = localhost; port = 3306; username = root; password = qwerty; database = sklad";
            //создание подключения
            MySqlConnection connection = new MySqlConnection(connString);
            return connection;
        }
        public static System.Data.DataTable ConnectionDataBase(string text = "")
        {
            MySqlConnection connection = ConnectToDb();
            //создание команды и запись в неё непосредственно команды и бд в которой требуется её выполнить
            MySqlCommand command = new MySqlCommand();
            command.CommandText = text;
            command.Connection = connection;

            //открть соединение
            connection.Open();
            //создается адаптер
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //создается набор данных
            DataSet dataSet = new DataSet();
            //в адаптер помещается команда
            adapter.SelectCommand = command;
            //адаптер заполняет результатом команды датасет
            adapter.Fill(dataSet);
            //закрыть соединение
            connection.Close();
            return dataSet.Tables[0];
        }

        public static void UpdateDatabase(string text)
        {
            MySqlConnection connection = ConnectToDb();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = text;
            command.Connection = connection;
            connection.Open();
            try 
            { 
                command.ExecuteNonQuery();
            }
            catch
            {
                Console.Error.Write("Error");
            }
    connection.Close();
        }

        public static List<string> GetAllId(string text = "")
        {
            MySqlConnection connection = ConnectToDb();
            //создание команды и запись в неё непосредственно команды и бд в которой требуется её выполнить
            MySqlCommand command = new MySqlCommand();
            command.CommandText = text;
            command.Connection = connection;

            //открть соединение
            connection.Open();
            //создается адаптер
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //создается набор данных
            DataSet dataSet = new DataSet();
            //в адаптер помещается команда
            adapter.SelectCommand = command;
            //адаптер заполняет результатом команды датасет
            adapter.Fill(dataSet);
            //закрыть соединение
            connection.Close();
            List<string> mas = new List<string>();
            for (int i = 0; i<dataSet.Tables[0].Rows.Count; i++)
            {
                mas.Add(dataSet.Tables[0].Rows[i][0].ToString());
            }
            return mas;
        }

        public static System.Data.DataTable gotAllWhEFromNomerSklad(string last_sklad)
        {
            return ConnectionDataBase($"SELECT * FROM `warehouse_has_extendable` where Warehouse_Nomer_sklad = '{last_sklad}'");
        }
        public static System.Data.DataTable gotAllWhEFromRashodNakl(string rashod)
        {
            return ConnectionDataBase($"SELECT * FROM `warehouse_has_extendable` where Extendable_id_raskhod_nakl = '{rashod}'");
        }
        public static void grossButtonNewWhE(string name_sklad, string rashod_nakl)
        {
            UpdateDatabase($"insert into warehouse_has_extendable (Warehouse_Nomer_sklad, Extendable_id_raskhod_nakl) value ('{name_sklad}', '{rashod_nakl}')");
        }
        public static void grossButtonDelWhE(string name_sklad, string rashod_nakl)
        {
            UpdateDatabase($"delete from warehouse_has_extendable where Warehouse_Nomer_sklad = '{name_sklad}' and Extendable_id_raskhod_nakl = '{rashod_nakl}'");
        }
        public static System.Data.DataTable gotAllWhRFromPriemNakl(string v)
        {
            return ConnectionDataBase($"SELECT * FROM `warehouse_has_reception` where Reception_id_priem_nakl = '{v}'"); 
        }
        public static System.Data.DataTable gotAllWhRFromNomerSklad(string v)
        {
            return ConnectionDataBase($"SELECT * FROM `warehouse_has_reception` where Warehouse_Nomer_sklad = '{v}'");
        }
        public static void grossButtonNewWhR(string name_sklad, string priem_nakl)
        {
            UpdateDatabase($"insert into warehouse_has_reception (Warehouse_Nomer_sklad, Reception_id_priem_nakl) value ('{name_sklad}', '{priem_nakl}')");
        }
        public static void grossButtonDelWhR(string name_sklad, string priem_nakl)
        {
            UpdateDatabase($"delete from warehouse_has_reception where Warehouse_Nomer_sklad = '{name_sklad}' and Reception_id_priem_nakl = '{priem_nakl}'");
        }
        public static System.Data.DataTable gotAllSklad()
        {
            return ConnectionDataBase("select * from warehouse");
        }
        public static System.Data.DataTable gotAllAccaunt()
        {
            return ConnectionDataBase("select * from account");
        }
        public static System.Data.DataTable gotAllPriem_nakl()
        {
            return ConnectionDataBase("select * from reception");
        }
        public static System.Data.DataTable gotAllRaskhod_nakl()
        {
            return ConnectionDataBase("select * from extendable");
        }
        public static System.Data.DataTable gotAllKarta_ucheta()
        {
            return ConnectionDataBase("SELECT * FROM warehouse_registration_card");
        }
        public static System.Data.DataTable gotAllOrder()
        {
            return ConnectionDataBase("SELECT * FROM `order`");
        }
        public static System.Data.DataTable gotAllMovement()
        {
            return ConnectionDataBase("select * from movement");
        }
        public static void grossButtonNewSklad(string name_sklad, string num_phone_sklad)
        {
            UpdateDatabase($"insert into warehouse (Name_sklad, Num_phone_sklad) value ('{name_sklad}', '{num_phone_sklad}')");
        }
        public static void grossButtonUpdateSklad(string nomer_sklad, string name_sklad, string num_phone_sklad)
        {
            UpdateDatabase($"update warehouse set Name_sklad = '{name_sklad}', Num_phone_sklad = '{num_phone_sklad}' where Nomer_sklad = {nomer_sklad}");
        }
        public static void grossButtonDeleteSklad(string nomer_sklad)
        {
            UpdateDatabase($"delete from warehouse where nomer_sklad = {nomer_sklad}");
        }
        public static void grossButtonNewAccaunt(string login, string password)
        {
            UpdateDatabase($"insert into account (login, password) value ('{login}', '{password}')");
        }
        public static void grossButtonUpdateAccaunt(string idAccount, string login, string password)
        {
            UpdateDatabase($"update account set login = '{login}', password = '{password}' where idAccount = {idAccount}");
        }
        public static void grossButtonDeleteAccaunt(string idAccount)
        {
            UpdateDatabase($"delete from account where idAccount = {idAccount}");
        }
        public static void grossButtonNewPriem_nakl(string date, string inventar, string kolich_yedinitsa, string sotrudnik)
        {
            UpdateDatabase($"insert into reception (date, inventar, kolich_yedinitsa, sotrudnik) value ('{date}', '{inventar}', {kolich_yedinitsa}, '{sotrudnik}')");
        }
        public static void grossButtonUpdatePriem_nakl(string id_priem_nakl, string date, string inventar, string kolich_yedinitsa, string sotrudnik)
        {
            UpdateDatabase($"update reception set date = '{date}', inventar = '{inventar}', kolich_yedinitsa = {kolich_yedinitsa}, sotrudnik = '{sotrudnik}' where id_priem_nakl = {id_priem_nakl}");
        }
        public static void grossButtonDeletePriem_nakl(string id_priem_nakl)
        {
            UpdateDatabase($"delete from reception where id_priem_nakl = {id_priem_nakl}");
        }
        public static void grossButtonNewRaskhod_nakl(string date, string inventar, string kolich_yedinitsa, string sotrudnik)
        {
            UpdateDatabase($"insert into extendable (date, inventar, kolich_yedinitsa, sotrudnik) value ('{date}', '{inventar}', {kolich_yedinitsa}, '{sotrudnik}')");
        }
        public static void grossButtonUpdateRaskhod_nakl(string id_raskhod_nakl, string date, string inventar, string kolich_yedinitsa, string sotrudnik)
        {
            UpdateDatabase($"update extendable set date = '{date}', inventar = '{inventar}', kolich_yedinitsa = {kolich_yedinitsa}, sotrudnik = '{sotrudnik}' where id_raskhod_nakl = {id_raskhod_nakl}");
        }
        public static void grossButtonDeleteRaskhod_nakl(string id_raskhod_nakl)
        {
            UpdateDatabase($"delete from extendable where id_raskhod_nakl = {id_raskhod_nakl}");
        }
        public static void grossButtonNewKarta_ucheta(string priem_nakl, string type_inventar, string inventar, string kolich_yedinitsa, string raskhod_nakl)
        {
            UpdateDatabase($"insert into warehouse_registration_card (Reception_id_priem_nakl, type_inventar, inventar, kolich_yedinitsa, Extendable_id_raskhod_nakl) value ({priem_nakl}, '{type_inventar}', '{inventar}', {kolich_yedinitsa}, {raskhod_nakl})");
        }
        public static void grossButtonUpdateKarta_ucheta(string id_karta_ucheta, string priem_nakl, string type_inventar, string inventar, string kolich_yedinitsa, string raskhod_nakl)
        {
            UpdateDatabase($"update warehouse_registration_card set Reception_id_priem_nakl = {priem_nakl}, type_inventar = '{type_inventar}', inventar = '{inventar}', kolich_yedinitsa = {kolich_yedinitsa}, Extendable_id_raskhod_nakl = {raskhod_nakl} where id_karta_ucheta = {id_karta_ucheta}");
        }
        public static void grossButtonDeleteKarta_ucheta(string id_karta_ucheta)
        {
            UpdateDatabase($"delete from warehouse_registration_card where id_karta_ucheta = {id_karta_ucheta}");
        }
        public static void grossButtonNewOrder(string inventar, string type_inventar, string kolich_yedinitsa, string sklad)
        {
            UpdateDatabase($"insert into order (inventar, typer_inventar, kolich_yedinitsa, Warehouse_Nomer_sklad) value ({inventar}, '{type_inventar}', {kolich_yedinitsa}, {sklad})");
        }
        public static void grossButtonUpdateOrder(string id_zayavka, string inventar, string type_inventar, string kolich_yedinitsa, string sklad)
        {
            UpdateDatabase($"update order set inventar = {inventar}, typer_inventar = '{type_inventar}', kolich_yedinitsa = '{kolich_yedinitsa}', Warehouse_Nomer_sklad = {sklad} where id_zayavka = {id_zayavka}");
        }
        public static void grossButtonDeleteOrder(string id_zayavka)
        {
            UpdateDatabase($"delete from order where id_zayavka = {id_zayavka}");
        }
        public static void grossButtonNewMovement(string priem_nakl, string raskhod_nakl)
        {
            UpdateDatabase($"insert into movement (Reception_id_priem_nakl, Extendable_id_raskhod_nakl) value ({priem_nakl}, {raskhod_nakl})");
        }
        public static void grossButtonDeleteMovement(string priem_nakl, string raskhod_nakl)
        {
            UpdateDatabase($"delete from movement where Reception_id_priem_nakl = {priem_nakl} and Extendable_id_raskhod_nakl = {raskhod_nakl}");
        }
    }
}
