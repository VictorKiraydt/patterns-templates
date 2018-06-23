﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class MazeFactory
    {
        private static MazeFactory factory;

        public MazeFactory Instanse()
        {
            return factory ?? (factory = new MazeFactory());
        }

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int number)
        {
            return new Room(number);
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}

