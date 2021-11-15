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
    public partial class Template_Controller : Form
    {
        public Template_Controller()
        {
            InitializeComponent();
        }

        private void bAcc_Click(object sender, EventArgs e)
        {
            Template_Accaunt tAcc = new Template_Accaunt();
            tAcc.Show();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Template_Backup tBack = new Template_Backup();
            tBack.Show();
        }

        private void bRaskhod_Click(object sender, EventArgs e)
        {
            Template_Expendable tExp = new Template_Expendable();
            tExp.Show();
        }

        private void bMove_Click(object sender, EventArgs e)
        {
            Template_Movement tMove = new Template_Movement();
            tMove.Show();
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            Template_Order tOrder = new Template_Order();
            tOrder.Show();

        }

        private void bPriem_Click(object sender, EventArgs e)
        {
            Template_Reception tRec = new Template_Reception();
            tRec.Show();
        }

        private void bSklad_Click(object sender, EventArgs e)
        {
            Template_Warehouse tWar = new Template_Warehouse();
            tWar.Show();
        }

        private void bCard_Click(object sender, EventArgs e)
        {
            Template_Werehouse_regisrtation_card tCard = new Template_Werehouse_regisrtation_card();
            tCard.Show();
        }
    }
}
