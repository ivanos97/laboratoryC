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
    public partial class Template_Authorization : Form
    {
        public Template_Authorization()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            Template_Controller tContr = new Template_Controller();
            tContr.Show();
            this.Hide();
            tContr.FormClosed += Showing;

        }
        public void Showing(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
