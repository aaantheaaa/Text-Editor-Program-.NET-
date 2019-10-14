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
    /* New User Form: Allow users to input details needed for registratrion
     */
    public partial class NewuserForm : Form
    {
        public LoginForm loginForm;
        public string[] login_f;

        public NewuserForm()
        {
            InitializeComponent();
            RMessageBox.Text = "";

            //date selection option restrict and set format
            Rdate.Format = DateTimePickerFormat.Custom;
            Rdate.CustomFormat = "dd-MM-yyyy";
            Rdate.MaxDate = DateTime.Today;
        }

        private void NewuserForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rusertype_Click(object sender, EventArgs e)
        {

        }

        private void RMessageBox_Click(object sender, EventArgs e)
        {

        }

        //put placeholders when the textbox is empty 
        private void RusernameTxt_Enter(object sender, EventArgs e)
        {
            if (RusernameTxt.Text == "Username")
                RusernameTxt.Text = "";
            RusernameTxt.ForeColor = Color.Black;
        }

        private void RusernameTxt_Leave(object sender, EventArgs e)
        {
            if (RusernameTxt.Text == "")
                RusernameTxt.Text = "Username";
            RusernameTxt.ForeColor = Color.Gray;
        }

        private void RpasswordTxt_Enter_1(object sender, EventArgs e)
        {
            if (RpasswordTxt.Text == "Password")
                RpasswordTxt.Text = "";
            RpasswordTxt.ForeColor = Color.Black;
        }

        private void RpasswordTxt_Leave(object sender, EventArgs e)
        {
            if (RpasswordTxt.Text == "")
                RpasswordTxt.Text = "Password";
            RpasswordTxt.ForeColor = Color.Gray;
        }

        private void RrepasswordTxt_Enter(object sender, EventArgs e)
        {
            if (RrepasswordTxt.Text == "Re-enter Password")
                RrepasswordTxt.Text = "";
            RrepasswordTxt.ForeColor = Color.Black;
        }

        private void RrepasswordTxt_Leave(object sender, EventArgs e)
        {
            if (RrepasswordTxt.Text == "")
                RrepasswordTxt.Text = "Re-enter Password";
            RrepasswordTxt.ForeColor = Color.Gray;
        }

        private void RfirstnameTxt_Enter(object sender, EventArgs e)
        {
            if (RfirstnameTxt.Text == "First Name")
                RfirstnameTxt.Text = "";
            RfirstnameTxt.ForeColor = Color.Black;
        }

        private void RfirstnameTxt_Leave(object sender, EventArgs e)
        {
            if (RfirstnameTxt.Text == "")
                RfirstnameTxt.Text = "First Name";
            RfirstnameTxt.ForeColor = Color.Gray;
        }

        private void RlastnameTxt_Enter(object sender, EventArgs e)
        {
            if (RlastnameTxt.Text == "Last Name")
                RlastnameTxt.Text = "";
            RlastnameTxt.ForeColor = Color.Black;
        }

        private void RlastnameTxt_Leave(object sender, EventArgs e)
        {
            if (RlastnameTxt.Text == "")
                RlastnameTxt.Text = "Last Name";
            RlastnameTxt.ForeColor = Color.Gray;
        }

        private void Rdate_ValueChanged(object sender, EventArgs e)
        {

        }

        //submit button > register new user/ save user details in the text file
        private void SubmitB_Click(object sender, EventArgs e)
        {
            if (register())
            {
                DialogResult result = MessageBox.Show("\tRegisteration Successful!\n\nWelcome, "+RfirstnameTxt.Text+" "+RlastnameTxt.Text+"\nDo you want to go back to the Login page?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    NewuserForm newuserForm = new NewuserForm();
                    newuserForm.Show();
                    this.Hide();
                }
                else if (result == DialogResult.Yes)
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
            }
            else {
                //initialise the form
                RusernameTxt.Text = "Username";
                RpasswordTxt.Text = "Password";
                RrepasswordTxt.Text = "Re-enter Password";
                RfirstnameTxt.Text = "First Name";
                RlastnameTxt.Text = "Last Name";
                Rdate.Value = DateTime.Today;
                RusertypeT.Text = "Select";
            }
        }

        private bool register()
        {
            string msg = "";
            //check if there is empty value
            if (RfirstnameTxt.Text == "First Name")
                msg += "First name must be filled out.\n";
            if (RlastnameTxt.Text == "Last Name")
                msg += "Last name must be filled out.\n";
            if (Rdate.Value == DateTime.Today)
                msg += "Date of Birth must be selected. \n";
            if (RusertypeT.Text == "Select")
                msg += "Usertype must be selected.\n";
            if (RusernameTxt.Text == "Username")
                msg += "Username must be filled out.\n";
            if (RpasswordTxt.Text == "Password")
                msg += "Password must be filled out.\n";
            if (RrepasswordTxt.Text == "Re-enter Password")
                msg += "Re-entered Password must be filled out.\n";
            //check existing username
            if (exists(RusernameTxt.Text))
                msg += "The username is already existing. Please try different username.";
            //check if password matches
            if (RpasswordTxt.Text != RrepasswordTxt.Text)
                msg += "Re-entered Password does not match.";
            RMessageBox.Text = msg;
            try
            {
                if (msg == "")
                {
                    File.AppendAllText("login.txt", "\n" + RusernameTxt.Text + "," + RpasswordTxt.Text + "," + RusertypeT.Text + "," + RfirstnameTxt.Text + "," + RlastnameTxt.Text + "," + Rdate.Text);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                RMessageBox.Text = "Error! " + e.Message;
                return false;
            }
        }

        //checking existing Id to prevent using duplicated ID
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

        private void RpasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RfirstnameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
