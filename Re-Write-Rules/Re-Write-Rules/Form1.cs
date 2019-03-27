using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Re_Write_Rules
{
    public partial class MainForm : Form
    {
        Generator generator;
        float distanceUnit, brushThickness;

        public MainForm()
        {
            InitializeComponent();
        }

        private void EnableButtons(bool enabled)
        {
            BtnInit.Enabled = enabled;
            if (!enabled || !checkReset.Checked) BtnResetTurtle.Enabled = enabled;
            checkReset.Enabled = enabled;
            BtnResetAxiom.Enabled = enabled;
            btnColor.Enabled = enabled;
            BtnGenerate.Enabled = enabled;
            RegenerateAvailability();
            TbxLines.Enabled = enabled;
            checkDelay.Enabled = enabled;
            checkTurtleVisible.Enabled = enabled;
            if (enabled) ExecuteAvailability();
            else BtnExecute.Enabled = false;
            TbxThickness.Enabled = enabled;
            TbxDistance.Enabled = enabled;
        }

        private void UpdateListBox()
        {
            LbxInstructions.Items.Clear();
            List<string> instructions = FileHandler.Load();
            foreach (string tempString in instructions)
                LbxInstructions.Items.Add(tempString);
        }

        private void RegenerateAvailability()
        {
            if (int.TryParse(TbxLines.Text, out int lines))
            {
                if (lines > 0)
                {
                    BtnReGenerate.Enabled = true;
                }
            }
            else
            {
                BtnReGenerate.Enabled = false;
            }
        }

        private void ExecuteAvailability()
        {
            if (float.TryParse(TbxThickness.Text, out brushThickness)
                && float.TryParse(TbxDistance.Text, out distanceUnit)
                && LbxInstructions.SelectedItem != null)
            {
                if (brushThickness > 0 && distanceUnit > 0)
                {
                    BtnExecute.Enabled = true;
                }
            }
            else
            {
                BtnExecute.Enabled = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CbxGenerator.SelectedIndex = 0;
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            ExpressiveRangeLogger.Initialize();
            switch (CbxGenerator.SelectedItem.ToString())
            {
                case "Cantor set":
                    generator = new CantorSetGenerator();
                    break;
                case "Koch curve":
                    generator = new KochCurveGenerator();
                    break;
                case "Fractal (binary) tree":
                    generator = new FractalTreeGenerator();
                    break;
                case "Sierpinski triangle":
                    generator = new SierpinskiTriangleGenerator();
                    break;
                case "Fractal plant":
                    generator = new FractalPlantGenerator();
                    break;
                default:
                    throw new Exception("Unknown selection");
            }
            Turtle.ShowTurtle = checkTurtleVisible.Checked;
            Generator.ProgressBar = progressBar;
            UpdateListBox();
            BtnInit.Text = "Re-Initialize";
            EnableButtons(true);
            TbxThickness.Text = "2";
            TbxDistance.Text = "20";
        }

        private void BtnResetTurtle_Click(object sender, EventArgs e)
        {
            ResetTurtle();
        }

        private void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            generator.SetUpTurtle();
            Turtle.ShowTurtle = checkTurtleVisible.Checked;
            Turtle.PenColor = colorDialog.Color;
        }

        private void BtnResetAxiom_Click(object sender, EventArgs e)
        {
            generator.ResetToAxiom();
            UpdateListBox();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Turtle.PenColor = colorDialog.Color;
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            generator.GenerateNewLine(LbxInstructions.Items[LbxInstructions.Items.Count - 1].ToString());
            UpdateListBox();
            EnableButtons(true);
        }

        private void BtnReGenerate_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            generator.GenerateInstructions(int.Parse(TbxLines.Text));
            UpdateListBox();
            EnableButtons(true);
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            EnableButtons(false);

            if (checkReset.Checked) ResetTurtle();

            string instructions = LbxInstructions.SelectedItem.ToString();
            progressBar.Maximum = instructions.Length - 1;
            Turtle.PenSize = brushThickness;
            Turtle.ShowTurtle = checkTurtleVisible.Checked;

            if (checkDelay.Checked)
                Turtle.Delay = 1000 / instructions.Length;
            else
                Turtle.Delay = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            generator.MoveTurtle(instructions, distanceUnit);
            stopwatch.Stop();
            ExpressiveRangeLogger.LogExpressiveRange(instructions.Length, stopwatch.ElapsedMilliseconds);

            EnableButtons(true);
            progressBar.Value = 0;
        }

        private void LbxInstructions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteAvailability();
        }

        private void TbxThickness_TextChanged(object sender, EventArgs e)
        {
            ExecuteAvailability();
        }

        private void TbxDistance_TextChanged(object sender, EventArgs e)
        {
            ExecuteAvailability();
        }

        private void CbxGenerator_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons(false);
            if (CbxGenerator.SelectedItem != null)
                BtnInit.Enabled = true;
        }

        private void checkReset_CheckedChanged(object sender, EventArgs e)
        {
            BtnResetTurtle.Enabled = !checkReset.Checked;
        }

        private void TbxLines_TextChanged(object sender, EventArgs e)
        {
            RegenerateAvailability();
        }
    }
}