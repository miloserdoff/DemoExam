
namespace SchoolDatabase.MainForms
{
    partial class TeacherDataBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TeacherDataBase = new System.Windows.Forms.DataGridView();
            this.RecordDataInformationPanel = new System.Windows.Forms.Panel();
            this.ClassGroupComboBox = new System.Windows.Forms.ComboBox();
            this.ClassYearComboBox = new System.Windows.Forms.ComboBox();
            this.LessonComboBox = new System.Windows.Forms.ComboBox();
            this.FullnameTextBox = new System.Windows.Forms.TextBox();
            this.DataOperationPanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditRecordTeacherDataBaseButton = new System.Windows.Forms.Button();
            this.AddNewDataTeacherDataBaseButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataBase)).BeginInit();
            this.RecordDataInformationPanel.SuspendLayout();
            this.DataOperationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherDataBase
            // 
            this.TeacherDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDataBase.Location = new System.Drawing.Point(53, 43);
            this.TeacherDataBase.Name = "TeacherDataBase";
            this.TeacherDataBase.Size = new System.Drawing.Size(456, 283);
            this.TeacherDataBase.TabIndex = 0;
            this.TeacherDataBase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RecordDataInformationPanel
            // 
            this.RecordDataInformationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecordDataInformationPanel.Controls.Add(this.ClassGroupComboBox);
            this.RecordDataInformationPanel.Controls.Add(this.ClassYearComboBox);
            this.RecordDataInformationPanel.Controls.Add(this.LessonComboBox);
            this.RecordDataInformationPanel.Controls.Add(this.FullnameTextBox);
            this.RecordDataInformationPanel.Location = new System.Drawing.Point(653, 43);
            this.RecordDataInformationPanel.Name = "RecordDataInformationPanel";
            this.RecordDataInformationPanel.Size = new System.Drawing.Size(284, 283);
            this.RecordDataInformationPanel.TabIndex = 1;
            // 
            // ClassGroupComboBox
            // 
            this.ClassGroupComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "А",
            "Б",
            "В",
            "Г",
            "Д",
            "Е",
            "Ж",
            "З",
            "И",
            "К"});
            this.ClassGroupComboBox.FormattingEnabled = true;
            this.ClassGroupComboBox.Items.AddRange(new object[] {
            "А",
            "Б",
            "В",
            "Г",
            "Д",
            "Е",
            "Ж",
            "З"});
            this.ClassGroupComboBox.Location = new System.Drawing.Point(14, 134);
            this.ClassGroupComboBox.Name = "ClassGroupComboBox";
            this.ClassGroupComboBox.Size = new System.Drawing.Size(255, 21);
            this.ClassGroupComboBox.TabIndex = 3;
            // 
            // ClassYearComboBox
            // 
            this.ClassYearComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.ClassYearComboBox.FormattingEnabled = true;
            this.ClassYearComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.ClassYearComboBox.Location = new System.Drawing.Point(14, 107);
            this.ClassYearComboBox.Name = "ClassYearComboBox";
            this.ClassYearComboBox.Size = new System.Drawing.Size(255, 21);
            this.ClassYearComboBox.TabIndex = 2;
            // 
            // LessonComboBox
            // 
            this.LessonComboBox.FormattingEnabled = true;
            this.LessonComboBox.Location = new System.Drawing.Point(14, 80);
            this.LessonComboBox.Name = "LessonComboBox";
            this.LessonComboBox.Size = new System.Drawing.Size(255, 21);
            this.LessonComboBox.TabIndex = 1;
            this.LessonComboBox.SelectedIndexChanged += new System.EventHandler(this.LessonComboBox_SelectedIndexChanged);
            // 
            // FullnameTextBox
            // 
            this.FullnameTextBox.Location = new System.Drawing.Point(14, 54);
            this.FullnameTextBox.Name = "FullnameTextBox";
            this.FullnameTextBox.Size = new System.Drawing.Size(255, 20);
            this.FullnameTextBox.TabIndex = 0;
            // 
            // DataOperationPanel
            // 
            this.DataOperationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataOperationPanel.Controls.Add(this.RemoveButton);
            this.DataOperationPanel.Controls.Add(this.EditRecordTeacherDataBaseButton);
            this.DataOperationPanel.Controls.Add(this.AddNewDataTeacherDataBaseButton);
            this.DataOperationPanel.Location = new System.Drawing.Point(653, 370);
            this.DataOperationPanel.Name = "DataOperationPanel";
            this.DataOperationPanel.Size = new System.Drawing.Size(284, 171);
            this.DataOperationPanel.TabIndex = 2;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(60, 118);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(162, 35);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Удалить запись";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditRecordTeacherDataBaseButton
            // 
            this.EditRecordTeacherDataBaseButton.Location = new System.Drawing.Point(61, 65);
            this.EditRecordTeacherDataBaseButton.Name = "EditRecordTeacherDataBaseButton";
            this.EditRecordTeacherDataBaseButton.Size = new System.Drawing.Size(162, 35);
            this.EditRecordTeacherDataBaseButton.TabIndex = 1;
            this.EditRecordTeacherDataBaseButton.Text = "Изменить запись";
            this.EditRecordTeacherDataBaseButton.UseVisualStyleBackColor = true;
            this.EditRecordTeacherDataBaseButton.Click += new System.EventHandler(this.EditRecordTeacherDataBaseButton_Click);
            // 
            // AddNewDataTeacherDataBaseButton
            // 
            this.AddNewDataTeacherDataBaseButton.Location = new System.Drawing.Point(61, 14);
            this.AddNewDataTeacherDataBaseButton.Name = "AddNewDataTeacherDataBaseButton";
            this.AddNewDataTeacherDataBaseButton.Size = new System.Drawing.Size(162, 35);
            this.AddNewDataTeacherDataBaseButton.TabIndex = 0;
            this.AddNewDataTeacherDataBaseButton.Text = "Добавить запись";
            this.AddNewDataTeacherDataBaseButton.UseVisualStyleBackColor = true;
            this.AddNewDataTeacherDataBaseButton.Click += new System.EventHandler(this.AddNewDataTeacherDataBaseButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(178, 13);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(302, 20);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(538, 13);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(108, 23);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // TeacherDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 578);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DataOperationPanel);
            this.Controls.Add(this.RecordDataInformationPanel);
            this.Controls.Add(this.TeacherDataBase);
            this.Name = "TeacherDataBaseForm";
            this.Text = "База данных учителей.";
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataBase)).EndInit();
            this.RecordDataInformationPanel.ResumeLayout(false);
            this.RecordDataInformationPanel.PerformLayout();
            this.DataOperationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TeacherDataBase;
        private System.Windows.Forms.Panel RecordDataInformationPanel;
        private System.Windows.Forms.ComboBox ClassGroupComboBox;
        private System.Windows.Forms.ComboBox ClassYearComboBox;
        private System.Windows.Forms.ComboBox LessonComboBox;
        private System.Windows.Forms.TextBox FullnameTextBox;
        private System.Windows.Forms.Panel DataOperationPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditRecordTeacherDataBaseButton;
        private System.Windows.Forms.Button AddNewDataTeacherDataBaseButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button RefreshButton;
    }
}