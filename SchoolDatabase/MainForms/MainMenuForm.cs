using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDatabase.MainForms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void TeacherDataBaseButton_Click(object sender, EventArgs e)
        {
            var teacherDataBase = new TeacherDataBaseForm();
            teacherDataBase.Show();
            this.Close();
        }
    }
}
