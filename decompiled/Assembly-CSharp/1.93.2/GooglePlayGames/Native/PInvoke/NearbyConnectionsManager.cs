using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001EE RID: 494
	[Token(Token = "0x200016C")]
	internal class NearbyConnectionsManager : BaseReferenceHolder
	{
		// Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x47D604", Offset = "0x47D604", VA = "0x647D604")]
		internal NearbyConnectionsManager(IntPtr selfPointer)
		{
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x47D690", Offset = "0x47D690", VA = "0x647D690", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x47D6A0", Offset = "0x47D6A0", VA = "0x647D6A0")]
		internal void SendUnreliable(string remoteEndpointId, byte[] payload)
		{
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x47D714", Offset = "0x47D714", VA = "0x647D714")]
		internal void SendReliable(string remoteEndpointId, byte[] payload)
		{
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x47D788", Offset = "0x47D788", VA = "0x647D788")]
		internal void StartAdvertising(string name, List<NativeAppIdentifier> appIds, long advertisingDuration, Action<long, NativeStartAdvertisingResult> advertisingCallback, Action<long, NativeConnectionRequest> connectionRequestCallback)
		{
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x47D3AC", Offset = "0x47D3AC", VA = "0x647D3AC")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1862CC", Offset = "0x1862CC")]
		private static void InternalStartAdvertisingCallback(long id, IntPtr result, IntPtr userData)
		{
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x47D474", Offset = "0x47D474", VA = "0x647D474")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186344", Offset = "0x186344")]
		private static void InternalConnectionRequestCallback(long id, IntPtr result, IntPtr userData)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x47DDC0", Offset = "0x47DDC0", VA = "0x647DDC0")]
		internal void StopAdvertising()
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x47DDF0", Offset = "0x47DDF0", VA = "0x647DDF0")]
		internal void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<long, NativeConnectionResponse> callback, NativeMessageListenerHelper listener)
		{
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x47D53C", Offset = "0x47D53C", VA = "0x647D53C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1863BC", Offset = "0x1863BC")]
		private static void InternalConnectResponseCallback(long localClientId, IntPtr response, IntPtr userData)
		{
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x47E108", Offset = "0x47E108", VA = "0x647E108")]
		internal void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, NativeMessageListenerHelper listener)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x47E1A8", Offset = "0x47E1A8", VA = "0x647E1A8")]
		internal void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x47E1E0", Offset = "0x47E1E0", VA = "0x647E1E0")]
		internal void StopAllConnections()
		{
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x47E210", Offset = "0x47E210", VA = "0x647E210")]
		internal void StartDiscovery(string serviceId, long duration, NativeEndpointDiscoveryListenerHelper listener)
		{
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x47E288", Offset = "0x47E288", VA = "0x647E288")]
		internal void StopDiscovery(string serviceId)
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x47E2C0", Offset = "0x47E2C0", VA = "0x647E2C0")]
		internal void RejectConnectionRequest(string remoteEndpointId)
		{
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x47E2F8", Offset = "0x47E2F8", VA = "0x647E2F8")]
		internal void Shutdown()
		{
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000116")]
		public string AppBundleId
		{
			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x47E328", Offset = "0x47E328", VA = "0x647E328")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x47E520", Offset = "0x47E520", VA = "0x647E520")]
		internal static string ReadServiceId()
		{
			return null;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000117")]
		public static string ServiceId
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x47EBB0", Offset = "0x47EBB0", VA = "0x647EBB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x47ECA0", Offset = "0x47ECA0", VA = "0x647ECA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x186434", Offset = "0x186434")]
		private static IntPtr <StartAdvertising>m__0(NativeAppIdentifier id)
		{
			return 0;
		}

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string sServiceId;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181080", Offset = "0x181080")]
		private static Func<IntPtr, NativeStartAdvertisingResult> <>f__mg$cache0;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181090", Offset = "0x181090")]
		private static Func<IntPtr, NativeConnectionRequest> <>f__mg$cache1;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1810A0", Offset = "0x1810A0")]
		private static NearbyConnectionTypes.StartAdvertisingCallback <>f__mg$cache2;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1810B0", Offset = "0x1810B0")]
		private static NearbyConnectionTypes.ConnectionRequestCallback <>f__mg$cache3;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1810C0", Offset = "0x1810C0")]
		private static Func<NativeAppIdentifier, IntPtr> <>f__am$cache0;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1810D0", Offset = "0x1810D0")]
		private static Func<IntPtr, NativeConnectionResponse> <>f__mg$cache4;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1810E0", Offset = "0x1810E0")]
		private static NearbyConnectionTypes.ConnectionResponseCallback <>f__mg$cache5;
	}
}
