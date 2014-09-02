using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public struct OrbitTransform {
						public	Vector3		position;	//位置
	[QuaternionEuler]	public	Quaternion	rotation;	//回転
						public	Vector3		scale;		//拡縮率
}

[System.Serializable]
public struct OrbitObject {
	[EnumMask]	public	Flags				flag;				//フラグ
				public	OrbitMaterial.Tag	tag;				//タグ
				public	OrbitTransform		transform;			//トランスフォーム
				public	OrbitTransform		velocity;			//速度
				public	Bounds				draw_bounds;		//描画範囲
				public	Bounds				collider_bounds;	//当たり判定
				public	Color				color;				//色
				public	int					order;				//描画順(小さい方が先)
				public	int					initorder;			//初期化順

	[System.Flags]
	public enum Flags {
		Valid			= 1<<0,	//有効オブジェクト
		NonAffine		= 1<<1,	//無変形(回転・拡大縮小無し))
		PlayerHoming	= 1<<2,	//プレイヤーホーミング
		Grazed			= 1<<3,	//かすり済み
	}

	private	Vector3[]	vertices_base;	//頂点キャッシュ
	private	Vector2[]	uvs_base;		//UVキャッシュ

	static int s_initorder = int.MinValue;

	public void Init(OrbitMaterial m = null) {
		if (null != m) {
			flag				= Flags.Valid | ((0!=(OrbitMaterial.Flags.NonAffine & m.m_Flag))? Flags.NonAffine: 0);
			tag					= m.m_Tag;
			transform.position	= Vector3.zero;
			transform.rotation	= Quaternion.identity;
			transform.scale		= Vector3.one;
			velocity.position	= Vector3.zero;
			velocity.rotation	= Quaternion.identity;
			velocity.scale		= Vector3.one;
			collider_bounds		= m.m_ColliderBounds;
			color				= m.m_Color;
			order				= 0;
			initorder			= ++s_initorder;

			{
				var rect = m.m_Sprite.textureRect;
				draw_bounds.center = Vector3.zero;
				draw_bounds.size = new Vector3(rect.width, rect.height, float.Epsilon);

				rect.width *= 0.5f;
				rect.height *= 0.5f;
				vertices_base = new[]{new Vector3(-rect.width,  rect.height, 0.0f)
									, new Vector3(rect.width,  rect.height, 0.0f)
									, new Vector3(-rect.width, -rect.height, 0.0f)
									, new Vector3(rect.width, -rect.height, 0.0f)
									};
			}
			{
				var texel_size = m.m_Sprite.texture.texelSize;
				var rect = m.m_Sprite.textureRect;
				rect.xMin *= texel_size.x;
				rect.xMax *= texel_size.x;
				rect.yMin *= texel_size.y;
				rect.yMax *= texel_size.y;
				uvs_base = new[]{new Vector2(rect.xMin, rect.yMax)
								, new Vector2(rect.xMax, rect.yMax)
								, new Vector2(rect.xMin, rect.yMin)
								, new Vector2(rect.xMax, rect.yMin)
								};
				
			}
		} else {
			flag				= (Flags)0;
			tag					= 0;
			transform.scale		= Vector3.zero;
			initorder			= ++s_initorder;
		}
	}

	public bool			valid{get{return 0 != (Flags.Valid & flag);}}
	public bool			move_only{get{return 0 != (Flags.NonAffine & flag);} set{if (value) {flag |= Flags.NonAffine;} else {flag &= ~Flags.NonAffine;}}}
	public bool			player_homing{get{return 0 != (Flags.PlayerHoming & flag);} set{if (value) {flag |= Flags.PlayerHoming;} else {flag &= ~Flags.PlayerHoming;}}}
	public bool			grazed{get{return 0 != (Flags.Grazed & flag);} set{if (value) {flag |= Flags.Grazed;} else {flag &= ~Flags.Grazed;}}}
	public Vector3		position{get{return transform.position;} set{transform.position = value;}}
	public Quaternion	rotation{get{return transform.rotation;} set{transform.rotation = value;}}
	public Vector3		scale{get{return transform.scale;} set{transform.scale = value;}}
	public Vector3		velocity_position{get{return velocity.position;} set{velocity.position = value;}}
	public Quaternion	velocity_rotation{get{return velocity.rotation;} set{velocity.rotation = value;}}
	public Vector3		velocity_scale{get{return velocity.scale;} set{velocity.scale = value;}}

	public IEnumerable<Vector3> vertices{get{
		IEnumerable<Vector3> result = null;
		if (valid) {
			var that = this;
			if (move_only) {
				//移動のみ
				result = vertices_base.Select(x=>x + that.transform.position);
			} else {
				//全トランスフォーム有効
				result = vertices_base.Select(x=>(that.transform.rotation * Vector3.Scale(x, that.transform.scale) + that.transform.position));
			}
		} else {
			result = Enumerable.Repeat(Vector3.zero, 4);
		}
		return result;
	}}
	public IEnumerable<Vector2> uvs{get{
		IEnumerable<Vector2> result = null;
		if (valid) {
			result = uvs_base;
		} else {
			result = Enumerable.Repeat(Vector2.zero, 4);
		}
		return result;
	}}
	public IEnumerable<Color> colors{get{
		return Enumerable.Repeat(color, 4);
	}}
}
