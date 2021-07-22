using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x2000150")]
	internal class FetchScoreSummaryResponse : BaseReferenceHolder
	{
		// Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x4554E8", Offset = "0x4554E8", VA = "0x64554E8")]
		internal FetchScoreSummaryResponse(IntPtr selfPointer)
		{
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x455570", Offset = "0x455570", VA = "0x6455570", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x455580", Offset = "0x455580", VA = "0x6455580")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return (CommonErrorStatus.ResponseStatus)0;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x4555AC", Offset = "0x4555AC", VA = "0x64555AC")]
		internal NativeScoreSummary GetScoreSummary()
		{
			return null;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x4555E0", Offset = "0x4555E0", VA = "0x64555E0")]
		internal static FetchScoreSummaryResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
