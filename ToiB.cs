using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtcoderProblems
{
  class ToiB
  {
  //190番台
    // 198条件付き回文チェック
    public void B_Palindrome_With_Leading_Zeros(){
      string strTrim = Console.ReadLine();
      strTrim = strTrim.TrimEnd('0'); //最終文字にある0を削除
      char[] cha = strTrim.ToCharArray();
      char[] chaArray = cha.Reverse().ToArray();
      bool judgment = true;
      if(object.ReferenceEquals(cha, chaArray))
      {
        judgment = true;
      }
      else if(cha == null || chaArray == null || cha.Length != chaArray.Length){
        judgment = false;
      }
      for (int i = 0; i < cha.Length; i++)
      {
        if(cha[i] != chaArray[i])
        {
          judgment = false;
          break;
        }
      }
      string str = (judgment)?"Yes":"No";
      Console.WriteLine(str);
    }

    // 197
    public void B_Visibility(){
    }

    // ★196小数点の切り下げ
    public void B_Round_Down(){
      string str = Console.ReadLine();
      //string str = "84939825309432908832902189.9092309409809091329";
      string str2 = Regex.Replace(str,@"\.\d*","");
      Console.WriteLine(str2);
    }

    // 195★みかんの数
    public void B_Many_Oranges(){
      string[] str = Console.ReadLine().Split(" ");
      int[] i = str.Select(str => int.Parse(str)).ToArray();
      int A = i[0];
      int B = i[1];
      int w = i[2];
      int minM = 0;
      int maxM = 0;
      for (int n=1; n<=w*1000; n++)
      {
        if(n*A <= w*1000 && w*1000 <= n * B)
        {
          minM = (minM == 0)? minM=n: minM;
          maxM = (maxM <= n)? maxM=n: maxM;
        }
      }
      if(minM == 0)
      {
        Console.WriteLine("UNSATISFIABLE");
      }
      else
      {
        Console.WriteLine(minM + " " + maxM);
      }
    }
        // ◆194最小値の取得
    public void B_Job_Assignment(){
            //       List<int> allJobList = new List<int>();
            // List<int> aJobList = new List<int>();
            // List<int> bJobList = new List<int>();

            // int a;
            // for(int sui=0; sui<3; sui++)
            // {
            //     string[] str = Console.ReadLine().Split(" ");
            //     int[] i = str.Select(str => int.Parse(str)).ToArray();
            //     allJobList.Add(i[0] + i[1]);
            //     aJobList.Add(i[0]);
            //     bJobList.Add(i[1]);


            // }

            // if(aJobList.Min() < bJobList.Min())
            // {
            //     a = aJobList.Min() + bJobList.Mi
            // }
    }
        // 193
    public void B_Play_(){
    }
  }
}