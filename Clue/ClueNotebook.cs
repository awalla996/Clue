using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue
{
    class ClueNotebook
    {
        public string suspect;
        public string weapon;
        public string room;

        public ClueNotebook()
        {
            suspect = "";
            weapon = "";
            room = "";
        }

        public ClueNotebook(string suspect, string weapon, string room)
        {
            this.suspect = suspect;
            this.weapon = weapon;
            this.room = room;
        }

        public string Suspect
        {
            get { return suspect; }
            set { suspect = value; }
        }

        public string Weapons
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public string Rooms
        {
            get { return room; }
            set { room = value; }
        }
    }
}
