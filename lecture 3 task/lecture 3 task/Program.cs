//task 1
Console.WriteLine("Task 1");
double avarageTemp = (10 + 16.5 + 14.3 + 8) / 4;
Console.WriteLine($"Avarage temperature = {avarageTemp}\n");

//task 2
Console.WriteLine("Task 2");
double avarageCandies = (10 + 15 + 8 + 12) / 4;
Console.WriteLine($"Avarage candies in the box = {avarageCandies}\n");

//task 3
Console.WriteLine("Task 3");
Console.Write("Enter the number of coins :");
int numOfCoins = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of pirates :");
int numOfPirates = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int avarageOfCoins = (numOfCoins - numOfCoins % numOfPirates) / numOfPirates;
Console.WriteLine("Each pirat will earn {0:D} coins\n", avarageOfCoins);

//task 4
Console.WriteLine("Task 4");
Console.Write("Enter the number of hours for the first worker :");
double workerOneHours = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the number of hours for the second worker :");
double workerSecondHours = Convert.ToDouble(Console.ReadLine());

Console.Write("Please, enter hourly rate :");
double hourRate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"The first worker will earn {workerOneHours * hourRate}\n");
Console.WriteLine($"The second one will earn {workerSecondHours * hourRate}\n");

double totalPayment = workerOneHours * hourRate + workerSecondHours * hourRate;
Console.WriteLine($"The total payment is {totalPayment}");