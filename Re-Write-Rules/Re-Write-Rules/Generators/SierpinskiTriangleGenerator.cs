using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Write_Rules
{
    class SierpinskiTriangleGenerator : Generator
    {
        public SierpinskiTriangleGenerator() : base()
        {
            axiom = "F-G-G";
            grammarVariables = new char[] { 'F', 'G' };
            ruleResults = new string[] { "F-G+F+G-F", "GG" };
            SetUpTurtle();
            ResetToAxiom();
        }

        public override void SetUpTurtle()
        {
            base.SetUpTurtle();
            Turtle.Rotate(30);
            Turtle.MoveTo(Turtle.X - 100, Turtle.Y - 250);
            Turtle.PenVisible = true;
        }

        public override void MoveTurtle(string instructions, float distanceUnit)
        {
            base.MoveTurtle(instructions, distanceUnit);
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'F':
                    case 'G':
                        Turtle.Forward(distanceUnit);
                        break;
                    case '-':
                        Turtle.Rotate(120);
                        break;
                    case '+':
                        Turtle.Rotate(-120);
                        break;
                }
                ProgressBar.Value = i;
            }
        }
    }
}