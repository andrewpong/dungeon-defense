using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x200000F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x17EE88", Offset = "0x17EE88")]
	public class InjectionDetector : ActDetectorBase
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2957B8", Offset = "0x2957B8", VA = "0x62957B8")]
		private InjectionDetector()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2957D0", Offset = "0x2957D0", VA = "0x62957D0")]
		public static void StartDetection()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x295C68", Offset = "0x295C68", VA = "0x6295C68")]
		public static void StartDetection(UnityAction callback)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x295F14", Offset = "0x295F14", VA = "0x6295F14")]
		public static void StartDetection(UnityAction<string> callback)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x295F4C", Offset = "0x295F4C", VA = "0x6295F4C")]
		public static void StopDetection()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2960A4", Offset = "0x2960A4", VA = "0x62960A4")]
		public static void Dispose()
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x29596C", Offset = "0x29596C", VA = "0x629596C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1852F8", Offset = "0x1852F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2961FC", Offset = "0x2961FC", VA = "0x62961FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185308", Offset = "0x185308")]
			private set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000015")]
		private static InjectionDetector GetOrCreateInstance
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x295CA0", Offset = "0x295CA0", VA = "0x6295CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x296260", Offset = "0x296260", VA = "0x6296260")]
		private void Awake()
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2963F0", Offset = "0x2963F0", VA = "0x62963F0", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x296464", Offset = "0x296464", VA = "0x6296464")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x296468", Offset = "0x296468", VA = "0x6296468")]
		private void OnLevelLoadedCallback()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2959D0", Offset = "0x2959D0", VA = "0x62959D0")]
		private void StartDetectionInternal(UnityAction callback, UnityAction<string> callbackWithArgument)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x296D98", Offset = "0x296D98", VA = "0x6296D98", Slot = "9")]
		protected override void StartDetectionAutomatically()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x296DA4", Offset = "0x296DA4", VA = "0x6296DA4", Slot = "11")]
		protected override void PauseDetector()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x296E5C", Offset = "0x296E5C", VA = "0x6296E5C", Slot = "12")]
		protected override void ResumeDetector()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x296F38", Offset = "0x296F38", VA = "0x6296F38", Slot = "10")]
		protected override void StopDetectionInternal()
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x297004", Offset = "0x297004", VA = "0x6297004", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x296BE4", Offset = "0x296BE4", VA = "0x6296BE4")]
		private void OnCheatingDetected(string cause)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x297148", Offset = "0x297148", VA = "0x6297148")]
		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x296C60", Offset = "0x296C60", VA = "0x6296C60")]
		private bool FindInjectionInCurrentAssemblies(out string cause)
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2971DC", Offset = "0x2971DC", VA = "0x62971DC")]
		private bool AssemblyAllowed(Assembly ass)
		{
			return default(bool);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x296598", Offset = "0x296598", VA = "0x6296598")]
		private void LoadAndParseAllowedAssemblies()
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x297378", Offset = "0x297378", VA = "0x6297378")]
		private int GetAssemblyHash(Assembly ass)
		{
			return 0;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x29753C", Offset = "0x29753C", VA = "0x629753C")]
		private string PublicKeyTokenToString(byte[] bytes)
		{
			return null;
		}

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400005D")]
		internal const string COMPONENT_NAME = "Injection Detector";

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x400005E")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x1C")]
		protected UnityAction<string> detectionActionWithArgument;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x20")]
		private bool signaturesAreNotGenuine;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x24")]
		private InjectionDetector.AllowedAssembly[] allowedAssemblies;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x28")]
		private string[] hexTable;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180334", Offset = "0x180334")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x180334", Offset = "0x180334")]
		private static InjectionDetector <Instance>k__BackingField;

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000010")]
		private class AllowedAssembly
		{
			// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x297514", Offset = "0x297514", VA = "0x6297514")]
			public AllowedAssembly(string name, int[] hashes)
			{
			}

			// Token: 0x040000A7 RID: 167
			[Token(Token = "0x4000065")]
			[FieldOffset(Offset = "0x8")]
			public readonly string name;

			// Token: 0x040000A8 RID: 168
			[Token(Token = "0x4000066")]
			[FieldOffset(Offset = "0xC")]
			public readonly int[] hashes;
		}
	}
}
