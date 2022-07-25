using UnityEngine;

namespace RiseOfArabs.Utilities.NumbersExtensions
{
    /// <summary>Extension mesthods class for <see cref="byte"/></summary>
    public static class Byte_Xs
    {
        #region Rounding

        #region Int
        /// <summary> Shortcut for <see cref="Mathf.RoundToInt(float)"/> </summary>
        public static int RInt(this byte _int) => Mathf.RoundToInt( _int );

        /// <summary> Shortcut for <see cref="Mathf.CeilToInt(float)"/> </summary>
        public static int CInt(this byte _int) => Mathf.CeilToInt( _int );

        /// <summary> Shortcut for <see cref="Mathf.FloorToInt(float)"/> </summary>
        public static int FInt(this byte _int) => Mathf.FloorToInt( _int );
        #endregion

        #region Byte
        /// <summary> Shortcut for <see cref="Mathf.RoundToInt(float)"/> then casting to byte </summary>
        public static byte R(this byte _byte) => (byte)Mathf.RoundToInt( _byte );

        /// <summary> Shortcut for <see cref="Mathf.CeilToInt(float)"/> then casting to byte </summary>
        public static byte C(this byte _byte) => (byte)Mathf.CeilToInt( _byte );

        /// <summary> Shortcut for <see cref="Mathf.FloorToInt(float)"/> then casting to byte </summary>
        public static byte F(this byte _byte) => (byte)Mathf.FloorToInt( _byte );
        #endregion

        #endregion

        #region Counting

        #region Next & Previous
        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_index"/> while portaling the value to the other side if it gets out of the range (<paramref name="_firstIndex"/>, <paramref name="_length"/> - 1),
        /// and making sure the value is never below 0</summary>
        public static byte Next(this byte _index, byte _length, byte _firstIndex = 0, byte _amount = 1) => PortalPos( _index, (byte)(_length - 1), _firstIndex, _amount );

        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_index"/> while clamping the value at <paramref name="_length"/> - 1,
        /// and making sure the value is never below 0</summary>
        public static byte NextClamped(this byte _index, byte _length, byte _amount = 1)
        {
            byte _max = (byte)(_length - 1);
            return PortalPos( _index, _max, _max, _amount );
        }

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_index"/> while portaling the value to the other side if it gets out of the range (<paramref name="_firstIndex"/>, <paramref name="_length"/> - 1),
        /// and making sure the value is never below 0</summary>
        public static byte Previous(this byte _index, byte _length, byte _firstIndex = 0, byte _amount = 1) => PortalNeg( _index, (byte)Mathf.Max( 0, _firstIndex ), (byte)(_length - 1), _amount );

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_index"/> while clamping the value at <paramref name="_firstIndex"/>,
        /// and making sure the value is never below 0</summary>
        public static byte PreviousClamped(this byte _index, byte _firstIndex = 0, byte _amount = 1) => PortalNeg( _index, (byte)Mathf.Max( 0, _firstIndex ), _index, _amount );
        #endregion

        #region Add & Subtract
        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_nm"/> while portaling the value to the other side if it gets out of the range (<paramref name="_min"/>, <paramref name="_max"/>)</summary>
        public static byte Add(this byte _nm, byte _min, byte _max, byte _amount = 1) => PortalPos( _nm, _max, _min, _amount );

        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_nm"/> while clamping the value at <paramref name="_max"/></summary>
        public static byte AddClamped(this byte _nm, byte _max, byte _amount = 1) => PortalPos( _nm, _max, _nm, _amount );

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_nm"/> while portaling the value to the other side if it gets out of the range (<paramref name="_min"/>, <paramref name="_max"/>)</summary>
        public static byte Subtract(this byte _nm, byte _min, byte _max, byte _amount = 1) => PortalNeg( _nm, _min, _max, _amount );

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_nm"/> while clamping the value at <paramref name="_max"/></summary>
        public static byte SubtractClamped(this byte _nm, byte _min, byte _amount = 1) => PortalNeg( _nm, _min, _nm, _amount );
        #endregion

        private static byte PortalPos(byte _nm, byte _max, byte _portalTo, byte _amount)
        {
            int _result = _nm + _amount;
            return (byte)(_result > _max ? _portalTo : _result);
        }
        private static byte PortalNeg(byte _nm, byte _min, byte _portalTo, byte _amount)
        {
            int _result = _nm - _amount;
            return (byte)(_result < _min ? _portalTo : _result);
        }
        #endregion

        #region Randoms
        /// <returns>Random value from 0 to 1</returns>
        public static byte GetRandom01() => (byte)Random.Range( 0, 2 );

        /// <returns>Random value from 0 to 100</returns>
        public static byte GetRandomPercent() => (byte)Random.Range( 0, 101 );
        #endregion
    }
}