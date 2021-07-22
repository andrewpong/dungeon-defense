using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x200014E")]
	internal class FetchScorePageResponse : BaseReferenceHolder
	{
		// Token: 0x06000BEE RID: 3054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x455320", Offset = "0x455320", VA = "0x6455320")]
		internal FetchScorePageResponse(IntPtr selfPointer)
		{
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x4553A8", Offset = "0x4553A8", VA = "0x64553A8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x4553D4", Offset = "0x4553D4", VA = "0x64553D4")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return (CommonErrorStatus.ResponseStatus)0;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x455400", Offset = "0x455400", VA = "0x6455400")]
		internal NativeScorePage GetScorePage()
		{
			return null;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x455434", Offset = "0x455434", VA = "0x6455434")]
		internal static FetchScorePageResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
