using UnityEngine;

public class OrbitMaterial : ScriptableObject {
	public Material m_Material;
	public Sprite	m_Sprite;
	public Color	m_Color = Color.black;
	public Bounds	m_ColliderBounds;

#if UNITY_EDITOR
	private const string menuName	= "Original Material";
	private const string fileName	= "New Original Material.asset";

	[UnityEditor.MenuItem("Assets/Create/" + menuName)]
	public static void Create() {
		var asset = ScriptableObject.CreateInstance<OrbitMaterial>();
		UnityEditor.ProjectWindowUtil.CreateAsset(asset, fileName);
 	}
#endif
}
