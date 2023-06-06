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
using SchoolDatabase.MainForms;

namespace SchoolDatabase
{
    public partial class LoginForm : Form
    {
        DataBase dataBase = new DataBase();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();

                var login = LoginTextBox.Text;
                var password = PasswordTextBox.Text;
                var table = new DataTable();
                var adapter = new SqlDataAdapter();

                var query = $"SELECT * FROM [dbo].[User] WHERE Login = '{login}' AND Password = '{password}'";
                var command = new SqlCommand(query, dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Успешная авторизация!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var mainMenu = new MainMenuForm();
                    mainMenu.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Не удалось авторизоваться!\nПроверьте введенные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.MaxLength = 50;
            LoginTextBox.MaxLength = 50;
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var regForm = new RegistrationForm();
            regForm.Show();
            this.Hide();
        }
    }
}
