using System;

namespace _16._04._22_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string Username;
            string Password;
           
            
            do
            {
                Console.WriteLine(" Please enter Username \n");
                 Username = Console.ReadLine();

            } while (Username.Length<=6);


            do
            {
                Console.WriteLine(" Please Enter Password \n");
                Password = Console.ReadLine();

            } while (!User.CheckPassword(Password));
            Console.WriteLine("Please enter Section");
            string section = Console.ReadLine();

            Console.WriteLine("IssuperAdmin? y/n");

            bool IssuperAdmin = false;

            string Superadmin = Console.ReadLine();
            if (Superadmin.ToLower().Trim()=="y")
            {
                IssuperAdmin = true;
                
                    
         
                    
            }
           
            Admin admin = new Admin(Username,Password,section,IssuperAdmin);
            admin.Info();


        }
    }
}
