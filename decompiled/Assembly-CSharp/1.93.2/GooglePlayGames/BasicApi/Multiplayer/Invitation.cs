using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x2000043")]
	public class Invitation
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x941D6C", Offset = "0x941D6C", VA = "0x6941D6C")]
		internal Invitation(Invitation.InvType invType, string invId, Participant inviter, int variant, long creationTime)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x17000048")]
		public Invitation.InvType InvitationType
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x941DB4", Offset = "0x941DB4", VA = "0x6941DB4")]
			get
			{
				return Invitation.InvType.RealTime;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000049")]
		public string InvitationId
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x941DBC", Offset = "0x941DBC", VA = "0x6941DBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004A")]
		public Participant Inviter
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x941DC4", Offset = "0x941DC4", VA = "0x6941DC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x1700004B")]
		public int Variant
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x941DCC", Offset = "0x941DCC", VA = "0x6941DCC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x1700004C")]
		public DateTime CreationTime
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x941DD4", Offset = "0x941DD4", VA = "0x6941DD4")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x941EA4", Offset = "0x941EA4", VA = "0x6941EA4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime UnixEpoch;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x8")]
		private Invitation.InvType mInvitationType;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0xC")]
		private string mInvitationId;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x10")]
		private Participant mInviter;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x14")]
		private int mVariant;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x18")]
		private long mCreationTime;

		// Token: 0x0200004B RID: 75
		[Token(Token = "0x2000044")]
		public enum InvType
		{
			// Token: 0x040001F5 RID: 501
			[Token(Token = "0x40001A9")]
			RealTime,
			// Token: 0x040001F6 RID: 502
			[Token(Token = "0x40001AA")]
			TurnBased,
			// Token: 0x040001F7 RID: 503
			[Token(Token = "0x40001AB")]
			Unknown
		}
	}
}
