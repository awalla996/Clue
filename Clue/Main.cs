using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace Clue
{
    public partial class Main : Form
    {
        //public static Form1 instance;
        public Main()
        {
            InitializeComponent();
            //instance = this;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the classic murder mystery game, Clue, Mr. Boddy is found dead inside of his mansion. The object of the game is to determine the killer, the murder weapon, and the room in which the crime occurred. The game is suited for players eight and up, and can support three to six players.");
            Form1 form = new Form1();
            form.Show();
        }

        public static implicit operator Main(Form1 v)
        {
            throw new NotImplementedException();
        }
    }
}
