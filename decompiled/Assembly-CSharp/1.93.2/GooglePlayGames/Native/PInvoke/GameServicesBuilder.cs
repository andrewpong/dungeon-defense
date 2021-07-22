using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x200014A")]
	internal class GameServicesBuilder : BaseReferenceHolder
	{
		// Token: 0x06000BC4 RID: 3012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x456374", Offset = "0x456374", VA = "0x6456374")]
		private GameServicesBuilder(IntPtr selfPointer)
		{
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x45642C", Offset = "0x45642C", VA = "0x645642C")]
		internal void SetOnAuthFinishedCallback(GameServicesBuilder.AuthFinishedCallback callback)
		{
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x456564", Offset = "0x456564", VA = "0x6456564")]
		internal void EnableSnapshots()
		{
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x456590", Offset = "0x456590", VA = "0x6456590")]
		internal void AddOauthScope(string scope)
		{
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x4559F0", Offset = "0x4559F0", VA = "0x64559F0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185B24", Offset = "0x185B24")]
		private static void InternalAuthFinishedCallback(Types.AuthOperation op, CommonErrorStatus.AuthStatus status, IntPtr data)
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x4567F0", Offset = "0x4567F0", VA = "0x64567F0")]
		internal void SetOnAuthStartedCallback(GameServicesBuilder.AuthStartedCallback callback)
		{
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x455BAC", Offset = "0x455BAC", VA = "0x6455BAC")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185B9C", Offset = "0x185B9C")]
		private static void InternalAuthStartedCallback(Types.AuthOperation op, IntPtr data)
		{
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x456B34", Offset = "0x456B34", VA = "0x6456B34")]
		internal void SetShowConnectingPopup(bool flag)
		{
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x456B68", Offset = "0x456B68", VA = "0x6456B68", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x455D60", Offset = "0x455D60", VA = "0x6455D60")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185C14", Offset = "0x185C14")]
		private static void InternalOnTurnBasedMatchEventCallback(Types.MultiplayerEvent eventType, string matchId, IntPtr match, IntPtr userData)
		{
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x456B78", Offset = "0x456B78", VA = "0x6456B78")]
		internal void SetOnTurnBasedMatchEventCallback(Action<Types.MultiplayerEvent, string, NativeTurnBasedMatch> callback)
		{
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x45606C", Offset = "0x45606C", VA = "0x645606C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185C8C", Offset = "0x185C8C")]
		private static void InternalOnMultiplayerInvitationEventCallback(Types.MultiplayerEvent eventType, string matchId, IntPtr match, IntPtr userData)
		{
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x456D60", Offset = "0x456D60", VA = "0x6456D60")]
		internal void SetOnMultiplayerInvitationEventCallback(Action<Types.MultiplayerEvent, string, MultiplayerInvitation> callback)
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x456E94", Offset = "0x456E94", VA = "0x6456E94")]
		internal GameServices Build(PlatformConfiguration configRef)
		{
			return null;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x456FF8", Offset = "0x456FF8", VA = "0x6456FF8")]
		internal static GameServicesBuilder Create()
		{
			return null;
		}

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F70", Offset = "0x180F70")]
		private static Builder.OnAuthActionFinishedCallback <>f__mg$cache0;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F80", Offset = "0x180F80")]
		private static Builder.OnAuthActionStartedCallback <>f__mg$cache1;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F90", Offset = "0x180F90")]
		private static Builder.OnTurnBasedMatchEventCallback <>f__mg$cache2;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FA0", Offset = "0x180FA0")]
		private static Builder.OnMultiplayerInvitationEventCallback <>f__mg$cache3;

		// Token: 0x020001CA RID: 458
		// (Invoke) Token: 0x06000BD4 RID: 3028
		[Token(Token = "0x200014B")]
		internal delegate void AuthFinishedCallback(Types.AuthOperation operation, CommonErrorStatus.AuthStatus status);

		// Token: 0x020001CB RID: 459
		// (Invoke) Token: 0x06000BD8 RID: 3032
		[Token(Token = "0x200014C")]
		internal delegate void AuthStartedCallback(Types.AuthOperation operation);
	}
}
