using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x200004A")]
	public class Participant : IComparable<Participant>
	{
		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x942C90", Offset = "0x942C90", VA = "0x6942C90")]
		internal Participant(string displayName, string participantId, Participant.ParticipantStatus status, Player player, bool connectedToRoom)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004E")]
		public string DisplayName
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x942D6C", Offset = "0x942D6C", VA = "0x6942D6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004F")]
		public string ParticipantId
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x942D74", Offset = "0x942D74", VA = "0x6942D74")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x17000050")]
		public Participant.ParticipantStatus Status
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x942D7C", Offset = "0x942D7C", VA = "0x6942D7C")]
			get
			{
				return Participant.ParticipantStatus.NotInvitedYet;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000051")]
		public Player Player
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x942D84", Offset = "0x942D84", VA = "0x6942D84")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x17000052")]
		public bool IsConnectedToRoom
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x942D8C", Offset = "0x942D8C", VA = "0x6942D8C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x17000053")]
		public bool IsAutomatch
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x942D94", Offset = "0x942D94", VA = "0x6942D94")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x942DA8", Offset = "0x942DA8", VA = "0x6942DA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x9430CC", Offset = "0x9430CC", VA = "0x69430CC", Slot = "4")]
		public int CompareTo(Participant other)
		{
			return 0;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x943174", Offset = "0x943174", VA = "0x6943174", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x9432C0", Offset = "0x9432C0", VA = "0x69432C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x8")]
		private string mDisplayName;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0xC")]
		private readonly string mParticipantId;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x10")]
		private Participant.ParticipantStatus mStatus;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x14")]
		private Player mPlayer;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x18")]
		private bool mIsConnectedToRoom;

		// Token: 0x02000052 RID: 82
		[Token(Token = "0x200004B")]
		public enum ParticipantStatus
		{
			// Token: 0x04000208 RID: 520
			[Token(Token = "0x40001BC")]
			NotInvitedYet,
			// Token: 0x04000209 RID: 521
			[Token(Token = "0x40001BD")]
			Invited,
			// Token: 0x0400020A RID: 522
			[Token(Token = "0x40001BE")]
			Joined,
			// Token: 0x0400020B RID: 523
			[Token(Token = "0x40001BF")]
			Declined,
			// Token: 0x0400020C RID: 524
			[Token(Token = "0x40001C0")]
			Left,
			// Token: 0x0400020D RID: 525
			[Token(Token = "0x40001C1")]
			Finished,
			// Token: 0x0400020E RID: 526
			[Token(Token = "0x40001C2")]
			Unresponsive,
			// Token: 0x0400020F RID: 527
			[Token(Token = "0x40001C3")]
			Unknown
		}
	}
}
