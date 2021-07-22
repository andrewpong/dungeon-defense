using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x20000FD")]
	internal static class TurnBasedMatch
	{
		// Token: 0x060008DA RID: 2266
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x6D1F60", Offset = "0x6D1F60", VA = "0x66D1F60")]
		[PreserveSig]
		internal static extern uint TurnBasedMatch_AutomatchingSlotsAvailable(HandleRef self);

		// Token: 0x060008DB RID: 2267
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x6D2050", Offset = "0x6D2050", VA = "0x66D2050")]
		[PreserveSig]
		internal static extern ulong TurnBasedMatch_CreationTime(HandleRef self);

		// Token: 0x060008DC RID: 2268
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x6D2130", Offset = "0x6D2130", VA = "0x66D2130")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMatch_Participants_Length(HandleRef self);

		// Token: 0x060008DD RID: 2269
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x6D2218", Offset = "0x6D2218", VA = "0x66D2218")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMatch_Participants_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x060008DE RID: 2270
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x6D2308", Offset = "0x6D2308", VA = "0x66D2308")]
		[PreserveSig]
		internal static extern uint TurnBasedMatch_Version(HandleRef self);

		// Token: 0x060008DF RID: 2271
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x6D2418", Offset = "0x6D2418", VA = "0x66D2418")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMatch_ParticipantResults(HandleRef self);

		// Token: 0x060008E0 RID: 2272
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x6D2500", Offset = "0x6D2500", VA = "0x66D2500")]
		[PreserveSig]
		internal static extern Types.MatchStatus TurnBasedMatch_Status(HandleRef self);

		// Token: 0x060008E1 RID: 2273
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x6D2608", Offset = "0x6D2608", VA = "0x66D2608")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMatch_Description(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008E2 RID: 2274
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x6D2700", Offset = "0x6D2700", VA = "0x66D2700")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMatch_PendingParticipant(HandleRef self);

		// Token: 0x060008E3 RID: 2275
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x6D27E8", Offset = "0x6D27E8", VA = "0x66D27E8")]
		[PreserveSig]
		internal static extern uint TurnBasedMatch_Variant(HandleRef self);

		// Token: 0x060008E4 RID: 2276
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x6D28F8", Offset = "0x6D28F8", VA = "0x66D28F8")]
		[PreserveSig]
		internal static extern bool TurnBasedMatch_HasPreviousMatchData(HandleRef self);

		// Token: 0x060008E5 RID: 2277
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x6D29E8", Offset = "0x6D29E8", VA = "0x66D29E8")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMatch_Data(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008E6 RID: 2278
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x6D2B08", Offset = "0x6D2B08", VA = "0x66D2B08")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMatch_LastUpdatingParticipant(HandleRef self);

		// Token: 0x060008E7 RID: 2279
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x6D2BF0", Offset = "0x6D2BF0", VA = "0x66D2BF0")]
		[PreserveSig]
		internal static extern bool TurnBasedMatch_HasData(HandleRef self);

		// Token: 0x060008E8 RID: 2280
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x6D2D08", Offset = "0x6D2D08", VA = "0x66D2D08")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMatch_SuggestedNextParticipant(HandleRef self);

		// Token: 0x060008E9 RID: 2281
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x6D2DF0", Offset = "0x6D2DF0", VA = "0x66D2DF0")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMatch_PreviousMatchData(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008EA RID: 2282
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x6D2EF0", Offset = "0x6D2EF0", VA = "0x66D2EF0")]
		[PreserveSig]
		internal static extern ulong TurnBasedMatch_LastUpdateTime(HandleRef self);

		// Token: 0x060008EB RID: 2283
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x6D2FD0", Offset = "0x6D2FD0", VA = "0x66D2FD0")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMatch_RematchId(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008EC RID: 2284
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x6D30F8", Offset = "0x6D30F8", VA = "0x66D30F8")]
		[PreserveSig]
		internal static extern uint TurnBasedMatch_Number(HandleRef self);

		// Token: 0x060008ED RID: 2285
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x6D3200", Offset = "0x6D3200", VA = "0x66D3200")]
		[PreserveSig]
		internal static extern bool TurnBasedMatch_HasRematchId(HandleRef self);

		// Token: 0x060008EE RID: 2286
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x6D32E8", Offset = "0x6D32E8", VA = "0x66D32E8")]
		[PreserveSig]
		internal static extern bool TurnBasedMatch_Valid(HandleRef self);

		// Token: 0x060008EF RID: 2287
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x6D33F8", Offset = "0x6D33F8", VA = "0x66D33F8")]
		[PreserveSig]
		internal static extern IntPtr TurnBasedMatch_CreatingParticipant(HandleRef self);

		// Token: 0x060008F0 RID: 2288
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x6D34E0", Offset = "0x6D34E0", VA = "0x66D34E0")]
		[PreserveSig]
		internal static extern UIntPtr TurnBasedMatch_Id(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008F1 RID: 2289
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x6D35F8", Offset = "0x6D35F8", VA = "0x66D35F8")]
		[PreserveSig]
		internal static extern void TurnBasedMatch_Dispose(HandleRef self);
	}
}
