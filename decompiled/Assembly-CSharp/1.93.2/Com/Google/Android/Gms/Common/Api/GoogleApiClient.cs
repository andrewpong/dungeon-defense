using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Common.Api
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x200007D")]
	public class GoogleApiClient : JavaObjWrapper
	{
		// Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x3BCB10", Offset = "0x3BCB10", VA = "0x63BCB10")]
		public GoogleApiClient(IntPtr ptr)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x3BCB18", Offset = "0x3BCB18", VA = "0x63BCB18")]
		public GoogleApiClient()
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x3BCB80", Offset = "0x3BCB80", VA = "0x63BCB80")]
		public object getContext()
		{
			return null;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x3BCC2C", Offset = "0x3BCC2C", VA = "0x63BCC2C")]
		public void connect()
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x3BCCCC", Offset = "0x3BCCCC", VA = "0x63BCCCC")]
		public void disconnect()
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x3BCD6C", Offset = "0x3BCD6C", VA = "0x63BCD6C")]
		public void dump(string arg_string_1, object arg_object_2, object arg_object_3, string[] arg_string_4)
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x3BCF70", Offset = "0x3BCF70", VA = "0x63BCF70")]
		public ConnectionResult blockingConnect(long arg_long_1, object arg_object_2)
		{
			return null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x3BD100", Offset = "0x3BD100", VA = "0x63BD100")]
		public ConnectionResult blockingConnect()
		{
			return null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x3BD1AC", Offset = "0x3BD1AC", VA = "0x63BD1AC")]
		public PendingResult<Status> clearDefaultAccountAndReconnect()
		{
			return null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x3BD258", Offset = "0x3BD258", VA = "0x63BD258")]
		public ConnectionResult getConnectionResult(object arg_object_1)
		{
			return null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x3BD36C", Offset = "0x3BD36C", VA = "0x63BD36C")]
		public int getSessionId()
		{
			return 0;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x3BD418", Offset = "0x3BD418", VA = "0x63BD418")]
		public bool isConnecting()
		{
			return default(bool);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x3BD4C4", Offset = "0x3BD4C4", VA = "0x63BD4C4")]
		public bool isConnectionCallbacksRegistered(object arg_object_1)
		{
			return default(bool);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x3BD5D8", Offset = "0x3BD5D8", VA = "0x63BD5D8")]
		public bool isConnectionFailedListenerRegistered(object arg_object_1)
		{
			return default(bool);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x3BD6EC", Offset = "0x3BD6EC", VA = "0x63BD6EC")]
		public void reconnect()
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x3BD78C", Offset = "0x3BD78C", VA = "0x63BD78C")]
		public void registerConnectionCallbacks(object arg_object_1)
		{
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x3BD894", Offset = "0x3BD894", VA = "0x63BD894")]
		public void registerConnectionFailedListener(object arg_object_1)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x3BD99C", Offset = "0x3BD99C", VA = "0x63BD99C")]
		public void stopAutoManage(object arg_object_1)
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x3BDAA4", Offset = "0x3BDAA4", VA = "0x63BDAA4")]
		public void unregisterConnectionCallbacks(object arg_object_1)
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x3BDBAC", Offset = "0x3BDBAC", VA = "0x63BDBAC")]
		public void unregisterConnectionFailedListener(object arg_object_1)
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x3BDCB4", Offset = "0x3BDCB4", VA = "0x63BDCB4")]
		public bool hasConnectedApi(object arg_object_1)
		{
			return default(bool);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x3BDDC8", Offset = "0x3BDDC8", VA = "0x63BDDC8")]
		public object getLooper()
		{
			return null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x3BDE74", Offset = "0x3BDE74", VA = "0x63BDE74")]
		public bool isConnected()
		{
			return default(bool);
		}

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x400029F")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/GoogleApiClient";
	}
}
