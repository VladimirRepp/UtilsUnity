using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool<T> : MonoBehaviour
{
    protected List<T> _poolData;
    protected int _currentIndex = 0;
    protected bool _isLoop = true;

    public List<T> Data => _poolData;
    public int Count => _poolData.Count;
    public T this[int index]
    {
        get => _poolData[index];
        set => _poolData[index] = value;
    }

    public Pool()
    {
        _poolData = new List<T>();
    }

    public void InitializationPool(T[] data)
    {
        foreach (T d in data)
        {
            _poolData.Add(d);
        }
    }

    public void InitializationPool(ref T[] data)
    {
        foreach (T d in data)
        {
            _poolData.Add(d);
        }
    }

    public void InitializationPool(List<T> data)
    {
        foreach (T d in data)
        {
            _poolData.Add(d);
        }
    }

    public void AddInPool(T d)
    {
        _poolData.Add(d);
    }

    public void RemoveAtPool(int index)
    {
        _poolData.RemoveAt(index);
    }

    public void RemoveInPool(T item)
    {
        _poolData.Remove(item);
    }

    public bool TryGetCurrent(out T data)
    {
        data = _poolData[_currentIndex];

        return _poolData[_currentIndex] == null ?
            false : true;
    }

    public bool TryGetNext(out T data)
    {
        data = default;

        if (_currentIndex >= _poolData.Count - 1 && !_isLoop)
            return false;

        _currentIndex = _currentIndex + 1 >= _poolData.Count ?
            0 : _currentIndex + 1;

        data = _poolData[_currentIndex];
        return true;
    }

    public bool TryGetPrev(out T data)
    {
        data = default;

        if (_currentIndex <= 0 && !_isLoop)
            return false;

        _currentIndex = _currentIndex - 1 < 0 ?
            _poolData.Count - 1 : _currentIndex - 1;

        data = _poolData[_currentIndex];
        return true;
    }

    public bool TryStepCurrentToNext()
    {
        if (_currentIndex >= _poolData.Count - 1 && !_isLoop)
            return false;

        _currentIndex = _currentIndex + 1 >= _poolData.Count ?
            0 : _currentIndex + 1;
        return true;
    }

    public bool TryStepCurrentToPrev()
    {
        if (_currentIndex <= 0 && !_isLoop)
            return false;

        _currentIndex = _currentIndex - 1 < 0 ?
           _poolData.Count - 1 : _currentIndex - 1;
        return true;
    }

    public T GetCurrent()
    {
        return _poolData[_currentIndex];
    }

    public T GetNext()
    {
        if (_currentIndex >= _poolData.Count - 1 && !_isLoop)
            return default;

        _currentIndex = _currentIndex + 1 >= _poolData.Count ?
            0 : _currentIndex + 1;

        return _poolData[_currentIndex];
    }

    public T GetPrev()
    {
        if (_currentIndex <= 0 && !_isLoop)
            return default;

        _currentIndex = _currentIndex - 1 < 0 ?
            _poolData.Count - 1 : _currentIndex - 1;

        return _poolData[_currentIndex];
    }

    public void StepCurrentToNext()
    {
        if (_currentIndex >= _poolData.Count - 1 && !_isLoop)
            throw new System.IndexOutOfRangeException();

        _currentIndex = _currentIndex + 1 >= _poolData.Count ?
           0 : _currentIndex + 1;
    }

    public void StepCurrentToPrev()
    {
        if (_currentIndex <= 0 && !_isLoop)
            throw new System.IndexOutOfRangeException();

        _currentIndex = _currentIndex - 1 < 0 ?
            _poolData.Count - 1 : _currentIndex - 1;
    }

    public void PoolMix()
    {
        System.Random random = new System.Random();

        for (int i = _poolData.Count - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);

            var temp = _poolData[j];
            _poolData[j] = _poolData[i];
            _poolData[i] = temp;
        }
    }
}
