//Task #1

var listToDo = new List<string>() { "awake", "take a shower", "breakfast", "walk with dog", "dulingo", "dataArt", "itgid"};
var listDone = new List<string>();
StringComparison comp = StringComparison.OrdinalIgnoreCase;


// main loop
do
{
    Console.Clear();
    Console.WriteLine("TASK #1\n");
    ShowTasks(listToDo, listDone);

    Console.WriteLine("\nPlease, enter task, or 'stop' to finish");
    var input = Console.ReadLine();

    if (input.Equals("stop", comp))
    {
        break;
    }

    AddNewTask(input);
    ShowTasks(listToDo, listDone);

} while (true);

//Task #1 methods

void AddNewTask(string str)
{
    if (str.Equals("stop"))
    {
    }
    if (listToDo.Contains(str))
    {
        listDone.Add(str);
        listToDo.Remove(str); 
    }
    else
    {
        listToDo.Add(str);
    }
}
void ShowTasks(List<string> list1, List<string> list2 )
{
    var count1 = list1.Count();
    var count2 = list2.Count();
    var maxCount = (count1 >= count2) ? count1 : count2;

    Console.WriteLine("{0,-3}{1,-20}{2,-20}", "#","ToDo", "DONE");
    for (var i=0; i<maxCount; i++)
    {
        if (i < count1 & i <count2)
        {
            Console.WriteLine("{0,-3}{1,-20}{2,-20}", i, listToDo[i], listDone[i]);
            continue;
        }
        else if ((i >= count1 & i < count2))
        {
            Console.WriteLine("{0,-3}{1,-20}{2,-20}", i, "", listDone[i]);
            continue;
        }
        else if ((i < count1 & i >= count2))
        {
            Console.WriteLine("{0,-3}{1,-20}{2,-20}", i, listToDo[i], "");
        }
    }

    if (list1.Count == 0)
    {
        Console.WriteLine("\n!!! Here is nothing to do for now !!!");
    }

}

//===============================================================================================================================//
//Task #2

var studentSrores = new List<int>() { 11, 8, 10 };

// main loop
do
{
    Console.Clear();
    Console.WriteLine("TASK #2");
    ShowStudentScores(studentSrores);

    Console.WriteLine("\nPlease, enter score, or 'stop' to finish");
    var input = Console.ReadLine();

    if (input.Equals("stop", comp))
    {
        break;
    }

    studentSrores.Add(int.Parse(input));
    ShowStudentScores(studentSrores);

} while (true);

//Task #2 methods
void ShowStudentScores(List<int> inputlist)
{
    var output = string.Empty;
    int min = inputlist[0];
    int max = inputlist[0];
    float sum = 0;

    foreach (var score in inputlist)
    {
        output += score + " ";
        sum += score;
        min = (score < min) ? score : min;
        max = (score > max) ? score : max;
    }

    float avarage = sum / inputlist.Count;

    Console.WriteLine($"\nAll scores are: {output}\n");
    Console.WriteLine("{0,-5}{1,-5}{2,-5}","MIN", "MAX", "AVG");
    Console.WriteLine("{0,-5}{1,-5}{2,-5:F2}", min, max, avarage);
}

//===============================================================================================================================//
//Task #3

Console.WriteLine("TASK #3");
var guestsList = new Dictionary<string, List<int>>();

//main loop
do
{
    var inputName = AskGuestName();
    if (inputName.Equals("stop", comp))
    {
        break;
    }
    
    int inputAge = AskGuestAge(inputName);
    
    var currentGuest = new List<int>();
    currentGuest.Add(inputAge);
    currentGuest.Add(ChooseRoom(inputAge));
    guestsList.Add(inputName, currentGuest);

} while (true);

Console.Clear();
Console.WriteLine($"We have {guestsList.Count} total guests for now");
ShowAllGuests(guestsList,1);
ShowAllGuests(guestsList,2);
ShowAllGuests(guestsList,3);

//===============================================================================================================================//
//Task #3 methods
string AskGuestName()
{
    Console.WriteLine("Please, enter Name of next guest or 'stop' to finish");
    var inputString = Console.ReadLine();

    return inputString;
}

int AskGuestAge(string name)
{
    while (true)
    {
        Console.WriteLine($"Input {name}'s age, please, like integer:");
        var input = Console.ReadLine();
        bool result = int.TryParse(input, out int age);

        if (result)
        {
            return age;
        }
        else
        {
            Console.WriteLine($"Wrong input! You must enter {name}'s age like an integer, please");
        }
    }
}

int ChooseRoom (int num)
{
    int result=0;

    if (num < 18)
    {
        result = 1;
    }
    else if (num >= 20 & num <=50)
    {
        result = 2;
    }
    else if (num > 50)
    {
        result = 3;
    }

    return result;
}

void ShowAllGuests(Dictionary<string, List<int>> dict1, int num )
{
    int count = 0;
    Console.WriteLine($"\nList of the guest located in the {num} hall:");
    Console.WriteLine("{0,-3}{1,-30}{2,-3:N2}", "#", "Guest", "Age");
    foreach (var guest in dict1)
    {
        if (guest.Value[1] == num)
        {
            Console.WriteLine("{0,-3}{1,-30}{2,-3:D2}", count+1, guest.Key,guest.Value[0]);
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine($"\n---Sorry, no guests in the #{num} hall---");
    }
    else
    {
        Console.WriteLine($"\nWe have {count} total guests in the #{num} hall");
    }
}

//===============================================================================================================================//
// Task #4

var classesList = new Dictionary<string, List<int>>();

// main loop
do
{
    ShowClasses();

    Console.WriteLine("\nPlease, input the class name");
    string input = Console.ReadLine();

    if (input.Equals("stop", comp))
    {
        break;
    }
    else
    {
        AskForClasses(input);
    }
   

} while (true);

//Task #4 methods
void AskForClasses(string str)
{
    if (classesList.ContainsKey(str))
    {
        int inputScore = AskForScore(str);
        
        classesList[str].Add(inputScore);
        Console.WriteLine($">>Adding {inputScore} to the {str} classe score");
    }
    else
    {
        classesList.Add(str, new List<int>());
        Console.WriteLine($"\n!!! Adding new class >>>{str}<<<");

        int inputScore = AskForScore(str);
        classesList[str].Add(inputScore);
    }
}

int AskForScore(string name)
{
    while (true)
    {
        Console.WriteLine($"Please, input score for the >>>{name}<<< classe like integer:");
        var input = Console.ReadLine();
        bool result = int.TryParse(input, out int score);

        if (result)
        {
            return score;
        }
        else
        {
            Console.WriteLine($"You entered the wrong value > {input}.\n You must enter score like an integer, please");
        }
    }
}

void ShowClasses()
{
    Console.Clear();
    Console.WriteLine("TASK #4\n");

    if (classesList.Count == 0)
    {
        Console.WriteLine("Sorry! We have NO records for now!\n");
        return;
    }
    else
    {
        Console.WriteLine("We have next classes and avarage scores for them:\n");
        Console.WriteLine("{0,-3}{1,-30}{2,-5:F2}", "#", "Class Name", "Avarage Score");
        int count = 1;

        foreach (var item in classesList)
        {
            Console.WriteLine("{0,-3}{1,-30}{2,-5:F2}",count, item.Key, GetAvarage(item.Value));
            count++;
        }
    }

    
}

float GetAvarage (List<int> inputList)
{
    float sum = 0;

    foreach (var item in inputList)
    {
        sum += item;
    }

    return sum/inputList.Count;
}