using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000B0")]
	internal static class GameServices
	{
		// Token: 0x0600071C RID: 1820
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x951998", Offset = "0x951998", VA = "0x6951998")]
		[PreserveSig]
		internal static extern void GameServices_Flush(HandleRef self, GameServices.FlushCallback callback, IntPtr callback_arg);

		// Token: 0x0600071D RID: 1821
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x951AC0", Offset = "0x951AC0", VA = "0x6951AC0")]
		[PreserveSig]
		internal static extern bool GameServices_IsAuthorized(HandleRef self);

		// Token: 0x0600071E RID: 1822
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x951BD8", Offset = "0x951BD8", VA = "0x6951BD8")]
		[PreserveSig]
		internal static extern void GameServices_Dispose(HandleRef self);

		// Token: 0x0600071F RID: 1823
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x951CE0", Offset = "0x951CE0", VA = "0x6951CE0")]
		[PreserveSig]
		internal static extern void GameServices_SignOut(HandleRef self);

		// Token: 0x06000720 RID: 1824
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x951DE8", Offset = "0x951DE8", VA = "0x6951DE8")]
		[PreserveSig]
		internal static extern void GameServices_StartAuthorizationUI(HandleRef self);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x06000722 RID: 1826
		[Token(Token = "0x20000B1")]
		internal delegate void FlushCallback(CommonErrorStatus.FlushStatus arg0, IntPtr arg1);
	}
}
