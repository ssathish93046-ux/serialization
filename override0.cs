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
}
class Program
{
  public static void Main()
  {
    Parent p=new Parent();
    p.print();
    p=new Child();
    p.print();
   }
 }