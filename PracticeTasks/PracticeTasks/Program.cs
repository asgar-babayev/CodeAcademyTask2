using System;

namespace PracticeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.Write("Array-a ölçü verin: ");
            //int arrSize = Convert.ToInt32(Console.ReadLine());
            //if (arrSize > 0)
            //{
            //    int[] arr = new int[arrSize];
            //    for (int i = 0; i < arrSize; i++)
            //    {
            //        Console.Write(i + ". " + "elementi daxil edin: ");
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    int minEl = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //        if (arr[i] < minEl) minEl = arr[i];

            //    Console.WriteLine("Arrayın ən kiçik elementi {0}", minEl);
            //}
            //else
            //    Console.WriteLine("Arrayın ölçüsü 0 ya da mənfi ola bilməz");
            //Console.ReadKey();
            #endregion

            #region Task 2
            //string input = Console.ReadLine();
            //bool isHaveSymbol = false;
            ////int count = 0;                         <--Əgər a simvolunun sayını tapmaq istəsək count-dan istifadə edə bilərik.-->
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == 'a')
            //    {
            //        //count++;
            //        isHaveSymbol = true;
            //        break;  
            //    }
            //}
            //Console.WriteLine($"a simvolu varsa true, yoxdursa false qaytarır: {isHaveSymbol}");
            ////Console.WriteLine($"Mətndəki a simvolunun sayı = {count}");
            //Console.ReadKey();
            #endregion

            #region Additional task
            //Console.Write("Array-a ölçü verin: ");
            //int arrSize = Convert.ToInt32(Console.ReadLine());
            ////int temp = 0;
            //if (arrSize > 0)
            //{
            //    int[] arr = new int[arrSize];
            //    for (int i = 0; i < arrSize; i++)
            //    {
            //        Console.Write(i + ". " + "elementi daxil edin: ");
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        for (int k = j; k < arr.Length; k++)
            //        {
            //            if (arr[j] > arr[k])
            //            {
            //                //    temp = arr[k];
            //                //    arr[k] = arr[j];
            //                //    arr[j] = temp;
            //                arr[j] = arr[k] + arr[j];
            //                arr[k] = arr[j] - arr[k];
            //                arr[j] = arr[j] - arr[k];
            //            }

            //        }
            //    }
            //    foreach (var el in arr)
            //        Console.WriteLine(el);
            //    
            //}
            #endregion
        }
    }
}