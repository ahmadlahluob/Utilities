using System;
using System.Collections;
using System.Collections.Generic;

namespace RiseOfArabs.Utilities
{
    /// <summary>Extension mesthods class for <see cref="System.Collections"/> and <see cref="System.Collections.Generic"/></summary>
    public static class Collections_Xs
    {
        public static bool IsNullOrEmpty(this Array _array) => _array == null || _array.Length == 0;
        public static bool IsNullOrEmpty<T>(this List<T> _list) => _list == null || _list.Count == 0;

        public static bool IsNullOrEmpty(this Queue _queue) => _queue == null || _queue.Count == 0;
        public static bool IsNullOrEmpty<T>(this Queue<T> _queue) => _queue == null || _queue.Count == 0;

        public static bool IsNullOrEmpty(this Stack _stack) => _stack == null || _stack.Count == 0;
        public static bool IsNullOrEmpty<T>(this Stack<T> _stack) => _stack == null || _stack.Count == 0;

        public static bool IsNullOrEmpty<T, T2>(this Dictionary<T, T2> _dictionary) => _dictionary == null || _dictionary.Count == 0;
    }
}