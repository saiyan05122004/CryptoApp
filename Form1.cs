using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace MessariT15
{
    public partial class Menu : Form
    {
        DataBase dataase = new DataBase();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
    (
     int nLeftRect,
     int nTopRect,
     int nRightRect,
     int nBottomRect,
     int nWidthEllipse,
     int nHeigtEllipse
     );   



        public Menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnList.Height;
            PnlNav.Top = BtnList.Top;
            PnlNav.Left = BtnList.Left;
            BtnList.BackColor = Color.FromArgb(31, 35, 42);

            iblTitle.Text = "MessariT";
            this.PnlFormLoader.Controls.Clear();
            List FrmList_Vrb = new List() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmList_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmList_Vrb);
            FrmList_Vrb.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            // Перемещает PnlNav на выброный button
            PnlNav.Height = BtnList.Height;
            PnlNav.Top = BtnList.Top;
            PnlNav.Left = BtnList.Left;
            BtnList.BackColor = Color.FromArgb(31, 35, 42);
             
            iblTitle.Text = "MessariT";
            // PnlFormLoader удоляет все элементы которые находять в ней 
            this.PnlFormLoader.Controls.Clear();
            // FrmList_Vrb делает новый List и перемешает его на PnlFormLoader 
            List FrmList_Vrb = new List() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmList_Vrb.FormBorderStyle = FormBorderStyle.None;
            // PnlFormLoader получил новый лист и выводит это в FrmList_Vrb
            this.PnlFormLoader.Controls.Add(FrmList_Vrb);
            FrmList_Vrb.Show();
        }

        private void BtnBriefcase_Click(object sender, EventArgs e)
        {
            // Перемещает PnlNav на выброный button
            PnlNav.Height = BtnBriefcase.Height;
            PnlNav.Top = BtnBriefcase.Top;
            BtnBriefcase.BackColor = Color.FromArgb(31, 35, 42);

            iblTitle.Text = "MessariT";
            this.PnlFormLoader.Controls.Clear();
            FrmBriefcase FrmList_Vrb = new FrmBriefcase() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmList_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmList_Vrb);
            FrmList_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DataBase.Login;
        }

        private void BtnFavorites_Click(object sender, EventArgs e)
        {
            // Перемещает PnlNav на выброный button
            PnlNav.Height = BtnFavorites.Height;
            PnlNav.Top = BtnFavorites.Top;
            BtnFavorites.BackColor = Color.FromArgb(31, 35, 42);

            iblTitle.Text = "MessariT";
            this.PnlFormLoader.Controls.Clear();
            FrmFavorites FrmList_Vrb = new FrmFavorites() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmList_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmList_Vrb);
            FrmList_Vrb.Show();
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            // Перемещает PnlNav на выброный button
            PnlNav.Height = BtnConverter.Height;
            PnlNav.Top = BtnConverter.Top;
            BtnConverter.BackColor = Color.FromArgb(22, 25, 29);

            iblTitle.Text = "MessariT";
            this.PnlFormLoader.Controls.Clear();
            FrmConverter FrmList_Vrb = new FrmConverter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmList_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmList_Vrb);
            FrmList_Vrb.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            // Перемещает PnlNav на выброный button
            PnlNav.Height = BtnSettings.Height;
            PnlNav.Top = BtnSettings.Top;
            BtnSettings.BackColor = Color.FromArgb(22, 25, 29);
        }

        private void BtnList_Leave(object sender, EventArgs e)
        {
            // Меняет цвет кнопки после нажания на нее 
            BtnList.BackColor = Color.FromArgb(22, 25, 29);
        }

        private void BtnBriefcase_Leave(object sender, EventArgs e)
        {
            // Меняет цвет кнопки после нажания на нее 
            BtnBriefcase.BackColor = Color.FromArgb(22, 25, 29);
        }

        private void BtnFavorites_Leave(object sender, EventArgs e)
        {
            // Меняет цвет кнопки после нажания на нее 
            BtnFavorites.BackColor = Color.FromArgb(22, 25, 29);
        }

        private void BtnConverter_Leave(object sender, EventArgs e)
        {
            // Меняет цвет кнопки после нажания на нее 
            BtnConverter.BackColor = Color.FromArgb(22, 25, 29);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            // Меняет цвет кнопки после нажания на нее 
            BtnSettings.BackColor = Color.FromArgb(22, 25, 29);
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // выход из приложения 
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DataBase.Login;
        }
    }
}
