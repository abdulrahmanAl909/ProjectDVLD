using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLD_Business;

namespace DVLD_Presentation
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void _WriteFile()
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\mno4t\OneDrive\المستندات\مشروع الشبكات\OneDrive\Desktop\ProjectDVLD\UserInfoInRememberMe.txt");

            writer.WriteLine(txtUserName.Text);
            writer.WriteLine(txtUserPassword.Text);
            writer.Write(cbRememberMe.Checked.ToString());

            writer.Close();
        }

        private void _ReaderFile(ref string UserName , ref string Password ,ref bool RememberMe)
        {
            StreamReader reader = new StreamReader(@"C:\Users\mno4t\OneDrive\المستندات\مشروع الشبكات\OneDrive\Desktop\ProjectDVLD\UserInfoInRememberMe.txt");

            UserName = reader.ReadLine();
            Password = reader.ReadLine();
            bool.TryParse(reader.ReadLine(), out bool result);
            RememberMe = result;

            reader.Close();
        }

        private void _CheckToWrite()
        {
            if (cbRememberMe.Checked)
            {
                _WriteFile();
            }
            else
            {
                _WriteFile();
            }
        }

        private void _CheckToReader()
        {
            if (cbRememberMe.Checked)
            {
                string UserName = "", UserPassword = "";
                bool RememberMe =false;

                _ReaderFile(ref UserName, ref UserPassword,ref RememberMe);

                txtUserName.Text = UserName;
                txtUserPassword.Text = UserPassword;
                cbRememberMe.Checked = RememberMe;
            }
            else
            {
                txtUserName.Clear();
                txtUserPassword.Clear();
                cbRememberMe.Checked = false;

            }
        }

        private void _CheckGetOutFromSystem()
        {
            string UserName = "", UserPassword = "";
            bool RememberMe = false;

            _ReaderFile(ref UserName, ref UserPassword, ref RememberMe);

            if (RememberMe)
            {
                txtUserName.Text = UserName;
                txtUserPassword.Text = UserPassword;
                cbRememberMe.Checked = RememberMe;
            }
            else
            {
                txtUserName.Clear();
                txtUserPassword.Clear();
                cbRememberMe.Checked = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                MessageBox.Show("Inviald UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGlobalSettings.FillCurrentUser(txtUserName.Text, txtUserPassword.Text) != null && clsGlobalSettings.CurrentUser.IsActive)
            {
                _CheckToWrite();

                frmMain frmMain = new frmMain();

                frmMain.ShowDialog();

                _CheckToReader();
            }
            else
            {
                MessageBox.Show("Inviald UserName or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _CheckGetOutFromSystem();
        }


    }
}
