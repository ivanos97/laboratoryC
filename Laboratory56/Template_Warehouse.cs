using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory56
{
    public partial class Template_Warehouse : Form
    {
        private string last_sklad = "0";
        public Template_Warehouse()
        {
            InitializeComponent();
            TableSklad.DataSource = Controller.gotAllSklad();
            TableSklad.CellClick += TableAccaunt_CellClick;
        }
        private void TableAccaunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                row = 0;
            }
            last_sklad = TableSklad.Rows[row].Cells[0].Value.ToString();
            inNomer_sklada.Text = TableSklad.Rows[row].Cells[0].Value.ToString();
            inName_sklada.Text = TableSklad.Rows[row].Cells[1].Value.ToString();
            inNum_phone_sklad.Text = TableSklad.Rows[row].Cells[2].Value.ToString();
            tableWarehouse_has_Reception.DataSource = Controller.gotAllWhRFromNomerSklad(last_sklad);
            tableWarehouse_has_Reception.CellClick += tableWarehouse_has_Reception_CellClick;
            tableWarehouse_has_Extendable.DataSource = Controller.gotAllWhEFromNomerSklad(last_sklad);
            tableWarehouse_has_Extendable.CellClick += tableWarehouse_has_Extendable_CellClick;
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewSklad(inName_sklada.Text, inNum_phone_sklad.Text);
            TableSklad.DataSource = Controller.gotAllSklad();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDeleteSklad(inNomer_sklada.Text);
            TableSklad.DataSource = Controller.gotAllSklad();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Controller.grossButtonUpdateSklad(inNomer_sklada.Text, inName_sklada.Text, inNum_phone_sklad.Text);
            TableSklad.DataSource = Controller.gotAllSklad();
        }

        private void bNewWhR_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewWhR(idNomer_sklad_sec.Text, idPriem_nakl_sec.Text);
            tableWarehouse_has_Reception.DataSource = Controller.gotAllWhRFromNomerSklad(last_sklad);
        }
        private void bDelWhR_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDelWhR(idNomer_sklad_sec.Text, idPriem_nakl_sec.Text);
            tableWarehouse_has_Reception.DataSource = Controller.gotAllWhRFromNomerSklad(last_sklad);
        }
        private void tableWarehouse_has_Reception_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                row = 0;
            }
            idNomer_sklad_sec.Text = tableWarehouse_has_Reception.Rows[row].Cells[0].Value.ToString();
            idPriem_nakl_sec.Text = tableWarehouse_has_Reception.Rows[row].Cells[1].Value.ToString();
        }

        private void bNewWhE_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewWhE(idNomer_sklad_thi.Text, idRashod_nakl.Text);
            tableWarehouse_has_Extendable.DataSource = Controller.gotAllWhEFromNomerSklad(last_sklad);
        }

        private void bDelWhE_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDelWhE(idNomer_sklad_thi.Text, idRashod_nakl.Text);
            tableWarehouse_has_Extendable.DataSource = Controller.gotAllWhEFromNomerSklad(last_sklad);
        }
        private void tableWarehouse_has_Extendable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                row = 0;
            }
            idNomer_sklad_thi.Text = tableWarehouse_has_Extendable.Rows[row].Cells[0].Value.ToString();
            idRashod_nakl.Text = tableWarehouse_has_Extendable.Rows[row].Cells[1].Value.ToString();
        }
    }
}
