using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001D5 RID: 469
	[Token(Token = "0x2000153")]
	internal class NativeAchievement : BaseReferenceHolder
	{
		// Token: 0x06000C18 RID: 3096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x452D34", Offset = "0x452D34", VA = "0x6452D34")]
		internal NativeAchievement(IntPtr selfPointer)
		{
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x459FF4", Offset = "0x459FF4", VA = "0x6459FF4")]
		internal uint CurrentSteps()
		{
			return 0U;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x45A020", Offset = "0x45A020", VA = "0x645A020")]
		internal string Description()
		{
			return null;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x45A0DC", Offset = "0x45A0DC", VA = "0x645A0DC")]
		internal string Id()
		{
			return null;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x45A198", Offset = "0x45A198", VA = "0x645A198")]
		internal string Name()
		{
			return null;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x45A254", Offset = "0x45A254", VA = "0x645A254")]
		internal Types.AchievementState State()
		{
			return (Types.AchievementState)0;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x45A280", Offset = "0x45A280", VA = "0x645A280")]
		internal uint TotalSteps()
		{
			return 0U;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x45A2AC", Offset = "0x45A2AC", VA = "0x645A2AC")]
		internal Types.AchievementType Type()
		{
			return (Types.AchievementType)0;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x45A2D8", Offset = "0x45A2D8", VA = "0x645A2D8")]
		internal ulong LastModifiedTime()
		{
			return 0UL;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x45A338", Offset = "0x45A338", VA = "0x645A338")]
		internal ulong getXP()
		{
			return 0UL;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x45A364", Offset = "0x45A364", VA = "0x645A364")]
		internal string getRevealedImageUrl()
		{
			return null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x45A420", Offset = "0x45A420", VA = "0x645A420")]
		internal string getUnlockedImageUrl()
		{
			return null;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x45A4DC", Offset = "0x45A4DC", VA = "0x645A4DC", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x45A4EC", Offset = "0x45A4EC", VA = "0x645A4EC")]
		internal GooglePlayGames.BasicApi.Achievement AsAchievement()
		{
			return null;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x45A8B8", Offset = "0x45A8B8", VA = "0x645A8B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185E9C", Offset = "0x185E9C")]
		private UIntPtr <Description>m__0(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x45A8FC", Offset = "0x45A8FC", VA = "0x645A8FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185EAC", Offset = "0x185EAC")]
		private UIntPtr <Id>m__1(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x45A940", Offset = "0x45A940", VA = "0x645A940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185EBC", Offset = "0x185EBC")]
		private UIntPtr <Name>m__2(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x45A984", Offset = "0x45A984", VA = "0x645A984")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185ECC", Offset = "0x185ECC")]
		private UIntPtr <getRevealedImageUrl>m__3(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x45A9C8", Offset = "0x45A9C8", VA = "0x645A9C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185EDC", Offset = "0x185EDC")]
		private UIntPtr <getUnlockedImageUrl>m__4(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000400")]
		private const ulong MinusOne = 18446744073709551615UL;
	}
}
