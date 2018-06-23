using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    enum Direction { North, South, East, West }
    public abstract class MapSite {
        public abstract void Enter();
    }
}
