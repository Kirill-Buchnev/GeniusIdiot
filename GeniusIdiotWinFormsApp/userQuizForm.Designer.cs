namespace GeniyIdiotWinFormsApp
{
    partial class userQuizForm
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
            userQuizLabel = new Label();
            userQuizButton = new Button();
            userQuizQuestionLabel = new Label();
            userQuizAnswerLabel = new Label();
            userQuizAnswerNumericUpDown = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            timerHeaderQuizQuestionLabel = new Label();
            quizTimer = new System.Windows.Forms.Timer(components);
            timerQuizQuestionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)userQuizAnswerNumericUpDown).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // userQuizLabel
            // 
            userQuizLabel.AutoSize = true;
            userQuizLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            userQuizLabel.Location = new Point(255, 33);
            userQuizLabel.Name = "userQuizLabel";
            userQuizLabel.Size = new Size(182, 38);
            userQuizLabel.TabIndex = 0;
            userQuizLabel.Text = "Вопрос №1:";
            // 
            // userQuizButton
            // 
            userQuizButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userQuizButton.Location = new Point(530, 261);
            userQuizButton.Name = "userQuizButton";
            userQuizButton.Size = new Size(131, 62);
            userQuizButton.TabIndex = 1;
            userQuizButton.Text = "Ответить";
            userQuizButton.UseVisualStyleBackColor = true;
            userQuizButton.Click += userQuizButton_Click;
            // 
            // userQuizQuestionLabel
            // 
            userQuizQuestionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userQuizQuestionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userQuizQuestionLabel.Location = new Point(35, 89);
            userQuizQuestionLabel.Name = "userQuizQuestionLabel";
            userQuizQuestionLabel.Size = new Size(649, 87);
            userQuizQuestionLabel.TabIndex = 0;
            userQuizQuestionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // userQuizAnswerLabel
            // 
            userQuizAnswerLabel.AutoSize = true;
            userQuizAnswerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userQuizAnswerLabel.Location = new Point(35, 276);
            userQuizAnswerLabel.Name = "userQuizAnswerLabel";
            userQuizAnswerLabel.Size = new Size(176, 32);
            userQuizAnswerLabel.TabIndex = 2;
            userQuizAnswerLabel.Text = "Введите ответ:";
            // 
            // userQuizAnswerNumericUpDown
            // 
            userQuizAnswerNumericUpDown.Location = new Point(279, 280);
            userQuizAnswerNumericUpDown.Maximum = new decimal(new int[] { 1661992960, 1808227885, 5, 0 });
            userQuizAnswerNumericUpDown.Minimum = new decimal(new int[] { 1661992960, 1808227885, 5, int.MinValue });
            userQuizAnswerNumericUpDown.Name = "userQuizAnswerNumericUpDown";
            userQuizAnswerNumericUpDown.Size = new Size(180, 31);
            userQuizAnswerNumericUpDown.TabIndex = 3;
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
            statisticsToolStripMenuItem.Click += statisticsToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(213, 34);
            restartToolStripMenuItem.Text = "Рестарт...";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(213, 34);
            exitToolStripMenuItem.Text = "Выход...";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // timerHeaderQuizQuestionLabel
            // 
            timerHeaderQuizQuestionLabel.AutoSize = true;
            timerHeaderQuizQuestionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timerHeaderQuizQuestionLabel.Location = new Point(35, 205);
            timerHeaderQuizQuestionLabel.Name = "timerHeaderQuizQuestionLabel";
            timerHeaderQuizQuestionLabel.Size = new Size(227, 32);
            timerHeaderQuizQuestionLabel.TabIndex = 11;
            timerHeaderQuizQuestionLabel.Text = "Оставшееся время:";
            // 
            // quizTimer
            // 
            quizTimer.Interval = 10;
            quizTimer.Tick += quizTimer_Tick;
            // 
            // timerQuizQuestionLabel
            // 
            timerQuizQuestionLabel.AutoSize = true;
            timerQuizQuestionLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            timerQuizQuestionLabel.Location = new Point(279, 202);
            timerQuizQuestionLabel.Name = "timerQuizQuestionLabel";
            timerQuizQuestionLabel.Size = new Size(49, 38);
            timerQuizQuestionLabel.TabIndex = 12;
            timerQuizQuestionLabel.Text = "10";
            // 
            // userQuizForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 357);
            Controls.Add(timerQuizQuestionLabel);
            Controls.Add(timerHeaderQuizQuestionLabel);
            Controls.Add(menuStrip1);
            Controls.Add(userQuizAnswerNumericUpDown);
            Controls.Add(userQuizAnswerLabel);
            Controls.Add(userQuizButton);
            Controls.Add(userQuizQuestionLabel);
            Controls.Add(userQuizLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "userQuizForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            ((System.ComponentModel.ISupportInitialize)userQuizAnswerNumericUpDown).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userQuizLabel;
        private Button userQuizButton;
        private Label userQuizQuestionLabel;
        private Label userQuizAnswerLabel;
        private NumericUpDown userQuizAnswerNumericUpDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label timerHeaderQuizQuestionLabel;
        private System.Windows.Forms.Timer quizTimer;
        private Label timerQuizQuestionLabel;
    }
}