Shader "Custom/ShotAlpha"
{
	Properties {
		_MainTex ("Sprite Texture", 2D) = "white" {}
		[MaterialToggle] PixelSnap ("Pixel snap", Float) = 0
	}

	SubShader {
		Tags { 
			"Queue"="Transparent" 
			"IgnoreProjector"="True" 
			"RenderType"="Transparent" 
			"PreviewType"="Plane"
			"CanUseSpriteAtlas"="True"
		}

		Cull Off
		Lighting Off
		ZWrite Off
		AlphaTest Greater 0
		Fog { Mode Off }
		Blend SrcAlpha OneMinusSrcAlpha

		Pass {
		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile DUMMY PIXELSNAP_ON
			#include "UnityCG.cginc"
			
			static const float2	c_color_offset = 256.0;

			struct appdata_t {
				float4 vertex	: POSITION;
				float4 tangent	: TANGENT;
			};

			struct v2f {
				float4 vertex	: SV_POSITION;
				fixed4 color	: COLOR;
				half2 texcoord	: TEXCOORD0;
			};

			float ColorValue(float f) {
				return floor(frac(f) * 256.0) * 2.0;
			}

			v2f vert(appdata_t IN) {
				v2f OUT;
				OUT.vertex = mul(UNITY_MATRIX_MVP, IN.vertex);
				OUT.texcoord = IN.tangent.xy;
				OUT.color.r = ColorValue(IN.tangent.z);
				OUT.color.g = ColorValue(IN.tangent.z * c_color_offset);
				OUT.color.b = ColorValue(IN.tangent.w);
				OUT.color.a = 1.0f;//ColorValue(IN.tangent.w * c_color_offset);
				#ifdef PIXELSNAP_ON
				OUT.vertex = UnityPixelSnap (OUT.vertex);
				#endif

				return OUT;
			}

			sampler2D _MainTex;

			fixed4 frag(v2f IN) : SV_Target {
				fixed4 tex_color = tex2D(_MainTex, IN.texcoord);
				fixed4 c;
				c.rgb = fixed3(1, 1, 1) - ((fixed3(1, 1, 1) - tex_color.rgb) * (fixed3(1, 1, 1) - IN.color.rgb));
				c.a = tex_color.a * IN.color.a;
				return c;
			}
		ENDCG
		}
	}
}
