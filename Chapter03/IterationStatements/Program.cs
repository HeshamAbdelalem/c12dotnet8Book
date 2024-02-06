using System.Collections;

namespace IterationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While Loop
            //int x = 0;

            //while (x < 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} 
            #endregion

            #region Do..While Loop

            //string? currentPassword = "Hesham";
            //string? password;
            //byte tryAttempt = 0;



            //do
            //{
            //    Console.WriteLine("Enter Your Password:");
            //    password = Console.ReadLine();
            //    tryAttempt++;
            //    if (tryAttempt == 3)
            //    {
            //        Console.WriteLine("too many attempts!!!!");
            //        return;
            //    }

            //} while (password != currentPassword);
            //Console.WriteLine("Password Correct!");




            #endregion

            #region For & Foreach Loop

            //for (int i = 0; i <= 10; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            string[] names = { "Hesham", "Magdy", "Atta", "Abdelalem" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine($"{name}");
            //}

            IEnumerator e = names.GetEnumerator();

            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);

            }

            #endregion
        }
    }
}
