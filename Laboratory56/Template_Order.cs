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
    public partial class Template_Order : Form
    {
        public Template_Order()
        {
            InitializeComponent();
            TableOrder.DataSource = Controller.gotAllOrder();
            TableOrder.CellClick += TableAccaunt_CellClick;
        }
        private void TableAccaunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            inId_zayavka.Text = TableOrder.Rows[row].Cells[0].Value.ToString();
            inType_Inventar.Text = TableOrder.Rows[row].Cells[1].Value.ToString();
            inSklad.Text = TableOrder.Rows[row].Cells[2].Value.ToString();
            inInventar.Text = TableOrder.Rows[row].Cells[3].Value.ToString();
            inKolich_yedinitsa.Text = TableOrder.Rows[row].Cells[4].Value.ToString();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewOrder(inInventar.Text, inType_Inventar.Text, inKolich_yedinitsa.Text, inSklad.Text);
            TableOrder.DataSource = Controller.gotAllOrder();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDeleteOrder(inId_zayavka.Text);
            TableOrder.DataSource = Controller.gotAllOrder();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Controller.grossButtonUpdateOrder(inId_zayavka.Text, inInventar.Text, inType_Inventar.Text, inKolich_yedinitsa.Text, inSklad.Text);
            TableOrder.DataSource = Controller.gotAllOrder();
        }
    }
}
