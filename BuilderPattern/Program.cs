using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User.UserBuilder("Rahul", "Jaiswal")
                .SetAge(10)
                .SetPhone("8979813900")
                .Build();

            Console.WriteLine(user.GetFirstName() + " " + user.GetLastName());

            Console.ReadKey();
        }
    }
}
