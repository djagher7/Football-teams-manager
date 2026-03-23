using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_teams_manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume1.Text) ||
                string.IsNullOrWhiteSpace(txtPozitie1.Text) ||
                string.IsNullOrWhiteSpace(txtIDNP1.Text))
            {
                MessageBox.Show("Completează toate câmpurile!");
            }
        }
    }
}
