using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000AC")]
	internal static class Event
	{
		// Token: 0x06000702 RID: 1794
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x950130", Offset = "0x950130", VA = "0x6950130")]
		[PreserveSig]
		internal static extern ulong Event_Count(HandleRef self);

		// Token: 0x06000703 RID: 1795
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x950228", Offset = "0x950228", VA = "0x6950228")]
		[PreserveSig]
		internal static extern UIntPtr Event_Description(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000704 RID: 1796
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x950340", Offset = "0x950340", VA = "0x6950340")]
		[PreserveSig]
		internal static extern UIntPtr Event_ImageUrl(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000705 RID: 1797
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x950458", Offset = "0x950458", VA = "0x6950458")]
		[PreserveSig]
		internal static extern Types.EventVisibility Event_Visibility(HandleRef self);

		// Token: 0x06000706 RID: 1798
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x950558", Offset = "0x950558", VA = "0x6950558")]
		[PreserveSig]
		internal static extern UIntPtr Event_Id(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x06000707 RID: 1799
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x950660", Offset = "0x950660", VA = "0x6950660")]
		[PreserveSig]
		internal static extern bool Event_Valid(HandleRef self);

		// Token: 0x06000708 RID: 1800
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x950760", Offset = "0x950760", VA = "0x6950760")]
		[PreserveSig]
		internal static extern void Event_Dispose(HandleRef self);

		// Token: 0x06000709 RID: 1801
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x950858", Offset = "0x950858", VA = "0x6950858")]
		[PreserveSig]
		internal static extern IntPtr Event_Copy(HandleRef self);

		// Token: 0x0600070A RID: 1802
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x950950", Offset = "0x950950", VA = "0x6950950")]
		[PreserveSig]
		internal static extern UIntPtr Event_Name(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);
	}
}
