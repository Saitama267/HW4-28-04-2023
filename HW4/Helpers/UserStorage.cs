using HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW4.Helpers
{
    public static class UserStorage
    {
        public static List<User> Users { get; set; }
        static UserStorage()
        {
            Users = new List<User>();
        }
    }
}
