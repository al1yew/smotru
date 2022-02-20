using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class User
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                string error1 = "Daxil edilen username sehvdir, minimum 8 elementden ibaret olmalidir.";
                if (value.Length >= 8)
                {
                    _username = value;
                    return;
                }
                Console.WriteLine(error1);
            }
        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                string b = "Password minimum 8 elementden ibaret olmalidir";

                if (value.Length >= 8)
                {
                    foreach (char item in value)
                    {
                        if (((int)item >= 48 && (int)item <= 57) && ((int)item >= 65 && (int)item <= 90) && ((int)item >= 97 && (int)item <= 122))
                        {
                            _password = value;
                        }
                    }
                    return;
                }
                Console.WriteLine(b);
            }
        }
        public string GetFullName()
        {
            return $"{Username},{Password} - sizin daxil etdiyiniz melumatdir";
        }
    }
}
