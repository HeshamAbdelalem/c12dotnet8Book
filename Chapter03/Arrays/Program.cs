using System.Collections;
using System.Security.Cryptography;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array Declaration and loop it

            //string[] names;

            //names = new string[2];

            //names[0] = "Hesham";
            //names[1] = "Magdy";

            //string[] names2 = { "atta", "abdelalem" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"{names[i]} have {names[i].Length} chars");
            //}


            //IEnumerator values = names2.GetEnumerator();

            //while(values.MoveNext())
            //{
            //    Console.WriteLine(values.Current);
            //}
            #endregion

            #region Multi-Dim Array

            //string[,] grid1 =
            //{
            //    {"Alpha", "Beta", "Gamma", "Delta" },
            //    {"Anne", "Ben", "Charlie", "Doug" },
            //    {"Aardvark", "Bear", "Cat", "Dog" }
            //};

            //for (int i = 0; i < grid1.Length; i++)
            //{
            //    Console.WriteLine(grid1[i/grid1.GetLength(1), i%grid1.GetLength(1)]);
            //}


            #endregion

            #region Convert from anytype to a string

            //int number = 15;
            //Console.WriteLine(number.ToString());

            //bool boolean = true;
            //Console.WriteLine(boolean.ToString());

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString());

            //object me  = new object();
            //Console.WriteLine(me.ToString());

            #endregion

            #region Convert from binary object to a string

            //byte[] binaryObject = new byte[128];

            //Random.Shared.NextBytes(binaryObject);

            //for (int i = 0; i < binaryObject.Length; i++)
            //{
            //    Console.Write($"{binaryObject[i]:X2}");
            //}
            //Console.WriteLine();

            //string encoded = ToBase64String(binaryObject);
            #endregion

            #region Parse from strings to numbers or dates and times

            //int friends = int.Parse("35");
            //DateTime birthday = DateTime.Parse("21 April 1989");

            //Console.WriteLine($"Hey I have {friends} friends to invite to my bday party ");
            //Console.WriteLine($"my birthday is on {birthday}");
            //Console.WriteLine($"my birthday is on {birthday:D}");


            #endregion

            #region tryParse

            Console.WriteLine("how old are you?");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int count))
            {
                Console.WriteLine($"You are {count} years old");
            } else
            {
                Console.WriteLine("please enter a vaild age");
            }


            #endregion
        }
    }
}
