using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public static class Global
    {
        public static string Username { get; private set; }
        public static string Password { get; private set; }

        public static bool IsManager()
        {
            AdminDAO adminDao = new AdminDAO();
            return adminDao.IsManager(Username);
        }
    }
}

