using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x0200020E RID: 526
	[Token(Token = "0x2000187")]
	internal class StatsManager
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x4884E4", Offset = "0x4884E4", VA = "0x64884E4")]
		internal StatsManager(GameServices services)
		{
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x48855C", Offset = "0x48855C", VA = "0x648855C")]
		internal void FetchForPlayer(Action<StatsManager.FetchForPlayerResponse> callback)
		{
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x488438", Offset = "0x488438", VA = "0x6488438")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186F04", Offset = "0x186F04")]
		private static void InternalFetchForPlayerCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly GameServices mServices;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181380", Offset = "0x181380")]
		private static Func<IntPtr, StatsManager.FetchForPlayerResponse> <>f__mg$cache0;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181390", Offset = "0x181390")]
		private static StatsManager.FetchForPlayerCallback <>f__mg$cache1;

		// Token: 0x0200020F RID: 527
		[Token(Token = "0x2000188")]
		internal class FetchForPlayerResponse : BaseReferenceHolder
		{
			// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x488744", Offset = "0x488744", VA = "0x6488744")]
			internal FetchForPlayerResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000DF1 RID: 3569 RVA: 0x000064E0 File Offset: 0x000046E0
			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x4887D0", Offset = "0x4887D0", VA = "0x64887D0")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000DF2 RID: 3570 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x488800", Offset = "0x488800", VA = "0x6488800")]
			internal NativePlayerStats PlayerStats()
			{
				return null;
			}

			// Token: 0x06000DF3 RID: 3571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x488898", Offset = "0x488898", VA = "0x6488898", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000DF4 RID: 3572 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x4888A8", Offset = "0x4888A8", VA = "0x64888A8")]
			internal static StatsManager.FetchForPlayerResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}
	}
}
