using UnityEngine;
using static RiseOfArabs.Utilities.NumbersExtensions.Int_Xs;

namespace RiseOfArabs.Utilities.VectorsExtensions
{
    /// <summary>Extension mesthods class for <see cref="Vector3Int"/></summary>
    public static class Vector3Int_Xs
    {
        #region Conversions

        #region To ints
        public static int[] ToInts(this Vector3Int _v3) => new int[] { _v3.x, _v3.y, _v3.z };
        public static int[] ToIntsRound(this Vector3Int _v3) => new int[] { _v3.x.R(), _v3.y.R(), _v3.z.R() };
        public static int[] ToIntsCeil(this Vector3Int _v3) => new int[] { _v3.x.C(), _v3.y.C(), _v3.z.C() };
        public static int[] ToIntsFloor(this Vector3Int _v3) => new int[] { _v3.x.F(), _v3.y.F(), _v3.z.F() };
        #endregion

        #region To bytes
        public static byte[] ToBytes(this Vector3Int _v3) => new byte[] { (byte)_v3.x, (byte)_v3.y, (byte)_v3.z };
        public static byte[] ToBytesRound(this Vector3Int _v3) => new byte[] { _v3.x.RByte(), _v3.y.RByte(), _v3.z.RByte() };
        public static byte[] ToBytesCeil(this Vector3Int _v3) => new byte[] { _v3.x.CByte(), _v3.y.CByte(), _v3.z.CByte() };
        public static byte[] ToBytesFloor(this Vector3Int _v3) => new byte[] { _v3.x.FByte(), _v3.y.FByte(), _v3.z.FByte() };
        #endregion

        #region To vector
        public static Vector3Int ToVector3Int(this int[] _ints) => new Vector3Int( _ints[0], _ints[1], _ints[3] );
        public static Vector3Int ToVector3Int(this byte[] _bytes) => new Vector3Int( _bytes[0], _bytes[1], _bytes[3] );
        #endregion

        #endregion

        #region Shortcuts

        #region Nullables
        public static Vector3Int With(this Vector3Int _v3, int? _x, int? _y, int? _z) => new Vector3Int( _x ?? _v3.x, _y ?? _v3.y, _z ?? _v3.z );
        public static Vector3Int With(this Vector3Int _v3, byte? _x, byte? _y, byte? _z) => new Vector3Int( _x ?? _v3.x, _y ?? _v3.y, _z ?? _v3.z );
        #endregion

        #region Singles
        public static Vector3Int WithX(this Vector3Int _v3, int _x) => new Vector3Int( _x, _v3.y, _v3.z );
        public static Vector3Int WithX(this Vector3Int _v3, byte _x) => new Vector3Int( _x, _v3.y, _v3.z );

        public static Vector3Int WithY(this Vector3Int _v3, int _y) => new Vector3Int( _v3.x, _y, _v3.z );
        public static Vector3Int WithY(this Vector3Int _v3, byte _y) => new Vector3Int( _v3.x, _y, _v3.z );

        public static Vector3Int WithZ(this Vector3Int _v3, int _z) => new Vector3Int( _v3.x, _v3.y, _z );
        public static Vector3Int WithZ(this Vector3Int _v3, byte _z) => new Vector3Int( _v3.x, _v3.y, _z );
        #endregion

        #region Doubles
        public static Vector3Int WithXY(this Vector3Int _v3, int _x, int _y) => new Vector3Int( _x, _y, _v3.z );
        public static Vector3Int WithXY(this Vector3Int _v3, byte _x, byte _y) => new Vector3Int( _x, _y, _v3.z );

        public static Vector3Int WithXZ(this Vector3Int _v3, int _x, int _z) => new Vector3Int( _x, _v3.y, _z );
        public static Vector3Int WithXZ(this Vector3Int _v3, byte _x, byte _z) => new Vector3Int( _x, _v3.y, _z );

        public static Vector3Int WithYZ(this Vector3Int _v3, int _y, int _z) => new Vector3Int( _v3.x, _y, _z );
        public static Vector3Int WithYZ(this Vector3Int _v3, byte _y, byte _z) => new Vector3Int( _v3.x, _y, _z );
        #endregion

        #endregion

        #region Area
        /// <returns>All possible positive and negative combinations</returns>
        public static Vector3Int[] GetAreaCorners(this Vector3Int _v3) => new Vector3Int[]
            {
                _v3,

                new Vector3Int(-_v3.x, _v3.y, _v3.z),
                new Vector3Int(_v3.x, -_v3.y, _v3.z),
                new Vector3Int(_v3.x, _v3.y, -_v3.z),

                new Vector3Int(-_v3.x, -_v3.y, _v3.z),
                new Vector3Int(-_v3.x, _v3.y, -_v3.z),
                new Vector3Int(_v3.x, -_v3.y, -_v3.z),

                -_v3,
            };
        #endregion

        #region Randoms
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector3Int RandomNP => new Vector3Int( GetRandomNP(), GetRandomNP(), GetRandomNP() );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector3Int Random01 => new Vector3Int( GetRandom01(), GetRandom01(), GetRandom01() );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector3Int RandomPercent => new Vector3Int( GetRandomPercent(), GetRandomPercent(), GetRandomPercent() );
        #endregion
    }
}