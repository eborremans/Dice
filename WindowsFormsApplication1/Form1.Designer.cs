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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 92);
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
    }
}

