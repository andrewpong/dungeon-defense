using System;
using Il2CppDummyDll;

// Token: 0x02000228 RID: 552
[Token(Token = "0x200019E")]
public class KeyChainBinding
{
	// Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x2A51F4", Offset = "0x2A51F4", VA = "0x62A51F4")]
	public KeyChainBinding()
	{
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700011A")]
	private static string mSavePath
	{
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x2A51FC", Offset = "0x2A51FC", VA = "0x62A51FC")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700011B")]
	private static string mUniqueIdentifier
	{
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x2A5298", Offset = "0x2A5298", VA = "0x62A5298")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18738C", Offset = "0x18738C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x2A52FC", Offset = "0x2A52FC", VA = "0x62A52FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18739C", Offset = "0x18739C")]
		set
		{
		}
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3C")]
	[Address(RVA = "0x2A5360", Offset = "0x2A5360", VA = "0x62A5360")]
	public static void GetKeyChainData(out string applicationKey, out string data)
	{
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3D")]
	[Address(RVA = "0x2A598C", Offset = "0x2A598C", VA = "0x62A598C")]
	public static void SetKeyChainData(string applicationKey, string data)
	{
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0x2A5DFC", Offset = "0x2A5DFC", VA = "0x62A5DFC")]
	public static void DeleteKeyChainData()
	{
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3F")]
	[Address(RVA = "0x2A5DF8", Offset = "0x2A5DF8", VA = "0x62A5DF8")]
	private static void Log(string log)
	{
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D40")]
	[Address(RVA = "0x2A5988", Offset = "0x2A5988", VA = "0x62A5988")]
	private static void LogFormat(string format, params object[] parms)
	{
	}

	// Token: 0x04000609 RID: 1545
	[Token(Token = "0x40004A5")]
	private const char seperatorChar = '|';

	// Token: 0x0400060A RID: 1546
	[Token(Token = "0x40004A6")]
	private const string logPrefix = "KeyChainBinding -> {0}";

	// Token: 0x0400060B RID: 1547
	[Token(Token = "0x40004A7")]
	private const string setLog = "Set keychain values";

	// Token: 0x0400060C RID: 1548
	[Token(Token = "0x40004A8")]
	private const string getLog = "Retrieved applicationKey={0} applicationData={1}";

	// Token: 0x0400060D RID: 1549
	[Token(Token = "0x40004A9")]
	private const string deleteLog = "Cleared keychain values";

	// Token: 0x0400060E RID: 1550
	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181520", Offset = "0x181520")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x181520", Offset = "0x181520")]
	private static string <mUniqueIdentifier>k__BackingField;
}
