using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    public abstract class MazeBuilder
    {
        public abstract void BuildMaze();
        public abstract void BuildRoom(int roomNo);
        public abstract void BuildDoor(int roomFrom, int roomTo);
        public abstract Maze GetMaze();
    }

    public class StandartMazeBuilder : MazeBuilder
    {
        Maze currentMaze = null;
        // Конструктор. 
        public StandartMazeBuilder() { this.currentMaze = null; }
        public override void BuildMaze() { this.currentMaze = new Maze(); }
        public override void BuildRoom(int roomNo)
        { //if (currentMaze.RoomNo(roomNo) == null) 
            {
                Room room = new Room(roomNo);
                room.Enter();
                currentMaze.AddRoom(room);
                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }
        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Room room1 = currentMaze.RoomNo(roomFrom);
            Room room2 = currentMaze.RoomNo(roomTo);
            Door door = new Door(room1, room2);
            door.Enter();
            room1.SetSide(CommonWall(room1, room2), door);
            room2.SetSide(CommonWall(room2, room1), door);
        }
        public override Maze GetMaze() { return this.currentMaze; }
        private Direction CommonWall(Room room1, Room room2) {
            if (room1.GetSide(Direction.North) is Wall && 
                room1.GetSide(Direction.South) is Wall && 
                room1.GetSide(Direction.East) is Wall && 
                room1.GetSide(Direction.West) is Wall && 
                room2.GetSide(Direction.North) is Wall && 
                room2.GetSide(Direction.South) is Wall && 
                room2.GetSide(Direction.East) is Wall &&
                room2.GetSide(Direction.West) is Wall)
            { return Direction.East; }
            else { return Direction.West; } }
    }
}

