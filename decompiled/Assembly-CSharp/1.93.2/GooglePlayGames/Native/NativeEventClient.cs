using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000125")]
	internal class NativeEventClient : IEventsClient
	{
		// Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x6DC210", Offset = "0x6DC210", VA = "0x66DC210")]
		internal NativeEventClient(EventManager manager)
		{
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x6E0F30", Offset = "0x6E0F30", VA = "0x66E0F30", Slot = "4")]
		public void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback)
		{
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x6E10D0", Offset = "0x6E10D0", VA = "0x66E10D0", Slot = "5")]
		public void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback)
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x6E1230", Offset = "0x6E1230", VA = "0x66E1230", Slot = "6")]
		public void IncrementEvent(string eventId, uint stepsToIncrement)
		{
		}

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x8")]
		private readonly EventManager mEventManager;

		// Token: 0x02000157 RID: 343
		[Token(Token = "0x20002E6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F880", Offset = "0x17F880")]
		private sealed class <FetchAllEvents>c__AnonStorey0
		{
			// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014C9")]
			[Address(RVA = "0x6E10C8", Offset = "0x6E10C8", VA = "0x66E10C8")]
			public <FetchAllEvents>c__AnonStorey0()
			{
			}

			// Token: 0x060009C4 RID: 2500 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014CA")]
			[Address(RVA = "0x6E12C4", Offset = "0x6E12C4", VA = "0x66E12C4")]
			internal void <>m__0(EventManager.FetchAllResponse response)
			{
			}

			// Token: 0x04000437 RID: 1079
			[Token(Token = "0x400135D")]
			[FieldOffset(Offset = "0x8")]
			internal Action<ResponseStatus, List<IEvent>> callback;
		}

		// Token: 0x02000158 RID: 344
		[Token(Token = "0x20002E7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F890", Offset = "0x17F890")]
		private sealed class <FetchEvent>c__AnonStorey1
		{
			// Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014CB")]
			[Address(RVA = "0x6E1228", Offset = "0x6E1228", VA = "0x66E1228")]
			public <FetchEvent>c__AnonStorey1()
			{
			}

			// Token: 0x060009C6 RID: 2502 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014CC")]
			[Address(RVA = "0x6E142C", Offset = "0x6E142C", VA = "0x66E142C")]
			internal void <>m__0(EventManager.FetchResponse response)
			{
			}

			// Token: 0x04000438 RID: 1080
			[Token(Token = "0x400135E")]
			[FieldOffset(Offset = "0x8")]
			internal Action<ResponseStatus, IEvent> callback;
		}
	}
}
