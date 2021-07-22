using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x2000168")]
	internal class NativeStartAdvertisingResult : BaseReferenceHolder
	{
		// Token: 0x06000CD2 RID: 3282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x47AF9C", Offset = "0x47AF9C", VA = "0x647AF9C")]
		internal NativeStartAdvertisingResult(IntPtr pointer)
		{
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00005E98 File Offset: 0x00004098
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x47B028", Offset = "0x47B028", VA = "0x647B028")]
		internal int GetStatus()
		{
			return 0;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x47B058", Offset = "0x47B058", VA = "0x647B058")]
		internal string LocalEndpointName()
		{
			return null;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x47B110", Offset = "0x47B110", VA = "0x647B110", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00005EB0 File Offset: 0x000040B0
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x47B120", Offset = "0x47B120", VA = "0x647B120")]
		internal AdvertisingResult AsResult()
		{
			return default(AdvertisingResult);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x47B29C", Offset = "0x47B29C", VA = "0x647B29C")]
		internal static NativeStartAdvertisingResult FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x47B328", Offset = "0x47B328", VA = "0x647B328")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18626C", Offset = "0x18626C")]
		private UIntPtr <LocalEndpointName>m__0(byte[] out_arg, UIntPtr out_size)
		{
			return 0;
		}
	}
}
