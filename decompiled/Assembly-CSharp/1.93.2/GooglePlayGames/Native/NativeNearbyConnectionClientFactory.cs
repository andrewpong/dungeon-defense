using System;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000126")]
	public class NativeNearbyConnectionClientFactory
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x6E1550", Offset = "0x6E1550", VA = "0x66E1550")]
		public NativeNearbyConnectionClientFactory()
		{
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x6E1558", Offset = "0x6E1558", VA = "0x66E1558")]
		internal static NearbyConnectionsManager GetManager()
		{
			return null;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x6E15C0", Offset = "0x6E15C0", VA = "0x66E15C0")]
		public static void Create(Action<INearbyConnectionClient> callback)
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x6E16A4", Offset = "0x6E16A4", VA = "0x66E16A4")]
		internal static void InitializeFactory()
		{
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x6E19D4", Offset = "0x6E19D4", VA = "0x66E19D4")]
		internal static void OnManagerInitialized(NearbyConnectionsStatus.InitializationStatus status)
		{
		}

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x0")]
		private static NearbyConnectionsManager sManager;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x4")]
		private static Action<INearbyConnectionClient> sCreationCallback;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180DF0", Offset = "0x180DF0")]
		private static Action<NearbyConnectionsStatus.InitializationStatus> <>f__mg$cache0;
	}
}
