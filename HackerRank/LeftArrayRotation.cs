using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
  public class LeftArrayRotation
  {
    public static void LeftArrayMain(string[] args)
    {
      string[] tokens_n = Console.ReadLine().Split(' ');
      int n = Convert.ToInt32(tokens_n[0]);
      int d = Convert.ToInt32(tokens_n[1]);
      string[] a_temp = Console.ReadLine().Split(' ');
      int[] a = Array.ConvertAll(a_temp, Int32.Parse);
      int[] result = leftRotation(a, d);
      Console.WriteLine(String.Join(" ", result));

    }

    public static int[] leftRotation(int[] array, int numberOfRotations)
    {
      var output = new int[array.Length];
      var actualRotations = DetermineNumberOfRotations(numberOfRotations, array.Length);
      for (int i = 0; i < array.Length; i++)
      {
        var indexAfterRotation = GetIndexAfterRotation(i, array.Length, numberOfRotations);
        output[indexAfterRotation] = array[i];
      }
      return output;
    }

    private static int DetermineNumberOfRotations(int numberOfRotations, int length)
    {
      if (numberOfRotations > length)
      {
        return numberOfRotations - length;
      }
      return numberOfRotations;
    }

    private static int GetIndexAfterRotation(int actualPosition , int arrayLength , int numberOfRotations)
    {
      var changedPosition = actualPosition - numberOfRotations;
      if(changedPosition < 0)
      {
        return changedPosition + arrayLength;
      }
      return changedPosition;
    }
  }
}
