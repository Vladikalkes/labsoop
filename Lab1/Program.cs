using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine();
            //________________________________________________________Типы 
            //a
            int a = -1;
            bool b = true;
            char ch = 'a';
            float abc = 1.2F;
            double c = 1.234e-12;
            long d = -123456789987;
            byte f = 4;
            sbyte g = -123;
            short q = -32767;
            uint h = 3456;
            ulong j = 12345;
            ushort t = 32800;
            decimal u = 123456737867987843;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(ch);
            Console.WriteLine(abc);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(q);
            Console.WriteLine(h);
            Console.WriteLine(j);
            Console.WriteLine(t);
            Console.WriteLine(u);

            //b неявные преобразования
            int num = 12312321;
            float bum1 = num;

            byte num1 = 123;
            ushort num11 = num1;

            char ax = 'a';
            int axc = ax;

            ulong num2 = 956;
            float num22 = num2;

            uint num3 = 156;
            double num33 = num3;

            //явные преобразования
            double s = 5.3;
            float e = (float)s;

            short sm = 45;
            byte em = (byte)sm;

            char xc = 'e';
            int i = (int)xc;

            ulong num4 = 78;
            double num44 = (double)num4;

            Int32 i32 = 56;
            Int64 i64 = (Int64)i32;

            uint vb = 12;
            char asd = (char)vb;

            double yy = 55.4;
            bool yy1 = Convert.ToBoolean(yy);

            //c Выполните упаковку и распаковку значимых типов
            int ob = 3;
            object abd = ob;

            int bo = (int)abd;
         //   decimal ll = (decimal)abd; //InvalidCastException

            //d Продемонстрируйте работу с неявно типизированной переменной. 
            var fd = "Test";
            Console.WriteLine("Тип fd (var): {0}", fd.GetType());

            //e Продемонстрируйте пример работы с Nullable переменной
            int? z1 = 7;
            Console.WriteLine("Nullable переменная {0}", z1 == null); 
            Console.WriteLine("Nullable переменная {0}", z1.Value);
            Console.WriteLine("Nullable переменная {0}", z1.HasValue);
            Console.WriteLine("Nullable переменная {0}", z1 ?? 1);

            Nullable<char> z2 = 'c';
            //char? z2 = null;
            Console.WriteLine("Nullable переменная {0}", z2.Value);

            // f  Определите переменную типа var и присвойте ей любое 
            //значение.Затем следующей инструкцией присвойте ей значение
            //другого типа. Объясните причину ошибки.
            var gg = "Test2";
            //gg = 123; //Будет ошибка. Нельзя менять тип данных.
            Console.WriteLine("Тип gg (var): {0}", gg.GetType());

            //_______________________________________2) Строки 
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine();

            //a     Объявите строковые литералы.

            Console.WriteLine("\a"); // звуковой сигнал
            Console.WriteLine("\b"); // возврат на одну позицию
            Console.WriteLine("\n"); // новая строка
            Console.WriteLine("\0"); // пустой символ
            Console.WriteLine("\'"); // одинарная кавычка
            Console.WriteLine("\""); // двойная кавычка
            Console.WriteLine("\\"); // обратная косая черта

            //b. Создайте три строки на основе String. 
            //Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки. 

            string str1 = "qwerty", str2 = "ytrewq", str3 = "test"; 

            string strresult = String.Concat(str1, str2, str3);
            Console.WriteLine("Результат сцепления: {0}", strresult);
            string strRes = String.Copy(str1);
            Console.WriteLine("Результат копирования: {0}", strRes);
            string strRes1 = str2.Substring(1, 3);
            Console.WriteLine("Результат выделения подстроки : {0}", strRes1);
            string[] strRes2 = str2.Split('e');
            foreach (string word in strRes2)
            {
                Console.WriteLine("Разделение строки на слова: {0}", word);
            }
            string strRes3 = str3.Insert(2, "OOOOO");
            Console.WriteLine("Результат вставки подстроки в заданную позицию: {0}", strRes3);
            string strRes4 = str1.Remove(2, 2);
            Console.WriteLine("Результат удаления заданной подстроки: {0}", strRes4);


            //c Создайте пустую и null строку.. Продемонстрируйте  использование метода string.IsNullOrEmpty.

            string nullstr1 = "";
            string nullstr2 = null;
            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullstr1);
            Console.WriteLine(isNullOrEmpty);
            isNullOrEmpty = string.IsNullOrEmpty(nullstr2);
            Console.WriteLine(isNullOrEmpty);

            //d Создайте строку на основе StringBuilder.Удалите определенные позиции и добавьте новые символы в начало и конец строки. 

            StringBuilder str4 = new StringBuilder("HelloWorld", 50);
            str4.Remove(2, 2);
            Console.WriteLine(str4);
            str4.Insert(0, "^");
            str4.Insert(9, "^");
            Console.WriteLine(str4);

            // ________________________________________________________3) Массивы 
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine();

            //a Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица).  
            Console.WriteLine();
            int[,] Arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

          for (int k = 0; k < 3; k++)
          {
              for (int r = 0; r < 3; r++)
              {
                  Console.Write(Arr[k, r]+"\t");
              }
              Console.WriteLine();
          }
            Console.WriteLine();

            //b. Создайте одномерный массив строк. 
            //Выведите на консоль его содержимое, длину массива. Поменяйте произвольный элемент (пользователь определяет позицию и значение). 

             string[] str5 = { "Test", "TeSt", "qwerty", "one" };
             for (int k = 0; k < 4; k++)
             {
                 Console.Write(str5[k] + "\t");
            }
             Console.WriteLine();
             Console.WriteLine("Длинна массива: {0}", str5.Length);
    
            Console.WriteLine();
            Console.Write("Введите позицию: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение: ");
            string val = Console.ReadLine();
            str5[pos] = val;

            for (int k = 0; k < 4; k++)
            {
                Console.Write(str5[k]+"\t");
            }
             Console.WriteLine();

            //c Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно. 
            //Значения массива введите с консоли.

             int[][] ArrA = new int[3][];
            ArrA[0] = new int[2];
            ArrA[1] = new int[3];
            ArrA[2] = new int[4];

            Console.WriteLine("Введите значения массива");
            for (int p= 0; p < ArrA.Length; p++)
            {
                for (int m = 0; m < ArrA[p].Length; m++)
                {
                    string st = Console.ReadLine();
                    ArrA[p][m] = int.Parse(st);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Вывод ступеньчатого массива:");
            for (int p = 0; p < ArrA.Length; p++)
            {
                for (int m = 0; m < ArrA[p].Length; m++)
                {
                    Console.Write(ArrA[p][m] + " ");
                }
                Console.WriteLine();
            }

            //d Создайте неявно типизированные переменные для хранения массива и строки.
            var arr = new[] { 1, 2, 3 };
            var str6 = new[] { "A", "B", "c" };

            //__________________________________4) Кортежи
               Console.WriteLine("ЗАДАНИЕ 4");
               Console.WriteLine();

            //a Задайте кортеж из 5 элементов с типами int, string, char, string, ulong

             (int val, string strTp, char chTp, string strTp2, ulong val_long) 
             tuple = (123,  "string", 't', "string2", 12321443253255326);

            //c Выведите кортеж на консоль целиком и выборочно(1, 3, 4  элементы)

               Console.WriteLine();
               Console.WriteLine("Вывод кортежа целеком: {0}", tuple);


               Console.WriteLine();
               Console.WriteLine("Вывод 1, 3, 4 элементов кортежа: {0}, {1}, {2}", tuple.val, tuple.chTp, tuple.strTp2);

            //d Выполните распаковку кортежа в переменные.
               int val1_tuple = (int)tuple.val;
               string val2_tuple = (string)tuple.strTp;
               char val3_tuple = (char)tuple.chTp;
               string val4_tuple = (string)tuple.strTp2;
               int val5_tuple = (int)tuple.val_long;


            //e Сравните два кортежа
              (int, string, char, string, ulong) 
              tuple2 = (124, "qwerty", 'a', "ytrewq", 1523552);

              Console.WriteLine("Сравнение двух кортежей: {0}", tuple == tuple2);

            // Задание 5. Создайте локальную функцию в main и вызовите ее.

              Console.WriteLine("\nЗадание 5");
              Console.WriteLine("Исходные данные");
              Random rand = new Random();
              int[] Array = new int[10];
              for (int k = 0; k < Array.Length; k++)
               {
                   Array[k] = rand.Next(0, 20);
                   Console.Write(Array[k]);
                   Console.Write(" ");
               }
               Console.WriteLine("\n");
               Console.WriteLine("Итоговый кортеж");
               object LocalMet(int[] LocalArr, string LocalStr)
               {
                   (int max, int min, int sum, char firstletter) LocalTup;
                   LocalTup.max = LocalArr[0];
                  LocalTup.min = LocalArr[0];
                  LocalTup.sum = 0;
                  for (int k = 0; k < LocalArr.Length; k++)
                  {
                      if (LocalTup.max < LocalArr[k])
                      {
                         LocalTup.max = LocalArr[k];
                      }
                     if (LocalTup.min > LocalArr[k])
                     {
                         LocalTup.min = LocalArr[k];
                     }
                     LocalTup.sum += LocalArr[k];
                  }
                  LocalTup.firstletter = LocalStr[0];
                  return LocalTup;
               }
               Console.WriteLine(LocalMet(Array, "Test word"));

            //Задание 6. Работа с checked/unchecked
            Console.WriteLine("\nЗадание 6");

            int ttt = 5;
            int Func1()
            {
                int m = int.MaxValue;
                try
                {
                    checked
                    {
                        m = m + ttt;
                        Console.WriteLine(m);
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка переполнения!");
                }
               return m;
            }
            int Func2()
            {
                int m = int.MaxValue;
                unchecked
                {
                    m = m + ttt;
                    Console.WriteLine(m);
                }
                return m;
            }
            Console.WriteLine(Func2());
            Console.WriteLine(Func1());

        }
    }
}
