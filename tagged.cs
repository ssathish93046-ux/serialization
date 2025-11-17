using System;
class Program
{
   public static void Main()
   {
     int [][]x;
     x=new int[5][];
    x[0]=new int[2];
    x[1]=new int[5];
    x[2]=new int[3];
    x[3]=new int[4];
    x[4]=new int[1];    
     for(int i=0; i<x.Length; i++)
     {
       for(int j=0; j<x[i].Length; j++)
        {
          x[i][j]=int.Parse(System.Console.ReadLine());
         }
       }
      for(int i=0; i<x.Length; i++)
       {
         for(int j=0; j<x[i].Length; j++)
          {
            System.Console.Write(x[i][j]);
           }
           System.Console.WriteLine();
         }
      }
   }
