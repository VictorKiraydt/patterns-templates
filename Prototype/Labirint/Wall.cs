using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Wall : MapSite
    {
        public Wall() { }
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
        public void Initilize(int number)
        {
           
        }
        public virtual Wall Clone()
        {
            Wall wall = new Wall();
            return wall;
        }

    }
    
}

