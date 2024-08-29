
namespace c_sharp_console
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string[,] table = new string[3, 3];
      bool isBreak = false;

      for (int i = 0; i < table.GetLength(0); i++)
      {
        for (int j = 0; j < table.GetLength(1); j++)
        {
          if (isBreak)
          {
            table[i, j] = "X";
            isBreak = false;
            Console.WriteLine(table[i, j]);
          }
          else
          {
            table[i, j] = "O";
            isBreak = true;
            Console.WriteLine(table[i, j]);
          }

        }
      }

    }
  }
}