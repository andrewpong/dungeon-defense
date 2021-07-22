using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002AF RID: 687
	[Token(Token = "0x2000220")]
	public class LightningSplineScript : LightningBoltPathScriptBase
	{
		// Token: 0x06001056 RID: 4182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x2E78D0", Offset = "0x2E78D0", VA = "0x62E78D0")]
		public LightningSplineScript()
		{
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x2E7A30", Offset = "0x2E7A30", VA = "0x62E7A30")]
		private bool SourceChanged()
		{
			return default(bool);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x2E7BFC", Offset = "0x2E7BFC", VA = "0x62E7BFC", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x2E7C00", Offset = "0x2E7C00", VA = "0x62E7C00", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x2E7C04", Offset = "0x2E7C04", VA = "0x62E7C04", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x2E82E8", Offset = "0x2E82E8", VA = "0x62E82E8", Slot = "8")]
		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x2E83C0", Offset = "0x2E83C0", VA = "0x62E83C0")]
		public void Trigger(List<Vector3> points, bool spline)
		{
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x2E571C", Offset = "0x2E571C", VA = "0x62E571C")]
		public static void PopulateSpline(List<Vector3> splinePoints, List<Vector3> sourcePoints, int generations, float distancePerSegmentHit, Camera camera)
		{
		}

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x40007A2")]
		public const int MaxSplineGenerations = 5;

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1838F0", Offset = "0x1838F0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1838F0", Offset = "0x1838F0")]
		public float DistancePerSegmentHint;

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x13C")]
		private readonly List<Vector3> prevSourcePoints;

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x140")]
		private readonly List<Vector3> sourcePoints;

		// Token: 0x04000925 RID: 2341
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x144")]
		private List<Vector3> savedSplinePoints;

		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x148")]
		private int previousGenerations;

		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x14C")]
		private float previousDistancePerSegment;
	}
}
