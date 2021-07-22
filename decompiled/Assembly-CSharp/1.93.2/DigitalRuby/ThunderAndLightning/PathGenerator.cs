using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x2000223")]
	public static class PathGenerator
	{
		// Token: 0x06001073 RID: 4211 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x2E3CF4", Offset = "0x2E3CF4", VA = "0x62E3CF4")]
		public static float SquareRoot(float x)
		{
			return 0f;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00006C00 File Offset: 0x00004E00
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x2EC4A0", Offset = "0x2EC4A0", VA = "0x62EC4A0")]
		private static float Distance2D(ref Vector3 point1, ref Vector3 point2)
		{
			return 0f;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x2EC4D0", Offset = "0x2EC4D0", VA = "0x62EC4D0")]
		private static float Distance3D(ref Vector3 point1, ref Vector3 point2)
		{
			return 0f;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x2EC514", Offset = "0x2EC514", VA = "0x62EC514")]
		private static void GetCurvePoint2D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point)
		{
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x2EC5E4", Offset = "0x2EC5E4", VA = "0x62EC5E4")]
		private static void GetCurvePoint3D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point)
		{
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x2EC6FC", Offset = "0x2EC6FC", VA = "0x62EC6FC")]
		private static void CalculateNonuniformCatmullRom(float p1, float p2, float p3, float p4, float distance1, float distance2, float distance3, out Vector4 point)
		{
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00006C30 File Offset: 0x00004E30
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x2EC7C0", Offset = "0x2EC7C0", VA = "0x62EC7C0")]
		private static float CalculatePolynomial(ref Vector4 point, float t)
		{
			return 0f;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x2EC7FC", Offset = "0x2EC7FC", VA = "0x62EC7FC")]
		private static void ClampSplineDistances(ref float distance1, ref float distance2, ref float distance3)
		{
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x2EC844", Offset = "0x2EC844", VA = "0x62EC844")]
		private static void GetSplinePoint2D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point)
		{
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x2ECA10", Offset = "0x2ECA10", VA = "0x62ECA10")]
		private static void GetSplinePoint3D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point)
		{
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00006C48 File Offset: 0x00004E48
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x2ECC78", Offset = "0x2ECC78", VA = "0x62ECC78")]
		public static float CreateCurve(ICollection<Vector3> path, Vector3 start, Vector3 end, Vector3 ctr1, Vector3 ctr2, int numberOfSegments, float startT)
		{
			return 0f;
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00006C60 File Offset: 0x00004E60
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x2E8EF4", Offset = "0x2E8EF4", VA = "0x62E8EF4")]
		public static bool CreateSpline(ICollection<Vector3> path, IList<Vector3> points, int numberOfSegments, bool closePath)
		{
			return default(bool);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00006C78 File Offset: 0x00004E78
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x2E8694", Offset = "0x2E8694", VA = "0x62E8694")]
		public static bool CreateSplineWithSegmentDistance(ICollection<Vector3> path, IList<Vector3> points, float distancePerSegment, bool closePath)
		{
			return default(bool);
		}

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x40007B8")]
		public const int MinPointsForSpline = 4;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x0")]
		public static bool Is2D;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x40007BA")]
		private const float curveMultiplier = 3f;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x40007BB")]
		private const float splineMultiplier1 = -3f;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x40007BC")]
		private const float splineMultiplier2 = 3f;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x40007BD")]
		private const float splineMultiplier3 = 2f;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x40007BE")]
		private const float splineDistanceClamp = 1f;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x40007BF")]
		private const float splineEpsilon = 0.0001f;
	}
}
