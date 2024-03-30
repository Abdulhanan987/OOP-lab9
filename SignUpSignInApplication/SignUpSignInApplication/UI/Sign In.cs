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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
           // button1.Text
             //   = "OK";
        }
       // int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          string username = Username.Text;
            string password = Password.Text;
            User user = new User(username, password);
            User user1 = UserDL.SignIn(user); 
           if(user1!=null)
            {
                MessageBox.Show(user1.GetRole());
            }
           else
            {
                MessageBox.Show("This user is not present in the record");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          SignInSignUp signInSignUp = new SignInSignUp();
            this.Hide();
            signInSignUp.ShowDialog();
        }
    }
}
