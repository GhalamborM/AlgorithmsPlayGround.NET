﻿//List<double> unsortedAsc = new() { 0,1,2,3,4,5 };
//List<double> unsortedDesc = new() { 5,4,3,2,1,0 };

//var sortedDesc = Algorithms.NET.Sorting.BubbleSort.BubbleSortAlgorithm.SortDescending(unsortedAsc);
//var sortedAsc = Algorithms.NET.Sorting.BubbleSort.BubbleSortAlgorithm.SortAscending(unsortedDesc);


//foreach(var item in sortedDesc)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();
//foreach (var item in sortedAsc)
//{
//    Console.WriteLine(item);
//}


using Algorithms.NET.Debug;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


var summary = BenchmarkRunner.Run<BenchmarkDemo>();



