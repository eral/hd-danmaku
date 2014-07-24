float Random(float x) {
	return frac(sin(x) * 43758.5453);
}

float PerlinNoise1d(float d) {
	float2 linearize = float(1.0/97.0);
	float linear_d = dot(floor(d), linearize);
	float2 frac_d = frac(d);

	return lerp(	Random(linear_d)
				,	Random(linear_d + linearize.x)
				,	frac_d.x
				);
}

float PerlinNoise2d(float2 d) {
	float2 linearize = float2(1.0/97.0, 1.0/499.0);
	float linear_d = dot(floor(d), linearize);
	float2 frac_d = frac(d);

	return lerp(lerp(	Random(linear_d)
					,	Random(linear_d + linearize.x)
					,	frac_d.x
					)
				, lerp(	Random(linear_d + linearize.y)
					,	Random(linear_d + linearize.y + linearize.x)
					,	frac_d.x
					)
				, frac_d.y
				);
}
float PerlinNoise1dt(float d, float t) {
	float2 x = float2(d, t);
	float2 y = x + float2(10.5, 0.5);
	return PerlinNoise2d(x) * 0.5 + PerlinNoise2d(y) * 0.5;
}

float PerlinNoise3d(float3 d) {
	float3 linearize = float3(1.0/97.0, 1.0/499.0, 1.0/997.0);
	float linear_d = dot(floor(d), linearize);
	float3 frac_d = frac(d);

	return lerp(lerp(lerp(	Random(linear_d)
						,	Random(linear_d + linearize.x)
						,	frac_d.x
						)
					, lerp(	Random(linear_d + linearize.y)
						,	Random(linear_d + linearize.y + linearize.x)
						,	frac_d.x
						)
					, frac_d.y
					)
				, lerp(lerp(Random(linear_d + linearize.z)
						,	Random(linear_d + linearize.z + linearize.x)
						,	frac_d.x
						)
					, lerp(	Random(linear_d + linearize.z + linearize.y)
						,	Random(linear_d + linearize.z + linearize.y + linearize.x)
						,	frac_d.x
						)
					, frac_d.y
					)
				, frac_d.z
				);
}
float PerlinNoise2dt(float2 d, float t) {
	float3 x = float3(d.x, d.y, t);
	float3 y = x + float3(10.5, 10.5, 0.5);
	return PerlinNoise3d(x) * 0.5 + PerlinNoise3d(y) * 0.5;
}

float PerlinNoise4d(float4 d) {
	float4 linearize = float4(1.0/97.0, 1.0/499.0, 1.0/997.0, 1.0/1499.0);
	float linear_d = dot(floor(d), linearize);
	float4 frac_d = frac(d);

	return lerp(lerp(lerp(lerp(		Random(linear_d)
							,		Random(linear_d + linearize.x)
							,		frac_d.x
							)
						, lerp(		Random(linear_d + linearize.y)
							,		Random(linear_d + linearize.y + linearize.x)
							,		frac_d.x
							)
						, frac_d.y
						)
					, lerp(lerp(	Random(linear_d + linearize.z)
							,		Random(linear_d + linearize.z + linearize.x)
							,		frac_d.x
							)
						, lerp(		Random(linear_d + linearize.z + linearize.y)
							,		Random(linear_d + linearize.z + linearize.y + linearize.x)
							,		frac_d.x
							)
						, frac_d.y
						)
					, frac_d.z
					)
				, lerp(lerp(lerp(	Random(linear_d + linearize.w)
							,		Random(linear_d + linearize.w + linearize.x)
							,		frac_d.x
							)
						, lerp(		Random(linear_d + linearize.w + linearize.y)
							,		Random(linear_d + linearize.w + linearize.y + linearize.x)
							,		frac_d.x
							)
						, frac_d.y
						)
					, lerp(lerp(	Random(linear_d + linearize.w + linearize.z)
							,		Random(linear_d + linearize.w + linearize.z + linearize.x)
							,		frac_d.x
							)
						, lerp(		Random(linear_d + linearize.w + linearize.z + linearize.y)
							,		Random(linear_d + linearize.w + linearize.z + linearize.y + linearize.x)
							,		frac_d.x
							)
						, frac_d.y
						)
					, frac_d.z
					)
				, frac_d.w
				);
}
float PerlinNoise3dt(float3 d, float t) {
	float4 x = float4(d.x, d.y, d.z, t);
	float4 y = x + float4(10.5, 10.5, 10.5, 0.5);
	return PerlinNoise4d(x) * 0.5 + PerlinNoise4d(y) * 0.5;
}

