namespace GeniyIdiotWinFormsApp
{
    partial class userMainForm
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
            userMainAttentionLabel = new Label();
            userMainStartButton = new Button();
            userMainInfoLabel = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // userMainAttentionLabel
            // 
            userMainAttentionLabel.AutoSize = true;
            userMainAttentionLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            userMainAttentionLabel.Location = new Point(201, 53);
            userMainAttentionLabel.Name = "userMainAttentionLabel";
            userMainAttentionLabel.Size = new Size(166, 38);
            userMainAttentionLabel.TabIndex = 0;
            userMainAttentionLabel.Text = "Внимание!";
            // 
            // userMainStartButton
            // 
            userMainStartButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userMainStartButton.Location = new Point(218, 203);
            userMainStartButton.Name = "userMainStartButton";
            userMainStartButton.Size = new Size(114, 56);
            userMainStartButton.TabIndex = 1;
            userMainStartButton.Text = "Начать!";
            userMainStartButton.UseVisualStyleBackColor = true;
            userMainStartButton.Click += userMainStartButton_Click;
            // 
            // userMainInfoLabel
            // 
            userMainInfoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userMainInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userMainInfoLabel.Location = new Point(88, 94);
            userMainInfoLabel.Name = "userMainInfoLabel";
            userMainInfoLabel.Size = new Size(399, 100);
            userMainInfoLabel.TabIndex = 0;
            userMainInfoLabel.Text = "На ответ на каждый вопрос у Вас есть ровно 10 секунд!";
            userMainInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(576, 33);
            menuStrip1.TabIndex = 9;
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
            statisticsToolStripMenuItem.Size = new Size(270, 34);
            statisticsToolStripMenuItem.Text = "Статистика...";
            statisticsToolStripMenuItem.Click += statisticsToolStripMenuItem_Click_1;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(270, 34);
            restartToolStripMenuItem.Text = "Рестарт...";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Выход...";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // userMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 292);
            Controls.Add(menuStrip1);
            Controls.Add(userMainStartButton);
            Controls.Add(userMainInfoLabel);
            Controls.Add(userMainAttentionLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "userMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userMainAttentionLabel;
        private Button userMainStartButton;
        private Label userMainInfoLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}