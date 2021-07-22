using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x200016D")]
	internal class NearbyConnectionsManagerBuilder : BaseReferenceHolder
	{
		// Token: 0x06000D19 RID: 3353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x47EF38", Offset = "0x47EF38", VA = "0x647EF38")]
		internal NearbyConnectionsManagerBuilder()
		{
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x47EFCC", Offset = "0x47EFCC", VA = "0x647EFCC")]
		internal NearbyConnectionsManagerBuilder SetOnInitializationFinished(Action<NearbyConnectionsStatus.InitializationStatus> callback)
		{
			return null;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x47ECCC", Offset = "0x47ECCC", VA = "0x647ECCC")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186444", Offset = "0x186444")]
		private static void InternalOnInitializationFinishedCallback(NearbyConnectionsStatus.InitializationStatus status, IntPtr userData)
		{
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x47F248", Offset = "0x47F248", VA = "0x647F248")]
		internal NearbyConnectionsManagerBuilder SetLocalClientId(long localClientId)
		{
			return null;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x47F298", Offset = "0x47F298", VA = "0x647F298")]
		internal NearbyConnectionsManagerBuilder SetDefaultLogLevel(Types.LogLevel minLevel)
		{
			return null;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x47F2D8", Offset = "0x47F2D8", VA = "0x647F2D8")]
		internal NearbyConnectionsManager Build(PlatformConfiguration configuration)
		{
			return null;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x47F394", Offset = "0x47F394", VA = "0x647F394", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1810F0", Offset = "0x1810F0")]
		private static NearbyConnectionsBuilder.OnInitializationFinishedCallback <>f__mg$cache0;
	}
}
