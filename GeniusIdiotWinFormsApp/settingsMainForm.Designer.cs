namespace GeniyIdiotWinFormsApp
{
    partial class settingsMainForm
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
            adminMainLabel = new Label();
            adminMainNextButton = new Button();
            adminMainComboBox = new ComboBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // adminMainLabel
            // 
            adminMainLabel.AutoSize = true;
            adminMainLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            adminMainLabel.Location = new Point(69, 50);
            adminMainLabel.Name = "adminMainLabel";
            adminMainLabel.Size = new Size(295, 38);
            adminMainLabel.TabIndex = 0;
            adminMainLabel.Text = "Выберите действие!";
            // 
            // adminMainNextButton
            // 
            adminMainNextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminMainNextButton.Location = new Point(155, 201);
            adminMainNextButton.Name = "adminMainNextButton";
            adminMainNextButton.Size = new Size(114, 56);
            adminMainNextButton.TabIndex = 1;
            adminMainNextButton.Text = "Далее";
            adminMainNextButton.UseVisualStyleBackColor = true;
            adminMainNextButton.Click += adminMainNextButton_Click;
            // 
            // adminMainComboBox
            // 
            adminMainComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            adminMainComboBox.FormattingEnabled = true;
            adminMainComboBox.Items.AddRange(new object[] { "Загрузить стандартный список вопросов", "Добавить вопрос", "Удалить вопрос" });
            adminMainComboBox.Location = new Point(27, 128);
            adminMainComboBox.Name = "adminMainComboBox";
            adminMainComboBox.Size = new Size(382, 33);
            adminMainComboBox.TabIndex = 2;
            adminMainComboBox.Text = "Выберите...";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(441, 33);
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
            // settingsMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 289);
            Controls.Add(menuStrip1);
            Controls.Add(adminMainComboBox);
            Controls.Add(adminMainNextButton);
            Controls.Add(adminMainLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "settingsMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminMainLabel;
        private Button adminMainNextButton;
        private ComboBox adminMainComboBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}