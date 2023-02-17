// See https://aka.ms/new-console-template for more information

using NumberWriterLib;


var numbWriter = new NumberWriter();
foreach (string i in numbWriter.WriteNumbers(int.MaxValue, new Tuple<int, string>(3, "Fizz"), new Tuple<int, string>(5, "Buzz")))
{
    Console.WriteLine(i);
}

Console.ReadLine();