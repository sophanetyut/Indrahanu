using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indradhanu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelRegistration.BringToFront();
        }

        

        private void btnRegistation_Click(object sender, EventArgs e)
        {
            panelRegistration.BringToFront();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            panelSchedule.BringToFront();
        }

        private void btnCaseRecord_Click(object sender, EventArgs e)
        {
            panelCaseRecord.BringToFront();
        }

        private void btnReciept_Click(object sender, EventArgs e)
        {
            panelReciept.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            panelView.BringToFront();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            panelSetting.BringToFront();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
