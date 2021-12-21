// Sort Class
using System;

namespace ObjectBubbleSortProj
{
    public class Sort
    {
        // Field
        private decimal[] theArray;

        // Constructor
        public Sort(decimal[] sort)
        {
            this.theArray = sort;
        }

        // Property
        public decimal[] TheArray
        {
            get
            {
                return theArray;
            }
            set
            {
                theArray = value;
            }
        }

        // Method
        public Array SortingMethod()
        {
            for (int i = 0; i <= TheArray.Length - 1; i++)
            {
                // Temp int variable to hold value in
                decimal temp;

                // Swap out adjacent value by order,
                // till completed.
                for (int j = 0; j < TheArray.Length - 1; j++)
                {
                    if (TheArray[j] > TheArray[j + 1])
                    {
                        temp = TheArray[j + 1];
                        TheArray[j + 1] = TheArray[j];
                        TheArray[j] = temp;
                    }
                }
            }
            // Return ascending array list
            return TheArray;

        }

        // Method
        public Array BacSortingMethod()
        {
            for (int i = 0; i <= TheArray.Length - 1; i++)
            {
                // Temp int variable to hold value in
                decimal temp;

                // Swap out adjacent value by order,
                // till completed.
                for (int j = 0; j < TheArray.Length - 1; j++)
                {
                    if (TheArray[j] < TheArray[j + 1])
                    {
                        temp = TheArray[j + 1];
                        TheArray[j + 1] = TheArray[j];
                        TheArray[j] = temp;
                    }
                }
            }

            //Return descending array list
            return TheArray;
        }
    }

}
