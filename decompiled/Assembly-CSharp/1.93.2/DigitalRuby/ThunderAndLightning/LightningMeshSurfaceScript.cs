using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002AE RID: 686
	[Token(Token = "0x200021F")]
	public class LightningMeshSurfaceScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x2E43E8", Offset = "0x2E43E8", VA = "0x62E43E8")]
		public LightningMeshSurfaceScript()
		{
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x2E44A4", Offset = "0x2E44A4", VA = "0x62E44A4")]
		private void CheckMesh()
		{
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x2E46FC", Offset = "0x2E46FC", VA = "0x62E46FC", Slot = "8")]
		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x2E47A8", Offset = "0x2E47A8", VA = "0x62E47A8", Slot = "10")]
		protected virtual void PopulateSourcePoints(List<Vector3> points)
		{
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x2E47B8", Offset = "0x2E47B8", VA = "0x62E47B8")]
		public void CreateRandomLightningPath(List<Vector3> points)
		{
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x2E53B8", Offset = "0x2E53B8", VA = "0x62E53B8", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x2E53BC", Offset = "0x2E53BC", VA = "0x62E53BC", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x2E53D8", Offset = "0x2E53D8", VA = "0x62E53D8", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x18368C", Offset = "0x18368C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18368C", Offset = "0x18368C")]
		public MeshFilter MeshFilter;

		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0x134")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183700", Offset = "0x183700")]
		public Collider MeshCollider;

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "SingleLineAttribute", RVA = "0x183734", Offset = "0x183734")]
		public RangeOfFloats MeshOffsetRange;

		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x140")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x183768", Offset = "0x183768")]
		[Attribute(Name = "SingleLineAttribute", RVA = "0x183768", Offset = "0x183768")]
		public RangeOfIntegers PathLengthCount;

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "SingleLineAttribute", RVA = "0x1837E8", Offset = "0x1837E8")]
		public RangeOfFloats MinimumPathDistanceRange;

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183854", Offset = "0x183854")]
		public float MaximumPathDistance;

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x154")]
		private float maximumPathDistanceSquared;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x158")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183888", Offset = "0x183888")]
		public bool Spline;

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0x15C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1838BC", Offset = "0x1838BC")]
		public float DistancePerSegmentHint;

		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x160")]
		private readonly List<Vector3> sourcePoints;

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x164")]
		private Mesh previousMesh;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x168")]
		private MeshHelper meshHelper;
	}
}
