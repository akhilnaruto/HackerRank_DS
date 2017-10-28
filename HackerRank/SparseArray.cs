using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
  public class SparseArray
  {
    public static void Main(string[] args)
    {
      var numberOfStrings = Convert.ToInt32(Console.ReadLine());
      var inputStrings = new List<string>();
      for (int i = 0; i < numberOfStrings; i++)
      {
        inputStrings.Add(Console.ReadLine());
      }
      var numberOfQueries = Convert.ToInt32(Console.ReadLine());
      var queries = new List<string>();
      for (int i = 0; i < numberOfQueries; i++)
      {
        queries.Add(Console.ReadLine());
      }
      foreach (var query in queries)
      {
        var executeQuery = inputStrings.Where(x => x.Equals(query)).ToList();
        Console.WriteLine(executeQuery.Count);
      }
      Console.ReadLine();
    }
  }
}
