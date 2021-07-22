using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x20000F2")]
	internal static class StatsManager
	{
		// Token: 0x060008D2 RID: 2258
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x6D1898", Offset = "0x6D1898", VA = "0x66D1898")]
		[PreserveSig]
		internal static extern void StatsManager_FetchForPlayer(HandleRef self, Types.DataSource data_source, StatsManager.FetchForPlayerCallback callback, IntPtr callback_arg);

		// Token: 0x060008D3 RID: 2259
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x6D1998", Offset = "0x6D1998", VA = "0x66D1998")]
		[PreserveSig]
		internal static extern void StatsManager_FetchForPlayerResponse_Dispose(HandleRef self);

		// Token: 0x060008D4 RID: 2260
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x6D1A88", Offset = "0x6D1A88", VA = "0x66D1A88")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus StatsManager_FetchForPlayerResponse_GetStatus(HandleRef self);

		// Token: 0x060008D5 RID: 2261
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x6D1B78", Offset = "0x6D1B78", VA = "0x66D1B78")]
		[PreserveSig]
		internal static extern IntPtr StatsManager_FetchForPlayerResponse_GetData(HandleRef self);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x060008D7 RID: 2263
		[Token(Token = "0x20000F3")]
		internal delegate void FetchForPlayerCallback(IntPtr arg0, IntPtr arg1);
	}
}
