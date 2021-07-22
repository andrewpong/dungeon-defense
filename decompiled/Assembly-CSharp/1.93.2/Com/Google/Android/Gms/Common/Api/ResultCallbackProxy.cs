using System;
using Google.Developers;
using Il2CppDummyDll;
using UnityEngine;

namespace Com.Google.Android.Gms.Common.Api
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x2000081")]
	public abstract class ResultCallbackProxy<R> : JavaInterfaceProxy, ResultCallback<R> where R : Result
	{
		// Token: 0x060005FA RID: 1530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A0")]
		public ResultCallbackProxy()
		{
		}

		// Token: 0x060005FB RID: 1531
		[Token(Token = "0x60005A1")]
		public abstract void OnResult(R arg_Result_1);

		// Token: 0x060005FC RID: 1532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A2")]
		public void onResult(R arg_Result_1)
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A3")]
		public void onResult(AndroidJavaObject arg_Result_1)
		{
		}

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x40002A1")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/ResultCallback";
	}
}
