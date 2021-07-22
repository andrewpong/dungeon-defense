using System;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x200008C")]
	internal static class CallbackUtils
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000619")]
		internal static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600061A")]
		internal static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600061B")]
		internal static Action<T1, T2, T3> ToOnGameThread<T1, T2, T3>(Action<T1, T2, T3> toConvert)
		{
			return null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1855EC", Offset = "0x1855EC")]
		private static void <ToOnGameThread<T>(T A_0)
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1855FC", Offset = "0x1855FC")]
		private static void <ToOnGameThread<T1, T2>(T1 A_0, T2 A_1)
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18560C", Offset = "0x18560C")]
		private static void <ToOnGameThread<T1, T2, T3>(T1 A_0, T2 A_1, T3 A_2)
		{
		}

		// Token: 0x020000A9 RID: 169
		[Token(Token = "0x20002D1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F770", Offset = "0x17F770")]
		private sealed class <ToOnGameThread>c__AnonStorey0<T>
		{
			// Token: 0x06000679 RID: 1657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149A")]
			public <ToOnGameThread>c__AnonStorey0()
			{
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149B")]
			internal void <>m__0(T val)
			{
			}

			// Token: 0x0400031D RID: 797
			[Token(Token = "0x4001336")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T> toConvert;

			// Token: 0x020000AA RID: 170
			[Token(Token = "0x20002D4")]
			private sealed class <ToOnGameThread>c__AnonStorey1
			{
				// Token: 0x0600067B RID: 1659 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014A0")]
				public <ToOnGameThread>c__AnonStorey1()
				{
				}

				// Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014A1")]
				internal void <>m__0()
				{
				}

				// Token: 0x0400031E RID: 798
				[Token(Token = "0x4001339")]
				[FieldOffset(Offset = "0x0")]
				internal T val;

				// Token: 0x0400031F RID: 799
				[Token(Token = "0x400133A")]
				[FieldOffset(Offset = "0x0")]
				internal CallbackUtils.<ToOnGameThread>c__AnonStorey0<T> <>f__ref$0;
			}
		}

		// Token: 0x020000AB RID: 171
		[Token(Token = "0x20002D2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F780", Offset = "0x17F780")]
		private sealed class <ToOnGameThread>c__AnonStorey2<T1, T2>
		{
			// Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149C")]
			public <ToOnGameThread>c__AnonStorey2()
			{
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149D")]
			internal void <>m__0(T1 val1, T2 val2)
			{
			}

			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4001337")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T1, T2> toConvert;

			// Token: 0x020000AC RID: 172
			[Token(Token = "0x20002D5")]
			private sealed class <ToOnGameThread>c__AnonStorey3
			{
				// Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014A2")]
				public <ToOnGameThread>c__AnonStorey3()
				{
				}

				// Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014A3")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000321 RID: 801
				[Token(Token = "0x400133B")]
				[FieldOffset(Offset = "0x0")]
				internal T1 val1;

				// Token: 0x04000322 RID: 802
				[Token(Token = "0x400133C")]
				[FieldOffset(Offset = "0x0")]
				internal T2 val2;

				// Token: 0x04000323 RID: 803
				[Token(Token = "0x400133D")]
				[FieldOffset(Offset = "0x0")]
				internal CallbackUtils.<ToOnGameThread>c__AnonStorey2<T1, T2> <>f__ref$2;
			}
		}

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20002D3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F790", Offset = "0x17F790")]
		private sealed class <ToOnGameThread>c__AnonStorey4<T1, T2, T3>
		{
			// Token: 0x06000681 RID: 1665 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149E")]
			public <ToOnGameThread>c__AnonStorey4()
			{
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149F")]
			internal void <>m__0(T1 val1, T2 val2, T3 val3)
			{
			}

			// Token: 0x04000324 RID: 804
			[Token(Token = "0x4001338")]
			[FieldOffset(Offset = "0x0")]
			internal Action<T1, T2, T3> toConvert;

			// Token: 0x020000AE RID: 174
			[Token(Token = "0x20002D6")]
			private sealed class <ToOnGameThread>c__AnonStorey5
			{
				// Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014A4")]
				public <ToOnGameThread>c__AnonStorey5()
				{
				}

				// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60014A5")]
				internal void <>m__0()
				{
				}

				// Token: 0x04000325 RID: 805
				[Token(Token = "0x400133E")]
				[FieldOffset(Offset = "0x0")]
				internal T1 val1;

				// Token: 0x04000326 RID: 806
				[Token(Token = "0x400133F")]
				[FieldOffset(Offset = "0x0")]
				internal T2 val2;

				// Token: 0x04000327 RID: 807
				[Token(Token = "0x4001340")]
				[FieldOffset(Offset = "0x0")]
				internal T3 val3;

				// Token: 0x04000328 RID: 808
				[Token(Token = "0x4001341")]
				[FieldOffset(Offset = "0x0")]
				internal CallbackUtils.<ToOnGameThread>c__AnonStorey4<T1, T2, T3> <>f__ref$4;
			}
		}
	}
}
