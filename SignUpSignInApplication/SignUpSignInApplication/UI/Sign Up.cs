using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpSignInApplication.UI
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            string role = this.role.Text;
            User user = new User(username,password,role);
            UserDL.AddData(user);
            UserDL.AddDataIntoDB(user);
            MessageBox.Show("User Added");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Username_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SignInSignUp signInSignUp = new SignInSignUp();
            this.Hide();
            signInSignUp.Show();
        }
    }
}
