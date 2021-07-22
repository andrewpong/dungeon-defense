using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x2000068")]
	public class ScorePageToken
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x94675C", Offset = "0x94675C", VA = "0x694675C")]
		internal ScorePageToken(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x17000092")]
		public LeaderboardCollection Collection
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x946794", Offset = "0x946794", VA = "0x6946794")]
			get
			{
				return (LeaderboardCollection)0;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x17000093")]
		public LeaderboardTimeSpan TimeSpan
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x94679C", Offset = "0x94679C", VA = "0x694679C")]
			get
			{
				return (LeaderboardTimeSpan)0;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000094")]
		public string LeaderboardId
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x9411AC", Offset = "0x9411AC", VA = "0x69411AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000095")]
		internal object InternalObject
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x9467A4", Offset = "0x9467A4", VA = "0x69467A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x8")]
		private string mId;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0xC")]
		private object mInternalObject;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x10")]
		private LeaderboardCollection mCollection;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x14")]
		private LeaderboardTimeSpan mTimespan;
	}
}
