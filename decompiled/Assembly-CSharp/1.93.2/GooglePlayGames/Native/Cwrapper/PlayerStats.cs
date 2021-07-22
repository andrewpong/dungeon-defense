using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000D2")]
	internal static class PlayerStats
	{
		// Token: 0x060007E9 RID: 2025
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x6C3F40", Offset = "0x6C3F40", VA = "0x66C3F40")]
		[PreserveSig]
		internal static extern bool PlayerStats_Valid(HandleRef self);

		// Token: 0x060007EA RID: 2026
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x6C4048", Offset = "0x6C4048", VA = "0x66C4048")]
		[PreserveSig]
		internal static extern void PlayerStats_Dispose(HandleRef self);

		// Token: 0x060007EB RID: 2027
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x6C4150", Offset = "0x6C4150", VA = "0x66C4150")]
		[PreserveSig]
		internal static extern bool PlayerStats_HasAverageSessionLength(HandleRef self);

		// Token: 0x060007EC RID: 2028
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x6C4240", Offset = "0x6C4240", VA = "0x66C4240")]
		[PreserveSig]
		internal static extern float PlayerStats_AverageSessionLength(HandleRef self);

		// Token: 0x060007ED RID: 2029
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x6C4328", Offset = "0x6C4328", VA = "0x66C4328")]
		[PreserveSig]
		internal static extern bool PlayerStats_HasChurnProbability(HandleRef self);

		// Token: 0x060007EE RID: 2030
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x6C4410", Offset = "0x6C4410", VA = "0x66C4410")]
		[PreserveSig]
		internal static extern float PlayerStats_ChurnProbability(HandleRef self);

		// Token: 0x060007EF RID: 2031
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x6C44F0", Offset = "0x6C44F0", VA = "0x66C44F0")]
		[PreserveSig]
		internal static extern bool PlayerStats_HasDaysSinceLastPlayed(HandleRef self);

		// Token: 0x060007F0 RID: 2032
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x6C45E0", Offset = "0x6C45E0", VA = "0x66C45E0")]
		[PreserveSig]
		internal static extern int PlayerStats_DaysSinceLastPlayed(HandleRef self);

		// Token: 0x060007F1 RID: 2033
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x6C46C0", Offset = "0x6C46C0", VA = "0x66C46C0")]
		[PreserveSig]
		internal static extern bool PlayerStats_HasNumberOfPurchases(HandleRef self);

		// Token: 0x060007F2 RID: 2034
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x6C47B0", Offset = "0x6C47B0", VA = "0x66C47B0")]
		[PreserveSig]
		internal static extern int PlayerStats_NumberOfPurchases(HandleRef self);

		// Token: 0x060007F3 RID: 2035
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x6C4890", Offset = "0x6C4890", VA = "0x66C4890")]
		[PreserveSig]
		internal static extern bool PlayerStats_HasNumberOfSessions(HandleRef self);

		// Token: 0x060007F4 RID: 2036
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x6C4978", Offset = "0x6C4978", VA = "0x66C4978")]
		[PreserveSig]
		internal static extern int PlayerStats_NumberOfSessions(HandleRef self);

		// Token: 0x060007F5 RID: 2037
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x6C4A58", Offset = "0x6C4A58", VA = "0x66C4A58")]
		[PreserveSig]
		internal static extern bool PlayerStats_HasSessionPercentile(HandleRef self);

		// Token: 0x060007F6 RID: 2038
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x6C4B48", Offset = "0x6C4B48", VA = "0x66C4B48")]
		[PreserveSig]
		internal static extern float PlayerStats_SessionPercentile(HandleRef self);

		// Token: 0x060007F7 RID: 2039
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x6C4C28", Offset = "0x6C4C28", VA = "0x66C4C28")]
		[PreserveSig]
		internal static extern bool PlayerStats_HasSpendPercentile(HandleRef self);

		// Token: 0x060007F8 RID: 2040
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x6C4D10", Offset = "0x6C4D10", VA = "0x66C4D10")]
		[PreserveSig]
		internal static extern float PlayerStats_SpendPercentile(HandleRef self);
	}
}
