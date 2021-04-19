using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    class Game
    {
        int[,] Board = new int[,]
        {
            {0,0,0},
            {0,0,0},
            {0,0,0},
        };

        public int CheckPlayer()
        {
            int player = 0;

            return player;
        }

        public void SwitchPlayer() 
        {

        }
        
        public int CheckGameState() //checks for wins
        {
            int gamestate = 0;

            return gamestate;
        }
    }
}
