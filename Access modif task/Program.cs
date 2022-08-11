using Access_modif_task.access_modifie;
using System;

namespace Access_modif_task
{
    class Program
    {
        static void Main(string[] args)
        {
            User Kamran = new User();
            Console.WriteLine("Please enter \"Username\" (note that Username can be min 6 max 25 characters)");
            Kamran.UserName = Console.ReadLine();
            Console.WriteLine(Kamran.UserName);
            Console.WriteLine("please enter \"Password\" (note that this Password can be min 8 max 25 characters and must contain at least 1 uppercase, 1 lowercase letter and a number)");
            Kamran.Pasword = Console.ReadLine();
            Console.WriteLine(Kamran.Pasword);
        }


    }
}
