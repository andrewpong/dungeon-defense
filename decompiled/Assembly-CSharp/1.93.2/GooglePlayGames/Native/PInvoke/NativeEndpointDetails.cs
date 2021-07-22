using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x2000157")]
	internal class NativeEndpointDetails : BaseReferenceHolder
	{
		// Token: 0x06000C44 RID: 3140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x4758D0", Offset = "0x4758D0", VA = "0x64758D0")]
		internal NativeEndpointDetails(IntPtr pointer)
		{
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x47595C", Offset = "0x47595C", VA = "0x647595C")]
		internal string EndpointId()
		{
			return null;
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x475D18", Offset = "0x475D18", VA = "0x6475D18")]
		internal string Name()
		{
			return null;
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x475DD0", Offset = "0x475DD0", VA = "0x6475DD0")]
		internal string ServiceId()
		{
			return null;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x475E88", Offset = "0x475E88", VA = "0x6475E88", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x475E98", Offset = "0x475E98", VA = "0x6475E98")]
		internal EndpointDetails ToDetails()
		{
			return default(EndpointDetails);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x475EFC", Offset = "0x475EFC", VA = "0x6475EFC")]
		internal static NativeEndpointDetails FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x475FB0", Offset = "0x475FB0", VA = "0x6475FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185F4C", Offset = "0x185F4C")]
		private UIntPtr <EndpointId>m__0(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x475FF8", Offset = "0x475FF8", VA = "0x6475FF8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185F5C", Offset = "0x185F5C")]
		private UIntPtr <Name>m__1(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x476040", Offset = "0x476040", VA = "0x6476040")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185F6C", Offset = "0x185F6C")]
		private UIntPtr <ServiceId>m__2(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}
	}
}
