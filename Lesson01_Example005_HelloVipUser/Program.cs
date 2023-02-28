Console.WriteLine("Enter your username:");
string username = Console.ReadLine();
if (username.ToLower() == "harry")
{
    Console.WriteLine($"WOW! That's Harry!");
}
else
{
    Console.WriteLine($"Hello, {username}");
}