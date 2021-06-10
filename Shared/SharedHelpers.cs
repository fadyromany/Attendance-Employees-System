using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attendance_Employees_System.Shared
{
    public static class SharedHelpers
    {

        public static string GenerateRandomPassword()
        {
            var length = 10;
            var random = new Random();
            const string chars = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiasdfghjklzxcvbnm!@#$%^&*()=+";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
