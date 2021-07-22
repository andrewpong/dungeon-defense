using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000074")]
	public class PlayGamesUserProfile : IUserProfile
	{
		// Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x32FA3C", Offset = "0x32FA3C", VA = "0x632FA3C")]
		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x32FA78", Offset = "0x32FA78", VA = "0x632FA78")]
		protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CE")]
		public string userName
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x32FB30", Offset = "0x32FB30", VA = "0x632FB30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CF")]
		public string id
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x32FB38", Offset = "0x32FB38", VA = "0x632FB38", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x170000D0")]
		public bool isFriend
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x32FB40", Offset = "0x32FB40", VA = "0x632FB40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x170000D1")]
		public UserState state
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x32FB48", Offset = "0x32FB48", VA = "0x632FB48", Slot = "8")]
			get
			{
				return UserState.Online;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D2")]
		public Texture2D image
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x32FB50", Offset = "0x32FB50", VA = "0x632FB50", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D3")]
		public string AvatarURL
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x32FD14", Offset = "0x32FD14", VA = "0x632FD14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x32FD1C", Offset = "0x32FD1C", VA = "0x632FD1C")]
		[DebuggerHidden]
		internal IEnumerator LoadImage()
		{
			return null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x32FDA8", Offset = "0x32FDA8", VA = "0x632FDA8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x32FED0", Offset = "0x32FED0", VA = "0x632FED0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x32FFBC", Offset = "0x32FFBC", VA = "0x632FFBC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x8")]
		private string mDisplayName;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0xC")]
		private string mPlayerId;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x10")]
		private string mAvatarUrl;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x14")]
		private bool mImageLoading;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x18")]
		private Texture2D mImage;

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x20002C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F6E0", Offset = "0x17F6E0")]
		private sealed class <LoadImage>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001484")]
			[Address(RVA = "0x32FDA0", Offset = "0x32FDA0", VA = "0x632FDA0")]
			[DebuggerHidden]
			public <LoadImage>c__Iterator0()
			{
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x00004A58 File Offset: 0x00002C58
			[Token(Token = "0x6001485")]
			[Address(RVA = "0x33005C", Offset = "0x33005C", VA = "0x633005C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x0600057F RID: 1407 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001AF")]
			private object Current
			{
				[Token(Token = "0x6001486")]
				[Address(RVA = "0x330380", Offset = "0x330380", VA = "0x6330380", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x06000580 RID: 1408 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001B0")]
			private object Current
			{
				[Token(Token = "0x6001487")]
				[Address(RVA = "0x330388", Offset = "0x330388", VA = "0x6330388", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001488")]
			[Address(RVA = "0x330390", Offset = "0x330390", VA = "0x6330390", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001489")]
			[Address(RVA = "0x3303A4", Offset = "0x3303A4", VA = "0x63303A4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x4001324")]
			[FieldOffset(Offset = "0x8")]
			internal UnityWebRequest <www>__1;

			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x4001325")]
			[FieldOffset(Offset = "0xC")]
			internal PlayGamesUserProfile $this;

			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x4001326")]
			[FieldOffset(Offset = "0x10")]
			internal object $current;

			// Token: 0x040002EA RID: 746
			[Token(Token = "0x4001327")]
			[FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			// Token: 0x040002EB RID: 747
			[Token(Token = "0x4001328")]
			[FieldOffset(Offset = "0x18")]
			internal int $PC;
		}
	}
}
