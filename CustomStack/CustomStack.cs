using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    internal class CustomStack<T>
    {

        private T[] _items;
        private int _count;
        private int _capacity;

        public int Count { get => _count; }
        public int Capacity { get => _capacity; }

        public CustomStack()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        public void Push(T item)
        {
            if(_count == _capacity)
            {
                _capacity*=2;
                T[] temp = new T[_capacity];
                for (int i = 0; i < _items.Length; i++)
                {
                    temp[i] = _items[i];
                }
                _items = temp;
            }
            _items[_count] = item;
            _count++;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return _items[_count - 1];
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T value = _items[_count - 1];
            _items[_count - 1] = default;
            return value;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public void Clear()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }


    }
}
