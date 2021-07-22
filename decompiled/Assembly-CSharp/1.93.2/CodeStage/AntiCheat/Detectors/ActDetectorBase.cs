using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x200000E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x17EE54", Offset = "0x17EE54")]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x29507C", Offset = "0x29507C", VA = "0x629507C")]
		protected ActDetectorBase()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x295094", Offset = "0x295094", VA = "0x6295094")]
		private void Start()
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x295210", Offset = "0x295210", VA = "0x6295210")]
		private void OnEnable()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x295278", Offset = "0x295278", VA = "0x6295278")]
		private void OnDisable()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x295294", Offset = "0x295294", VA = "0x6295294")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2952A4", Offset = "0x2952A4", VA = "0x62952A4", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x295474", Offset = "0x295474", VA = "0x6295474", Slot = "5")]
		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2956B0", Offset = "0x2956B0", VA = "0x62956B0", Slot = "6")]
		protected virtual void DisposeInternal()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x295734", Offset = "0x295734", VA = "0x6295734", Slot = "7")]
		protected virtual bool DetectorHasAdditionalCallbacks()
		{
			return default(bool);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x29573C", Offset = "0x29573C", VA = "0x629573C", Slot = "8")]
		internal virtual void OnCheatingDetected()
		{
		}

		// Token: 0x060000A1 RID: 161
		[Token(Token = "0x6000081")]
		protected abstract void StartDetectionAutomatically();

		// Token: 0x060000A2 RID: 162
		[Token(Token = "0x6000082")]
		protected abstract void StopDetectionInternal();

		// Token: 0x060000A3 RID: 163
		[Token(Token = "0x6000083")]
		protected abstract void PauseDetector();

		// Token: 0x060000A4 RID: 164
		[Token(Token = "0x6000084")]
		protected abstract void ResumeDetector();

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000051")]
		protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000052")]
		protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000053")]
		protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x0")]
		protected static GameObject detectorsContainer;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x180214", Offset = "0x180214")]
		public bool autoStart;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xD")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x180248", Offset = "0x180248")]
		public bool keepAlive;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0xE")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1802B0", Offset = "0x1802B0")]
		public bool autoDispose;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected UnityEvent detectionEvent;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x14")]
		protected UnityAction detectionAction;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected bool detectionEventHasListener;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x19")]
		protected bool isRunning;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x1A")]
		protected bool started;
	}
}
