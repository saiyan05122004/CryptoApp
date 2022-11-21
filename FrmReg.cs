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

namespace MessariT15
{
    public partial class FrmReg : Form
    {
        DataBase dataBase = new DataBase();

        public FrmReg()
        {
            InitializeComponent();
               // открытие формы по центре
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DataBase.Login= TBoxSignUpLogin.Text;
            DataBase.Password = TBoxSignUpPass.Text;

            var loginUser = TBoxSignUpLogin.Text;
            var passUser = TBoxSignUpPass.Texts;

            string querystring = $"select insert into [register] (login_user, password_user) = values('{loginUser}' , '{passUser}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
                FrmLogin frmLogin = new FrmLogin();
                this.Hide();
                frmLogin.ShowDialog();
          
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            dataBase.closeConnection();
        }

        private Boolean checkuser()
        {
            var loginUser = TBoxSignUpLogin.Texts;
            var passUser = TBoxSignUpPass.Texts;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}'and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else
            { 
              return false;
            }
             
           
                
            
        }
    }
}
