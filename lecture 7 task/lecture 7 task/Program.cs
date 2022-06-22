// task #1

int GetNumberFromUserRanged (int min, int max)
{
    int userInput;
    while (true)
    {
        Console.WriteLine($"Please input or number in range from {min} to {max}:");
        userInput = int.Parse(Console.ReadLine());

        if (userInput >= min && userInput <= max)
        {
            Console.WriteLine($"Thank you. You entered {userInput}");
            break;
        }
        else 
        {
            Console.WriteLine($"\nYou must eneter an integer number more then {min} and less then {max}\n");
        }
    }
    return userInput;
};

int age = GetNumberFromUserRanged(10, 50);

//task #2

int numberOfStudents = 2; // Input number of student here

for (int i = 1; i <= numberOfStudents; i++)
{
    Console.WriteLine($"\nHello, student #{i}!!!");
    Console.WriteLine($"Your group is {GetGroupNumberByAgeAndExp()}");
    
}

int GetGroupNumberByAgeAndExp()
{
    Console.WriteLine("Please eneter your age here");
    int studentAge = GetNumberFromUserRanged(10, 60);

    Console.WriteLine("Please enter 1 if you have experience or 0 if not ");
    int studentExp = GetNumberFromUserRanged(0,1);

    if (studentExp == 0 && studentAge <= 18 )
    {
        return 1;
    }
    else if (studentExp == 1 && studentAge <= 18 )
    {
        return 2;
    }
    else if (studentExp == 0 && studentAge > 18 )
    {
        return 3;
    }
    else if (studentExp == 1 && studentAge > 18 )
    {
        return 4;
    }

    return 0;
};

// task #3

double Calculator(double firstNum, double secondNum, char operand)
{
    double resultOfCalc;

    switch (operand)
    {
        case '+':
            resultOfCalc = firstNum + secondNum;
            break;
        case '-':
            resultOfCalc = firstNum - secondNum;
            break;
        case '*':
            resultOfCalc = firstNum * secondNum;
            break;
        case '/':
            resultOfCalc = firstNum / secondNum;
            break;
        default:
            resultOfCalc = 0;
            break;
    }

    return resultOfCalc;
}


Console.WriteLine("{0:N2}",Calculator(2, 35, '+')); //testing operands
Console.WriteLine("{0:N2}",Calculator(2, 35, '-'));
Console.WriteLine("{0:N2}",Calculator(5, 2, '/'));
Console.WriteLine("{0:N2}",Calculator(2,35,'*'));


double DaysBetweenDates(int year1, int month1, int day1, int year2, int month2, int day2)
{
    DateTime date1 = DateTime.Parse($"{year1}/{month1}/{day1}");
    DateTime date2 = DateTime.Parse($"{year2}/{month2}/{day2}");

    return (date1 - date2).TotalDays;
}

Console.WriteLine($"\nDays:{DaysBetweenDates(2022, 12, 30, 2022, 12, 10)}"); //20day between date1 and date2