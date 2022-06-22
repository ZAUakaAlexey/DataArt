string studentsByString = "Ivan Ivanov: 12, Petr Petrov: 8, Olga Sidorova: 5, Test Testovich: 14";
int lowestScore = 5;
int maxStudent = 30; 

studentsByString = FirstInput(); //you can comment this line to skip manual input and work with default string
ShowList(studentsByString);
ShowListToRetake(studentsByString, lowestScore);
AddStudent();

int ShowList (string str)
{
    int studCount = 0;
    string[] list = str.Split(',');

    Console.WriteLine("\nList of the students:");
    Console.WriteLine("{0,-2}{1,-30}{2,-3}", "#", "Student", "Score");
    foreach (string item in list)
    {
        string studentName = GetStudentName(item);
        int studentScore = GetStudentScore(item);
        Console.WriteLine("{0,-2}{1,-30}{2,-3}",studCount, studentName, studentScore);
        studCount++;
    }

    Console.WriteLine();
    return studCount;
}

string GetStudentName(string str)
{
    try
    {
        return str.Substring(0, str.IndexOf(':')).Trim();
    }
    catch 
    {
        Console.WriteLine("!!!!WRONG input!!!");
        throw;
    }
    
}

int GetStudentScore (string str)
{
    string sToNumber = str.Substring((str.IndexOf(':') + 1));
    int res = -1;
    try
    {
        res=int.Parse(sToNumber);
    }
    catch 
    {
        Console.WriteLine("!!!NOT A NUMBER!!!");
        throw;
    }
    
    return res;
}

void ShowListToRetake(string str, int value)
{
    int count = 0;
    string[] list = str.Split(',');

    Console.WriteLine($"List of the students with score less then {value}:");
    Console.WriteLine("{0,-2}{1,-30}{2,-3}", "#", "Student", "Score");

    foreach (string item in list)
    {
        int studentScore = GetStudentScore(item.Substring((item.IndexOf(':') + 1)));

        if (studentScore < value)
        {
            string studentName = GetStudentName(item);
            Console.WriteLine("{0,-2}{1,-30}{2,-3}",count, studentName, studentScore);
            count++;
        }
    }
    Console.WriteLine();
}

void AddStudent()
{
    int check = 0;
    while (check <= maxStudent)
    {
        Console.WriteLine($"Max number of student is {maxStudent}");
        Console.WriteLine("Please, enter new student in format %name %surname : %score OR enter 'stop'");
        string newStudent = Console.ReadLine();

        StringComparison comp = StringComparison.OrdinalIgnoreCase;

        if (newStudent.Contains("stop",comp))
        {
            Console.WriteLine("\n\n!!!STOP!!! detected");
            break;
        }

        if (newStudent.IndexOf(':') != -1)
        {
            string newName = GetStudentName(newStudent);
            int newScore = GetStudentScore(newStudent);

            if (studentsByString.Contains(newName, comp))
            {
                int indexOfName = studentsByString.IndexOf(newName, comp);
                int indexTwoDots = studentsByString.IndexOf(':', indexOfName + newName.Length);
                int indexOfComa = studentsByString.IndexOf(',', indexOfName);
                string ss = studentsByString.Substring((indexTwoDots + 1), (indexOfComa - indexTwoDots - 1));
                int checkScore = GetStudentScore(ss);

                if (newScore != checkScore)
                {
                    string newList = studentsByString.Remove(indexTwoDots + 1, ss.Length);
                    studentsByString = newList.Insert(indexTwoDots + 1, newScore.ToString());
                }


                Console.Clear();
                check = ShowList(studentsByString);
                ShowListToRetake(studentsByString, lowestScore);
            }
            else
            {
                studentsByString += "," + newStudent;
                Console.Clear();
                check = ShowList(studentsByString);
                ShowListToRetake(studentsByString, lowestScore);
            }
        }
        else
        {
            Console.WriteLine("You must enter ':' ");
        }
    }
}

string FirstInput ()
{
    Console.WriteLine("Please, input list of students in format %name %surname : %score separated by coma");
    Console.WriteLine("For Example: Ivan Ivanov: 12, Petr Petrov: 8, Olga Sidorova: 5, Test Testovich: 14");

    return Console.ReadLine();
}

