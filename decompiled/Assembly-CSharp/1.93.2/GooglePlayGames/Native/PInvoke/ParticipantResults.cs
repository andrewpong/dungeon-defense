using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x200016E")]
	internal class ParticipantResults : BaseReferenceHolder
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x47B684", Offset = "0x47B684", VA = "0x647B684")]
		internal ParticipantResults(IntPtr selfPointer)
		{
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x47F9FC", Offset = "0x47F9FC", VA = "0x647F9FC")]
		internal bool HasResultsForParticipant(string participantId)
		{
			return default(bool);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x47FA34", Offset = "0x47FA34", VA = "0x647FA34")]
		internal uint PlacingForParticipant(string participantId)
		{
			return 0U;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x47FA6C", Offset = "0x47FA6C", VA = "0x647FA6C")]
		internal Types.MatchResult ResultsForParticipant(string participantId)
		{
			return (Types.MatchResult)0;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x47FAA4", Offset = "0x47FAA4", VA = "0x647FAA4")]
		internal ParticipantResults WithResult(string participantId, uint placing, Types.MatchResult result)
		{
			return null;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x47FB58", Offset = "0x47FB58", VA = "0x647FB58", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}
	}
}
