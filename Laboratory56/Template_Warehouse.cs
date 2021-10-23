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
        public Template_Warehouse()
        {
            InitializeComponent();
            TableSklad.DataSource = Controller.gotAllSklad();
            TableSklad.CellClick += TableAccaunt_CellClick;
        }
        private void TableAccaunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            inNomer_sklada.Text = TableSklad.Rows[row].Cells[0].Value.ToString();
            inName_sklada.Text = TableSklad.Rows[row].Cells[1].Value.ToString();
            inNum_phone_sklad.Text = TableSklad.Rows[row].Cells[2].Value.ToString();
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
    }
}
