using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Re_Write_Rules
{
    class Generator
    {
        static public ProgressBar ProgressBar { get; set; }
        protected string axiom;
        protected char[] grammarVariables;
        protected string[] ruleResults;

        private Stack<TurtleState> stateStack;

        public Generator()
        {
            stateStack = new Stack<TurtleState>();
        }

        public void ResetToAxiom()
        {
            FileHandler.SaveNewLine(axiom, append: false);
        }

        virtual public void MoveTurtle(string instructions, float distanceUnit) { ExpressiveRangeLogger.LogExpressiveRange(); }

        virtual public void SetUpTurtle()
        {
            Turtle.Reset();
            Turtle.PenVisible = false;
            Turtle.PenColor = Color.Black;
        }

        public void GenerateInstructions(int n)
        {
            ProgressBar.Maximum = n - 1;
            ResetToAxiom();
            List<string> stringList = new List<string> { axiom };
            for (int i = 0; i < n; i++)
            {
                stringList.Add(GenerateNewLine(stringList[i], recursion: true));
                ProgressBar.Value = i;
            }
            FileHandler.Save(stringList);
            ProgressBar.Value = 0;
        }

        public string GenerateNewLine(string prevLine, bool recursion = false)
        {
            StringBuilder newLine = new StringBuilder();
            if (!recursion) ProgressBar.Maximum = prevLine.Length - 1;
            for (int i = 0; i < prevLine.Length; i++)
            {
                string newString = prevLine[i].ToString();
                for (int j = 0; j < grammarVariables.Length; j++)
                {
                    if (newString == grammarVariables[j].ToString())
                    {
                        newString = ruleResults[j];
                    }
                }
                newLine.Append(newString);
                if (!recursion) ProgressBar.Value = i;
            }
            if (!recursion)
            {
                FileHandler.SaveNewLine(newLine.ToString(), append: true);
                ProgressBar.Value = 0;
            }
            return newLine.ToString();
        }

        protected void PushTurtle()
        {
            Point currentPos = new Point((int)Turtle.X, (int)Turtle.Y);
            stateStack.Push(new TurtleState(currentPos, Turtle.Angle));
        }

        protected void PopTurtle()
        {
            TurtleState newState = stateStack.Pop();
            Turtle.PenVisible = false;
            Turtle.MoveTo(newState.Position.X, newState.Position.Y);
            Turtle.PenVisible = true;
            Turtle.Angle = newState.Angle;
        }
    }
}