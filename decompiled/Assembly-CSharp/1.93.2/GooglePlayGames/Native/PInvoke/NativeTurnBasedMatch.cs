using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001EB RID: 491
	[Token(Token = "0x2000169")]
	internal class NativeTurnBasedMatch : BaseReferenceHolder
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x47B370", Offset = "0x47B370", VA = "0x647B370")]
		internal NativeTurnBasedMatch(IntPtr selfPointer)
		{
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00005EE0 File Offset: 0x000040E0
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x47B3FC", Offset = "0x47B3FC", VA = "0x647B3FC")]
		internal uint AvailableAutomatchSlots()
		{
			return 0U;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x47B42C", Offset = "0x47B42C", VA = "0x647B42C")]
		internal ulong CreationTime()
		{
			return 0UL;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00005F10 File Offset: 0x00004110
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x47B45C", Offset = "0x47B45C", VA = "0x647B45C")]
		internal ulong LastUpdateTime()
		{
			return 0UL;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x47B48C", Offset = "0x47B48C", VA = "0x647B48C")]
		internal IEnumerable<MultiplayerParticipant> Participants()
		{
			return null;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00005F28 File Offset: 0x00004128
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x47B58C", Offset = "0x47B58C", VA = "0x647B58C")]
		internal uint Version()
		{
			return 0U;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x47B5BC", Offset = "0x47B5BC", VA = "0x647B5BC")]
		internal uint Variant()
		{
			return 0U;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x47B5EC", Offset = "0x47B5EC", VA = "0x647B5EC")]
		internal ParticipantResults Results()
		{
			return null;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x47B710", Offset = "0x47B710", VA = "0x647B710")]
		internal MultiplayerParticipant ParticipantWithId(string participantId)
		{
			return null;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x47BACC", Offset = "0x47BACC", VA = "0x647BACC")]
		internal MultiplayerParticipant PendingParticipant()
		{
			return null;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00005F58 File Offset: 0x00004158
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x47BBAC", Offset = "0x47BBAC", VA = "0x647BBAC")]
		internal Types.MatchStatus MatchStatus()
		{
			return (Types.MatchStatus)0;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x47BBDC", Offset = "0x47BBDC", VA = "0x647BBDC")]
		internal string Description()
		{
			return null;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00005F70 File Offset: 0x00004170
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x47BC94", Offset = "0x47BC94", VA = "0x647BC94")]
		internal bool HasRematchId()
		{
			return default(bool);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x47BD64", Offset = "0x47BD64", VA = "0x647BD64")]
		internal string RematchId()
		{
			return null;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x47BE1C", Offset = "0x47BE1C", VA = "0x647BE1C")]
		internal byte[] Data()
		{
			return null;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x47C09C", Offset = "0x47C09C", VA = "0x647C09C")]
		internal string Id()
		{
			return null;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x47C154", Offset = "0x47C154", VA = "0x647C154", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x47C164", Offset = "0x47C164", VA = "0x647C164")]
		internal GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch AsTurnBasedMatch(string selfPlayerId)
		{
			return null;
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00005F88 File Offset: 0x00004188
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x47CB94", Offset = "0x47CB94", VA = "0x647CB94")]
		private static GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus ToTurnStatus(Types.MatchStatus status)
		{
			return GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus.Complete;
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00005FA0 File Offset: 0x000041A0
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x47CBB4", Offset = "0x47CBB4", VA = "0x647CBB4")]
		private static GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus ToMatchStatus(string pendingParticipantId, Types.MatchStatus status)
		{
			return GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus.Active;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x47CC24", Offset = "0x47CC24", VA = "0x647CC24")]
		internal static NativeTurnBasedMatch FromPointer(IntPtr selfPointer)
		{
			return null;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x47CD58", Offset = "0x47CD58", VA = "0x647CD58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18627C", Offset = "0x18627C")]
		private MultiplayerParticipant <Participants>m__0(UIntPtr index)
		{
			return null;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x47CDFC", Offset = "0x47CDFC", VA = "0x647CDFC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18628C", Offset = "0x18628C")]
		private UIntPtr <Description>m__1(byte[] out_string, UIntPtr size)
		{
			return 0;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x47CE44", Offset = "0x47CE44", VA = "0x647CE44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18629C", Offset = "0x18629C")]
		private UIntPtr <RematchId>m__2(byte[] out_string, UIntPtr size)
		{
			return 0;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x47CE8C", Offset = "0x47CE8C", VA = "0x647CE8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1862AC", Offset = "0x1862AC")]
		private UIntPtr <Data>m__3(byte[] bytes, UIntPtr size)
		{
			return 0;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x47CED4", Offset = "0x47CED4", VA = "0x647CED4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1862BC", Offset = "0x1862BC")]
		private UIntPtr <Id>m__4(byte[] out_string, UIntPtr size)
		{
			return 0;
		}
	}
}
