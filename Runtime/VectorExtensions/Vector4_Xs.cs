using UnityEngine;
using static RiseOfArabs.Utilities.NumbersExtensions.Float_Xs;

namespace RiseOfArabs.Utilities.VectorsExtensions
{
    /// <summary>Extension mesthods class for <see cref="Vector4"/></summary>
    public static class Vector4_Xs
    {
        #region Conversions

        #region To floats
        public static float[] ToFloats(this Vector4 _v4) => new float[] { _v4.x, _v4.y, _v4.z, _v4.w };
        public static float[] ToFloatsRound(this Vector4 _v4) => new float[] { _v4.x.R(), _v4.y.R(), _v4.z.R(), _v4.w.R() };
        public static float[] ToFloatsCeil(this Vector4 _v4) => new float[] { _v4.x.C(), _v4.y.C(), _v4.z.C(), _v4.w.C() };
        public static float[] ToFloatsFloor(this Vector4 _v4) => new float[] { _v4.x.F(), _v4.y.F(), _v4.z.F(), _v4.w.F() };
        #endregion

        #region To ints
        public static int[] ToInts(this Vector4 _v4) => new int[] { (int)_v4.x, (int)_v4.y, (int)_v4.z, (int)_v4.w };
        public static int[] ToIntsRound(this Vector4 _v4) => new int[] { _v4.x.RInt(), _v4.y.RInt(), _v4.z.RInt(), _v4.w.RInt() };
        public static int[] ToIntsCeil(this Vector4 _v4) => new int[] { _v4.x.CInt(), _v4.y.CInt(), _v4.z.CInt(), _v4.w.CInt() };
        public static int[] ToIntsFloor(this Vector4 _v4) => new int[] { _v4.x.FInt(), _v4.y.FInt(), _v4.z.FInt(), _v4.w.FInt() };
        #endregion

        #region To bytes
        public static byte[] ToBytes(this Vector4 _v4) => new byte[] { (byte)_v4.x, (byte)_v4.y, (byte)_v4.z, (byte)_v4.w };
        public static byte[] ToBytesRound(this Vector4 _v4) => new byte[] { _v4.x.RByte(), _v4.y.RByte(), _v4.z.RByte(), _v4.w.RByte() };
        public static byte[] ToBytesCeil(this Vector4 _v4) => new byte[] { _v4.x.CByte(), _v4.y.CByte(), _v4.z.CByte(), _v4.w.CByte() };
        public static byte[] ToBytesFloor(this Vector4 _v4) => new byte[] { _v4.x.FByte(), _v4.y.FByte(), _v4.z.FByte(), _v4.w.FByte() };
        #endregion

        #region To vector
        public static Vector4 ToVector4(this float[] _floats) => new Vector4( _floats[0], _floats[1], _floats[2], _floats[4] );
        public static Vector4 ToVector4(this int[] _ints) => new Vector4( _ints[0], _ints[1], _ints[2], _ints[4] );
        public static Vector4 ToVector4(this byte[] _bytes) => new Vector4( _bytes[0], _bytes[1], _bytes[2], _bytes[4] );
        #endregion

        #endregion

        #region Shortcuts

        #region Nullables
        public static Vector4 With(this Vector4 _v4, float? _x, float? _y, float? _z, float? _w) => new Vector4( _x ?? _v4.x, _y ?? _v4.y, _z ?? _v4.z, _w ?? _v4.w );
        public static Vector4 With(this Vector4 _v4, int? _x, int? _y, int? _z, int? _w) => new Vector4( _x ?? _v4.x, _y ?? _v4.y, _z ?? _v4.z, _w ?? _v4.w );
        public static Vector4 With(this Vector4 _v4, byte? _x, byte? _y, byte? _z, byte? _w) => new Vector4( _x ?? _v4.x, _y ?? _v4.y, _z ?? _v4.z, _w ?? _v4.w );
        #endregion

