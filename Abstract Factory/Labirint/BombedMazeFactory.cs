using Labirint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class BombedMazeFactory : MazeFactory
    {
        // Метод создает взорванные стены. 
        public override Wall MakeWall() { return new BoombedWall(); }
        // Метод создает комнату с бомбой.
        public override Room MakeRoom(int number) { return new RoomWithBomb(number); }
    }
}
