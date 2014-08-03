/*
 * (C) 2014 ERAL
 * Distributed under the Boost Software License, Version 1.0.
 * (See copy at http://www.boost.org/LICENSE_1_0.txt)
 */

using UnityEngine;

namespace Swizzle {
	static class ColorExtensions {

#region Color←1D swizzle
		/// <summary>
		/// Color←1D swizzle
		/// </summary>
		/// <param name="src">1D</param>
		/// <returns>4D</returns>
		public static Color rrrr(this float src) {
			return new Color(src, src, src, src);
		}
#endregion

#region Color←2D swizzle
		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color rrrr(this Vector2 src) {
			return new Color(src.x, src.x, src.x, src.x);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color rrrg(this Vector2 src) {
			return new Color(src.x, src.x, src.x, src.y);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color rrgr(this Vector2 src) {
			return new Color(src.x, src.x, src.y, src.x);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color rrgg(this Vector2 src) {
			return new Color(src.x, src.x, src.y, src.y);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color rgrr(this Vector2 src) {
			return new Color(src.x, src.y, src.x, src.x);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color rgrg(this Vector2 src) {
			return new Color(src.x, src.y, src.x, src.y);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color rggr(this Vector2 src) {
			return new Color(src.x, src.y, src.y, src.x);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color rggg(this Vector2 src) {
			return new Color(src.x, src.y, src.y, src.y);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color grrr(this Vector2 src) {
			return new Color(src.y, src.x, src.x, src.x);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color grrg(this Vector2 src) {
			return new Color(src.y, src.x, src.x, src.y);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color grgr(this Vector2 src) {
			return new Color(src.y, src.x, src.y, src.x);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color grgg(this Vector2 src) {
			return new Color(src.y, src.x, src.y, src.y);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color ggrr(this Vector2 src) {
			return new Color(src.y, src.y, src.x, src.x);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color ggrg(this Vector2 src) {
			return new Color(src.y, src.y, src.x, src.y);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color gggr(this Vector2 src) {
			return new Color(src.y, src.y, src.y, src.x);
		}

		/// <summary>
		/// Color←2D swizzle
		/// </summary>
		/// <param name="src">2D</param>
		/// <returns>4D</returns>
		public static Color gggg(this Vector2 src) {
			return new Color(src.y, src.y, src.y, src.y);
		}
#endregion

#region Color←3D swizzle
		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rrrr(this Vector3 src) {
			return new Color(src.x, src.x, src.x, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rrrg(this Vector3 src) {
			return new Color(src.x, src.x, src.x, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rrrb(this Vector3 src) {
			return new Color(src.x, src.x, src.x, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rrgr(this Vector3 src) {
			return new Color(src.x, src.x, src.y, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rrgg(this Vector3 src) {
			return new Color(src.x, src.x, src.y, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rrgb(this Vector3 src) {
			return new Color(src.x, src.x, src.y, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rrbr(this Vector3 src) {
			return new Color(src.x, src.x, src.z, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rrbg(this Vector3 src) {
			return new Color(src.x, src.x, src.z, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rrbb(this Vector3 src) {
			return new Color(src.x, src.x, src.z, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rgrr(this Vector3 src) {
			return new Color(src.x, src.y, src.x, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rgrg(this Vector3 src) {
			return new Color(src.x, src.y, src.x, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rgrb(this Vector3 src) {
			return new Color(src.x, src.y, src.x, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rggr(this Vector3 src) {
			return new Color(src.x, src.y, src.y, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rggg(this Vector3 src) {
			return new Color(src.x, src.y, src.y, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rggb(this Vector3 src) {
			return new Color(src.x, src.y, src.y, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rgbr(this Vector3 src) {
			return new Color(src.x, src.y, src.z, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rgbg(this Vector3 src) {
			return new Color(src.x, src.y, src.z, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rgbb(this Vector3 src) {
			return new Color(src.x, src.y, src.z, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rbrr(this Vector3 src) {
			return new Color(src.x, src.z, src.x, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rbrg(this Vector3 src) {
			return new Color(src.x, src.z, src.x, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rbrb(this Vector3 src) {
			return new Color(src.x, src.z, src.x, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rbgr(this Vector3 src) {
			return new Color(src.x, src.z, src.y, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rbgg(this Vector3 src) {
			return new Color(src.x, src.z, src.y, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rbgb(this Vector3 src) {
			return new Color(src.x, src.z, src.y, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rbbr(this Vector3 src) {
			return new Color(src.x, src.z, src.z, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rbbg(this Vector3 src) {
			return new Color(src.x, src.z, src.z, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color rbbb(this Vector3 src) {
			return new Color(src.x, src.z, src.z, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color grrr(this Vector3 src) {
			return new Color(src.y, src.x, src.x, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color grrg(this Vector3 src) {
			return new Color(src.y, src.x, src.x, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color grrb(this Vector3 src) {
			return new Color(src.y, src.x, src.x, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color grgr(this Vector3 src) {
			return new Color(src.y, src.x, src.y, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color grgg(this Vector3 src) {
			return new Color(src.y, src.x, src.y, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color grgb(this Vector3 src) {
			return new Color(src.y, src.x, src.y, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color grbr(this Vector3 src) {
			return new Color(src.y, src.x, src.z, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color grbg(this Vector3 src) {
			return new Color(src.y, src.x, src.z, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color grbb(this Vector3 src) {
			return new Color(src.y, src.x, src.z, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color ggrr(this Vector3 src) {
			return new Color(src.y, src.y, src.x, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color ggrg(this Vector3 src) {
			return new Color(src.y, src.y, src.x, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color ggrb(this Vector3 src) {
			return new Color(src.y, src.y, src.x, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gggr(this Vector3 src) {
			return new Color(src.y, src.y, src.y, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gggg(this Vector3 src) {
			return new Color(src.y, src.y, src.y, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gggb(this Vector3 src) {
			return new Color(src.y, src.y, src.y, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color ggbr(this Vector3 src) {
			return new Color(src.y, src.y, src.z, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color ggbg(this Vector3 src) {
			return new Color(src.y, src.y, src.z, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color ggbb(this Vector3 src) {
			return new Color(src.y, src.y, src.z, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gbrr(this Vector3 src) {
			return new Color(src.y, src.z, src.x, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gbrg(this Vector3 src) {
			return new Color(src.y, src.z, src.x, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gbrb(this Vector3 src) {
			return new Color(src.y, src.z, src.x, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gbgr(this Vector3 src) {
			return new Color(src.y, src.z, src.y, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gbgg(this Vector3 src) {
			return new Color(src.y, src.z, src.y, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gbgb(this Vector3 src) {
			return new Color(src.y, src.z, src.y, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gbbr(this Vector3 src) {
			return new Color(src.y, src.z, src.z, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gbbg(this Vector3 src) {
			return new Color(src.y, src.z, src.z, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color gbbb(this Vector3 src) {
			return new Color(src.y, src.z, src.z, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color brrr(this Vector3 src) {
			return new Color(src.z, src.x, src.x, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color brrg(this Vector3 src) {
			return new Color(src.z, src.x, src.x, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color brrb(this Vector3 src) {
			return new Color(src.z, src.x, src.x, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color brgr(this Vector3 src) {
			return new Color(src.z, src.x, src.y, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color brgg(this Vector3 src) {
			return new Color(src.z, src.x, src.y, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color brgb(this Vector3 src) {
			return new Color(src.z, src.x, src.y, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color brbr(this Vector3 src) {
			return new Color(src.z, src.x, src.z, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color brbg(this Vector3 src) {
			return new Color(src.z, src.x, src.z, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color brbb(this Vector3 src) {
			return new Color(src.z, src.x, src.z, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bgrr(this Vector3 src) {
			return new Color(src.z, src.y, src.x, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bgrg(this Vector3 src) {
			return new Color(src.z, src.y, src.x, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bgrb(this Vector3 src) {
			return new Color(src.z, src.y, src.x, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bggr(this Vector3 src) {
			return new Color(src.z, src.y, src.y, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bggg(this Vector3 src) {
			return new Color(src.z, src.y, src.y, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bggb(this Vector3 src) {
			return new Color(src.z, src.y, src.y, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bgbr(this Vector3 src) {
			return new Color(src.z, src.y, src.z, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bgbg(this Vector3 src) {
			return new Color(src.z, src.y, src.z, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bgbb(this Vector3 src) {
			return new Color(src.z, src.y, src.z, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bbrr(this Vector3 src) {
			return new Color(src.z, src.z, src.x, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bbrg(this Vector3 src) {
			return new Color(src.z, src.z, src.x, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bbrb(this Vector3 src) {
			return new Color(src.z, src.z, src.x, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bbgr(this Vector3 src) {
			return new Color(src.z, src.z, src.y, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bbgg(this Vector3 src) {
			return new Color(src.z, src.z, src.y, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bbgb(this Vector3 src) {
			return new Color(src.z, src.z, src.y, src.z);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bbbr(this Vector3 src) {
			return new Color(src.z, src.z, src.z, src.x);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bbbg(this Vector3 src) {
			return new Color(src.z, src.z, src.z, src.y);
		}

		/// <summary>
		/// Color←3D swizzle
		/// </summary>
		/// <param name="src">3D</param>
		/// <returns>4D</returns>
		public static Color bbbb(this Vector3 src) {
			return new Color(src.z, src.z, src.z, src.z);
		}
#endregion

#region Color←4D swizzle
		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrrr(this Vector4 src) {
			return new Color(src.x, src.x, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrrg(this Vector4 src) {
			return new Color(src.x, src.x, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrrb(this Vector4 src) {
			return new Color(src.x, src.x, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrra(this Vector4 src) {
			return new Color(src.x, src.x, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrgr(this Vector4 src) {
			return new Color(src.x, src.x, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrgg(this Vector4 src) {
			return new Color(src.x, src.x, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrgb(this Vector4 src) {
			return new Color(src.x, src.x, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrga(this Vector4 src) {
			return new Color(src.x, src.x, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrbr(this Vector4 src) {
			return new Color(src.x, src.x, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrbg(this Vector4 src) {
			return new Color(src.x, src.x, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrbb(this Vector4 src) {
			return new Color(src.x, src.x, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrba(this Vector4 src) {
			return new Color(src.x, src.x, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrar(this Vector4 src) {
			return new Color(src.x, src.x, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrag(this Vector4 src) {
			return new Color(src.x, src.x, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrab(this Vector4 src) {
			return new Color(src.x, src.x, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rraa(this Vector4 src) {
			return new Color(src.x, src.x, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgrr(this Vector4 src) {
			return new Color(src.x, src.y, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgrg(this Vector4 src) {
			return new Color(src.x, src.y, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgrb(this Vector4 src) {
			return new Color(src.x, src.y, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgra(this Vector4 src) {
			return new Color(src.x, src.y, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rggr(this Vector4 src) {
			return new Color(src.x, src.y, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rggg(this Vector4 src) {
			return new Color(src.x, src.y, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rggb(this Vector4 src) {
			return new Color(src.x, src.y, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgga(this Vector4 src) {
			return new Color(src.x, src.y, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgbr(this Vector4 src) {
			return new Color(src.x, src.y, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgbg(this Vector4 src) {
			return new Color(src.x, src.y, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgbb(this Vector4 src) {
			return new Color(src.x, src.y, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgba(this Vector4 src) {
			return new Color(src.x, src.y, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgar(this Vector4 src) {
			return new Color(src.x, src.y, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgag(this Vector4 src) {
			return new Color(src.x, src.y, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgab(this Vector4 src) {
			return new Color(src.x, src.y, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgaa(this Vector4 src) {
			return new Color(src.x, src.y, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbrr(this Vector4 src) {
			return new Color(src.x, src.z, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbrg(this Vector4 src) {
			return new Color(src.x, src.z, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbrb(this Vector4 src) {
			return new Color(src.x, src.z, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbra(this Vector4 src) {
			return new Color(src.x, src.z, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbgr(this Vector4 src) {
			return new Color(src.x, src.z, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbgg(this Vector4 src) {
			return new Color(src.x, src.z, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbgb(this Vector4 src) {
			return new Color(src.x, src.z, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbga(this Vector4 src) {
			return new Color(src.x, src.z, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbbr(this Vector4 src) {
			return new Color(src.x, src.z, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbbg(this Vector4 src) {
			return new Color(src.x, src.z, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbbb(this Vector4 src) {
			return new Color(src.x, src.z, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbba(this Vector4 src) {
			return new Color(src.x, src.z, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbar(this Vector4 src) {
			return new Color(src.x, src.z, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbag(this Vector4 src) {
			return new Color(src.x, src.z, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbab(this Vector4 src) {
			return new Color(src.x, src.z, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbaa(this Vector4 src) {
			return new Color(src.x, src.z, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rarr(this Vector4 src) {
			return new Color(src.x, src.w, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rarg(this Vector4 src) {
			return new Color(src.x, src.w, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rarb(this Vector4 src) {
			return new Color(src.x, src.w, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rara(this Vector4 src) {
			return new Color(src.x, src.w, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ragr(this Vector4 src) {
			return new Color(src.x, src.w, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ragg(this Vector4 src) {
			return new Color(src.x, src.w, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ragb(this Vector4 src) {
			return new Color(src.x, src.w, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raga(this Vector4 src) {
			return new Color(src.x, src.w, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rabr(this Vector4 src) {
			return new Color(src.x, src.w, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rabg(this Vector4 src) {
			return new Color(src.x, src.w, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rabb(this Vector4 src) {
			return new Color(src.x, src.w, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raba(this Vector4 src) {
			return new Color(src.x, src.w, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raar(this Vector4 src) {
			return new Color(src.x, src.w, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raag(this Vector4 src) {
			return new Color(src.x, src.w, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raab(this Vector4 src) {
			return new Color(src.x, src.w, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raaa(this Vector4 src) {
			return new Color(src.x, src.w, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grrr(this Vector4 src) {
			return new Color(src.y, src.x, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grrg(this Vector4 src) {
			return new Color(src.y, src.x, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grrb(this Vector4 src) {
			return new Color(src.y, src.x, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grra(this Vector4 src) {
			return new Color(src.y, src.x, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grgr(this Vector4 src) {
			return new Color(src.y, src.x, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grgg(this Vector4 src) {
			return new Color(src.y, src.x, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grgb(this Vector4 src) {
			return new Color(src.y, src.x, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grga(this Vector4 src) {
			return new Color(src.y, src.x, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grbr(this Vector4 src) {
			return new Color(src.y, src.x, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grbg(this Vector4 src) {
			return new Color(src.y, src.x, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grbb(this Vector4 src) {
			return new Color(src.y, src.x, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grba(this Vector4 src) {
			return new Color(src.y, src.x, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grar(this Vector4 src) {
			return new Color(src.y, src.x, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grag(this Vector4 src) {
			return new Color(src.y, src.x, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grab(this Vector4 src) {
			return new Color(src.y, src.x, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color graa(this Vector4 src) {
			return new Color(src.y, src.x, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggrr(this Vector4 src) {
			return new Color(src.y, src.y, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggrg(this Vector4 src) {
			return new Color(src.y, src.y, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggrb(this Vector4 src) {
			return new Color(src.y, src.y, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggra(this Vector4 src) {
			return new Color(src.y, src.y, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gggr(this Vector4 src) {
			return new Color(src.y, src.y, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gggg(this Vector4 src) {
			return new Color(src.y, src.y, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gggb(this Vector4 src) {
			return new Color(src.y, src.y, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggga(this Vector4 src) {
			return new Color(src.y, src.y, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggbr(this Vector4 src) {
			return new Color(src.y, src.y, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggbg(this Vector4 src) {
			return new Color(src.y, src.y, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggbb(this Vector4 src) {
			return new Color(src.y, src.y, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggba(this Vector4 src) {
			return new Color(src.y, src.y, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggar(this Vector4 src) {
			return new Color(src.y, src.y, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggag(this Vector4 src) {
			return new Color(src.y, src.y, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggab(this Vector4 src) {
			return new Color(src.y, src.y, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggaa(this Vector4 src) {
			return new Color(src.y, src.y, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbrr(this Vector4 src) {
			return new Color(src.y, src.z, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbrg(this Vector4 src) {
			return new Color(src.y, src.z, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbrb(this Vector4 src) {
			return new Color(src.y, src.z, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbra(this Vector4 src) {
			return new Color(src.y, src.z, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbgr(this Vector4 src) {
			return new Color(src.y, src.z, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbgg(this Vector4 src) {
			return new Color(src.y, src.z, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbgb(this Vector4 src) {
			return new Color(src.y, src.z, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbga(this Vector4 src) {
			return new Color(src.y, src.z, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbbr(this Vector4 src) {
			return new Color(src.y, src.z, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbbg(this Vector4 src) {
			return new Color(src.y, src.z, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbbb(this Vector4 src) {
			return new Color(src.y, src.z, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbba(this Vector4 src) {
			return new Color(src.y, src.z, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbar(this Vector4 src) {
			return new Color(src.y, src.z, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbag(this Vector4 src) {
			return new Color(src.y, src.z, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbab(this Vector4 src) {
			return new Color(src.y, src.z, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbaa(this Vector4 src) {
			return new Color(src.y, src.z, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color garr(this Vector4 src) {
			return new Color(src.y, src.w, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color garg(this Vector4 src) {
			return new Color(src.y, src.w, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color garb(this Vector4 src) {
			return new Color(src.y, src.w, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gara(this Vector4 src) {
			return new Color(src.y, src.w, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gagr(this Vector4 src) {
			return new Color(src.y, src.w, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gagg(this Vector4 src) {
			return new Color(src.y, src.w, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gagb(this Vector4 src) {
			return new Color(src.y, src.w, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaga(this Vector4 src) {
			return new Color(src.y, src.w, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gabr(this Vector4 src) {
			return new Color(src.y, src.w, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gabg(this Vector4 src) {
			return new Color(src.y, src.w, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gabb(this Vector4 src) {
			return new Color(src.y, src.w, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaba(this Vector4 src) {
			return new Color(src.y, src.w, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaar(this Vector4 src) {
			return new Color(src.y, src.w, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaag(this Vector4 src) {
			return new Color(src.y, src.w, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaab(this Vector4 src) {
			return new Color(src.y, src.w, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaaa(this Vector4 src) {
			return new Color(src.y, src.w, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brrr(this Vector4 src) {
			return new Color(src.z, src.x, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brrg(this Vector4 src) {
			return new Color(src.z, src.x, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brrb(this Vector4 src) {
			return new Color(src.z, src.x, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brra(this Vector4 src) {
			return new Color(src.z, src.x, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brgr(this Vector4 src) {
			return new Color(src.z, src.x, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brgg(this Vector4 src) {
			return new Color(src.z, src.x, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brgb(this Vector4 src) {
			return new Color(src.z, src.x, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brga(this Vector4 src) {
			return new Color(src.z, src.x, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brbr(this Vector4 src) {
			return new Color(src.z, src.x, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brbg(this Vector4 src) {
			return new Color(src.z, src.x, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brbb(this Vector4 src) {
			return new Color(src.z, src.x, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brba(this Vector4 src) {
			return new Color(src.z, src.x, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brar(this Vector4 src) {
			return new Color(src.z, src.x, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brag(this Vector4 src) {
			return new Color(src.z, src.x, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brab(this Vector4 src) {
			return new Color(src.z, src.x, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color braa(this Vector4 src) {
			return new Color(src.z, src.x, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgrr(this Vector4 src) {
			return new Color(src.z, src.y, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgrg(this Vector4 src) {
			return new Color(src.z, src.y, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgrb(this Vector4 src) {
			return new Color(src.z, src.y, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgra(this Vector4 src) {
			return new Color(src.z, src.y, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bggr(this Vector4 src) {
			return new Color(src.z, src.y, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bggg(this Vector4 src) {
			return new Color(src.z, src.y, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bggb(this Vector4 src) {
			return new Color(src.z, src.y, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgga(this Vector4 src) {
			return new Color(src.z, src.y, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgbr(this Vector4 src) {
			return new Color(src.z, src.y, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgbg(this Vector4 src) {
			return new Color(src.z, src.y, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgbb(this Vector4 src) {
			return new Color(src.z, src.y, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgba(this Vector4 src) {
			return new Color(src.z, src.y, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgar(this Vector4 src) {
			return new Color(src.z, src.y, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgag(this Vector4 src) {
			return new Color(src.z, src.y, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgab(this Vector4 src) {
			return new Color(src.z, src.y, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgaa(this Vector4 src) {
			return new Color(src.z, src.y, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbrr(this Vector4 src) {
			return new Color(src.z, src.z, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbrg(this Vector4 src) {
			return new Color(src.z, src.z, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbrb(this Vector4 src) {
			return new Color(src.z, src.z, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbra(this Vector4 src) {
			return new Color(src.z, src.z, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbgr(this Vector4 src) {
			return new Color(src.z, src.z, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbgg(this Vector4 src) {
			return new Color(src.z, src.z, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbgb(this Vector4 src) {
			return new Color(src.z, src.z, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbga(this Vector4 src) {
			return new Color(src.z, src.z, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbbr(this Vector4 src) {
			return new Color(src.z, src.z, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbbg(this Vector4 src) {
			return new Color(src.z, src.z, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbbb(this Vector4 src) {
			return new Color(src.z, src.z, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbba(this Vector4 src) {
			return new Color(src.z, src.z, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbar(this Vector4 src) {
			return new Color(src.z, src.z, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbag(this Vector4 src) {
			return new Color(src.z, src.z, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbab(this Vector4 src) {
			return new Color(src.z, src.z, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbaa(this Vector4 src) {
			return new Color(src.z, src.z, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color barr(this Vector4 src) {
			return new Color(src.z, src.w, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color barg(this Vector4 src) {
			return new Color(src.z, src.w, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color barb(this Vector4 src) {
			return new Color(src.z, src.w, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bara(this Vector4 src) {
			return new Color(src.z, src.w, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bagr(this Vector4 src) {
			return new Color(src.z, src.w, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bagg(this Vector4 src) {
			return new Color(src.z, src.w, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bagb(this Vector4 src) {
			return new Color(src.z, src.w, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baga(this Vector4 src) {
			return new Color(src.z, src.w, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color babr(this Vector4 src) {
			return new Color(src.z, src.w, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color babg(this Vector4 src) {
			return new Color(src.z, src.w, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color babb(this Vector4 src) {
			return new Color(src.z, src.w, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baba(this Vector4 src) {
			return new Color(src.z, src.w, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baar(this Vector4 src) {
			return new Color(src.z, src.w, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baag(this Vector4 src) {
			return new Color(src.z, src.w, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baab(this Vector4 src) {
			return new Color(src.z, src.w, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baaa(this Vector4 src) {
			return new Color(src.z, src.w, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arrr(this Vector4 src) {
			return new Color(src.w, src.x, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arrg(this Vector4 src) {
			return new Color(src.w, src.x, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arrb(this Vector4 src) {
			return new Color(src.w, src.x, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arra(this Vector4 src) {
			return new Color(src.w, src.x, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color argr(this Vector4 src) {
			return new Color(src.w, src.x, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color argg(this Vector4 src) {
			return new Color(src.w, src.x, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color argb(this Vector4 src) {
			return new Color(src.w, src.x, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arga(this Vector4 src) {
			return new Color(src.w, src.x, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arbr(this Vector4 src) {
			return new Color(src.w, src.x, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arbg(this Vector4 src) {
			return new Color(src.w, src.x, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arbb(this Vector4 src) {
			return new Color(src.w, src.x, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arba(this Vector4 src) {
			return new Color(src.w, src.x, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arar(this Vector4 src) {
			return new Color(src.w, src.x, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arag(this Vector4 src) {
			return new Color(src.w, src.x, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arab(this Vector4 src) {
			return new Color(src.w, src.x, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color araa(this Vector4 src) {
			return new Color(src.w, src.x, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agrr(this Vector4 src) {
			return new Color(src.w, src.y, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agrg(this Vector4 src) {
			return new Color(src.w, src.y, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agrb(this Vector4 src) {
			return new Color(src.w, src.y, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agra(this Vector4 src) {
			return new Color(src.w, src.y, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aggr(this Vector4 src) {
			return new Color(src.w, src.y, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aggg(this Vector4 src) {
			return new Color(src.w, src.y, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aggb(this Vector4 src) {
			return new Color(src.w, src.y, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agga(this Vector4 src) {
			return new Color(src.w, src.y, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agbr(this Vector4 src) {
			return new Color(src.w, src.y, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agbg(this Vector4 src) {
			return new Color(src.w, src.y, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agbb(this Vector4 src) {
			return new Color(src.w, src.y, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agba(this Vector4 src) {
			return new Color(src.w, src.y, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agar(this Vector4 src) {
			return new Color(src.w, src.y, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agag(this Vector4 src) {
			return new Color(src.w, src.y, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agab(this Vector4 src) {
			return new Color(src.w, src.y, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agaa(this Vector4 src) {
			return new Color(src.w, src.y, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abrr(this Vector4 src) {
			return new Color(src.w, src.z, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abrg(this Vector4 src) {
			return new Color(src.w, src.z, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abrb(this Vector4 src) {
			return new Color(src.w, src.z, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abra(this Vector4 src) {
			return new Color(src.w, src.z, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abgr(this Vector4 src) {
			return new Color(src.w, src.z, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abgg(this Vector4 src) {
			return new Color(src.w, src.z, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abgb(this Vector4 src) {
			return new Color(src.w, src.z, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abga(this Vector4 src) {
			return new Color(src.w, src.z, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abbr(this Vector4 src) {
			return new Color(src.w, src.z, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abbg(this Vector4 src) {
			return new Color(src.w, src.z, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abbb(this Vector4 src) {
			return new Color(src.w, src.z, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abba(this Vector4 src) {
			return new Color(src.w, src.z, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abar(this Vector4 src) {
			return new Color(src.w, src.z, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abag(this Vector4 src) {
			return new Color(src.w, src.z, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abab(this Vector4 src) {
			return new Color(src.w, src.z, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abaa(this Vector4 src) {
			return new Color(src.w, src.z, src.w, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aarr(this Vector4 src) {
			return new Color(src.w, src.w, src.x, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aarg(this Vector4 src) {
			return new Color(src.w, src.w, src.x, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aarb(this Vector4 src) {
			return new Color(src.w, src.w, src.x, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aara(this Vector4 src) {
			return new Color(src.w, src.w, src.x, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aagr(this Vector4 src) {
			return new Color(src.w, src.w, src.y, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aagg(this Vector4 src) {
			return new Color(src.w, src.w, src.y, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aagb(this Vector4 src) {
			return new Color(src.w, src.w, src.y, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaga(this Vector4 src) {
			return new Color(src.w, src.w, src.y, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aabr(this Vector4 src) {
			return new Color(src.w, src.w, src.z, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aabg(this Vector4 src) {
			return new Color(src.w, src.w, src.z, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aabb(this Vector4 src) {
			return new Color(src.w, src.w, src.z, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaba(this Vector4 src) {
			return new Color(src.w, src.w, src.z, src.w);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaar(this Vector4 src) {
			return new Color(src.w, src.w, src.w, src.x);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaag(this Vector4 src) {
			return new Color(src.w, src.w, src.w, src.y);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaab(this Vector4 src) {
			return new Color(src.w, src.w, src.w, src.z);
		}

		/// <summary>
		/// Color←4D swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaaa(this Vector4 src) {
			return new Color(src.w, src.w, src.w, src.w);
		}
#endregion

#region 4D←Color swizzle
		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxxx(this Color src) {
			return new Vector4(src.r, src.r, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxxy(this Color src) {
			return new Vector4(src.r, src.r, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxxz(this Color src) {
			return new Vector4(src.r, src.r, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxxw(this Color src) {
			return new Vector4(src.r, src.r, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxyx(this Color src) {
			return new Vector4(src.r, src.r, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxyy(this Color src) {
			return new Vector4(src.r, src.r, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxyz(this Color src) {
			return new Vector4(src.r, src.r, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxyw(this Color src) {
			return new Vector4(src.r, src.r, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxzx(this Color src) {
			return new Vector4(src.r, src.r, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxzy(this Color src) {
			return new Vector4(src.r, src.r, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxzz(this Color src) {
			return new Vector4(src.r, src.r, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxzw(this Color src) {
			return new Vector4(src.r, src.r, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxwx(this Color src) {
			return new Vector4(src.r, src.r, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxwy(this Color src) {
			return new Vector4(src.r, src.r, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxwz(this Color src) {
			return new Vector4(src.r, src.r, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xxww(this Color src) {
			return new Vector4(src.r, src.r, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyxx(this Color src) {
			return new Vector4(src.r, src.g, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyxy(this Color src) {
			return new Vector4(src.r, src.g, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyxz(this Color src) {
			return new Vector4(src.r, src.g, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyxw(this Color src) {
			return new Vector4(src.r, src.g, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyyx(this Color src) {
			return new Vector4(src.r, src.g, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyyy(this Color src) {
			return new Vector4(src.r, src.g, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyyz(this Color src) {
			return new Vector4(src.r, src.g, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyyw(this Color src) {
			return new Vector4(src.r, src.g, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyzx(this Color src) {
			return new Vector4(src.r, src.g, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyzy(this Color src) {
			return new Vector4(src.r, src.g, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyzz(this Color src) {
			return new Vector4(src.r, src.g, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyzw(this Color src) {
			return new Vector4(src.r, src.g, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xywx(this Color src) {
			return new Vector4(src.r, src.g, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xywy(this Color src) {
			return new Vector4(src.r, src.g, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xywz(this Color src) {
			return new Vector4(src.r, src.g, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xyww(this Color src) {
			return new Vector4(src.r, src.g, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzxx(this Color src) {
			return new Vector4(src.r, src.b, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzxy(this Color src) {
			return new Vector4(src.r, src.b, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzxz(this Color src) {
			return new Vector4(src.r, src.b, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzxw(this Color src) {
			return new Vector4(src.r, src.b, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzyx(this Color src) {
			return new Vector4(src.r, src.b, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzyy(this Color src) {
			return new Vector4(src.r, src.b, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzyz(this Color src) {
			return new Vector4(src.r, src.b, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzyw(this Color src) {
			return new Vector4(src.r, src.b, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzzx(this Color src) {
			return new Vector4(src.r, src.b, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzzy(this Color src) {
			return new Vector4(src.r, src.b, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzzz(this Color src) {
			return new Vector4(src.r, src.b, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzzw(this Color src) {
			return new Vector4(src.r, src.b, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzwx(this Color src) {
			return new Vector4(src.r, src.b, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzwy(this Color src) {
			return new Vector4(src.r, src.b, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzwz(this Color src) {
			return new Vector4(src.r, src.b, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xzww(this Color src) {
			return new Vector4(src.r, src.b, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwxx(this Color src) {
			return new Vector4(src.r, src.a, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwxy(this Color src) {
			return new Vector4(src.r, src.a, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwxz(this Color src) {
			return new Vector4(src.r, src.a, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwxw(this Color src) {
			return new Vector4(src.r, src.a, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwyx(this Color src) {
			return new Vector4(src.r, src.a, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwyy(this Color src) {
			return new Vector4(src.r, src.a, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwyz(this Color src) {
			return new Vector4(src.r, src.a, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwyw(this Color src) {
			return new Vector4(src.r, src.a, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwzx(this Color src) {
			return new Vector4(src.r, src.a, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwzy(this Color src) {
			return new Vector4(src.r, src.a, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwzz(this Color src) {
			return new Vector4(src.r, src.a, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwzw(this Color src) {
			return new Vector4(src.r, src.a, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwwx(this Color src) {
			return new Vector4(src.r, src.a, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwwy(this Color src) {
			return new Vector4(src.r, src.a, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwwz(this Color src) {
			return new Vector4(src.r, src.a, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 xwww(this Color src) {
			return new Vector4(src.r, src.a, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxxx(this Color src) {
			return new Vector4(src.g, src.r, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxxy(this Color src) {
			return new Vector4(src.g, src.r, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxxz(this Color src) {
			return new Vector4(src.g, src.r, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxxw(this Color src) {
			return new Vector4(src.g, src.r, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxyx(this Color src) {
			return new Vector4(src.g, src.r, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxyy(this Color src) {
			return new Vector4(src.g, src.r, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxyz(this Color src) {
			return new Vector4(src.g, src.r, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxyw(this Color src) {
			return new Vector4(src.g, src.r, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxzx(this Color src) {
			return new Vector4(src.g, src.r, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxzy(this Color src) {
			return new Vector4(src.g, src.r, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxzz(this Color src) {
			return new Vector4(src.g, src.r, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxzw(this Color src) {
			return new Vector4(src.g, src.r, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxwx(this Color src) {
			return new Vector4(src.g, src.r, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxwy(this Color src) {
			return new Vector4(src.g, src.r, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxwz(this Color src) {
			return new Vector4(src.g, src.r, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yxww(this Color src) {
			return new Vector4(src.g, src.r, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyxx(this Color src) {
			return new Vector4(src.g, src.g, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyxy(this Color src) {
			return new Vector4(src.g, src.g, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyxz(this Color src) {
			return new Vector4(src.g, src.g, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyxw(this Color src) {
			return new Vector4(src.g, src.g, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyyx(this Color src) {
			return new Vector4(src.g, src.g, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyyy(this Color src) {
			return new Vector4(src.g, src.g, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyyz(this Color src) {
			return new Vector4(src.g, src.g, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyyw(this Color src) {
			return new Vector4(src.g, src.g, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyzx(this Color src) {
			return new Vector4(src.g, src.g, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyzy(this Color src) {
			return new Vector4(src.g, src.g, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyzz(this Color src) {
			return new Vector4(src.g, src.g, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyzw(this Color src) {
			return new Vector4(src.g, src.g, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yywx(this Color src) {
			return new Vector4(src.g, src.g, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yywy(this Color src) {
			return new Vector4(src.g, src.g, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yywz(this Color src) {
			return new Vector4(src.g, src.g, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yyww(this Color src) {
			return new Vector4(src.g, src.g, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzxx(this Color src) {
			return new Vector4(src.g, src.b, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzxy(this Color src) {
			return new Vector4(src.g, src.b, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzxz(this Color src) {
			return new Vector4(src.g, src.b, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzxw(this Color src) {
			return new Vector4(src.g, src.b, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzyx(this Color src) {
			return new Vector4(src.g, src.b, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzyy(this Color src) {
			return new Vector4(src.g, src.b, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzyz(this Color src) {
			return new Vector4(src.g, src.b, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzyw(this Color src) {
			return new Vector4(src.g, src.b, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzzx(this Color src) {
			return new Vector4(src.g, src.b, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzzy(this Color src) {
			return new Vector4(src.g, src.b, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzzz(this Color src) {
			return new Vector4(src.g, src.b, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzzw(this Color src) {
			return new Vector4(src.g, src.b, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzwx(this Color src) {
			return new Vector4(src.g, src.b, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzwy(this Color src) {
			return new Vector4(src.g, src.b, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzwz(this Color src) {
			return new Vector4(src.g, src.b, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 yzww(this Color src) {
			return new Vector4(src.g, src.b, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywxx(this Color src) {
			return new Vector4(src.g, src.a, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywxy(this Color src) {
			return new Vector4(src.g, src.a, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywxz(this Color src) {
			return new Vector4(src.g, src.a, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywxw(this Color src) {
			return new Vector4(src.g, src.a, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywyx(this Color src) {
			return new Vector4(src.g, src.a, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywyy(this Color src) {
			return new Vector4(src.g, src.a, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywyz(this Color src) {
			return new Vector4(src.g, src.a, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywyw(this Color src) {
			return new Vector4(src.g, src.a, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywzx(this Color src) {
			return new Vector4(src.g, src.a, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywzy(this Color src) {
			return new Vector4(src.g, src.a, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywzz(this Color src) {
			return new Vector4(src.g, src.a, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywzw(this Color src) {
			return new Vector4(src.g, src.a, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywwx(this Color src) {
			return new Vector4(src.g, src.a, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywwy(this Color src) {
			return new Vector4(src.g, src.a, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywwz(this Color src) {
			return new Vector4(src.g, src.a, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 ywww(this Color src) {
			return new Vector4(src.g, src.a, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxxx(this Color src) {
			return new Vector4(src.b, src.r, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxxy(this Color src) {
			return new Vector4(src.b, src.r, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxxz(this Color src) {
			return new Vector4(src.b, src.r, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxxw(this Color src) {
			return new Vector4(src.b, src.r, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxyx(this Color src) {
			return new Vector4(src.b, src.r, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxyy(this Color src) {
			return new Vector4(src.b, src.r, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxyz(this Color src) {
			return new Vector4(src.b, src.r, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxyw(this Color src) {
			return new Vector4(src.b, src.r, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxzx(this Color src) {
			return new Vector4(src.b, src.r, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxzy(this Color src) {
			return new Vector4(src.b, src.r, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxzz(this Color src) {
			return new Vector4(src.b, src.r, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxzw(this Color src) {
			return new Vector4(src.b, src.r, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxwx(this Color src) {
			return new Vector4(src.b, src.r, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxwy(this Color src) {
			return new Vector4(src.b, src.r, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxwz(this Color src) {
			return new Vector4(src.b, src.r, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zxww(this Color src) {
			return new Vector4(src.b, src.r, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyxx(this Color src) {
			return new Vector4(src.b, src.g, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyxy(this Color src) {
			return new Vector4(src.b, src.g, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyxz(this Color src) {
			return new Vector4(src.b, src.g, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyxw(this Color src) {
			return new Vector4(src.b, src.g, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyyx(this Color src) {
			return new Vector4(src.b, src.g, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyyy(this Color src) {
			return new Vector4(src.b, src.g, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyyz(this Color src) {
			return new Vector4(src.b, src.g, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyyw(this Color src) {
			return new Vector4(src.b, src.g, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyzx(this Color src) {
			return new Vector4(src.b, src.g, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyzy(this Color src) {
			return new Vector4(src.b, src.g, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyzz(this Color src) {
			return new Vector4(src.b, src.g, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyzw(this Color src) {
			return new Vector4(src.b, src.g, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zywx(this Color src) {
			return new Vector4(src.b, src.g, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zywy(this Color src) {
			return new Vector4(src.b, src.g, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zywz(this Color src) {
			return new Vector4(src.b, src.g, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zyww(this Color src) {
			return new Vector4(src.b, src.g, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzxx(this Color src) {
			return new Vector4(src.b, src.b, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzxy(this Color src) {
			return new Vector4(src.b, src.b, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzxz(this Color src) {
			return new Vector4(src.b, src.b, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzxw(this Color src) {
			return new Vector4(src.b, src.b, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzyx(this Color src) {
			return new Vector4(src.b, src.b, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzyy(this Color src) {
			return new Vector4(src.b, src.b, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzyz(this Color src) {
			return new Vector4(src.b, src.b, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzyw(this Color src) {
			return new Vector4(src.b, src.b, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzzx(this Color src) {
			return new Vector4(src.b, src.b, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzzy(this Color src) {
			return new Vector4(src.b, src.b, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzzz(this Color src) {
			return new Vector4(src.b, src.b, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzzw(this Color src) {
			return new Vector4(src.b, src.b, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzwx(this Color src) {
			return new Vector4(src.b, src.b, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzwy(this Color src) {
			return new Vector4(src.b, src.b, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzwz(this Color src) {
			return new Vector4(src.b, src.b, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zzww(this Color src) {
			return new Vector4(src.b, src.b, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwxx(this Color src) {
			return new Vector4(src.b, src.a, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwxy(this Color src) {
			return new Vector4(src.b, src.a, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwxz(this Color src) {
			return new Vector4(src.b, src.a, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwxw(this Color src) {
			return new Vector4(src.b, src.a, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwyx(this Color src) {
			return new Vector4(src.b, src.a, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwyy(this Color src) {
			return new Vector4(src.b, src.a, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwyz(this Color src) {
			return new Vector4(src.b, src.a, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwyw(this Color src) {
			return new Vector4(src.b, src.a, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwzx(this Color src) {
			return new Vector4(src.b, src.a, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwzy(this Color src) {
			return new Vector4(src.b, src.a, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwzz(this Color src) {
			return new Vector4(src.b, src.a, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwzw(this Color src) {
			return new Vector4(src.b, src.a, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwwx(this Color src) {
			return new Vector4(src.b, src.a, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwwy(this Color src) {
			return new Vector4(src.b, src.a, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwwz(this Color src) {
			return new Vector4(src.b, src.a, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 zwww(this Color src) {
			return new Vector4(src.b, src.a, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxxx(this Color src) {
			return new Vector4(src.a, src.r, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxxy(this Color src) {
			return new Vector4(src.a, src.r, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxxz(this Color src) {
			return new Vector4(src.a, src.r, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxxw(this Color src) {
			return new Vector4(src.a, src.r, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxyx(this Color src) {
			return new Vector4(src.a, src.r, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxyy(this Color src) {
			return new Vector4(src.a, src.r, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxyz(this Color src) {
			return new Vector4(src.a, src.r, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxyw(this Color src) {
			return new Vector4(src.a, src.r, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxzx(this Color src) {
			return new Vector4(src.a, src.r, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxzy(this Color src) {
			return new Vector4(src.a, src.r, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxzz(this Color src) {
			return new Vector4(src.a, src.r, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxzw(this Color src) {
			return new Vector4(src.a, src.r, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxwx(this Color src) {
			return new Vector4(src.a, src.r, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxwy(this Color src) {
			return new Vector4(src.a, src.r, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxwz(this Color src) {
			return new Vector4(src.a, src.r, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wxww(this Color src) {
			return new Vector4(src.a, src.r, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyxx(this Color src) {
			return new Vector4(src.a, src.g, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyxy(this Color src) {
			return new Vector4(src.a, src.g, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyxz(this Color src) {
			return new Vector4(src.a, src.g, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyxw(this Color src) {
			return new Vector4(src.a, src.g, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyyx(this Color src) {
			return new Vector4(src.a, src.g, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyyy(this Color src) {
			return new Vector4(src.a, src.g, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyyz(this Color src) {
			return new Vector4(src.a, src.g, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyyw(this Color src) {
			return new Vector4(src.a, src.g, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyzx(this Color src) {
			return new Vector4(src.a, src.g, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyzy(this Color src) {
			return new Vector4(src.a, src.g, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyzz(this Color src) {
			return new Vector4(src.a, src.g, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyzw(this Color src) {
			return new Vector4(src.a, src.g, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wywx(this Color src) {
			return new Vector4(src.a, src.g, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wywy(this Color src) {
			return new Vector4(src.a, src.g, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wywz(this Color src) {
			return new Vector4(src.a, src.g, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wyww(this Color src) {
			return new Vector4(src.a, src.g, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzxx(this Color src) {
			return new Vector4(src.a, src.b, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzxy(this Color src) {
			return new Vector4(src.a, src.b, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzxz(this Color src) {
			return new Vector4(src.a, src.b, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzxw(this Color src) {
			return new Vector4(src.a, src.b, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzyx(this Color src) {
			return new Vector4(src.a, src.b, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzyy(this Color src) {
			return new Vector4(src.a, src.b, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzyz(this Color src) {
			return new Vector4(src.a, src.b, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzyw(this Color src) {
			return new Vector4(src.a, src.b, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzzx(this Color src) {
			return new Vector4(src.a, src.b, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzzy(this Color src) {
			return new Vector4(src.a, src.b, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzzz(this Color src) {
			return new Vector4(src.a, src.b, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzzw(this Color src) {
			return new Vector4(src.a, src.b, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzwx(this Color src) {
			return new Vector4(src.a, src.b, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzwy(this Color src) {
			return new Vector4(src.a, src.b, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzwz(this Color src) {
			return new Vector4(src.a, src.b, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wzww(this Color src) {
			return new Vector4(src.a, src.b, src.a, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwxx(this Color src) {
			return new Vector4(src.a, src.a, src.r, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwxy(this Color src) {
			return new Vector4(src.a, src.a, src.r, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwxz(this Color src) {
			return new Vector4(src.a, src.a, src.r, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwxw(this Color src) {
			return new Vector4(src.a, src.a, src.r, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwyx(this Color src) {
			return new Vector4(src.a, src.a, src.g, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwyy(this Color src) {
			return new Vector4(src.a, src.a, src.g, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwyz(this Color src) {
			return new Vector4(src.a, src.a, src.g, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwyw(this Color src) {
			return new Vector4(src.a, src.a, src.g, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwzx(this Color src) {
			return new Vector4(src.a, src.a, src.b, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwzy(this Color src) {
			return new Vector4(src.a, src.a, src.b, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwzz(this Color src) {
			return new Vector4(src.a, src.a, src.b, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwzw(this Color src) {
			return new Vector4(src.a, src.a, src.b, src.a);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwwx(this Color src) {
			return new Vector4(src.a, src.a, src.a, src.r);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwwy(this Color src) {
			return new Vector4(src.a, src.a, src.a, src.g);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwwz(this Color src) {
			return new Vector4(src.a, src.a, src.a, src.b);
		}

		/// <summary>
		/// 4D←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Vector4 wwww(this Color src) {
			return new Vector4(src.a, src.a, src.a, src.a);
		}
#endregion

#region Color←Color swizzle
		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrrr(this Color src) {
			return new Color(src.r, src.r, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrrg(this Color src) {
			return new Color(src.r, src.r, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrrb(this Color src) {
			return new Color(src.r, src.r, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrra(this Color src) {
			return new Color(src.r, src.r, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrgr(this Color src) {
			return new Color(src.r, src.r, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrgg(this Color src) {
			return new Color(src.r, src.r, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrgb(this Color src) {
			return new Color(src.r, src.r, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrga(this Color src) {
			return new Color(src.r, src.r, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrbr(this Color src) {
			return new Color(src.r, src.r, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrbg(this Color src) {
			return new Color(src.r, src.r, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrbb(this Color src) {
			return new Color(src.r, src.r, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrba(this Color src) {
			return new Color(src.r, src.r, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrar(this Color src) {
			return new Color(src.r, src.r, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrag(this Color src) {
			return new Color(src.r, src.r, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rrab(this Color src) {
			return new Color(src.r, src.r, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rraa(this Color src) {
			return new Color(src.r, src.r, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgrr(this Color src) {
			return new Color(src.r, src.g, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgrg(this Color src) {
			return new Color(src.r, src.g, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgrb(this Color src) {
			return new Color(src.r, src.g, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgra(this Color src) {
			return new Color(src.r, src.g, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rggr(this Color src) {
			return new Color(src.r, src.g, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rggg(this Color src) {
			return new Color(src.r, src.g, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rggb(this Color src) {
			return new Color(src.r, src.g, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgga(this Color src) {
			return new Color(src.r, src.g, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgbr(this Color src) {
			return new Color(src.r, src.g, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgbg(this Color src) {
			return new Color(src.r, src.g, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgbb(this Color src) {
			return new Color(src.r, src.g, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgba(this Color src) {
			return new Color(src.r, src.g, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgar(this Color src) {
			return new Color(src.r, src.g, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgag(this Color src) {
			return new Color(src.r, src.g, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgab(this Color src) {
			return new Color(src.r, src.g, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rgaa(this Color src) {
			return new Color(src.r, src.g, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbrr(this Color src) {
			return new Color(src.r, src.b, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbrg(this Color src) {
			return new Color(src.r, src.b, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbrb(this Color src) {
			return new Color(src.r, src.b, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbra(this Color src) {
			return new Color(src.r, src.b, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbgr(this Color src) {
			return new Color(src.r, src.b, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbgg(this Color src) {
			return new Color(src.r, src.b, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbgb(this Color src) {
			return new Color(src.r, src.b, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbga(this Color src) {
			return new Color(src.r, src.b, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbbr(this Color src) {
			return new Color(src.r, src.b, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbbg(this Color src) {
			return new Color(src.r, src.b, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbbb(this Color src) {
			return new Color(src.r, src.b, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbba(this Color src) {
			return new Color(src.r, src.b, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbar(this Color src) {
			return new Color(src.r, src.b, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbag(this Color src) {
			return new Color(src.r, src.b, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbab(this Color src) {
			return new Color(src.r, src.b, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rbaa(this Color src) {
			return new Color(src.r, src.b, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rarr(this Color src) {
			return new Color(src.r, src.a, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rarg(this Color src) {
			return new Color(src.r, src.a, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rarb(this Color src) {
			return new Color(src.r, src.a, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rara(this Color src) {
			return new Color(src.r, src.a, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ragr(this Color src) {
			return new Color(src.r, src.a, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ragg(this Color src) {
			return new Color(src.r, src.a, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ragb(this Color src) {
			return new Color(src.r, src.a, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raga(this Color src) {
			return new Color(src.r, src.a, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rabr(this Color src) {
			return new Color(src.r, src.a, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rabg(this Color src) {
			return new Color(src.r, src.a, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color rabb(this Color src) {
			return new Color(src.r, src.a, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raba(this Color src) {
			return new Color(src.r, src.a, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raar(this Color src) {
			return new Color(src.r, src.a, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raag(this Color src) {
			return new Color(src.r, src.a, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raab(this Color src) {
			return new Color(src.r, src.a, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color raaa(this Color src) {
			return new Color(src.r, src.a, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grrr(this Color src) {
			return new Color(src.g, src.r, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grrg(this Color src) {
			return new Color(src.g, src.r, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grrb(this Color src) {
			return new Color(src.g, src.r, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grra(this Color src) {
			return new Color(src.g, src.r, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grgr(this Color src) {
			return new Color(src.g, src.r, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grgg(this Color src) {
			return new Color(src.g, src.r, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grgb(this Color src) {
			return new Color(src.g, src.r, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grga(this Color src) {
			return new Color(src.g, src.r, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grbr(this Color src) {
			return new Color(src.g, src.r, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grbg(this Color src) {
			return new Color(src.g, src.r, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grbb(this Color src) {
			return new Color(src.g, src.r, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grba(this Color src) {
			return new Color(src.g, src.r, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grar(this Color src) {
			return new Color(src.g, src.r, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grag(this Color src) {
			return new Color(src.g, src.r, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color grab(this Color src) {
			return new Color(src.g, src.r, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color graa(this Color src) {
			return new Color(src.g, src.r, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggrr(this Color src) {
			return new Color(src.g, src.g, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggrg(this Color src) {
			return new Color(src.g, src.g, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggrb(this Color src) {
			return new Color(src.g, src.g, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggra(this Color src) {
			return new Color(src.g, src.g, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gggr(this Color src) {
			return new Color(src.g, src.g, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gggg(this Color src) {
			return new Color(src.g, src.g, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gggb(this Color src) {
			return new Color(src.g, src.g, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggga(this Color src) {
			return new Color(src.g, src.g, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggbr(this Color src) {
			return new Color(src.g, src.g, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggbg(this Color src) {
			return new Color(src.g, src.g, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggbb(this Color src) {
			return new Color(src.g, src.g, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggba(this Color src) {
			return new Color(src.g, src.g, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggar(this Color src) {
			return new Color(src.g, src.g, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggag(this Color src) {
			return new Color(src.g, src.g, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggab(this Color src) {
			return new Color(src.g, src.g, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color ggaa(this Color src) {
			return new Color(src.g, src.g, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbrr(this Color src) {
			return new Color(src.g, src.b, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbrg(this Color src) {
			return new Color(src.g, src.b, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbrb(this Color src) {
			return new Color(src.g, src.b, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbra(this Color src) {
			return new Color(src.g, src.b, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbgr(this Color src) {
			return new Color(src.g, src.b, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbgg(this Color src) {
			return new Color(src.g, src.b, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbgb(this Color src) {
			return new Color(src.g, src.b, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbga(this Color src) {
			return new Color(src.g, src.b, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbbr(this Color src) {
			return new Color(src.g, src.b, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbbg(this Color src) {
			return new Color(src.g, src.b, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbbb(this Color src) {
			return new Color(src.g, src.b, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbba(this Color src) {
			return new Color(src.g, src.b, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbar(this Color src) {
			return new Color(src.g, src.b, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbag(this Color src) {
			return new Color(src.g, src.b, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbab(this Color src) {
			return new Color(src.g, src.b, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gbaa(this Color src) {
			return new Color(src.g, src.b, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color garr(this Color src) {
			return new Color(src.g, src.a, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color garg(this Color src) {
			return new Color(src.g, src.a, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color garb(this Color src) {
			return new Color(src.g, src.a, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gara(this Color src) {
			return new Color(src.g, src.a, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gagr(this Color src) {
			return new Color(src.g, src.a, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gagg(this Color src) {
			return new Color(src.g, src.a, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gagb(this Color src) {
			return new Color(src.g, src.a, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaga(this Color src) {
			return new Color(src.g, src.a, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gabr(this Color src) {
			return new Color(src.g, src.a, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gabg(this Color src) {
			return new Color(src.g, src.a, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gabb(this Color src) {
			return new Color(src.g, src.a, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaba(this Color src) {
			return new Color(src.g, src.a, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaar(this Color src) {
			return new Color(src.g, src.a, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaag(this Color src) {
			return new Color(src.g, src.a, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaab(this Color src) {
			return new Color(src.g, src.a, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color gaaa(this Color src) {
			return new Color(src.g, src.a, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brrr(this Color src) {
			return new Color(src.b, src.r, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brrg(this Color src) {
			return new Color(src.b, src.r, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brrb(this Color src) {
			return new Color(src.b, src.r, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brra(this Color src) {
			return new Color(src.b, src.r, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brgr(this Color src) {
			return new Color(src.b, src.r, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brgg(this Color src) {
			return new Color(src.b, src.r, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brgb(this Color src) {
			return new Color(src.b, src.r, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brga(this Color src) {
			return new Color(src.b, src.r, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brbr(this Color src) {
			return new Color(src.b, src.r, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brbg(this Color src) {
			return new Color(src.b, src.r, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brbb(this Color src) {
			return new Color(src.b, src.r, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brba(this Color src) {
			return new Color(src.b, src.r, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brar(this Color src) {
			return new Color(src.b, src.r, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brag(this Color src) {
			return new Color(src.b, src.r, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color brab(this Color src) {
			return new Color(src.b, src.r, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color braa(this Color src) {
			return new Color(src.b, src.r, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgrr(this Color src) {
			return new Color(src.b, src.g, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgrg(this Color src) {
			return new Color(src.b, src.g, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgrb(this Color src) {
			return new Color(src.b, src.g, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgra(this Color src) {
			return new Color(src.b, src.g, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bggr(this Color src) {
			return new Color(src.b, src.g, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bggg(this Color src) {
			return new Color(src.b, src.g, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bggb(this Color src) {
			return new Color(src.b, src.g, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgga(this Color src) {
			return new Color(src.b, src.g, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgbr(this Color src) {
			return new Color(src.b, src.g, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgbg(this Color src) {
			return new Color(src.b, src.g, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgbb(this Color src) {
			return new Color(src.b, src.g, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgba(this Color src) {
			return new Color(src.b, src.g, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgar(this Color src) {
			return new Color(src.b, src.g, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgag(this Color src) {
			return new Color(src.b, src.g, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgab(this Color src) {
			return new Color(src.b, src.g, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bgaa(this Color src) {
			return new Color(src.b, src.g, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbrr(this Color src) {
			return new Color(src.b, src.b, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbrg(this Color src) {
			return new Color(src.b, src.b, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbrb(this Color src) {
			return new Color(src.b, src.b, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbra(this Color src) {
			return new Color(src.b, src.b, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbgr(this Color src) {
			return new Color(src.b, src.b, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbgg(this Color src) {
			return new Color(src.b, src.b, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbgb(this Color src) {
			return new Color(src.b, src.b, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbga(this Color src) {
			return new Color(src.b, src.b, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbbr(this Color src) {
			return new Color(src.b, src.b, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbbg(this Color src) {
			return new Color(src.b, src.b, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbbb(this Color src) {
			return new Color(src.b, src.b, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbba(this Color src) {
			return new Color(src.b, src.b, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbar(this Color src) {
			return new Color(src.b, src.b, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbag(this Color src) {
			return new Color(src.b, src.b, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbab(this Color src) {
			return new Color(src.b, src.b, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bbaa(this Color src) {
			return new Color(src.b, src.b, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color barr(this Color src) {
			return new Color(src.b, src.a, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color barg(this Color src) {
			return new Color(src.b, src.a, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color barb(this Color src) {
			return new Color(src.b, src.a, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bara(this Color src) {
			return new Color(src.b, src.a, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bagr(this Color src) {
			return new Color(src.b, src.a, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bagg(this Color src) {
			return new Color(src.b, src.a, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color bagb(this Color src) {
			return new Color(src.b, src.a, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baga(this Color src) {
			return new Color(src.b, src.a, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color babr(this Color src) {
			return new Color(src.b, src.a, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color babg(this Color src) {
			return new Color(src.b, src.a, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color babb(this Color src) {
			return new Color(src.b, src.a, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baba(this Color src) {
			return new Color(src.b, src.a, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baar(this Color src) {
			return new Color(src.b, src.a, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baag(this Color src) {
			return new Color(src.b, src.a, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baab(this Color src) {
			return new Color(src.b, src.a, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color baaa(this Color src) {
			return new Color(src.b, src.a, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arrr(this Color src) {
			return new Color(src.a, src.r, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arrg(this Color src) {
			return new Color(src.a, src.r, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arrb(this Color src) {
			return new Color(src.a, src.r, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arra(this Color src) {
			return new Color(src.a, src.r, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color argr(this Color src) {
			return new Color(src.a, src.r, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color argg(this Color src) {
			return new Color(src.a, src.r, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color argb(this Color src) {
			return new Color(src.a, src.r, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arga(this Color src) {
			return new Color(src.a, src.r, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arbr(this Color src) {
			return new Color(src.a, src.r, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arbg(this Color src) {
			return new Color(src.a, src.r, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arbb(this Color src) {
			return new Color(src.a, src.r, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arba(this Color src) {
			return new Color(src.a, src.r, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arar(this Color src) {
			return new Color(src.a, src.r, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arag(this Color src) {
			return new Color(src.a, src.r, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color arab(this Color src) {
			return new Color(src.a, src.r, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color araa(this Color src) {
			return new Color(src.a, src.r, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agrr(this Color src) {
			return new Color(src.a, src.g, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agrg(this Color src) {
			return new Color(src.a, src.g, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agrb(this Color src) {
			return new Color(src.a, src.g, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agra(this Color src) {
			return new Color(src.a, src.g, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aggr(this Color src) {
			return new Color(src.a, src.g, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aggg(this Color src) {
			return new Color(src.a, src.g, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aggb(this Color src) {
			return new Color(src.a, src.g, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agga(this Color src) {
			return new Color(src.a, src.g, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agbr(this Color src) {
			return new Color(src.a, src.g, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agbg(this Color src) {
			return new Color(src.a, src.g, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agbb(this Color src) {
			return new Color(src.a, src.g, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agba(this Color src) {
			return new Color(src.a, src.g, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agar(this Color src) {
			return new Color(src.a, src.g, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agag(this Color src) {
			return new Color(src.a, src.g, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agab(this Color src) {
			return new Color(src.a, src.g, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color agaa(this Color src) {
			return new Color(src.a, src.g, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abrr(this Color src) {
			return new Color(src.a, src.b, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abrg(this Color src) {
			return new Color(src.a, src.b, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abrb(this Color src) {
			return new Color(src.a, src.b, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abra(this Color src) {
			return new Color(src.a, src.b, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abgr(this Color src) {
			return new Color(src.a, src.b, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abgg(this Color src) {
			return new Color(src.a, src.b, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abgb(this Color src) {
			return new Color(src.a, src.b, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abga(this Color src) {
			return new Color(src.a, src.b, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abbr(this Color src) {
			return new Color(src.a, src.b, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abbg(this Color src) {
			return new Color(src.a, src.b, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abbb(this Color src) {
			return new Color(src.a, src.b, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abba(this Color src) {
			return new Color(src.a, src.b, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abar(this Color src) {
			return new Color(src.a, src.b, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abag(this Color src) {
			return new Color(src.a, src.b, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abab(this Color src) {
			return new Color(src.a, src.b, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color abaa(this Color src) {
			return new Color(src.a, src.b, src.a, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aarr(this Color src) {
			return new Color(src.a, src.a, src.r, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aarg(this Color src) {
			return new Color(src.a, src.a, src.r, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aarb(this Color src) {
			return new Color(src.a, src.a, src.r, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aara(this Color src) {
			return new Color(src.a, src.a, src.r, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aagr(this Color src) {
			return new Color(src.a, src.a, src.g, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aagg(this Color src) {
			return new Color(src.a, src.a, src.g, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aagb(this Color src) {
			return new Color(src.a, src.a, src.g, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaga(this Color src) {
			return new Color(src.a, src.a, src.g, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aabr(this Color src) {
			return new Color(src.a, src.a, src.b, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aabg(this Color src) {
			return new Color(src.a, src.a, src.b, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aabb(this Color src) {
			return new Color(src.a, src.a, src.b, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaba(this Color src) {
			return new Color(src.a, src.a, src.b, src.a);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaar(this Color src) {
			return new Color(src.a, src.a, src.a, src.r);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaag(this Color src) {
			return new Color(src.a, src.a, src.a, src.g);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaab(this Color src) {
			return new Color(src.a, src.a, src.a, src.b);
		}

		/// <summary>
		/// Color←Color swizzle
		/// </summary>
		/// <param name="src">4D</param>
		/// <returns>4D</returns>
		public static Color aaaa(this Color src) {
			return new Color(src.a, src.a, src.a, src.a);
		}
#endregion
	}
}
