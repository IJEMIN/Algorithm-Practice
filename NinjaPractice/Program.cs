using System;
using System.Collections.Generic;

namespace NinjaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomGeneratedValues = new List<int>();
            
            var randomGenerator = new Random();
            
            var randomCount = randomGenerator.Next(3,10);

            for (var i = 0; i < randomCount; i++)  {
                randomGeneratedValues.Add(randomGenerator.Next(-100,100));
            }
            
            
            //new SelectionSort().Run();

            new BinarySearch().Run(randomGeneratedValues.ToArray(), randomGeneratedValues[randomGenerator.Next(0,randomCount)]);
        }
    }
}