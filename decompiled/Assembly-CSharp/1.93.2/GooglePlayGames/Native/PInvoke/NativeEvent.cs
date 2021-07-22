using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Events;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x2000159")]
	internal class NativeEvent : BaseReferenceHolder, IEvent
	{
		// Token: 0x06000C54 RID: 3156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x476800", Offset = "0x476800", VA = "0x6476800")]
		internal NativeEvent(IntPtr selfPointer)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010A")]
		public string Id
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x47688C", Offset = "0x47688C", VA = "0x647688C", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010B")]
		public string Name
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x476944", Offset = "0x476944", VA = "0x6476944", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010C")]
		public string Description
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x4769FC", Offset = "0x4769FC", VA = "0x64769FC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010D")]
		public string ImageUrl
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x476AB4", Offset = "0x476AB4", VA = "0x6476AB4", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x1700010E")]
		public ulong CurrentCount
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x476B6C", Offset = "0x476B6C", VA = "0x6476B6C", Slot = "10")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x1700010F")]
		public EventVisibility Visibility
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x476B9C", Offset = "0x476B9C", VA = "0x6476B9C", Slot = "11")]
			get
			{
				return (EventVisibility)0;
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x476CE4", Offset = "0x476CE4", VA = "0x6476CE4", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x476CF4", Offset = "0x476CF4", VA = "0x6476CF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x477068", Offset = "0x477068", VA = "0x6477068")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18606C", Offset = "0x18606C")]
		private UIntPtr <get_Id>m__0(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x4770B0", Offset = "0x4770B0", VA = "0x64770B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18607C", Offset = "0x18607C")]
		private UIntPtr <get_Name>m__1(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x4770F8", Offset = "0x4770F8", VA = "0x64770F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18608C", Offset = "0x18608C")]
		private UIntPtr <get_Description>m__2(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x477140", Offset = "0x477140", VA = "0x6477140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18609C", Offset = "0x18609C")]
		private UIntPtr <get_ImageUrl>m__3(byte[] out_string, UIntPtr out_size)
		{
			return 0;
		}
	}
}
