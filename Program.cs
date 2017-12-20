using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //•	Напечатать весь массив целых чисел
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Массив целых чисел");
            Console.ForegroundColor = ConsoleColor.White;
            int[] num = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
                                    foreach(int i in num) { 
                                        Console.Write(i+" ");
                                    }
                                    Console.WriteLine();
                        #endregion
                        //•	Найти индекс максимального значения в массиве
                        #region
                        int indMax = num.Max();
                                    Console.WriteLine("Индекс максималного числа = "+indMax);
                        #endregion
                        // •	Найти индекс максимального четного значения в массиве
                        #region
                        int indMaxC =num.Max();
                                    if ((indMaxC % 2) == 0)
                                    {
                                        Console.WriteLine("Индекс максималного четного числа = " + indMaxC);
                                    }
                                    else
                                    {
                                        indMaxC -= 1;
                                        Console.WriteLine("Индекс максималного четного числа = " + indMaxC);
                                    }
            #endregion
                        //•	Удалить элемент из массива по индексу.
                        #region
                        Console.WriteLine("Введите индекс для удаление");

                                  int poisk=Int32.Parse(Console.ReadLine());

                                   var temp=num.ToList();
                                    temp.RemoveAt(poisk);
                                    num = temp.ToArray();
                                    foreach(int i in num)
                                    {
                                        Console.Write(i + " ");
                                    }

                                    Console.WriteLine();

                        #endregion
                        //•	Удаление элементов из массива по значению
                        #region
                        Console.WriteLine("Введите значение для удаление");

                                    int poisk2 = Int32.Parse(Console.ReadLine());

                                    var temp2 = num.ToList();
                                    poisk2=temp2.IndexOf(poisk2);
                                    temp2.RemoveAt(poisk2);

                                    num = temp2.ToArray();
                                    foreach (int i in num)
                                    {
                                        Console.Write(i + " ");
                                    }

                                    Console.WriteLine();

                        #endregion
                        //•Вставить элемент в массив по индексу
                        #region
                        Console.WriteLine("Введите индекс для добавления");
                                    int adIn= Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите значение ");
                                    int adNum = Int32.Parse(Console.ReadLine());
                                    temp =num.ToList();
                                    temp.Insert(adIn, adNum);
                                    num = temp.ToArray();
                                    foreach (int i in num)
                                    {
                                        Console.Write(i + " ");
                                    }

                                    Console.WriteLine();

                        #endregion
                        //•	Удалить те элементы массива, которые встречаются в нем ровно два раза
                        #region    
                            int[] num2 = new int[6];
                            int[] num3 = new int[6];

                            for (int i = 0; i < 6; i++)
                            {
                                num2[i] = num[i];
                            }

                            for (int i = 0; i < 6; i++)
                            {
                               Console.Write(num2[i]+" ");
                            }
                        Console.WriteLine();
            #endregion
            //•	Удалить из строки слова, в которых есть буква 'a'

            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Удалить из строки слова, в которых есть буква 'a' :");
            Console.ForegroundColor = ConsoleColor.White;
            string str = "Kluge kleine Kinder kaufen keine kleinen Kleiderknopfe";
                                string[] str2 = str.Split(' ');
                                foreach(var item in str2)
                                {
                                    Console.Write(item + " ");
                                }
                                for(int i = 0; i < str2.Length; i++)
                                {
                                    if (str2[i].Contains("a"))
                                    {
                                        str2[i] = "";
                                    }
                                }
                                for(int i = 0; i < str2.Length; i++)
                                {
                                    Console.Write(str2[i] + ' ');
                                }


                                Console.WriteLine();


            #endregion
            //•	Удалить из строки слова, в которых есть хоть одна буква последнего слова
            #region     
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("	Удалить из строки слова, в которых есть хоть одна буква последнего слова");
            Console.ForegroundColor = ConsoleColor.White;
            string str3 = "Wenn Klappergras blüht, bleibt Klappergras immer noch grün";

                                string[] str4 = str3.Split(' ');
                                for (int i = 0; i < str4.Length; i++)
                                {
                                    Console.Write(str4[i] + ' ');
                                }
                                Console.WriteLine();
                                for (int i = 0; i < str4.Length; i++)
                                {
                                    char[] char2 = str4[str4.Length - 1].ToArray();
                                    for (int j = 0; j < char2.Length; j++)
                                    {
                                        if (str4[i].Contains(char2[j]))
                                        {
                                            str4[i] = "";
                                        }
                                    }
                                }
                                Console.WriteLine("Резулат : ");
                                for (int i = 0; i < str4.Length; i++)
                                {
                                    Console.Write(str4[i] + ' ');
                                }

                                Console.WriteLine();

            #endregion
            //•	В строке все слова, которые начинаются и заканчиваются одной буквой, выделить квадратными скобками
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("В строке все слова, которые начинаются и заканчиваются одной буквой, выделить квадратными скобками");
            Console.ForegroundColor = ConsoleColor.White;
            str3 = "Es war einmal ein Mann, der hatte drei Sohne.\n Der eine hiess Schack, der andre hiess Schackschawwerack, der dritte hiess Schackschawwerackschackommini. \nNun war da auch eine Frau, die hatte drei Tochter.\nDie eine hiess Sipp, die andre hiess Sippsiwwelipp, die dritte hiess Sippsiwwelippsippelimmini.\n Und Schack nahm die Sipp, und Schackschawwerack nahm Sippsiwwelipp, und Schackschawwerackschackommini nahm Sippsiwwelippsippelimmini zur Frau";
                        str4 = str3.Split(' ');
                        for (int i = 0; i < str4.Length; i++)
                        {
                            Console.Write(str4[i] + ' ');
                        }
                        for (int i = 0; i < str4.Length; i++)
                        {
                            if (str4[i].First() == str4[i].Last())
                            {
                                str4[i] = "[" + str4[i] + "]";
                            }
                        }
                        Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Результат : ");
                        for (int i = 0; i < str4.Length; i++)
                        {
                            Console.Write(str4[i] + ' ');
                        }

                        Console.WriteLine();
            #endregion
            //•	Обнулить элементы тех строк,
            //на пересечении которых с главной 
            //диагональю стоит четный элемент
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Обнулить элементы тех строк, на пересечении которых с главной диагональю стоит четный элемент");
            Console.ForegroundColor = ConsoleColor.White;
            int[,] arrayY = new int[5, 5];
                                       var rndY = new Random();
                                       for(int i = 0; i < 5; i++)
                                       {
                                           for(int j = 0; j < 5; j++)
                                           {
                                               arrayY[i, j] = rndY.Next(10);
                                               Console.Write(arrayY[i, j] + " ");
                                           }
                                           Console.WriteLine();
                                       }

                                       for (int i = 0; i < 5; i++)
                                       {

                                           for (int j = 0; j < 5; j++)
                                           {
                                               if((i==j)&& (arrayY[i, j] % 2 == 0))
                                               {
                                                   for (j = 0; j < 5; j++) { 
                                                       arrayY[i, j] = 0;

                                                   }
                                               }

                                           }
                                       }

                                               Console.WriteLine();
                                       for (int i = 0; i < 5; i++)
                                       {
                                           for (int j = 0; j < 5; j++)
                                           {
                                               Console.Write(arrayY[i, j] + " ");
                                           }
                                           Console.WriteLine();
                                       }
                                       Console.WriteLine();

            #endregion
            //•	Обнулить элементы тех столбцов, 
            //на пересечении которых с главной диагональю
            //стоит четный элемент
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Обнулить элементы тех столбцов, на пересечении которых с главной диагональю стоит четный элемент");
            Console.ForegroundColor = ConsoleColor.White;
            int[,] arrayX = new int[6, 6];
                                         var rndX = new Random();
                                         for (int y = 0; y < 6; y++)
                                         {
                                             for (int x = 0; x < 6; x++)
                                             {
                                                 arrayX[y, x] = rndX.Next(10);
                                                 Console.Write(arrayX[y, x] + " ");
                                             }
                                             Console.WriteLine();
                                         }

                                         for (int y = 0; y < 6; y++)
                                         {

                                             for (int x = 0; x < 6; x++)
                                             {
                                                 if ((y == x) && (arrayX[y, x] % 2 == 0))
                                                 {
                                                     for (y = 0; y < 6; y++)
                                                     {
                                                         arrayX[y, x] = 0;
                                                       }

                                                 }

                                             }
                                         }

                                         Console.WriteLine();
                                         for (int y = 0; y < 6; y++)
                                         {
                                             for (int x = 0; x < 6; x++)
                                             {
                                                 Console.Write(arrayX[y, x] + " ");
                                             }
                                             Console.WriteLine();
                                         }

            #endregion
            //•	Удалить те столбцы, в которых встречается
            //хотя бы два одинаковых элемента
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Удалить те столбцы, в которых встречается хотя бы два одинаковых элемента");
            Console.ForegroundColor = ConsoleColor.White;
            int[,] arrayK = new int[5, 6];
                                      var rndK = new Random();
                                      for (int i = 0; i < 5; i++)
                                      {
                                          for (int j = 0; j < 6; j++)
                                          {
                                              arrayK[i, j] = rndK.Next(10);
                                              Console.Write(arrayK[i, j] + " ");
                                          }
                                          Console.WriteLine();
                                      }
                                      Console.WriteLine();



                                              for (int y = 0; y < 5; y++)
                                      {
                                          for (int x = 0; x < 6; x++)
                                          {
                                              Console.Write(arrayK[y, x] + " ");
                                          }
                                          Console.WriteLine();
                                      }

            #endregion
            //•	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
            //Программа должна сосчитать количество введенных пользователем пробелов. (Подсказка. IF, Length)



            //•	Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный 
            //билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме
            //последних трёх, то этот билет считается счастливым).
            //(Подсказка. SUBSTRING, LENGTH)
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым");
            Console.ForegroundColor = ConsoleColor.White;
            var randbill = new Random();
                           int[] billet = new int[6];
                           for(int i = 0; i < 6; i++)
                           {
                Console.Write("_");
                               billet[i] = Int32.Parse(Console.ReadLine());
                           }
                           foreach(var i in billet)
                           {
                               Console.Write(i+" ");
                           }
                           Console.WriteLine();
                           int prt1 = 0;
                           int prt2 = 0;
                           for(int i = 0, j=3; i < 3; i++,j++)
                           {
                               prt1+=billet[i];
                               prt2 += billet[j];
                           }
                           if (prt1 == prt2) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ты счастливчик!");
                                   }
                           else
                           {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Не везет..");
                           }
                           Console.WriteLine();

            #endregion
            //•	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего
            //регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры
            //и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
            //(Без подсказки – легче легкого)
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите строку с верхним и нижним регистром \n");
            Console.ForegroundColor = ConsoleColor.White;
            string stroki= Console.ReadLine();
                        char[] stroki1 = stroki.ToCharArray();
                       for(int i = 0; i < stroki1.Length; i++)
                        {
                            if (Char.IsUpper(stroki1[i]))
                            {
                               stroki1[i]=Char.ToLower(stroki1[i]);
                            }
                            else
                            {
                                stroki1[i] = Char.ToUpper(stroki1[i]);
                            }
                        }
                        Console.WriteLine("Ваша строка: ");
                        foreach (var item in stroki1)
                        {
                            Console.Write(item);
                        }

                        Console.WriteLine();
            #endregion

            //•	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое
            //число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное 
            //его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
            //        3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите целые числа А и В (A < B) :");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите А: ");
                        int size1= Int32.Parse(Console.ReadLine());
                        Console.Write("Введите B: ");
                        int size2 = Int32.Parse(Console.ReadLine())+1;
                        int[][] numbers = new int[size2][];
                        for(int i = size1; i <size2; i++)
                        {
                            numbers[i] = new int[i];
                            for(int j = 0; j < numbers[i].Length; j++)
                            {
                                numbers[i][j] = i;
                                Console.Write(numbers[i][j] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
            #endregion

            //•	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
            //Например, если было введено число 345, то программа должна вывести число 543.
            //(Подсказка – вспомните что есть строка, и как мы с ней можем работать)



            //•	Объявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) 
            //дробных чисел с именем B.Заполнить одномерный массив А числами, введенными с клавиатуры пользователем,
            //а двумерный массив В случайными числами с помощью циклов.Вывести на экран значения массивов: 
            //массива А в одну строку, массива В — в виде матрицы.Найти в данных массивах общий максимальный элемент,
            //минимальный элемент, общую сумму всех элементов, общее произведение всех элементов, сумму четных
            //элементов массива А, сумму нечетных столбцов массива В.
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Объявлен одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив А числами");
            Console.ForegroundColor = ConsoleColor.White;
            double[] A;
                        A = new double[5];

                        double[,] B = new double[3, 4];

                        for (int i = 0; i < 5; i++)
                        {
                            A[i] = Int32.Parse(Console.ReadLine());
                        }

                        var rnd = new Random();
                        for (int i = 0; i < B.GetLength(0); i++)
                        {
                            for (int j = 0; j < B.GetLength(1); j++)
                            {
                                B[i, j] = rnd.Next(50);
                            }
                        }
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

                        Console.WriteLine("Макс первого массива - " + A.Max());
                        Console.WriteLine("Мин первого массива - " + A.Min());

                        double max = 0;
                        double min = 51;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {

                                if ((B[i, j].CompareTo(A[j])) <= 0)
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

                        double sumA = A.Sum();
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

                       double prA = 1;
                        for (int i = 0; i < 5; i++)
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


                        Console.WriteLine("Произведение всех элементов = " + (String.Format("{0:G}", prA)));
                        sumA = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            if (A[i] % 2 == 0)
                            {
                                sumA += A[i];
                            }
                        }
                        Console.WriteLine("Четных элементов сумма = " + sumA);
                        sumB = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (B[i, j] % 2 != 0)
                                {
                                    sumB += B[i, j];
                                }

                            }
                        }

                        Console.WriteLine("Нечетных элементов сумма = " + sumB);

            #endregion


            //•	Даны 2 массива размерности M и N соответственно.Необходимо переписать в третий массив общие
            //элементы первых двух массивов без повторений.
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Даны 2 массива размерности M и N соответственно.Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.");
            Console.ForegroundColor = ConsoleColor.White;
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

            //•	Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
            //Определить сумму элементов массива, расположенных между минимальным и максимальным элементами
            //Подсказка – Random rnd = new Random, rnd.Next(1, 15).

            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.");
            Console.ForegroundColor = ConsoleColor.White;
            int[,] Massiv = new int[5, 5];

                        var rnd3 = new Random();
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Massiv[i, j] = rnd3.Next(-100, 100);
                                Console.Write(Massiv[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        int size = 25;
                        int[] Massiv2 = new int[size];
                        int max2 = 0;
                        int min2 = 100;
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
                            if (Massiv2[h] > max2)
                            {
                                max = Massiv2[h];
                            }
                            if (Massiv2[h] < min2)
                            {
                                min = Massiv2[h];
                            }
                        }

                        Console.WriteLine("MAX - " + max2);
                        Console.WriteLine("Min - " + min2);
                        var dMassiv = Massiv2.ToList();
                        var indMaximum = dMassiv.IndexOf(max2);
                        var indMinimum = dMassiv.IndexOf(min2);
                        Console.WriteLine(indMaximum + "  Index Max");
                        Console.WriteLine(indMinimum + "   Ind Min");
                        int sumRes = 0;

                        if (indMinimum < indMaximum)
                        {
                            for (int h = indMinimum + 1; h < indMaximum; h++)
                                sumRes += Massiv2[h];
                        }
                        else
                        {
                            for (int h = indMaximum + 1; h < indMinimum; h++)
                                sumRes += Massiv2[h];
                        }

                        Console.WriteLine("Сумма элементов массива, расположенных между минимальным и максимальным элементами = " + sumRes);





            #endregion

        

            //•	Составить символьную строку из N звездочек.
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите колличество звезд");
            Console.ForegroundColor = ConsoleColor.White;
            int sizeStar = Int32.Parse(Console.ReadLine());
            char[] stars = new char[sizeStar];
            for(int i = 0; i < sizeStar; i++)
            {
                stars[i] = '*';
                Console.Write(stars[i] + " ");
            }
            Console.WriteLine();

            #endregion
            //•	Есть строка(любая), нужно удалить из этой строки знаки / и \.
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Есть строка(любая), нужно удалить из этой строки знаки / и \\.");
            Console.ForegroundColor = ConsoleColor.White;
            string strokA = "\\Allen Leuten recht getan ist eine Kunst, die niemand kann.\\ \n\t\t/Deutsche Sprichwort/";
            Console.WriteLine(strokA);
            char[] strokB = strokA.ToCharArray();
            for(int i = 0; i < strokB.Length; i++)
            {
                if((strokB[i]=='/')||(strokB[i] == '\\'))
                {
                    strokB[i] = ' ';
                }
            }
            Console.WriteLine();
            foreach(var i in strokB)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            #endregion
            //•	Составьте программу, которая в слове «класс» две одинаковые буквы заменяет цифрой «1»
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("в слове «класс» две одинаковые буквы заменяет цифрой «1»");
            Console.ForegroundColor = ConsoleColor.White;
            strokA = "klass";
            strokB = strokA.ToCharArray();
            for(int i = 1; i < strokB.Length; i++)
            {
                if (strokB[i] == strokB[i -1])
                {
                    strokB[i] = ' ';
                    strokB[i - 1] = '1';
                 }
            }
            foreach(var item in strokB)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            #endregion
            //•	Написать программу, подсчитывающую количество цифр в заданной строке.
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите строку с цифрами");
            Console.ForegroundColor = ConsoleColor.White;
            strokA = Console.ReadLine();
            strokB = strokA.ToCharArray();
            int quant=0;
             for(int i = 0; i < strokB.Length; i++)
            {

                if (Char.IsNumber(strokB[i]))
                {
                    quant++;
                }
               
            }
            Console.WriteLine("В введенно строке "+quant+" цифр(ы) \n");
            #endregion
            //•	Дан текст.Определить, есть ли в тексте слово one.
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            strokA = "One more cup of coffee for the road\n One more cup of coffee 'fore I go.\n To the valley below.\n";
            Console.WriteLine(strokA);
            Console.ForegroundColor = ConsoleColor.White;
            string[] strokaC = strokA.Split(' ');
            for(int i = 0; i < strokaC.Length; i++)
            {
                if ((strokaC[i] == "one")||(strokaC[i] == "One"))
                {
                    strokaC[i]="";
                }
            }
            foreach(var item in strokaC)
            {
                Console.Write(item+" ");
            }

            #endregion
            Console.WriteLine();
            //•	Дан текст.Определить, содержит ли он символы, отличающиеся от букв и цифр.
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            strokA = "Suddenly they saw a very$$ tall young man with a big $$black dog. They were nervous and walked past him as fast as they could to the lift. The door of the lift opened and Jenny and Robert got in. Before the doors closed the man and the dog jumped in – three people and one big black dog in the lift.";
            Console.WriteLine(strokA);
            Console.ForegroundColor = ConsoleColor.White;
            strokB = strokA.ToCharArray();
            quant = 0;
            for(int i = 0; i < strokB.Length; i++)
            {
                if (Char.IsSymbol(strokB[i]))
                {
                    quant++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("В строке "+quant+" символов");
            #endregion
            Console.WriteLine();
           

            //•	Дана строка, посчитать количество вхождений буквы P.
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            strokA = "Холодный и бледный рассвет еще только занимался, а Арагорн уже вел отряд по пути, равного которому по трудности не изведал никто из смертных. Дунаданцы-северяне, гном Гимли и эльф Леголас преодолели его, ведомые стальной волей, не знающей преград.";
            Console.WriteLine(strokA);
            Console.ForegroundColor = ConsoleColor.White;
            strokB = strokA.ToCharArray();
            quant = 0;
            for(int i = 0; i < strokB.Length; i++)
            {
                if ((strokB[i] == 'Р') || (strokB[i] == 'р'))
                {
                    quant++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("В данном тексте "+quant+" букв Р");
            Console.WriteLine();
            #endregion
            //•	Ввести небольшой текст(с пробелами) в строку S.Подсчитать количество слов в строке и вывести все слова в столбик.
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите небольшой текст(с пробелами) в строку");
            Console.ForegroundColor = ConsoleColor.White;
            string S = Console.ReadLine();
            strokaC = S.Split(' ');
            int si = 0;
            Console.WriteLine();
            for (si = 0; si < strokaC.Length; si++)
            {
                Console.WriteLine(strokaC[si]);
            }
            Console.WriteLine();
            Console.WriteLine("\nВ набраном тексте "+si+" слов(а)");
            #endregion
            Console.WriteLine();
            //•	Дана строка символов.Группы символов, разделенные пробелами и не содержащие пробелов внутри себя, 
            //будем называть словами.Найти количество слов, у которых первый и последний символы совпадают между 
            //собой(если можно с комментариями).
            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            strokA = "Отныне все дороги вели на восток, навстречу Тьме. В тот самый час, когда Пин, стоя перед Воротоами Города, смотрел на входящие войска, правитель Ристании во главе большого отряда Всадников, спускался с холмов. Вечерело.Длинные тени, перегоняя лошадей, бежали впереди по долине. На лесистых склонах было уже темно. В верховьях долины, словно запирая ее, высился могучий горный пик с вершиной, укрытой вечными снегами. На восточных его склонах густо голубели тени, западные пылали в огне заката. Мерри с изумлением озирался по сторонам. Ему было интересно в незнакомой стране. От могучих водопадов воздух тихо звенел, шумели деревья, стучали по камням копыта. Раньше Мерри любил слушать о горах, думать о них, но теперь, когда горные хребты вздымались вокруг под самые небеса, он чувствовал себя неуютно.Слишком они были большие: хотелось оказаться в маленькой комнатке возле камина. Отряд был в пути уже третий день.Шли почти без отдыха, и Мерри не на шутку устал.Когда дорога позволяла, он ехал рядом с правителем, занимая его рассказами о Хоббитании или слушая о прошлом и настоящем ристанийцев. Но чаще он следовал позади Теодена, прислушиваясь к медленной, звучной речи Всадников. Иногда слова их языка напоминали ему родной говор, но смысл ускользал. Зато песни Всадников ему очень нравились.";
            strokaC = strokA.Split(' ');
            
            quant = 0;
            for (int i = 0; i < strokaC.Length; i++)
            {
                Console.Write(strokaC[i] + ' ');
            }
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < strokaC.Length; i++)
            {
                if (strokaC[i].First() == strokaC[i].Last())
                {
                    quant++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("В тексте "+quant+" слов, у которых первый и последний символы совпадают между cобой");
            Console.WriteLine();
            #endregion


            //Дана строка символов, состоящая из цифр от 0 до 9 и пробелов.Группы цифр, разделенные 
            //пробелами(одним или несколькими) и не содержащие пробелов внутри себя, будем называть словами.
            //Рассматривая эти слова как числа, определить и напечатать сумму чисел, оканчивающихся на цифры 3 или 4.

            #region
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            strokA = "1247 254 7413 8521 4454 5253";
            Console.WriteLine(strokA);
            Console.ForegroundColor = ConsoleColor.White;
            strokaC = strokA.Split(' ');
            quant = 0;
            for(int i = 0; i < strokaC.Length; i++)
            {
                strokB = strokaC[i].ToCharArray();
               if((strokaC[i].Last()=='4')|| (strokaC[i].Last() == '3'))
                {
                    for(int j = 0; j < strokB.Length; j++)
                    {
                        quant += Int32.Parse(strokB[j].ToString());
                    }
                }
            }

            Console.WriteLine("Сумма всех чисел, оканчивающихся на цифры 3 или 4 = " + quant);
            Console.WriteLine();
           
            #endregion
        }
    }
}
