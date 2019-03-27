using Nakov.TurtleGraphics;

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
            ExpressiveRangeLogger.RecordPosition();
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
                ExpressiveRangeLogger.RecordPosition();
                ProgressBar.Value = i;
            }
            base.MoveTurtle(instructions, distanceUnit);
        }
    }
}
