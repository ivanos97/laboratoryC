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
    public partial class Template_Expendable : Form
    {
        public Template_Expendable()
        {
            InitializeComponent();
            TableRaskhod_nakl.DataSource = Controller.gotAllRaskhod_nakl();
            TableRaskhod_nakl.CellClick += TableAccaunt_CellClick;
        }
        private void TableAccaunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            inId_raskhod_nakl.Text = TableRaskhod_nakl.Rows[row].Cells[0].Value.ToString();
            inDate.Text = TableRaskhod_nakl.Rows[row].Cells[1].Value.ToString();
            
            inInventar.Text = TableRaskhod_nakl.Rows[row].Cells[2].Value.ToString();
            inKolich_yedinitsa.Text = TableRaskhod_nakl.Rows[row].Cells[3].Value.ToString();
            inSotrudnik.Text = TableRaskhod_nakl.Rows[row].Cells[4].Value.ToString();

        }

        private void bNew_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewRaskhod_nakl(inDate.Text, inInventar.Text, inKolich_yedinitsa.Text, inSotrudnik.Text);
            TableRaskhod_nakl.DataSource = Controller.gotAllRaskhod_nakl();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDeleteRaskhod_nakl(inId_raskhod_nakl.Text);
            TableRaskhod_nakl.DataSource = Controller.gotAllRaskhod_nakl();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Controller.grossButtonUpdateRaskhod_nakl(inId_raskhod_nakl.Text, inDate.Text, inInventar.Text, inKolich_yedinitsa.Text, inSotrudnik.Text);
            TableRaskhod_nakl.DataSource = Controller.gotAllRaskhod_nakl();
        }
    }
}
