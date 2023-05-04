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
    public partial class Form1 : Form
    {
        //public static Gameplay instance;
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet cluesDataSet, myDataSet;
        DataTable cluesTable;
        BindingSource myBindingSource;
        string strSQL;
        public Form1()
        {
            InitializeComponent();
            //instance = this;            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int num = rand.Next(100000000, 1000000000);
            txtUserID.Text = Convert.ToString(num);
            if (btnSubmit.Text == "Submit")
            {
                DataTable dtCluePlayers = myDataSet.Tables["ClueTable"];
                DataRow drNewUser = dtCluePlayers.NewRow();

                drNewUser["UserID"] = txtUserID.Text;
                drNewUser["Username"] = txtUsername.Text;

                dtCluePlayers.Rows.Add(drNewUser);

                btnSubmit.Text = "Sumbit";

                myBindingSource.ResumeBinding();
                myBindingSource.MoveLast();
            }

            Gameplay gameplayForm = new Gameplay();
            gameplayForm.Show();
            MessageBox.Show("Mr. Boddy is found death in one of the rooms of his mansion. The player must determine the answers to these three questions: Who killed him? Where? and with What Weapon?");
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ClueDatabase.accdb;");
            strSQL = "SELECT * FROM ClueNotebook";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            cluesDataSet = new DataSet("CluesTable");
            myDataAdapter.Fill(cluesDataSet, "CluesTable");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public static implicit operator Form1(Main v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Form1(Gameplay v)
        {
            throw new NotImplementedException();
        }
    }
}
