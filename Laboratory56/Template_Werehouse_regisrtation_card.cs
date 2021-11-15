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
    public partial class Template_Werehouse_regisrtation_card : Form
    {
        public Template_Werehouse_regisrtation_card()
        {
            InitializeComponent();
            inRaskhod_nakl.DataSource = Controller.GetAllId("select * from extendable");
            TableKarta_ucheta.DataSource = Controller.gotAllKarta_ucheta();
            TableKarta_ucheta.CellClick += TableAccaunt_CellClick;
        }
        private void TableAccaunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            inId_karta_ucheta.Text = TableKarta_ucheta.Rows[row].Cells[0].Value.ToString();
            inPriem_nakl.Text = TableKarta_ucheta.Rows[row].Cells[1].Value.ToString();
            inType_inventar.Text = TableKarta_ucheta.Rows[row].Cells[2].Value.ToString();
            inInventar.Text = TableKarta_ucheta.Rows[row].Cells[3].Value.ToString();
            inKolich_yedinitsa.Text = TableKarta_ucheta.Rows[row].Cells[4].Value.ToString();
            inRaskhod_nakl.Text = TableKarta_ucheta.Rows[row].Cells[5].Value.ToString();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewKarta_ucheta(inPriem_nakl.Text, inType_inventar.Text, inInventar.Text, inKolich_yedinitsa.Text, inRaskhod_nakl.Text);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDeleteKarta_ucheta(inId_karta_ucheta.Text);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Controller.grossButtonUpdateKarta_ucheta(inId_karta_ucheta.Text, inPriem_nakl.Text, inType_inventar.Text, inInventar.Text, inKolich_yedinitsa.Text, inRaskhod_nakl.Text);
        }
    }
}
