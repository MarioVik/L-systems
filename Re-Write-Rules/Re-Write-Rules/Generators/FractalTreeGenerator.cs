using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Write_Rules
{
    class FractalTreeGenerator : Generator
    {
        public FractalTreeGenerator() : base()
        {
            axiom = "0";
            grammarVariables = new char[] { '0', '1' };
            ruleResults = new string[] { "1[0]0", "11" };
            SetUpTurtle();
            ResetToAxiom();
        }

        public override void SetUpTurtle()
        {
            base.SetUpTurtle();
            Turtle.MoveTo(Turtle.X + 150, Turtle.Y - 350);
            Turtle.PenVisible = true;
        }

        public override void MoveTurtle(string instructions, float distanceUnit)
        {
            base.MoveTurtle(instructions, distanceUnit);
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case '0':
                        Turtle.Forward(distanceUnit / 2);
                        break;
                    case '1':
                        Turtle.Forward(distanceUnit);
                        break;
                    case '[':
                        PushTurtle();
                        Turtle.Rotate(-45);
                        break;
                    case ']':
                        PopTurtle();
                        Turtle.Rotate(45);
                        break;
                }
                ProgressBar.Value = i;
            }
        }
    }
}