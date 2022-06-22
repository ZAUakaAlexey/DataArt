//Task #1

var boxList = new List<int>() { 1, 7, 20, 13, 9, 5, 4, 17, 10, 15, 19, 4, 1, 4, 2, 3, 8, 29, 18 };

var listLess5 = boxList.Where(box => box < 5).ToList();
var listLess15 = boxList.Where(box => box < 15).ToList();
var listMore15 = boxList.Where(box => box >= 15).ToList();

Console.WriteLine($"The total weight of the boxes less than 5 is {CalcBoxesWeight(listLess5)}");
Console.WriteLine($"The total weight of the boxes less than 15 is {CalcBoxesWeight(listLess15)}");
Console.WriteLine($"The total weight of the boxes more than 15 is {CalcBoxesWeight(listMore15)}");

int CalcBoxesWeight(List<int> inputList)
{
    int total = 0;
    foreach (var box in inputList)
    {
        total += box;
    }
    return total;
}

//Task #2

var scores = new Dictionary<string, int>()
    {
        { "matematika", 10 },
        { "himiya", 8 },
        { "literatura", 5 },
        { "geografiya", 4 },
        { "fizika", 9 },
        { "fiz-ra", 11 }
    };

var needToRetake = scores.Where(score => score.Value < 6);

Console.WriteLine("\n\nYou need to retake the next classes:\n");

foreach (var score in needToRetake)
{
    Console.WriteLine("{0,-20}{1,2}",score.Key,score.Value);
}