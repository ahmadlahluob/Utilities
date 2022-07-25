using RiseOfArabs.Utilities.NumbersExtensions;
using UnityEngine;

namespace RiseOfArabs.Utilities
{
    /// <summary>Extension mesthods class for <see cref="Quaternion"/></summary>
    public static class Quaternion_Xs
    {
        #region Conversions

        #region To floats
        public static float[] ToFloats(this Quaternion _quat) => new float[] { _quat.eulerAngles.x, _quat.eulerAngles.y, _quat.eulerAngles.z };
        public static float[] ToFloatsRound(this Quaternion _quat) => new float[] { _quat.eulerAngles.x.R(), _quat.eulerAngles.y.R(), _quat.eulerAngles.z.R() };
        public static float[] ToFloatsCeil(this Quaternion _quat) => new float[] { _quat.eulerAngles.x.C(), _quat.eulerAngles.y.C(), _quat.eulerAngles.z.C() };
        public static float[] ToFloatsFloor(this Quaternion _quat) => new float[] { _quat.eulerAngles.x.F(), _quat.eulerAngles.y.F(), _quat.eulerAngles.z.F() };
        #endregion

        #region To ints
        public static int[] ToInts(this Quaternion _quat) => new int[] { (int)_quat.eulerAngles.x, (int)_quat.eulerAngles.y, (int)_quat.eulerAngles.z };
        public static int[] ToIntsRound(this Quaternion _quat) => new int[] { _quat.eulerAngles.x.RInt(), _quat.eulerAngles.y.RInt(), _quat.eulerAngles.z.RInt() };
        public static int[] ToIntsCeil(this Quaternion _quat) => new int[] { _quat.eulerAngles.x.CInt(), _quat.eulerAngles.y.CInt(), _quat.eulerAngles.z.CInt() };
        public static int[] ToIntsFloor(this Quaternion _quat) => new int[] { _quat.eulerAngles.x.FInt(), _quat.eulerAngles.y.FInt(), _quat.eulerAngles.z.FInt() };
        #endregion

        #region To bytes
        public static byte[] ToBytes(this Quaternion _quat) => new byte[] { (byte)_quat.eulerAngles.x, (byte)_quat.eulerAngles.y, (byte)_quat.eulerAngles.z };
        public static byte[] ToBytesRound(this Quaternion _quat) => new byte[] { _quat.eulerAngles.x.RByte(), _quat.eulerAngles.y.RByte(), _quat.eulerAngles.z.RByte() };
        public static byte[] ToBytesCeil(this Quaternion _quat) => new byte[] { _quat.eulerAngles.x.CByte(), _quat.eulerAngles.y.CByte(), _quat.eulerAngles.z.CByte() };
        public static byte[] ToBytesFloor(this Quaternion _quat) => new byte[] { _quat.eulerAngles.x.FByte(), _quat.eulerAngles.y.FByte(), _quat.eulerAngles.z.FByte() };
        #endregion

        #region To quaternion
        public static Quaternion ToQuaternion(this float[] _floats) => Quaternion.Euler( _floats[0], _floats[1], _floats[2] );
        public static Quaternion ToQuaternion(this int[] _ints) => Quaternion.Euler( _ints[0], _ints[1], _ints[2] );
        public static Quaternion ToQuaternion(this byte[] _bytes) => Quaternion.Euler( _bytes[0], _bytes[1], _bytes[2] );
        #endregion

        #endregion
    }
}