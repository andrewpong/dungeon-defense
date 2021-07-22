using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x200004E")]
	public class TurnBasedMatch
	{
		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x943300", Offset = "0x943300", VA = "0x6943300")]
		internal TurnBasedMatch(string matchId, byte[] data, bool canRematch, string selfParticipantId, List<Participant> participants, uint availableAutomatchSlots, string pendingParticipantId, TurnBasedMatch.MatchTurnStatus turnStatus, TurnBasedMatch.MatchStatus matchStatus, uint variant, uint version, ulong creationTime, ulong lastUpdateTime)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x17000054")]
		public DateTime CreationTime
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x9433FC", Offset = "0x9433FC", VA = "0x69433FC")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x17000055")]
		public DateTime LastUpdateTime
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x9434CC", Offset = "0x9434CC", VA = "0x69434CC")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000056")]
		public string MatchId
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x94359C", Offset = "0x94359C", VA = "0x694359C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000057")]
		public byte[] Data
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x9435A4", Offset = "0x9435A4", VA = "0x69435A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x17000058")]
		public bool CanRematch
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x9435AC", Offset = "0x9435AC", VA = "0x69435AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000059")]
		public string SelfParticipantId
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x9435B4", Offset = "0x9435B4", VA = "0x69435B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005A")]
		public Participant Self
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x9435BC", Offset = "0x9435BC", VA = "0x69435BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x9435C4", Offset = "0x9435C4", VA = "0x69435C4")]
		public Participant GetParticipant(string participantId)
		{
			return null;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005B")]
		public List<Participant> Participants
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x9437EC", Offset = "0x9437EC", VA = "0x69437EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005C")]
		public string PendingParticipantId
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x9437F4", Offset = "0x9437F4", VA = "0x69437F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005D")]
		public Participant PendingParticipant
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x9437FC", Offset = "0x9437FC", VA = "0x69437FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x1700005E")]
		public TurnBasedMatch.MatchTurnStatus TurnStatus
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x943810", Offset = "0x943810", VA = "0x6943810")]
			get
			{
				return TurnBasedMatch.MatchTurnStatus.Complete;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x1700005F")]
		public TurnBasedMatch.MatchStatus Status
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x943818", Offset = "0x943818", VA = "0x6943818")]
			get
			{
				return TurnBasedMatch.MatchStatus.Active;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x17000060")]
		public uint Variant
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x943820", Offset = "0x943820", VA = "0x6943820")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x17000061")]
		public uint Version
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x943828", Offset = "0x943828", VA = "0x6943828")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x17000062")]
		public uint AvailableAutomatchSlots
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x943830", Offset = "0x943830", VA = "0x6943830")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x943838", Offset = "0x943838", VA = "0x6943838", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x943FFC", Offset = "0x943FFC", VA = "0x6943FFC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1853FC", Offset = "0x1853FC")]
		private static string <ToString>m__0(Participant p)
		{
			return null;
		}

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime UnixEpoch;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x8")]
		private string mMatchId;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0xC")]
		private byte[] mData;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x10")]
		private bool mCanRematch;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x14")]
		private uint mAvailableAutomatchSlots;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x18")]
		private string mSelfParticipantId;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x1C")]
		private List<Participant> mParticipants;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x20")]
		private string mPendingParticipantId;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x24")]
		private TurnBasedMatch.MatchTurnStatus mTurnStatus;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x28")]
		private TurnBasedMatch.MatchStatus mMatchStatus;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x2C")]
		private uint mVariant;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x30")]
		private uint mVersion;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x38")]
		private long mCreationTime;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x40")]
		private long mLastUpdateTime;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180B44", Offset = "0x180B44")]
		private static Func<Participant, string> <>f__am$cache0;

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x200004F")]
		public enum MatchStatus
		{
			// Token: 0x04000220 RID: 544
			[Token(Token = "0x40001D4")]
			Active,
			// Token: 0x04000221 RID: 545
			[Token(Token = "0x40001D5")]
			AutoMatching,
			// Token: 0x04000222 RID: 546
			[Token(Token = "0x40001D6")]
			Cancelled,
			// Token: 0x04000223 RID: 547
			[Token(Token = "0x40001D7")]
			Complete,
			// Token: 0x04000224 RID: 548
			[Token(Token = "0x40001D8")]
			Expired,
			// Token: 0x04000225 RID: 549
			[Token(Token = "0x40001D9")]
			Unknown,
			// Token: 0x04000226 RID: 550
			[Token(Token = "0x40001DA")]
			Deleted
		}

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000050")]
		public enum MatchTurnStatus
		{
			// Token: 0x04000228 RID: 552
			[Token(Token = "0x40001DC")]
			Complete,
			// Token: 0x04000229 RID: 553
			[Token(Token = "0x40001DD")]
			Invited,
			// Token: 0x0400022A RID: 554
			[Token(Token = "0x40001DE")]
			MyTurn,
			// Token: 0x0400022B RID: 555
			[Token(Token = "0x40001DF")]
			TheirTurn,
			// Token: 0x0400022C RID: 556
			[Token(Token = "0x40001E0")]
			Unknown
		}
	}
}
