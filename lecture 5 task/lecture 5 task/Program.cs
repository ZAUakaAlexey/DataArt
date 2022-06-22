//task 1
Console.WriteLine("Hi! Would you like to read a poem or a joke?\nPlease, enter \"joke\" or \"poem\":");
string literature = Console.ReadLine();
bool isPoem = string.Equals(literature, "poem");
bool isJoke = string.Equals(literature, "joke");
if (isPoem) 
{
    Console.WriteLine("\nYou have chosen a \"poem\". Great choice!\n");
    Console.WriteLine("Shall I compare thee to a summer’s day?");
    Console.WriteLine("Thou art more lovely and more temperate:");
    Console.WriteLine("Rough winds do shake the darling buds of May,");
    Console.WriteLine("And summer’s lease hath all too short a date;");
}
else if (isJoke)
{
    Console.WriteLine("\nYou have chosen a \"joke\". Great choice!\n");
    Console.WriteLine("Two hunters are out in the woods when one of them collapses.");
    Console.WriteLine("He doesn't seem to be breathing and his eyes are glazed.");
    Console.WriteLine("The other guy whips out his phone and calls the emergency services.");
    Console.WriteLine("He gasps, \"My friend is dead! What can I do? \" The operator says, \"Calm down.I can help. First, let's make sure he's dead.\"");
    Console.WriteLine("There is a silence; then a gun shot is heard. Back on the phone, the guy says, \"OK, now what ? \"");
}
else Console.WriteLine("\nYou entered wrong data!");

//task 2
Console.WriteLine("\n\nHi! What time of year were you born?\nPlease enter \"winter\", \"spring\", \"summer\" or \"autumn\":");
string bornSeason = Console.ReadLine();
if (string.Equals(bornSeason, "winter"))
{
    Console.WriteLine("\nWinter is coming \nYou got me running away\nAnd I'll run until the night turns to day\nSummer's long gone, Spring's far away\nAnd I'm listening to sad songs all day");
}
else if (string.Equals(bornSeason, "spring"))
{
    Console.WriteLine("\nWe planted the seed while the tears of our grief soaked the ground");
}
else if (string.Equals(bornSeason, "summer"))
{
    Console.WriteLine("\nSummer time is coming, so get out \nForget all those things that do with doubts");
}
else if (string.Equals(bornSeason, "autumn"))
{
    Console.WriteLine("\nRed leaves falling\nRed leaves falling\nOn the ground\nOn the ground\nAutumn - time is coming\nAutumn - time is coming\nAll around\nAll around");
}
else Console.WriteLine($"Sorry, no such season you had entered \"{bornSeason}\".");

//task 3
string menuAdult = "Old Fashioned, Margarita, Cosmopolitan, Negroni";
string menuForKids = "Chicken Tenders, Burgers, Pizza, Grilled Cheese";
Console.WriteLine("\nHi! Please, enter your age:");

int userAge = int.Parse(Console.ReadLine());

if (userAge < 14)
{
    Console.WriteLine($"We can offer you: {menuForKids}");
}
else if (userAge > 14)
{
    Console.WriteLine($"We can offer you: {menuAdult}");
}
else if (userAge == 14)
{
    Console.WriteLine($"Please, enter what menu do your prefer:\n1 - menu for kids\n2 - adult menu");
    int userChoice = int.Parse(Console.ReadLine());
    if (userChoice == 1)
    {
        Console.WriteLine($"We can offer you: {menuForKids}");
    }
    else if (userChoice == 2)
    {
        Console.WriteLine($"We can offer you: {menuAdult}");
    }
    else Console.WriteLine($"Sorry, no such menu you had entered \"{userChoice}\"");
}

//task 4
Console.WriteLine("\nHi! Please, enter your login:");
string userLogin = Console.ReadLine();
if (userLogin == "admin")
{
    Console.WriteLine("Please, enter your password:");
    string adminPass = Console.ReadLine();
    if (adminPass == "qwe") Console.WriteLine("Hello, ADMIN!!!");
    else Console.WriteLine("Sorry, wrong admin password.");
}
else Console.WriteLine($"Hello, {userLogin}!");
