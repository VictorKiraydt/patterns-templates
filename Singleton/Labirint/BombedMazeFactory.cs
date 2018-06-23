using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class BombedMazeFactory: MazeFactory
    {
        public override Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }
    }
   class BombedWall : Wall
    {
    }

    class RoomWithBomb : Room
    {
        public RoomWithBomb(int number) : base(number)
        {

        }
    }
}
