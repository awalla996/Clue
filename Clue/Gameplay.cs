using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clue
{
    public partial class Gameplay : Form
    {
        //public static Form1 instance;
        List<ClueNotebook> clues = new List<ClueNotebook>();
        List<ClueNotebook> hands = new List<ClueNotebook>();
        ClueNotebook nb;

        string[] suspects = { "Mrs. Patricia Peacock", "Colonel Michael Mustard", "Reverend John Green", "Professor Peter Plum", "Miss Josephine Scarlet", "Mrs. Blanche White" };
        string[] rooms = {"Billard Room", "Lounge", "Kitchen", "Dining Room", "Study", "Hall", "Ballroom", "Library", "Conservatory" };
        string[] weapons = {"Revolver", "Dagger", "Lead Pipe", "Rope", "Candlestick", "Wrench" };

        string criminal;
        string w;
        string r;

        HashSet<int> sus;
        HashSet<int> weap;
        HashSet<int> ro;

        public Gameplay()
        {
            InitializeComponent();
            //instance = this;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ClueNotebook nb = new ClueNotebook();
            nb.Suspect = txtSuspect.Text;
            nb.Rooms = txtRoom.Text;
            nb.Weapons = txtWeapon.Text;

            clues.Add(nb);
            dgvNotebook.DataSource = clues;
                        
        }

        private void btnAccuse_Click(object sender, EventArgs e)
        {
            nb = new ClueNotebook();
            nb.Suspect = txtSuspect.Text;
            nb.Rooms = txtRoom.Text;
            nb.Weapons = txtWeapon.Text;

            clues.Add(nb);
            dgvNotebook.DataSource = clues;

            if (txtSuspect.Text == criminal)
            {
                MessageBox.Show("There is no way to disprove the suspect");
            }

            if (txtWeapon.Text == w)
            {
                MessageBox.Show("There is no way to disprove the weapon");
            }

            if (txtRoom.Text == r)
            {
                MessageBox.Show("There is no way to disprove the room");
            }
        }

        private void Gameplay_Load(object sender, EventArgs e)
        {
            Random rand = new Random();

            sus = new HashSet<int>();
            weap = new HashSet<int>();
            ro = new HashSet<int>();

            for (int i = 0; i < 3; i++)
            {
                // Start with a random number
                //
                int value = rand.Next(0, 6);

                // Check whether you already have that number
                // Keep trying until you get a unique
                //
                while (sus.Contains(value))
                {
                    value = rand.Next(0, 6);
                }
                sus.Add(value);
                while (weap.Contains(value))
                {
                    value = rand.Next(0, 6);
                }
                weap.Add(value);
                while (ro.Contains(value))
                {
                    value = rand.Next(0, 9);
                }
                ro.Add(value);

            }
            criminal = suspects[sus.First()];

            w = weapons[weap.First()];

            r = rooms[ro.First()];

            List<int> susInt = new List<int>(sus);
            List<int> weapInt = new List<int>(weap);
            List<int> roInt = new List<int>(ro);

            for (int i = 1; i < 3; i++)
            {
                int x = susInt[i];
                int z = weapInt[i];
                int y = roInt[i];

                string a = suspects[x];
                string b = rooms[z];
                string c = weapons[y];

                ClueNotebook obj = new ClueNotebook(a, c, b);
                hands.Add(obj);

            }

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            var number = randNum.Next(1, 7);

            MessageBox.Show("You rolled a " + number);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Stats form = new Stats();
            form.Show();
        }

        /*public static implicit operator Gameplay(Form1 v)
        {
            throw new NotImplementedException();
        }*/
    }
}
