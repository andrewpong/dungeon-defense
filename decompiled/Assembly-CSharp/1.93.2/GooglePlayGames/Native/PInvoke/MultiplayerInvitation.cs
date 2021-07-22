using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x2000151")]
	internal class MultiplayerInvitation : BaseReferenceHolder
	{
		// Token: 0x06000BFD RID: 3069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x459714", Offset = "0x459714", VA = "0x6459714")]
		internal MultiplayerInvitation(IntPtr selfPointer)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x45979C", Offset = "0x45979C", VA = "0x645979C")]
		internal MultiplayerParticipant Inviter()
		{
			return null;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x459944", Offset = "0x459944", VA = "0x6459944")]
		internal uint Variant()
		{
			return 0U;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x459970", Offset = "0x459970", VA = "0x6459970")]
		internal ulong CreationTime()
		{
			return 0UL;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x45999C", Offset = "0x45999C", VA = "0x645999C")]
		internal Types.MultiplayerInvitationType Type()
		{
			return (Types.MultiplayerInvitationType)0;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x43D41C", Offset = "0x43D41C", VA = "0x643D41C")]
		internal string Id()
		{
			return null;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x4599C8", Offset = "0x4599C8", VA = "0x64599C8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x43D4D8", Offset = "0x43D4D8", VA = "0x643D4D8")]
		internal uint AutomatchingSlots()
		{
			return 0U;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x43D504", Offset = "0x43D504", VA = "0x643D504")]
		internal uint ParticipantCount()
		{
			return 0U;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00005718 File Offset: 0x00003918
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x4599D8", Offset = "0x4599D8", VA = "0x64599D8")]
		private static Invitation.InvType ToInvType(Types.MultiplayerInvitationType invitationType)
		{
			return Invitation.InvType.RealTime;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x43EDBC", Offset = "0x43EDBC", VA = "0x643EDBC")]
		internal Invitation AsInvitation()
		{
			return null;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x456CAC", Offset = "0x456CAC", VA = "0x6456CAC")]
		internal static MultiplayerInvitation FromPointer(IntPtr selfPointer)
		{
			return null;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x459AF0", Offset = "0x459AF0", VA = "0x6459AF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185E6C", Offset = "0x185E6C")]
		private UIntPtr <Id>m__0(byte[] out_string, UIntPtr size)
		{
			return 0;
		}
	}
}
