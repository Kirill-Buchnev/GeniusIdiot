namespace GeniyIdiotWinFormsApp
{
    partial class userEndQuizForm
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
            userEndQuizLabel = new Label();
            userEndQuizButton = new Button();
            userRepeatQuizButton = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // userEndQuizLabel
            // 
            userEndQuizLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userEndQuizLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userEndQuizLabel.Location = new Point(40, 102);
            userEndQuizLabel.Name = "userEndQuizLabel";
            userEndQuizLabel.Size = new Size(631, 124);
            userEndQuizLabel.TabIndex = 0;
            userEndQuizLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // userEndQuizButton
            // 
            userEndQuizButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userEndQuizButton.Location = new Point(509, 260);
            userEndQuizButton.Name = "userEndQuizButton";
            userEndQuizButton.Size = new Size(162, 71);
            userEndQuizButton.TabIndex = 2;
            userEndQuizButton.Text = "Завершить";
            userEndQuizButton.UseVisualStyleBackColor = true;
            userEndQuizButton.Click += userEndQuizButton_Click;
            // 
            // userRepeatQuizButton
            // 
            userRepeatQuizButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userRepeatQuizButton.Location = new Point(40, 260);
            userRepeatQuizButton.Name = "userRepeatQuizButton";
            userRepeatQuizButton.Size = new Size(162, 71);
            userRepeatQuizButton.TabIndex = 2;
            userRepeatQuizButton.Text = "Повторить";
            userRepeatQuizButton.UseVisualStyleBackColor = true;
            userRepeatQuizButton.Click += userRepeatQuizButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(713, 33);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statisticsToolStripMenuItem, restartToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(78, 29);
            menuToolStripMenuItem.Text = "Меню";
            // 
            // statisticsToolStripMenuItem
            // 
            statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            statisticsToolStripMenuItem.Size = new Size(213, 34);
            statisticsToolStripMenuItem.Text = "Статистика...";
            statisticsToolStripMenuItem.Click += statisticsToolStripMenuItem_Click_1;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(213, 34);
            restartToolStripMenuItem.Text = "Рестарт...";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(213, 34);
            exitToolStripMenuItem.Text = "Выход...";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // userEndQuizForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 357);
            Controls.Add(menuStrip1);
            Controls.Add(userRepeatQuizButton);
            Controls.Add(userEndQuizButton);
            Controls.Add(userEndQuizLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "userEndQuizForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userEndQuizLabel;
        private Button userEndQuizButton;
        private Button userRepeatQuizButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}