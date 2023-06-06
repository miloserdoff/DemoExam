using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolDatabase.MainForms
{
    public partial class TeacherDataBaseForm : Form
    {
        DataBase dataBase = new DataBase();

        public TeacherDataBaseForm()
        {
            InitializeComponent();
            CreateColumn();
            RefreshDataGrid(TeacherDataBase);
            CreateLessonComboBoxItems();
        }

        private void CreateLessonComboBoxItems()
        {
            try
            {
                dataBase.OpenConnection();

                var query = $"SELECT ProfileLessonName FROM ProfileLesson";

                var command = new SqlCommand(query, dataBase.GetConnection());
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LessonComboBox.Items.Add(reader[0]);
                }

                reader.Close();

                dataBase.CloseConnection();
            }

            catch
            {
                MessageBox.Show("Произошла ошибка при получении коллекции предметов.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateColumn()
        {
            TeacherDataBase.Columns.Add("TeacherId", "Id");
            TeacherDataBase.Columns.Add("TeacherFullName", "ФИО");
            TeacherDataBase.Columns.Add("ProfileLessonName", "Предмет");
            TeacherDataBase.Columns.Add("ClassYear", "Цифра класса");
            TeacherDataBase.Columns.Add("ClassGroup", "Буква класса");

            TeacherDataBase.Columns[0].Visible = false;
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4));
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            try
            {
                dataBase.OpenConnection();

                var query = @"SELECT TeacherId, TeacherFullName, ProfileLessonName, ClassYear, ClassGroup
                            FROM Teacher
                            JOIN ProfileLesson
                            ON Teacher.ProfileLessonId = ProfileLesson.Id
                            JOIN Class
                            ON Teacher.OwnClassId = Class.Id";

                var command = new SqlCommand(query, dataBase.GetConnection());
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(TeacherDataBase, reader);
                }
            }

            catch
            {
                MessageBox.Show("Произошла ошибка подключения к базе данных.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.CloseConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;

            TeacherDataBase.Columns[0].Visible = true;

            DataSaver.Id = Convert.ToInt32(TeacherDataBase[0, selectedRowIndex].Value);

            TeacherDataBase.Columns[0].Visible = false;

            if (selectedRowIndex >= 0)
            {
                var row = TeacherDataBase.Rows[selectedRowIndex];

                FullnameTextBox.Text = row.Cells[1].Value.ToString();
                LessonComboBox.Text = row.Cells[2].Value.ToString();
                ClassYearComboBox.Text = row.Cells[3].Value.ToString();
                ClassGroupComboBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private int GetId(string fullname, string lesson, string classYear, string classGroup)
        {
            try
            {
                dataBase.OpenConnection();

                var lessonId = GetLessonIdByName(LessonComboBox.Text);
                var classId = GetClassIdByYearAndGroup(Convert.ToInt32(ClassYearComboBox.Text), ClassGroupComboBox.Text);

                var query = $"SELECT Id FROM Teacher WHERE TeacherFullname = '{fullname}', ProfileLessonId = {lessonId}, OwnClassId = {classId}";

                var command = new SqlCommand(query, dataBase.GetConnection());
                var id = command.ExecuteScalar();

                return Convert.ToInt32(id);
            }

            catch
            {
                MessageBox.Show("Ошибка");
            }

            return -1;
        }

        private int GetClassIdByYearAndGroup(int year, string group)
        {
            try
            {
                dataBase.OpenConnection();

                var query = $"SELECT Id FROM Class WHERE ClassYear = {year} AND ClassGroup = '{group}'";
                var command = new SqlCommand(query, dataBase.GetConnection());
                var classId = command.ExecuteScalar();

                return Convert.ToInt32(classId);
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1;
        }

        private int GetLessonIdByName(string lessonName)
        {
            try
            {
                dataBase.OpenConnection();

                var query = $"SELECT Id FROM ProfileLesson WHERE ProfileLessonName = '{lessonName}'";
                var command = new SqlCommand(query, dataBase.GetConnection());
                var profileLessonId = command.ExecuteScalar();

                var id = Convert.ToInt32(profileLessonId);

                return id;
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1;
        }

        private void LessonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();
                var lessonId = GetLessonIdByName(LessonComboBox.Text);
                var classId = GetClassIdByYearAndGroup(Convert.ToInt32(ClassYearComboBox.Text), ClassGroupComboBox.Text);


                if (lessonId != -1)
                {
                    var dialogResult = MessageBox.Show($"Вы хотите удалить элемент с ФИО {FullnameTextBox.Text}?", "Подтвердите удаление", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var query = $"DELETE FROM Teacher WHERE TeacherId = {DataSaver.Id}";
                        var command = new SqlCommand(query, dataBase.GetConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Запись удалена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                else
                {
                    MessageBox.Show("У учителя нет предмета!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search(DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();

                dataBase.OpenConnection();

                var query = @"SELECT TeacherFullName, ProfileLessonName, ClassYear, ClassGroup
                            FROM Teacher
                            JOIN ProfileLesson
                            ON Teacher.ProfileLessonId = ProfileLesson.Id
                            JOIN Class
                            ON Teacher.OwnClassId = Class.Id
                            WHERE CONCAT (TeacherFullName, ProfileLessonName, ClassYear, ClassGroup) 
                            LIKE '%" + SearchTextBox.Text + "%'";

                var command = new SqlCommand(query, dataBase.GetConnection());
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dataGridView, reader);
                }

                reader.Close();

                dataBase.CloseConnection();
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewDataTeacherDataBaseButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(TeacherDataBase);
        }

        private void EditRecordTeacherDataBaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();

                var lessonId = GetLessonIdByName(LessonComboBox.Text);
                var classId = GetClassIdByYearAndGroup(Convert.ToInt32(ClassYearComboBox.Text), ClassGroupComboBox.Text);

                var query = $"UPDATE Teacher SET TeacherFullname = '{FullnameTextBox.Text}', ProfileLessonId = {lessonId}, OwnClassId = {classId} WHERE TeacherId = {DataSaver.Id}";
                var command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Успешно!");
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            TeacherDataBase.Rows.Clear();
            RefreshDataGrid(TeacherDataBase);
        }
    }
}
