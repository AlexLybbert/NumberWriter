// See https://aka.ms/new-console-template for more information

using NumberWriterLib;


var numbWriter = new NumberWriter();
foreach (string i in numbWriter.WriteNumbers(int.MaxValue))
{
    Console.WriteLine(i);
}

Console.ReadLine();