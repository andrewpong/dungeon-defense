using System;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000C5")]
	internal static class NearbyConnectionsStatus
	{
		// Token: 0x020000E8 RID: 232
		[Token(Token = "0x20000C6")]
		internal enum InitializationStatus
		{
			// Token: 0x04000368 RID: 872
			[Token(Token = "0x40002E8")]
			VALID = 1,
			// Token: 0x04000369 RID: 873
			[Token(Token = "0x40002E9")]
			ERROR_INTERNAL = -2,
			// Token: 0x0400036A RID: 874
			[Token(Token = "0x40002EA")]
			ERROR_VERSION_UPDATE_REQUIRED = -4
		}
	}
}
