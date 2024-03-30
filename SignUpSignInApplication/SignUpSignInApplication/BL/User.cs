using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpSignInApplication
{
    internal class User
    {
        private string Username;
        private string Password;
        private string Role;
        public User(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
        public User(string username,string password)
        {
            this.Username = username;
            this.Password = password;
            this.Role = "NA";

        }
        public string GetUserName()
        { return this.Username; }
        public string GetPassword() { return this.Password;}
        public string GetRole() 
        { return this.Role;}
        public bool IsAdmin()
        {
            if(this.Role == "Admin")
                return true;
            return false;
        }
    }
}
