using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiviStroki
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
               //Задание(начальное):

               //1.Объявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B.
               double[] A;
               A = new double[5];

               double[,] B = new double[3, 4];
               //Заполнить одномерный массив А числами, введенными с клавиатуры пользователем,
               for (int i = 0; i < 5; i++)
               {
                   A[i] = Int32.Parse(Console.ReadLine());
               }

               //а двумерный массив В случайными числами с помощью циклов.
               var rnd = new Random();
               for (int i = 0; i < B.GetLength(0); i++)
               {
                   for (int j = 0; j < B.GetLength(1); j++)
                   {
                       B[i, j] = rnd.Next(50);
                   }
               }
               // Вывести на экран значения массивов: массива А в одну  строку, массива В – в виде матрицы.
               for (int i = 0; i < 5; i++)
               {
                   Console.Write("{0}\t", A[i]);
               }
               Console.WriteLine();

               for (int i = 0; i < 3; i++)
               {
                   for (int j = 0; j < 4; j++)
                   {
                       Console.Write("{0}\t", B[i, j]);
                   }
                   Console.WriteLine();
               }

               // Найти в данных массивах общий максимальный элемент, минимальный элемент, 
               Console.WriteLine("Макс первого массива - " + A.Max());
               Console.WriteLine("Мин первого массива - " + A.Min());

               double max = 0;
               double min = 51;
                   for (int i = 0; i < 3; i++)
               {
                   for (int j = 0; j < 4; j++)
                   {

                     if((B[i, j].CompareTo(A[j]) )<= 0)
                       {
                           if (max < B[i, j])
                           {
                               max = B[i, j];
                           }
                           if (B[i, j] < min)
                           {
                               min = B[i, j];
                           }

                       }

                   }

               }
               if (max != 0 || min != 51)
               {

                   Console.WriteLine("MAX =" + max + " ___Min = " + min);
               }
               else
               {
                   Console.WriteLine("NON");
               }
       // общую сумму всех элементов,

               double sumA=A.Sum();
               double sumB = 0;
               double sumResult;
               for (int i = 0; i < 3; i++)
               {
                   for (int j = 0; j < 4; j++)
                   {
                       sumB += B[i, j];
                   }
               }
               sumResult = sumA + sumB;
               Console.WriteLine("Сумма всех элементов = " + sumResult);

               // общее произведение всех элементов, 
               double prA = 1;
               for(int i = 0; i < 5; i++)
               {
                   if (A[i] == 0)
                   {
                       i += 1;
                   }
                   else
                   {
                       prA *= A[i];
                   }
               }

               for (int i = 0; i < 3; i++)
               {
                   for (int j = 0; j < 4; j++)
                   {
                       prA *= B[i, j];
                   }
               }


               Console.WriteLine("Произведение всех элементов = " + (String.Format("{0:G}",prA)));

               //сумму четных элементов массива А, 
               sumA = 0;
              for(int i = 0; i < 5; i++)
               {
                   if (A[i] % 2 == 0)
                   {
                       sumA += A[i];
                   }
               }
               Console.WriteLine("Четных элементов сумма = " + sumA);
               //сумму нечетных столбцов массива В.
               sumB = 0;

               for (int i = 0; i < 3; i++)
               {
                   for (int j = 0; j < 4; j++)
                   {
                       if (B[i,j] % 2 != 0)
                       {
                           sumB += B[i, j];
                       }

                   }
               }

               Console.WriteLine("Нечетных элементов сумма = " + sumB);

               #endregion
               
            #region

            //2.Даны 2 массива размерности M и N соответственно.
            //Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.
            int m = 15;
            int n = 16;
            int[] arrA = new int[m];
            int[] arrB = new int[n];
            int[] arrC = new int[n];
            var rnd2 = new Random();
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = rnd2.Next(50);
                Console.Write(arrA[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arrB.Length; i++)
            {
                arrB[i] = rnd2.Next(50);
                Console.Write(arrB[i] + " ");
            }
            Console.WriteLine();

            for (int h = 0; h < arrC.Length; h++)
            {
                arrC[h] = 51;

            }

                for (int h = 0; h < arrC.Length; h++)
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    bool sameEl = false;
                    for (int j = 0; j < arrB.Length; j++)
                    {
                        if (arrA[i] == arrB[j])
                            sameEl = true;
                    }

                    if (sameEl)
                    {
                        Console.Write(arrA[i] + " ");
                        arrC[i] = arrA[i];
                    }
                    
                }
                Console.WriteLine();
               

            }

            Console.WriteLine("-----------------");
            for (int h = 0; h < arrC.Length; h++)
            {
                if (arrC[h] == 51)
                {
                    h++;
                }
                else
                {
                    Console.Write(arrC[h] + " ");
                }
            }
            Console.WriteLine();
            #endregion
           

           
            #region
            //4.Подсчитать количество слов во введенном предложении.
            Console.WriteLine("Введите предложение : ");
            string text = Console.ReadLine();
            var words = text.Split(' ');
            int count = 0;
            foreach( var i in words)
            {
                count++;
            }
            Console.WriteLine("В предложении "+count+" слов(а)");
            Console.WriteLine();

            #endregion
           

            #region
            //5.Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от -100 до 100.
            //Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
            int[,] Massiv = new int[5, 5];

            var rnd3 = new Random();
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Massiv[i, j] = rnd3.Next(-100, 100);
                    Console.Write(Massiv[i, j] + " ");
                }
                Console.WriteLine();
            }
            int size = 25;
            int[] Massiv2 = new int[size];
            int max = 0;
            int min = 100;
            int z = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                Massiv2[z] = Massiv[i, j];
                    z++;  
                 }
            }
            Console.WriteLine();
            for (int h = 0; h < Massiv2.Length; h++)
            {
                Console.Write(Massiv2[h] + " ");
            }
            Console.WriteLine();
            for (int h = 0; h < Massiv2.Length; h++)
            {
                if (Massiv2[h] > max)
                {
                    max = Massiv2[h];
                }
                if (Massiv2[h] < min)
                {
                    min = Massiv2[h];
                }
            }

            Console.WriteLine("MAX - " + max);
            Console.WriteLine("Min - " + min);
            var dMassiv = Massiv2.ToList();
            var indMaximum=dMassiv.IndexOf(max);
            var indMinimum = dMassiv.IndexOf(min);
            Console.WriteLine(indMaximum + "  Index Max");
            Console.WriteLine(indMinimum + "   Ind Min");
            int sumRes = 0;
           
                if (indMinimum < indMaximum)
                {
                for (int h = indMinimum+1; h <indMaximum; h++)
                  sumRes += Massiv2[h];
                }
                else
                {
                for (int h = indMaximum+1; h < indMinimum; h++)
                    sumRes += Massiv2[h];
                  }

            Console.WriteLine("Сумма элементов массива, расположенных между минимальным и максимальным элементами = " + sumRes);



            #endregion


        }
    }
}
