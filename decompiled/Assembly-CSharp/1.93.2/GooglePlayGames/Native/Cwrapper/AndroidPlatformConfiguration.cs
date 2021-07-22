using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x2000093")]
	internal static class AndroidPlatformConfiguration
	{
		// Token: 0x060006B5 RID: 1717
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x94BEF0", Offset = "0x94BEF0", VA = "0x694BEF0")]
		[PreserveSig]
		internal static extern void AndroidPlatformConfiguration_SetOnLaunchedWithSnapshot(HandleRef self, AndroidPlatformConfiguration.OnLaunchedWithSnapshotCallback callback, IntPtr callback_arg);

		// Token: 0x060006B6 RID: 1718
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x94C008", Offset = "0x94C008", VA = "0x694C008")]
		[PreserveSig]
		internal static extern IntPtr AndroidPlatformConfiguration_Construct();

		// Token: 0x060006B7 RID: 1719
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x94C0E0", Offset = "0x94C0E0", VA = "0x694C0E0")]
		[PreserveSig]
		internal static extern void AndroidPlatformConfiguration_SetOptionalIntentHandlerForUI(HandleRef self, AndroidPlatformConfiguration.IntentHandler intent_handler, IntPtr intent_handler_arg);

		// Token: 0x060006B8 RID: 1720
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x94C1F8", Offset = "0x94C1F8", VA = "0x694C1F8")]
		[PreserveSig]
		internal static extern void AndroidPlatformConfiguration_Dispose(HandleRef self);

		// Token: 0x060006B9 RID: 1721
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x94C2E0", Offset = "0x94C2E0", VA = "0x694C2E0")]
		[PreserveSig]
		internal static extern bool AndroidPlatformConfiguration_Valid(HandleRef self);

		// Token: 0x060006BA RID: 1722
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x94C3D0", Offset = "0x94C3D0", VA = "0x694C3D0")]
		[PreserveSig]
		internal static extern void AndroidPlatformConfiguration_SetActivity(HandleRef self, IntPtr android_app_activity);

		// Token: 0x060006BB RID: 1723
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x94C4C8", Offset = "0x94C4C8", VA = "0x694C4C8")]
		[PreserveSig]
		internal static extern void AndroidPlatformConfiguration_SetOnLaunchedWithQuest(HandleRef self, AndroidPlatformConfiguration.OnLaunchedWithQuestCallback callback, IntPtr callback_arg);

		// Token: 0x060006BC RID: 1724
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x94C5D8", Offset = "0x94C5D8", VA = "0x694C5D8")]
		[PreserveSig]
		internal static extern void AndroidPlatformConfiguration_SetOptionalViewForPopups(HandleRef self, IntPtr android_view);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x060006BE RID: 1726
		[Token(Token = "0x2000094")]
		internal delegate void IntentHandler(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x060006C2 RID: 1730
		[Token(Token = "0x2000095")]
		internal delegate void OnLaunchedWithSnapshotCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x060006C6 RID: 1734
		[Token(Token = "0x2000096")]
		internal delegate void OnLaunchedWithQuestCallback(IntPtr arg0, IntPtr arg1);
	}
}
