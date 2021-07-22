using System;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000012")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x17EF50", Offset = "0x17EF50")]
	public class SpeedHackDetector : ActDetectorBase
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x29859C", Offset = "0x29859C", VA = "0x629859C")]
		private SpeedHackDetector()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2985CC", Offset = "0x2985CC", VA = "0x62985CC")]
		public static void StartDetection()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x298AD8", Offset = "0x298AD8", VA = "0x6298AD8")]
		public static void StartDetection(UnityAction callback)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x298D80", Offset = "0x298D80", VA = "0x6298D80")]
		public static void StartDetection(UnityAction callback, float interval)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x298DBC", Offset = "0x298DBC", VA = "0x6298DBC")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x298E08", Offset = "0x298E08", VA = "0x6298E08")]
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x298E5C", Offset = "0x298E5C", VA = "0x6298E5C")]
		public static void StopDetection()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x298FB4", Offset = "0x298FB4", VA = "0x6298FB4")]
		public static void Dispose()
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x29887C", Offset = "0x29887C", VA = "0x629887C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185338", Offset = "0x185338")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x29910C", Offset = "0x29910C", VA = "0x629910C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185348", Offset = "0x185348")]
			private set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001A")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x298B0C", Offset = "0x298B0C", VA = "0x6298B0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x299170", Offset = "0x299170", VA = "0x6299170")]
		private void Awake()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x299300", Offset = "0x299300", VA = "0x6299300", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x299374", Offset = "0x299374", VA = "0x6299374")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x299378", Offset = "0x299378", VA = "0x6299378")]
		private void OnLevelLoadedCallback()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2994A8", Offset = "0x2994A8", VA = "0x62994A8")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x29958C", Offset = "0x29958C", VA = "0x629958C")]
		private void Update()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2988E0", Offset = "0x2988E0", VA = "0x62988E0")]
		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2997D4", Offset = "0x2997D4", VA = "0x62997D4", Slot = "9")]
		protected override void StartDetectionAutomatically()
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x299800", Offset = "0x299800", VA = "0x6299800", Slot = "11")]
		protected override void PauseDetector()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x29980C", Offset = "0x29980C", VA = "0x629980C", Slot = "12")]
		protected override void ResumeDetector()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x29982C", Offset = "0x29982C", VA = "0x629982C", Slot = "10")]
		protected override void StopDetectionInternal()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x299844", Offset = "0x299844", VA = "0x6299844", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2994B4", Offset = "0x2994B4", VA = "0x62994B4")]
		private void ResetStartTicks()
		{
		}

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x400006F")]
		internal const string COMPONENT_NAME = "Speed Hack Detector";

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x4000070")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x4000071")]
		private const long TICKS_PER_SECOND = 10000000L;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x4000072")]
		private const int THRESHOLD = 5000000;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18046C", Offset = "0x18046C")]
		public float interval;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1804C4", Offset = "0x1804C4")]
		public byte maxFalsePositives;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1804F8", Offset = "0x1804F8")]
		public int coolDown;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x28")]
		private byte currentFalsePositives;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x2C")]
		private int currentCooldownShots;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x30")]
		private long ticksOnStart;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x38")]
		private long vulnerableTicksOnStart;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x40")]
		private long prevTicks;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x48")]
		private long prevIntervalTicks;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18052C", Offset = "0x18052C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x18052C", Offset = "0x18052C")]
		private static SpeedHackDetector <Instance>k__BackingField;
	}
}
