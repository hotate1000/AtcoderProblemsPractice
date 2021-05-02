using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtcoderProblems
{
  class ToiB
  {
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





    // ★195みかんの数
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





    // ×194最小値の取得
    public void B_Job_Assignment(){
            //リストの作成
      string str = Console.ReadLine();
      int intN = int.Parse(str);
      List<int> intA = new List<int>();
      List<int> intB = new List<int>();
      List<int> intAB = new List<int>();
      for (int i = 0; i < intN; i++)
      {
          string[] strI = Console.ReadLine().Split(" ");
          intA.Add(int.Parse(strI[0]));
          intB.Add(int.Parse(strI[1]));
          intAB.Add(int.Parse(strI[0]) + int.Parse(strI[1]));
      }
      int min1A = 100000000;
      int min2A = 100000000;
      int min1B = 100000000;
      int min2B = 100000000;

      //最小と二番目
      for(int j=0; j < intA.Count; j++)
      {
          if(min1A > intA[j])
          {
              min2A = min1A;
              min1A = intA[j];
          }else if(min1B > intA[j])
          {
              min2A = intA[j];
          }
      }
      for (int j=0; j < intB.Count; j++)
      {
          if (min1B > intB[j])
          {
              min2B = min1B;
              min1B = intB[j];
          }
          else if (min2B > intB[j])
          {
              min2B = intB[j];
          }
      }
      int numA = intA.IndexOf(intA.Min()) + 1;
      int numB = intB.IndexOf(intB.Min()) + 1;
      //最小の番号が同じ、最小の値が同じ
      if(numA == numB && min1A == min1B){
        //二番目に小さい数値の大きさ判定
        if (min2A <= min2B)
        {
          if (min2A <= intAB.Min())
          {
            Console.WriteLine(min2A);
          }
          else
          {
            Console.WriteLine(intAB.Min());
          }
        }
          else if(min2A >= min2B)
        {
          if (min2B <= intAB.Min())
          {
            Console.WriteLine(min2B);
          }
          else
          {
            Console.WriteLine(intAB.Min());
          }
        }
      }else
      {
        int inta = 0;
        if(min2A < min2B)
        {
          inta = (min2A < min1B)?min1B:min2A;
        }
        else if(min2A > min2B)
        {
          inta = (min2B < min1A)?min1A:min2B;
        }
          int intb = (inta <= intAB.Min())?inta:intAB.Min();
          Console.WriteLine(intb);
      }
    }
    // 194最小値の取得（別回）
    public void B_Job_Assignment2(){
      string str = Console.ReadLine();
			//入力した数値を取得する
			int suu = int.Parse(str);
			int[] a = new int[suu];
			int[] b = new int[suu];
			//繰り返し処理を行う
			for (int i = 0; i < suu; i++)
			{
				string[] anbn = Console.ReadLine().Split(' ');
				//仕事Aと仕事B用の配列を作成する
				a[i] = int.Parse(anbn[0]);
				b[i] = int.Parse(anbn[1]);
			}
			//比較用の値を作成する
			int cnt = 0;
			int min = 100000;
			for (int k = 0; k < suu; k++)
			{
				for (int j = 0; j < suu; j++)
				{
					//配列の位置が同じ時
					if (k == j)
					{ 
						cnt = a[k] + b[j];
					}
					else 
					{ 
						//下から二番目の数値を取得するため
						cnt = Math.Max(a[k], b[j]); 
					}
					//全体、配列の位置が同じか、下から二番目の数値か確認する
					min = Math.Min(min, cnt);
				}
			}
			Console.WriteLine(min.ToString());
    }



    // 193:製品の購入可否判断
    public void B_Play_Snuke(){
      int N = int.Parse(Console.ReadLine());
      List<int> Answer = new List<int>();
			int stock = -1;
			for (int j=0; j<N; j++){
				string[] str = Console.ReadLine().Split(" ");
				int[] inti = str.Select(str => int.Parse(str)).ToArray();
				stock = inti[2] - inti[0];
          if (stock > 0)
          {
            Answer.Add(inti[1]);
          }
			}
			int intAnswer = (Answer.Count != 0)? Answer.Min() : -1;
			Console.WriteLine(intAnswer);
    }


    // 192:文字列の大文字小文字
    public void B_uNrEaDaBLE_sTrinG(){
      string str = Console.ReadLine();
			char[] c1 = str.ToCharArray();
        bool judgment = true;
			for (int i=0; i<c1.Length; i++ )
      {
        //奇数
				if(i % 2 == 0 && !char.IsLower(c1[i]))
        {
            judgment = false;
            break;
        }
        //偶数
				else if(i % 2 == 1 && !char.IsUpper(c1[i]))
        {
            judgment = false;
            break;
        }
      }
      string answer = (judgment)?"Yes":"No";
      Console.WriteLine(answer);
    }
  }
}




