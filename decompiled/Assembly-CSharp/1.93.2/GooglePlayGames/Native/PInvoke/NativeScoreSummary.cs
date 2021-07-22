using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x2000164")]
	internal class NativeScoreSummary : BaseReferenceHolder
	{
		// Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x479DFC", Offset = "0x479DFC", VA = "0x6479DFC")]
		internal NativeScoreSummary(IntPtr selfPtr)
		{
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x479E88", Offset = "0x479E88", VA = "0x6479E88", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x479E98", Offset = "0x479E98", VA = "0x6479E98")]
		internal ulong ApproximateResults()
		{
			return 0UL;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x479EC8", Offset = "0x479EC8", VA = "0x6479EC8")]
		internal NativeScore LocalUserScore()
		{
			return null;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x479EFC", Offset = "0x479EFC", VA = "0x6479EFC")]
		internal static NativeScoreSummary FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
