using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x200015A")]
	internal class NativeLeaderboard : BaseReferenceHolder
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x477188", Offset = "0x477188", VA = "0x6477188")]
		internal NativeLeaderboard(IntPtr selfPtr)
		{
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x477214", Offset = "0x477214", VA = "0x6477214", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x477224", Offset = "0x477224", VA = "0x6477224")]
		internal string Title()
		{
			return null;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x4772DC", Offset = "0x4772DC", VA = "0x64772DC")]
		internal static NativeLeaderboard FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x477390", Offset = "0x477390", VA = "0x6477390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1860AC", Offset = "0x1860AC")]
		private UIntPtr <Title>m__0(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}
	}
}
