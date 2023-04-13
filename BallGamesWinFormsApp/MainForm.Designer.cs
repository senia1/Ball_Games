namespace BallGamesWinFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            manyBallsButton = new Button();
            SuspendLayout();
            // 
            // manyBallsButton
            // 
            manyBallsButton.Location = new Point(659, 309);
            manyBallsButton.Name = "manyBallsButton";
            manyBallsButton.Size = new Size(112, 34);
            manyBallsButton.TabIndex = 0;
            manyBallsButton.Text = "Start";
            manyBallsButton.UseVisualStyleBackColor = true;
            manyBallsButton.Click += manyBallsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(manyBallsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balls";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button manyBallsButton;
    }
}