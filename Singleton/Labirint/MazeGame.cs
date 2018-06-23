using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class MazeGame
    {
        private MazeFactory factory;
        public Maze CreateMaze(MazeFactory factoryParam)
        {
            factory = factoryParam;
            var aMaze = factory.MakeMaze();
            var r1 = factory.MakeRoom(1);
            r1.Enter();
            var r2 = factory.MakeRoom(2);
            r2.Enter();
            var theDoor = factory.MakeDoor(r1, r2);
            theDoor.Enter();
            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);
            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, factory.MakeWall());
            r1.SetSide(Direction.West, factory.MakeWall());

            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.West, theDoor);
            r1.SetSide(Direction.South, factory.MakeWall());
            r1.SetSide(Direction.East, factory.MakeWall());
            return aMaze;
        }
    }
}

