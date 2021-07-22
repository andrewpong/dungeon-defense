using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000CE")]
	internal static class PlayerManager
	{
		// Token: 0x060007CE RID: 1998
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x95C188", Offset = "0x95C188", VA = "0x695C188")]
		[PreserveSig]
		internal static extern void PlayerManager_FetchInvitable(HandleRef self, Types.DataSource data_source, PlayerManager.FetchListCallback callback, IntPtr callback_arg);

		// Token: 0x060007CF RID: 1999
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x95C290", Offset = "0x95C290", VA = "0x695C290")]
		[PreserveSig]
		internal static extern void PlayerManager_FetchConnected(HandleRef self, Types.DataSource data_source, PlayerManager.FetchListCallback callback, IntPtr callback_arg);

		// Token: 0x060007D0 RID: 2000
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x95C398", Offset = "0x95C398", VA = "0x695C398")]
		[PreserveSig]
		internal static extern void PlayerManager_Fetch(HandleRef self, Types.DataSource data_source, string player_id, PlayerManager.FetchCallback callback, IntPtr callback_arg);

		// Token: 0x060007D1 RID: 2001
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x95C4E0", Offset = "0x95C4E0", VA = "0x695C4E0")]
		[PreserveSig]
		internal static extern void PlayerManager_FetchRecentlyPlayed(HandleRef self, Types.DataSource data_source, PlayerManager.FetchListCallback callback, IntPtr callback_arg);

		// Token: 0x060007D2 RID: 2002
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x95C5E8", Offset = "0x95C5E8", VA = "0x695C5E8")]
		[PreserveSig]
		internal static extern void PlayerManager_FetchSelf(HandleRef self, Types.DataSource data_source, PlayerManager.FetchSelfCallback callback, IntPtr callback_arg);

		// Token: 0x060007D3 RID: 2003
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x95C720", Offset = "0x95C720", VA = "0x695C720")]
		[PreserveSig]
		internal static extern void PlayerManager_FetchSelfResponse_Dispose(HandleRef self);

		// Token: 0x060007D4 RID: 2004
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x95C808", Offset = "0x95C808", VA = "0x695C808")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus PlayerManager_FetchSelfResponse_GetStatus(HandleRef self);

		// Token: 0x060007D5 RID: 2005
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x95C8F8", Offset = "0x95C8F8", VA = "0x695C8F8")]
		[PreserveSig]
		internal static extern IntPtr PlayerManager_FetchSelfResponse_GetData(HandleRef self);

		// Token: 0x060007D6 RID: 2006
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x95C9E0", Offset = "0x95C9E0", VA = "0x695C9E0")]
		[PreserveSig]
		internal static extern void PlayerManager_FetchResponse_Dispose(HandleRef self);

		// Token: 0x060007D7 RID: 2007
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x95CAC8", Offset = "0x95CAC8", VA = "0x695CAC8")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus PlayerManager_FetchResponse_GetStatus(HandleRef self);

		// Token: 0x060007D8 RID: 2008
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x95CBB0", Offset = "0x95CBB0", VA = "0x695CBB0")]
		[PreserveSig]
		internal static extern IntPtr PlayerManager_FetchResponse_GetData(HandleRef self);

		// Token: 0x060007D9 RID: 2009
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x95CC98", Offset = "0x95CC98", VA = "0x695CC98")]
		[PreserveSig]
		internal static extern void PlayerManager_FetchListResponse_Dispose(HandleRef self);

		// Token: 0x060007DA RID: 2010
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x95CD80", Offset = "0x95CD80", VA = "0x695CD80")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus PlayerManager_FetchListResponse_GetStatus(HandleRef self);

		// Token: 0x060007DB RID: 2011
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x95CE70", Offset = "0x95CE70", VA = "0x695CE70")]
		[PreserveSig]
		internal static extern UIntPtr PlayerManager_FetchListResponse_GetData_Length(HandleRef self);

		// Token: 0x060007DC RID: 2012
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x95CF60", Offset = "0x95CF60", VA = "0x695CF60")]
		[PreserveSig]
		internal static extern IntPtr PlayerManager_FetchListResponse_GetData_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x060007DE RID: 2014
		[Token(Token = "0x20000CF")]
		internal delegate void FetchSelfCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x060007E2 RID: 2018
		[Token(Token = "0x20000D0")]
		internal delegate void FetchCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x060007E6 RID: 2022
		[Token(Token = "0x20000D1")]
		internal delegate void FetchListCallback(IntPtr arg0, IntPtr arg1);
	}
}
