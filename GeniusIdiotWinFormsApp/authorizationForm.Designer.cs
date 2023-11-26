namespace GeniyIdiotWinFormsApp
{
    partial class authorizationForm
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            authorizationStartButton = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(42, 53);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(281, 38);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Введите Ваше имя:";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.ImeMode = ImeMode.On;
            nameTextBox.Location = new Point(81, 119);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(194, 31);
            nameTextBox.TabIndex = 4;
            nameTextBox.Text = "Undefined";
            // 
            // authorizationStartButton
            // 
            authorizationStartButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            authorizationStartButton.Location = new Point(98, 181);
            authorizationStartButton.Name = "authorizationStartButton";
            authorizationStartButton.Size = new Size(155, 76);
            authorizationStartButton.TabIndex = 5;
            authorizationStartButton.Text = "Старт!";
            authorizationStartButton.UseVisualStyleBackColor = true;
            authorizationStartButton.Click += authorizationNextButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(361, 33);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statisticsToolStripMenuItem, settingsToolStripMenuItem, restartToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(78, 29);
            menuToolStripMenuItem.Text = "Меню";
            // 
            // statisticsToolStripMenuItem
            // 
            statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            statisticsToolStripMenuItem.Size = new Size(270, 34);
            statisticsToolStripMenuItem.Text = "Статистика...";
            statisticsToolStripMenuItem.Click += statisticsToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(270, 34);
            restartToolStripMenuItem.Text = "Рестарт...";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Выход...";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(270, 34);
            settingsToolStripMenuItem.Text = "Настройки...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // authorizationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 286);
            Controls.Add(authorizationStartButton);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "authorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nameLabel;
        private TextBox nameTextBox;
        private Button authorizationStartButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}