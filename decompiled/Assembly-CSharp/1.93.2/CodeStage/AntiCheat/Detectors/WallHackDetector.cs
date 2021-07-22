using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000013")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x17EFB0", Offset = "0x17EFB0")]
	public class WallHackDetector : ActDetectorBase
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x299988", Offset = "0x299988", VA = "0x6299988")]
		private WallHackDetector()
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x299ABC", Offset = "0x299ABC", VA = "0x6299ABC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x299AC4", Offset = "0x299AC4", VA = "0x6299AC4")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public bool CheckController
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x29BA34", Offset = "0x29BA34", VA = "0x629BA34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x29BA3C", Offset = "0x29BA3C", VA = "0x629BA3C")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public bool CheckWireframe
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x29BD80", Offset = "0x29BD80", VA = "0x629BD80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x29BD88", Offset = "0x29BD88", VA = "0x629BD88")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public bool CheckRaycast
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x29BF4C", Offset = "0x29BF4C", VA = "0x629BF4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x29BF54", Offset = "0x29BF54", VA = "0x629BF54")]
			set
			{
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x29C10C", Offset = "0x29C10C", VA = "0x629C10C")]
		public static void StartDetection()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x29C5C0", Offset = "0x29C5C0", VA = "0x629C5C0")]
		public static void StartDetection(UnityAction callback)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x29C874", Offset = "0x29C874", VA = "0x629C874")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x29C8CC", Offset = "0x29C8CC", VA = "0x629C8CC")]
		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x29C924", Offset = "0x29C924", VA = "0x629C924")]
		public static void StopDetection()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x29CA7C", Offset = "0x29CA7C", VA = "0x629CA7C")]
		public static void Dispose()
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x29C354", Offset = "0x29C354", VA = "0x629C354")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185358", Offset = "0x185358")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x29CBD4", Offset = "0x29CBD4", VA = "0x629CBD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185368", Offset = "0x185368")]
			private set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000020")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x29C600", Offset = "0x29C600", VA = "0x629C600")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x29CC38", Offset = "0x29CC38", VA = "0x629CC38")]
		private void Awake()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x29CDC8", Offset = "0x29CDC8", VA = "0x629CDC8", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x29CFB0", Offset = "0x29CFB0", VA = "0x629CFB0")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x29CFB4", Offset = "0x29CFB4", VA = "0x629CFB4")]
		private void OnLevelLoadedCallback()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x29D0E4", Offset = "0x29D0E4", VA = "0x629D0E4")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x29D274", Offset = "0x29D274", VA = "0x629D274")]
		private void Update()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x29C3B8", Offset = "0x29C3B8", VA = "0x629C3B8")]
		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x29D4A4", Offset = "0x29D4A4", VA = "0x629D4A4", Slot = "9")]
		protected override void StartDetectionAutomatically()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x29D4D4", Offset = "0x29D4D4", VA = "0x629D4D4", Slot = "11")]
		protected override void PauseDetector()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x29D518", Offset = "0x29D518", VA = "0x629D518", Slot = "12")]
		protected override void ResumeDetector()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x29D58C", Offset = "0x29D58C", VA = "0x629D58C", Slot = "10")]
		protected override void StopDetectionInternal()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x29D5C8", Offset = "0x29D5C8", VA = "0x629D5C8", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x299B80", Offset = "0x299B80", VA = "0x6299B80")]
		private void UpdateServiceContainer()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x29D420", Offset = "0x29D420", VA = "0x629D420")]
		[DebuggerHidden]
		private IEnumerator InitDetector()
		{
			return null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x29B650", Offset = "0x29B650", VA = "0x629B650")]
		private void StartRigidModule()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x29BAF8", Offset = "0x29BAF8", VA = "0x629BAF8")]
		private void StartControllerModule()
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x29BE44", Offset = "0x29BE44", VA = "0x629BE44")]
		private void StartWireframeModule()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x29DE14", Offset = "0x29DE14", VA = "0x629DE14")]
		private void ShootWireframeModule()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x29DEA0", Offset = "0x29DEA0", VA = "0x629DEA0")]
		[DebuggerHidden]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x29C010", Offset = "0x29C010", VA = "0x629C010")]
		private void StartRaycastModule()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x29DF2C", Offset = "0x29DF2C", VA = "0x629DF2C")]
		private void ShootRaycastModule()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x29B920", Offset = "0x29B920", VA = "0x629B920")]
		private void StopRigidModule()
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x29BCD0", Offset = "0x29BCD0", VA = "0x629BCD0")]
		private void StopControllerModule()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x29BEE4", Offset = "0x29BEE4", VA = "0x629BEE4")]
		private void StopWireframeModule()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x29C0A4", Offset = "0x29C0A4", VA = "0x629C0A4")]
		private void StopRaycastModule()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x29D8E8", Offset = "0x29D8E8", VA = "0x629D8E8")]
		private void InitRigidModule()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x29DC08", Offset = "0x29DC08", VA = "0x629DC08")]
		private void InitControllerModule()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x29D7F4", Offset = "0x29D7F4", VA = "0x629D7F4")]
		private void UninitRigidModule()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x29DB14", Offset = "0x29DB14", VA = "0x629DB14")]
		private void UninitControllerModule()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x29D218", Offset = "0x29D218", VA = "0x629D218")]
		private bool Detect()
		{
			return default(bool);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x29D70C", Offset = "0x29D70C", VA = "0x629D70C")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x29D780", Offset = "0x29D780", VA = "0x629D780")]
		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return default(bool);
		}

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x400007E")]
		internal const string COMPONENT_NAME = "WallHack Detector";

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x400007F")]
		internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x4000080")]
		private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x4000081")]
		private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x4000082")]
		private const int SHADER_TEXTURE_SIZE = 4;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x4000083")]
		private const int RENDER_TEXTURE_SIZE = 4;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Vector3 rigidPlayerVelocity;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x28")]
		private readonly WaitForEndOfFrame waitForEndOfFrame;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x180560", Offset = "0x180560")]
		private bool checkRigidbody;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1805A8", Offset = "0x1805A8")]
		private bool checkController;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x2E")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1805F0", Offset = "0x1805F0")]
		private bool checkWireframe;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x2F")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x180638", Offset = "0x180638")]
		private bool checkRaycast;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x180680", Offset = "0x180680")]
		[Attribute(Name = "RangeAttribute", RVA = "0x180680", Offset = "0x180680")]
		public int wireframeDelay;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18070C", Offset = "0x18070C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x18070C", Offset = "0x18070C")]
		public int raycastDelay;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x180794", Offset = "0x180794")]
		public Vector3 spawnPosition;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1807C8", Offset = "0x1807C8")]
		public byte maxFalsePositives;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x48")]
		private GameObject serviceContainer;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x4C")]
		private GameObject solidWall;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x50")]
		private GameObject thinWall;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x54")]
		private Camera wfCamera;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x58")]
		private MeshRenderer foregroundRenderer;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x5C")]
		private MeshRenderer backgroundRenderer;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x60")]
		private Color wfColor1;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x70")]
		private Color wfColor2;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x80")]
		private Shader wfShader;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x84")]
		private Material wfMaterial;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D shaderTexture;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x8C")]
		private Texture2D targetTexture;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x90")]
		private RenderTexture renderTexture;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x94")]
		private int whLayer;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x98")]
		private int raycastMask;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x9C")]
		private Rigidbody rigidPlayer;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xA0")]
		private CharacterController charControllerPlayer;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0xA4")]
		private float charControllerVelocity;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xA8")]
		private byte rigidbodyDetections;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0xA9")]
		private byte controllerDetections;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xAA")]
		private byte wireframeDetections;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0xAB")]
		private byte raycastDetections;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0xAC")]
		private bool wireframeDetected;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1807FC", Offset = "0x1807FC")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1807FC", Offset = "0x1807FC")]
		private static WallHackDetector <Instance>k__BackingField;

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x20002BA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F610", Offset = "0x17F610")]
		private sealed class <InitDetector>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001460")]
			[Address(RVA = "0x29D7EC", Offset = "0x29D7EC", VA = "0x629D7EC")]
			[DebuggerHidden]
			public <InitDetector>c__Iterator0()
			{
			}

			// Token: 0x0600011E RID: 286 RVA: 0x000023D0 File Offset: 0x000005D0
			[Token(Token = "0x6001461")]
			[Address(RVA = "0x29EAA8", Offset = "0x29EAA8", VA = "0x629EAA8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600011F RID: 287 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001AB")]
			private object Current
			{
				[Token(Token = "0x6001462")]
				[Address(RVA = "0x29EC38", Offset = "0x29EC38", VA = "0x629EC38", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000120 RID: 288 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001AC")]
			private object Current
			{
				[Token(Token = "0x6001463")]
				[Address(RVA = "0x29EC40", Offset = "0x29EC40", VA = "0x629EC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001464")]
			[Address(RVA = "0x29EC48", Offset = "0x29EC48", VA = "0x629EC48", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001465")]
			[Address(RVA = "0x29EC5C", Offset = "0x29EC5C", VA = "0x629EC5C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x4001304")]
			[FieldOffset(Offset = "0x8")]
			internal WallHackDetector $this;

			// Token: 0x040000EA RID: 234
			[Token(Token = "0x4001305")]
			[FieldOffset(Offset = "0xC")]
			internal object $current;

			// Token: 0x040000EB RID: 235
			[Token(Token = "0x4001306")]
			[FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			// Token: 0x040000EC RID: 236
			[Token(Token = "0x4001307")]
			[FieldOffset(Offset = "0x14")]
			internal int $PC;
		}

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x20002BB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F620", Offset = "0x17F620")]
		private sealed class <CaptureFrame>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001466")]
			[Address(RVA = "0x29DF24", Offset = "0x29DF24", VA = "0x629DF24")]
			[DebuggerHidden]
			public <CaptureFrame>c__Iterator1()
			{
			}

			// Token: 0x06000124 RID: 292 RVA: 0x000023E8 File Offset: 0x000005E8
			[Token(Token = "0x6001467")]
			[Address(RVA = "0x29E0D4", Offset = "0x29E0D4", VA = "0x629E0D4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000125 RID: 293 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001AD")]
			private object Current
			{
				[Token(Token = "0x6001468")]
				[Address(RVA = "0x29E9FC", Offset = "0x29E9FC", VA = "0x629E9FC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000126 RID: 294 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001AE")]
			private object Current
			{
				[Token(Token = "0x6001469")]
				[Address(RVA = "0x29EA04", Offset = "0x29EA04", VA = "0x629EA04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600146A")]
			[Address(RVA = "0x29EA0C", Offset = "0x29EA0C", VA = "0x629EA0C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600146B")]
			[Address(RVA = "0x29EA20", Offset = "0x29EA20", VA = "0x629EA20", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x040000ED RID: 237
			[Token(Token = "0x4001308")]
			[FieldOffset(Offset = "0x8")]
			internal RenderTexture <previousActive>__0;

			// Token: 0x040000EE RID: 238
			[Token(Token = "0x4001309")]
			[FieldOffset(Offset = "0xC")]
			internal bool <detected>__0;

			// Token: 0x040000EF RID: 239
			[Token(Token = "0x400130A")]
			[FieldOffset(Offset = "0x10")]
			internal WallHackDetector $this;

			// Token: 0x040000F0 RID: 240
			[Token(Token = "0x400130B")]
			[FieldOffset(Offset = "0x14")]
			internal object $current;

			// Token: 0x040000F1 RID: 241
			[Token(Token = "0x400130C")]
			[FieldOffset(Offset = "0x18")]
			internal bool $disposing;

			// Token: 0x040000F2 RID: 242
			[Token(Token = "0x400130D")]
			[FieldOffset(Offset = "0x1C")]
			internal int $PC;
		}
	}
}
