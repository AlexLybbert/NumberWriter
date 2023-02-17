namespace NumberWriterLib
{
    public class NumberWriter
    {
        public IEnumerable<string> WriteNumbers(int upperBound, Tuple<int, string> numberWord1, Tuple<int, string> numberWord2)
        {
            for (int i = 1; i <= upperBound; i++)
            {
                string output = string.Empty;
                if (i % numberWord1?.Item1 == 0)
                {
                    output += numberWord1?.Item2;
                }
                if (i % numberWord2?.Item1 == 0)
                {
                    output += (output == string.Empty ? "" : " ") + numberWord2?.Item2;
                }
                yield return output == string.Empty ? $"{i}" : output;
            }
        }
    }
}