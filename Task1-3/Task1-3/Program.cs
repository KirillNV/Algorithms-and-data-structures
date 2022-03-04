using System;

namespace Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            SortBubble(myArray);
            for (int i = 0; i < myArray.Length; i++)
            { 
                Console.WriteLine(myArray[i]);
            }
        }

        static int[] SortElections(int[] myArray) // сортировка массива методом выбора
        {//на каждый итерации выбирается элемент с минимальным значением и ставим его в начало  
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < myArray.Length; j++) // цикл сравнивающий i-ный элемент со следующими
                {                                            // и ставит минимальный
                    if (myArray[j] < myArray[min])
                    {
                        min = j;
                    }
                }
                int temp = myArray[min]; // вносим по очереди минимальные элементы
                myArray[min] = myArray[i];
                myArray[i] = temp;
            }
            return myArray;
        }

        static int[] SortInsertion(int[] myArray) // сортировка массива методом вставки
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                int min = myArray[i];
                int j = i;
                while (j > 0 && myArray[j - 1] > min)
                {
                    myArray[j] = myArray[j - 1];
                    j = j - 1;
                }
                myArray[j] = min;
            }
                return myArray;
        }

        static int[] SortBubble(int[] myArray)
        {
            int temp;
            for (int i = 0; i < myArray.Length; i++)// перебор "1-ого" элемента
            {
                for (int j = i + 1; j < myArray.Length; j++)// перебор "2-ого" элемента
                {
                    if (myArray[i] > myArray[j])//сравние близике элементы
                    {                           // первый элемент больше второго, то меняем местами
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            return myArray;
        }
    }
}
