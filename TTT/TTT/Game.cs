using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    class Game
    {
        int gamePlayer;
        int[,] Board = new int[,]
        {
            {0,0,0},
            {0,0,0},
            {0,0,0},
        };

        public int CheckPlayer()
        {
           if(gamePlayer == 1)
           {
               return 2;
           }
           else 
            return 1;
        }

        public void SwitchPlayer(int player) 
        {
            

            gamePlayer = player;
        }
        
        public int CheckGameState() //checks for wins
        {
            int gamestate = 0;

            return gamestate;
        }
    }
}
