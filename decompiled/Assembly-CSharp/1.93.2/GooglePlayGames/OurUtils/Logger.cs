using System;
using Il2CppDummyDll;

namespace GooglePlayGames.OurUtils
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000075")]
	public class Logger
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x48CE0C", Offset = "0x48CE0C", VA = "0x648CE0C")]
		public Logger()
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00004A70 File Offset: 0x00002C70
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D4")]
		public static bool DebugLogEnabled
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x48CE14", Offset = "0x48CE14", VA = "0x648CE14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x48CEA0", Offset = "0x48CEA0", VA = "0x648CEA0")]
			set
			{
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00004A88 File Offset: 0x00002C88
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D5")]
		public static bool WarningLogEnabled
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x48CF30", Offset = "0x48CF30", VA = "0x648CF30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x48CFBC", Offset = "0x48CFBC", VA = "0x648CFBC")]
			set
			{
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x47BF64", Offset = "0x47BF64", VA = "0x647BF64")]
		public static void d(string msg)
		{
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x47F110", Offset = "0x47F110", VA = "0x647F110")]
		public static void w(string msg)
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x4766C8", Offset = "0x4766C8", VA = "0x64766C8")]
		public static void e(string msg)
		{
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x48D28C", Offset = "0x48D28C", VA = "0x648D28C")]
		public static string describe(byte[] b)
		{
			return null;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x48D378", Offset = "0x48D378", VA = "0x648D378")]
		private static string ToLogMessage(string prefix, string logType, string msg)
		{
			return null;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x48D860", Offset = "0x48D860", VA = "0x648D860")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1855CC", Offset = "0x1855CC")]
		private static void <ToLogMessage>m__0()
		{
		}

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x0")]
		private static bool debugLogEnabled;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x1")]
		private static bool warningLogEnabled;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180DD0", Offset = "0x180DD0")]
		private static Action <>f__am$cache0;

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x20002C9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F6F0", Offset = "0x17F6F0")]
		private sealed class <d>c__AnonStorey0
		{
			// Token: 0x0600058F RID: 1423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600148A")]
			[Address(RVA = "0x48D04C", Offset = "0x48D04C", VA = "0x648D04C")]
			public <d>c__AnonStorey0()
			{
			}

			// Token: 0x06000590 RID: 1424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600148B")]
			[Address(RVA = "0x48D8EC", Offset = "0x48D8EC", VA = "0x648D8EC")]
			internal void <>m__0()
			{
			}

			// Token: 0x040002EF RID: 751
			[Token(Token = "0x4001329")]
			[FieldOffset(Offset = "0x8")]
			internal string msg;
		}

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x20002CA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F700", Offset = "0x17F700")]
		private sealed class <w>c__AnonStorey1
		{
			// Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600148C")]
			[Address(RVA = "0x48D27C", Offset = "0x48D27C", VA = "0x648D27C")]
			public <w>c__AnonStorey1()
			{
			}

			// Token: 0x06000592 RID: 1426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600148D")]
			[Address(RVA = "0x48DAE4", Offset = "0x48DAE4", VA = "0x648DAE4")]
			internal void <>m__0()
			{
			}

			// Token: 0x040002F0 RID: 752
			[Token(Token = "0x400132A")]
			[FieldOffset(Offset = "0x8")]
			internal string msg;
		}

		// Token: 0x0200008C RID: 140
		[Token(Token = "0x20002CB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F710", Offset = "0x17F710")]
		private sealed class <e>c__AnonStorey2
		{
			// Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600148E")]
			[Address(RVA = "0x48D284", Offset = "0x48D284", VA = "0x648D284")]
			public <e>c__AnonStorey2()
			{
			}

			// Token: 0x06000594 RID: 1428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600148F")]
			[Address(RVA = "0x48DA04", Offset = "0x48DA04", VA = "0x648DA04")]
			internal void <>m__0()
			{
			}

			// Token: 0x040002F1 RID: 753
			[Token(Token = "0x400132B")]
			[FieldOffset(Offset = "0x8")]
			internal string msg;
		}
	}
}
