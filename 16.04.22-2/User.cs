using System;
using System.Collections.Generic;
using System.Text;

namespace _16._04._22_2
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
                if (value.Length>6)
                {
                    _username = value;

                }
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
                if (CheckPassword(value))
                {
                    _password = value;

                }
                

            }



        }
       
        public  static bool CheckPassword(string password)
        {
            bool HasDgit = false;
            bool HassUpper = false;
            bool HasLower = false;
            bool check = false;


            //// Bu birinci yazdığım Foreach ilə encapsulation'dı


            //foreach (char letter in password)
            //{
            //    if (char.IsUpper(letter))
            //    {
            //        HassUpper = true;
            //    }
            //    if (char.IsDigit(letter))
            //    {
            //        HasDgit = true;
            //    }
            //    if (char.IsLower(letter))
            //    {
            //        HasLower = true;


            //    }

            //}
            //bool Check = HasLower && HassUpper && HasDgit;
            //return Check;


            ////Bu isə For ilə encapsulation'dı


            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    HasLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    HassUpper = true;

                }
                if (char.IsDigit(password[i]))
                {
                    HasDgit = true;
                    
                }
                
                
            }
             check = HassUpper && HasDgit && HasLower;

            return check;








        }
        public User(string username,string pw)
        {
            Username = username;
            Password = pw;

        }
        public   void Info()
        {
            Console.WriteLine($"Usename:{Username},Password{Password}");
        }

    }
}





