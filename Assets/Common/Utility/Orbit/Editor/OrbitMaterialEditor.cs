using UnityEngine;
using UnityEditor;
using System.Linq;

[CustomEditor(typeof(OrbitMaterial))]
public class OrbitMaterialEditor : Editor {
	/// <summary>
	/// Inspector描画
	/// </summary>
	public override void OnInspectorGUI() {
		DrawDefaultInspector();
	}

	/// <summary>
	/// Preview描画確認
	/// </summary>
	/// <returns>true:描画する,false:描画しない</returns>
	public override bool HasPreviewGUI() {
		return true;
	}

	/// <summary>
	/// Preview描画
	/// </summary>
	/// <param name="r">描画領域</param>
	/// <param name="background">背景スタイル</param>
	public override void OnPreviewGUI(Rect r, GUIStyle background) {
		OrbitMaterial orbit_material = (OrbitMaterial)target;

		var texture_bounds = orbit_material.m_Sprite.bounds;
		var collider_bounds = orbit_material.m_ColliderBounds;
		var cover_bounds = CoverBounds(new []{texture_bounds, collider_bounds});
		cover_bounds.Expand(2.0f);

		var tex_r = GetDrawRect(r, cover_bounds, texture_bounds);
		var tex_coords = new Rect();
		tex_coords.min = Vector2.Scale(orbit_material.m_Sprite.textureRect.min, orbit_material.m_Sprite.texture.texelSize);
		tex_coords.max = Vector2.Scale(orbit_material.m_Sprite.textureRect.max, orbit_material.m_Sprite.texture.texelSize);
		GUI.DrawTextureWithTexCoords(tex_r, orbit_material.m_Sprite.texture, tex_coords);

		var col_r = GetDrawRect(r, cover_bounds, collider_bounds);
		DrawRectFrameLine(col_r, Color.green);
	}

	/// <summary>
	/// 全包括バウンズ作成
	/// </summary>
	/// <param name="bounds">包括されるバウンズの配列</param>
	/// <returns>包括バウンズ</returns>
	private static Bounds CoverBounds(Bounds[] bounds) {
		var result = bounds[0];
		foreach (var b in bounds.Skip(1)) {
			result.min = Vector3.Min(result.min, b.min);
			result.max = Vector3.Max(result.max, b.max);
		}
		return result;
	}

	/// <summary>
	/// 描画矩形取得
	/// </summary>
	/// <param name="r">描画領域</param>
	/// <param name="cover_bounds">全包括バウンズ</param>
	/// <param name="bounds">対象バウンズ</param>
	/// <returns>描画矩形</returns>
	private static Rect GetDrawRect(Rect r, Bounds cover_bounds, Bounds bounds) {
		System.Func<Vector3, Vector2> vector2 = x=>new Vector2(x.x, x.y);

		var result = new Rect(r);
		float scale;
		if (r.width/r.height <= cover_bounds.size.x/cover_bounds.size.y) {
			scale = r.width / cover_bounds.size.x;
		} else {
			scale = r.height / cover_bounds.size.y;
		}

		result.size = vector2(bounds.size) * scale;
		result.center = r.center + (vector2(bounds.center) - vector2(cover_bounds.center)) * scale;
		return result;
	}

	/// <summary>
	/// 矩形枠線描画
	/// </summary>
	/// <param name="r">描画矩形</param>
	/// <param name="color">色</param>
	private static void DrawRectFrameLine(Rect r, Color color) {
		var col_s = new GUIStyle();
		var col_t = new Texture2D(1, 1);
		col_t.SetPixel(0, 0, color);
		col_t.Apply();
		col_s.normal.background = col_t;

		Rect draw_r = r;
		draw_r.width = 1.0f;
		GUI.Box(draw_r, new GUIContent(), col_s);
		draw_r.x += r.width - 1.0f;
		GUI.Box(draw_r, new GUIContent(), col_s);
		draw_r = r;
		draw_r.height = 1.0f;
		GUI.Box(draw_r, new GUIContent(), col_s);
		draw_r.y += r.height - 1.0f;
		GUI.Box(draw_r, new GUIContent(), col_s);
	}
}
