using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetAss2
{
    public partial class AboutForm : Form
    {
        //Constructor
        public AboutForm()
        {
            InitializeComponent();
            //set the about text label 
            text.Text = 
                "             Welcome to Text Editor! \n\n" +
                "You can create, save and edit text documents here.\n" +
                "Text Documents can be either viewed, modified or created \n" +
                "based on Usertype (Edit/View). \n\n" +
                "Made by: Seul Lee (13331879)\n\n" +
                "           14-10-2019";
        }

        //OK button to close the window
        private void Okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_Click(object sender, EventArgs e)
        {

        }
    }
}
