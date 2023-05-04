using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue
{
    class ClueMethods
    {
        public int userID;
        public string username;
        public int score;

        //Default Constructor
        public ClueMethods()
        {
            userID = 0;
            username = "";
            score = 0;
        }

        //Parameterized Constructor
        public ClueMethods(int ID)
        {
            this.userID = ID;
            username = "";
            score = 0;
        }

        public ClueMethods(string name)
        {
            userID = 0;
            this.username = name;
            score = 0;
        }

        public int UserId
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
