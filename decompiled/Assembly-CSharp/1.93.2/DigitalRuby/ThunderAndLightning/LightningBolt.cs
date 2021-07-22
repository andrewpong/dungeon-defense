using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200028B RID: 651
	[Token(Token = "0x2000200")]
	public class LightningBolt
	{
		// Token: 0x06000F91 RID: 3985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x3C9A80", Offset = "0x3C9A80", VA = "0x63C9A80")]
		public LightningBolt()
		{
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00006948 File Offset: 0x00004B48
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000124")]
		public float MinimumDelay
		{
			[Token(Token = "0x6000E3A")]
			[Address(RVA = "0x3C9BBC", Offset = "0x3C9BBC", VA = "0x63C9BBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18743C", Offset = "0x18743C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E3B")]
			[Address(RVA = "0x3C9BC4", Offset = "0x3C9BC4", VA = "0x63C9BC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18744C", Offset = "0x18744C")]
			private set
			{
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00006960 File Offset: 0x00004B60
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000125")]
		public bool HasGlow
		{
			[Token(Token = "0x6000E3C")]
			[Address(RVA = "0x3C9BCC", Offset = "0x3C9BCC", VA = "0x63C9BCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18745C", Offset = "0x18745C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E3D")]
			[Address(RVA = "0x3C9BD4", Offset = "0x3C9BD4", VA = "0x63C9BD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18746C", Offset = "0x18746C")]
			private set
			{
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x17000126")]
		public bool IsActive
		{
			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x3C9BDC", Offset = "0x3C9BDC", VA = "0x63C9BDC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00006990 File Offset: 0x00004B90
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000127")]
		public CameraMode CameraMode
		{
			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x3C9BF8", Offset = "0x3C9BF8", VA = "0x63C9BF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18747C", Offset = "0x18747C")]
			get
			{
				return CameraMode.Auto;
			}
			[Token(Token = "0x6000E40")]
			[Address(RVA = "0x3C9C00", Offset = "0x3C9C00", VA = "0x63C9C00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18748C", Offset = "0x18748C")]
			private set
			{
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x000069A8 File Offset: 0x00004BA8
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		public float StartTimeOffset
		{
			[Token(Token = "0x6000E41")]
			[Address(RVA = "0x3C9C08", Offset = "0x3C9C08", VA = "0x63C9C08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18749C", Offset = "0x18749C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E42")]
			[Address(RVA = "0x3C9C10", Offset = "0x3C9C10", VA = "0x63C9C10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1874AC", Offset = "0x1874AC")]
			private set
			{
			}
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x3C9C18", Offset = "0x3C9C18", VA = "0x63C9C18")]
		public void SetupLightningBolt(LightningBoltDependencies dependencies)
		{
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x3CB3E8", Offset = "0x3CB3E8", VA = "0x63CB3E8")]
		public bool Update()
		{
			return default(bool);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x3CB648", Offset = "0x3CB648", VA = "0x63CB648")]
		public void Cleanup(bool willCache)
		{
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x3CC3E4", Offset = "0x3CC3E4", VA = "0x63CC3E4")]
		public LightningBoltSegmentGroup AddGroup()
		{
			return null;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x3CC1E8", Offset = "0x3CC1E8", VA = "0x63CC1E8")]
		private void CleanupLight(Light l, bool returnToCache)
		{
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x3CC56C", Offset = "0x3CC56C", VA = "0x63CC56C")]
		private void EnableLineRenderer(LightningBolt.LineRendererMesh lineRenderer, int tag)
		{
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x3CC654", Offset = "0x3CC654", VA = "0x63CC654")]
		[DebuggerHidden]
		private IEnumerator EnableLastRendererCoRoutine()
		{
			return null;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x3CA26C", Offset = "0x3CA26C", VA = "0x63CA26C")]
		private LightningBolt.LineRendererMesh GetOrCreateLineRenderer()
		{
			return null;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x3CC6D8", Offset = "0x3CC6D8", VA = "0x63CC6D8")]
		private void RenderGroup(LightningBoltSegmentGroup group, LightningBoltParameters p)
		{
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x3CD054", Offset = "0x3CD054", VA = "0x63CD054")]
		private void ProcessParameters(LightningBoltParameters p, RangeOfFloats delay)
		{
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x3CA8AC", Offset = "0x3CA8AC", VA = "0x63CA8AC")]
		private void ProcessAllLightningParameters()
		{
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x3CDA6C", Offset = "0x3CDA6C", VA = "0x63CDA6C")]
		private void EnableCurrentLineRendererFromThread()
		{
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x3CCE80", Offset = "0x3CCE80", VA = "0x63CCE80")]
		private void EnableCurrentLineRenderer()
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x3CDB20", Offset = "0x3CDB20", VA = "0x63CDB20")]
		private void RenderParticleSystems(Vector3 start, Vector3 end, float trunkWidth, float lifeTime, float delaySeconds)
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x3CD298", Offset = "0x3CD298", VA = "0x63CD298")]
		private void RenderLightningBolt(LightningBoltQualitySetting quality, int generations, int startGroupIndex, int endGroupIndex, LightningBoltParameters parameters)
		{
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x3CDE4C", Offset = "0x3CDE4C", VA = "0x63CDE4C")]
		private void CreateLightsForGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, LightningBoltQualitySetting quality, int maxLights)
		{
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x3CE2CC", Offset = "0x3CE2CC", VA = "0x63CE2CC")]
		private bool AddLightToGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, int segmentIndex, int nthLight, int nthShadows, ref int maxLights, ref int nthShadowCounter)
		{
			return default(bool);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x3CE62C", Offset = "0x3CE62C", VA = "0x63CE62C")]
		private Light GetOrCreateLight(LightningLightParameters lp)
		{
			return null;
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x3CEB5C", Offset = "0x3CEB5C", VA = "0x63CEB5C")]
		private void UpdateLight(LightningLightParameters lp, IEnumerable<Light> lights, float delay, float peakStart, float peakEnd, float lifeTime)
		{
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x3CB444", Offset = "0x3CB444", VA = "0x63CB444")]
		private void UpdateLights()
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x3CDD7C", Offset = "0x3CDD7C", VA = "0x63CDD7C")]
		[DebuggerHidden]
		private IEnumerator GenerateParticleCoRoutine(ParticleSystem p, Vector3 pos, float delay)
		{
			return null;
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x3C9E54", Offset = "0x3C9E54", VA = "0x63C9E54")]
		private void CheckForGlow(IEnumerable<LightningBoltParameters> parameters)
		{
		}

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x40006F5")]
		[FieldOffset(Offset = "0x0")]
		public static int MaximumLightCount;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x4")]
		public static int MaximumLightsPerBatch;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181B50", Offset = "0x181B50")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x181B50", Offset = "0x181B50")]
		private float <MinimumDelay>k__BackingField;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181B84", Offset = "0x181B84")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x181B84", Offset = "0x181B84")]
		private bool <HasGlow>k__BackingField;

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181BB8", Offset = "0x181BB8")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x181BB8", Offset = "0x181BB8")]
		private CameraMode <CameraMode>k__BackingField;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181BEC", Offset = "0x181BEC")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x181BEC", Offset = "0x181BEC")]
		private float <StartTimeOffset>k__BackingField;

		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x18")]
		private LightningBoltDependencies dependencies;

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x1C")]
		private float elapsedTime;

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x20")]
		private float lifeTime;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x24")]
		private bool hasLight;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x28")]
		private float timeSinceLevelLoad;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<LightningBoltSegmentGroup> segmentGroups;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<LightningBoltSegmentGroup> segmentGroupsWithLight;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x34")]
		private readonly List<LightningBolt.LineRendererMesh> activeLineRenderers;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<LightningBolt.LineRendererMesh> lineRendererCache;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x8")]
		private static int lightCount;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x3C")]
		private readonly List<LightningBoltSegmentGroup> groupCache;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<Light> lightCache;

		// Token: 0x0200028C RID: 652
		[Token(Token = "0x2000201")]
		public class LineRendererMesh
		{
			// Token: 0x06000FB2 RID: 4018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E5A")]
			[Address(RVA = "0x2DA060", Offset = "0x2DA060", VA = "0x62DA060")]
			public LineRendererMesh()
			{
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000129")]
			public GameObject GameObject
			{
				[Token(Token = "0x6000E5B")]
				[Address(RVA = "0x2DA3E4", Offset = "0x2DA3E4", VA = "0x62DA3E4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1874DC", Offset = "0x1874DC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000E5C")]
				[Address(RVA = "0x2DA3DC", Offset = "0x2DA3DC", VA = "0x62DA3DC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1874EC", Offset = "0x1874EC")]
				private set
				{
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700012A")]
			public Material Material
			{
				[Token(Token = "0x6000E5D")]
				[Address(RVA = "0x2DA3EC", Offset = "0x2DA3EC", VA = "0x62DA3EC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000E5E")]
				[Address(RVA = "0x2DA418", Offset = "0x2DA418", VA = "0x62DA418")]
				set
				{
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700012B")]
			public MeshRenderer MeshRenderer
			{
				[Token(Token = "0x6000E5F")]
				[Address(RVA = "0x2DA44C", Offset = "0x2DA44C", VA = "0x62DA44C")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000069F0 File Offset: 0x00004BF0
			// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700012C")]
			public int Tag
			{
				[Token(Token = "0x6000E60")]
				[Address(RVA = "0x2D9718", Offset = "0x2D9718", VA = "0x62D9718")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1874FC", Offset = "0x1874FC")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000E61")]
				[Address(RVA = "0x2D9720", Offset = "0x2D9720", VA = "0x62D9720")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18750C", Offset = "0x18750C")]
				set
				{
				}
			}

			// Token: 0x06000FBA RID: 4026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E62")]
			[Address(RVA = "0x2DA454", Offset = "0x2DA454", VA = "0x62DA454")]
			public void Cleanup()
			{
			}

			// Token: 0x06000FBB RID: 4027 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E63")]
			[Address(RVA = "0x2DA4DC", Offset = "0x2DA4DC", VA = "0x62DA4DC")]
			public void PopulateMesh()
			{
			}

			// Token: 0x06000FBC RID: 4028 RVA: 0x00006A08 File Offset: 0x00004C08
			[Token(Token = "0x6000E64")]
			[Address(RVA = "0x2DA92C", Offset = "0x2DA92C", VA = "0x62DA92C")]
			public bool PrepareForLines(int lineCount)
			{
				return default(bool);
			}

			// Token: 0x06000FBD RID: 4029 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E65")]
			[Address(RVA = "0x2DA9C0", Offset = "0x2DA9C0", VA = "0x62DA9C0")]
			public void BeginLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			// Token: 0x06000FBE RID: 4030 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x2DB464", Offset = "0x2DB464", VA = "0x62DB464")]
			public void AppendLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			// Token: 0x06000FBF RID: 4031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E67")]
			[Address(RVA = "0x2DB740", Offset = "0x2DB740", VA = "0x62DB740")]
			public void Reset()
			{
			}

			// Token: 0x06000FC0 RID: 4032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E68")]
			[Address(RVA = "0x2DA588", Offset = "0x2DA588", VA = "0x62DA588")]
			private void PopulateMeshInternal()
			{
			}

			// Token: 0x06000FC1 RID: 4033 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E69")]
			[Address(RVA = "0x2DB940", Offset = "0x2DB940", VA = "0x62DB940")]
			private void UpdateBounds(ref Vector3 point1, ref Vector3 point2)
			{
			}

			// Token: 0x06000FC2 RID: 4034 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E6A")]
			[Address(RVA = "0x2DBA38", Offset = "0x2DBA38", VA = "0x62DBA38")]
			private void AddIndices()
			{
			}

			// Token: 0x06000FC3 RID: 4035 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E6B")]
			[Address(RVA = "0x2DAB74", Offset = "0x2DAB74", VA = "0x62DAB74")]
			private void AppendLineInternal(ref Vector3 start, ref Vector3 end, ref Vector4 dir, ref Vector4 dirPrev1, ref Vector4 dirPrev2, Color32 color, float colorIntensity, ref Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			// Token: 0x04000870 RID: 2160
			[Token(Token = "0x4000707")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181C20", Offset = "0x181C20")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x181C20", Offset = "0x181C20")]
			private GameObject <GameObject>k__BackingField;

			// Token: 0x04000871 RID: 2161
			[Token(Token = "0x4000708")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181C54", Offset = "0x181C54")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x181C54", Offset = "0x181C54")]
			private int <Tag>k__BackingField;

			// Token: 0x04000872 RID: 2162
			[Token(Token = "0x4000709")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 uv1;

			// Token: 0x04000873 RID: 2163
			[Token(Token = "0x400070A")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 uv2;

			// Token: 0x04000874 RID: 2164
			[Token(Token = "0x400070B")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Vector2 uv3;

			// Token: 0x04000875 RID: 2165
			[Token(Token = "0x400070C")]
			[FieldOffset(Offset = "0x18")]
			private static readonly Vector2 uv4;

			// Token: 0x04000876 RID: 2166
			[Token(Token = "0x400070D")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<int> indices;

			// Token: 0x04000877 RID: 2167
			[Token(Token = "0x400070E")]
			[FieldOffset(Offset = "0x14")]
			private readonly List<Vector3> vertices;

			// Token: 0x04000878 RID: 2168
			[Token(Token = "0x400070F")]
			[FieldOffset(Offset = "0x18")]
			private readonly List<Vector4> lineDirs;

			// Token: 0x04000879 RID: 2169
			[Token(Token = "0x4000710")]
			[FieldOffset(Offset = "0x1C")]
			private readonly List<Color32> colors;

			// Token: 0x0400087A RID: 2170
			[Token(Token = "0x4000711")]
			[FieldOffset(Offset = "0x20")]
			private readonly List<Vector3> ends;

			// Token: 0x0400087B RID: 2171
			[Token(Token = "0x4000712")]
			[FieldOffset(Offset = "0x24")]
			private readonly List<Vector4> texCoordsAndGlowModifiers;

			// Token: 0x0400087C RID: 2172
			[Token(Token = "0x4000713")]
			[FieldOffset(Offset = "0x28")]
			private readonly List<Vector4> fadeLifetimes;

			// Token: 0x0400087D RID: 2173
			[Token(Token = "0x4000714")]
			private const int boundsPadder = 1000000000;

			// Token: 0x0400087E RID: 2174
			[Token(Token = "0x4000715")]
			[FieldOffset(Offset = "0x2C")]
			private int currentBoundsMinX;

			// Token: 0x0400087F RID: 2175
			[Token(Token = "0x4000716")]
			[FieldOffset(Offset = "0x30")]
			private int currentBoundsMinY;

			// Token: 0x04000880 RID: 2176
			[Token(Token = "0x4000717")]
			[FieldOffset(Offset = "0x34")]
			private int currentBoundsMinZ;

			// Token: 0x04000881 RID: 2177
			[Token(Token = "0x4000718")]
			[FieldOffset(Offset = "0x38")]
			private int currentBoundsMaxX;

			// Token: 0x04000882 RID: 2178
			[Token(Token = "0x4000719")]
			[FieldOffset(Offset = "0x3C")]
			private int currentBoundsMaxY;

			// Token: 0x04000883 RID: 2179
			[Token(Token = "0x400071A")]
			[FieldOffset(Offset = "0x40")]
			private int currentBoundsMaxZ;

			// Token: 0x04000884 RID: 2180
			[Token(Token = "0x400071B")]
			[FieldOffset(Offset = "0x44")]
			private Mesh mesh;

			// Token: 0x04000885 RID: 2181
			[Token(Token = "0x400071C")]
			[FieldOffset(Offset = "0x48")]
			private MeshFilter meshFilter;

			// Token: 0x04000886 RID: 2182
			[Token(Token = "0x400071D")]
			[FieldOffset(Offset = "0x4C")]
			private MeshRenderer meshRenderer;
		}

		// Token: 0x0200028D RID: 653
		[Token(Token = "0x2000340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD70", Offset = "0x17FD70")]
		private sealed class <EnableLastRendererCoRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000FC5 RID: 4037 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001598")]
			[Address(RVA = "0x2D9520", Offset = "0x2D9520", VA = "0x62D9520")]
			[DebuggerHidden]
			public <EnableLastRendererCoRoutine>c__Iterator0()
			{
			}

			// Token: 0x06000FC6 RID: 4038 RVA: 0x00006A20 File Offset: 0x00004C20
			[Token(Token = "0x6001599")]
			[Address(RVA = "0x2D9528", Offset = "0x2D9528", VA = "0x62D9528", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001B7")]
			private object Current
			{
				[Token(Token = "0x600159A")]
				[Address(RVA = "0x2D9728", Offset = "0x2D9728", VA = "0x62D9728", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001B8")]
			private object Current
			{
				[Token(Token = "0x600159B")]
				[Address(RVA = "0x2D9730", Offset = "0x2D9730", VA = "0x62D9730", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000FC9 RID: 4041 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600159C")]
			[Address(RVA = "0x2D9738", Offset = "0x2D9738", VA = "0x62D9738", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000FCA RID: 4042 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600159D")]
			[Address(RVA = "0x2D974C", Offset = "0x2D974C", VA = "0x62D974C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000887 RID: 2183
			[Token(Token = "0x400142B")]
			[FieldOffset(Offset = "0x8")]
			internal LightningBolt.LineRendererMesh <lineRenderer>__0;

			// Token: 0x04000888 RID: 2184
			[Token(Token = "0x400142C")]
			[FieldOffset(Offset = "0xC")]
			internal int <tag>__0;

			// Token: 0x04000889 RID: 2185
			[Token(Token = "0x400142D")]
			[FieldOffset(Offset = "0x10")]
			internal LightningBolt $this;

			// Token: 0x0400088A RID: 2186
			[Token(Token = "0x400142E")]
			[FieldOffset(Offset = "0x14")]
			internal object $current;

			// Token: 0x0400088B RID: 2187
			[Token(Token = "0x400142F")]
			[FieldOffset(Offset = "0x18")]
			internal bool $disposing;

			// Token: 0x0400088C RID: 2188
			[Token(Token = "0x4001430")]
			[FieldOffset(Offset = "0x1C")]
			internal int $PC;
		}

		// Token: 0x0200028E RID: 654
		[Token(Token = "0x2000341")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD80", Offset = "0x17FD80")]
		private sealed class <RenderGroup>c__AnonStorey2
		{
			// Token: 0x06000FCB RID: 4043 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600159E")]
			[Address(RVA = "0x2D9BC4", Offset = "0x2D9BC4", VA = "0x62D9BC4")]
			public <RenderGroup>c__AnonStorey2()
			{
			}

			// Token: 0x06000FCC RID: 4044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600159F")]
			[Address(RVA = "0x2D9BCC", Offset = "0x2D9BCC", VA = "0x62D9BCC")]
			internal void <>m__0()
			{
			}

			// Token: 0x0400088D RID: 2189
			[Token(Token = "0x4001431")]
			[FieldOffset(Offset = "0x8")]
			internal LightningBolt.LineRendererMesh currentLineRenderer;

			// Token: 0x0400088E RID: 2190
			[Token(Token = "0x4001432")]
			[FieldOffset(Offset = "0xC")]
			internal LightningBolt $this;
		}

		// Token: 0x0200028F RID: 655
		[Token(Token = "0x2000342")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD90", Offset = "0x17FD90")]
		private sealed class <RenderLightningBolt>c__AnonStorey3
		{
			// Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015A0")]
			[Address(RVA = "0x2D9C20", Offset = "0x2D9C20", VA = "0x62D9C20")]
			public <RenderLightningBolt>c__AnonStorey3()
			{
			}

			// Token: 0x06000FCE RID: 4046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015A1")]
			[Address(RVA = "0x2D9C28", Offset = "0x2D9C28", VA = "0x62D9C28")]
			internal void <>m__0()
			{
			}

			// Token: 0x0400088F RID: 2191
			[Token(Token = "0x4001433")]
			[FieldOffset(Offset = "0x8")]
			internal Vector3 start;

			// Token: 0x04000890 RID: 2192
			[Token(Token = "0x4001434")]
			[FieldOffset(Offset = "0x14")]
			internal Vector3 end;

			// Token: 0x04000891 RID: 2193
			[Token(Token = "0x4001435")]
			[FieldOffset(Offset = "0x20")]
			internal LightningBoltParameters parameters;

			// Token: 0x04000892 RID: 2194
			[Token(Token = "0x4001436")]
			[FieldOffset(Offset = "0x24")]
			internal LightningLightParameters lp;

			// Token: 0x04000893 RID: 2195
			[Token(Token = "0x4001437")]
			[FieldOffset(Offset = "0x28")]
			internal int startGroupIndex;

			// Token: 0x04000894 RID: 2196
			[Token(Token = "0x4001438")]
			[FieldOffset(Offset = "0x2C")]
			internal LightningBoltQualitySetting quality;

			// Token: 0x04000895 RID: 2197
			[Token(Token = "0x4001439")]
			[FieldOffset(Offset = "0x30")]
			internal LightningBolt $this;
		}

		// Token: 0x02000290 RID: 656
		[Token(Token = "0x2000343")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FDA0", Offset = "0x17FDA0")]
		private sealed class <GenerateParticleCoRoutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000FCF RID: 4047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015A2")]
			[Address(RVA = "0x2D97D4", Offset = "0x2D97D4", VA = "0x62D97D4")]
			[DebuggerHidden]
			public <GenerateParticleCoRoutine>c__Iterator1()
			{
			}

			// Token: 0x06000FD0 RID: 4048 RVA: 0x00006A38 File Offset: 0x00004C38
			[Token(Token = "0x60015A3")]
			[Address(RVA = "0x2D97DC", Offset = "0x2D97DC", VA = "0x62D97DC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001B9")]
			private object Current
			{
				[Token(Token = "0x60015A4")]
				[Address(RVA = "0x2D9B18", Offset = "0x2D9B18", VA = "0x62D9B18", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001BA")]
			private object Current
			{
				[Token(Token = "0x60015A5")]
				[Address(RVA = "0x2D9B20", Offset = "0x2D9B20", VA = "0x62D9B20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000FD3 RID: 4051 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015A6")]
			[Address(RVA = "0x2D9B28", Offset = "0x2D9B28", VA = "0x62D9B28", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000FD4 RID: 4052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015A7")]
			[Address(RVA = "0x2D9B3C", Offset = "0x2D9B3C", VA = "0x62D9B3C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000896 RID: 2198
			[Token(Token = "0x400143A")]
			[FieldOffset(Offset = "0x8")]
			internal float delay;

			// Token: 0x04000897 RID: 2199
			[Token(Token = "0x400143B")]
			[FieldOffset(Offset = "0xC")]
			internal Vector3 pos;

			// Token: 0x04000898 RID: 2200
			[Token(Token = "0x400143C")]
			[FieldOffset(Offset = "0x18")]
			internal ParticleSystem p;

			// Token: 0x04000899 RID: 2201
			[Token(Token = "0x400143D")]
			[FieldOffset(Offset = "0x1C")]
			internal int <count>__1;

			// Token: 0x0400089A RID: 2202
			[Token(Token = "0x400143E")]
			[FieldOffset(Offset = "0x20")]
			internal object $current;

			// Token: 0x0400089B RID: 2203
			[Token(Token = "0x400143F")]
			[FieldOffset(Offset = "0x24")]
			internal bool $disposing;

			// Token: 0x0400089C RID: 2204
			[Token(Token = "0x4001440")]
			[FieldOffset(Offset = "0x28")]
			internal int $PC;
		}
	}
}
