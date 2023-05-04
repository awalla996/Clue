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
    public partial class Stats : Form
    {
        List<ClueMethods> clueList = new List<ClueMethods>();
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet cluesDataSet, myDataSet;
        DataTable cluesTable;
        BindingSource myBindingSource;
        string strSQL;
        public Stats()
        {
            InitializeComponent();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Gameplay form = new Gameplay();
            form.Show();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ClueDatabase.accdb;");
            strSQL = "SELECT * FROM ClueNotebook";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            cluesDataSet = new DataSet("CluesTable");
            myDataAdapter.Fill(cluesDataSet, "CluesTable");

            foreach (DataRow record in cluesTable.Rows)
            {
                ClueMethods clueLeaderBoard = new ClueMethods();
                //clueLeaderBoard.UserId = record["UserId"].ToString();
                clueLeaderBoard.Username = record["Username"].ToString();
                //clueLeaderBoard.Score = record["Score"].ToString();
                
                clueList.Add(clueLeaderBoard);
            }
            dgvStats.DataSource = clueList;
        }
    }
}
