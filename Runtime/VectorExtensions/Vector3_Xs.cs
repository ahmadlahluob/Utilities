using UnityEngine;
using static RiseOfArabs.Utilities.NumbersExtensions.Float_Xs;

namespace RiseOfArabs.Utilities.VectorsExtensions
{
    /// <summary>Extension mesthods class for <see cref="Vector3"/></summary>
    public static class Vector3_Xs
    {
        #region Conversions

        #region To floats
        public static float[] ToFloats(this Vector3 _v3) => new float[] { _v3.x, _v3.y, _v3.z };
        public static float[] ToFloatsRound(this Vector3 _v3) => new float[] { _v3.x.R(), _v3.y.R(), _v3.z.R() };
        public static float[] ToFloatsCeil(this Vector3 _v3) => new float[] { _v3.x.C(), _v3.y.C(), _v3.z.C() };
        public static float[] ToFloatsFloor(this Vector3 _v3) => new float[] { _v3.x.F(), _v3.y.F(), _v3.z.F() };
        #endregion

        #region To ints
        public static int[] ToInts(this Vector3 _v3) => new int[] { (int)_v3.x, (int)_v3.y, (int)_v3.z };
        public static int[] ToIntsRound(this Vector3 _v3) => new int[] { _v3.x.RInt(), _v3.y.RInt(), _v3.z.RInt() };
        public static int[] ToIntsCeil(this Vector3 _v3) => new int[] { _v3.x.CInt(), _v3.y.CInt(), _v3.z.CInt() };
        public static int[] ToIntsFloor(this Vector3 _v3) => new int[] { _v3.x.FInt(), _v3.y.FInt(), _v3.z.FInt() };
        #endregion

        #region To bytes
        public static byte[] ToBytes(this Vector3 _v3) => new byte[] { (byte)_v3.x, (byte)_v3.y, (byte)_v3.z };
        public static byte[] ToBytesRound(this Vector3 _v3) => new byte[] { _v3.x.RByte(), _v3.y.RByte(), _v3.z.RByte() };
        public static byte[] ToBytesCeil(this Vector3 _v3) => new byte[] { _v3.x.CByte(), _v3.y.CByte(), _v3.z.CByte() };
        public static byte[] ToBytesFloor(this Vector3 _v3) => new byte[] { _v3.x.FByte(), _v3.y.FByte(), _v3.z.FByte() };
        #endregion

        #region To vector
        public static Vector3 ToVector3Int(this float[] _ints) => new Vector3( _ints[0], _ints[1], _ints[3] );
        public static Vector3 ToVector3Int(this int[] _ints) => new Vector3( _ints[0], _ints[1], _ints[3] );
        public static Vector3 ToVector3Int(this byte[] _bytes) => new Vector3( _bytes[0], _bytes[1], _bytes[3] );
        #endregion

        #endregion

        #region Shortcuts

        #region Nullables
        public static Vector3 With(this Vector3 _v3, float? _x, float? _y, float? _z) => new Vector3( _x ?? _v3.x, _y ?? _v3.y, _z ?? _v3.z );
        public static Vector3 With(this Vector3 _v3, int? _x, int? _y, int? _z) => new Vector3( _x ?? _v3.x, _y ?? _v3.y, _z ?? _v3.z );
        public static Vector3 With(this Vector3 _v3, byte? _x, byte? _y, byte? _z) => new Vector3( _x ?? _v3.x, _y ?? _v3.y, _z ?? _v3.z );
        public static void With_ref(this ref Vector3 _v3, float? _x, float? _y, float? _z) => new Vector3( _x ?? _v3.x, _y ?? _v3.y, _z ?? _v3.z );
        public static void With_ref(this ref Vector3 _v3, int? _x, int? _y, int? _z) => new Vector3( _x ?? _v3.x, _y ?? _v3.y, _z ?? _v3.z );
        public static void With_ref(this ref Vector3 _v3, byte? _x, byte? _y, byte? _z) => new Vector3( _x ?? _v3.x, _y ?? _v3.y, _z ?? _v3.z );
        #endregion

        #region Singles
        public static Vector3 WithX(this Vector3 _v3, float _x) => new Vector3( _x, _v3.y, _v3.z );
        public static Vector3 WithX(this Vector3 _v3, int _x) => new Vector3( _x, _v3.y, _v3.z );
        public static Vector3 WithX(this Vector3 _v3, byte _x) => new Vector3( _x, _v3.y, _v3.z );
        public static void WithX_ref(this ref Vector3 _v3, float _x) => new Vector3( _x, _v3.y, _v3.z );
        public static void WithX_ref(this ref Vector3 _v3, int _x) => new Vector3( _x, _v3.y, _v3.z );
        public static void WithX_ref(this ref Vector3 _v3, byte _x) => new Vector3( _x, _v3.y, _v3.z );

