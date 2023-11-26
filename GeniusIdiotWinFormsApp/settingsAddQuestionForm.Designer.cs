namespace GeniyIdiotWinFormsApp
{
    partial class settingsAddQuestionForm
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
            adminAddQuestionMainLabel = new Label();
            adminAddQuestionButton = new Button();
            adminAddQuestionNumericUpDown = new NumericUpDown();
            adminAddQuestionTextLabel = new Label();
            adminAddQuestionTextBox = new TextBox();
            adminAddQuestionAnswerLabel = new Label();
            adminAddQuestionBackButton = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)adminAddQuestionNumericUpDown).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // adminAddQuestionMainLabel
            // 
            adminAddQuestionMainLabel.AutoSize = true;
            adminAddQuestionMainLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            adminAddQuestionMainLabel.Location = new Point(211, 49);
            adminAddQuestionMainLabel.Name = "adminAddQuestionMainLabel";
            adminAddQuestionMainLabel.Size = new Size(306, 38);
            adminAddQuestionMainLabel.TabIndex = 0;
            adminAddQuestionMainLabel.Text = "Добавление вопроса";
            // 
            // adminAddQuestionButton
            // 
            adminAddQuestionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminAddQuestionButton.Location = new Point(520, 317);
            adminAddQuestionButton.Name = "adminAddQuestionButton";
            adminAddQuestionButton.Size = new Size(140, 75);
            adminAddQuestionButton.TabIndex = 1;
            adminAddQuestionButton.Text = "Добавить";
            adminAddQuestionButton.UseVisualStyleBackColor = true;
            adminAddQuestionButton.Click += adminAddQuestionButton_Click;
            // 
            // adminAddQuestionNumericUpDown
            // 
            adminAddQuestionNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            adminAddQuestionNumericUpDown.Location = new Point(268, 259);
            adminAddQuestionNumericUpDown.Maximum = new decimal(new int[] { 1661992960, 1808227885, 5, 0 });
            adminAddQuestionNumericUpDown.Minimum = new decimal(new int[] { 1661992960, 1808227885, 5, int.MinValue });
            adminAddQuestionNumericUpDown.Name = "adminAddQuestionNumericUpDown";
            adminAddQuestionNumericUpDown.Size = new Size(160, 31);
            adminAddQuestionNumericUpDown.TabIndex = 5;
            adminAddQuestionNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // adminAddQuestionTextLabel
            // 
            adminAddQuestionTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminAddQuestionTextLabel.Location = new Point(230, 108);
            adminAddQuestionTextLabel.Name = "adminAddQuestionTextLabel";
            adminAddQuestionTextLabel.Size = new Size(294, 38);
            adminAddQuestionTextLabel.TabIndex = 6;
            adminAddQuestionTextLabel.Text = "Введите текст вопроса:";
            // 
            // adminAddQuestionTextBox
            // 
            adminAddQuestionTextBox.Location = new Point(47, 158);
            adminAddQuestionTextBox.Name = "adminAddQuestionTextBox";
            adminAddQuestionTextBox.Size = new Size(631, 31);
            adminAddQuestionTextBox.TabIndex = 7;
            // 
            // adminAddQuestionAnswerLabel
            // 
            adminAddQuestionAnswerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminAddQuestionAnswerLabel.Location = new Point(259, 209);
            adminAddQuestionAnswerLabel.Name = "adminAddQuestionAnswerLabel";
            adminAddQuestionAnswerLabel.Size = new Size(181, 38);
            adminAddQuestionAnswerLabel.TabIndex = 6;
            adminAddQuestionAnswerLabel.Text = "Введите ответ:";
            // 
            // adminAddQuestionBackButton
            // 
            adminAddQuestionBackButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminAddQuestionBackButton.Location = new Point(58, 317);
            adminAddQuestionBackButton.Name = "adminAddQuestionBackButton";
            adminAddQuestionBackButton.Size = new Size(140, 75);
            adminAddQuestionBackButton.TabIndex = 9;
            adminAddQuestionBackButton.Text = "Назад";
            adminAddQuestionBackButton.UseVisualStyleBackColor = true;
            adminAddQuestionBackButton.Click += adminAddQuestionBackButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(726, 33);
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
            // settingsAddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 419);
            Controls.Add(menuStrip1);
            Controls.Add(adminAddQuestionBackButton);
            Controls.Add(adminAddQuestionTextBox);
            Controls.Add(adminAddQuestionAnswerLabel);
            Controls.Add(adminAddQuestionTextLabel);
            Controls.Add(adminAddQuestionNumericUpDown);
            Controls.Add(adminAddQuestionButton);
            Controls.Add(adminAddQuestionMainLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "settingsAddQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            ((System.ComponentModel.ISupportInitialize)adminAddQuestionNumericUpDown).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminAddQuestionMainLabel;
        private Button adminAddQuestionButton;
        private NumericUpDown adminAddQuestionNumericUpDown;
        private Label adminAddQuestionTextLabel;
        private TextBox adminAddQuestionTextBox;
        private Label adminAddQuestionAnswerLabel;
        private Button adminAddQuestionBackButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}