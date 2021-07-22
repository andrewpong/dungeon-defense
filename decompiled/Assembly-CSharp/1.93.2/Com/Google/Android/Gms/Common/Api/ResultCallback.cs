using System;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Common.Api
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x2000080")]
	public interface ResultCallback<R> where R : Result
	{
		// Token: 0x060005F9 RID: 1529
		[Token(Token = "0x600059F")]
		void onResult(R arg_Result_1);
	}
}
