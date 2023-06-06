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
    public partial class RegistrationForm : Form
    {
        DataBase dataBase = new DataBase();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();
                var login = LoginTextBox.Text;
                var password = PasswordTextBox.Text;

                if (IsUserExist(login, password))
                {
                    MessageBox.Show("Такой пользователь уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    var query = $"INSERT INTO [dbo].[User] (Login, Password, Role) VALUES ('{login}', '{password}', 1)";
                    var command = new SqlCommand(query, dataBase.GetConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Успешная регистрация!\nПройдите авторизацию!", "Зарегистрировано!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch
            {
                MessageBox.Show("При выполнении операции произошла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsUserExist(string login, string password)
        {
            try
            {
                dataBase.OpenConnection();
                var table = new DataTable();
                var adapter = new SqlDataAdapter();

                var query = $"SELECT * FROM [dbo].[User] WHERE Login = '{login}' AND Password = '{password}'";
                var command = new SqlCommand(query, dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return true;
                }

            }

            catch
            {
                MessageBox.Show("При выполнении операции произошла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            LoginTextBox.MaxLength = 50;
            PasswordTextBox.MaxLength = 50;
            PasswordTextBox.PasswordChar = '*';
        }
    }
}
