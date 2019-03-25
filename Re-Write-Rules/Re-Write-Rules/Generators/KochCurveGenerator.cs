using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Write_Rules
{
    class KochCurveGenerator : Generator
    {
        public KochCurveGenerator() : base()
        {
            axiom = "F";
            grammarVariables = new char[] { 'F' };
            ruleResults = new string[] { "F+F-F-F+F" };
            SetUpTurtle();
            ResetToAxiom();
        }

        public override void SetUpTurtle()
        {
            base.SetUpTurtle();
            Turtle.Rotate(90);
            Turtle.MoveTo(Turtle.X - 150, Turtle.Y - 250);
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
                        Turtle.Forward(distanceUnit);
                        break;
                    case '+':
                        Turtle.Rotate(-90);
                        break;
                    case '-':
                        Turtle.Rotate(90);
                        break;
                }
                ProgressBar.Value = i;
            }
        }
    }
}