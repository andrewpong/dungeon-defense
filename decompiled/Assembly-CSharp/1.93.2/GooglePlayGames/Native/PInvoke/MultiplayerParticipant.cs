using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D4 RID: 468
	[Token(Token = "0x2000152")]
	internal class MultiplayerParticipant : BaseReferenceHolder
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x459890", Offset = "0x459890", VA = "0x6459890")]
		internal MultiplayerParticipant(IntPtr selfPointer)
		{
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00005748 File Offset: 0x00003948
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x44214C", Offset = "0x44214C", VA = "0x644214C")]
		internal Types.ParticipantStatus Status()
		{
			return (Types.ParticipantStatus)0;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x440954", Offset = "0x440954", VA = "0x6440954")]
		internal bool IsConnectedToRoom()
		{
			return default(bool);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x459B34", Offset = "0x459B34", VA = "0x6459B34")]
		internal string DisplayName()
		{
			return null;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x459BF0", Offset = "0x459BF0", VA = "0x6459BF0")]
		internal NativePlayer Player()
		{
			return null;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x440CFC", Offset = "0x440CFC", VA = "0x6440CFC")]
		internal string Id()
		{
			return null;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x459918", Offset = "0x459918", VA = "0x6459918")]
		internal bool Valid()
		{
			return default(bool);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x459CAC", Offset = "0x459CAC", VA = "0x6459CAC", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x440DE0", Offset = "0x440DE0", VA = "0x6440DE0")]
		internal Participant AsParticipant()
		{
			return null;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x459CBC", Offset = "0x459CBC", VA = "0x6459CBC")]
		internal static MultiplayerParticipant FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x44DCC8", Offset = "0x44DCC8", VA = "0x644DCC8")]
		internal static MultiplayerParticipant AutomatchingSentinel()
		{
			return null;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x459F6C", Offset = "0x459F6C", VA = "0x6459F6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185E7C", Offset = "0x185E7C")]
		private UIntPtr <DisplayName>m__0(byte[] out_string, UIntPtr size)
		{
			return 0;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x459FB0", Offset = "0x459FB0", VA = "0x6459FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185E8C", Offset = "0x185E8C")]
		private UIntPtr <Id>m__1(byte[] out_string, UIntPtr size)
		{
			return 0;
		}

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Types.ParticipantStatus, Participant.ParticipantStatus> StatusConversion;
	}
}
