static const float4	c_linearize		= float4(1.0/97.0, 1.0/499.0, 1.0/997.0, 1.0/1499.0);
static const float4	c_linearize_xyz	= float4(c_linearize.x, c_linearize.y, 0.0, 0.0);
static const half2	c_time_offset	= half2(10.5, 0.5);

fixed PerlinNoiseRandom(float x) {
	return frac(sin(x) * 43758.5453);
}

fixed PerlinNoise1d(half d) {
	float linear_d = dot((float)floor(d), c_linearize.x);
	fixed2 frac_d = frac(d);

	return lerp(	PerlinNoiseRandom(linear_d)
				,	PerlinNoiseRandom(linear_d + c_linearize_xyz.x)
				,	frac_d.x
				);
}

fixed PerlinNoise2d(half2 d) {
	float linear_d = dot((float2)floor(d), c_linearize.xy);
	fixed2 frac_d = frac(d);

	float4 d1x1y1 = linear_d.xxxx + c_linearize_xyz.wxwx + c_linearize_xyz.wwyy;

	return lerp(lerp(	PerlinNoiseRandom(d1x1y1.x)
					,	PerlinNoiseRandom(d1x1y1.y)
					,	frac_d.x
					)
				, lerp(	PerlinNoiseRandom(d1x1y1.z)
					,	PerlinNoiseRandom(d1x1y1.w)
					,	frac_d.x
					)
				, frac_d.y
				);
}
fixed PerlinNoise1dt(half d, half t) {
	half2 x = half2(d, t);
	half2 y = x + c_time_offset.xy;
	return (-PerlinNoise2d(x) - PerlinNoise2d(y)) * -0.5;
}

fixed PerlinNoise3d(half3 d) {
	float linear_d = dot((float3)floor(d), c_linearize.xyz);
	fixed3 frac_d = frac(d);

	float4 d1x1y1z0 = linear_d.xxxx + c_linearize_xyz.wxwx + c_linearize_xyz.wwyy;
	float4 d1x1y1z1 = d1x1y1z0 + c_linearize.zzzz;

	return lerp(lerp(lerp(	PerlinNoiseRandom(d1x1y1z0.x)
						,	PerlinNoiseRandom(d1x1y1z0.y)
						,	frac_d.x
						)
					, lerp(	PerlinNoiseRandom(d1x1y1z0.z)
						,	PerlinNoiseRandom(d1x1y1z0.w)
						,	frac_d.x
						)
					, frac_d.y
					)
				, lerp(lerp(PerlinNoiseRandom(d1x1y1z1.x)
						,	PerlinNoiseRandom(d1x1y1z1.y)
						,	frac_d.x
						)
					, lerp(	PerlinNoiseRandom(d1x1y1z1.z)
						,	PerlinNoiseRandom(d1x1y1z1.w)
						,	frac_d.x
						)
					, frac_d.y
					)
				, frac_d.z
				);
}
fixed PerlinNoise2dt(half2 d, half t) {
	half3 x = half3(d.x, d.y, t);
	half3 y = x + c_time_offset.xxy;
	return (-PerlinNoise3d(x) - PerlinNoise3d(y)) * -0.5;
}

fixed PerlinNoise4d(half4 d) {
	float linear_d = dot((float4)floor(d), c_linearize.xyzw);
	fixed4 frac_d = frac(d);

	float4 d1x1y1z0w0 = linear_d.xxxx + c_linearize_xyz.wxwx + c_linearize_xyz.wwyy;

	float4 d1x1y1z1w0 = d1x1y1z0w0.xyzw + c_linearize.zzzz;
	float4 d1x1y1z0w1 = d1x1y1z0w0.xyzw + c_linearize.wwww;
	float4 d1x1y1z1w1 = d1x1y1z1w0.xyzw + c_linearize.wwww;

	return lerp(lerp(lerp(lerp(		PerlinNoiseRandom(d1x1y1z0w0.x)
							,		PerlinNoiseRandom(d1x1y1z0w0.y)
							,		frac_d.x
							)
						, lerp(		PerlinNoiseRandom(d1x1y1z0w0.z)
							,		PerlinNoiseRandom(d1x1y1z0w0.w)
							,		frac_d.x
							)
						, frac_d.y
						)
					, lerp(lerp(	PerlinNoiseRandom(d1x1y1z1w0.x)
							,		PerlinNoiseRandom(d1x1y1z1w0.y)
							,		frac_d.x
							)
						, lerp(		PerlinNoiseRandom(d1x1y1z1w0.z)
							,		PerlinNoiseRandom(d1x1y1z1w0.w)
							,		frac_d.x
							)
						, frac_d.y
						)
					, frac_d.z
					)
				, lerp(lerp(lerp(	PerlinNoiseRandom(d1x1y1z0w1.x)
							,		PerlinNoiseRandom(d1x1y1z0w1.y)
							,		frac_d.x
							)
						, lerp(		PerlinNoiseRandom(d1x1y1z0w1.z)
							,		PerlinNoiseRandom(d1x1y1z0w1.w)
							,		frac_d.x
							)
						, frac_d.y
						)
					, lerp(lerp(	PerlinNoiseRandom(d1x1y1z1w1.x)
							,		PerlinNoiseRandom(d1x1y1z1w1.y)
							,		frac_d.x
							)
						, lerp(		PerlinNoiseRandom(d1x1y1z1w1.z)
							,		PerlinNoiseRandom(d1x1y1z1w1.w)
							,		frac_d.x
							)
						, frac_d.y
						)
					, frac_d.z
					)
				, frac_d.w
				);
}
fixed PerlinNoise3dt(half3 d, half t) {
	half4 x = half4(d.x, d.y, d.z, t);
	half4 y = x + c_time_offset.xxxy;
	return (-PerlinNoise4d(x) - PerlinNoise4d(y)) * -0.5;
}
