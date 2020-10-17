using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class EnemyAi : Player
    {
        public EnemyAi()
        {
            active = false;
            playerGrid = new Grid();
        }

    }
}
