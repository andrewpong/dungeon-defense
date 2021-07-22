using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x200013C")]
	internal class AchievementManager
	{
		// Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x451C90", Offset = "0x451C90", VA = "0x6451C90")]
		internal AchievementManager(GameServices services)
		{
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x451D08", Offset = "0x451D08", VA = "0x6451D08")]
		internal void ShowAllUI(Action<CommonErrorStatus.UIStatus> callback)
		{
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x451EEC", Offset = "0x451EEC", VA = "0x6451EEC")]
		internal void FetchAll(Action<AchievementManager.FetchAllResponse> callback)
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x451B48", Offset = "0x451B48", VA = "0x6451B48")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18579C", Offset = "0x18579C")]
		private static void InternalFetchAllCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x4524F0", Offset = "0x4524F0", VA = "0x64524F0")]
		internal void Fetch(string achId, Action<AchievementManager.FetchResponse> callback)
		{
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x451BEC", Offset = "0x451BEC", VA = "0x6451BEC")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x185814", Offset = "0x185814")]
		private static void InternalFetchCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x4526F4", Offset = "0x4526F4", VA = "0x64526F4")]
		internal void Increment(string achievementId, uint numSteps)
		{
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x4527A4", Offset = "0x4527A4", VA = "0x64527A4")]
		internal void SetStepsAtLeast(string achivementId, uint numSteps)
		{
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x452854", Offset = "0x452854", VA = "0x6452854")]
		internal void Reveal(string achievementId)
		{
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x4528F4", Offset = "0x4528F4", VA = "0x64528F4")]
		internal void Unlock(string achievementId)
		{
		}

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly GameServices mServices;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180EB0", Offset = "0x180EB0")]
		private static AchievementManager.ShowAllUICallback <>f__mg$cache0;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180EC0", Offset = "0x180EC0")]
		private static Func<IntPtr, AchievementManager.FetchAllResponse> <>f__mg$cache1;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180ED0", Offset = "0x180ED0")]
		private static AchievementManager.FetchAllCallback <>f__mg$cache2;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180EE0", Offset = "0x180EE0")]
		private static Func<IntPtr, AchievementManager.FetchResponse> <>f__mg$cache3;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180EF0", Offset = "0x180EF0")]
		private static AchievementManager.FetchCallback <>f__mg$cache4;

		// Token: 0x020001B6 RID: 438
		[Token(Token = "0x200013D")]
		internal class FetchResponse : BaseReferenceHolder
		{
			// Token: 0x06000B5E RID: 2910 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x452F84", Offset = "0x452F84", VA = "0x6452F84")]
			internal FetchResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000B5F RID: 2911 RVA: 0x000054C0 File Offset: 0x000036C0
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x45300C", Offset = "0x45300C", VA = "0x645300C")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000B60 RID: 2912 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x453038", Offset = "0x453038", VA = "0x6453038")]
			internal NativeAchievement Achievement()
			{
				return null;
			}

			// Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x4530CC", Offset = "0x4530CC", VA = "0x64530CC", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000B62 RID: 2914 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x4530DC", Offset = "0x4530DC", VA = "0x64530DC")]
			internal static AchievementManager.FetchResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		// Token: 0x020001B7 RID: 439
		[Token(Token = "0x200013E")]
		internal class FetchAllResponse : BaseReferenceHolder, IEnumerable<NativeAchievement>, IEnumerable
		{
			// Token: 0x06000B63 RID: 2915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x452994", Offset = "0x452994", VA = "0x6452994")]
			internal FetchAllResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000B64 RID: 2916 RVA: 0x000054D8 File Offset: 0x000036D8
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x452AEC", Offset = "0x452AEC", VA = "0x6452AEC")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return (CommonErrorStatus.ResponseStatus)0;
			}

			// Token: 0x06000B65 RID: 2917 RVA: 0x000054F0 File Offset: 0x000036F0
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x452BD8", Offset = "0x452BD8", VA = "0x6452BD8")]
			internal UIntPtr Length()
			{
				return 0;
			}

			// Token: 0x06000B66 RID: 2918 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x452C04", Offset = "0x452C04", VA = "0x6452C04")]
			private NativeAchievement GetElement(UIntPtr index)
			{
				return null;
			}

			// Token: 0x06000B67 RID: 2919 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x452DBC", Offset = "0x452DBC", VA = "0x6452DBC", Slot = "6")]
			public IEnumerator<NativeAchievement> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000B68 RID: 2920 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x452EB8", Offset = "0x452EB8", VA = "0x6452EB8", Slot = "7")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000B69 RID: 2921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x452EBC", Offset = "0x452EBC", VA = "0x6452EBC", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000B6A RID: 2922 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x452ECC", Offset = "0x452ECC", VA = "0x6452ECC")]
			internal static AchievementManager.FetchAllResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			// Token: 0x06000B6B RID: 2923 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x452F80", Offset = "0x452F80", VA = "0x6452F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18588C", Offset = "0x18588C")]
			private NativeAchievement <GetEnumerator>m__0(UIntPtr index)
			{
				return null;
			}
		}
	}
}
