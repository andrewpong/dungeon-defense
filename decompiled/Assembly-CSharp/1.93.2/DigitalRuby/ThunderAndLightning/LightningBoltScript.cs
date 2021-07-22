using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000296 RID: 662
	[Token(Token = "0x2000207")]
	public class LightningBoltScript : MonoBehaviour
	{
		// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x2DD900", Offset = "0x2DD900", VA = "0x62DD900")]
		public LightningBoltScript()
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		public Action<Light> LightAddedCallback
		{
			[Token(Token = "0x6000E86")]
			[Address(RVA = "0x2DE63C", Offset = "0x2DE63C", VA = "0x62DE63C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18751C", Offset = "0x18751C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E87")]
			[Address(RVA = "0x2DE644", Offset = "0x2DE644", VA = "0x62DE644")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18752C", Offset = "0x18752C")]
			set
			{
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012E")]
		public Action<Light> LightRemovedCallback
		{
			[Token(Token = "0x6000E88")]
			[Address(RVA = "0x2DE64C", Offset = "0x2DE64C", VA = "0x62DE64C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18753C", Offset = "0x18753C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E89")]
			[Address(RVA = "0x2DE654", Offset = "0x2DE654", VA = "0x62DE654")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18754C", Offset = "0x18754C")]
			set
			{
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x1700012F")]
		public bool HasActiveBolts
		{
			[Token(Token = "0x6000E8A")]
			[Address(RVA = "0x2DE65C", Offset = "0x2DE65C", VA = "0x62DE65C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x2DE6DC", Offset = "0x2DE6DC", VA = "0x62DE6DC", Slot = "4")]
		public virtual void CreateLightningBolt(LightningBoltParameters p)
		{
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x2DDF18", Offset = "0x2DDF18", VA = "0x62DDF18")]
		public void CreateLightningBolts(ICollection<LightningBoltParameters> parameters)
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x2DEF08", Offset = "0x2DEF08", VA = "0x62DEF08", Slot = "5")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x2DE348", Offset = "0x2DE348", VA = "0x62DE348", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x2DE588", Offset = "0x2DE588", VA = "0x62DE588", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x2DD628", Offset = "0x2DD628", VA = "0x62DD628", Slot = "8")]
		protected virtual LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x2DDDD4", Offset = "0x2DDDD4", VA = "0x62DDDD4")]
		protected LightningBoltParameters CreateParameters()
		{
			return null;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x2DE26C", Offset = "0x2DE26C", VA = "0x62DE26C", Slot = "9")]
		protected virtual void PopulateParameters(LightningBoltParameters p)
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000130")]
		internal Material lightningMaterialMeshInternal
		{
			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x2E0104", Offset = "0x2E0104", VA = "0x62E0104")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18755C", Offset = "0x18755C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x2E010C", Offset = "0x2E010C", VA = "0x62E010C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18756C", Offset = "0x18756C")]
			private set
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000FFE RID: 4094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000131")]
		internal Material lightningMaterialMeshNoGlowInternal
		{
			[Token(Token = "0x6000E95")]
			[Address(RVA = "0x2E0114", Offset = "0x2E0114", VA = "0x62E0114")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18757C", Offset = "0x18757C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E96")]
			[Address(RVA = "0x2E011C", Offset = "0x2E011C", VA = "0x62E011C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18758C", Offset = "0x18758C")]
			private set
			{
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x2DEACC", Offset = "0x2DEACC", VA = "0x62DEACC")]
		private LightningBoltDependencies CreateLightningBoltDependencies(ICollection<LightningBoltParameters> parameters)
		{
			return null;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x2E0124", Offset = "0x2E0124", VA = "0x62E0124")]
		private void ReturnLightningDependenciesToCache(LightningBoltDependencies d)
		{
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x2E0218", Offset = "0x2E0218", VA = "0x62E0218")]
		internal void OnLightAdded(Light l)
		{
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x2E028C", Offset = "0x2E028C", VA = "0x62E028C")]
		internal void OnLightRemoved(Light l)
		{
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x2E0300", Offset = "0x2E0300", VA = "0x62E0300")]
		internal void AddActiveBolt(LightningBolt bolt)
		{
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x2E0380", Offset = "0x2E0380", VA = "0x62E0380")]
		private void UpdateMainThreadActions()
		{
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x2DEF0C", Offset = "0x2DEF0C", VA = "0x62DEF0C")]
		private void UpdateShaderIds()
		{
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x2DF254", Offset = "0x2DF254", VA = "0x62DF254")]
		private void UpdateMaterialsForLastTexture()
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x2DE798", Offset = "0x2DE798", VA = "0x62DE798")]
		private void UpdateTexture()
		{
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x2E06E4", Offset = "0x2E06E4", VA = "0x62E06E4")]
		private void SetMaterialPerspective()
		{
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x2E0864", Offset = "0x2E0864", VA = "0x62E0864")]
		private void SetMaterialOrthographicXY()
		{
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x2E09E4", Offset = "0x2E09E4", VA = "0x62E09E4")]
		private void SetMaterialOrthographicXZ()
		{
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x2E05E8", Offset = "0x2E05E8", VA = "0x62E05E8")]
		private void SetupMaterialCamera()
		{
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x2E0B64", Offset = "0x2E0B64", VA = "0x62E0B64")]
		private void EnableKeyword(string keyword, bool enable, Material m)
		{
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x2DF4C0", Offset = "0x2DF4C0", VA = "0x62DF4C0")]
		private void UpdateShaderParameters()
		{
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x2DFB64", Offset = "0x2DFB64", VA = "0x62DFB64")]
		private void CheckCompensateForParentTransform()
		{
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x2DF150", Offset = "0x2DF150", VA = "0x62DF150")]
		private void UpdateCamera()
		{
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x2DE930", Offset = "0x2DE930", VA = "0x62DE930")]
		private LightningBolt GetOrCreateLightningBolt()
		{
			return null;
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x2DFF94", Offset = "0x2DFF94", VA = "0x62DFF94")]
		private void UpdateActiveBolts()
		{
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x2E0BAC", Offset = "0x2E0BAC", VA = "0x62E0BAC")]
		private void OnDestroy()
		{
		}

		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x182890", Offset = "0x182890")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182890", Offset = "0x182890")]
		public Camera Camera;

		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182908", Offset = "0x182908")]
		public CameraMode CameraMode;

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x14")]
		internal CameraMode calculatedCameraMode;

		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18293C", Offset = "0x18293C")]
		public bool UseWorldSpace;

		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182970", Offset = "0x182970")]
		public bool CompensateForParentTransform;

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1829A4", Offset = "0x1829A4")]
		public LightningBoltQualitySetting QualitySetting;

		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1829D8", Offset = "0x1829D8")]
		public bool MultiThreaded;

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182A0C", Offset = "0x182A0C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x182A0C", Offset = "0x182A0C")]
		public float SoftParticlesFactor;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x182A64", Offset = "0x182A64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182A64", Offset = "0x182A64")]
		public int RenderQueue;

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x4000752")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "HideInInspector", RVA = "0x182B08", Offset = "0x182B08")]
		public string SortLayerName;

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HideInInspector", RVA = "0x182B18", Offset = "0x182B18")]
		public int SortOrderInLayer;

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182B28", Offset = "0x182B28")]
		public Material LightningMaterialMesh;

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182B7C", Offset = "0x182B7C")]
		public Material LightningMaterialMeshNoGlow;

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182BDC", Offset = "0x182BDC")]
		public Texture2D LightningTexture;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182C10", Offset = "0x182C10")]
		public Texture2D LightningGlowTexture;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182C44", Offset = "0x182C44")]
		public ParticleSystem LightningOriginParticleSystem;

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182C78", Offset = "0x182C78")]
		public ParticleSystem LightningDestinationParticleSystem;

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182CAC", Offset = "0x182CAC")]
		public Color LightningTintColor;

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182CF8", Offset = "0x182CF8")]
		public Color GlowTintColor;

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x400075C")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182D48", Offset = "0x182D48")]
		public BlendMode SourceBlendMode;

		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182D9C", Offset = "0x182D9C")]
		public BlendMode DestinationBlendMode;

		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x182DD0", Offset = "0x182DD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182DD0", Offset = "0x182DD0")]
		public float JitterMultiplier;

		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182E48", Offset = "0x182E48")]
		public float Turbulence;

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182E7C", Offset = "0x182E7C")]
		public Vector3 TurbulenceVelocity;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x182ED4", Offset = "0x182ED4")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x182ED4", Offset = "0x182ED4")]
		private Action<Light> <LightAddedCallback>k__BackingField;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x4000762")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x182F08", Offset = "0x182F08")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x182F08", Offset = "0x182F08")]
		private Action<Light> <LightRemovedCallback>k__BackingField;

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x182F3C", Offset = "0x182F3C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x182F3C", Offset = "0x182F3C")]
		private Material <lightningMaterialMeshInternal>k__BackingField;

		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x182F70", Offset = "0x182F70")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x182F70", Offset = "0x182F70")]
		private Material <lightningMaterialMeshNoGlowInternal>k__BackingField;

		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x98")]
		private Texture2D lastLightningTexture;

		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x9C")]
		private Texture2D lastLightningGlowTexture;

		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0xA0")]
		private readonly List<LightningBolt> activeBolts;

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0xA4")]
		private readonly LightningBoltParameters[] oneParameterArray;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0xA8")]
		private readonly List<LightningBolt> lightningBoltCache;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0xAC")]
		private readonly List<LightningBoltDependencies> dependenciesCache;

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0xB0")]
		private LightningThreadState threadState;

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x0")]
		private static int shaderId_MainTex;

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x4")]
		private static int shaderId_GlowTex;

		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x8")]
		private static int shaderId_TintColor;

		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0xC")]
		private static int shaderId_GlowTintColor;

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x10")]
		private static int shaderId_JitterMultiplier;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x14")]
		private static int shaderId_Turbulence;

		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x18")]
		private static int shaderId_TurbulenceVelocity;

		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x1C")]
		private static int shaderId_SrcBlendMode;

		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x20")]
		private static int shaderId_DstBlendMode;

		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x24")]
		private static int shaderId_InvFade;
	}
}
