using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x200013F")]
	internal sealed class AndroidPlatformConfiguration : PlatformConfiguration
	{
		// Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x453234", Offset = "0x453234", VA = "0x6453234")]
		private AndroidPlatformConfiguration(IntPtr selfPointer)
		{
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x45323C", Offset = "0x45323C", VA = "0x645323C")]
		internal void SetActivity(IntPtr activity)
		{
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x453270", Offset = "0x453270", VA = "0x6453270")]
		internal void SetOptionalIntentHandlerForUI(Action<IntPtr> intentHandler)
		{
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x4533C0", Offset = "0x4533C0", VA = "0x64533C0")]
		internal void SetOptionalViewForPopups(IntPtr view)
		{
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x4533F4", Offset = "0x4533F4", VA = "0x64533F4", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x453190", Offset = "0x453190", VA = "0x6453190")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18589C", Offset = "0x18589C")]
		private static void InternalIntentHandler(IntPtr intent, IntPtr userData)
		{
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x453404", Offset = "0x453404", VA = "0x6453404")]
		internal static AndroidPlatformConfiguration Create()
		{
			return null;
		}

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F00", Offset = "0x180F00")]
		private static AndroidPlatformConfiguration.IntentHandler <>f__mg$cache0;

		// Token: 0x020001B9 RID: 441
		// (Invoke) Token: 0x06000B74 RID: 2932
		[Token(Token = "0x2000140")]
		private delegate void IntentHandlerInternal(IntPtr intent, IntPtr userData);
	}
}
