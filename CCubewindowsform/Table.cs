using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLogic
{
    public class Table
    {
        bool player1;
        bool player2;
        bool tablefree;
        Game game;

        public Table()
        {
        }
        public Table(bool player1 = false, bool player2 = false, bool tablefree = false)
        {
            this.Player1 = player1;
            this.Player2 = player2;
            this.Tablefree = tablefree;
        }

        public bool Player1 { get => player1; set => player1 = value; }
        public bool Player2 { get => player2; set => player2 = value; }
        public bool Tablefree { get => tablefree; set => tablefree = value; }
        internal Game Game { get => game; set => game = value; }

        public bool tablecheck()
        {
            if (tablefree == true)
                return true;
            else
                return false;
        }

        public bool player1check()
        {
            if (player1 == true)
                return true;
            else
                return false;
        }

        public bool player2check()
        {
            if (player2 == true)
                return true;
            else
                return false;
        }
    }//end class
}//end namespace
