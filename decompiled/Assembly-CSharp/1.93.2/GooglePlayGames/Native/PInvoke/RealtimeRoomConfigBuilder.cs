using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x02000207 RID: 519
	[Token(Token = "0x2000180")]
	internal class RealtimeRoomConfigBuilder : BaseReferenceHolder
	{
		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x4859E8", Offset = "0x4859E8", VA = "0x64859E8")]
		internal RealtimeRoomConfigBuilder(IntPtr selfPointer)
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x485A74", Offset = "0x485A74", VA = "0x6485A74")]
		internal RealtimeRoomConfigBuilder PopulateFromUIResponse(PlayerSelectUIResponse response)
		{
			return null;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x485AD0", Offset = "0x485AD0", VA = "0x6485AD0")]
		internal RealtimeRoomConfigBuilder SetVariant(uint variantValue)
		{
			return null;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x485B18", Offset = "0x485B18", VA = "0x6485B18")]
		internal RealtimeRoomConfigBuilder AddInvitedPlayer(string playerId)
		{
			return null;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x485B58", Offset = "0x485B58", VA = "0x6485B58")]
		internal RealtimeRoomConfigBuilder SetExclusiveBitMask(ulong bitmask)
		{
			return null;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x485BA8", Offset = "0x485BA8", VA = "0x6485BA8")]
		internal RealtimeRoomConfigBuilder SetMinimumAutomatchingPlayers(uint minimum)
		{
			return null;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x485BE8", Offset = "0x485BE8", VA = "0x6485BE8")]
		internal RealtimeRoomConfigBuilder SetMaximumAutomatchingPlayers(uint maximum)
		{
			return null;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x485C28", Offset = "0x485C28", VA = "0x6485C28")]
		internal RealtimeRoomConfig Build()
		{
			return null;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x485CC0", Offset = "0x485CC0", VA = "0x6485CC0", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x485CD0", Offset = "0x485CD0", VA = "0x6485CD0")]
		internal static RealtimeRoomConfigBuilder Create()
		{
			return null;
		}
	}
}
