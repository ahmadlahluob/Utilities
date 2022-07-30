using UnityEngine;

namespace RiseOfArabs.Utilities.NumbersExtensions
{
    /// <summary>Extension mesthods class for <see cref="int"/></summary>
    public static class Int_Xs
    {
        #region Rounding

        #region Int
        /// <summary> Shortcut for <see cref="Mathf.RoundToInt(float)"/> </summary>
        public static int R(this int _int) => Mathf.RoundToInt( _int );

        /// <summary> Shortcut for <see cref="Mathf.CeilToInt(float)"/> </summary>
        public static int C(this int _int) => Mathf.CeilToInt( _int );

        /// <summary> Shortcut for <see cref="Mathf.FloorToInt(float)"/> </summary>
        public static int F(this int _int) => Mathf.FloorToInt( _int );
        #endregion

        #region Byte
        /// <summary> Shortcut for <see cref="Mathf.RoundToInt(float)"/> then casting to byte </summary>
        public static byte RByte(this int _byte) => (byte)Mathf.RoundToInt( _byte );

        /// <summary> Shortcut for <see cref="Mathf.CeilToInt(float)"/> then casting to byte </summary>
        public static byte CByte(this int _byte) => (byte)Mathf.CeilToInt( _byte );

        /// <summary> Shortcut for <see cref="Mathf.FloorToInt(float)"/> then casting to byte </summary>
        public static byte FByte(this int _byte) => (byte)Mathf.FloorToInt( _byte );
        #endregion

        #endregion

        #region Counting

        #region Next & Previous
        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_index"/> while portaling the value to the other side if it gets out of the range (<paramref name="_firstIndex"/>, <paramref name="_length"/> - 1),
        /// and making sure the value is never below 0</summary>
        public static int Next(this int _index, int _length, int _firstIndex = 0, int _amount = 1) => PortalPos( _index, _length - 1, _firstIndex, _amount );
        

        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_index"/> while clamping the value at <paramref name="_length"/> - 1,
        /// and making sure the value is never below 0</summary>
        public static int NextClamped(this int _index, int _length, int _amount = 1)
        {
            int _max = _length - 1;
            return PortalPos( _index, _max, _max, _amount );
        }

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_index"/> while portaling the value to the other side if it gets out of the range (<paramref name="_firstIndex"/>, <paramref name="_length"/> - 1),
        /// and making sure the value is never below 0</summary>
        public static int Previous(this int _index, int _length, int _firstIndex = 0, int _amount = 1) => PortalNeg( _index, Mathf.Max( 0, _firstIndex ), _length - 1, _amount );

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_index"/> while clamping the value at <paramref name="_firstIndex"/>,
        /// and making sure the value is never below 0</summary>
        public static int PreviousClamped(this int _index, int _firstIndex = 0, int _amount = 1) => PortalNeg( _index, Mathf.Max( 0, _firstIndex ), _index, _amount );
        #endregion

        #region Add & Subtract
        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_nm"/> while portaling the value to the other side if it gets out of the range (<paramref name="_min"/>, <paramref name="_max"/>)</summary>
        public static int Add(this int _nm, int _min, int _max, int _amount = 1) => PortalPos( _nm, _max, _min, _amount );


        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_nm"/> while clamping the value at <paramref name="_max"/></summary>
        public static int AddClamped(this int _nm, int _max, int _amount = 1) => PortalPos( _nm, _max, _nm, _amount );

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_nm"/> while portaling the value to the other side if it gets out of the range (<paramref name="_min"/>, <paramref name="_max"/>)</summary>
        public static int Subtract(this int _nm, int _min, int _max, int _amount = 1) => PortalNeg( _nm, _min, _max, _amount );

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_nm"/> while clamping the value at <paramref name="_max"/></summary>
        public static int SubtractClamped(this int _nm, int _min, int _amount = 1) => PortalNeg( _nm, _min, _nm, _amount );
        #endregion

        private static int PortalPos(int _nm, int _max, int _portalTo, int _amount)
        {
            int _result = _nm + _amount;
            return _result > _max ? _portalTo : _result;
        }
        private static int PortalNeg(int _nm, int _min, int _portalTo, int _amount)
        {
            int _result = _nm - _amount;
            return _result < _min ? _portalTo : _result;
        }
        #endregion
    }
}