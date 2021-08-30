using System;

namespace AcessoAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string permission = "Admin|Manage";
            int level = 53;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manage"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have a sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have a sufficient privileges.");
            }
        }
    }
}
