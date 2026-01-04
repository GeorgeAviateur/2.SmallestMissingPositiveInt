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
     * Complete the 'findSmallestMissingPositive' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY orderNumbers as parameter.
     */

    public static int findSmallestMissingPositive(List<int> orderNumbers)
    {
        
       
        
        return 0;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        int orderNumbersCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> orderNumbers = new List<int>();

        for (int i = 0; i < orderNumbersCount; i++)
        {
            int orderNumbersItem = Convert.ToInt32(Console.ReadLine().Trim());
            orderNumbers.Add(orderNumbersItem);
        }

        int result = Result.findSmallestMissingPositive(orderNumbers);

        Console.WriteLine(result);
    }
}
