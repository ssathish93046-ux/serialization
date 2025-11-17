// 50 arrays 
class Program
{
  public static void Main()
  {
   int [][]x;
   x=new int [50][];                                    //declared 50 arryas
    for(int i=0; i<x.Length; i++)
     {
        x[i]=new int[i+1];                                   //each row gets i+1 elements
    
     for(int j=0; j<=i; j++)
     {
      x[i][j]=j+1;                                          //fill the values 1 to i+1
     }
    }
     for(int i=0; i<x.Length; i++)
     { 
      for(int j=0; j<x[i].Length; j++)
      {
        System.Console.Write( x[i][j]);
      }
       System.Console.WriteLine();
    }
   }
}