using System;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000011")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x17EEE8", Offset = "0x17EEE8")]
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2976A0", Offset = "0x2976A0", VA = "0x62976A0")]
		private ObscuredCheatingDetector()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2976D8", Offset = "0x2976D8", VA = "0x62976D8")]
		public static void StartDetection()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x297A9C", Offset = "0x297A9C", VA = "0x6297A9C")]
		public static void StartDetection(UnityAction callback)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x297D44", Offset = "0x297D44", VA = "0x6297D44")]
		public static void StopDetection()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x297E9C", Offset = "0x297E9C", VA = "0x6297E9C")]
		public static void Dispose()
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x297870", Offset = "0x297870", VA = "0x6297870")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185318", Offset = "0x185318")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x297FF4", Offset = "0x297FF4", VA = "0x6297FF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185328", Offset = "0x185328")]
			private set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000017")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x297AD0", Offset = "0x297AD0", VA = "0x6297AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x17000018")]
		internal static bool IsRunning
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x298058", Offset = "0x298058", VA = "0x6298058")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2980D4", Offset = "0x2980D4", VA = "0x62980D4")]
		private void Awake()
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x298264", Offset = "0x298264", VA = "0x6298264", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2982D8", Offset = "0x2982D8", VA = "0x62982D8")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2982DC", Offset = "0x2982DC", VA = "0x62982DC")]
		private void OnLevelLoadedCallback()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2978D4", Offset = "0x2978D4", VA = "0x62978D4")]
		private void StartDetectionInternal(UnityAction callback)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x29840C", Offset = "0x29840C", VA = "0x629840C", Slot = "9")]
		protected override void StartDetectionAutomatically()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x298414", Offset = "0x298414", VA = "0x6298414", Slot = "11")]
		protected override void PauseDetector()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x298420", Offset = "0x298420", VA = "0x6298420", Slot = "12")]
		protected override void ResumeDetector()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x298440", Offset = "0x298440", VA = "0x6298440", Slot = "10")]
		protected override void StopDetectionInternal()
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x298458", Offset = "0x298458", VA = "0x6298458", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x4000067")]
		internal const string COMPONENT_NAME = "Obscured Cheating Detector";

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x4000068")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x180368", Offset = "0x180368")]
		public float floatEpsilon;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18039C", Offset = "0x18039C")]
		public float vector2Epsilon;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1803D0", Offset = "0x1803D0")]
		public float vector3Epsilon;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x180404", Offset = "0x180404")]
		public float quaternionEpsilon;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180438", Offset = "0x180438")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x180438", Offset = "0x180438")]
		private static ObscuredCheatingDetector <Instance>k__BackingField;
	}
}
