using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x2000141")]
	internal abstract class BaseReferenceHolder : IDisposable
	{
		// Token: 0x06000B77 RID: 2935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x452A1C", Offset = "0x452A1C", VA = "0x6452A1C")]
		public BaseReferenceHolder(IntPtr pointer)
		{
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x45377C", Offset = "0x45377C", VA = "0x645377C")]
		protected bool IsDisposed()
		{
			return default(bool);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x452B18", Offset = "0x452B18", VA = "0x6452B18")]
		protected HandleRef SelfPtr()
		{
			return default(HandleRef);
		}

		// Token: 0x06000B7A RID: 2938
		[Token(Token = "0x6000A50")]
		protected abstract void CallDispose(HandleRef selfPointer);

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x45380C", Offset = "0x45380C", VA = "0x645380C", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x4409BC", Offset = "0x4409BC", VA = "0x64409BC", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x4539F0", Offset = "0x4539F0", VA = "0x64539F0")]
		internal IntPtr AsPointer()
		{
			return 0;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x453874", Offset = "0x453874", VA = "0x6453874")]
		private void Dispose(bool fromFinalizer)
		{
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x44AF60", Offset = "0x44AF60", VA = "0x644AF60")]
		internal void ReferToMe()
		{
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x44FC84", Offset = "0x44FC84", VA = "0x644FC84")]
		internal void ForgetMe()
		{
		}

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<HandleRef, BaseReferenceHolder> _refs;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private HandleRef mSelfPointer;
	}
}
