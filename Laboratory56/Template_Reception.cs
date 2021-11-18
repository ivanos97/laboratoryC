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
    public partial class Template_Reception : Form
    {
        private string last_nakl = "0";
        public Template_Reception()
        {
            InitializeComponent();
            TablePriem_nakl.DataSource = Controller.gotAllPriem_nakl();
            TablePriem_nakl.CellClick += TableAccaunt_CellClick;
        }
        private void TableAccaunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                row = 0;
            }
            last_nakl = TablePriem_nakl.Rows[row].Cells[0].Value.ToString();
            tableWarehouse_has_Reception.DataSource = Controller.gotAllWhRFromPriemNakl(last_nakl);
            inId_priem_nakl.Text = TablePriem_nakl.Rows[row].Cells[0].Value.ToString();
            inDate.Text = TablePriem_nakl.Rows[row].Cells[1].Value.ToString();
            inSklad.Items.Clear();
            for (int i = 0; i < tableWarehouse_has_Reception.Rows.Count-1; i++)
            {
                inSklad.Items.Add(tableWarehouse_has_Reception.Rows[i].Cells[0].Value.ToString());
            }
            inSklad.SelectedIndex = 0;
            inInventar.Text = TablePriem_nakl.Rows[row].Cells[2].Value.ToString();
            inKolich_yedinitsa.Text = TablePriem_nakl.Rows[row].Cells[3].Value.ToString();
            inSotrudnik.Text = TablePriem_nakl.Rows[row].Cells[4].Value.ToString();
            tableWarehouse_has_Reception.CellClick += tableWarehouse_has_Reception_CellClick;
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
        private void bNew_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewPriem_nakl(inDate.Text, inInventar.Text, inKolich_yedinitsa.Text, inSotrudnik.Text);
            TablePriem_nakl.DataSource = Controller.gotAllPriem_nakl();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDeletePriem_nakl(inId_priem_nakl.Text);
            TablePriem_nakl.DataSource = Controller.gotAllPriem_nakl();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Controller.grossButtonUpdatePriem_nakl(inId_priem_nakl.Text, inDate.Text, inInventar.Text, inKolich_yedinitsa.Text, inSotrudnik.Text);
            TablePriem_nakl.DataSource = Controller.gotAllPriem_nakl();
        }

        private void bNewWhR_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewWhR(idNomer_sklad_sec.Text, idPriem_nakl_sec.Text);
            tableWarehouse_has_Reception.DataSource = Controller.gotAllWhRFromPriemNakl(last_nakl);
        }

        private void bDelWhR_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDelWhR(idNomer_sklad_sec.Text, idPriem_nakl_sec.Text);
            tableWarehouse_has_Reception.DataSource = Controller.gotAllWhRFromPriemNakl(last_nakl);
        }
    }
}
