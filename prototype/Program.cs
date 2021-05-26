using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(){
                id = 1,
                username = "ozi",
                password = "123"
            };

            User user2 = (User)user1.Clone();
            user2.id = 2;
            user2.username = "torres";
            user2.password = "321";

            Console.WriteLine(user1.GetHashCode());
            Console.WriteLine(user2.GetHashCode());
        }
    }
}
