using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000C2")]
	internal static class NearbyConnectionsBuilder
	{
		// Token: 0x06000791 RID: 1937
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x95A2B0", Offset = "0x95A2B0", VA = "0x695A2B0")]
		[PreserveSig]
		internal static extern void NearbyConnections_Builder_SetOnInitializationFinished(HandleRef self, NearbyConnectionsBuilder.OnInitializationFinishedCallback callback, IntPtr callback_arg);

		// Token: 0x06000792 RID: 1938
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x95A3C8", Offset = "0x95A3C8", VA = "0x695A3C8")]
		[PreserveSig]
		internal static extern IntPtr NearbyConnections_Builder_Construct();

		// Token: 0x06000793 RID: 1939
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x95A4A0", Offset = "0x95A4A0", VA = "0x695A4A0")]
		[PreserveSig]
		internal static extern void NearbyConnections_Builder_SetClientId(HandleRef self, long client_id);

		// Token: 0x06000794 RID: 1940
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x95A598", Offset = "0x95A598", VA = "0x695A598")]
		[PreserveSig]
		internal static extern void NearbyConnections_Builder_SetOnLog(HandleRef self, NearbyConnectionsBuilder.OnLogCallback callback, IntPtr callback_arg, Types.LogLevel min_level);

		// Token: 0x06000795 RID: 1941
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x95A6A0", Offset = "0x95A6A0", VA = "0x695A6A0")]
		[PreserveSig]
		internal static extern void NearbyConnections_Builder_SetDefaultOnLog(HandleRef self, Types.LogLevel min_level);

		// Token: 0x06000796 RID: 1942
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x95A798", Offset = "0x95A798", VA = "0x695A798")]
		[PreserveSig]
		internal static extern IntPtr NearbyConnections_Builder_Create(HandleRef self, IntPtr platform);

		// Token: 0x06000797 RID: 1943
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x95A888", Offset = "0x95A888", VA = "0x695A888")]
		[PreserveSig]
		internal static extern void NearbyConnections_Builder_Dispose(HandleRef self);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x06000799 RID: 1945
		[Token(Token = "0x20000C3")]
		internal delegate void OnInitializationFinishedCallback(NearbyConnectionsStatus.InitializationStatus arg0, IntPtr arg1);

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x0600079D RID: 1949
		[Token(Token = "0x20000C4")]
		internal delegate void OnLogCallback(Types.LogLevel arg0, string arg1, IntPtr arg2);
	}
}
