namespace Re_Write_Rules
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnInit = new System.Windows.Forms.Button();
            this.LbxInstructions = new System.Windows.Forms.ListBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnResetAxiom = new System.Windows.Forms.Button();
            this.BtnResetTurtle = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.BtnReGenerate = new System.Windows.Forms.Button();
            this.TbxLines = new System.Windows.Forms.TextBox();
            this.lblLines = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.TbxDistance = new System.Windows.Forms.TextBox();
            this.lblThickness = new System.Windows.Forms.Label();
            this.TbxThickness = new System.Windows.Forms.TextBox();
            this.CbxGenerator = new System.Windows.Forms.ComboBox();
            this.checkDelay = new System.Windows.Forms.CheckBox();
            this.checkTurtleVisible = new System.Windows.Forms.CheckBox();
            this.checkReset = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnInit
            // 
            this.BtnInit.Location = new System.Drawing.Point(9, 12);
            this.BtnInit.Name = "BtnInit";
            this.BtnInit.Size = new System.Drawing.Size(184, 60);
            this.BtnInit.TabIndex = 0;
            this.BtnInit.Text = "Initialize";
            this.BtnInit.UseVisualStyleBackColor = true;
            this.BtnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // LbxInstructions
            // 
            this.LbxInstructions.FormattingEnabled = true;
            this.LbxInstructions.HorizontalScrollbar = true;
            this.LbxInstructions.ItemHeight = 16;
            this.LbxInstructions.Location = new System.Drawing.Point(9, 513);
            this.LbxInstructions.Name = "LbxInstructions";
            this.LbxInstructions.ScrollAlwaysVisible = true;
            this.LbxInstructions.Size = new System.Drawing.Size(427, 228);
            this.LbxInstructions.TabIndex = 3;
            this.LbxInstructions.SelectedIndexChanged += new System.EventHandler(this.LbxInstructions_SelectedIndexChanged);
            // 
            // BtnExecute
            // 
            this.BtnExecute.Enabled = false;
            this.BtnExecute.Location = new System.Drawing.Point(9, 342);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(307, 109);
            this.BtnExecute.TabIndex = 5;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Enabled = false;
            this.BtnGenerate.Location = new System.Drawing.Point(9, 210);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(184, 60);
            this.BtnGenerate.TabIndex = 6;
            this.BtnGenerate.Text = "Generate New Line";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnResetAxiom
            // 
            this.BtnResetAxiom.Enabled = false;
            this.BtnResetAxiom.Location = new System.Drawing.Point(9, 144);
            this.BtnResetAxiom.Name = "BtnResetAxiom";
            this.BtnResetAxiom.Size = new System.Drawing.Size(184, 60);
            this.BtnResetAxiom.TabIndex = 7;
            this.BtnResetAxiom.Text = "Reset to Axiom";
            this.BtnResetAxiom.UseVisualStyleBackColor = true;
            this.BtnResetAxiom.Click += new System.EventHandler(this.BtnResetAxiom_Click);
            // 
            // BtnResetTurtle
            // 
            this.BtnResetTurtle.Enabled = false;
            this.BtnResetTurtle.Location = new System.Drawing.Point(9, 78);
            this.BtnResetTurtle.Name = "BtnResetTurtle";
            this.BtnResetTurtle.Size = new System.Drawing.Size(184, 60);
            this.BtnResetTurtle.TabIndex = 8;
            this.BtnResetTurtle.Text = "Reset Turtle";
            this.BtnResetTurtle.UseVisualStyleBackColor = true;
            this.BtnResetTurtle.Click += new System.EventHandler(this.BtnResetTurtle_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 457);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(427, 50);
            this.progressBar.TabIndex = 9;
            // 
            // BtnReGenerate
            // 
            this.BtnReGenerate.Enabled = false;
            this.BtnReGenerate.Location = new System.Drawing.Point(9, 276);
            this.BtnReGenerate.Name = "BtnReGenerate";
            this.BtnReGenerate.Size = new System.Drawing.Size(184, 60);
            this.BtnReGenerate.TabIndex = 10;
            this.BtnReGenerate.Text = "Re-Generate Multiple Lines";
            this.BtnReGenerate.UseVisualStyleBackColor = true;
            this.BtnReGenerate.Click += new System.EventHandler(this.BtnReGenerate_Click);
            // 
            // TbxLines
            // 
            this.TbxLines.Enabled = false;
            this.TbxLines.Location = new System.Drawing.Point(200, 314);
            this.TbxLines.Name = "TbxLines";
            this.TbxLines.Size = new System.Drawing.Size(116, 22);
            this.TbxLines.TabIndex = 11;
            this.TbxLines.TextChanged += new System.EventHandler(this.TbxLines_TextChanged);
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(197, 294);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(116, 17);
            this.lblLines.TabIndex = 12;
            this.lblLines.Text = "Number of Lines:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(319, 409);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(96, 17);
            this.lblDistance.TabIndex = 14;
            this.lblDistance.Text = "Distance Unit:";
            // 
            // TbxDistance
            // 
            this.TbxDistance.Enabled = false;
            this.TbxDistance.Location = new System.Drawing.Point(322, 429);
            this.TbxDistance.Name = "TbxDistance";
            this.TbxDistance.Size = new System.Drawing.Size(114, 22);
            this.TbxDistance.TabIndex = 13;
            this.TbxDistance.TextChanged += new System.EventHandler(this.TbxDistance_TextChanged);
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(319, 364);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(117, 17);
            this.lblThickness.TabIndex = 16;
            this.lblThickness.Text = "Brush Thickness:";
            // 
            // TbxThickness
            // 
            this.TbxThickness.Enabled = false;
            this.TbxThickness.Location = new System.Drawing.Point(322, 384);
            this.TbxThickness.Name = "TbxThickness";
            this.TbxThickness.Size = new System.Drawing.Size(114, 22);
            this.TbxThickness.TabIndex = 15;
            this.TbxThickness.TextChanged += new System.EventHandler(this.TbxThickness_TextChanged);
            // 
            // CbxGenerator
            // 
            this.CbxGenerator.FormattingEnabled = true;
            this.CbxGenerator.Items.AddRange(new object[] {
            "Cantor set",
            "Koch curve",
            "Fractal (binary) tree",
            "Sierpinski triangle",
            "Fractal plant"});
            this.CbxGenerator.Location = new System.Drawing.Point(199, 12);
            this.CbxGenerator.Name = "CbxGenerator";
            this.CbxGenerator.Size = new System.Drawing.Size(121, 24);
            this.CbxGenerator.TabIndex = 17;
            this.CbxGenerator.SelectedIndexChanged += new System.EventHandler(this.CbxGenerator_SelectedIndexChanged);
            // 
            // checkDelay
            // 
            this.checkDelay.AutoSize = true;
            this.checkDelay.Enabled = false;
            this.checkDelay.Location = new System.Drawing.Point(322, 342);
            this.checkDelay.Name = "checkDelay";
            this.checkDelay.Size = new System.Drawing.Size(118, 21);
            this.checkDelay.TabIndex = 18;
            this.checkDelay.Text = "Show process";
            this.checkDelay.UseVisualStyleBackColor = true;
            // 
            // checkTurtleVisible
            // 
            this.checkTurtleVisible.AutoSize = true;
            this.checkTurtleVisible.Enabled = false;
            this.checkTurtleVisible.Location = new System.Drawing.Point(446, 342);
            this.checkTurtleVisible.Name = "checkTurtleVisible";
            this.checkTurtleVisible.Size = new System.Drawing.Size(105, 21);
            this.checkTurtleVisible.TabIndex = 19;
            this.checkTurtleVisible.Text = "Show Turtle";
            this.checkTurtleVisible.UseVisualStyleBackColor = true;
            // 
            // checkReset
            // 
            this.checkReset.AutoSize = true;
            this.checkReset.Enabled = false;
            this.checkReset.Location = new System.Drawing.Point(202, 78);
            this.checkReset.Name = "checkReset";
            this.checkReset.Size = new System.Drawing.Size(153, 21);
            this.checkReset.TabIndex = 20;
            this.checkReset.Text = "Reset automatically";
            this.checkReset.UseVisualStyleBackColor = true;
            this.checkReset.CheckedChanged += new System.EventHandler(this.checkReset_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.checkReset);
            this.Controls.Add(this.checkTurtleVisible);
            this.Controls.Add(this.checkDelay);
            this.Controls.Add(this.CbxGenerator);
            this.Controls.Add(this.lblThickness);
            this.Controls.Add(this.TbxThickness);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.TbxDistance);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.TbxLines);
            this.Controls.Add(this.BtnReGenerate);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BtnResetTurtle);
            this.Controls.Add(this.BtnResetAxiom);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.LbxInstructions);
            this.Controls.Add(this.BtnInit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInit;
        private System.Windows.Forms.ListBox LbxInstructions;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnResetAxiom;
        private System.Windows.Forms.Button BtnResetTurtle;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button BtnReGenerate;
        private System.Windows.Forms.TextBox TbxLines;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox TbxDistance;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.TextBox TbxThickness;
        private System.Windows.Forms.ComboBox CbxGenerator;
        private System.Windows.Forms.CheckBox checkDelay;
        private System.Windows.Forms.CheckBox checkTurtleVisible;
        private System.Windows.Forms.CheckBox checkReset;
    }
}

