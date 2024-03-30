using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpSignInApplication
{
    internal class UserDL
    {
        private static List<User> Users = new List<User>();
        public static void AddData(User user)
        { 
            Users.Add(user); 
        }
        public static User SignIn(User user)
        {
           Users = RetrieveData();
            foreach (User storedusers in Users)
            {
                if(storedusers.GetUserName()==user.GetUserName()&& storedusers.GetPassword() == user.GetPassword()) 
                {
                    return storedusers;
                }
            }
            return null;
        }
        public static List<User> GetUsers()
        {
            return Users;
        }
        public static void AddDataIntoDB(User user)
        {
            string conn = "Data Source = ABDULHANANPC\\SQLEXPRESS11;Database = SignSignUpDesktop;Integrated security= true";
            string query = String.Format("Insert into MUser(Username,Password,Role)" + " values('{0}','{1}','{2}')", user.GetUserName(),user.GetPassword(),user.GetRole());
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand sql = new SqlCommand(query, sqlConnection);
            sql.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public static List<User> RetrieveData()
        { List<User> users = new List<User>();  
            string conn = "Data Source = ABDULHANANPC\\SQLEXPRESS11;Database = SignSignUpDesktop;Integrated security= true";
            string query = "Select * from MUser ";
            SqlConnection sqlConnection = new SqlConnection( conn );
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                User user = new User(Convert.ToString(reader["Username"]), Convert.ToString(reader["Password"]), Convert.ToString(reader["Role"]));
                users.Add(user);
            }
            return users;
        }

    }
}
