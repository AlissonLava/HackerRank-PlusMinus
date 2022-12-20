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

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        float countPos = 0;
        float countNeg = 0;
        float countZer = 0;


        foreach (int num in arr)
        {

            if (num > 0)
            {
                countPos++;
            }
            if (num < 0)
            {
                countNeg++;
            }
            if (num == 0)
            {
                countZer++;
            }
        }


        float propPos = countPos / arr.Count;
        float propNeg = countNeg / arr.Count;
        float propZer = countZer / arr.Count;

        Console.WriteLine($"{propPos:0.000000}");
        Console.WriteLine($"{propNeg:0.000000}");
        Console.WriteLine($"{propZer:0.000000}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
