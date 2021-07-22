using System;
using Il2CppDummyDll;

namespace Thinksquirrel.CShake.Internal
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000007")]
	[Attribute(Name = "AttributeUsageAttribute", RVA = "0x17ED7C", Offset = "0x17ED7C")]
	public sealed class CameraShakeDocumentationName : Attribute
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0xCAC598", Offset = "0xCAC598", VA = "0x6CAC598")]
		public CameraShakeDocumentationName(string name)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000010")]
		public string name
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xCAC5B8", Offset = "0xCAC5B8", VA = "0x6CAC5B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x8")]
		private string m_Name;
	}
}
