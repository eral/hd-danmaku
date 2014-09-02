using UnityEngine;

public class OrbitMaterial : ScriptableObject {
				public Material m_Material;
				public Sprite	m_Sprite;
				public Color	m_Color = Color.black;
				public Bounds	m_ColliderBounds;
	[EnumMask]	public Flags	m_Flag;
				public Tag		m_Tag;

	[System.Flags]
	public enum Flags {
		NonAffine	= 1<<0,	//無変形(回転・拡大縮小無し))
	}

	public enum Tag {
		None,
		PlayerShot,
		EnemyShot,
		Item,
	}


#if UNITY_EDITOR
	private const string menuName	= "Orbit Material";
	private const string fileName	= "New Orbit Material.asset";

	[UnityEditor.MenuItem("Assets/Create/" + menuName)]
	public static void Create() {
		var asset = ScriptableObject.CreateInstance<OrbitMaterial>();
		UnityEditor.ProjectWindowUtil.CreateAsset(asset, fileName);
 	}
#endif
}
