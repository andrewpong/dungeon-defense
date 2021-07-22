using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000CC")]
	internal static class ParticipantResults
	{
		// Token: 0x060007BD RID: 1981
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x95AFA8", Offset = "0x95AFA8", VA = "0x695AFA8")]
		[PreserveSig]
		internal static extern IntPtr ParticipantResults_WithResult(HandleRef self, string participant_id, uint placing, Types.MatchResult result);

		// Token: 0x060007BE RID: 1982
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x95B0C8", Offset = "0x95B0C8", VA = "0x695B0C8")]
		[PreserveSig]
		internal static extern bool ParticipantResults_Valid(HandleRef self);

		// Token: 0x060007BF RID: 1983
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x95B1E0", Offset = "0x95B1E0", VA = "0x695B1E0")]
		[PreserveSig]
		internal static extern Types.MatchResult ParticipantResults_MatchResultForParticipant(HandleRef self, string participant_id);

		// Token: 0x060007C0 RID: 1984
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x95B300", Offset = "0x95B300", VA = "0x695B300")]
		[PreserveSig]
		internal static extern uint ParticipantResults_PlaceForParticipant(HandleRef self, string participant_id);

		// Token: 0x060007C1 RID: 1985
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x95B418", Offset = "0x95B418", VA = "0x695B418")]
		[PreserveSig]
		internal static extern bool ParticipantResults_HasResultsForParticipant(HandleRef self, string participant_id);

		// Token: 0x060007C2 RID: 1986
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x95B538", Offset = "0x95B538", VA = "0x695B538")]
		[PreserveSig]
		internal static extern void ParticipantResults_Dispose(HandleRef self);
	}
}
