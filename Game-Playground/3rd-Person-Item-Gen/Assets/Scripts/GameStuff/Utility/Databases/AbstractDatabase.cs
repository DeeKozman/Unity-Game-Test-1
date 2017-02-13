using System.Collections.Generic;
using UnityEngine;

namespace ItemGen.Database
{
    public class AbstractDatabase<T> : ScriptableObject where T : IDatabaseAsset
    {
    }

    {
    [SerializeField] private List<T> _objects;

    protected List<T> Objects
    {
        get
        {
            if (_objects == null)
                _objects = new List<T>();
            return _objects;
        }
    }

    public int Count
    {
        get { return Objects.Count; }
    }

    public void Add(T t)
    {
        Objects.Add(t);
    }

    public void Remove(T t)
    {
        Objects.Remove(t);
    }

    public void RemoveAt(int index)
    {
        Objects.RemoveAt(index);
    }

    public bool Contains(T t)
    {
        return Objects.Contains(t);
    }

    public T GetAtIndex(int index)
    {
        if (Count > 0)
        {
            if (index >= 0 && index < Count)
                return Objects[index];
            return default(T);
        }
        return default(T);
    }
    }
}