﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Maze
    {
        private Dictionary<int, Room> rooms = null;

        public Maze()
        {
            rooms = new Dictionary<int, Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room.RoomNumber, room);
        }

        public Room RoomNo(int number)
        {
            return rooms[number];
        }
    }
}
