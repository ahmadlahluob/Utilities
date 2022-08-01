using UnityEngine;

namespace RiseOfArabs.DevTool.Utilities.Randoms
{
    public static class V2Int
    {
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector2Int RandomNP => new Vector2Int( Int.RandomNP, Int.RandomNP );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector2Int Random01 => new Vector2Int( Int.Random01, Int.Random01 );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector2Int RandomPercent => new Vector2Int( Int.RandomPercent, Int.RandomPercent );

        /// <summary>Returns a random vector with values from 0 to 10</summary>
        public static Vector2Int RandomFromTen => new Vector2Int( Int.RandomFromTen, Int.RandomFromTen );

        /// <summary>Returns a random vector with values from 0 to 5</summary>
        public static Vector2Int RandomFromFive => new Vector2Int( Int.RandomFromFive, Int.RandomFromFive );
    }
}