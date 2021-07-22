using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000AD")]
	internal static class EventManager
	{
		// Token: 0x0600070B RID: 1803
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x950A60", Offset = "0x950A60", VA = "0x6950A60")]
		[PreserveSig]
		internal static extern void EventManager_FetchAll(HandleRef self, Types.DataSource data_source, EventManager.FetchAllCallback callback, IntPtr callback_arg);

		// Token: 0x0600070C RID: 1804
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x950B98", Offset = "0x950B98", VA = "0x6950B98")]
		[PreserveSig]
		internal static extern void EventManager_Fetch(HandleRef self, Types.DataSource data_source, string event_id, EventManager.FetchCallback callback, IntPtr callback_arg);

		// Token: 0x0600070D RID: 1805
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x950CE0", Offset = "0x950CE0", VA = "0x6950CE0")]
		[PreserveSig]
		internal static extern void EventManager_Increment(HandleRef self, string event_id, uint steps);

		// Token: 0x0600070E RID: 1806
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x950E18", Offset = "0x950E18", VA = "0x6950E18")]
		[PreserveSig]
		internal static extern void EventManager_FetchAllResponse_Dispose(HandleRef self);

		// Token: 0x0600070F RID: 1807
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x950F00", Offset = "0x950F00", VA = "0x6950F00")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus EventManager_FetchAllResponse_GetStatus(HandleRef self);

		// Token: 0x06000710 RID: 1808
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x950FE8", Offset = "0x950FE8", VA = "0x6950FE8")]
		[PreserveSig]
		internal static extern UIntPtr EventManager_FetchAllResponse_GetData(HandleRef self, IntPtr[] out_arg, UIntPtr out_size);

		// Token: 0x06000711 RID: 1809
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x9510E8", Offset = "0x9510E8", VA = "0x69510E8")]
		[PreserveSig]
		internal static extern void EventManager_FetchResponse_Dispose(HandleRef self);

		// Token: 0x06000712 RID: 1810
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x9511D0", Offset = "0x9511D0", VA = "0x69511D0")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus EventManager_FetchResponse_GetStatus(HandleRef self);

		// Token: 0x06000713 RID: 1811
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x9512B8", Offset = "0x9512B8", VA = "0x69512B8")]
		[PreserveSig]
		internal static extern IntPtr EventManager_FetchResponse_GetData(HandleRef self);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x06000715 RID: 1813
		[Token(Token = "0x20000AE")]
		internal delegate void FetchAllCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x06000719 RID: 1817
		[Token(Token = "0x20000AF")]
		internal delegate void FetchCallback(IntPtr arg0, IntPtr arg1);
	}
}
