using System;
using System.Windows.Forms;
using ComputerComposerNsp.Repositories;

namespace ComputerComposerNsp.Forms
{
    /// <summary>
    /// Register window
    /// </summary>
    public partial class FormRegister : Form
    {
        //Creating new users repository
        UsersRep usersRep = new UsersRep();

        /// <summary>
        /// Register form constructor
        /// </summary>
        public FormRegister()
        {
            InitializeComponent();

            //setting start position as in a center
            StartPosition = FormStartPosition.CenterScreen;
            //setting password char as a standard star
            textBoxPassword.PasswordChar = '*';
            //setting max length of password as 12
            textBoxPassword.MaxLength = 12;
        }

        /// <summary>
        /// Button to register new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //checking if length of strings are correct
            if (textBoxLogin.Text.Length < 3 || textBoxPassword.Text.Length < 6)
            {
                //showing message if strings are too short
                MessageBox.Show("Login or password are too short.");
                textBoxPassword.Text = "";
            }
            else // if length is correct
            {
                //calling method for register new user
                if (usersRep.Register(textBoxLogin.Text, textBoxPassword.Text))
                    //registration successful
                    MessageBox.Show("Registration successful. Use your new accout for log in.");
                else
                    //registration failed
                    MessageBox.Show("Something went wrong. Try later.");
                //closing window
                Close();
            }
        }
    }
}
