using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1/
            Console.WriteLine("Task 1.");
            Console.WriteLine();

            int[] arr = { 1, 2, 3, 3, 33, 4, 44, 7, 9, 0, 12, 134 };

            string uniqStr = "";
            int countUniq = 0;
            int countEvenValues = 0;
            int countNotEvenValues = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(arr, arr[i]) == i)
                {
                    uniqStr += arr[i];
                    countUniq++;

                    if (i < arr.Length - 1)
                    {
                        uniqStr += ", ";
                    }
                }

                if (arr[i] % 2 == 0)
                {
                    countEvenValues += 1;
                }
                else
                {
                    countNotEvenValues += 1;

                }

            }

            Console.WriteLine($"Array {string.Join(",", arr)}");
            Console.WriteLine($"Uniq value {uniqStr}. Count uniq value : {countUniq} .");
            Console.WriteLine($"Event values : {countEvenValues}, not event values : {countNotEvenValues}");

            //task 2/
            Console.WriteLine();
            Console.WriteLine("Task 2.");
            Console.WriteLine();

            int[] arr1 = { 1, 33, 2, 4, 45, 7, 77, 8, 88 };

            Console.WriteLine("Enter number :");
            Console.WriteLine();

            int checkNum = int.Parse(Console.ReadLine());
            int countTask2 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < checkNum)
                {
                    countTask2++;
                }
            }

            Console.WriteLine($"Array : {string.Join(",", arr1)}");
            Console.WriteLine($"Number of values that are less than your number : {countTask2}");

            //task 3/
            Console.WriteLine();
            Console.WriteLine("Task 3.");
            Console.WriteLine();

            string taskStr = "13386859401326456867861862";

            Console.WriteLine("Enter sequence numbers :");

            string sequence = Console.ReadLine();

            int countRepet = 0;

            for (int i = 0; i < taskStr.Length - sequence.Length; i++)
            {
                string str = "";

                for (int j = i; j < sequence.Length + i; j++)
                {
                    str += taskStr[j];

                }

                if (str.CompareTo(sequence) == 0)
                {
                    countRepet++;
                }
            }

            Console.WriteLine($"String : {taskStr}");
            Console.WriteLine($"Number of repetition sequentce {sequence} is :{countRepet}.");

            //task 4/
            Console.WriteLine();
            Console.WriteLine("Task 4.");
            Console.WriteLine();

            int[] arr1Tas4 = { 1, 2, 3, 3, 4, 2, 5, 6, 7, 8, 9 };

            int[] arr2Tas4 = { 1, 11, 2, 12, 13, 14, 15 };

            List<int> tempArr = new List<int>();
            List<int> newArrTask4 = new List<int>();

            for (int i = 0; i < arr1Tas4.Length; i++)
            {
                if (Array.IndexOf(arr1Tas4, arr1Tas4[i]) == i)
                {
                    tempArr.Add(arr1Tas4[i]);
                }
            }

            for (int i = 0; i < arr2Tas4.Length; i++)
            {
                if (Array.IndexOf(arr2Tas4, arr2Tas4[i]) == i)
                {
                    tempArr.Add(arr2Tas4[i]);
                }
            }

            foreach (var num in tempArr)
            {
                if (!newArrTask4.Contains(num))
                {
                    newArrTask4.Add(num);
                }
            }

            Console.WriteLine($"First array : {string.Join(",", arr1Tas4)}");
            Console.WriteLine($"Second array : {string.Join(",", arr2Tas4)}");
            Console.WriteLine($"New array : {string.Join(",", newArrTask4)}");

            //task 5/
            Console.WriteLine();
            Console.WriteLine("Task 5.");
            Console.WriteLine();

            int sizeRow = 5;
            int sizeCol = 15;
            int[,] arrTask5 = new int[sizeRow, sizeCol];

            Random rnd = new Random();

            for (int i = 0; i < sizeRow; i++)
            {
                for (int j = 0; j < sizeCol; j++)
                {
                    arrTask5[i, j] = rnd.Next(1, 101);
                }
            }

            int maxValue = arrTask5[0, 0];
            int minValue = arrTask5[0, 0];

            for (int i = 0; i < sizeRow; i++)
            {
                for (int j = 0; j < sizeCol; j++)
                {
                    maxValue = (arrTask5[i, j] > maxValue) ? arrTask5[i, j] : maxValue;
                    minValue = (arrTask5[i, j] < minValue) ? arrTask5[i, j] : minValue;

                }
            }

            for (int i = 0; i < sizeRow; i++)
            {
                for (int j = 0; j < sizeCol; j++)
                {
                    Console.Write(arrTask5[i, j]);
                    Console.Write(' ');

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Max value : {maxValue}, min value {minValue}.");


            Console.WriteLine();
            Console.WriteLine("Task 6.");
            Console.WriteLine();

            Console.WriteLine("Enter sentece :");
            string strTask6 = Console.ReadLine();

            int countWords = 0;
            bool counter = true;
            Char[] arrTask6 = { ' ', '?', '!', '.' };

            for (int i = 0; i < strTask6.Length; i++)
            {

                if (arrTask6.Contains(strTask6[i]))
                {
                    if (counter)
                    {
                        countWords++;
                        counter = false;
                    }
                }
                else
                {
                    counter = true;
                }
            }
            Console.WriteLine($"Number words in this sentence {countWords}.");

            Console.WriteLine();
            Console.WriteLine("Task 7.");
            Console.WriteLine();

            Console.WriteLine("Enter sentece :");

            string strTask7 = Console.ReadLine();
            string[] words = strTask7.Split(' ');
            string temp = "";
            foreach (string word in words)
            {
                char[] charArr = word.ToCharArray();
                Array.Reverse(charArr);
                string RewersWord = new string(charArr);
                temp += (RewersWord + " ");
            }
            string result = temp.TrimEnd();
            Console.Write("Reversed sentence:");
            Console.WriteLine(result);

            Console.WriteLine();
            Console.WriteLine("Task 8.");
            Console.WriteLine();

            Console.WriteLine("Enter sentece :");

            string strTask8 = Console.ReadLine();
            string[] wordsTask8 = strTask8.Split(' ');
            int countVowels = 0;

            foreach (string word in wordsTask8)
            {
                char[] charsFromWord = word.ToCharArray();

                for (int i = 0; i < charsFromWord.Length; i++)
                {
                    if (char.ToUpper(charsFromWord[i]) == 'A' || char.ToUpper(charsFromWord[i]) == 'E' || char.ToUpper(charsFromWord[i]) == 'I' || char.ToUpper(charsFromWord[i]) == 'O' || char.ToUpper(charsFromWord[i]) == 'U' || char.ToUpper(charsFromWord[i]) == 'Y')
                    {
                        countVowels++;
                    }
                }
            }

            Console.WriteLine($"In this sentence has :{countVowels} vowels");

            Console.WriteLine();
            Console.WriteLine("Task 9.");
            Console.WriteLine();

            Console.WriteLine("Enter sentece :");
            string sentenceTask9 = Console.ReadLine();

            Console.WriteLine("Enter sequence :");
            string sequenceTask9 = Console.ReadLine();

            string[] senteceArr = sentenceTask9.Split(' ');

            int countRepetTask9 = 0;

            foreach (string word in senteceArr)
            {
                if (senteceArr.Contains(sequenceTask9))
                {
                    countRepetTask9++;
                }
            }

            Console.WriteLine($"Found : {countRepetTask9} repietitions.");

            Console.ReadLine();
        }
    }
}
