using System;
using System.Collections.Generic;
using System.Linq;

public class Generic<T> where T : struct
{
    private List<T> values;

    public Generic()
    {
        values = new List<T>();
    }

    public void Add(T item)
    {
        values.Add(item);
    }

    public T Get(int index)
    {
        if (index >= values.Count)
        {
            throw new IndexOutOfRangeException();
        }

        return values[index];
    }

    public List<T> GetDescending()
    {
        List<T> descendingList = values.OrderByDescending(x => x).ToList();
        return descendingList;
    }
}
