using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000B2")]
	internal static class InternalHooks
	{
		// Token: 0x06000725 RID: 1829
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x9521D8", Offset = "0x9521D8", VA = "0x69521D8")]
		[PreserveSig]
		internal static extern void InternalHooks_ConfigureForUnityPlugin(HandleRef builder, string unity_version);

		// Token: 0x06000726 RID: 1830
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x9522E8", Offset = "0x9522E8", VA = "0x69522E8")]
		[PreserveSig]
		internal static extern IntPtr InternalHooks_GetApiClient(HandleRef services);
	}
}
