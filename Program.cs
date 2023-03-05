using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int hourglassSum(List<List<int>> arr)
    {
        int sum = 0;
        int maxValue = int.MinValue;
        for (int i = 0; i < arr.Count - 2; i++) // interaction after lenght list
                                                // -2 the last elements will not make a hourglass
        {
            for (int j = 0; j < arr[i].Count - 2; j++)
            {
                sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]  // 3 element
                          + arr[i + 1][j + 1]                           // 1 element 
                          + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]; // 3 elementy 
                maxValue = Math.Max(sum, maxValue);
            }
        }
        return maxValue;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        Console.WriteLine(result);

     
    }
}
