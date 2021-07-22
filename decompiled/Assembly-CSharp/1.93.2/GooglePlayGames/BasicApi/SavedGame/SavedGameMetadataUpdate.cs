using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x2000066")]
	public struct SavedGameMetadataUpdate
	{
		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1E1B78", Offset = "0x1E1B78", VA = "0x61E1B78")]
		private SavedGameMetadataUpdate(SavedGameMetadataUpdate.Builder builder)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x1700008C")]
		public bool IsDescriptionUpdated
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x1E1BD0", Offset = "0x1E1BD0", VA = "0x61E1BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008D")]
		public string UpdatedDescription
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x1E1BD8", Offset = "0x1E1BD8", VA = "0x61E1BD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x1700008E")]
		public bool IsCoverImageUpdated
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x1E1BE0", Offset = "0x1E1BE0", VA = "0x61E1BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008F")]
		public byte[] UpdatedPngCoverImage
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x1E1BE8", Offset = "0x1E1BE8", VA = "0x61E1BE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x17000090")]
		public bool IsPlayedTimeUpdated
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x1E1BF0", Offset = "0x1E1BF0", VA = "0x61E1BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x17000091")]
		public TimeSpan? UpdatedPlayedTime
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x1E1BF8", Offset = "0x1E1BF8", VA = "0x61E1BF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool mDescriptionUpdated;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x4")]
		private readonly string mNewDescription;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x8")]
		private readonly bool mCoverImageUpdated;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0xC")]
		private readonly byte[] mNewPngCoverImage;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x10")]
		private readonly TimeSpan? mNewPlayedTime;

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x2000067")]
		public struct Builder
		{
			// Token: 0x060004A5 RID: 1189 RVA: 0x00004578 File Offset: 0x00002778
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x1E1C64", Offset = "0x1E1C64", VA = "0x61E1C64")]
			public SavedGameMetadataUpdate.Builder WithUpdatedDescription(string description)
			{
				return default(SavedGameMetadataUpdate.Builder);
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x00004590 File Offset: 0x00002790
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x1E1C78", Offset = "0x1E1C78", VA = "0x61E1C78")]
			public SavedGameMetadataUpdate.Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage)
			{
				return default(SavedGameMetadataUpdate.Builder);
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x000045A8 File Offset: 0x000027A8
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x1E1CA0", Offset = "0x1E1CA0", VA = "0x61E1CA0")]
			public SavedGameMetadataUpdate.Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime)
			{
				return default(SavedGameMetadataUpdate.Builder);
			}

			// Token: 0x060004A8 RID: 1192 RVA: 0x000045C0 File Offset: 0x000027C0
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1E1CBC", Offset = "0x1E1CBC", VA = "0x61E1CBC")]
			public SavedGameMetadataUpdate Build()
			{
				return default(SavedGameMetadataUpdate);
			}

			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000238")]
			[FieldOffset(Offset = "0x0")]
			internal bool mDescriptionUpdated;

			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000239")]
			[FieldOffset(Offset = "0x4")]
			internal string mNewDescription;

			// Token: 0x04000286 RID: 646
			[Token(Token = "0x400023A")]
			[FieldOffset(Offset = "0x8")]
			internal bool mCoverImageUpdated;

			// Token: 0x04000287 RID: 647
			[Token(Token = "0x400023B")]
			[FieldOffset(Offset = "0xC")]
			internal byte[] mNewPngCoverImage;

			// Token: 0x04000288 RID: 648
			[Token(Token = "0x400023C")]
			[FieldOffset(Offset = "0x10")]
			internal TimeSpan? mNewPlayedTime;
		}
	}
}
