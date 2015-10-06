using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSorting
{
    public class Sorting
    {
        private const int MIN_BOUNDARY = -10;
        private const int MAX_BOUNDARY = 10;
        private const int ARRAY_SIZE = 20;
        Random random = new Random();

        private int[] actualArray = new int[ARRAY_SIZE];
        private int[] array;

        public Sorting()
        {
            for (int i = 0; i < actualArray.Length; i++)
            {
                this.actualArray[i] = random.Next(MIN_BOUNDARY, MAX_BOUNDARY);
            }

        }

        public Sorting(int[] array, int n)
        {
            this.array = new int[n];
            for (int i = 0; i < n; i++)
            {
                this.array[i] = array[i];
            }
        }

        public int[] getActualArray()
        {
            return actualArray;
        }

        public int[] getArray()
        {
            return array;
        }
        
              

        public int[] bubbleSort(int[] array) 
        {
            bool already = alreadySorted(array);
            if (already == true)
            {
                return array;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }

            return array;
        }





        public int[] gnomeSort(int[] array)
        {
            bool already = alreadySorted(array);
            if (already == true)
            {
                return array;
            }

            int i = 1;
            int j = 2;

            while (i < array.Length)
            {
                if (array[i - 1] < array[i])
                {
                    i = j;
                    j = j + 1;
                }
                else
                {
                    int tmp = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = tmp;
                    i = i - 1;
                }
                if (i == 0)
                {
                    i = j;
                    j = j + 1;
                }


            }
            return array;
        }


        public int enterCountOfNumber()
        {
            int n = 0;
            bool flag = true;

            while (flag)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, enter count of elements. It is must be not bigger than 30");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 31)
                    {
                        Console.WriteLine("Number must be less than 30");
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter the number");
                }
            }
            return n;

        }
                              

        public int[] enterArray()
        {
            int n = enterCountOfNumber();
            int[] array = new int[n];
            int count = 0;
            bool flag = true;

            Console.WriteLine();
            Console.WriteLine("Please, enter the elements of array");

            for (int i = 0; i < array.Length;)
            {
                while (flag)
                {
                    try
                    {
                        if (count >= n)
                        {
                            break;
                        }
                        if (flag == true)
                        {
                            array[i] = Convert.ToInt32(Console.ReadLine());
                            count++;
                            i++;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Enter the number");
                    }
                }
                
            }

            return array;
        }

        public bool alreadySorted(int[] array)
        {
            int count = 0;
            try {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        if (i == (array.Length - 1))
                        {
                            count++;
                        }
                        count++;
                    }
                }
            } catch (IndexOutOfRangeException ex)
            {

            }

            if (count == array.Length -1)
            {
                Console.WriteLine();
                Console.WriteLine("Already sorted");
                return true;
            }
            return false;
        }


        public void printArray(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


    }
}

