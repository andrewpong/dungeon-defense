using System;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x2000087")]
	public interface PlayerStats
	{
		// Token: 0x06000657 RID: 1623
		[Token(Token = "0x60005FD")]
		float getAverageSessionLength();

		// Token: 0x06000658 RID: 1624
		[Token(Token = "0x60005FE")]
		float getChurnProbability();

		// Token: 0x06000659 RID: 1625
		[Token(Token = "0x60005FF")]
		int getDaysSinceLastPlayed();

		// Token: 0x0600065A RID: 1626
		[Token(Token = "0x6000600")]
		int getNumberOfPurchases();

		// Token: 0x0600065B RID: 1627
		[Token(Token = "0x6000601")]
		int getNumberOfSessions();

		// Token: 0x0600065C RID: 1628
		[Token(Token = "0x6000602")]
		float getSessionPercentile();

		// Token: 0x0600065D RID: 1629
		[Token(Token = "0x6000603")]
		float getSpendPercentile();

		// Token: 0x0600065E RID: 1630
		[Token(Token = "0x6000604")]
		float getSpendProbability();

		// Token: 0x0600065F RID: 1631
		[Token(Token = "0x6000605")]
		float getHighSpenderProbability();

		// Token: 0x06000660 RID: 1632
		[Token(Token = "0x6000606")]
		float getTotalSpendNext28Days();
	}
}
