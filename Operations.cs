using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumPow
{
    class Operations
    {
        //просуммированное число всех найденых чисел
        double sum = 0;
        public void findEl()
        {
            //задаем границу до миллиона
            for (int i = 0; i< 1000000; i++)
            {
                //конвертируем число в массив чар, чтобы доставать каждую цифру числа
                var str = i.ToString();
                char[] arr = str.ToCharArray();
                compareEl(arr);
            }

            Console.WriteLine("Symma vseh chisel= " + sum.ToString());
            Console.ReadLine();
        }


        //сравниваем число с их суммой разрядов в 5 степени
        private void compareEl(char[] arr)
        {
           
            //коллекция куда будем записывать все цифри приведенные в степень конкретного числа
            List<double> result = new List<double>();

            //конверируем каждую цифру в дабл и приводим к 5 степени
            for (int i=0; i < arr.Length; i++)
            {
                var str1 = arr[i].ToString();
                var intNumber = Convert.ToDouble(str1);
                var a = Math.Pow(intNumber, 5);
                result.Add(a);
            }

           
            
            //конвертируем массив чар в инт
            string str = new string(arr);
            int asd = Convert.ToInt32(str);

            //сравниваем просуммированное число с числом, которое получили изачально, если они равны, то это число, которое нам нужно
            //используем лямбда выражение result.Sum() для суммирования всех цифр с их степенью
            if (result.Sum() == asd && result.Sum() != 0 && result.Sum() != 1)
            {
                sum = sum + result.Sum();
                Console.WriteLine(result.Sum().ToString());
            }
        }
    }
}
