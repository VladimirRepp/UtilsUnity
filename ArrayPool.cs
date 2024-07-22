using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace DataSpace
{
    public class ArrayPool<T> : MonoBehaviour where T : ICloned
    {
        protected T[] _poolData;
        protected int _currentIndex = 0;
        protected bool _isLoop = true;

        public T[] Data => _poolData;
        public int Count => _poolData.Length;
        public T this[int index]
        {
            get => _poolData[index];
            set => _poolData[index] = value;
        }

        public ArrayPool(int count)
        {
            _poolData = new T[count];
        }

        public ArrayPool()
        {
            _poolData = new T[0];
        }

        public void InitializationPool(T data, int count)
        {
            _poolData = new T[count];

            for (int i = 0; i < count; i++)
            {
                T newData = (T)data.Clone();
                _poolData[i] = newData;
            }
        }

        public void InitializationPool(T data)
        {
            for (int i = 0; i < Count; i++)
            {
                T newData = (T)data.Clone();
                _poolData[i] = newData;
            }
        }

        public void InitializationPool(ref T[] data)
        {
            for (int i = 0; i < Count; i++)
            {
                _poolData[i] = data[i];
            }
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

            if (_currentIndex >= _poolData.Length - 1 && !_isLoop)
                return false;

            _currentIndex = _currentIndex + 1 >= _poolData.Length ?
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
                _poolData.Length - 1 : _currentIndex - 1;

            data = _poolData[_currentIndex];
            return true;
        }

        public bool TryStepCurrentToNext()
        {
            if (_currentIndex >= _poolData.Length - 1 && !_isLoop)
                return false;

            _currentIndex = _currentIndex + 1 >= _poolData.Length ?
                0 : _currentIndex + 1;
            return true;
        }

        public bool TryStepCurrentToPrev()
        {
            if (_currentIndex <= 0 && !_isLoop)
                return false;

            _currentIndex = _currentIndex - 1 < 0 ?
               _poolData.Length - 1 : _currentIndex - 1;
            return true;
        }

        public T GetCurrent()
        {
            return _poolData[_currentIndex];
        }

        public T GetNext()
        {
            if (_currentIndex >= _poolData.Length - 1 && !_isLoop)
                return default;

            _currentIndex = _currentIndex + 1 >= _poolData.Length ?
                0 : _currentIndex + 1;

            return _poolData[_currentIndex];
        }

        public T GetPrev()
        {
            if (_currentIndex <= 0 && !_isLoop)
                return default;

            _currentIndex = _currentIndex - 1 < 0 ?
                _poolData.Length - 1 : _currentIndex - 1;

            return _poolData[_currentIndex];
        }

        public void StepCurrentToNext()
        {
            if (_currentIndex >= _poolData.Length - 1 && !_isLoop)
                throw new System.IndexOutOfRangeException();

            _currentIndex = _currentIndex + 1 >= _poolData.Length ?
               0 : _currentIndex + 1;
        }

        public void StepCurrentToPrev()
        {
            if (_currentIndex <= 0 && !_isLoop)
                throw new System.IndexOutOfRangeException();

            _currentIndex = _currentIndex - 1 < 0 ?
                _poolData.Length - 1 : _currentIndex - 1;
        }

        public void PoolMix()
        {
            System.Random random = new System.Random();

            for (int i = _poolData.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                var temp = _poolData[j];
                _poolData[j] = _poolData[i];
                _poolData[i] = temp;
            }
        }
    }

    public interface ICloned
    {
        object Clone();
    }
}

