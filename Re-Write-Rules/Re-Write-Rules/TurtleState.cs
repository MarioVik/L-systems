using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Write_Rules
{
    class TurtleState
    {
        public Point Position { get; private set; }
        public float Angle { get; private set; }

        public TurtleState(Point position, float angle)
        {
            Position = position;
            Angle = angle;
        }
    }
}
