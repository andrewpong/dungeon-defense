using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Android
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000079")]
	internal class AndroidTokenClient : TokenClient
	{
		// Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x93DAA4", Offset = "0x93DAA4", VA = "0x693DAA4")]
		public AndroidTokenClient()
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x93DAAC", Offset = "0x93DAAC", VA = "0x693DAAC")]
		public static AndroidJavaObject CreateInvisibleView()
		{
			return null;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x93DCD0", Offset = "0x93DCD0", VA = "0x693DCD0")]
		public static AndroidJavaObject GetActivity()
		{
			return null;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x93DE64", Offset = "0x93DE64", VA = "0x693DE64", Slot = "9")]
		public void SetRequestAuthCode(bool flag, bool forceRefresh)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x93DE70", Offset = "0x93DE70", VA = "0x693DE70", Slot = "10")]
		public void SetRequestEmail(bool flag)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x93DE78", Offset = "0x93DE78", VA = "0x693DE78", Slot = "11")]
		public void SetRequestIdToken(bool flag)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x93DE80", Offset = "0x93DE80", VA = "0x693DE80", Slot = "12")]
		public void SetWebClientId(string webClientId)
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x93DE88", Offset = "0x93DE88", VA = "0x693DE88", Slot = "15")]
		public void SetHidePopups(bool flag)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x93DE90", Offset = "0x93DE90", VA = "0x693DE90", Slot = "13")]
		public void SetAccountName(string accountName)
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x93DE98", Offset = "0x93DE98", VA = "0x693DE98", Slot = "14")]
		public void AddOauthScopes(params string[] scopes)
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x93DF60", Offset = "0x93DF60", VA = "0x693DF60", Slot = "8")]
		public void Signout()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x93E070", Offset = "0x93E070", VA = "0x693E070", Slot = "4")]
		public string GetEmail()
		{
			return null;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x93E078", Offset = "0x93E078", VA = "0x693E078", Slot = "5")]
		public string GetAuthCode()
		{
			return null;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x93E080", Offset = "0x93E080", VA = "0x693E080", Slot = "6")]
		public string GetIdToken()
		{
			return null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x93E088", Offset = "0x93E088", VA = "0x693E088", Slot = "16")]
		public void FetchTokens(bool silent, Action<int> callback)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x93E1B4", Offset = "0x93E1B4", VA = "0x693E1B4")]
		private void DoFetchToken(bool silent, Action<int> callback)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x93EDC8", Offset = "0x93EDC8", VA = "0x693EDC8", Slot = "7")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x93EEF4", Offset = "0x93EEF4", VA = "0x693EEF4")]
		private void DoGetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x93FA54", Offset = "0x93FA54", VA = "0x693FA54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1855DC", Offset = "0x1855DC")]
		private static void <Signout>m__0()
		{
		}

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x400028F")]
		private const string TokenFragmentClass = "com.google.games.bridge.TokenFragment";

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x8")]
		private bool requestEmail;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x9")]
		private bool requestAuthCode;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0xA")]
		private bool requestIdToken;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0xC")]
		private List<string> oauthScopes;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x10")]
		private string webClientId;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x14")]
		private bool forceRefresh;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x15")]
		private bool hidePopups;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x18")]
		private string accountName;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x1C")]
		private string email;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x20")]
		private string authCode;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x24")]
		private string idToken;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180DE0", Offset = "0x180DE0")]
		private static Action <>f__am$cache0;

		// Token: 0x02000092 RID: 146
		[Token(Token = "0x200007A")]
		private class ResultCallbackProxy : AndroidJavaProxy
		{
			// Token: 0x060005BD RID: 1469 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x93ED2C", Offset = "0x93ED2C", VA = "0x693ED2C")]
			public ResultCallbackProxy(Action<AndroidJavaObject> callback)
			{
			}

			// Token: 0x060005BE RID: 1470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x93FF5C", Offset = "0x93FF5C", VA = "0x693FF5C")]
			public void onResult(AndroidJavaObject tokenResult)
			{
			}

			// Token: 0x04000307 RID: 775
			[Token(Token = "0x400029C")]
			[FieldOffset(Offset = "0x10")]
			private Action<AndroidJavaObject> mCallback;
		}

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x20002CD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F730", Offset = "0x17F730")]
		private sealed class <FetchTokens>c__AnonStorey0
		{
			// Token: 0x060005BF RID: 1471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001492")]
			[Address(RVA = "0x93E1AC", Offset = "0x93E1AC", VA = "0x693E1AC")]
			public <FetchTokens>c__AnonStorey0()
			{
			}

			// Token: 0x060005C0 RID: 1472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001493")]
			[Address(RVA = "0x93FEDC", Offset = "0x93FEDC", VA = "0x693FEDC")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000308 RID: 776
			[Token(Token = "0x400132D")]
			[FieldOffset(Offset = "0x8")]
			internal bool silent;

			// Token: 0x04000309 RID: 777
			[Token(Token = "0x400132E")]
			[FieldOffset(Offset = "0xC")]
			internal Action<int> callback;

			// Token: 0x0400030A RID: 778
			[Token(Token = "0x400132F")]
			[FieldOffset(Offset = "0x10")]
			internal AndroidTokenClient $this;
		}

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x20002CE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F740", Offset = "0x17F740")]
		private sealed class <DoFetchToken>c__AnonStorey1
		{
			// Token: 0x060005C1 RID: 1473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001494")]
			[Address(RVA = "0x93ED24", Offset = "0x93ED24", VA = "0x693ED24")]
			public <DoFetchToken>c__AnonStorey1()
			{
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001495")]
			[Address(RVA = "0x93FBC8", Offset = "0x93FBC8", VA = "0x693FBC8")]
			internal void <>m__0(AndroidJavaObject tokenResult)
			{
			}

			// Token: 0x0400030B RID: 779
			[Token(Token = "0x4001330")]
			[FieldOffset(Offset = "0x8")]
			internal Action<int> callback;

			// Token: 0x0400030C RID: 780
			[Token(Token = "0x4001331")]
			[FieldOffset(Offset = "0xC")]
			internal AndroidTokenClient $this;
		}

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x20002CF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F750", Offset = "0x17F750")]
		private sealed class <GetAnotherServerAuthCode>c__AnonStorey2
		{
			// Token: 0x060005C3 RID: 1475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001496")]
			[Address(RVA = "0x93EEEC", Offset = "0x93EEEC", VA = "0x693EEEC")]
			public <GetAnotherServerAuthCode>c__AnonStorey2()
			{
			}

			// Token: 0x060005C4 RID: 1476 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001497")]
			[Address(RVA = "0x93FF1C", Offset = "0x93FF1C", VA = "0x693FF1C")]
			internal void <>m__0()
			{
			}

			// Token: 0x0400030D RID: 781
			[Token(Token = "0x4001332")]
			[FieldOffset(Offset = "0x8")]
			internal bool reAuthenticateIfNeeded;

			// Token: 0x0400030E RID: 782
			[Token(Token = "0x4001333")]
			[FieldOffset(Offset = "0xC")]
			internal Action<string> callback;

			// Token: 0x0400030F RID: 783
			[Token(Token = "0x4001334")]
			[FieldOffset(Offset = "0x10")]
			internal AndroidTokenClient $this;
		}

		// Token: 0x02000096 RID: 150
		[Token(Token = "0x20002D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F760", Offset = "0x17F760")]
		private sealed class <DoGetAnotherServerAuthCode>c__AnonStorey3
		{
			// Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001498")]
			[Address(RVA = "0x93FA4C", Offset = "0x93FA4C", VA = "0x693FA4C")]
			public <DoGetAnotherServerAuthCode>c__AnonStorey3()
			{
			}

			// Token: 0x060005C6 RID: 1478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001499")]
			[Address(RVA = "0x93FE00", Offset = "0x93FE00", VA = "0x693FE00")]
			internal void <>m__0(AndroidJavaObject tokenResult)
			{
			}

			// Token: 0x04000310 RID: 784
			[Token(Token = "0x4001335")]
			[FieldOffset(Offset = "0x8")]
			internal Action<string> callback;
		}
	}
}
