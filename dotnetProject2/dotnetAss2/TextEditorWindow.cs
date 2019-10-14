using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetAss2
{
    /*Text Editor Window: Allow users to create, save and edit text documents here. 
    *                     Text Documents can be either viewed, modified or created
    *                     based on Usertype (Edit/View). 
    */
    public partial class TextEditorWindow : Form
    { 
        public LoginForm loginForm;
        private string currentFile = "";
        private bool saved = false;

        //receive username and usertype from LoginForm as parameter
        public TextEditorWindow(string username, string usertype)
        {
            InitializeComponent();
            Tusername.Text = "User Name: " + username;
            Testlabel.Text = "";
            FontSize.SelectedIndex = 2;
            //Only allow Editing for users who has Edit Usertype 
            if (usertype == "View")
                RichTB.ReadOnly = true;
        }

        /* Intialise the rich text box allowing users to start new Text Editing
         * Ask If the user wants to save the file when the file hasn't been saved. 
         */
        private void NewFile()
        {
            if(!saved)
            {
                DialogResult result = MessageBox.Show("The File is Not Saved. \nDo you want to save?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
            }
            RichTB.Text = "";
            currentFile = "";
        }

        /* Allow users to open existing file.
         * File extension should be .rtf (rich text file format)
         */
        private void OpenFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            string filename = "";
            openFile.Title = "Open a Text File";
            openFile.Filter = "Rich Text File (*.rtf)| *.rtf";
            DialogResult dr = openFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filename = openFile.FileName;
                MessageBox.Show("The File Selected was:" + filename);
                currentFile = openFile.FileName;
            }
            try
            {
                RichTB.LoadFile(filename);
            }
            catch(Exception e)
            {
                Testlabel.Text = e.Message;
            }
        }

        /* Allow users to Save the Text file.
         * Ask user to type filename if it's first time to save.
         * once user save as new name, user can override to existing file.
         */
        private void SaveFile()
        {
            if (currentFile == "")
                SaveAsFile();
            else
            {
                if (File.Exists(currentFile))
                {
                    File.Delete(currentFile);
                    RichTB.SaveFile(currentFile, RichTextBoxStreamType.RichText);
                    saved = true;
                    MessageBox.Show("File is succeessfully saved in "+currentFile+ "! ","Save",MessageBoxButtons.OK);
                }
                else
                {
                    Testlabel.Text = "Error occured while saving the file.";
                }
            }
            
        }

        // Allow Users to save the text file with new name.
        private void SaveAsFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Rich Text File (*.rtf)| *.rtf";
            DialogResult dr = saveFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                RichTB.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
                currentFile = saveFile.FileName;
            }
            saved = true;
        }

        //Cut the selected text (can paste) 
        private void Cut()
        {
            if (RichTB.SelectedText != "")
            {
                Clipboard.SetText(RichTB.SelectedText);

                RichTB.SelectedText = "";
            }
        }

        //Copy the selected text 
        private void Copy()
        {
            if (RichTB.SelectedText != "")
            {
                Clipboard.SetText(RichTB.SelectedText);
            }
        }

        //Paste the copied or cut text (saved in clipboard)
        private void Paste()
        {
            if (Clipboard.ContainsText())
            {
                RichTB.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }

        //call About Form for information about the program
        private void Help()
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void TextEditorWindow_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Tusername_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void New_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void NewM_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OpenM_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveM_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveAsM_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void CutM_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void CopyM_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void PasteM_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void RichTB_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        //Change the selected text or text user is going to type to Bold textstyle
        private void Bold_Click(object sender, EventArgs e)
        {
            if (RichTB.SelectionFont != null)
            {
                System.Drawing.Font currentFont = RichTB.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (RichTB.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                RichTB.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        //Change the selected text or text user is going to type to Italic textstyle
        private void Italic_Click(object sender, EventArgs e)
        {
            if (RichTB.SelectionFont != null)
            {
                System.Drawing.Font currentFont = RichTB.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (RichTB.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                RichTB.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        //Change the selected text or text user is going to type to Underlined textstyle
        private void Underline_Click(object sender, EventArgs e)
        {
            if (RichTB.SelectionFont != null)
            {
                System.Drawing.Font currentFont = RichTB.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (RichTB.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }

                RichTB.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        //Change the font size of the selected text or text user is going to type.
        private void FontSize_Click(object sender, EventArgs e)
        {
            if (RichTB.SelectionFont != null)
            {
                System.Drawing.Font currentFont = RichTB.SelectionFont;
                float fontSize = 10.0f;
                if (FontSize != null)
                    fontSize = float.Parse(FontSize.Text);

                RichTB.SelectionFont = new Font(
                   currentFont.FontFamily,
                   fontSize,
                   currentFont.Style
                );
            }
        }

        private void AboutM_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void about_Click(object sender, EventArgs e)
        {
            Help();
        }
    }
}
