
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
  public class HourGlass
  {
    public static void HourGlassMain(string[] args)
    {
      int[][] arr = new int[6][];
      for (int arr_i = 0; arr_i < 6; arr_i++)
      {
        string[] arr_temp = Console.ReadLine().Split(' ');
        arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
      }

      Console.WriteLine(CalMaxHourGlassValue(arr));

    }

    public static int CalMaxHourGlassValue(int[][] arr)
    {
      var hourGlasses = SplitIntoHourGlasses(arr);
      var maxValue = GetMaxHourGlassValue(hourGlasses);
      return maxValue;
    }

    private static int GetMaxHourGlassValue(List<int[][]> hourGlasses)
    {
      int maxHourGlassSum = -100;
      for (int i = 0; i < hourGlasses.Count; i++)
      {
        var hourGlass = hourGlasses[i];
        var sum = hourGlass[0][0] + hourGlass[0][1] + hourGlass[0][2]
                                  + hourGlass[1][1]
                 + hourGlass[2][0] + hourGlass[2][1] + hourGlass[2][2];
        if (sum > maxHourGlassSum)
        {
          maxHourGlassSum = sum;
        }
      }
        return maxHourGlassSum;
    }

    private static List<int[][]> SplitIntoHourGlasses(int[][] input)
    {
      var maxIterationsPossible = 4;
      var rowIteration = 4;
      List<int[][]> hourGlasses = new List<int[][]>();
      for (int j = 0; j < maxIterationsPossible; j++)
      {
        for (int i = 0; i < maxIterationsPossible; i++)
        {
          int[][] hourGlass = new int[3][];
          hourGlass[0] = new int[] { input[i][j], input[i][j + 1], input[i][j + 2] };
          hourGlass[1] = new int[] { input[i + 1][j], input[i + 1][j + 1], input[i + 1][j + 2] };
          hourGlass[2] = new int[] { input[i + 2][j], input[i + 2][j + 1], input[i + 2][j + 2] };
          hourGlasses.Add(hourGlass);
        }

      }
      return hourGlasses;
    }
  }
}
