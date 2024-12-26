using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Principal;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: 

            // int[,] Numbers = new int[2, 2];

            //for (int i=0;i<2;i++) {


            //    for (int j=0;j<2;j++) {
            //   Console.WriteLine($"Enter numbers[{i},{j}]");
            //      Numbers[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.Clear();
            //for (int i = 0; i<2; i++)
            //{


            //    for (int j = 0; j<2; j++)
            //    {
            //        Console.WriteLine($"{ Numbers[i,j]}");

            //    }
            //}
            #endregion

            #region Q2: Write a program in C# Sharp to find the sum of all elements


            //int[] Numbers02 = new int[3] { 1, 3, 5 };

            //int Result = 0;

            //for (int i=0;i<Numbers02.Length;i++) {

            //    Result+=Numbers02[i];
            //}

            //Console.WriteLine($"the sum of elemnts ::\n{Result}");


            #endregion


            #region Q3: 
            //Write a program in C# Sharp to merge two arrays of the same size
            //sorted in ascending order




            //int[] array1 = { 1, 2, 3 };
            //int[] array2 = { 4, 5, 6 };


            //int[] mergedArray = array1.Concat(array2).ToArray();


            //Console.WriteLine("Merged Array: ");
            //foreach (int number in mergedArray)
            //{
            //    Console.Write(number + " ");
            //}


            #endregion



            #region Q4:
            // Write a program in C# Sharp to count the frequency of each element
            //of an array. 

            //int Size;
            //bool Flag;

            //do
            //{
            //    Console.WriteLine("please enter the size of array");
            //    Flag =int.TryParse(Console.ReadLine(), out Size);

            //} while (!Flag);

            //Console.Clear();
            //int[] Array01 = new int[Size];
            //int[] Freq = new int[Size];



            //for (int i = 0; i<Size; i++) {
            //    Console.WriteLine($"enter the numbers {i+1}");
            //    int.TryParse(Console.ReadLine(), out Array01[i]);
            //    Freq[i]=-1;
            //}

            //Console.Clear(); 

            //int Y, Counter = 0;


            //for (int i=0;i<Size;i++) {

            //    Counter=1;

            //    for (Y=i+1;Y<Size;Y++) {
            //        if (Array01[i]==Array01[Y]) {

            //            Counter++;
            //            Freq[Y]=0;


            //        }

            //        if (Freq[i]!=0) {

            //            Freq[Y]=Counter;

            //        }


            //    }


            //}


            //for (int i=0;i<Size;i++) {
            //    Console.WriteLine($" the number :{Array01[i]} Have Freq {Freq[i]}");


            //}

            #endregion

            #region Q5:
            //Write a program in C# Sharp to find maximum and minimum element in
            //an array

            //int Size01;
            //bool Flag;

            //do
            //{
            //    Console.WriteLine("please enter the size of array");
            //    Flag =int.TryParse(Console.ReadLine(), out Size01);

            //} while (!Flag);

            //Console.Clear();
            //int[] Array02 = new int[Size01];


            //for (int i = 0; i<Size01; i++)
            //{

            //    bool IsValid;
            //    do
            //    {
            //        Console.WriteLine($"Number{i+1} is :");
            //        IsValid=int.TryParse(Console.ReadLine(), out Array02[i]);
            //        if (!IsValid)

            //            Console.WriteLine("invalid input!!!enter again");

            //    } while (!IsValid);
            //}
            //    int Max= Array02[0];
            //    int Min = Array02[0];

            //    for (int i = 1; i < Size01; i++)
            //    {
            //        if (Array02[i] > Max)
            //        {
            //            Max = Array02[i];
            //        }
            //        if (Array02[i] < Min)
            //        {
            //            Min = Array02[i];
            //        }
            //    }




            //        Console.WriteLine( $"The max numbr in array{Max}");
            //    Console.WriteLine($"The min numbr in array{Min}");






            #endregion


            #region Q6:
            //Write a program in C# Sharp to find the second largest element in an
            //array.



            #endregion

            #region Q7:

            //int Size00;
            //bool Flag;

            //do
            //{
            //    Console.WriteLine("please enter the size of array");
            //    Flag =int.TryParse(Console.ReadLine(), out Size00);

            //} while (!Flag);

            //Console.Clear();
            //int[] Array02 = new int[Size00];

            //for (int i = 0; i<Size00; i++)
            //{

            //    bool IsValid;
            //    do
            //    {
            //        Console.WriteLine($"Number{i+1} is :");
            //        IsValid=int.TryParse(Console.ReadLine(), out Array02[i]);
            //        if (!IsValid)

            //            Console.WriteLine("invalid input!!!enter again");

            //    } while (!IsValid);
            //}

            //    int Distance = 0;

            //    for (int i = 0; i<Size00; i++) {
            //    for (int j = i+1; j<Size00; j++)

            //        if (Array02[i]==Array02[j])
            //            if (Distance<j - i - 1)
            //                Distance=j - i - 1;


            //    }

            //Console.WriteLine($"{Distance}");
            #endregion


            #region Q11

            //Console.WriteLine("Enter the size of the array:");
            //int size;
            //while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

           
            //int[] array = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter element {i + 1}:");
            //    while (!int.TryParse(Console.ReadLine(), out array[i]))
            //    {
            //        Console.WriteLine("Invalid input. Please enter an integer:");
            //    }
            //}

            
            //Console.WriteLine("\nOriginal Array:");
            //foreach (int element in array)
            //{
            //    Console.Write(element + " ");
            //}

            
            //Console.WriteLine("\n\nReversed Array:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
                #endregion



            }
    }
    }
            

