using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Multiplayer;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x200005D")]
	public struct PlayGamesClientConfiguration
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1E1AC4", Offset = "0x1E1AC4", VA = "0x61E1AC4")]
		private PlayGamesClientConfiguration(PlayGamesClientConfiguration.Builder builder)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x1700007C")]
		public bool EnableSavedGames
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1E1ACC", Offset = "0x1E1ACC", VA = "0x61E1ACC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x1700007D")]
		public bool IsHidingPopups
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1E1AD4", Offset = "0x1E1AD4", VA = "0x61E1AD4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x1700007E")]
		public bool IsRequestingAuthCode
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1E1ADC", Offset = "0x1E1ADC", VA = "0x61E1ADC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x1700007F")]
		public bool IsForcingRefresh
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1E1AE4", Offset = "0x1E1AE4", VA = "0x61E1AE4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x17000080")]
		public bool IsRequestingEmail
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1E1AEC", Offset = "0x1E1AEC", VA = "0x61E1AEC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x17000081")]
		public bool IsRequestingIdToken
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1E1AF4", Offset = "0x1E1AF4", VA = "0x61E1AF4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000082")]
		public string AccountName
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1E1AFC", Offset = "0x1E1AFC", VA = "0x61E1AFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000083")]
		public string[] Scopes
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1E1B04", Offset = "0x1E1B04", VA = "0x61E1B04")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000084")]
		public InvitationReceivedDelegate InvitationDelegate
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1E1B0C", Offset = "0x1E1B0C", VA = "0x61E1B0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000085")]
		public MatchDelegate MatchDelegate
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1E1B14", Offset = "0x1E1B14", VA = "0x61E1B14")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PlayGamesClientConfiguration DefaultConfiguration;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool mEnableSavedGames;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x4")]
		private readonly string[] mScopes;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x8")]
		private readonly bool mRequestAuthCode;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x9")]
		private readonly bool mForceRefresh;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0xA")]
		private readonly bool mHidePopups;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0xB")]
		private readonly bool mRequestEmail;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0xC")]
		private readonly bool mRequestIdToken;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x10")]
		private readonly string mAccountName;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x14")]
		private readonly InvitationReceivedDelegate mInvitationDelegate;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x18")]
		private readonly MatchDelegate mMatchDelegate;

		// Token: 0x02000065 RID: 101
		[Token(Token = "0x200005E")]
		public class Builder
		{
			// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x9454D8", Offset = "0x9454D8", VA = "0x69454D8")]
			public Builder()
			{
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x94565C", Offset = "0x94565C", VA = "0x694565C")]
			public PlayGamesClientConfiguration.Builder EnableSavedGames()
			{
				return null;
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x945668", Offset = "0x945668", VA = "0x6945668")]
			public PlayGamesClientConfiguration.Builder EnableHidePopups()
			{
				return null;
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x945674", Offset = "0x945674", VA = "0x6945674")]
			public PlayGamesClientConfiguration.Builder RequestServerAuthCode(bool forceRefresh)
			{
				return null;
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x945684", Offset = "0x945684", VA = "0x6945684")]
			public PlayGamesClientConfiguration.Builder RequestEmail()
			{
				return null;
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x945690", Offset = "0x945690", VA = "0x6945690")]
			public PlayGamesClientConfiguration.Builder RequestIdToken()
			{
				return null;
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x94569C", Offset = "0x94569C", VA = "0x694569C")]
			public PlayGamesClientConfiguration.Builder SetAccountName(string accountName)
			{
				return null;
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x9456A4", Offset = "0x9456A4", VA = "0x69456A4")]
			public PlayGamesClientConfiguration.Builder AddOauthScope(string scope)
			{
				return null;
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x945768", Offset = "0x945768", VA = "0x6945768")]
			public PlayGamesClientConfiguration.Builder WithInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
			{
				return null;
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x9457D8", Offset = "0x9457D8", VA = "0x69457D8")]
			public PlayGamesClientConfiguration.Builder WithMatchDelegate(MatchDelegate matchDelegate)
			{
				return null;
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x00004470 File Offset: 0x00002670
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x94563C", Offset = "0x94563C", VA = "0x694563C")]
			public PlayGamesClientConfiguration Build()
			{
				return default(PlayGamesClientConfiguration);
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x00004488 File Offset: 0x00002688
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x9452E8", Offset = "0x9452E8", VA = "0x69452E8")]
			internal bool HasEnableSaveGames()
			{
				return default(bool);
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x000044A0 File Offset: 0x000026A0
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x945390", Offset = "0x945390", VA = "0x6945390")]
			internal bool IsRequestingAuthCode()
			{
				return default(bool);
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x000044B8 File Offset: 0x000026B8
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x945388", Offset = "0x945388", VA = "0x6945388")]
			internal bool IsHidingPopups()
			{
				return default(bool);
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x000044D0 File Offset: 0x000026D0
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x945398", Offset = "0x945398", VA = "0x6945398")]
			internal bool IsForcingRefresh()
			{
				return default(bool);
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x000044E8 File Offset: 0x000026E8
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x9453A0", Offset = "0x9453A0", VA = "0x69453A0")]
			internal bool IsRequestingEmail()
			{
				return default(bool);
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x00004500 File Offset: 0x00002700
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x9453A8", Offset = "0x9453A8", VA = "0x69453A8")]
			internal bool IsRequestingIdToken()
			{
				return default(bool);
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x9453B0", Offset = "0x9453B0", VA = "0x69453B0")]
			internal string GetAccountName()
			{
				return null;
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x945300", Offset = "0x945300", VA = "0x6945300")]
			internal string[] getScopes()
			{
				return null;
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x9452F8", Offset = "0x9452F8", VA = "0x69452F8")]
			internal MatchDelegate GetMatchDelegate()
			{
				return null;
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x9452F0", Offset = "0x9452F0", VA = "0x69452F0")]
			internal InvitationReceivedDelegate GetInvitationDelegate()
			{
				return null;
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x945848", Offset = "0x945848", VA = "0x6945848")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18556C", Offset = "0x18556C")]
			private static void <mInvitationDelegate>m__0(Invitation A_0, bool A_1)
			{
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x94584C", Offset = "0x94584C", VA = "0x694584C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18557C", Offset = "0x18557C")]
			private static void <mMatchDelegate>m__1(TurnBasedMatch A_0, bool A_1)
			{
			}

			// Token: 0x0400025F RID: 607
			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x8")]
			private bool mEnableSaveGames;

			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0xC")]
			private List<string> mScopes;

			// Token: 0x04000261 RID: 609
			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x10")]
			private bool mHidePopups;

			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x11")]
			private bool mRequestAuthCode;

			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0x12")]
			private bool mForceRefresh;

			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000218")]
			[FieldOffset(Offset = "0x13")]
			private bool mRequestEmail;

			// Token: 0x04000265 RID: 613
			[Token(Token = "0x4000219")]
			[FieldOffset(Offset = "0x14")]
			private bool mRequestIdToken;

			// Token: 0x04000266 RID: 614
			[Token(Token = "0x400021A")]
			[FieldOffset(Offset = "0x18")]
			private string mAccountName;

			// Token: 0x04000267 RID: 615
			[Token(Token = "0x400021B")]
			[FieldOffset(Offset = "0x1C")]
			private InvitationReceivedDelegate mInvitationDelegate;

			// Token: 0x04000268 RID: 616
			[Token(Token = "0x400021C")]
			[FieldOffset(Offset = "0x20")]
			private MatchDelegate mMatchDelegate;

			// Token: 0x04000269 RID: 617
			[Token(Token = "0x400021D")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180D90", Offset = "0x180D90")]
			private static InvitationReceivedDelegate <>f__am$cache0;

			// Token: 0x0400026A RID: 618
			[Token(Token = "0x400021E")]
			[FieldOffset(Offset = "0x4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180DA0", Offset = "0x180DA0")]
			private static MatchDelegate <>f__am$cache1;
		}
	}
}
