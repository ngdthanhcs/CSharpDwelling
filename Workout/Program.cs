// See https://aka.ms/new-console-template for more information

using System.Text;
using Workout;

/*var numberArr = new int[5][]
{
    new []{1, 1, 0, 0, 0},
    new []{1, 1, 1, 1, 0},
    new []{1, 0, 0, 0, 0},
    new []{1, 1, 0, 0, 0},
    new []{1, 1, 1, 1, 1},
};
Console.WriteLine(KWeakestRow.Main(numberArr, 3));*/

/*Console.WriteLine(IsSubsequence.Main("abc", "ahbgdc"));
Console.WriteLine(IsSubsequence.Main("axc", "ahbgdc"));*/

// -- 1921. Eliminate Maximum Number of Monsters

/*var dist = new int[3] { 1, 3, 4 };
var speed = new int[3] { 1, 1, 1 };
Console.WriteLine(EliminateMaxMonster.EliminateMaximum(dist, speed));

var dist1 = new int[4] { 1, 1, 2, 3 };
var speed1 = new int[4] { 1, 1, 1, 1};
Console.WriteLine(EliminateMaxMonster.EliminateMaximum(dist1, speed1));

var dist2 = new int[3] { 3, 2, 4 };
var speed2 = new int[3] { 5, 3, 2 };
Console.WriteLine(EliminateMaxMonster.EliminateMaximum(dist2, speed2));*/

// 1759. Count number of homogenous substring
//Console.WriteLine(CountNumberOfHomogenousSubstrings.CountHomogenous("abbcccaa"));
//Console.WriteLine(CountNumberOfHomogenousSubstrings.CountHomogenous("xy"));
//Console.WriteLine(CountNumberOfHomogenousSubstrings.CountHomogenous("zzzzz"));

// 338 Counting bits 
/*Helper.WriteArray(CountingBits.CountBits(2));
Helper.WriteArray(CountingBits.CountBits(8));*/

// 1743. Restore arr from adj pair 
/*var adjacentPair = new [3][];*/

// 2642 DesignGraphWithShortestPathCalculator
/*int[][] edges = new int[6][];
var graph = new DesignGraphWithShortestPathCalculator(6, edges);*/

// 815. Bus Routes
/*int[][] routes = {
    new[] { 7, 12 },
    new[] { 4, 5, 15},
    new[] { 6 },
    new[] { 15, 19 },
    new[] { 9, 12, 13 },
    //new[] { 12, 6, 19 }
};
var start = 15;
var target = 12;
Console.WriteLine(BusRoutes.NumBusesToDestination(routes, start, target));*/

//2785 sort vowel in a string AGAIN
/*
var s = "lEetcOde";

Console.WriteLine(SortVowelsInAString.SortVowels(s));
*/
// 1930 -UniqueLength3PalindromeSubsequence 
/*Console.WriteLine(UniqueLength3PalindromeSubsequence.CountPalindromicSubsequence("aabca"));
Console.WriteLine(UniqueLength3PalindromeSubsequence.CountPalindromicSubsequence("bbcbaba"));
Console.WriteLine(UniqueLength3PalindromeSubsequence.CountPalindromicSubsequence("adc"));*/

// 1846 Max element after decreasing and rearranging 
/*var arr = new int[5] {2, 2, 1, 2, 1};
var arr1 = new int[3] {100, 1, 1000};
var arr2 = new int[5] {1, 2, 3, 4, 5};

Console.WriteLine(MaxElementAfterDecreasingAndRearranging.MaxElementAfterModifyArr(arr));
Console.WriteLine(MaxElementAfterDecreasingAndRearranging.MaxElementAfterModifyArr(arr1));
Console.WriteLine(MaxElementAfterDecreasingAndRearranging.MaxElementAfterModifyArr(arr2));*/

//1940 Find unique binary string
var nums = new string[] { "01", 
                          "10" };
var nums1 = new string[] { "00", 
                           "01" };
//Console.WriteLine(FindUniqueBinaryString.FindUnique(nums));
Console.WriteLine(FindUniqueBinaryString.FindUnique(nums1));

/*var sb = new StringBuilder("10");
var s = "00";
Console.WriteLine(FindUniqueBinaryString.XOR(sb, s));*/