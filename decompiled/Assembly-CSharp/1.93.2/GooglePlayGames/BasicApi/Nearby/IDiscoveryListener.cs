using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000059")]
	public interface IDiscoveryListener
	{
		// Token: 0x06000442 RID: 1090
		[Token(Token = "0x6000416")]
		void OnEndpointFound(EndpointDetails discoveredEndpoint);

		// Token: 0x06000443 RID: 1091
		[Token(Token = "0x6000417")]
		void OnEndpointLost(string lostEndpointId);
	}
}
