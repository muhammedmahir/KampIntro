using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T İtem)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1]; //dizinin elemn sayısını bir arttırıyorum.
            for (int i = 0; i < tempArray.length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = İtem;
        }

    }
}
