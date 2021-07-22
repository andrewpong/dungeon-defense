using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x2000158")]
	internal class NativeEndpointDiscoveryListenerHelper : BaseReferenceHolder
	{
		// Token: 0x06000C4E RID: 3150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x47632C", Offset = "0x47632C", VA = "0x647632C")]
		internal NativeEndpointDiscoveryListenerHelper()
		{
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x4763C0", Offset = "0x4763C0", VA = "0x64763C0", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x4763D0", Offset = "0x4763D0", VA = "0x64763D0")]
		internal void SetOnEndpointFound(Action<long, NativeEndpointDetails> callback)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x476088", Offset = "0x476088", VA = "0x6476088")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185F7C", Offset = "0x185F7C")]
		private static void InternalOnEndpointFoundCallback(long id, IntPtr data, IntPtr userData)
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x47658C", Offset = "0x47658C", VA = "0x647658C")]
		internal void SetOnEndpointLostCallback(Action<long, string> callback)
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x476150", Offset = "0x476150", VA = "0x6476150")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185FF4", Offset = "0x185FF4")]
		private static void InternalOnEndpointLostCallback(long id, string lostEndpointId, IntPtr userData)
		{
		}

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181030", Offset = "0x181030")]
		private static Func<IntPtr, NativeEndpointDetails> <>f__mg$cache0;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181040", Offset = "0x181040")]
		private static EndpointDiscoveryListenerHelper.OnEndpointFoundCallback <>f__mg$cache1;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181050", Offset = "0x181050")]
		private static EndpointDiscoveryListenerHelper.OnEndpointLostCallback <>f__mg$cache2;
	}
}
