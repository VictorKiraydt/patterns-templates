using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
	class MazeGame
	{
		MazeFactory factory = null;
		public Maze CreateMaze(MazeFactory factory)
		{
			this.factory = factory;
			Maze aMaze = this.factory.MakeMaze();
			Room r1 = this.factory.MakeRoom(1);
			r1.Enter();
			Room r2 = this.factory.MakeRoom(2);
			r2.Enter();
			Door aDoor = this.factory.MakeDoor(r1, r2);
			aDoor.Enter();
			aMaze.AddRoom(r1);
			aMaze.AddRoom(r2);
			r1.SetSide(Direction.North, this.factory.MakeWall());
			r1.SetSide(Direction.East, aDoor);
			r1.SetSide(Direction.South, this.factory.MakeWall());
			r1.SetSide(Direction.West, this.factory.MakeWall());
			r2.SetSide(Direction.North, this.factory.MakeWall());
			r2.SetSide(Direction.East, this.factory.MakeWall());
			r2.SetSide(Direction.South, this.factory.MakeWall());
			r2.SetSide(Direction.West, aDoor);
			return aMaze;
		}
	}
}
