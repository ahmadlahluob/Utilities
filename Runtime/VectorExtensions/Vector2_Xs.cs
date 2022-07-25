using RiseOfArabs.Utilities.NumbersExtensions;
using UnityEngine;
using static RiseOfArabs.Utilities.NumbersExtensions.Float_Xs;

namespace RiseOfArabs.Utilities.VectorsExtensions
{
    /// <summary>Extension mesthods class for <see cref="Vector2"/></summary>
    public static class Vector2_Xs
    {
        #region Conversions

        #region To floats
        public static float[] ToFloats(this Vector2 _v2) => new float[] { _v2.x, _v2.y };
        public static float[] ToFloatsRound(this Vector2 _v2) => new float[] { _v2.x.R(), _v2.y.R() };
        public static float[] ToFloatsCeil(this Vector2 _v2) => new float[] { _v2.x.C(), _v2.y.C() };
        public static float[] ToFloatsFloor(this Vector2 _v2) => new float[] { _v2.x.F(), _v2.y.F() };
        #endregion

        #region To ints
        public static int[] ToInts(this Vector2 _v2) => new int[] { (int)_v2.x, (int)_v2.y };
        public static int[] ToIntsRound(this Vector2 _v2) => new int[] { _v2.x.RInt(), _v2.y.RInt() };
        public static int[] ToIntsCeil(this Vector2 _v2) => new int[] { _v2.x.CInt(), _v2.y.CInt() };
        public static int[] ToIntsFloor(this Vector2 _v2) => new int[] { _v2.x.FInt(), _v2.y.FInt() };
        #endregion

        #region To bytes
        public static byte[] ToBytes(this Vector2 _v2) => new byte[] { (byte)_v2.x, (byte)_v2.y };
        public static byte[] ToBytesRound(this Vector2 _v2) => new byte[] { _v2.x.RByte(), _v2.y.RByte() };
        public static byte[] ToBytesCeil(this Vector2 _v2) => new byte[] { _v2.x.CByte(), _v2.y.CByte() };
        public static byte[] ToBytesFloor(this Vector2 _v2) => new byte[] { _v2.x.FByte(), _v2.y.FByte() };
        #endregion

        #region To vector
        public static Vector2 ToVector2(this float[] _floats) => new Vector2( _floats[0], _floats[1] );
        public static Vector2 ToVector2(this int[] _ints) => new Vector2( _ints[0], _ints[1] );
        public static Vector2 ToVector2(this byte[] _bytes) => new Vector2( _bytes[0], _bytes[1] );
        #endregion

        #endregion

        #region Shortcuts

        #region Nullables
        public static Vector2 With(this Vector2 _v2, float? _x, float? _y) => new Vector2( _x ?? _v2.x, _y ?? _v2.y );
        public static Vector2 With(this Vector2 _v2, int? _x, int? _y) => new Vector2( _x ?? _v2.x, _y ?? _v2.y );
        public static Vector2 With(this Vector2 _v2, byte? _x, byte? _y) => new Vector2( _x ?? _v2.x, _y ?? _v2.y );
        #endregion

        #region Singles
        public static Vector2 WithX(this Vector2 _v2, float _x) => new Vector2( _x, _v2.y );
        public static Vector2 WithX(this Vector2 _v2, int _x) => new Vector2( _x, _v2.y );
        public static Vector2 WithX(this Vector2 _v2, byte _x) => new Vector2( _x, _v2.y );

        public static Vector2 WithY(this Vector2 _v2, float _y) => new Vector2( _v2.x, _y );
        public static Vector2 WithY(this Vector2 _v2, int _y) => new Vector2( _v2.x, _y );
        public static Vector2 WithY(this Vector2 _v2, byte _y) => new Vector2( _v2.x, _y );
        #endregion

        #endregion

        #region Area
        /// <returns>All possible positive and negative combinations</returns>
        public static Vector2[] GetAreaCorners(this Vector2 _v2) => new Vector2[]
            {
                _v2,

                new Vector2(-_v2.x, _v2.y),
                new Vector2(_v2.x, -_v2.y),

                -_v2,
            };
        #endregion

        #region Randoms
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector2 RandomNP => new Vector2( GetRandomNP(), GetRandomNP() );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector2 Random01 => new Vector2( GetRandom01(), GetRandom01() );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector2 RandomPercent => new Vector2( GetRandomPercent(), GetRandomPercent() );
        #endregion
    }
}