//using System.Reflection;
//using System.Net.Http;//To use Assembly , TypeName, and so on ..


//namespace Vocabulary
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("hello world");

//            Assembly? myApp = Assembly.GetEntryAssembly();

//            if (myApp is null) return;

//            foreach (AssemblyName name in myApp.GetReferencedAssemblies())
//            {
//                Assembly a = Assembly.Load(name);

//                int methodCount = 0;

//                foreach (TypeInfo t in a.DefinedTypes)
//                {
//                    methodCount += t.GetMethods().Length;
//                }
//                Console.WriteLine("{0:No} Types with {1:No} methods in {2} assembly.",
//                    arg0: a.DefinedTypes.Count(),
//                    arg1: methodCount,
//                    arg2: name.Name);

//            }

//            Console.ReadLine();
//        }
//    }
//}


var person = new {firstName= "Hesham" , Age= 35};

string json = $$"""
        {
        firstName: {{person.firstName}},
        Age: {{person.Age}}
        }
        """;

Console.WriteLine(json);
Console.ReadLine();