class Parent 
{
 public void print()
 {
   System.Console.WriteLine("from Parent print");
 }
}
class Child:Parent
{
 public void print()
 {
   System.Console.WriteLine("from Child print");
 }
}
class Program
{
  public static void Main()
  {
    Parent p=new Parent();
    Child c=new Child();
    p.print();
    c.print();
   }
 }