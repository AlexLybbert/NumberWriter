namespace NumberWriterLib
{
    public class NumberWriter
    {
        public IEnumerable<string> WriteNumbers(int upperBound)
        {
            for (var i = 1; i <= upperBound; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    yield return "Fizz Buzz";
                }
                else if (i % 3 == 0)
                {
                    yield return "Fizz";
                }
                else if (i % 5 == 0)
                {
                    yield return "Buzz";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}