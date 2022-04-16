using System;
using System.Collections.Generic;
using System.Text;

namespace _16._04._22_2
{
    class Admin : User
    {
      

        public Admin(string username, string pw, string section, bool issuperAdmin) : base(username, pw)
        {
            Section = section;
            IssuperAdmin = issuperAdmin;
        }

        public bool IssuperAdmin { get; set; }
        public string Section { get; set; }
        
        public  void Info()
        {
            Console.WriteLine($"Username:{Username},Password{Password},Section{Section},{(IssuperAdmin ?  "Superadmindir" : "SuperAdmindeyil")}");


        }


    }
}
