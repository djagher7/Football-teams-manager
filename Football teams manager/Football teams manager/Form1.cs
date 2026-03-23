using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms; 
namespace Football_teams_manager
{
    public partial class Form1 : Form
    {
        List<Player> jucator = new List<Player>();
        private const String Path = "Players.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readFromFile(Path);
            var echipe = jucator
        .Select(j => j.team)
        .Distinct()
        .ToList();

            comboBox1.DataSource = echipe;

            comboBox1.SelectedIndex = 1;
        }

        public void readFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string linie in lines)
            {
                if (string.IsNullOrWhiteSpace(linie))
                    continue;

                string[] parts = linie.Split(';');

                Player p = new Player
                {
                    team = parts[0],
                    name = parts[1],
                    position = parts[2],
                    idnp = parts[3],
                    birthDate = DateTime.Parse(parts[4]),
                };

                jucator.Add(p);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string echipaSelectata = comboBox1.SelectedItem.ToString();

            flowLayoutPanel1.Controls.Clear();

            var lista = jucator.Where(j => j.team == echipaSelectata);

            foreach (var p in lista)
            {
                Button btn = new Button();
                btn.Width = 240;
                btn.Height = 30;

                btn.Text = p.name;
                btn.Tag = p;

                btn.Click += PlayerButton_Click;

                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void PlayerButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Player p = (Player)btn.Tag;

            txtNume.Text = p.name;
            txtPozitie.Text = p.position;
            txtIDNP.Text = p.idnp;
            dateTimePicker1.Value = p.birthDate;

            int varsta = DateTime.Now.Year - p.birthDate.Year;
            txtVarsta.Text = varsta.ToString();
        }
        class Player
        {
            public string team { get; set; }
            public string name { get; set; }
            public string position { get; set; }
            public string idnp { get; set; }
            public DateTime birthDate { get; set; }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
