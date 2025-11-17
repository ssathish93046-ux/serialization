struct student
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
 }
 class Program
{
 public  static void Main()
 {
  student [] S;
  S=new student[5];
 for(int i=0; i<5; i++)
  {
   S[i].read();
   }
    for(int i=0; i<5; i++)
     {
       S[i].print();
      }
 } 
}
    
 
