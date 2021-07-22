using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x2000162")]
	internal class NativeScorePage : BaseReferenceHolder
	{
		// Token: 0x06000CA4 RID: 3236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x479654", Offset = "0x479654", VA = "0x6479654")]
		internal NativeScorePage(IntPtr selfPtr)
		{
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x4796E0", Offset = "0x4796E0", VA = "0x64796E0", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x4796F0", Offset = "0x4796F0", VA = "0x64796F0")]
		internal Types.LeaderboardCollection GetCollection()
		{
			return (Types.LeaderboardCollection)0;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x479720", Offset = "0x479720", VA = "0x6479720")]
		private UIntPtr Length()
		{
			return 0;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x479750", Offset = "0x479750", VA = "0x6479750")]
		private NativeScoreEntry GetElement(UIntPtr index)
		{
			return null;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x479888", Offset = "0x479888", VA = "0x6479888")]
		public IEnumerator<NativeScoreEntry> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x479988", Offset = "0x479988", VA = "0x6479988")]
		internal bool HasNextScorePage()
		{
			return default(bool);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x4799B8", Offset = "0x4799B8", VA = "0x64799B8")]
		internal bool HasPrevScorePage()
		{
			return default(bool);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x4799E8", Offset = "0x4799E8", VA = "0x64799E8")]
		internal NativeScorePageToken GetNextScorePageToken()
		{
			return null;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x479B0C", Offset = "0x479B0C", VA = "0x6479B0C")]
		internal NativeScorePageToken GetPreviousScorePageToken()
		{
			return null;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x479BA4", Offset = "0x479BA4", VA = "0x6479BA4")]
		internal bool Valid()
		{
			return default(bool);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x479BD4", Offset = "0x479BD4", VA = "0x6479BD4")]
		internal Types.LeaderboardTimeSpan GetTimeSpan()
		{
			return (Types.LeaderboardTimeSpan)0;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x479C04", Offset = "0x479C04", VA = "0x6479C04")]
		internal Types.LeaderboardStart GetStart()
		{
			return (Types.LeaderboardStart)0;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x479C34", Offset = "0x479C34", VA = "0x6479C34")]
		internal string GetLeaderboardId()
		{
			return null;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x479CEC", Offset = "0x479CEC", VA = "0x6479CEC")]
		internal static NativeScorePage FromPointer(IntPtr pointer)
		{
			return null;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x479DA0", Offset = "0x479DA0", VA = "0x6479DA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18621C", Offset = "0x18621C")]
		private NativeScoreEntry <GetEnumerator>m__0(UIntPtr index)
		{
			return null;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x479DA4", Offset = "0x479DA4", VA = "0x6479DA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18622C", Offset = "0x18622C")]
		private UIntPtr <GetLeaderboardId>m__1(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}
	}
}
