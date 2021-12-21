// Console Print Bubble Sort Ascending & Descending
using System;

namespace ObjectBubbleSortProj
{
    internal class Program
    {
        static void Main()
        {
            // CREATE RANDOM OBJECT FROM RANDOM CLASS
            Random random = new Random();

            // Decimal Array with 56 elements
            decimal[] theArray = new decimal[55];
                       
            // Copy the Arrays
            decimal[] ascendingArray = new decimal[theArray.Length];
            decimal[] descendingArray = new decimal[theArray.Length];
            
            // Declare integer i for iterations
            int i = 0;

            // CREATING RANDOM NUMBER LIST
            // Do loop to add random numbers
            do
            {
                theArray[i] = (random.Next(1, 1000));
                i++;

            } while (i < theArray.Length);

            // Copy the Array before Sorting
            Array.Copy(theArray, ascendingArray, theArray.Length);
            Array.Copy(theArray, descendingArray, theArray.Length);

            // Create object from Sort Class
            Sort sort = new Sort(theArray);
            Sort sort2 = new Sort(ascendingArray);

            Console.WriteLine("Now Ascending:");
            int j = 0;

            // Execute Method from Ojbects class: THE FORWARD ARRAY
            // ASCENDING SORT CALL
            sort.SortingMethod();

            // For each element in the array print to console
            foreach (decimal number in theArray)
            {
                Console.Write($"{ascendingArray[j]}\t < RAW | SORTED >\t ");
                Console.WriteLine(number + "\n");
                j++;
            }

            Console.WriteLine("\nNow Decending:\n");
            j = 0;

            // Execute Method from Ojbects class: THE REVERSED ARRAY
            // DESCENDING SORT CALL                     
            sort2.BacSortingMethod();
            
            // For each element in the array print to console
            foreach (decimal number in theArray)
            {
                Console.Write($"{ascendingArray[j]}\t < RAW | SORTED >\t ");
                Console.WriteLine(number + "\n");
                j++;
            }
        }
    }
} 