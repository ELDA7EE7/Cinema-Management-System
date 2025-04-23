using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Project
{
    internal static class CurrUser
    {
        
        public static string Username { get; set; }
        public static int UserId { get; set; }
        public static Boolean IsAdmin { get; set; }
        public static void Logout()
        {
            Username = null;
            UserId = 0;
        }
        public static void LogIn(string username, int userId, bool isAdmin)
        {
            Username = username;
            UserId = userId;
            IsAdmin = isAdmin;
        }
    }
}
