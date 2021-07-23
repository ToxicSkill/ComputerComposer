using System;
using System.Windows.Forms;
using ComputerComposerNsp.Repositories;
using ComputerComposerNsp.Forms;

namespace ComputerComposerNsp
{
    /// <summary>
    /// Login window
    /// </summary>
    public partial class FormLogin : Form
    {
        //creating repository object
        UsersRep usersRepository = new UsersRep();

        /// <summary>
        /// Login form constructor
        /// </summary>
        public FormLogin()
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
        /// Button to log into system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //getting login and password to string varaible
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            //checking if provided data is correct
            bool inLogin = usersRepository.Login(login, password);

            //if user is successfuly logged, setting logged varaible as true and closing logging window
            if (inLogin)
            {
                //assigning login string to program`s variable
                Program.user = textBoxLogin.Text.ToString();
                //setting logged bool variable to true (login and password correct)
                Program.logged = true;
                //closing window
                Close();
            }

            //if logging failed, showing message and reseting logging data
            MessageBox.Show(text: "Login failed. Check login and password");
            //clearing text boxes
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        /// <summary>
        /// Method called after clicking on the website from logging in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //creating new register form and showing it 
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }
    }
}
