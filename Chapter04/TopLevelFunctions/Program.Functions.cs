partial class Program
{
    static void WhatsMyNamespace()
    {
        Console.WriteLine("{0}", arg0: typeof(Program).Namespace ?? "null");
    }
}