public class FizzBuzz
{
  public static void main(String[] args) {
    for (int i = 1; i <= 100; i++) {
      System.out.println(FizzBuzzCheck(i));
    }
  }

  private static String FizzBuzzCheck(int i) {

    if (i % 15 == 0) {
      return "FizzBuzz";
    }

    if (i % 3 == 0) {
      return "Fizz";
    }

    if (i % 5 == 0) {
      return "Buzz";
    }
    return Integer.toString(i);
  }

}
