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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            manyBallsButton = new Button();
            stopBallButton = new Button();
            clearFormButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
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
            // stopBallButton
            // 
            stopBallButton.Location = new Point(659, 349);
            stopBallButton.Name = "stopBallButton";
            stopBallButton.Size = new Size(112, 34);
            stopBallButton.TabIndex = 1;
            stopBallButton.Text = "Stop";
            stopBallButton.UseVisualStyleBackColor = true;
            stopBallButton.Click += stopBallButton_Click;
            // 
            // clearFormButton
            // 
            clearFormButton.Location = new Point(659, 389);
            clearFormButton.Name = "clearFormButton";
            clearFormButton.Size = new Size(112, 34);
            clearFormButton.TabIndex = 2;
            clearFormButton.Text = " Clean";
            clearFormButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearFormButton);
            Controls.Add(stopBallButton);
            Controls.Add(manyBallsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balls";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button manyBallsButton;
        private Button stopBallButton;
        private Button clearFormButton;
        private System.Windows.Forms.Timer timer;
    }
}