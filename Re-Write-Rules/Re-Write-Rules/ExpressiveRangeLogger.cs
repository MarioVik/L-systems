using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Write_Rules
{
    static class ExpressiveRangeLogger
    {
        static public string FilePath { get { return @"Instructions.txt"; } }
        static private List<Point> positions;
        static int recursion = 0;

        static public void RecordPosition()
        {
            Point currentPos = new Point((int)Turtle.X, (int)Turtle.Y);
            positions.Add(currentPos);
        }

        static public void LogExpressiveRange()
        {
            float lowestX = float.MaxValue;
            float highestX = float.MinValue;
            float lowestY = float.MaxValue;
            float highestY = float.MinValue;

            foreach (Point tempPos in positions)
            {
                if (tempPos.X < lowestX) lowestX = tempPos.X;
                if (tempPos.X > highestX) highestX = tempPos.X;
                if (tempPos.Y < lowestY) lowestY = tempPos.Y;
                if (tempPos.Y > highestY) highestY = tempPos.Y;
            }

            float width = highestX - lowestX;
            float height = highestY - lowestY;

            StreamWriter streamWriter = new StreamWriter(FilePath, true);
            streamWriter.WriteLine(recursion + "\t" + width + "\t" + height);
            streamWriter.Close();
            positions.Clear();
            recursion++;
        }
    }
}