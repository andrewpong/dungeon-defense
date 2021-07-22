using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x2000048")]
	public class MatchOutcome
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x942614", Offset = "0x942614", VA = "0x6942614")]
		public MatchOutcome()
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x942708", Offset = "0x942708", VA = "0x6942708")]
		public void SetParticipantResult(string participantId, MatchOutcome.ParticipantResult result, uint placement)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x942830", Offset = "0x942830", VA = "0x6942830")]
		public void SetParticipantResult(string participantId, MatchOutcome.ParticipantResult result)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x94284C", Offset = "0x94284C", VA = "0x694284C")]
		public void SetParticipantResult(string participantId, uint placement)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004D")]
		public List<string> ParticipantIds
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x94286C", Offset = "0x94286C", VA = "0x694286C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x942874", Offset = "0x942874", VA = "0x6942874")]
		public MatchOutcome.ParticipantResult GetResultFor(string participantId)
		{
			return MatchOutcome.ParticipantResult.None;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x942934", Offset = "0x942934", VA = "0x6942934")]
		public uint GetPlacementFor(string participantId)
		{
			return 0U;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x9429F4", Offset = "0x9429F4", VA = "0x69429F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001AC")]
		public const uint PlacementUnset = 0U;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x8")]
		private List<string> mParticipantIds;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<string, uint> mPlacements;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, MatchOutcome.ParticipantResult> mResults;

		// Token: 0x02000050 RID: 80
		[Token(Token = "0x2000049")]
		public enum ParticipantResult
		{
			// Token: 0x040001FD RID: 509
			[Token(Token = "0x40001B1")]
			Unset = -1,
			// Token: 0x040001FE RID: 510
			[Token(Token = "0x40001B2")]
			None,
			// Token: 0x040001FF RID: 511
			[Token(Token = "0x40001B3")]
			Win,
			// Token: 0x04000200 RID: 512
			[Token(Token = "0x40001B4")]
			Loss,
			// Token: 0x04000201 RID: 513
			[Token(Token = "0x40001B5")]
			Tie
		}
	}
}
