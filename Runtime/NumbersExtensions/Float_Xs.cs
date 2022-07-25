using UnityEngine;

namespace RiseOfArabs.Utilities.NumbersExtensions
{
    /// <summary>Extension mesthods class for <see cref="float"/></summary>
    public static class Float_Xs
    {
        #region Rounding

        #region Float
        /// <summary> Shortcut for <see cref="Mathf.Round(float)"/> </summary>
        public static float R(this float _float) => Mathf.Round( _float );

        /// <summary> Shortcut for <see cref="Mathf.Ceil(float)"/> </summary>
        public static float C(this float _float) => Mathf.Ceil( _float );

        /// <summary> Shortcut for <see cref="Mathf.Floor(float)"/> </summary>
        public static float F(this float _float) => Mathf.Floor( _float );
        #endregion

        #region Int
        /// <summary> Shortcut for <see cref="Mathf.RoundToInt(float)"/> </summary>
        public static int RInt(this float _float) => Mathf.RoundToInt( _float );

        /// <summary> Shortcut for <see cref="Mathf.CeilToInt(float)"/> </summary>
        public static int CInt(this float _float) => Mathf.CeilToInt( _float );

        /// <summary> Shortcut for <see cref="Mathf.FloorToInt(float)"/> </summary>
        public static int FInt(this float _float) => Mathf.FloorToInt( _float );
        #endregion

        #region Byte
        /// <summary> Shortcut for <see cref="Mathf.RoundToInt(float)"/> then casting to byte </summary>
        public static byte RByte(this float _float) => (byte)Mathf.RoundToInt( _float );

        /// <summary> Shortcut for <see cref="Mathf.CeilToInt(float)"/> then casting to byte </summary>
        public static byte CByte(this float _float) => (byte)Mathf.CeilToInt( _float );

        /// <summary> Shortcut for <see cref="Mathf.FloorToInt(float)"/> then casting to byte </summary>
        public static byte FByte(this float _float) => (byte)Mathf.FloorToInt( _float );
        #endregion

        #endregion

        #region Counting

        #region Next & Previous
        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_index"/> while portaling the value to the other side if it gets out of the range (<paramref name="_firstIndex"/>, <paramref name="_length"/> - 1),
        /// and making sure the value is never below 0</summary>
        public static float Next(this float _index, float _length, float _firstIndex = 0, float _amount = 1) => PortalPositive( _index, _length - 1, Mathf.Max( 0, _firstIndex ), _amount );

        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_index"/> while clamping the value at <paramref name="_length"/> - 1,
        /// and making sure the value is never below 0</summary>
        public static float NextClamped(this float _index, float _length, float _amount = 1)
        {
            float _max = _length - 1;
            return PortalPositive( _index, _max, _max, _amount );
        }

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_index"/> while portaling the value to the other side if it gets out of the range (<paramref name="_firstIndex"/>, <paramref name="_length"/> - 1),
        /// and making sure the value is never below 0</summary>
        public static float Previous(this float _index, float _length, float _firstIndex = 0, float _amount = 1) => PortalNegative( _index, Mathf.Max( 0, _firstIndex ), _length - 1, _amount );

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_index"/> while clamping the value at <paramref name="_firstIndex"/>,
        /// and making sure the value is never below 0</summary>
        public static float PreviousClamped(this float _index, float _firstIndex = 0, float _amount = 1) => PortalNegative( _index, Mathf.Max( 0, _firstIndex ), _index, _amount );
        #endregion

        #region Add & Subtract
        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_nm"/> while portaling the value to the other side if it gets out of the range (<paramref name="_min"/>, <paramref name="_max"/>)</summary>
        public static float Add(this float _nm, float _min, float _max, float _amount = 1) => PortalPositive( _nm, _max, _min, _amount );

        /// <summary>Adding <paramref name="_amount"/> to <paramref name="_nm"/> while clamping the value at <paramref name="_max"/></summary>
        public static float AddClamped(this float _nm, float _max, float _amount = 1) => PortalPositive( _nm, _max, _nm, _amount );

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_nm"/> while portaling the value to the other side if it gets out of the range (<paramref name="_min"/>, <paramref name="_max"/>)</summary>
        public static float Subtract(this float _nm, float _min, float _max, float _amount = 1) => PortalNegative( _nm, _min, _max, _amount );

        /// <summary>Subtracting <paramref name="_amount"/> from <paramref name="_nm"/> while clamping the value at <paramref name="_max"/></summary>
        public static float SubtractClamped(this float _nm, float _min, float _amount = 1) => PortalNegative( _nm, _min, _nm, _amount );
        #endregion

        private static float PortalPositive(float _nm, float _max, float _portalTo, float _amount)
        {
            float _result = _nm + _amount;
            return _result > _max ? _portalTo : _result;
        }
        private static float PortalNegative(float _nm, float _min, float _portalTo, float _amount)
        {
            float _result = _nm - _amount;
            return _result < _min ? _portalTo : _result;
        }
        #endregion

        #region Randoms
        /// <returns>Random value from -1 to 1</returns>
        public static float GetRandomNP() => Random.Range( -1f, 1f );

        /// <returns>Random value from 0 to 1</returns>
        public static float GetRandom01() => Random.Range( 0f, 1f );

        /// <returns>Random value from 0 to 100</returns>
        public static float GetRandomPercent() => Random.Range( 0f, 100f );
        #endregion
    }
}