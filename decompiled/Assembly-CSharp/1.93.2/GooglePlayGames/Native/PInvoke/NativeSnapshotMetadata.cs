using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x2000165")]
	internal class NativeSnapshotMetadata : BaseReferenceHolder, ISavedGameMetadata
	{
		// Token: 0x06000CBC RID: 3260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x479FB0", Offset = "0x479FB0", VA = "0x6479FB0")]
		internal NativeSnapshotMetadata(IntPtr selfPointer)
		{
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x17000110")]
		public bool IsOpen
		{
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0x47A03C", Offset = "0x47A03C", VA = "0x647A03C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000111")]
		public string Filename
		{
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x47A06C", Offset = "0x47A06C", VA = "0x647A06C", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000112")]
		public string Description
		{
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x47A124", Offset = "0x47A124", VA = "0x647A124", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000113")]
		public string CoverImageURL
		{
			[Token(Token = "0x6000B84")]
			[Address(RVA = "0x47A1DC", Offset = "0x47A1DC", VA = "0x647A1DC", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x17000114")]
		public TimeSpan TotalTimePlayed
		{
			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x47A294", Offset = "0x47A294", VA = "0x647A294", Slot = "10")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00005E38 File Offset: 0x00004038
		[Token(Token = "0x17000115")]
		public DateTime LastModifiedTimestamp
		{
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x47A3A0", Offset = "0x47A3A0", VA = "0x647A3A0", Slot = "11")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x47A574", Offset = "0x47A574", VA = "0x647A574", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x47A918", Offset = "0x47A918", VA = "0x647A918", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00005E50 File Offset: 0x00004050
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x47A948", Offset = "0x47A948", VA = "0x647A948")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18623C", Offset = "0x18623C")]
		private UIntPtr <get_Filename>m__0(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00005E68 File Offset: 0x00004068
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x47A990", Offset = "0x47A990", VA = "0x647A990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18624C", Offset = "0x18624C")]
		private UIntPtr <get_Description>m__1(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x47A9D8", Offset = "0x47A9D8", VA = "0x647A9D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18625C", Offset = "0x18625C")]
		private UIntPtr <get_CoverImageURL>m__2(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}
	}
}
