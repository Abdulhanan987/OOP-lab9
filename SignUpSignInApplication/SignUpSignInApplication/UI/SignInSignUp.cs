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
    public partial class SignInSignUp : Form
    {
        public SignInSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign_Up myForm = new Sign_Up();
            this.Hide();
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_In myForm = new Sign_In();
            this.Hide();
            myForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
