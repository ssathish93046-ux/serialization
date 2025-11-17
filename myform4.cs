
 class MyForm1: System.Windows.Forms.Form
 {
   private System.Windows.Forms.TextBox tb1;
   private System.Windows.Forms.Button btn;

   public MyForm1()
   {
      
      tb1=new System.Windows.Forms.TextBox();
      tb1.Location=new System.Drawing.Point(100,100); 
      
      btn=new System.Windows.Forms.Button();
      btn.Text="ok";
      btn.Click+=new System.EventHandler(btn_click);
      btn.Location=new System.Drawing.Point(100,200);
     

      Controls.Add(tb1);
      Controls.Add(btn);
   }
   private void btn_click(System.Object o,System.EventArgs e)
   {
      MyForm2 frm2=new MyForm2();
     
      frm2.Show();
      
   }
  

}
class MyForm2: System.Windows.Forms.Form
{
   private System.Windows.Forms.TextBox tb2;
   private System.Windows.Forms.Button btn;
 

   public MyForm2()
   {
 
      tb2=new System.Windows.Forms.TextBox();
      tb2.Location=new System.Drawing.Point(100,100); 
      
      btn=new System.Windows.Forms.Button();
      btn.Text="ok";
      btn.Click+=new System.EventHandler(btn_click);
      btn.Location=new System.Drawing.Point(100,200);
     

      Controls.Add(tb2);
      Controls.Add(btn);
   }
   private void btn_click(System.Object o,System.EventArgs e)
   {
     
    
   }
   
 }


 class program
 {
   public static void Main(string []args)
   {
      MyForm1 frm1=new MyForm1();
      System.Windows.Forms.Application.Run(frm1);
     
     
      
    }
 }


     
 	
