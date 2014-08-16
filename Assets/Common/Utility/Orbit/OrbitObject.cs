using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(Rigidbody2D))]
public class OrbitObject : MonoBehaviour {
	public	int				user_flag;			//フラグ
	public	Sprite			sprite;				//スプライト
	public	Transform		transform_;			//トランスフォーム
	public	Rigidbody2D		rigidbody_;			//剛体
	public	Color			color;				//色
	public	int				order;				//描画順(小さい方が先)
	public	int				initorder;			//初期化順

	static int s_initorder = int.MinValue;

	private	Vector3[]		vertices_base;
	private	Vector2[]		uvs_base;
	private int				m_LayerFlagBg;

	public void Init(Sprite sp = null) {
		if (null != sp) {
			user_flag					= 0;
			sprite						= sp;
			transform_.localPosition	= Vector3.zero;
			transform_.localRotation	= Quaternion.identity;
			transform_.localScale		= Vector3.one;
			rigidbody_.velocity			= Vector2.zero;
			rigidbody_.angularVelocity	= 0.0f;
			color						= Color.black;
			order						= 0;
			initorder					= ++s_initorder;

			{
				var rect = sprite.textureRect;
				transform_.localScale = new Vector3(rect.width, rect.height, 1.0f);

				var collider = GetComponent<BoxCollider2D>();
				collider.size	= new Vector2(4.0f / rect.width, 4.0f / rect.height);
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
			sprite					= sp;
			transform_.localScale	= Vector3.zero;
			initorder				= ++s_initorder;
		}
	}

	public bool			valid{get{return null!=sprite;}}
	public Vector3		position{get{return transform_.localPosition;} set{transform_.localPosition = value;}}
	public Quaternion	rotation{get{return transform_.localRotation;} set{transform_.localRotation = value;}}
	public Vector3		scale{get{
		var result = transform_.localScale;
		if (null != sprite) {
			var rect = sprite.textureRect;
			result = Vector3.Scale(result, new Vector3(1.0f / rect.width, 1.0f / rect.height, 1.0f));
		}
		return result;
	} set{
		if (null != sprite) {
			var rect = sprite.textureRect;
			value = Vector3.Scale(value, new Vector3(rect.width, rect.height, 1.0f));
		}
		transform_.localScale = value;
	}}
	public Vector2		velocity_position{get{return rigidbody_.velocity;} set{rigidbody_.velocity = value;}}
	public float		velocity_rotation{get{return rigidbody_.angularVelocity;} set{rigidbody_.angularVelocity = value;}}

	public IEnumerable<Vector3> vertices{get{
		return vertices_base;
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

	/// <summary>
	/// 破棄
	/// </summary>
	public void Destory() {
		Init(null);
		var material = transform_.parent.GetComponent<OrbitMaterial>();
		material.FreeOrbitIndices(this);
	}
	
	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		transform_ = GetComponent<Transform>();
		rigidbody_ = GetComponent<Rigidbody2D>();
		m_LayerFlagBg	= LayerMask.NameToLayer("Bg");
		vertices_base = new[]{new Vector3(-0.5f,  0.5f, 0.0f)
							, new Vector3(0.5f,  0.5f, 0.0f)
							, new Vector3(-0.5f, -0.5f, 0.0f)
							, new Vector3(0.5f, -0.5f, 0.0f)
							};
		Init(null);
	}
	
	/// <summary>
	/// トリガー衝突解消
	/// </summary>
	/// <param name="other">衝突対象</param>
	void OnTriggerExit2D(Collider2D other) {
		var target_layer = other.gameObject.layer;
		if (m_LayerFlagBg == target_layer) {
			//背景
			Destory();
		}
	}
}
