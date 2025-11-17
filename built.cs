using System;

class MyList
{
    private object[] items;
    private int i;
   

    public MyList()
    {
        items = new object[5];
        i = 0;
    }

    public void Add(object value)
    {
        if (i == items.Length)
        {
            Resize();
        }
        items[i++] = value;
    }

    private void Resize()
    {
       
        for (int i = 0; i < items.Length; i++)
        {
            newItems[i] = items[i];
        }
        items = newItems;
    }

    public object Get(int index)
    {
        if (index < 0 || index >= i)
         {
             return items[index];
         }
    }

    public int count
    {
        get { return count; }
    }
}