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
        public Template_Reception()
        {
            InitializeComponent();
            TablePriem_nakl.DataSource = Controller.gotAllPriem_nakl();
            TablePriem_nakl.CellClick += TableAccaunt_CellClick;
        }
        private void TableAccaunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            inId_priem_nakl.Text = TablePriem_nakl.Rows[row].Cells[0].Value.ToString();
            inDate.Text = TablePriem_nakl.Rows[row].Cells[1].Value.ToString();
            inInventar.Text = TablePriem_nakl.Rows[row].Cells[2].Value.ToString();
            inKolich_yedinitsa.Text = TablePriem_nakl.Rows[row].Cells[3].Value.ToString();
            inSotrudnik.Text = TablePriem_nakl.Rows[row].Cells[4].Value.ToString();
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
    }
}
