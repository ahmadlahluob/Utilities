using UnityEngine;

namespace RiseOfArabs.Utilities.Randoms
{
    public static class Float
    {
        /// <returns>Random value from -1 to 1</returns>
        public static float RandomNP => Random.Range( -1f, 1f );

        /// <returns>Random value from 0 to 1</returns>
        public static float Random01 => Random.Range( 0f, 1f );

        /// <returns>Random value from 0 to 100</returns>
        public static float RandomPercent => Random.Range( 0f, 100f );

        /// <returns>Random value from 0 to 10</returns>
        public static float RandomFromTen => Random.Range( 0f, 10f );

        /// <returns>Random value from 0 to 5</returns>
        public static float RandomFromFive => Random.Range( 0f, 5f );
    }
    public static class Int
    {
        /// <returns>Random value from -1 to 1</returns>
        public static int RandomNP => Random.Range( -1, 2 );

        /// <returns>Random value from 0 to 1</returns>
        public static int Random01 => Random.Range( 0, 2 );

        /// <returns>Random value from 0 to 100</returns>
        public static int RandomPercent => Random.Range( 0, 101 );

        /// <returns>Random value from 0 to 10</returns>
        public static int RandomFromTen => Random.Range( 0, 11 );

        /// <returns>Random value from 0 to 5</returns>
        public static int RandomFromFive => Random.Range( 0, 6 );
    }
    public static class Byte
    {
        /// <returns>Random value from 0 to 1</returns>
        public static byte Random01 => (byte)Random.Range( 0, 2 );

        /// <returns>Random value from 0 to 100</returns>
        public static byte RandomPercent => (byte)Random.Range( 0, 101 );

        /// <returns>Random value from 0 to 10</returns>
        public static byte RandomFromTen => (byte)Random.Range( 0, 11 );

        /// <returns>Random value from 0 to 5</returns>
        public static byte RandomFromFive => (byte)Random.Range( 0, 6 );
    }

    public static class V2
    {
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector2 RandomNP => new Vector2( Float.RandomNP, Float.RandomNP );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector2 Random01 => new Vector2( Float.Random01, Float.Random01 );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector2 RandomPercent => new Vector2( Float.RandomPercent, Float.RandomPercent );

        /// <summary>Returns a random vector with values from 0 to 10</summary>
        public static Vector2 RandomFromTen => new Vector2( Float.RandomFromTen, Float.RandomFromTen );

        /// <summary>Returns a random vector with values from 0 to 5</summary>
        public static Vector2 RandomFromFive => new Vector2( Float.RandomFromFive, Float.RandomFromFive );
    }
    public static class V3
    {
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector3 RandomNP => new Vector3( Float.RandomNP, Float.RandomNP, Float.RandomNP );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector3 Random01 => new Vector3( Float.Random01, Float.Random01, Float.Random01 );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector3 RandomPercent => new Vector3( Float.RandomPercent, Float.RandomPercent, Float.RandomPercent );

        /// <summary>Returns a random vector with values from 0 to 10</summary>
        public static Vector3 RandomFromTen => new Vector3( Float.RandomFromTen, Float.RandomFromTen, Float.RandomFromTen );

        /// <summary>Returns a random vector with values from 0 to 5</summary>
        public static Vector3 RandomFromFive => new Vector3( Float.RandomFromFive, Float.RandomFromFive, Float.RandomFromFive );
    }
    public static class V4
    {
        /// <summary>Returns a random vector with values from -1 to 1</summary>
        public static Vector4 RandomNP => new Vector4( Float.RandomNP, Float.RandomNP, Float.RandomNP, Float.RandomNP );

        /// <summary>Returns a random vector with values from 0 to 1</summary>
        public static Vector4 Random01 => new Vector4( Float.Random01, Float.Random01, Float.Random01, Float.Random01 );

        /// <summary>Returns a random vector with values from 0 to 100</summary>
        public static Vector4 RandomPercent => new Vector4( Float.RandomPercent, Float.RandomPercent, Float.RandomPercent, Float.RandomPercent );

        /// <summary>Returns a random vector with values from 0 to 10</summary>
        public static Vector4 RandomFromTen => new Vector4( Float.RandomFromTen, Float.RandomFromTen, Float.RandomFromTen, Float.RandomFromTen );

        /// <summary>Returns a random vector with values from 0 to 5</summary>
        public static Vector4 RandomFromFive => new Vector4( Float.RandomFromFive, Float.RandomFromFive, Float.RandomFromFive, Float.RandomFromFive );
    }
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