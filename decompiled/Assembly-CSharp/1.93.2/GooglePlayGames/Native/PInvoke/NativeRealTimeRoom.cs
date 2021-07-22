using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x200015F")]
	internal class NativeRealTimeRoom : BaseReferenceHolder
	{
		// Token: 0x06000C8B RID: 3211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x4788F0", Offset = "0x4788F0", VA = "0x64788F0")]
		internal NativeRealTimeRoom(IntPtr selfPointer)
		{
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x47897C", Offset = "0x47897C", VA = "0x647897C")]
		internal string Id()
		{
			return null;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x478A34", Offset = "0x478A34", VA = "0x6478A34")]
		internal IEnumerable<MultiplayerParticipant> Participants()
		{
			return null;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x478B34", Offset = "0x478B34", VA = "0x6478B34")]
		internal uint ParticipantCount()
		{
			return 0U;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x478B74", Offset = "0x478B74", VA = "0x6478B74")]
		internal Types.RealTimeRoomStatus Status()
		{
			return (Types.RealTimeRoomStatus)0;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x478BA4", Offset = "0x478BA4", VA = "0x6478BA4", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x478BB4", Offset = "0x478BB4", VA = "0x6478BB4")]
		internal static NativeRealTimeRoom FromPointer(IntPtr selfPointer)
		{
			return null;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x478C68", Offset = "0x478C68", VA = "0x6478C68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1861DC", Offset = "0x1861DC")]
		private UIntPtr <Id>m__0(byte[] out_string, UIntPtr size)
		{
			return 0;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x478CB0", Offset = "0x478CB0", VA = "0x6478CB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1861EC", Offset = "0x1861EC")]
		private MultiplayerParticipant <Participants>m__1(UIntPtr index)
		{
			return null;
		}
	}
}
