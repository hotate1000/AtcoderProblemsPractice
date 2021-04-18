using System;
using System.Linq;
using System.Collections.Generic;

namespace AtcoderProblems
{
  class ToiA
  {
  //190番台
    // 198割合確認
    public void A_Div(){
      int N = int.Parse(Console.ReadLine());
      Console.WriteLine(N - 1);
    }

    // 197先頭文字最後
    public void A_Rotate(){
      string N = Console.ReadLine();
      string stg1 = N.Substring(0,1);
      string stg2 = N.Remove(0,1);
      Console.WriteLine(stg2 + stg1);
    }

    // 196最大値―最小値
    public void A_Difference_Max(){
      string[] strX = Console.ReadLine().Split(' ');
      int[] intX = strX.Select(strX => int.Parse(strX)).ToArray();
      string[] strY = Console.ReadLine().Split(' ');
      int[] intY = strY.Select(strY => int.Parse(strY)).ToArray();
      Console.WriteLine(intX[1] - intY[0]);
    }

    // 195÷時のあまり
    public void A_Health_M_Death(){
      string[] str = Console.ReadLine().Split(" ");
      int[] i = str.Select(str => int.Parse(str)).ToArray();
      string yes = "Yes";
      string no = "No";
      if (i[1] % i[0] == 0) {
        Console.WriteLine(yes);
      } else {
        Console.WriteLine(no);
      }
    }

    //194アイス成分判断
    public void A_L_Scream(){
      string[] str = Console.ReadLine().Split(' ');
      int[] i = str.Select(str => int.Parse(str)).ToArray();
      int notFatMilk = i[0];
      int milkFat = i[1];
      int milkSolids = notFatMilk + milkFat;
      if (milkSolids >= 15 && milkFat >= 8) {
        Console.WriteLine(1);
      } else if (milkSolids >= 10 && milkFat >= 3) {
        Console.WriteLine(2);
      } else if (milkSolids >= 3) {
        Console.WriteLine(3);
      } else {
        Console.WriteLine(4);
      }
    }

    //193定価計算
    public void A_Discount(){
      string[] str = Console.ReadLine().Split(" ");
      double[] i = str.Select(str => double.Parse(str)).ToArray();
      double A = i[0];
      double B = i[1];
      double ListPrice = (A - B) / A * 100;
      Console.WriteLine(ListPrice);
    }

    //192
    public void A_Star(){
      int i = int.Parse(Console.ReadLine());
      int untilGetAReward = 100 - i % 100;
      Console.WriteLine(untilGetAReward);
    }

    //191
    public void A_Vanishing_Pitch(){
      string[] str = Console.ReadLine().Split(' ');
      int[] i = str.Select(str => int.Parse(str)).ToArray();
      int startToDisappearing = i[0] * i[1];
      int endToDisappearing = i[0] * i[2];
      int distance = i[3];
      if(startToDisappearing <= distance && distance <= endToDisappearing) {
        Console.WriteLine("No");
      } else {
        Console.WriteLine("Yes");
      }
    }

    //190勝者の判断
    public void A_Very_Very_Primitive_Game(){
      string[]  str = Console.ReadLine().Split(" ");
      int[] i = str.Select(str => int.Parse(str)).ToArray();
      int playerLifeA = i[0];
      int playerLifeB = i[1];
      int firstStrike = i[2];
      //間違った例
      //while(!(playerLifeA == 0 || playerLifeB == 0))
      //{
      //    if(firstStrike == 0)
      //    {
      //        playerLifeA--;
      //        if(playerLifeA == 0)
      //        {
      //            Console.WriteLine("Aoki");
      //            break;
      //        }
      //        playerLifeB--;
      //        if (playerLifeB == 0)
      //        {
      //            Console.WriteLine("Takahashi");
      //            break;
      //        }
      //    }
      //    else if(firstStrike == 1)
      //    {
      //        playerLifeB--;
      //        if (playerLifeB == 0)
      //        {
      //            Console.WriteLine("Takahashi");
      //            break;
      //        }
      //        playerLifeA--;
      //        if (playerLifeA == 0)
      //        {
      //            Console.WriteLine("Aoki");
      //            break;
      //        }
      //    }
      //}
      //三条演算子で簡単に
      string winnerJudgment = ((playerLifeA + firstStrike) > playerLifeB) ? "Takahashi":"Aoki";
      Console.WriteLine(winnerJudgment);
    }

  //180番台
    //189同文字があるか検索
    public void A_Slot(){
      string str = Console.ReadLine();
      char[] ch = str.ToCharArray();

      for(int i=0; i < ch.Length; i++)
      {
          if(ch[0] != ch[i]) {
            Console.WriteLine("Lost");
            break;
          }
          if(i+1 == ch.Length) {
            Console.WriteLine("Won");
          }
      }
    }

    //188ポイント差
    public void A_Three_Point_Shot(){
      string[] str = Console.ReadLine().Split(" ");
      int[] i = str.Select(str => int.Parse(str)).ToArray();
      string a = (i.Max() - i.Min() < 3)?"Yes":"No";
      Console.WriteLine(a);
    }
    
    //187★数値分解し、比較
    public void A_Large_Digits(){
      string[] str = Console.ReadLine().Split();
      int[] i = str.Select(str => int.Parse(str)).ToArray();
      List<int> listInt = new List<int>();
      for(int fi=0; fi < i.Length; fi++)
      {
        int count = 0;
        while(i[fi] > 0)
        {
        count += i[fi] % 10;
        i[fi] = i[fi] / 10;
        }
        listInt.Add(count);
      }
      Console.WriteLine(listInt.Max());
    }

    //186小数点の切り捨て
    public void A_Brick(){
      string[] str = Console.ReadLine().Split(" ");
      int TotalAmount = int.Parse(str[0]);
      int BrickAmount = int.Parse(str[1]);
      double Answer = TotalAmount / BrickAmount;
      Console.WriteLine(Math.Floor(Answer));
    }
    //185最小値を求める
    public void A_ABC_Preparation(){
      string[] str = Console.ReadLine().Split(" ");
      int[] i = str.Select(str => int.Parse(str)).ToArray();
      Console.WriteLine(i.Min());
    }
    //184クロスの掛け算
    public void A_Determinant(){
      string[] str1 = Console.ReadLine().Split(" ");
      int[] i1 = str1.Select(str => int.Parse(str)).ToArray();
      string[] str2 = Console.ReadLine().Split(" ");
      int[] i2 = str2.Select(str => int.Parse(str)).ToArray();
      int Anser = i1[0]*i2[1] - i1[1] * i2[0];
      Console.WriteLine(Anser);
    }
  }
}
