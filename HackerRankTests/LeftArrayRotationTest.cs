using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTests
{
  [TestClass]
  public class LeftArrayRotationTest
  {
    [TestMethod]
    public void TestLeftArrayRotationImplementation()
    {
      var input = new int[] { 1, 2, 3, 4, 5 }; 
      var expected = new int[] { 5, 1, 2, 3, 4 };
      var numberOfLeftRotations = 4; 
      var output = LeftArrayRotation.leftRotation(input, numberOfLeftRotations);
      Assert.IsTrue(expected.SequenceEqual(output));
    }
  }
}
