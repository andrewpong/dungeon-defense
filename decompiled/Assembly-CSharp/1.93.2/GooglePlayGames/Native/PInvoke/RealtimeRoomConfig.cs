using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x200017F")]
	internal class RealtimeRoomConfig : BaseReferenceHolder
	{
		// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x485898", Offset = "0x485898", VA = "0x6485898")]
		internal RealtimeRoomConfig(IntPtr selfPointer)
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x485924", Offset = "0x485924", VA = "0x6485924", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x485934", Offset = "0x485934", VA = "0x6485934")]
		internal static RealtimeRoomConfig FromPointer(IntPtr selfPointer)
		{
			return null;
		}
	}
}
