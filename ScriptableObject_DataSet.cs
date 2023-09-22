using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObject_DataSet<T> : ScriptableObject 
{
    public List<T> _data;

    public List<T> Data
    {
        get => _data;
        set => _data = value;
    }
    public T this[int index]
    {
        get => _data[index];
        set => _data[index] = value;
    }
    public int Count => _data.Count;

    public void Add(T d)
    {
        _data.Add(d);
    }

    public void Remove(T d)
    {
        _data.Remove(d);
    }

    public void RemoveAt(int index)
    {
        _data.RemoveAt(index);
    }

    public T[] ToArray()
    {
        return _data.ToArray();
    }
}