        public static Vector3 WithY(this Vector3 _v3, float _y) => new Vector3( _v3.x, _y, _v3.z );
        public static Vector3 WithY(this Vector3 _v3, int _y) => new Vector3( _v3.x, _y, _v3.z );
        public static Vector3 WithY(this Vector3 _v3, byte _y) => new Vector3( _v3.x, _y, _v3.z );
        public static void WithY_ref(this ref Vector3 _v3, float _y) => new Vector3( _v3.x, _y, _v3.z );
        public static void WithY_ref(this ref Vector3 _v3, int _y) => new Vector3( _v3.x, _y, _v3.z );
        public static void WithY_ref(this ref Vector3 _v3, byte _y) => new Vector3( _v3.x, _y, _v3.z );

        public static Vector3 WithZ(this Vector3 _v3, float _z) => new Vector3( _v3.x, _v3.y, _z );
        public static Vector3 WithZ(this Vector3 _v3, int _z) => new Vector3( _v3.x, _v3.y, _z );
        public static Vector3 WithZ(this Vector3 _v3, byte _z) => new Vector3( _v3.x, _v3.y, _z );
        public static void WithZ_ref(this ref Vector3 _v3, float _z) => new Vector3( _v3.x, _v3.y, _z );
        public static void WithZ_ref(this ref Vector3 _v3, int _z) => new Vector3( _v3.x, _v3.y, _z );
        public static void WithZ_ref(this ref Vector3 _v3, byte _z) => new Vector3( _v3.x, _v3.y, _z );
        #endregion

        #region Doubles
        public static Vector3 WithXY(this Vector3 _v3, float _x, float _y) => new Vector3( _x, _y, _v3.z );
        public static Vector3 WithXY(this Vector3 _v3, int _x, int _y) => new Vector3( _x, _y, _v3.z );
        public static Vector3 WithXY(this Vector3 _v3, byte _x, byte _y) => new Vector3( _x, _y, _v3.z );
        public static void WithXY_ref(this ref Vector3 _v3, float _x, float _y) => new Vector3( _x, _y, _v3.z );
        public static void WithXY_ref(this ref Vector3 _v3, int _x, int _y) => new Vector3( _x, _y, _v3.z );
        public static void WithXY_ref(this ref Vector3 _v3, byte _x, byte _y) => new Vector3( _x, _y, _v3.z );

        public static Vector3 WithXZ(this Vector3 _v3, float _x, float _z) => new Vector3( _x, _v3.y, _z );
        public static Vector3 WithXZ(this Vector3 _v3, int _x, int _z) => new Vector3( _x, _v3.y, _z );
        public static Vector3 WithXZ(this Vector3 _v3, byte _x, byte _z) => new Vector3( _x, _v3.y, _z );
        public static void WithXZ_ref(this ref Vector3 _v3, float _x, float _z) => new Vector3( _x, _v3.y, _z );
        public static void WithXZ_ref(this ref Vector3 _v3, int _x, int _z) => new Vector3( _x, _v3.y, _z );
        public static void WithXZ_ref(this ref Vector3 _v3, byte _x, byte _z) => new Vector3( _x, _v3.y, _z );

        public static Vector3 WithYZ(this Vector3 _v3, float _y, float _z) => new Vector3( _v3.x, _y, _z );
        public static Vector3 WithYZ(this Vector3 _v3, int _y, int _z) => new Vector3( _v3.x, _y, _z );
        public static Vector3 WithYZ(this Vector3 _v3, byte _y, byte _z) => new Vector3( _v3.x, _y, _z );
        public static void WithYZ_ref(this ref Vector3 _v3, float _y, float _z) => new Vector3( _v3.x, _y, _z );
        public static void WithYZ_ref(this ref Vector3 _v3, int _y, int _z) => new Vector3( _v3.x, _y, _z );
        public static void WithYZ_ref(this ref Vector3 _v3, byte _y, byte _z) => new Vector3( _v3.x, _y, _z );
        #endregion

        #endregion

        #region Area
        /// <returns>All possible positive and negative combinations</returns>
        public static Vector3[] GetAreaCorners(this Vector3 _v3) => new Vector3[]
            {
                _v3,

                new Vector3(-_v3.x, _v3.y, _v3.z),
                new Vector3(_v3.x, -_v3.y, _v3.z),
                new Vector3(_v3.x, _v3.y, -_v3.z),

                new Vector3(-_v3.x, -_v3.y, _v3.z),
                new Vector3(-_v3.x, _v3.y, -_v3.z),
                new Vector3(_v3.x, -_v3.y, -_v3.z),

                -_v3,
            };
        #endregion

        #region Randoms
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector3 RandomNP => new Vector3( GetRandomNP(), GetRandomNP(), GetRandomNP() );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector3 Random01 => new Vector3( GetRandom01(), GetRandom01(), GetRandom01() );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector3 RandomPercent => new Vector3( GetRandomPercent(), GetRandomPercent(), GetRandomPercent() );
        #endregion
    }
}
