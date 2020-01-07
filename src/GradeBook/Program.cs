using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Program
    {
       static void Main(string[] args){
           
        List<double> marks =  new List<double>(){3.4, 2, 4.5};
        double result = 0;
        double average = 0;
        marks.Add(5.1);
        
        foreach (var mark in marks)
        {
            result += mark;
        }

        average = result/marks.Count;
        Console.WriteLine(result +"  "+ average);
       }
    }
}
