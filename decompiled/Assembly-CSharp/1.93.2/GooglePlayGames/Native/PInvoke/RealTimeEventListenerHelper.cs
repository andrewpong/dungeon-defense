using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001FF RID: 511
	[Token(Token = "0x2000179")]
	internal class RealTimeEventListenerHelper : BaseReferenceHolder
	{
		// Token: 0x06000D6F RID: 3439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x4823C4", Offset = "0x4823C4", VA = "0x64823C4")]
		internal RealTimeEventListenerHelper(IntPtr selfPointer)
		{
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x482450", Offset = "0x482450", VA = "0x6482450", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x482460", Offset = "0x482460", VA = "0x6482460")]
		internal RealTimeEventListenerHelper SetOnRoomStatusChangedCallback(Action<NativeRealTimeRoom> callback)
		{
			return null;
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x481B34", Offset = "0x481B34", VA = "0x6481B34")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186644", Offset = "0x186644")]
		internal static void InternalOnRoomStatusChangedCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x482670", Offset = "0x482670", VA = "0x6482670")]
		internal RealTimeEventListenerHelper SetOnRoomConnectedSetChangedCallback(Action<NativeRealTimeRoom> callback)
		{
			return null;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x481BE0", Offset = "0x481BE0", VA = "0x6481BE0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1866BC", Offset = "0x1866BC")]
		internal static void InternalOnRoomConnectedSetChangedCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x482780", Offset = "0x482780", VA = "0x6482780")]
		internal RealTimeEventListenerHelper SetOnP2PConnectedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant> callback)
		{
			return null;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x481C8C", Offset = "0x481C8C", VA = "0x6481C8C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186734", Offset = "0x186734")]
		internal static void InternalOnP2PConnectedCallback(IntPtr room, IntPtr participant, IntPtr data)
		{
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x482E00", Offset = "0x482E00", VA = "0x6482E00")]
		internal RealTimeEventListenerHelper SetOnP2PDisconnectedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant> callback)
		{
			return null;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x481D08", Offset = "0x481D08", VA = "0x6481D08")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1867AC", Offset = "0x1867AC")]
		internal static void InternalOnP2PDisconnectedCallback(IntPtr room, IntPtr participant, IntPtr data)
		{
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x482F40", Offset = "0x482F40", VA = "0x6482F40")]
		internal RealTimeEventListenerHelper SetOnParticipantStatusChangedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant> callback)
		{
			return null;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x481D84", Offset = "0x481D84", VA = "0x6481D84")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186824", Offset = "0x186824")]
		internal static void InternalOnParticipantStatusChangedCallback(IntPtr room, IntPtr participant, IntPtr data)
		{
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x4828C0", Offset = "0x4828C0", VA = "0x64828C0")]
		internal static void PerformRoomAndParticipantCallback(string callbackName, IntPtr room, IntPtr participant, IntPtr data)
		{
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x483080", Offset = "0x483080", VA = "0x6483080")]
		internal RealTimeEventListenerHelper SetOnDataReceivedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant, byte[], bool> callback)
		{
			return null;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x481E00", Offset = "0x481E00", VA = "0x6481E00")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18689C", Offset = "0x18689C")]
		internal static void InternalOnDataReceived(IntPtr room, IntPtr participant, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData)
		{
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x482574", Offset = "0x482574", VA = "0x6482574")]
		private static IntPtr ToCallbackPointer(Action<NativeRealTimeRoom> callback)
		{
			return 0;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x483284", Offset = "0x483284", VA = "0x6483284")]
		internal static RealTimeEventListenerHelper Create()
		{
			return null;
		}

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181160", Offset = "0x181160")]
		private static RealTimeEventListenerHelper.OnRoomStatusChangedCallback <>f__mg$cache0;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181170", Offset = "0x181170")]
		private static RealTimeEventListenerHelper.OnRoomConnectedSetChangedCallback <>f__mg$cache1;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181180", Offset = "0x181180")]
		private static RealTimeEventListenerHelper.OnP2PConnectedCallback <>f__mg$cache2;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181190", Offset = "0x181190")]
		private static RealTimeEventListenerHelper.OnP2PDisconnectedCallback <>f__mg$cache3;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811A0", Offset = "0x1811A0")]
		private static RealTimeEventListenerHelper.OnParticipantStatusChangedCallback <>f__mg$cache4;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811B0", Offset = "0x1811B0")]
		private static RealTimeEventListenerHelper.OnDataReceivedCallback <>f__mg$cache5;

		// Token: 0x02000200 RID: 512
		[Token(Token = "0x200033B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD20", Offset = "0x17FD20")]
		private sealed class <ToCallbackPointer>c__AnonStorey0
		{
			// Token: 0x06000D80 RID: 3456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600158A")]
			[Address(RVA = "0x48327C", Offset = "0x48327C", VA = "0x648327C")]
			public <ToCallbackPointer>c__AnonStorey0()
			{
			}

			// Token: 0x06000D81 RID: 3457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600158B")]
			[Address(RVA = "0x4832FC", Offset = "0x4832FC", VA = "0x64832FC")]
			internal void <>m__0(IntPtr result)
			{
			}

			// Token: 0x04000581 RID: 1409
			[Token(Token = "0x4001421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Action<NativeRealTimeRoom> callback;
		}
	}
}
