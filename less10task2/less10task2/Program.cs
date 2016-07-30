﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте класс MyList<T>.Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса
//List<T>.Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
//индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов. 

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока.
//Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 

namespace less10task2
{
    static class ExtensionClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {

            T[] newList = new T[list.quantity];
            for (int i = 0; i < list.quantity; i++)
            {
                newList[i] = (T)list[i];
            }
            return newList;
        }
    }
    interface IMyList<T>
    {
        void Add(T numb);
        int quantity
        { get; }
    }

    class MyList<T> : IMyList<T>
    {
        private T[] newList = new T[5];


        int count;
        public object this[int index]
        {
            get
            {
                if (index >= 5)
                    return newList[index];
                else
                {
                    return "выход за предел массива";
                };
            }
        }

        public void Add(T numb)
        {
            newList[count] = numb;
            count++;
        }
        public int quantity
        {
            get { return count; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> instance = new MyList<string>();

            instance.Add("fg");
            instance.Add("rt");
            instance.Add("fe");
            instance.Add("asd");
            instance.Add("www");
            instance.Add("ffff");
            instance.Add("df");

            //  Console.WriteLine(instance[2]);
            Console.WriteLine(instance.quantity);

            string[] array = instance.GetArray<string>();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
