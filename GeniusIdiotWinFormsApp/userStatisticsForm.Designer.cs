namespace GeniyIdiotWinFormsApp
{
    partial class userStatisticsForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            userStatisticsButton = new Button();
            userStatisticsDataGridView = new DataGridView();
            numberOfGame = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            countRightAnswers = new DataGridViewTextBoxColumn();
            diagnose = new DataGridViewTextBoxColumn();
            userStatisticsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)userStatisticsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userStatisticsButton
            // 
            userStatisticsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userStatisticsButton.Location = new Point(343, 379);
            userStatisticsButton.Name = "userStatisticsButton";
            userStatisticsButton.Size = new Size(130, 40);
            userStatisticsButton.TabIndex = 1;
            userStatisticsButton.Text = "ОК";
            userStatisticsButton.UseVisualStyleBackColor = true;
            userStatisticsButton.Click += userStatisticsButton_Click;
            // 
            // userStatisticsDataGridView
            // 
            userStatisticsDataGridView.AllowUserToDeleteRows = false;
            userStatisticsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userStatisticsDataGridView.Columns.AddRange(new DataGridViewColumn[] { numberOfGame, userName, countRightAnswers, diagnose });
            userStatisticsDataGridView.Location = new Point(26, 84);
            userStatisticsDataGridView.Name = "userStatisticsDataGridView";
            userStatisticsDataGridView.ReadOnly = true;
            userStatisticsDataGridView.RowHeadersWidth = 62;
            userStatisticsDataGridView.RowTemplate.Height = 33;
            userStatisticsDataGridView.Size = new Size(740, 260);
            userStatisticsDataGridView.TabIndex = 2;
            // 
            // numberOfGame
            // 
            numberOfGame.HeaderText = "Номер игры";
            numberOfGame.MinimumWidth = 8;
            numberOfGame.Name = "numberOfGame";
            numberOfGame.ReadOnly = true;
            numberOfGame.Width = 150;
            // 
            // userName
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            userName.DefaultCellStyle = dataGridViewCellStyle1;
            userName.HeaderText = "ФИО";
            userName.MinimumWidth = 8;
            userName.Name = "userName";
            userName.ReadOnly = true;
            userName.Width = 150;
            // 
            // countRightAnswers
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            countRightAnswers.DefaultCellStyle = dataGridViewCellStyle2;
            countRightAnswers.HeaderText = "Кол-во правильных ответов";
            countRightAnswers.MinimumWidth = 8;
            countRightAnswers.Name = "countRightAnswers";
            countRightAnswers.ReadOnly = true;
            countRightAnswers.Width = 200;
            // 
            // diagnose
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            diagnose.DefaultCellStyle = dataGridViewCellStyle3;
            diagnose.HeaderText = "Диагноз";
            diagnose.MinimumWidth = 8;
            diagnose.Name = "diagnose";
            diagnose.ReadOnly = true;
            diagnose.Width = 150;
            // 
            // userStatisticsLabel
            // 
            userStatisticsLabel.AutoSize = true;
            userStatisticsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            userStatisticsLabel.Location = new Point(293, 20);
            userStatisticsLabel.Name = "userStatisticsLabel";
            userStatisticsLabel.Size = new Size(222, 38);
            userStatisticsLabel.TabIndex = 3;
            userStatisticsLabel.Text = "Статистика игр";
            // 
            // userStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 444);
            Controls.Add(userStatisticsLabel);
            Controls.Add(userStatisticsDataGridView);
            Controls.Add(userStatisticsButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "userStatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            ((System.ComponentModel.ISupportInitialize)userStatisticsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button userStatisticsButton;
        private DataGridView userStatisticsDataGridView;
        private Label userStatisticsLabel;
        private DataGridViewTextBoxColumn numberOfGame;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn countRightAnswers;
        private DataGridViewTextBoxColumn diagnose;
    }
}