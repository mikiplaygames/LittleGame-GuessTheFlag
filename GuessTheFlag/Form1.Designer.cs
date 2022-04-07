namespace GuessTheFlag
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.skipButton = new System.Windows.Forms.Button();
            this.pktLabel = new System.Windows.Forms.Label();
            this.happyText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(106, 502);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(76, 63);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Zatwierdź";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(327, 38);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(207, 28);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "Jakiego kraju to flaga?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(106, 444);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(642, 23);
            this.answerBox.TabIndex = 3;
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(672, 502);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(76, 63);
            this.skipButton.TabIndex = 4;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // pktLabel
            // 
            this.pktLabel.AutoSize = true;
            this.pktLabel.Location = new System.Drawing.Point(377, 526);
            this.pktLabel.Name = "pktLabel";
            this.pktLabel.Size = new System.Drawing.Size(102, 15);
            this.pktLabel.TabIndex = 5;
            this.pktLabel.Text = "Liczba Punktów: 0";
            this.pktLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // happyText
            // 
            this.happyText.AutoSize = true;
            this.happyText.Location = new System.Drawing.Point(377, 502);
            this.happyText.Name = "happyText";
            this.happyText.Size = new System.Drawing.Size(0, 15);
            this.happyText.TabIndex = 6;
            this.happyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.happyText);
            this.Controls.Add(this.pktLabel);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.nextButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button nextButton;
        private Label questionLabel;
        private TextBox answerBox;
        private Button skipButton;
        private Label pktLabel;
        private Label happyText;
        private PictureBox pictureBox1;
    }
}