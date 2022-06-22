//task #1
const int maxMarkis = 12; //Setting MAX possible value of the mark for the student

byte[,] studentsMarks = { { 10, 11, 8, 7, 9 }, { 5, 7, 6, 7, 8 },{ 11, 10, 10, 12, 9 }, { 8, 9, 7, 6, 6 } };

int bestStudentIndex = 0, worseStudentIndex = 0;
int bestMark, worseMark;
double avarageMark, bestAvarageMark = 0, worseAvarageMark = maxMarkis;


for (int i = 0; i < studentsMarks.GetUpperBound(0) + 1; i++)
{
    avarageMark = 0;
    bestMark = 0;
    worseMark = 10;

    for (int j = 0; j < studentsMarks.GetUpperBound(1)+1; j++)
    {
        avarageMark += studentsMarks[i, j];

        if (bestMark <= studentsMarks[i, j])
        {
            bestMark = studentsMarks[i, j];
        }
        if (worseMark >= studentsMarks[i, j])
        {
            worseMark = studentsMarks[i, j];
        }
    }

    avarageMark = avarageMark / (studentsMarks.GetUpperBound(1) + 1);

    if (bestAvarageMark <= avarageMark)
    {
        bestAvarageMark = avarageMark;
        bestStudentIndex = i;
    }
    if (worseAvarageMark >= avarageMark)
    {
        worseAvarageMark = avarageMark;
        worseStudentIndex = i;
    }

    Console.WriteLine("{0,10} {1,-3} {2,12} {3, -4} {4,10} {5, -3} {6,10} {7, -3}", "Student #", i + 1, "avarage mark", avarageMark, "best mark" , bestMark, "worse mark" , worseMark);

}

Console.WriteLine($"\nThe student #{bestStudentIndex+1} has the best avarage mark {bestAvarageMark}");
Console.WriteLine($"The student #{worseStudentIndex+1} has the best avarage mark {worseAvarageMark}");