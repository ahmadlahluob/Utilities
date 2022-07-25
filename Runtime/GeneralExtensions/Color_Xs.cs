using UnityEngine;

namespace RiseOfArabs.Utilities.VectorsExtensions
{
    /// <summary>Extension mesthods class for <see cref="Color"/> and <see cref="Color32"/></summary>
    public static class Color_Xs
    {
        /// <param name="_state">Char that represents the color</param>
        /// <returns>
        /// 'G'=<see cref="Color.green"/>,
        /// 'g'=<see cref="Color.gray"/>, 
        /// 'R'=<see cref="Color.red"/>, 
        /// 'B'=<see cref="Color.blue"/>, 
        /// 'C'=<see cref="Color.cyan"/>, 
        /// 'Y'=<see cref="Color.yellow"/>, 
        /// 'W'=<see cref="Color.white"/>, 
        /// default=<see cref="Color.black"/>, 
        /// </returns>
        public static Color AsColor( this char _state )
        {
            switch ( _state )
            {
                case 'G':
                    return Color.green;
                case 'g':
                    return Color.gray;
                case 'R':
                    return Color.red;
                case 'B':
                    return Color.blue;
                case 'C':
                    return Color.cyan;
                case 'Y':
                    return Color.yellow;
                case 'W':
                    return Color.white;
                default:
                    return Color.black;
            }
        }

        /// <returns><see cref="Color.green"/> if positive, <see cref="Color.red"/> if negative, <see cref="Color.white"/> if 0</returns>
        public static Color AsColor( this float _state ) => _state > 0 ? Color.green : _state < 0 ? Color.red : Color.white;
        
        /// <returns><see cref="Color.green"/> if positive, <see cref="Color.red"/> if negative, <see cref="Color.white"/> if 0</returns>
        public static Color AsColor( this int _state ) => _state > 0 ? Color.green : _state < 0 ? Color.red : Color.white;
        
        /// <returns><see cref="Color.green"/> if 1, <see cref="Color.red"/> if 0, <see cref="Color.white"/> if else</returns>
        public static Color AsColor( this byte _state ) => _state == 1 ? Color.green : _state == 0 ? Color.red : Color.white;

        /// <returns><see cref="Color.green"/> if true, <see cref="Color.red"/> if false</returns>
        public static Color AsColor( this bool _state ) => _state ? Color.green : Color.red;
    }
}