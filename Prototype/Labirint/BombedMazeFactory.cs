using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class BombedMazeFactory: MazeFactory
    {
        //public override Room MakeRoom(int number)
        //{
        //    return new RoomWithBomb(number);
        //}

        public override Wall MakeWall()
        {
            return new BombedWall();
        }
    }
    class BombedWall : Wall
    {
        bool bomb;
        // Конструкторы. 
        public BombedWall(){}
        public BombedWall(BombedWall other) { this.bomb = other.bomb; }
        // Переопределение базовой операции клонирования. 
        public override Wall Clone() { return new BombedWall(this); }
        public bool HasBomb() { return this.bomb; }
    }

    //class RoomWithBomb : Room
    //{
    //    //public RoomWithBomb(int number) : base(number)
    //    //{

    //    //}


    //    //bool bomb;
    //    //int number;
    //    //// Конструкторы. 
    //    //public RoomWithBomb() { }
    //    //public RoomWithBomb(RoomWithBomb other) { this.bomb = other.bomb; }
    //    //// Переопределение базовой операции клонирования. 
    //    //public override Wall Clone() { return newRoomWithBomb(this. number); }
    //    //public bool HasBomb() { return this.bomb; }

    //}
}
