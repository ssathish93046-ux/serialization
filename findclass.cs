class student
{
   private int Sno;
   private string Sname;
   private double fee;
   public void read() 
   {
     Sno=int.Parse(System.Console.ReadLine());
     Sname=System.Console.ReadLine();
     fee=double.Parse(System.Console.ReadLine());
    }
   public void print()
   {
     System.Console.WriteLine("{0} {1} {2} ", Sno,Sname,fee);
    }
  public int getSno()
   {
      return(Sno);
    }
 }
 class Program
 {
   public  static void Main()
   {
   
    student [] S;
    S=new student[5];
    for(int i=0; i<5.Length; i++)
    {
      S[i]=new student ();
      S[i].read();
     }
    int tSno=int.Parse(System.Console.ReadLine());

    for(int i=0; i<5.Length; i++)
    {
       if(S[i].getSno()==tSno);
       {
         S[i].print();
         break;
       }
    } 
  }
}
    
 
