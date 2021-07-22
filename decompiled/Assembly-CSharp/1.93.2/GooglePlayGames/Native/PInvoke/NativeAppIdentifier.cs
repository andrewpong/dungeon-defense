using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x2000154")]
	internal class NativeAppIdentifier : BaseReferenceHolder
	{
		// Token: 0x06000C2B RID: 3115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x45AA0C", Offset = "0x45AA0C", VA = "0x645AA0C")]
		internal NativeAppIdentifier(IntPtr pointer)
		{
		}

		// Token: 0x06000C2C RID: 3116
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x45AA98", Offset = "0x45AA98", VA = "0x645AA98")]
		[PreserveSig]
		internal static extern IntPtr NearbyUtils_ConstructAppIdentifier(string appId);

		// Token: 0x06000C2D RID: 3117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x45ABA0", Offset = "0x45ABA0", VA = "0x645ABA0")]
		internal string Id()
		{
			return null;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x45AC5C", Offset = "0x45AC5C", VA = "0x645AC5C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x45AC6C", Offset = "0x45AC6C", VA = "0x645AC6C")]
		internal static NativeAppIdentifier FromString(string appId)
		{
			return null;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x45ACE8", Offset = "0x45ACE8", VA = "0x645ACE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185EEC", Offset = "0x185EEC")]
		private UIntPtr <Id>m__0(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}
	}
}
