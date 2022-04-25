using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUBD
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Hotel_Click(object sender, EventArgs e)
        {
            FormHotel form = new FormHotel();
            form.ShowDialog();
        }

        private void button_Employee_Click(object sender, EventArgs e)
        {
            FormEmployee form = new FormEmployee();
            form.ShowDialog();
        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            FormClient form = new FormClient();
            form.ShowDialog();
        }
    }
}
