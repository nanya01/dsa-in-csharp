using System;


namespace dsa
{
   
    class Program
    {
       public  static void Main(string[] args)
        {
            int[] values = { 5, 34, 65, 12, 77, 35 };
            int target = 77;

            /* Array.Sort(values);
             for (int i = 0; i < values.Length; i++)
             {
                 Console.WriteLine(values[i]);
             }
             DsaMethods methods = new DsaMethods();
             int result = methods.binarySearch(values, target);

             Console.WriteLine("Result: " + result);*/
            DsaMethods methods = new DsaMethods();
            methods.bubbleSort(values);

        }
    }

     class DsaMethods
    {
        /*Search algorithms  */
        // Linear search algorithm
        public int linearSearch(int[] values, int target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        public int binarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            
            while(left <= right)
            {
                var middle = (left + right) / 2;

                if (array[middle] == target)
                {
                    return middle;
                }

                if(target < array[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
              
            }
            return -1;
        }
        
        public void bubbleSort(int[] unSortedList)
        {
            int temp;
            for (int i = 0; i < unSortedList.Length-1; i++)
            {
                for (int j = 0; j < unSortedList.Length- (1+i); j++)
                {
                    if(unSortedList[j]  > unSortedList[j + 1]) 
                    {
                        temp = unSortedList[j + 1];
                        unSortedList[j + 1] = unSortedList[j];
                        unSortedList[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array: ");

            for (int i = 0; i < unSortedList.Length; i++)
            {
                Console.WriteLine(unSortedList[i]);
            }
        }
    }
}
