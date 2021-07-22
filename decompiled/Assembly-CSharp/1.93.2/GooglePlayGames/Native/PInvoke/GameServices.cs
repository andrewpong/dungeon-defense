using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x2000149")]
	internal class GameServices : BaseReferenceHolder
	{
		// Token: 0x06000BBA RID: 3002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x455694", Offset = "0x455694", VA = "0x6455694")]
		internal GameServices(IntPtr selfPointer)
		{
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00005610 File Offset: 0x00003810
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x45571C", Offset = "0x45571C", VA = "0x645571C")]
		internal bool IsAuthenticated()
		{
			return default(bool);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x455748", Offset = "0x455748", VA = "0x6455748")]
		internal void SignOut()
		{
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x455774", Offset = "0x455774", VA = "0x6455774")]
		internal void StartAuthorizationUI()
		{
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x4557A0", Offset = "0x4557A0", VA = "0x64557A0")]
		public AchievementManager AchievementManager()
		{
			return null;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x455810", Offset = "0x455810", VA = "0x6455810")]
		public LeaderboardManager LeaderboardManager()
		{
			return null;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x4558F8", Offset = "0x4558F8", VA = "0x64558F8")]
		public PlayerManager PlayerManager()
		{
			return null;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x45596C", Offset = "0x45596C", VA = "0x645596C")]
		public StatsManager StatsManager()
		{
			return null;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x451E6C", Offset = "0x451E6C", VA = "0x6451E6C")]
		internal HandleRef AsHandle()
		{
			return default(HandleRef);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x4559E0", Offset = "0x4559E0", VA = "0x64559E0", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}
	}
}
