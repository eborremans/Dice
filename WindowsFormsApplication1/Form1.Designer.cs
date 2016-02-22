namespace WindowsFormsApplication1
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
            this.mNrOfDice_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mSidesPerDie_TXT = new System.Windows.Forms.TextBox();
            this.mTotalDots_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mNrOfWays_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mOutput_TXT = new System.Windows.Forms.TextBox();
            this.mPermutations_TXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mTotalNrOfPossibilities_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mChance_TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mNrOfDice_TXT
            // 
            this.mNrOfDice_TXT.Location = new System.Drawing.Point(136, 12);
            this.mNrOfDice_TXT.Name = "mNrOfDice_TXT";
            this.mNrOfDice_TXT.Size = new System.Drawing.Size(46, 20);
            this.mNrOfDice_TXT.TabIndex = 1;
            this.mNrOfDice_TXT.Text = "2";
            this.mNrOfDice_TXT.TextChanged += new System.EventHandler(this.mNrOfDice_TXT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "nr. of dice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "sides per die";
            // 
            // mSidesPerDie_TXT
            // 
            this.mSidesPerDie_TXT.Location = new System.Drawing.Point(136, 38);
            this.mSidesPerDie_TXT.Name = "mSidesPerDie_TXT";
            this.mSidesPerDie_TXT.Size = new System.Drawing.Size(46, 20);
            this.mSidesPerDie_TXT.TabIndex = 3;
            this.mSidesPerDie_TXT.Text = "6";
            this.mSidesPerDie_TXT.TextChanged += new System.EventHandler(this.mSidesPerDie_TXT_TextChanged);
            // 
            // mTotalDots_TXT
            // 
            this.mTotalDots_TXT.Location = new System.Drawing.Point(136, 64);
            this.mTotalDots_TXT.Name = "mTotalDots_TXT";
            this.mTotalDots_TXT.Size = new System.Drawing.Size(46, 20);
            this.mTotalDots_TXT.TabIndex = 5;
            this.mTotalDots_TXT.Text = "2";
            this.mTotalDots_TXT.TextChanged += new System.EventHandler(this.mTotalDots_TXT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "nr. of ways to throw";
            // 
            // mNrOfWays_TXT
            // 
            this.mNrOfWays_TXT.Location = new System.Drawing.Point(207, 64);
            this.mNrOfWays_TXT.Name = "mNrOfWays_TXT";
            this.mNrOfWays_TXT.Size = new System.Drawing.Size(67, 20);
            this.mNrOfWays_TXT.TabIndex = 7;
            this.mNrOfWays_TXT.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "=";
            // 
            // mOutput_TXT
            // 
            this.mOutput_TXT.Location = new System.Drawing.Point(296, 96);
            this.mOutput_TXT.Multiline = true;
            this.mOutput_TXT.Name = "mOutput_TXT";
            this.mOutput_TXT.Size = new System.Drawing.Size(267, 349);
            this.mOutput_TXT.TabIndex = 10;
            this.mOutput_TXT.Visible = false;
            // 
            // mPermutations_TXT
            // 
            this.mPermutations_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPermutations_TXT.Location = new System.Drawing.Point(3, 173);
            this.mPermutations_TXT.Multiline = true;
            this.mPermutations_TXT.Name = "mPermutations_TXT";
            this.mPermutations_TXT.Size = new System.Drawing.Size(271, 272);
            this.mPermutations_TXT.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "permutations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "total nr. of possibilities";
            // 
            // mTotalNrOfPossibilities_TXT
            // 
            this.mTotalNrOfPossibilities_TXT.Location = new System.Drawing.Point(136, 90);
            this.mTotalNrOfPossibilities_TXT.Name = "mTotalNrOfPossibilities_TXT";
            this.mTotalNrOfPossibilities_TXT.Size = new System.Drawing.Size(138, 20);
            this.mTotalNrOfPossibilities_TXT.TabIndex = 17;
            this.mTotalNrOfPossibilities_TXT.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "chance to throw";
            // 
            // mChance_TXT
            // 
            this.mChance_TXT.Location = new System.Drawing.Point(136, 116);
            this.mChance_TXT.Name = "mChance_TXT";
            this.mChance_TXT.Size = new System.Drawing.Size(46, 20);
            this.mChance_TXT.TabIndex = 19;
            this.mChance_TXT.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 451);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mChance_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTotalNrOfPossibilities_TXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mPermutations_TXT);
            this.Controls.Add(this.mOutput_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mNrOfWays_TXT);
            this.Controls.Add(this.mTotalDots_TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mSidesPerDie_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mNrOfDice_TXT);
            this.Name = "Form1";
            this.Text = "Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mNrOfDice_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mSidesPerDie_TXT;
        private System.Windows.Forms.TextBox mTotalDots_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mNrOfWays_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mOutput_TXT;
        private System.Windows.Forms.TextBox mPermutations_TXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mTotalNrOfPossibilities_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mChance_TXT;
    }
}

