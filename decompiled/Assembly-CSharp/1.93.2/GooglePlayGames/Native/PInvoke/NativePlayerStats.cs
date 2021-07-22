using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x200015E")]
	internal class NativePlayerStats : BaseReferenceHolder
	{
		// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x4782B8", Offset = "0x4782B8", VA = "0x64782B8")]
		internal NativePlayerStats(IntPtr selfPointer)
		{
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x478344", Offset = "0x478344", VA = "0x6478344")]
		internal bool Valid()
		{
			return default(bool);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x478374", Offset = "0x478374", VA = "0x6478374")]
		internal bool HasAverageSessionLength()
		{
			return default(bool);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x4783A4", Offset = "0x4783A4", VA = "0x64783A4")]
		internal float AverageSessionLength()
		{
			return 0f;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x4783D4", Offset = "0x4783D4", VA = "0x64783D4")]
		internal bool HasChurnProbability()
		{
			return default(bool);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x478404", Offset = "0x478404", VA = "0x6478404")]
		internal float ChurnProbability()
		{
			return 0f;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x478434", Offset = "0x478434", VA = "0x6478434")]
		internal bool HasDaysSinceLastPlayed()
		{
			return default(bool);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x478464", Offset = "0x478464", VA = "0x6478464")]
		internal int DaysSinceLastPlayed()
		{
			return 0;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x478494", Offset = "0x478494", VA = "0x6478494")]
		internal bool HasNumberOfPurchases()
		{
			return default(bool);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x4784C4", Offset = "0x4784C4", VA = "0x64784C4")]
		internal int NumberOfPurchases()
		{
			return 0;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x4784F4", Offset = "0x4784F4", VA = "0x64784F4")]
		internal bool HasNumberOfSessions()
		{
			return default(bool);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x478524", Offset = "0x478524", VA = "0x6478524")]
		internal int NumberOfSessions()
		{
			return 0;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x478554", Offset = "0x478554", VA = "0x6478554")]
		internal bool HasSessionPercentile()
		{
			return default(bool);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x478584", Offset = "0x478584", VA = "0x6478584")]
		internal float SessionPercentile()
		{
			return 0f;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x4785B4", Offset = "0x4785B4", VA = "0x64785B4")]
		internal bool HasSpendPercentile()
		{
			return default(bool);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x4785E4", Offset = "0x4785E4", VA = "0x64785E4")]
		internal float SpendPercentile()
		{
			return 0f;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x478614", Offset = "0x478614", VA = "0x6478614", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x478624", Offset = "0x478624", VA = "0x6478624")]
		internal PlayerStats AsPlayerStats()
		{
			return null;
		}
	}
}
