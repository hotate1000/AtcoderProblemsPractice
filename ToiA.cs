using System;
using System.Linq;

namespace AtcoderProblems
{
  class ToiA
  {
    public void A_Div(){
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(N - 1);
    }
    public void A_Rotate(){
        string N = Console.ReadLine();
        string stg1 = N.Substring(0,1);
        string stg2 = N.Remove(0,1);
        Console.WriteLine(stg2 + stg1);
    }

    public void SA(){
      string[] strX = Console.ReadLine().Split(' ');
      int[] intX = strX.Select(strX => int.Parse(strX)).ToArray();
			string[] strY = Console.ReadLine().Split(' ');
      int[] intY = strY.Select(strY => int.Parse(strY)).ToArray();

      Console.WriteLine(intX[1] - intY[0]);
    }
  }
}
