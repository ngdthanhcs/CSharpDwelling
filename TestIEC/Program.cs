// See https://aka.ms/new-console-template for more information

using TestIEC;

/*var arr = new int[] { 1, 3, 6, 4, 1, 2 };
Console.WriteLine(DemoTask.Main(arr));*/

/*var arr = new int[] { 2, 7, 4, 6, 3, 1 };
var arr1 = new int[] { -1, 1 };
var arr2 = new int[] { 2, -1 };
var arr3 = new int[] { 1, 2, 4, 3 };
var arr4 = new int[] { -1, -3, 4, 7, 7, 7 };
Console.WriteLine(DivideIntoOddPair.DividePair(arr));
Console.WriteLine(DivideIntoOddPair.DividePair(arr1));
Console.WriteLine(DivideIntoOddPair.DividePair(arr2));
Console.WriteLine(DivideIntoOddPair.DividePair(arr3));
Console.WriteLine(DivideIntoOddPair.DividePair(arr4));*/

//Shortest sub-array
var arr = new int[] {2, 1, 4, 3, 2, 1, 1, 4};
var arr1 = new int[] {1000_000_000, 1, 1, 1, 1, 1, 999_999_999};
var arr2 = new int[] {1, 3, 5, 7};

Console.WriteLine(ShortestSubArrayBetweenLAndR.Solution(arr, 2, 4));
Console.WriteLine(ShortestSubArrayBetweenLAndR.Solution(arr1, 999_999_999, 1000_000_000));
Console.WriteLine(ShortestSubArrayBetweenLAndR.Solution(arr2, 3, 5));
