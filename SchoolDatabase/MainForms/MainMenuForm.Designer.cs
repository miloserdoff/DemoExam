
namespace SchoolDatabase.MainForms
{
    partial class MainMenuForm
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
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.TeacherDataBaseButton = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenuPanel.Controls.Add(this.TeacherDataBaseButton);
            this.MainMenuPanel.Location = new System.Drawing.Point(347, 85);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(268, 299);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // TeacherDataBaseButton
            // 
            this.TeacherDataBaseButton.Location = new System.Drawing.Point(59, 47);
            this.TeacherDataBaseButton.Name = "TeacherDataBaseButton";
            this.TeacherDataBaseButton.Size = new System.Drawing.Size(154, 38);
            this.TeacherDataBaseButton.TabIndex = 0;
            this.TeacherDataBaseButton.Text = "Открыть БД учителей.";
            this.TeacherDataBaseButton.UseVisualStyleBackColor = true;
            this.TeacherDataBaseButton.Click += new System.EventHandler(this.TeacherDataBaseButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 538);
            this.Controls.Add(this.MainMenuPanel);
            this.Name = "MainMenuForm";
            this.Text = "Главное меню.";
            this.MainMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button TeacherDataBaseButton;
    }
}