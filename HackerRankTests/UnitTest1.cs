using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;

namespace HackerRankTests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestHourGlass()
    {
      int[][] input = new int[6][];

      input[0] = new int[] { 1, 1, 1, 0, 0, 0 };
      input[1] = new int[] { 0, 1, 0, 0, 0, 0 };
      input[2] = new int[] { 1, 1, 1, 0, 0, 0 };
      input[3] = new int[] { 0, 0, 2, 4, 4, 0 };
      input[4] = new int[] { 0, 0, 0, 2, 0, 0 };
      input[5] = new int[] { 0, 0, 1, 2, 4, 0 };

      int[][] input2 = new int[6][];

      input2[0] = new int[] { 0 ,- 4 ,- 6, 0, - 7, - 6 };
      input2[1] = new int[] { -1 ,- 2 ,- 6, - 8, - 3 ,- 1 };
      input2[2] = new int[] { -8, - 4, - 2, - 8 ,- 8, - 6 };
      input2[3] = new int[] { -3 ,- 1 ,- 2, - 5, - 7, - 4 };
      input2[4] = new int[] { -3, - 5, - 3, - 6 ,- 6, - 6 };
      input2[5] = new int[] { -3 ,- 6, 0 ,- 8, - 6, - 7 };


      var maxHourGlass = HourGlass.CalMaxHourGlassValue(input2);

      Assert.AreEqual(-19, maxHourGlass);
    }
  }
}
