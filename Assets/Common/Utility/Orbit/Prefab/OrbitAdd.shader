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
		Blend SrcAlpha One

		Pass {
		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile DUMMY PIXELSNAP_ON
			#include "UnityCG.cginc"
			
			struct appdata_t {
				float4 vertex	: POSITION;	//常に0.0
				float4 tangent	: TANGENT;
				//符号部をSign、指数部をExponent、仮数部をFfractionとした場合、IEEE754のfloatはS1E8F23の形式を取る
				//S1E8には全く情報を乗せずに、F23だけを使い複数の情報をパックする
				//xy:頂点・UVパック: 頂点座標11bit(-1024～1023の領域を0～2047として扱う)、UV11bit(0.0～1.0の領域を0.0～0.5として扱う)、空き1bit
				//zw:カラー2ch: カラー(1ch)11bit(0.0～1.0の領域を0.0～0.5として扱う)、カラー(1ch)11bit(0.0～1.0の領域を0.0～0.5として扱う)、空き1bit
			};

			struct v2f {
				float4 vertex	: SV_POSITION;
				fixed4 color	: COLOR;
				half2 texcoord	: TEXCOORD0;
			};

			float VertexValue(float f) {
				return floor(frac(f) * 2048.0) - 1024.0;
			}
			float2 VertexValue(float2 f) {
				return floor(frac(f) * 2048.0) - 1024.0;
			}
			float UvValue(float f) {
				return floor(frac(f * 2048.0) * 2048.0) / 2048.0f * 2.0;
			}
			float2 UvValue(float2 f) {
				return floor(frac(f * 2048.0) * 2048.0) / 2048.0f * 2.0;
			}

			float ColorHighValue(float f) {
				return floor(frac(f) * 2048.0) / 2048.0f * 2.0;
			}
			float2 ColorHighValue(float2 f) {
				return floor(frac(f) * 2048.0) / 2048.0f * 2.0;
			}
			float ColorLowValue(float f) {
				return floor(frac(f * 2048.0) * 2048.0) / 2048.0f * 2.0;
			}
			float2 ColorLowValue(float2 f) {
				return floor(frac(f * 2048.0) * 2048.0) / 2048.0f * 2.0;
			}

			v2f vert(appdata_t IN) {
				v2f OUT;
				float4 vertex;
				vertex.xy = VertexValue(IN.tangent.xy);
				vertex.zw = float2(0.0, 1.0);
				OUT.vertex = mul(UNITY_MATRIX_MVP, vertex);
				OUT.texcoord.xy = UvValue(IN.tangent.xy);
				OUT.color.rg = ColorHighValue(IN.tangent.zw);
				OUT.color.ba = ColorLowValue(IN.tangent.zw);
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
