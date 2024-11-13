using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public static class Data
    {
        public static string username;
        public static ERoleLogin role;
    }
}


public enum ERoleLogin
{
    admin,
    employ,
    cadidate
}