using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x2000097")]
	internal static class Builder
	{
		// Token: 0x060006C9 RID: 1737
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x94CFD0", Offset = "0x94CFD0", VA = "0x694CFD0")]
		[PreserveSig]
		internal static extern void GameServices_Builder_SetOnAuthActionStarted(HandleRef self, Builder.OnAuthActionStartedCallback callback, IntPtr callback_arg);

		// Token: 0x060006CA RID: 1738
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x94D0D8", Offset = "0x94D0D8", VA = "0x694D0D8")]
		[PreserveSig]
		internal static extern void GameServices_Builder_AddOauthScope(HandleRef self, string scope);

		// Token: 0x060006CB RID: 1739
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x94D1E0", Offset = "0x94D1E0", VA = "0x694D1E0")]
		[PreserveSig]
		internal static extern void GameServices_Builder_SetLogging(HandleRef self, Builder.OnLogCallback callback, IntPtr callback_arg, Types.LogLevel min_level);

		// Token: 0x060006CC RID: 1740
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x94D2E8", Offset = "0x94D2E8", VA = "0x694D2E8")]
		[PreserveSig]
		internal static extern IntPtr GameServices_Builder_Construct();

		// Token: 0x060006CD RID: 1741
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x94D3B8", Offset = "0x94D3B8", VA = "0x694D3B8")]
		[PreserveSig]
		internal static extern void GameServices_Builder_EnableSnapshots(HandleRef self);

		// Token: 0x060006CE RID: 1742
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x94D4A0", Offset = "0x94D4A0", VA = "0x694D4A0")]
		[PreserveSig]
		internal static extern void GameServices_Builder_SetOnLog(HandleRef self, Builder.OnLogCallback callback, IntPtr callback_arg, Types.LogLevel min_level);

		// Token: 0x060006CF RID: 1743
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x94D5A8", Offset = "0x94D5A8", VA = "0x694D5A8")]
		[PreserveSig]
		internal static extern void GameServices_Builder_SetDefaultOnLog(HandleRef self, Types.LogLevel min_level);

		// Token: 0x060006D0 RID: 1744
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x94D698", Offset = "0x94D698", VA = "0x694D698")]
		[PreserveSig]
		internal static extern void GameServices_Builder_SetOnAuthActionFinished(HandleRef self, Builder.OnAuthActionFinishedCallback callback, IntPtr callback_arg);

		// Token: 0x060006D1 RID: 1745
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x94D7A8", Offset = "0x94D7A8", VA = "0x694D7A8")]
		[PreserveSig]
		internal static extern void GameServices_Builder_SetOnTurnBasedMatchEvent(HandleRef self, Builder.OnTurnBasedMatchEventCallback callback, IntPtr callback_arg);

		// Token: 0x060006D2 RID: 1746
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x94D8B8", Offset = "0x94D8B8", VA = "0x694D8B8")]
		[PreserveSig]
		internal static extern void GameServices_Builder_SetOnQuestCompleted(HandleRef self, Builder.OnQuestCompletedCallback callback, IntPtr callback_arg);

		// Token: 0x060006D3 RID: 1747
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x94D9C0", Offset = "0x94D9C0", VA = "0x694D9C0")]
		[PreserveSig]
		internal static extern void GameServices_Builder_SetOnMultiplayerInvitationEvent(HandleRef self, Builder.OnMultiplayerInvitationEventCallback callback, IntPtr callback_arg);

		// Token: 0x060006D4 RID: 1748
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x94DAD8", Offset = "0x94DAD8", VA = "0x694DAD8")]
		[PreserveSig]
		internal static extern void GameServices_Builder_SetShowConnectingPopup(HandleRef self, bool flag);

		// Token: 0x060006D5 RID: 1749
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x94DBD0", Offset = "0x94DBD0", VA = "0x694DBD0")]
		[PreserveSig]
		internal static extern IntPtr GameServices_Builder_Create(HandleRef self, IntPtr platform);

		// Token: 0x060006D6 RID: 1750
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x94DCB8", Offset = "0x94DCB8", VA = "0x694DCB8")]
		[PreserveSig]
		internal static extern void GameServices_Builder_Dispose(HandleRef self);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x060006D8 RID: 1752
		[Token(Token = "0x2000098")]
		internal delegate void OnLogCallback(Types.LogLevel arg0, string arg1, IntPtr arg2);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x060006DC RID: 1756
		[Token(Token = "0x2000099")]
		internal delegate void OnAuthActionStartedCallback(Types.AuthOperation arg0, IntPtr arg1);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x060006E0 RID: 1760
		[Token(Token = "0x200009A")]
		internal delegate void OnAuthActionFinishedCallback(Types.AuthOperation arg0, CommonErrorStatus.AuthStatus arg1, IntPtr arg2);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x060006E4 RID: 1764
		[Token(Token = "0x200009B")]
		internal delegate void OnMultiplayerInvitationEventCallback(Types.MultiplayerEvent arg0, string arg1, IntPtr arg2, IntPtr arg3);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x060006E8 RID: 1768
		[Token(Token = "0x200009C")]
		internal delegate void OnTurnBasedMatchEventCallback(Types.MultiplayerEvent arg0, string arg1, IntPtr arg2, IntPtr arg3);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x060006EC RID: 1772
		[Token(Token = "0x200009D")]
		internal delegate void OnQuestCompletedCallback(IntPtr arg0, IntPtr arg1);
	}
}
