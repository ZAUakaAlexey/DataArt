// task #1 
// для устновки точки "останова" необходимо в крайнем левом поле рабочей области ИДЕ нажать ЛКМ напротив интересуемой
// строки кода, идикатор ввиде белого круга окрасится в красный.

// task #2
// F5 - запуск процесса дебагинга, F10 - следующая строка кода БЕЗ захода в методы, F11 - следующая строка кода
// с переходом в код метода, Shift+F11 - завершает текущий метод

//task #3
//Тип - System.FormatException
//Описание - Input string was not in a correct format.

//task #4
//Locals




int userAge = 0;

while (true)
{
    try
    {
        Console.WriteLine("Please, input your age:");
        userAge = int.Parse(Console.ReadLine());
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Please Enter your age as integer!!!\nThank you!");
        //throw;
        //throw new Exception("Wrong age format!");
    }
}
Console.WriteLine($"Thank you for your answer {userAge}");