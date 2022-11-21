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
    public partial class FrmLogin : Form

    {
        DataBase dataBase = new DataBase();

        public FrmLogin()
        {  
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DataBase.Login = TBoxSignLogin.Text;
            DataBase.Password = TBoxSignPassword.Text;
            
            DataTable table = new DataTable();

            

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();
                this.Hide();
                
            }
           
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();

        }

        private void TBoxSignPassword__TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TBoxSignLogin__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FrmReg frmReg = new FrmReg();
            frmReg.Show();
            this.Hide();
        }
    }
}
