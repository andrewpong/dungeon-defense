using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x200008F")]
	internal static class AchievementManager
	{
		// Token: 0x0600069B RID: 1691
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x94A760", Offset = "0x94A760", VA = "0x694A760")]
		[PreserveSig]
		internal static extern void AchievementManager_FetchAll(HandleRef self, Types.DataSource data_source, AchievementManager.FetchAllCallback callback, IntPtr callback_arg);

		// Token: 0x0600069C RID: 1692
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x94A860", Offset = "0x94A860", VA = "0x694A860")]
		[PreserveSig]
		internal static extern void AchievementManager_Reveal(HandleRef self, string achievement_id);

		// Token: 0x0600069D RID: 1693
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x94A998", Offset = "0x94A998", VA = "0x694A998")]
		[PreserveSig]
		internal static extern void AchievementManager_Unlock(HandleRef self, string achievement_id);

		// Token: 0x0600069E RID: 1694
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x94AAD0", Offset = "0x94AAD0", VA = "0x694AAD0")]
		[PreserveSig]
		internal static extern void AchievementManager_ShowAllUI(HandleRef self, AchievementManager.ShowAllUICallback callback, IntPtr callback_arg);

		// Token: 0x0600069F RID: 1695
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x94ABD0", Offset = "0x94ABD0", VA = "0x694ABD0")]
		[PreserveSig]
		internal static extern void AchievementManager_SetStepsAtLeast(HandleRef self, string achievement_id, uint steps);

		// Token: 0x060006A0 RID: 1696
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x94ACE0", Offset = "0x94ACE0", VA = "0x694ACE0")]
		[PreserveSig]
		internal static extern void AchievementManager_Increment(HandleRef self, string achievement_id, uint steps);

		// Token: 0x060006A1 RID: 1697
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x94ADF0", Offset = "0x94ADF0", VA = "0x694ADF0")]
		[PreserveSig]
		internal static extern void AchievementManager_Fetch(HandleRef self, Types.DataSource data_source, string achievement_id, AchievementManager.FetchCallback callback, IntPtr callback_arg);

		// Token: 0x060006A2 RID: 1698
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x94AF48", Offset = "0x94AF48", VA = "0x694AF48")]
		[PreserveSig]
		internal static extern void AchievementManager_FetchAllResponse_Dispose(HandleRef self);

		// Token: 0x060006A3 RID: 1699
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x94B038", Offset = "0x94B038", VA = "0x694B038")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus AchievementManager_FetchAllResponse_GetStatus(HandleRef self);

		// Token: 0x060006A4 RID: 1700
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x94B128", Offset = "0x94B128", VA = "0x694B128")]
		[PreserveSig]
		internal static extern UIntPtr AchievementManager_FetchAllResponse_GetData_Length(HandleRef self);

		// Token: 0x060006A5 RID: 1701
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x94B220", Offset = "0x94B220", VA = "0x694B220")]
		[PreserveSig]
		internal static extern IntPtr AchievementManager_FetchAllResponse_GetData_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x060006A6 RID: 1702
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x94B320", Offset = "0x94B320", VA = "0x694B320")]
		[PreserveSig]
		internal static extern void AchievementManager_FetchResponse_Dispose(HandleRef self);

		// Token: 0x060006A7 RID: 1703
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x94B410", Offset = "0x94B410", VA = "0x694B410")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus AchievementManager_FetchResponse_GetStatus(HandleRef self);

		// Token: 0x060006A8 RID: 1704
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x94B500", Offset = "0x94B500", VA = "0x694B500")]
		[PreserveSig]
		internal static extern IntPtr AchievementManager_FetchResponse_GetData(HandleRef self);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x060006AA RID: 1706
		[Token(Token = "0x2000090")]
		internal delegate void FetchAllCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x060006AE RID: 1710
		[Token(Token = "0x2000091")]
		internal delegate void FetchCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x060006B2 RID: 1714
		[Token(Token = "0x2000092")]
		internal delegate void ShowAllUICallback(CommonErrorStatus.UIStatus arg0, IntPtr arg1);
	}
}
