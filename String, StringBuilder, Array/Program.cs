using System;
using String__StringBuilder__Array.Models;

namespace String__StringBuilder__Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task
            Car Merc = new Car();
            Merc.Model = "Mercedes";
            Merc.Brand = "GLS600";
            Merc.FuelFor1Km = 0.23;
            Merc.FuelCapacity = 90;
            Merc.Year = 2020;
            Merc.CurrentFuel = 20;
            Merc.Color = "White";
            Merc.ShowInfo();
            Merc.Drive();
            #endregion


            #region dersde elediyimizin praktikasi
            //int a = 10;
            //int c = a;
            //c = 15;
            //Console.WriteLine(a);

            //string word = "lorem";
            //string word2 = word;
            //word2 = "ipsum";
            //Console.WriteLine(word);
            //string word3 = "ipsum";
            //string word4 = "test";
            //int[] arr = {1,2,3};
            //int[] arr2 = {1,2,3};
            //Console.WriteLine(arr==arr2);
            //Console.WriteLine(word3 == word4);
            //word4 += "a";
            //Console.WriteLine(word4);
            //string soz = "salam";

            //Console.WriteLine(Reverse(soz));
            //string a = "   Word Salam    "; //word
            //Console.WriteLine(a.Length);
            //Console.WriteLine(a.ToUpper());
            //Console.WriteLine(a.ToLower());
            //Console.WriteLine(a.ToLower().Equals("woRd".ToLower()));
            //Console.WriteLine(a.Trim());
            //Console.WriteLine(a.TrimStart());
            //Console.WriteLine(a.ToLower().Contains("w".ToLower()));
            //Console.WriteLine(a.Replace(" ", "-"));
            //Console.WriteLine(String.Concat(a, "salam"));
            //Console.WriteLine(a + "salam");
            //Console.WriteLine($"{a} salam");
            //Console.WriteLine("{0} {1}", a, "salam");
            //Console.WriteLine(a.IndexOf('t'));
            //Console.WriteLine(a.LastIndexOf("a"));
            //Console.WriteLine(a.IndexOf("a"));
            //Console.WriteLine(a.Remove(0, 3));
            //string b = "  ";
            //Console.WriteLine(String.IsNullOrEmpty(b));
            //Console.WriteLine(String.IsNullOrWhiteSpace(b));

            //array methods

            //string[] arr = { "lorem", "ipsum", "doler", "sit", "amet" };

            //int[] arr = { 1, -2, 13, 4, 0, 6, -7 };

            //string result = String.Join(",", arr);

            //Console.WriteLine(result);

            //string word = "Hello World";
            //string[] words = word.Split(' ');
            //string[] words = { "Hello", "World" };
            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //int[,,] arr2 = {
            //    { 
            //        {1,2 }, {2,3 } //0
            //    },
            //    {
            //        {2,4 } , {2,3 } //1
            //    },
            //    { 
            //        { 5,6} , {2,3 } //2
            //    },
            //};

            //Console.WriteLine(arr2.Rank);
            //Console.WriteLine(arr2[2,0,1]);
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr3 = new int[3];
            //arr3[0] = 1;    
            //arr3[1] = 1;    
            //arr3[2] = 1;
            //fixed size
            //Array.Resize(ref arr3, 4);


            //int[] numbers = { 1, 2, 3 };

            //int[] result = Resize(ref numbers, 4);
            //result[3] = 5;
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}




            //static int[] Resize(ref int[] arr, int count)
            //{
            //    int[] newArr = new int[count];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        newArr[i] = arr[i];
            //    }

            //    return newArr;
            //}


            //static StringBuilder Reverse(string soz)
            //{
            //    StringBuilder word=new StringBuilder();

            //    for (int i = soz.Length - 1; i > -1; i--)
            //    {
            //        word.Append(soz[i]);
            //    }

            //    return word;
            //}

            #endregion
        }
    }
}

