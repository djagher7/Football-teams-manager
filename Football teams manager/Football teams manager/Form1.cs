using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_teams_manager
{
    public partial class Form1 : Form
    {
        private const String Path = "Players.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }



    class Player
    {
        string team;
        string name;
        string position;
        int idnp;
        string birthAge;

        public Player(string team, string name, string position, int idnp, string birthAge)
        {
            this.team = team;
            this.name = name;
            this.position = position;
            this.idnp = idnp;
            this.birthAge = birthAge;
        }
    }
}
