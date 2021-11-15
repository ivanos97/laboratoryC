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
    public partial class Template_Movement : Form
    {
        public Template_Movement()
        {
            InitializeComponent();
            comboBox1.DataSource = Controller.GetAllId("select * from extendable");
            comboBox2.DataSource = Controller.GetAllId("select * from reception");
            TableMovement.DataSource = Controller.gotAllMovement();
            TableMovement.CellClick += TableAccaunt_CellClick;
        }
        private void TableAccaunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            comboBox1.Text = TableMovement.Rows[row].Cells[0].Value.ToString();
            comboBox2.Text = TableMovement.Rows[row].Cells[1].Value.ToString();
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            Controller.grossButtonNewMovement(comboBox1.Text, comboBox2.Text);
            TableMovement.DataSource = Controller.gotAllMovement();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Controller.grossButtonDeleteMovement(comboBox1.Text, comboBox2.Text);
            TableMovement.DataSource = Controller.gotAllMovement();
        }

    }
}
