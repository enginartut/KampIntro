using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Generic içine <> işaretleri arasına string, int yazılabilceği gibi
    //bir sınıfta yazılabilir. Herhangi bir seyde yazılabilir...
    //ama genellikle Type anlamında T yazılır..
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }

        }

        public T[] Items
        {
            get { return items; }

        }
    }
}
