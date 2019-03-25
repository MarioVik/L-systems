using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Write_Rules
{
    class FractalPlantGenerator : Generator
    {
        public FractalPlantGenerator() : base()
        {
            axiom = "X";
            grammarVariables = new char[] { 'X', 'F' };
            ruleResults = new string[] { "F+[[X]-X]-F[-FX]+X", "FF" };
            SetUpTurtle();
            ResetToAxiom();
        }

        public override void SetUpTurtle()
        {
            base.SetUpTurtle();
            Turtle.Rotate(25);
            Turtle.MoveTo(Turtle.X + 0, Turtle.Y - 350);
            Turtle.PenVisible = true;
        }

        public override void MoveTurtle(string instructions, float distanceUnit)
        {
            ExpressiveRangeLogger.RecordPosition();
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'F':
                        Turtle.Forward(distanceUnit);
                        break;
                    case '-':
                        Turtle.Rotate(-25);
                        break;
                    case '+':
                        Turtle.Rotate(25);
                        break;
                    case '[':
                        PushTurtle();
                        break;
                    case ']':
                        PopTurtle();
                        break;
                }
                ExpressiveRangeLogger.RecordPosition();
                ProgressBar.Value = i;
            }
            base.MoveTurtle(instructions, distanceUnit);
        }
    }
}