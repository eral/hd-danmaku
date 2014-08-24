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
	public	int				user_flag;			//フラグ
	public	OrbitTransform	transform;			//トランスフォーム
	public	OrbitTransform	velocity;			//速度
	public	Bounds			draw_bounds;		//描画範囲
	public	Bounds			collider_bounds;	//当たり判定
	public	Color			color;				//色
	public	int				order;				//描画順(小さい方が先)
	public	int				initorder;			//初期化順

	public	OrbitMaterial	material;			//軌道マテリアル
	private	Vector3[]		vertices_base;
	private	Vector2[]		uvs_base;

	static int s_initorder = int.MinValue;

	public void Init(OrbitMaterial m = null) {
		if (null != m) {
			user_flag			= 0;
			material			= m;
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
			material			= m;
			transform.scale		= Vector3.zero;
			initorder			= ++s_initorder;
		}
	}

	public bool			valid{get{return null!=material;}}
	public Vector3		position{get{return transform.position;} set{transform.position = value;}}
	public Quaternion	rotation{get{return transform.rotation;} set{transform.rotation = value;}}
	public Vector3		scale{get{return transform.scale;} set{transform.scale = value;}}
	public Vector3		velocity_position{get{return velocity.position;} set{velocity.position = value;}}
	public Quaternion	velocity_rotation{get{return velocity.rotation;} set{velocity.rotation = value;}}
	public Vector3		velocity_scale{get{return velocity.scale;} set{velocity.scale = value;}}

	public IEnumerable<Vector3> vertices{get{
		IEnumerable<Vector3> result = null;
		if (null != material) {
			var that = this;
			result = vertices_base.Select(x=>(that.transform.rotation * Vector3.Scale(x, that.transform.scale) + that.transform.position));
		} else {
			 result = Enumerable.Repeat(Vector3.zero, 4);
		}
		return result;
	}}
	public IEnumerable<Vector2> uvs{get{
		IEnumerable<Vector2> result = null;
		if (null != material) {
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
