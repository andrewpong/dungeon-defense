using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Multiplayer;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x200015D")]
	internal class NativePlayer : BaseReferenceHolder
	{
		// Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x477E6C", Offset = "0x477E6C", VA = "0x6477E6C")]
		internal NativePlayer(IntPtr selfPointer)
		{
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x477EF8", Offset = "0x477EF8", VA = "0x6477EF8")]
		internal string Id()
		{
			return null;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x477FB0", Offset = "0x477FB0", VA = "0x6477FB0")]
		internal string Name()
		{
			return null;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x478068", Offset = "0x478068", VA = "0x6478068")]
		internal string AvatarURL()
		{
			return null;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x478120", Offset = "0x478120", VA = "0x6478120", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x478130", Offset = "0x478130", VA = "0x6478130")]
		internal Player AsPlayer()
		{
			return null;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x4781E0", Offset = "0x4781E0", VA = "0x64781E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1861AC", Offset = "0x1861AC")]
		private UIntPtr <Id>m__0(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x478228", Offset = "0x478228", VA = "0x6478228")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1861BC", Offset = "0x1861BC")]
		private UIntPtr <Name>m__1(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x478270", Offset = "0x478270", VA = "0x6478270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1861CC", Offset = "0x1861CC")]
		private UIntPtr <AvatarURL>m__2(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}
	}
}
