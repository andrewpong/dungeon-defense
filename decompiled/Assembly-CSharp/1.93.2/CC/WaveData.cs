using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace CC
{
	// Token: 0x020002EF RID: 751
	[Token(Token = "0x200025B")]
	public class WaveData
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x29424C", Offset = "0x29424C", VA = "0x629424C")]
		public WaveData()
		{
		}

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000C83")]
		[FieldOffset(Offset = "0x8")]
		public ObscuredInt nSpawn;

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000C84")]
		[FieldOffset(Offset = "0x18")]
		public ObscuredInt nMaxWave;

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000C85")]
		[FieldOffset(Offset = "0x28")]
		public ObscuredInt nCurrentWave;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000C86")]
		[FieldOffset(Offset = "0x38")]
		public ObscuredFloat fWaveLenth;
	}
}
