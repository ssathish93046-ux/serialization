class Parent 
{
 public virtual void print()
 {
   System.Console.WriteLine("from Parent print");
 }
}
class Child:Parent
{
 public override void print()
 {
   System.Console.WriteLine("from Child print");
  
 }
 public void print(int val)
 {
   System.Console.WriteLine("from child print {0}",val);
 }
}
class Program
{
  public static void Main()
  {
    Parent p=new Child();
    p.print();
    ((Child)p).print(100);
   }
 }