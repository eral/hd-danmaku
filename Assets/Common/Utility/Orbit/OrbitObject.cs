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
	public	Sprite			sprite;		//スプライト
	public	OrbitTransform	transform;	//トランスフォーム
	public	OrbitTransform	velocity;	//速度
	public	Color			color;		//色
	public	int				order;		//描画順(小さい方が先)
	public	float			inittime;	//初期化時刻

	public void Init(Sprite sp = null) {
		if (null != sp) {
			sprite				= sp;
			transform.position	= Vector3.zero;
			transform.rotation	= Quaternion.identity;
			transform.scale		= Vector3.one;
			velocity.position	= Vector3.zero;
			velocity.rotation	= Quaternion.identity;
			velocity.scale		= Vector3.one;
			color				= Color.black;
			order				= 0;
			inittime			= Time.time;
		} else {
			sprite				= sp;
			transform.scale		= Vector3.zero;
			inittime			= Time.time;
		}
	}

	public Vector3		position{get{return transform.position;} set{transform.position = value;}}
	public Quaternion	rotation{get{return transform.rotation;} set{transform.rotation = value;}}
	public Vector3		scale{get{return transform.scale;} set{transform.scale = value;}}
	public Vector3		velocity_position{get{return velocity.position;} set{velocity.position = value;}}
	public Quaternion	velocity_rotation{get{return velocity.rotation;} set{velocity.rotation = value;}}
	public Vector3		velocity_scale{get{return velocity.scale;} set{velocity.scale = value;}}

	public IEnumerable<Vector3> vertices{get{
		IEnumerable<Vector3> result = null;
		if (null != sprite) {
			var rect = sprite.textureRect;
			rect.width *= 0.5f;
			rect.height *= 0.5f;
			var that = this;
			result = (new[]{new Vector3(-rect.width,  rect.height, 0.0f)
							, new Vector3(rect.width,  rect.height, 0.0f)
							, new Vector3(-rect.width, -rect.height, 0.0f)
							, new Vector3(rect.width, -rect.height, 0.0f)
							}).Select(x=>(that.transform.rotation * Vector3.Scale(x, that.transform.scale) + that.transform.position));
		} else {
			 result = Enumerable.Repeat(Vector3.zero, 4);
		}
		return result;
	}}
	public IEnumerable<Vector2> uvs{get{
		IEnumerable<Vector2> result = null;
		if (null != sprite) {
			var texel_size = sprite.texture.texelSize;
			var rect = sprite.textureRect;
			rect.xMin *= texel_size.x;
			rect.xMax *= texel_size.x;
			rect.yMin *= texel_size.y;
			rect.yMax *= texel_size.y;
			result = new[]{new Vector2(rect.xMin, rect.yMax)
						, new Vector2(rect.xMax, rect.yMax)
						, new Vector2(rect.xMin, rect.yMin)
						, new Vector2(rect.xMax, rect.yMin)
						};
		} else {
			 result = Enumerable.Repeat(Vector2.zero, 4);
		}
		return result;
	}}
	public IEnumerable<Color> colors{get{
		return Enumerable.Repeat(color, 4);
	}}
}
