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
    public partial class Template_Accaunt : Form
    {
        public Template_Accaunt()
        {
            InitializeComponent();
            TableAccaunt.DataSource = Controller.gotAllAccaunt();
            TableAccaunt.CellClick += TableAccaunt_CellClick;
        }
        private void TableAccaunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            inNum_accaunt.Text = TableAccaunt.Rows[row].Cells[0].Value.ToString();
            inLogin.Text = TableAccaunt.Rows[row].Cells[1].Value.ToString();
            inPassword.Text = TableAccaunt.Rows[row].Cells[2].Value.ToString();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewAccaunt(inLogin.Text, inPassword.Text);
            TableAccaunt.DataSource = Controller.gotAllAccaunt();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDeleteAccaunt(inNum_accaunt.Text);
            TableAccaunt.DataSource = Controller.gotAllAccaunt();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Controller.grossButtonUpdateAccaunt(inNum_accaunt.Text, inLogin.Text, inPassword.Text);
            TableAccaunt.DataSource = Controller.gotAllAccaunt();
        }
    }
}
