using System.Windows.Forms;
using System.Drawing;

partial class MyForm
{
    private TextBox tb1,tb2,tb3;
    private Button btn;

         public void InitializeComponent()
         {
            tb1=new TextBox();
            tb1.Location=new Point(100,100);
            tb2=new TextBox();
	    tb2.Location=new Point(100,150);
            tb3=new TextBox();
            tb3.Location=new Point(100,200);
            btn=new Button();
            btn.Location=new Point(100,250);
            btn.Text="ok";
            btn.Click+=new EventHandler(do_sum);
            this.Controls.Add(tb1);
            this.Controls.Add(tb2);
            this.Controls.Add(tb3);
            this.Controls.Add(btn);
          }



} 