using System;
using System.Globalization;

namespace FizzBuzz
{
  class Program
  {
    static void Main()
    {
      for (int i = 1; i <= 100; i++)
      {
        Console.WriteLine(FizzBuzzCheck(i));
      }
      Console.ReadLine();
    }

    private static string FizzBuzzCheck(int i)
    {
      string output = String.Empty;

      if (i % 3 == 0)
      {
        output = "Fizz";
      }

      if (i % 5 == 0)
      {
        output += "Buzz";
      }

      if (String.IsNullOrEmpty(output))
      {
        output = i.ToString(CultureInfo.InvariantCulture);
      }

      return output;
    }
  }
}
