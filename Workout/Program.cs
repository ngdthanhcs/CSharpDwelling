// See https://aka.ms/new-console-template for more information

using Workout;

var numberArr = new int[5][]
{
    new []{1, 1, 0, 0, 0},
    new []{1, 1, 1, 1, 0},
    new []{1, 0, 0, 0, 0},
    new []{1, 1, 0, 0, 0},
    new []{1, 1, 1, 1, 1},
};
Console.WriteLine(KWeakestRow.Main(numberArr, 3));