namespace HW7;

using System.Text.Json;
using PostNamespace;
using AdminNamespace;
using UserNamespace;

class Program 
{
    static void Main(string[] args)
    {
        List<Admin>? admins;
        List<User>? users;
        List<Post>? posts;

        var adminsFile = File.ReadAllText("Admins.json");
        var usersFile = File.ReadAllText("Users.json");
        var postsFile = File.ReadAllText("Posts.json");

        admins = JsonSerializer.Deserialize<List<Admin>>(adminsFile);
        users = JsonSerializer.Deserialize<List<User>>(usersFile);
        posts = JsonSerializer.Deserialize<List<Post>>(postsFile);

        int choose;
        while(true)
        {
            Console.WriteLine("Enter [1] for Admin, [2] for User");
            choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Enter Username: ");
                string? username=Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                string? email = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                string? password = Console.ReadLine();

                Admin u = new Admin(username!, email!, password!);
            }
            else if (choose == 2)
            {
                Console.WriteLine("Enter Username: ");
                string? username = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                string? email = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                string? password = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                User u= new User(email,username,password,age);

            }
            else continue;
        }
    }
}