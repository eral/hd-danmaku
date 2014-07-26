Shader "Custom/BgNoise" {
	Properties {
		Tiling ("Tiling", Vector) = (1, 1, 1, 0)
		LightColor ("LightColor", Color) = (1,1,1,1)
		DarkColor ("DarkColor", Color) = (0,0,0,1)
	}
	SubShader {
		Tags { "RenderType"="Background" }
		LOD 200
		
		Cull Off
		Lighting Off
		ZWrite Off
		ZTest Always
		AlphaTest Off
		Fog { Mode Off }
		Blend One Zero

		Pass {
		CGPROGRAM
			#pragma target 3.0
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile DUMMY PIXELSNAP_ON
			#include "UnityCG.cginc"
			#include "./PerlinNoiseFast.cginc"
			
			struct appdata_t {
				float4 vertex	: POSITION;
				float2 texcoord	: TEXCOORD0;
			};

			struct v2f {
				float4 vertex	: SV_POSITION;
				half2 texcoord	: TEXCOORD0;
			};
			
			float4 Tiling;
			fixed4 LightColor;
			fixed4 DarkColor;

			v2f vert(appdata_t IN) {
				v2f OUT;
				OUT.vertex = mul(UNITY_MATRIX_MVP, IN.vertex);
				OUT.texcoord = IN.texcoord * Tiling.xy;
				#ifdef PIXELSNAP_ON
				OUT.vertex = UnityPixelSnap (OUT.vertex);
				#endif

				return OUT;
			}

			fixed4 frag(v2f IN) : SV_Target {
				float noise_value = 0.0;
				noise_value = PerlinNoise2dt(float2(IN.texcoord.x, IN.texcoord.y), _Time.y * Tiling.z);
				fixed4 c = lerp(DarkColor, LightColor, noise_value);
				return c;
			}
		ENDCG
		}
	} 
	FallBack "Diffuse"
}
