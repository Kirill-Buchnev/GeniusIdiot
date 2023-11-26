namespace GeniyIdiotWinFormsApp
{
    partial class settingsRemoveQuestionForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            adminRemoveQuestionMainLabel = new Label();
            adminRemoveQuestionButton = new Button();
            adminRemoveQuestionBackButton = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            removeQuestionDataGridView = new DataGridView();
            numberColumn = new DataGridViewTextBoxColumn();
            textColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)removeQuestionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // adminRemoveQuestionMainLabel
            // 
            adminRemoveQuestionMainLabel.AutoSize = true;
            adminRemoveQuestionMainLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            adminRemoveQuestionMainLabel.Location = new Point(236, 51);
            adminRemoveQuestionMainLabel.Name = "adminRemoveQuestionMainLabel";
            adminRemoveQuestionMainLabel.Size = new Size(253, 38);
            adminRemoveQuestionMainLabel.TabIndex = 0;
            adminRemoveQuestionMainLabel.Text = "Список вопросов";
            // 
            // adminRemoveQuestionButton
            // 
            adminRemoveQuestionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminRemoveQuestionButton.Location = new Point(549, 405);
            adminRemoveQuestionButton.Name = "adminRemoveQuestionButton";
            adminRemoveQuestionButton.Size = new Size(140, 75);
            adminRemoveQuestionButton.TabIndex = 1;
            adminRemoveQuestionButton.Text = "Удалить";
            adminRemoveQuestionButton.UseVisualStyleBackColor = true;
            adminRemoveQuestionButton.Click += adminRemoveQuestionButton_Click;
            // 
            // adminRemoveQuestionBackButton
            // 
            adminRemoveQuestionBackButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminRemoveQuestionBackButton.Location = new Point(32, 405);
            adminRemoveQuestionBackButton.Name = "adminRemoveQuestionBackButton";
            adminRemoveQuestionBackButton.Size = new Size(140, 75);
            adminRemoveQuestionBackButton.TabIndex = 8;
            adminRemoveQuestionBackButton.Text = "Назад";
            adminRemoveQuestionBackButton.UseVisualStyleBackColor = true;
            adminRemoveQuestionBackButton.Click += adminRemoveQuestionBackButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(726, 33);
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
            // removeQuestionDataGridView
            // 
            removeQuestionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            removeQuestionDataGridView.Columns.AddRange(new DataGridViewColumn[] { numberColumn, textColumn });
            removeQuestionDataGridView.Location = new Point(32, 105);
            removeQuestionDataGridView.Name = "removeQuestionDataGridView";
            removeQuestionDataGridView.RowHeadersWidth = 62;
            removeQuestionDataGridView.RowTemplate.Height = 33;
            removeQuestionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            removeQuestionDataGridView.Size = new Size(657, 263);
            removeQuestionDataGridView.TabIndex = 10;
            // 
            // numberColumn
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            numberColumn.DefaultCellStyle = dataGridViewCellStyle1;
            numberColumn.FillWeight = 200F;
            numberColumn.HeaderText = "Номер вопроса";
            numberColumn.MinimumWidth = 8;
            numberColumn.Name = "numberColumn";
            numberColumn.Width = 150;
            // 
            // textColumn
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            textColumn.DefaultCellStyle = dataGridViewCellStyle2;
            textColumn.FillWeight = 200F;
            textColumn.HeaderText = "Вопрос";
            textColumn.MinimumWidth = 8;
            textColumn.Name = "textColumn";
            textColumn.Width = 480;
            // 
            // settingsRemoveQuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 492);
            Controls.Add(removeQuestionDataGridView);
            Controls.Add(menuStrip1);
            Controls.Add(adminRemoveQuestionBackButton);
            Controls.Add(adminRemoveQuestionButton);
            Controls.Add(adminRemoveQuestionMainLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "settingsRemoveQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)removeQuestionDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminRemoveQuestionMainLabel;
        private Button adminRemoveQuestionButton;
        private Button adminRemoveQuestionBackButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView removeQuestionDataGridView;
        private DataGridViewTextBoxColumn numberColumn;
        private DataGridViewTextBoxColumn textColumn;
    }
}