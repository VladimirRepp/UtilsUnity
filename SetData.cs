using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetData<T> : MonoBehaviour
{
    protected List<T> _setData;
    protected int _currentIndex = 0;
    protected bool _isLoop = true;

    public List<T> Data => _setData;
    public int Count => _setData.Count;
    public T this[int index]
    {
        get => _setData[index];
        set => _setData[index] = value;
    }

    public SetData()
    {
        _setData = new List<T>();
    }

    public void InitializationSet(T[] data)
    {
        foreach (T d in data)
        {
            _setData.Add(d);
        }
    }

    public void InitializationSet(ref T[] data)
    {
        foreach (T d in data)
        {
            _setData.Add(d);
        }
    }

    public void InitializationSet(List<T> data)
    {
        foreach (T d in data)
        {
            _setData.Add(d);
        }
    }

    public void AddInSet(T d)
    {
        _setData.Add(d);
    }

    public void RemoveAtSet(int index)
    {
        _setData.RemoveAt(index);
    }

    public void RemoveInSet(T item)
    {
        _setData.Remove(item);
    }

    public bool TryGetCurrent(out T data)
    {
        data = _setData[_currentIndex];

        return _setData[_currentIndex] == null ?
            false : true;
    }

    public bool TryGetNext(out T data)
    {
        data = default;

        if (_currentIndex >= _setData.Count - 1 && !_isLoop)
            return false;

        _currentIndex = _currentIndex + 1 >= _setData.Count ?
            0 : _currentIndex + 1;

        data = _setData[_currentIndex];
        return true;
    }

    public bool TryGetPrev(out T data)
    {
        data = default;

        if (_currentIndex <= 0 && !_isLoop)
            return false;

        _currentIndex = _currentIndex - 1 < 0 ?
            _poolData.Count - 1 : _currentIndex - 1;

        data = _setData[_currentIndex];
        return true;
    }

    public bool TryStepCurrentToNext()
    {
        if (_currentIndex >= _setData.Count - 1 && !_isLoop)
            return false;

        _currentIndex = _currentIndex + 1 >= _setData.Count ?
            0 : _currentIndex + 1;
        return true;
    }

    public bool TryStepCurrentToPrev()
    {
        if (_currentIndex <= 0 && !_isLoop)
            return false;

        _currentIndex = _currentIndex - 1 < 0 ?
           _setData.Count - 1 : _currentIndex - 1;
        return true;
    }

    public T GetCurrent()
    {
        return _setData[_currentIndex];
    }

    public T GetNext()
    {
        if (_currentIndex >= _setData.Count - 1 && !_isLoop)
            return default;

        _currentIndex = _currentIndex + 1 >= _setData.Count ?
            0 : _currentIndex + 1;

        return _setData[_currentIndex];
    }

    public T GetPrev()
    {
        if (_currentIndex <= 0 && !_isLoop)
            return default;

        _currentIndex = _currentIndex - 1 < 0 ?
            _setData.Count - 1 : _currentIndex - 1;

        return _setData[_currentIndex];
    }

    public void StepCurrentToNext()
    {
        if (_currentIndex >= _setData.Count - 1 && !_isLoop)
            throw new System.IndexOutOfRangeException();

        _currentIndex = _currentIndex + 1 >= _setData.Count ?
           0 : _currentIndex + 1;
    }

    public void StepCurrentToPrev()
    {
        if (_currentIndex <= 0 && !_isLoop)
            throw new System.IndexOutOfRangeException();

        _currentIndex = _currentIndex - 1 < 0 ?
            _setData.Count - 1 : _currentIndex - 1;
    }

    public void SetMix()
    {
        System.Random random = new System.Random();

        for (int i = _setData.Count - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);

            var temp = _setData[j];
            _setData[j] = _setData[i];
            _setData[i] = temp;
        }
    }
}
