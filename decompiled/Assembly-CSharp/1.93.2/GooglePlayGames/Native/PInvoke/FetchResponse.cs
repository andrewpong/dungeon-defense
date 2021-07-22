using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x200014F")]
	internal class FetchResponse : BaseReferenceHolder
	{
		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x455158", Offset = "0x455158", VA = "0x6455158")]
		internal FetchResponse(IntPtr selfPointer)
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x4551E0", Offset = "0x4551E0", VA = "0x64551E0", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x45520C", Offset = "0x45520C", VA = "0x645520C")]
		internal NativeLeaderboard Leaderboard()
		{
			return null;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x455240", Offset = "0x455240", VA = "0x6455240")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return (CommonErrorStatus.ResponseStatus)0;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x45526C", Offset = "0x45526C", VA = "0x645526C")]
		internal static FetchResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
