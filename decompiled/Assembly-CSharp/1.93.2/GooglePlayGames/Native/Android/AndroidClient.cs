using System;
using Com.Google.Android.Gms.Common.Api;
using Com.Google.Android.Gms.Games.Stats;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Native.Android
{
	// Token: 0x0200021C RID: 540
	[Token(Token = "0x2000194")]
	internal class AndroidClient : IClientImpl
	{
		// Token: 0x06000E5D RID: 3677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x94778C", Offset = "0x94778C", VA = "0x694778C")]
		public AndroidClient()
		{
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D10")]
		[Address(RVA = "0x947794", Offset = "0x947794", VA = "0x6947794", Slot = "4")]
		public PlatformConfiguration CreatePlatformConfiguration(PlayGamesClientConfiguration clientConfig)
		{
			return null;
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x947A2C", Offset = "0x947A2C", VA = "0x6947A2C", Slot = "5")]
		public TokenClient CreateTokenClient(bool reset)
		{
			return null;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x947B38", Offset = "0x947B38", VA = "0x6947B38")]
		private static void LaunchBridgeIntent(IntPtr bridgedIntent)
		{
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x948170", Offset = "0x948170", VA = "0x6948170")]
		public void Signout()
		{
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x948240", Offset = "0x948240", VA = "0x6948240", Slot = "6")]
		public void GetPlayerStats(IntPtr apiClient, Action<CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback)
		{
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x948520", Offset = "0x948520", VA = "0x6948520", Slot = "7")]
		public void SetGravityForPopups(IntPtr apiClient, Gravity gravity)
		{
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x9485A4", Offset = "0x9485A4", VA = "0x69485A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18737C", Offset = "0x18737C")]
		private static void <CreatePlatformConfiguration>m__0(IntPtr intent)
		{
		}

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x400045C")]
		internal const string BridgeActivityClass = "com.google.games.bridge.NativeBridgeActivity";

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x400045D")]
		private const string LaunchBridgeMethod = "launchBridgeIntent";

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x400045E")]
		private const string LaunchBridgeSignature = "(Landroid/app/Activity;Landroid/content/Intent;)V";

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x8")]
		private TokenClient tokenClient;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaObject invisible;

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181510", Offset = "0x181510")]
		private static Action<IntPtr> <>f__am$cache0;

		// Token: 0x0200021D RID: 541
		[Token(Token = "0x2000195")]
		private class StatsResultCallback : ResultCallbackProxy<Stats_LoadPlayerStatsResultObject>
		{
			// Token: 0x06000E65 RID: 3685 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D17")]
			[Address(RVA = "0x9484B4", Offset = "0x9484B4", VA = "0x69484B4")]
			public StatsResultCallback(Action<int, Com.Google.Android.Gms.Games.Stats.PlayerStats> callback)
			{
			}

			// Token: 0x06000E66 RID: 3686 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x948E28", Offset = "0x948E28", VA = "0x6948E28", Slot = "10")]
			public override void OnResult(Stats_LoadPlayerStatsResultObject arg_Result_1)
			{
			}

			// Token: 0x040005C4 RID: 1476
			[Token(Token = "0x4000462")]
			[FieldOffset(Offset = "0x10")]
			private Action<int, Com.Google.Android.Gms.Games.Stats.PlayerStats> callback;
		}

		// Token: 0x0200021E RID: 542
		[Token(Token = "0x200033D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD40", Offset = "0x17FD40")]
		private sealed class <GetPlayerStats>c__AnonStorey1
		{
			// Token: 0x06000E67 RID: 3687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600158E")]
			[Address(RVA = "0x9484AC", Offset = "0x9484AC", VA = "0x69484AC")]
			public <GetPlayerStats>c__AnonStorey1()
			{
			}

			// Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600158F")]
			[Address(RVA = "0x948714", Offset = "0x948714", VA = "0x6948714")]
			internal void <>m__0(int result, Com.Google.Android.Gms.Games.Stats.PlayerStats stats)
			{
			}

			// Token: 0x040005C5 RID: 1477
			[Token(Token = "0x4001424")]
			[FieldOffset(Offset = "0x8")]
			internal Action<CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback;
		}

		// Token: 0x0200021F RID: 543
		[Token(Token = "0x200033E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FD50", Offset = "0x17FD50")]
		private sealed class <CreatePlatformConfiguration>c__AnonStorey0
		{
			// Token: 0x06000E69 RID: 3689 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001590")]
			[Address(RVA = "0x9486A4", Offset = "0x9486A4", VA = "0x69486A4")]
			public <CreatePlatformConfiguration>c__AnonStorey0()
			{
			}

			// Token: 0x06000E6A RID: 3690 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001591")]
			[Address(RVA = "0x9486AC", Offset = "0x9486AC", VA = "0x69486AC")]
			internal void <>m__0()
			{
			}

			// Token: 0x040005C6 RID: 1478
			[Token(Token = "0x4001425")]
			[FieldOffset(Offset = "0x8")]
			internal IntPtr intentRef;
		}
	}
}
