uniform sampler2D PerlinNoiseSeed;

float Fade(float t) {
	return t * t * t * (t * (t * 6.0 - 15.0) + 10.0);
}

float Grad2d(float hash, float x, float y) {
	float h = fmod(hash, 16.0);
	float u = ((h < 8.0)? x: y);
	float v = ((h < 4.0)? y: x);
	float a = ((0.0 == fmod(h, 2.0))? u: -u);
	float b = ((0.0 == fmod(h / 2.0, 2.0))? v: -v);
	return a + b;
}

float Grad3d(float hash, float x, float y, float z) {
	float h = fmod(hash, 16.0);
	float u = ((h < 8.0)? x: y);
	float v = ((h < 4.0)? y: (((12.0 == h) || (14.0 == h)))? x: z);
	float a = ((0.0 == fmod(h, 2.0))? u: -u);
	float b = ((0.0 == fmod(h / 2.0, 2.0))? v: -v);
	return a + b;
}

float Permutation(float d) {
	d = floor(d);	
	float2 t = float2(fmod(d, 16.0)
					, floor(d / 16.0)
					) / 15.0;
	return floor(tex2D(PerlinNoiseSeed,t).r * 255.0);
}

float PerlinNoise2d(float2 IN) {
	float X = fmod(IN.x, 256.0);
	float Y = fmod(IN.y, 256.0);
	
	float x = IN.x - floor(IN.x);
	float y = IN.y - floor(IN.y);
	
	float u = Fade(x);
	float v = Fade(y);
	
	float A		= Permutation(X) + Y;
	float AA	= Permutation(A);
	float AB	= Permutation(A + 1); 	
	float B		= Permutation(X + 1) + Y;
	float BA	= Permutation(B);
	float BB	= Permutation(B + 1);
	
	return lerp(lerp(	Grad2d(Permutation(AA),	x,		y	)
					,	Grad2d(Permutation(BA),	x - 1,	y	)
					,	u
					)
				, lerp(	Grad2d(Permutation(AB),	x,		y - 1)
					,	Grad2d(Permutation(BB),	x - 1,	y - 1)
					,	u
					)
				, v
				);
}

float PerlinNoise3d(float3 IN) {
	float X = fmod(IN.x, 256.0);
	float Y = fmod(IN.y, 256.0);
	float Z = fmod(IN.z, 256.0);
	
	float x = IN.x - floor(IN.x);
	float y = IN.y - floor(IN.y);
	float z = IN.z - floor(IN.z);
	
	float u = Fade(x);
	float v = Fade(y);
	float w = Fade(z);
	
	float A		= Permutation(X) + Y;
	float AA	= Permutation(A) + Z;
	float AB	= Permutation(A + 1) + Z;
	float B		= Permutation(X + 1) + Y;
	float BA	= Permutation(B) + Z;
	float BB	= Permutation(B + 1) + Z;
	
	return lerp(lerp(lerp(	Grad3d(Permutation(AA),		x,		y,		z	)
						,	Grad3d(Permutation(BA),		x - 1,	y,		z	)
						,	u
						)
					, lerp(	Grad3d(Permutation(AB),		x,		y - 1,	z	)
						,	Grad3d(Permutation(BB),		x - 1,	y - 1,	z	)
						,	u
						)
					, v
					)
				, lerp(lerp(Grad3d(Permutation(AA+1),	x,		y,		z - 1)
						,	Grad3d(Permutation(BA+1),	x - 1,	y,		z - 1)
						,	u
						)
					, lerp(	Grad3d(Permutation(AB+1),	x,		y - 1,	z - 1)
						,	Grad3d(Permutation(BB+1),	x - 1,	y - 1,	z - 1)
						,	u
						)
					, v
					)
				, w
				);
}
