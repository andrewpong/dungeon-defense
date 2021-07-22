using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x2000155")]
	internal class NativeConnectionRequest : BaseReferenceHolder
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x45AD2C", Offset = "0x45AD2C", VA = "0x645AD2C")]
		internal NativeConnectionRequest(IntPtr pointer)
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x45ADB4", Offset = "0x45ADB4", VA = "0x645ADB4")]
		internal string RemoteEndpointId()
		{
			return null;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x45AE70", Offset = "0x45AE70", VA = "0x645AE70")]
		internal string RemoteEndpointName()
		{
			return null;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x45AF2C", Offset = "0x45AF2C", VA = "0x645AF2C")]
		internal byte[] Payload()
		{
			return null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x45B000", Offset = "0x45B000", VA = "0x645B000", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x45B010", Offset = "0x45B010", VA = "0x645B010")]
		internal ConnectionRequest AsRequest()
		{
			return default(ConnectionRequest);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x45B0F0", Offset = "0x45B0F0", VA = "0x645B0F0")]
		internal static NativeConnectionRequest FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x45B17C", Offset = "0x45B17C", VA = "0x645B17C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185EFC", Offset = "0x185EFC")]
		private UIntPtr <RemoteEndpointId>m__0(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x45B1C0", Offset = "0x45B1C0", VA = "0x645B1C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185F0C", Offset = "0x185F0C")]
		private UIntPtr <RemoteEndpointName>m__1(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x45B204", Offset = "0x45B204", VA = "0x645B204")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185F1C", Offset = "0x185F1C")]
		private UIntPtr <Payload>m__2(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}
	}
}
