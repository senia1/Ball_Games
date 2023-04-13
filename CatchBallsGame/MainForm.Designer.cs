namespace CatchBallsGame
{
    partial class MainForm
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
            countBallsLabel = new Label();
            startButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // countBallsLabel
            // 
            countBallsLabel.Anchor = AnchorStyles.Top;
            countBallsLabel.AutoSize = true;
            countBallsLabel.Location = new Point(386, 9);
            countBallsLabel.Name = "countBallsLabel";
            countBallsLabel.Size = new Size(22, 25);
            countBallsLabel.TabIndex = 0;
            countBallsLabel.Text = "0";
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Top;
            startButton.Location = new Point(229, 9);
            startButton.Name = "startButton";
            startButton.Size = new Size(112, 34);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top;
            clearButton.Location = new Point(455, 9);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(startButton);
            Controls.Add(countBallsLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CatchBallsGame";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label countBallsLabel;
        private Button startButton;
        private Button clearButton;
    }
}