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
	public	Sprite			sprite;				//スプライト
	public	OrbitTransform	transform;			//トランスフォーム
	public	OrbitTransform	velocity;			//速度
	public	Bounds			collider_bounds;	//当たり判定
	public	Color			color;				//色
	public	int				order;				//描画順(小さい方が先)
	public	int				initorder;			//初期化順

	static int s_initorder = int.MinValue;

	private	Vector3[]		vertices_base;
	private	Vector2[]		uvs_base;

	public void Init(Sprite sp = null) {
		if (null != sp) {
			user_flag			= 0;
			sprite				= sp;
			transform.position	= Vector3.zero;
			transform.rotation	= Quaternion.identity;
			transform.scale		= Vector3.one;
			velocity.position	= Vector3.zero;
			velocity.rotation	= Quaternion.identity;
			velocity.scale		= Vector3.one;
			collider_bounds		= new Bounds(Vector3.zero, new Vector3(4.0f, 4.0f, float.Epsilon));
			color				= Color.black;
			order				= 0;
			initorder			= ++s_initorder;

			{
				var rect = sprite.textureRect;
				rect.width *= 0.5f;
				rect.height *= 0.5f;
				var that = this;
				vertices_base = new[]{new Vector3(-rect.width,  rect.height, 0.0f)
									, new Vector3(rect.width,  rect.height, 0.0f)
									, new Vector3(-rect.width, -rect.height, 0.0f)
									, new Vector3(rect.width, -rect.height, 0.0f)
									};
			}
			{
				var texel_size = sprite.texture.texelSize;
				var rect = sprite.textureRect;
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
			sprite				= sp;
			transform.scale		= Vector3.zero;
			initorder			= ++s_initorder;
		}
	}

	public bool			valid{get{return null!=sprite;}}
	public Vector3		position{get{return transform.position;} set{transform.position = value;}}
	public Quaternion	rotation{get{return transform.rotation;} set{transform.rotation = value;}}
	public Vector3		scale{get{return transform.scale;} set{transform.scale = value;}}
	public Vector3		velocity_position{get{return velocity.position;} set{velocity.position = value;}}
	public Quaternion	velocity_rotation{get{return velocity.rotation;} set{velocity.rotation = value;}}
	public Vector3		velocity_scale{get{return velocity.scale;} set{velocity.scale = value;}}

	public IEnumerable<Vector3> vertices{get{
		IEnumerable<Vector3> result = null;
		if (null != sprite) {
			var that = this;
			result = vertices_base.Select(x=>(that.transform.rotation * Vector3.Scale(x, that.transform.scale) + that.transform.position));
		} else {
			 result = Enumerable.Repeat(Vector3.zero, 4);
		}
		return result;
	}}
	public IEnumerable<Vector2> uvs{get{
		IEnumerable<Vector2> result = null;
		if (null != sprite) {
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
