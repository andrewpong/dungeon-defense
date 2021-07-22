using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000202")]
	public class LightningThreadState
	{
		// Token: 0x06000FD5 RID: 4053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x2DFDD0", Offset = "0x2DFDD0", VA = "0x62DFDD0")]
		public LightningThreadState()
		{
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x2E9660", Offset = "0x2E9660", VA = "0x62E9660")]
		private void BackgroundThreadMethod()
		{
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x2E03A8", Offset = "0x2E03A8", VA = "0x62E03A8")]
		public void UpdateMainThreadActions()
		{
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x2E99EC", Offset = "0x2E99EC", VA = "0x62E99EC")]
		public void AddActionForMainThread(Action a, bool waitForAction = false)
		{
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x2E9B54", Offset = "0x2E9B54", VA = "0x62E9B54")]
		public void AddActionForBackgroundThread(Action a)
		{
		}

		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x8")]
		private Thread lightningThread;

		// Token: 0x0400089E RID: 2206
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0xC")]
		private AutoResetEvent lightningThreadEvent;

		// Token: 0x0400089F RID: 2207
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x10")]
		private readonly Queue<Action> actionsForBackgroundThread;

		// Token: 0x040008A0 RID: 2208
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x14")]
		private readonly Queue<KeyValuePair<Action, ManualResetEvent>> actionsForMainThread;

		// Token: 0x040008A1 RID: 2209
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x18")]
		public bool Running;
	}
}
