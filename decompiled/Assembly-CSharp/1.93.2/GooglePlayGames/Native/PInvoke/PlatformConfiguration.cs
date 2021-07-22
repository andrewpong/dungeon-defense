using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x2000172")]
	internal abstract class PlatformConfiguration : BaseReferenceHolder
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x47FB68", Offset = "0x47FB68", VA = "0x647FB68")]
		protected PlatformConfiguration(IntPtr selfPointer)
		{
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x47FBF4", Offset = "0x47FBF4", VA = "0x647FBF4")]
		internal HandleRef AsHandle()
		{
			return default(HandleRef);
		}
	}
}
