using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x200015B")]
	internal class NativeMessageListenerHelper : BaseReferenceHolder
	{
		// Token: 0x06000C66 RID: 3174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x4777DC", Offset = "0x4777DC", VA = "0x64777DC")]
		internal NativeMessageListenerHelper()
		{
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x477870", Offset = "0x477870", VA = "0x6477870", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x477880", Offset = "0x477880", VA = "0x6477880")]
		internal void SetOnMessageReceivedCallback(NativeMessageListenerHelper.OnMessageReceived callback)
		{
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x4773D8", Offset = "0x4773D8", VA = "0x64773D8")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1860BC", Offset = "0x1860BC")]
		private static void InternalOnMessageReceivedCallback(long id, string name, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData)
		{
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x477C48", Offset = "0x477C48", VA = "0x6477C48")]
		internal void SetOnDisconnectedCallback(Action<long, string> callback)
		{
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x477600", Offset = "0x477600", VA = "0x6477600")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186134", Offset = "0x186134")]
		private static void InternalOnDisconnectedCallback(long id, string lostEndpointId, IntPtr userData)
		{
		}

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181060", Offset = "0x181060")]
		private static MessageListenerHelper.OnMessageReceivedCallback <>f__mg$cache0;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181070", Offset = "0x181070")]
		private static MessageListenerHelper.OnDisconnectedCallback <>f__mg$cache1;

		// Token: 0x020001DE RID: 478
		// (Invoke) Token: 0x06000C6D RID: 3181
		[Token(Token = "0x200015C")]
		internal delegate void OnMessageReceived(long localClientId, string remoteEndpointId, byte[] data, bool isReliable);
	}
}
