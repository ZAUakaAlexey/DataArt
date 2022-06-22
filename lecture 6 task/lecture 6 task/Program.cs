// task #1

int ammount = 100;

while (ammount > 0)
{
    Console.WriteLine($"\nCurrent ammount is {ammount} in warehouse");
    Console.WriteLine("Please input load for current car:");
    int loadCurrentCar = int.Parse(Console.ReadLine());

    if (loadCurrentCar > ammount)
    {
        Console.WriteLine($"We have not enough goods in our warehouse to load {loadCurrentCar} on your request");
        continue;
    }

    ammount -= loadCurrentCar;
    Console.WriteLine("\n");
}

Console.WriteLine($"The warehouse is empty, there is {ammount} ammount in it");

// task #2

int rightAnswer = 42,
    usernaswer;

Console.WriteLine("\n\nHello username! \nI need you to answer for 'The Ultimate Question of Life, the Universe, and Everything.'");

do
{
    Console.WriteLine("Please, input your answer:");
    usernaswer = int.Parse(Console.ReadLine());
    if (usernaswer > rightAnswer)
    {
        Console.WriteLine("\nYou're wrong. You need input less\n");
    } 
    else if (usernaswer < rightAnswer)
    {
        Console.WriteLine("\nYou're wrong. You need input more\n");
    }

} while (usernaswer != rightAnswer);

Console.WriteLine($"\nCongrats!!!\nThe answer is {rightAnswer}...");

// task #3

for (int i = 1; i < 6; i++)
{
    Console.WriteLine($"Please, enter the name of the guest #{i}");
    string userName = Console.ReadLine();
    Console.WriteLine($"Nice to see you, {userName}\n");
}

Console.WriteLine("Ok, all guests are here, so we can start");


// task #4

for (int i = 1; i < 4; i++)
{
    for (int j = 1; j < 6; j++)
    {
        Console.WriteLine($"Please, enter the name of the guest:");
        string userName = Console.ReadLine();
        Console.WriteLine($"Nice to see you, {userName}, your table is #{i}\n");
    }
}

Console.WriteLine("All tables are full, so we can start...");

// task #5

int roomChild = 0,
    roomAdult = 0,
    roomAge = 0;

string stopWord = "stop";

do
{
    Console.WriteLine("Please, input your name:");
    string userName = Console.ReadLine();

    if (userName == stopWord)
    {
        break;
    }

    Console.WriteLine($"Hello, {userName}! Please, tell us your age:");
    int userAge = int.Parse(Console.ReadLine());
    if (userAge < 18)
    {
        roomChild++;
    }
    else if (userAge >=18 && userAge <= 50)
    {
        roomAdult++;
    }
    else if (userAge > 50)
    {
        roomAge++;
    }

} while (true);

Console.WriteLine($"We have total guests: {roomChild+roomAge+roomAdult}");
Console.WriteLine($"We have {roomChild} guests less then 18yo");
Console.WriteLine($"We have {roomAdult} guests from 18yo to 50yo");
Console.WriteLine($"We have {roomAge} guests more then 50yo");