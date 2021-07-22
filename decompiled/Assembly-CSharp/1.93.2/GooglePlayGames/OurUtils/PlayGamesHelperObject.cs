using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x2000078")]
	public class PlayGamesHelperObject : MonoBehaviour
	{
		// Token: 0x0600059A RID: 1434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x48E0AC", Offset = "0x48E0AC", VA = "0x648E0AC")]
		public PlayGamesHelperObject()
		{
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x48E138", Offset = "0x48E138", VA = "0x648E138")]
		public static void CreateObject()
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x48E368", Offset = "0x48E368", VA = "0x648E368")]
		public void Awake()
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x48E3FC", Offset = "0x48E3FC", VA = "0x648E3FC")]
		public void OnDisable()
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x48E518", Offset = "0x48E518", VA = "0x648E518")]
		public static void RunCoroutine(IEnumerator action)
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x48D054", Offset = "0x48D054", VA = "0x648D054")]
		public static void RunOnGameThread(Action action)
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x48E694", Offset = "0x48E694", VA = "0x648E694")]
		public void Update()
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x48E9AC", Offset = "0x48E9AC", VA = "0x648E9AC")]
		public void OnApplicationFocus(bool focused)
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x48ED18", Offset = "0x48ED18", VA = "0x648ED18")]
		public void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x48F084", Offset = "0x48F084", VA = "0x648F084")]
		public static void AddFocusCallback(Action<bool> callback)
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x48F1B8", Offset = "0x48F1B8", VA = "0x648F1B8")]
		public static bool RemoveFocusCallback(Action<bool> callback)
		{
			return default(bool);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x48F274", Offset = "0x48F274", VA = "0x648F274")]
		public static void AddPauseCallback(Action<bool> callback)
		{
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x48F3A8", Offset = "0x48F3A8", VA = "0x648F3A8")]
		public static bool RemovePauseCallback(Action<bool> callback)
		{
			return default(bool);
		}

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x0")]
		private static PlayGamesHelperObject instance;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x4")]
		private static bool sIsDummy;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x8")]
		private static List<Action> sQueue;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0xC")]
		private List<Action> localQueue;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0xC")]
		private static bool sQueueEmpty;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x10")]
		private static List<Action<bool>> sPauseCallbackList;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x14")]
		private static List<Action<bool>> sFocusCallbackList;

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x20002CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F720", Offset = "0x17F720")]
		private sealed class <RunCoroutine>c__AnonStorey0
		{
			// Token: 0x060005A8 RID: 1448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001490")]
			[Address(RVA = "0x48E68C", Offset = "0x48E68C", VA = "0x648E68C")]
			public <RunCoroutine>c__AnonStorey0()
			{
			}

			// Token: 0x060005A9 RID: 1449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001491")]
			[Address(RVA = "0x48F580", Offset = "0x48F580", VA = "0x648F580")]
			internal void <>m__0()
			{
			}

			// Token: 0x040002F9 RID: 761
			[Token(Token = "0x400132C")]
			[FieldOffset(Offset = "0x8")]
			internal IEnumerator action;
		}
	}
}
