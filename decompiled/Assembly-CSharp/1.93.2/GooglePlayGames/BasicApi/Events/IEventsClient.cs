using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Events
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x200003F")]
	public interface IEventsClient
	{
		// Token: 0x0600036A RID: 874
		[Token(Token = "0x600033E")]
		void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback);

		// Token: 0x0600036B RID: 875
		[Token(Token = "0x600033F")]
		void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback);

		// Token: 0x0600036C RID: 876
		[Token(Token = "0x6000340")]
		void IncrementEvent(string eventId, uint stepsToIncrement);
	}
}
