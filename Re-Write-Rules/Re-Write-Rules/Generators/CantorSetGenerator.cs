using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Write_Rules
{
    class CantorSetGenerator : Generator
    {
        public CantorSetGenerator() : base()
        {
            axiom = "A";
            grammarVariables = new char[] { 'A', 'B' };
            ruleResults = new string[] { "ABA", "BBB" };
            SetUpTurtle();
            ResetToAxiom();
        }

        public override void SetUpTurtle()
        {
            base.SetUpTurtle();
            Turtle.Rotate(90);
            Turtle.MoveTo(Turtle.X - 150, Turtle.Y - 150);
            Turtle.PenVisible = true;
        }

        public override void MoveTurtle(string instructions, float distanceUnit)
        {
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'A':
                        Turtle.Forward(distanceUnit);
                        break;
                    case 'B':
                        Turtle.PenVisible = false;
                        Turtle.Forward(distanceUnit);
                        Turtle.PenVisible = true;
                        break;
                }
                ProgressBar.Value = i;
            }
        }
    }
}
