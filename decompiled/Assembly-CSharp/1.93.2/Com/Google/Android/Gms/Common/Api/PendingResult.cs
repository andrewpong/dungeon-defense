using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Common.Api
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200007E")]
	public class PendingResult<R> : JavaObjWrapper where R : Result
	{
		// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000596")]
		public PendingResult(IntPtr ptr)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000597")]
		public PendingResult()
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000598")]
		public R await(long arg_long_1, object arg_object_2)
		{
			return null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000599")]
		public R await()
		{
			return null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x600059A")]
		public bool isCanceled()
		{
			return default(bool);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059B")]
		public void cancel()
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059C")]
		public void setResultCallback(ResultCallback<R> arg_ResultCallback_1)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059D")]
		public void setResultCallback(ResultCallback<R> arg_ResultCallback_1, long arg_long_2, object arg_object_3)
		{
		}

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x40002A0")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/PendingResult";
	}
}
