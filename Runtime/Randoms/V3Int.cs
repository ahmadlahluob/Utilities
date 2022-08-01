using UnityEngine;

namespace RiseOfArabs.DevTool.Utilities.Randoms
{
    public static class V3Int
    {
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector3Int RandomNP => new Vector3Int( Int.RandomNP, Int.RandomNP, Int.RandomNP );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector3Int Random01 => new Vector3Int( Int.Random01, Int.Random01, Int.Random01 );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector3Int RandomPercent => new Vector3Int( Int.RandomPercent, Int.RandomPercent, Int.RandomPercent );

        /// <summary>Returns a random vector with values from 0 to 10</summary>
        public static Vector3Int RandomFromTen => new Vector3Int( Int.RandomFromTen, Int.RandomFromTen, Int.RandomFromTen );

        /// <summary>Returns a random vector with values from 0 to 5</summary>
        public static Vector3Int RandomFromFive => new Vector3Int( Int.RandomFromFive, Int.RandomFromFive, Int.RandomFromFive );
    }
}