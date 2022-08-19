using System;
using UnityEngine;

namespace RiseOfArabs.DevTool.Utilities
{
    public static class Tests_Xs
    {
        public static void DebugIsTrue(object _expected, object _actual)
        {
            Debugging( nameof( _expected ), _expected );
            Debugging( nameof( _actual ), _actual );
        }

        private static void Debugging(string _message, object _obj)
        {
            if ( _obj is Array _array )
            {
                var _length = _array.Length;
                for ( int _i = 0; _i < _length; _i++ )
                    Debug.Log( $"{_message}[{_i}]: {_array.GetValue( _i )}" );
            }
            else
                Debug.Log( $"{_message}: {_obj}" );
        }
        public static bool AreTrue(Array _expected, Array _actual)
        {
            bool _check = true;
            var _length1 = _expected.Length;
            var _length2 = _actual.Length;

            for ( int _i = 0; _i < _length1 && _i < _length2; _i++ )
                if ( _expected.GetValue( _i ) != _actual.GetValue( _i ) )
                    return false;
            return _check;
        }
    }
}