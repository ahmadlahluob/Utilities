using RiseOfArabs.DevTool.Utilities.NumbersExtensions;
using UnityEngine;
using static RiseOfArabs.DevTool.Utilities.NumbersExtensions.Int_Xs;

namespace RiseOfArabs.DevTool.Utilities.VectorsExtensions
{
    /// <summary>Extension mesthods class for <see cref="Vector2Int"/></summary>
    public static class Vector2IntInt_Xs
    {
        #region Conversions

        #region To ints
        public static int[] ToInts(this Vector2Int _v2) => new int[] { _v2.x, _v2.y };
        public static int[] ToIntsRound(this Vector2Int _v2) => new int[] { _v2.x.R(), _v2.y.R() };
        public static int[] ToIntsCeil(this Vector2Int _v2) => new int[] { _v2.x.C(), _v2.y.C() };
        public static int[] ToIntsFloor(this Vector2Int _v2) => new int[] { _v2.x.F(), _v2.y.F() };
        #endregion

        #region To bytes
        public static byte[] ToBytes(this Vector2Int _v2) => new byte[] { (byte)_v2.x, (byte)_v2.y };
        public static byte[] ToBytesRound(this Vector2Int _v2) => new byte[] { _v2.x.RByte(), _v2.y.RByte() };
        public static byte[] ToBytesCeil(this Vector2Int _v2) => new byte[] { _v2.x.CByte(), _v2.y.CByte() };
        public static byte[] ToBytesFloor(this Vector2Int _v2) => new byte[] { _v2.x.FByte(), _v2.y.FByte() };
        #endregion

        #region To vector
        public static Vector2Int ToVector2Int(this int[] _ints) => new Vector2Int( _ints[0], _ints[1] );
        public static Vector2Int ToVector2Int(this byte[] _bytes) => new Vector2Int( _bytes[0], _bytes[1] );
        #endregion

        #endregion

        #region Shortcuts

        #region Nullables
        public static Vector2Int With(this Vector2Int _v2, int? _x, int? _y) => new Vector2Int( _x ?? _v2.x, _y ?? _v2.y );
        public static Vector2Int With(this Vector2Int _v2, byte? _x, byte? _y) => new Vector2Int( _x ?? _v2.x, _y ?? _v2.y );
        public static void With_ref(this ref Vector2Int _v2, int? _x, int? _y) => new Vector2Int( _x ?? _v2.x, _y ?? _v2.y );
        public static void With_ref(this ref Vector2Int _v2, byte? _x, byte? _y) => new Vector2Int( _x ?? _v2.x, _y ?? _v2.y );
        #endregion

        #region Singles
        public static Vector2Int WithX(this Vector2Int _v2, int _x) => new Vector2Int( _x, _v2.y );
        public static Vector2Int WithX(this Vector2Int _v2, byte _x) => new Vector2Int( _x, _v2.y );
        public static void WithX_ref(this ref Vector2Int _v2, int _x) => new Vector2Int( _x, _v2.y );
        public static void WithX_ref(this ref Vector2Int _v2, byte _x) => new Vector2Int( _x, _v2.y );

        public static Vector2Int WithY(this Vector2Int _v2, int _y) => new Vector2Int( _v2.x, _y );
        public static Vector2Int WithY(this Vector2Int _v2, byte _y) => new Vector2Int( _v2.x, _y );
        public static void WithY_ref(this ref Vector2Int _v2, int _y) => new Vector2Int( _v2.x, _y );
        public static void WithY_ref(this ref Vector2Int _v2, byte _y) => new Vector2Int( _v2.x, _y );
        #endregion

        #endregion

        #region Area
        /// <returns>All possible positive and negative combinations</returns>
        public static Vector2Int[] GetAreaCorners(this Vector2Int _v2) => new Vector2Int[]
            {
                _v2,

                new Vector2Int(-_v2.x, _v2.y),
                new Vector2Int(_v2.x, -_v2.y),

                -_v2,
            };
        #endregion
    }
}