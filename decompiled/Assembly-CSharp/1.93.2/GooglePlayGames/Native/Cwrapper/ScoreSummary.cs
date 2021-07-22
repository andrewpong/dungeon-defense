using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x20000E7")]
	internal static class ScoreSummary
	{
		// Token: 0x06000884 RID: 2180
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x6CCE78", Offset = "0x6CCE78", VA = "0x66CCE78")]
		[PreserveSig]
		internal static extern ulong ScoreSummary_ApproximateNumberOfScores(HandleRef self);

		// Token: 0x06000885 RID: 2181
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x6CCF60", Offset = "0x6CCF60", VA = "0x66CCF60")]
		[PreserveSig]
		internal static extern Types.LeaderboardTimeSpan ScoreSummary_TimeSpan(HandleRef self);

		// Token: 0x06000886 RID: 2182
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x6CD068", Offset = "0x6CD068", VA = "0x66CD068")]
		[PreserveSig]
		internal static extern UIntPtr ScoreSummary_LeaderboardId(HandleRef self, [In] [Out] char[] out_arg, UIntPtr out_size);

		// Token: 0x06000887 RID: 2183
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x6CD218", Offset = "0x6CD218", VA = "0x66CD218")]
		[PreserveSig]
		internal static extern Types.LeaderboardCollection ScoreSummary_Collection(HandleRef self);

		// Token: 0x06000888 RID: 2184
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x6CD328", Offset = "0x6CD328", VA = "0x66CD328")]
		[PreserveSig]
		internal static extern bool ScoreSummary_Valid(HandleRef self);

		// Token: 0x06000889 RID: 2185
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x6CD438", Offset = "0x6CD438", VA = "0x66CD438")]
		[PreserveSig]
		internal static extern IntPtr ScoreSummary_CurrentPlayerScore(HandleRef self);

		// Token: 0x0600088A RID: 2186
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x6CD518", Offset = "0x6CD518", VA = "0x66CD518")]
		[PreserveSig]
		internal static extern void ScoreSummary_Dispose(HandleRef self);
	}
}
