using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x20000E6")]
	internal static class ScorePage
	{
		// Token: 0x06000870 RID: 2160
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x6CBAC0", Offset = "0x6CBAC0", VA = "0x66CBAC0")]
		[PreserveSig]
		internal static extern void ScorePage_Dispose(HandleRef self);

		// Token: 0x06000871 RID: 2161
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x6CBBC0", Offset = "0x6CBBC0", VA = "0x66CBBC0")]
		[PreserveSig]
		internal static extern Types.LeaderboardTimeSpan ScorePage_TimeSpan(HandleRef self);

		// Token: 0x06000872 RID: 2162
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x6CBCC8", Offset = "0x6CBCC8", VA = "0x66CBCC8")]
		[PreserveSig]
		internal static extern UIntPtr ScorePage_LeaderboardId(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000873 RID: 2163
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x6CBDF0", Offset = "0x6CBDF0", VA = "0x66CBDF0")]
		[PreserveSig]
		internal static extern Types.LeaderboardCollection ScorePage_Collection(HandleRef self);

		// Token: 0x06000874 RID: 2164
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x6CBEF8", Offset = "0x6CBEF8", VA = "0x66CBEF8")]
		[PreserveSig]
		internal static extern Types.LeaderboardStart ScorePage_Start(HandleRef self);

		// Token: 0x06000875 RID: 2165
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x6CBFF8", Offset = "0x6CBFF8", VA = "0x66CBFF8")]
		[PreserveSig]
		internal static extern bool ScorePage_Valid(HandleRef self);

		// Token: 0x06000876 RID: 2166
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x6CC100", Offset = "0x6CC100", VA = "0x66CC100")]
		[PreserveSig]
		internal static extern bool ScorePage_HasPreviousScorePage(HandleRef self);

		// Token: 0x06000877 RID: 2167
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x6CC1E8", Offset = "0x6CC1E8", VA = "0x66CC1E8")]
		[PreserveSig]
		internal static extern bool ScorePage_HasNextScorePage(HandleRef self);

		// Token: 0x06000878 RID: 2168
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x6CC2D0", Offset = "0x6CC2D0", VA = "0x66CC2D0")]
		[PreserveSig]
		internal static extern IntPtr ScorePage_PreviousScorePageToken(HandleRef self);

		// Token: 0x06000879 RID: 2169
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x6CC3B8", Offset = "0x6CC3B8", VA = "0x66CC3B8")]
		[PreserveSig]
		internal static extern IntPtr ScorePage_NextScorePageToken(HandleRef self);

		// Token: 0x0600087A RID: 2170
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x6CC498", Offset = "0x6CC498", VA = "0x66CC498")]
		[PreserveSig]
		internal static extern UIntPtr ScorePage_Entries_Length(HandleRef self);

		// Token: 0x0600087B RID: 2171
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x6CC5A8", Offset = "0x6CC5A8", VA = "0x66CC5A8")]
		[PreserveSig]
		internal static extern IntPtr ScorePage_Entries_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x0600087C RID: 2172
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x6CC690", Offset = "0x6CC690", VA = "0x66CC690")]
		[PreserveSig]
		internal static extern void ScorePage_Entry_Dispose(HandleRef self);

		// Token: 0x0600087D RID: 2173
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x6CC7A0", Offset = "0x6CC7A0", VA = "0x66CC7A0")]
		[PreserveSig]
		internal static extern UIntPtr ScorePage_Entry_PlayerId(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x0600087E RID: 2174
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x6CC8C8", Offset = "0x6CC8C8", VA = "0x66CC8C8")]
		[PreserveSig]
		internal static extern ulong ScorePage_Entry_LastModified(HandleRef self);

		// Token: 0x0600087F RID: 2175
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x6CC9A8", Offset = "0x6CC9A8", VA = "0x66CC9A8")]
		[PreserveSig]
		internal static extern IntPtr ScorePage_Entry_Score(HandleRef self);

		// Token: 0x06000880 RID: 2176
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x6CCAB0", Offset = "0x6CCAB0", VA = "0x66CCAB0")]
		[PreserveSig]
		internal static extern bool ScorePage_Entry_Valid(HandleRef self);

		// Token: 0x06000881 RID: 2177
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x6CCBC0", Offset = "0x6CCBC0", VA = "0x66CCBC0")]
		[PreserveSig]
		internal static extern ulong ScorePage_Entry_LastModifiedTime(HandleRef self);

		// Token: 0x06000882 RID: 2178
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x6CCCA8", Offset = "0x6CCCA8", VA = "0x66CCCA8")]
		[PreserveSig]
		internal static extern bool ScorePage_ScorePageToken_Valid(HandleRef self);

		// Token: 0x06000883 RID: 2179
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x6CCD90", Offset = "0x6CCD90", VA = "0x66CCD90")]
		[PreserveSig]
		internal static extern void ScorePage_ScorePageToken_Dispose(HandleRef self);
	}
}
