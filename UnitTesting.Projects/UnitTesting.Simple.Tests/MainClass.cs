using System;

namespace UnitTesting.Simple.Tests
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.ReadLine();
                Console.WriteLine("Starting");
                SimpleParserTests.TestReturnsZeroWhenEmptyString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}