        #region Singles
        public static Vector4 WithX(this Vector4 _v4, float _x) => new Vector4( _x, _v4.y, _v4.z );
        public static Vector4 WithX(this Vector4 _v4, int _x) => new Vector4( _x, _v4.y, _v4.z );
        public static Vector4 WithX(this Vector4 _v4, byte _x) => new Vector4( _x, _v4.y, _v4.z );

        public static Vector4 WithY(this Vector4 _v4, float _y) => new Vector4( _v4.x, _y, _v4.z );
        public static Vector4 WithY(this Vector4 _v4, int _y) => new Vector4( _v4.x, _y, _v4.z );
        public static Vector4 WithY(this Vector4 _v4, byte _y) => new Vector4( _v4.x, _y, _v4.z );

        public static Vector4 WithZ(this Vector4 _v4, float _z) => new Vector4( _v4.x, _v4.y, _z );
        public static Vector4 WithZ(this Vector4 _v4, int _z) => new Vector4( _v4.x, _v4.y, _z );
        public static Vector4 WithZ(this Vector4 _v4, byte _z) => new Vector4( _v4.x, _v4.y, _z );
        #endregion

        #region Doubles
        public static Vector4 WithXY(this Vector4 _v4, float _x, float _y) => new Vector4( _x, _y, _v4.z );
        public static Vector4 WithXY(this Vector4 _v4, int _x, int _y) => new Vector4( _x, _y, _v4.z );
        public static Vector4 WithXY(this Vector4 _v4, byte _x, byte _y) => new Vector4( _x, _y, _v4.z );

        public static Vector4 WithXZ(this Vector4 _v4, float _x, float _z) => new Vector4( _x, _v4.y, _z );
        public static Vector4 WithXZ(this Vector4 _v4, int _x, int _z) => new Vector4( _x, _v4.y, _z );
        public static Vector4 WithXZ(this Vector4 _v4, byte _x, byte _z) => new Vector4( _x, _v4.y, _z );

        public static Vector4 WithYZ(this Vector4 _v4, float _y, float _z) => new Vector4( _v4.x, _y, _z );
        public static Vector4 WithYZ(this Vector4 _v4, int _y, int _z) => new Vector4( _v4.x, _y, _z );
        public static Vector4 WithYZ(this Vector4 _v4, byte _y, byte _z) => new Vector4( _v4.x, _y, _z );
        #endregion

        #endregion

        #region Area
        /// <returns>All possible positive and negative combinations</returns>
        public static Vector4[] GetAreaCorners(this Vector4 _v4) => new Vector4[]
            {
                _v4,

                new Vector4(-_v4.x, _v4.y, _v4.z, _v4.w),
                new Vector4(_v4.x, -_v4.y, _v4.z, _v4.w),
                new Vector4(_v4.x, _v4.y, -_v4.z, _v4.w),
                new Vector4(_v4.x, _v4.y, _v4.z, -_v4.w),

                new Vector4(-_v4.x, -_v4.y, _v4.z, _v4.w),
                new Vector4(-_v4.x, _v4.y, -_v4.z, _v4.w),
                new Vector4(-_v4.x, _v4.y, _v4.z, -_v4.w),
                new Vector4(_v4.x, -_v4.y, -_v4.z, _v4.w),
                new Vector4(_v4.x, -_v4.y, _v4.z, -_v4.w),
                new Vector4(_v4.x, _v4.y, -_v4.z, -_v4.w),

                new Vector4(-_v4.x, -_v4.y, -_v4.z, _v4.w),
                new Vector4(-_v4.x, -_v4.y, _v4.z, -_v4.w),
                new Vector4(-_v4.x, _v4.y, -_v4.z, -_v4.w),
                new Vector4(_v4.x, -_v4.y, -_v4.z, -_v4.w),

                -_v4,
            };
        #endregion

        #region Randoms
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector4 RandomNP => new Vector4( GetRandomNP(), GetRandomNP(), GetRandomNP(), GetRandomNP() );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector4 Random01 => new Vector4( GetRandom01(), GetRandom01(), GetRandom01(), GetRandom01() );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector4 RandomPercent => new Vector4( GetRandomPercent(), GetRandomPercent(), GetRandomPercent(), GetRandomPercent() );
        #endregion
    }
}