using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetAss2
{
    /* Login Form: First Window showing when the program runs
     *             Allow Users to login, go to register page or exit
     */
    public partial class LoginForm : Form
    {
        //read login txt file and store data in string array
        private string[] login_f = File.ReadAllLines("login.txt");
        private string name = "default";
        private string usertype = "View";

        public LoginForm()
        {
            InitializeComponent();
            LoginTitle.Focus();
            LoginTitle.Select();
            MessageBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Create New user (register) button > send to Register window
        private void NewuserB_Click(object sender, EventArgs e)
        {
            NewuserForm newuserForm = new NewuserForm();
            newuserForm.login_f = this.login_f;
            newuserForm.Show();
            this.Hide();
        }

        //Exit button > exit the window and quit the program 
        private void ExitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Login button > send to text editor window when valid login detail input
        private void LoginB_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                TextEditorWindow textEditor = new TextEditorWindow(name,usertype);
                textEditor.loginForm = this;
                textEditor.Show();
                this.Hide();
            }
            else {
                UsernameTxt.Text = "Username";
                PasswordTxt.PasswordChar = '\0';
                PasswordTxt.Text = "Password";
            }
        }

        //validate login details
        private bool Login()
        {
            string msg = "";
            bool set = false;

            if (UsernameTxt.Text == "Username")
            {
                msg += "Username must be filled.";
            }
            if (PasswordTxt.Text == "Password")
            {
                msg += " Password must be filled.\n";
            }
            if (exists(UsernameTxt.Text))
            {
                if (matches(UsernameTxt.Text, PasswordTxt.Text))
                {
                    set = true;
                }
                else
                {
                    msg += "Password is incorrect.\n";
                }
            }
            else
            {
                msg += "Username dose not exist.\n";
            }
            MessageBox.Text = msg;
            return set;
        }

        //check if username is existing in the file
        private bool exists(String user_name)
        {
            foreach (string set in login_f)
            {
                string[] splits = set.Split(',');
                if (splits[0] == user_name)
                    return true;
            }
            return false;
        }

        //check if username matches with password
        private bool matches(String user_name, String password)
        {
            foreach (string set in login_f)
            {
                string[] splits = set.Split(',');
                if (splits[0] == user_name && splits[1] == password)
                {
                    name = splits[3] +" "+ splits[4];
                    usertype = splits[2];
                    return true;
                }
            }
            return false;
        }

        private void MessageBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        //put placeholders when the textbox is empty 
        private void UsernameTxt_Enter(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "Username")
                UsernameTxt.Text = "";
            UsernameTxt.ForeColor = Color.Black;
        }
        private void PasswordTxt_Enter(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "Password")
                PasswordTxt.Text = "";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.ForeColor = Color.Black;
            
        }

        private void UsernameTxt_Leave(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "")
                UsernameTxt.Text = "Username";
            UsernameTxt.ForeColor = Color.Gray;
        }

        private void PasswordTxt_Leave(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "")
            {
                PasswordTxt.PasswordChar = '\0';
                PasswordTxt.Text = "Password";   
            }
            PasswordTxt.ForeColor = Color.Gray;
        }

    }
}
