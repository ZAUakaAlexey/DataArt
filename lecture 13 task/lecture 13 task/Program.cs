// Task 1

var favoriteSongCoup =
    "Now under siege have the real strength to hold them now\nHave to believe that we can repel them\n" +
    "Faith in the years our ancestors taught us\nHave the belief that we can protect the wall";

char[] separators = new char[] { ' ', '.', ',', '\n' };

string[] subs = favoriteSongCoup.Split(separators, StringSplitOptions.RemoveEmptyEntries);

List<string> coupByWords = new List<string>();

coupByWords.AddRange(subs);

// Task #1a
ShowList(coupByWords.Where(w => w.Length > 4).ToList(), "words with lenght more then 4");

// Task #1b
ShowList(coupByWords.Where((w) => w.Length > 4).
        Where((w) => w.Length < 8).ToList(), "words with lenght more then 4 and less then 8");

// Task #1c
ShowList(coupByWords.OrderBy((w) => w).
        OrderBy((w) => w.Length).ToList(), "ordered by lenght and if equal length then by alphabet");

// Task  #1d
Console.WriteLine("The longest word is : ",coupByWords.OrderByDescending((w) => w.Length).First());

// Task #1e
ShowList(coupByWords.OrderBy((w) => w).ToList(), "Ordered by alphabet");
ShowList(coupByWords.OrderBy((w) => w).Take(3).Skip(2).ToList(), "the 3rd word is");

// Task #1 method
void ShowList(List<string> list, string caption)
{
    Console.WriteLine($"{caption}\n");
    var count = 1;
    foreach (var item in list)
    {
        Console.WriteLine("{0,-3}{1,15}",count,item);
        count++;
    }
    Console.WriteLine("{0,18}","=========987654321\n");
}

Console.WriteLine("\n\n!!!All task from TASK #1 are completed!!!");
Console.WriteLine("Press any key to continue...");
Console.ReadKey(true);
Console.Clear();

//========================================================================================================//

// Task #2

var students = new Dictionary<string, double>() {
        { "Ivanov", 10.4 },
        { "Petrova", 9.2 },
        { "Sidorenko", 6.9 },
        { "Irpinova", 11.2 },
        { "Petrusenko", 8.2 },
        { "Kolubko", 7.8 },
        { "Kravchenko", 8.7 },
        { "Brakova", 5.0 },
        { "Arbuzov", 5.9 },
        { "Avarin", 6.9 },
        { "Latunin", 8.3 },
        { "Mirosin", 4.9 },
        { "Gladchenko", 7.7 },
        { "Bruskov", 9.8 },
    };

// Task #2a

Console.WriteLine("Task #2a answers\n");
ShowDictionary(students.Where(std => std.Value > 10).
            OrderBy(std => std.Key).
            ToDictionary(p => p.Key, p => p.Value), "Avarage scrore > 10");

ShowDictionary(students.Where(std => std.Value > 7).
            Where(std => std.Value < 9).
            OrderBy(std => std.Key).
            ToDictionary(p => p.Key, p => p.Value), "Avarage scrore 7-9");

ShowDictionary(students.Where(std => std.Value < 7).
            OrderBy(std => std.Key).
            ToDictionary(p => p.Key, p => p.Value), "Avarage scrore < 7");

// Task #2b

Console.WriteLine("Task #2b answer\n");
var listTask2b = students.Where(std => std.Value < 6).Count();
Console.WriteLine((listTask2b > 0) ? "We have students that needed to retake exams": "no students to retake exams");
Console.WriteLine("========================\n");


// Task #2c

Console.WriteLine("Task #2c answer\n");

var listTask2c = students.Where(std => std.Value < 5);

Console.WriteLine("they won't get a certificate:\n");

foreach (var student in listTask2c)
{
    Console.WriteLine(student.Key);
}
Console.WriteLine("========================\n");

//Task #2d

Console.WriteLine("Task #2d answer\n");

var exellStd = students.Where(std => std.Value > 10).
            OrderBy(std => std.Key).
            ToDictionary(p => p.Key, p => p.Value).Count;

Console.WriteLine($"We have {exellStd} students in honor roll");

Console.WriteLine("========================\n");

//Task #2e

Console.WriteLine("Task #2e answer\n");

var studWith11 = students.Where(std => std.Value > 11).
            ToDictionary(p => p.Key, p => p.Value).Count;

Console.WriteLine((exellStd == studWith11) ? "All exellent students will receive honours degree" :
                                                "Not All exellent students will receive honours degree");

// Task #2 methods

void ShowDictionary(Dictionary<string, double> dict, string caption)
{
    Console.WriteLine($"{caption}\n");
    var count = 0;

    foreach (var item in dict)
    {
        count++;
        Console.WriteLine("{0,-4}{1,-15}{2,-3}", count, item.Key, item.Value);
        
    }
    Console.WriteLine("========================\n");
}
