using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x2000088")]
	public class PlayerStatsObject : JavaObjWrapper, PlayerStats
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x3C19B4", Offset = "0x3C19B4", VA = "0x63C19B4")]
		public PlayerStatsObject(IntPtr ptr)
		{
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x17000104")]
		public static float UNSET_VALUE
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x3C19BC", Offset = "0x3C19BC", VA = "0x63C19BC")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x17000105")]
		public static int CONTENTS_FILE_DESCRIPTOR
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x3C1A2C", Offset = "0x3C1A2C", VA = "0x63C1A2C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x17000106")]
		public static int PARCELABLE_WRITE_RETURN_VALUE
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x3C1A9C", Offset = "0x3C1A9C", VA = "0x63C1A9C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x3C1B0C", Offset = "0x3C1B0C", VA = "0x63C1B0C", Slot = "5")]
		public float getAverageSessionLength()
		{
			return 0f;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x3C1BB8", Offset = "0x3C1BB8", VA = "0x63C1BB8", Slot = "6")]
		public float getChurnProbability()
		{
			return 0f;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x3C1C64", Offset = "0x3C1C64", VA = "0x63C1C64", Slot = "7")]
		public int getDaysSinceLastPlayed()
		{
			return 0;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x3C1D10", Offset = "0x3C1D10", VA = "0x63C1D10", Slot = "8")]
		public int getNumberOfPurchases()
		{
			return 0;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x3C1DBC", Offset = "0x3C1DBC", VA = "0x63C1DBC", Slot = "9")]
		public int getNumberOfSessions()
		{
			return 0;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x3C1E68", Offset = "0x3C1E68", VA = "0x63C1E68", Slot = "10")]
		public float getSessionPercentile()
		{
			return 0f;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x3C1F14", Offset = "0x3C1F14", VA = "0x63C1F14", Slot = "11")]
		public float getSpendPercentile()
		{
			return 0f;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x3C1FC0", Offset = "0x3C1FC0", VA = "0x63C1FC0", Slot = "12")]
		public float getSpendProbability()
		{
			return 0f;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x3C206C", Offset = "0x3C206C", VA = "0x63C206C", Slot = "13")]
		public float getHighSpenderProbability()
		{
			return 0f;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x3C2118", Offset = "0x3C2118", VA = "0x63C2118", Slot = "14")]
		public float getTotalSpendNext28Days()
		{
			return 0f;
		}

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x40002A7")]
		private const string CLASS_NAME = "com/google/android/gms/games/stats/PlayerStats";
	}
}
