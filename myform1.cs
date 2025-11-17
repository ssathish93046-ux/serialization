/*
	Console apps : cui ( character user interface ) dos based applications.
	
	Windows apps : gui graphical user interface.
 	
	build in libraries:
	
		System.dll
		System.Windows.Forms.dll
		System.Drawing.dll.

	window/form/frame/container

	OS----->creates----->process------->thread(1)------>main runs.

	WindowsMessageLoop.

	Click is the object of EventHandler delegate.
	
		EventHandler(Object,EventArgs);
*/



class program
{

	public static void btn_click(System.Object o,System.EventArgs e)
	{
	         System.Windows.Forms.Button btn = (Button)o; 
		System.Windows.Forms.MessageBox.Show( btn.Text);
	}
	
	public static void Main()
	{
		System.Windows.Forms.Form	frm;

		System.Windows.Forms.Button	btn;
		
		frm=new System.Windows.Forms.Form();
		
 
		int x,y;
	    	for(int i=0; i <5; i++)
		{
			for(int j=0; j<5; j++)
			{	
		          btn=new System.Windows.Forms.Button();
			  		
		        	x = 50 + 90;           
		                y = 50 + 50;       


		          btn.Location=new System.Drawing.Point(x,y); //point is a structure.
			 
		          btn.Text=("ok");
		 
		          btn.Click+=new System.EventHandler(btn_click);	
		          frm.Controls.Add(btn);

			  
		        }
		}
     	    
		System.Windows.Forms.Application.Run(frm);//create a message loop and also calls show method.
		//run method should be used only once through out the application.
		
		
	}
}