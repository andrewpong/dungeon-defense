using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000189")]
	internal class TurnBasedManager
	{
		// Token: 0x06000DF5 RID: 3573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x488E80", Offset = "0x488E80", VA = "0x6488E80")]
		internal TurnBasedManager(GameServices services)
		{
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x488EA0", Offset = "0x488EA0", VA = "0x6488EA0")]
		internal void GetMatch(string matchId, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
		{
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x48895C", Offset = "0x48895C", VA = "0x648895C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186F7C", Offset = "0x186F7C")]
		internal static void InternalTurnBasedMatchCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x4890E0", Offset = "0x4890E0", VA = "0x64890E0")]
		internal void CreateMatch(TurnBasedMatchConfig config, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
		{
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x489224", Offset = "0x489224", VA = "0x6489224")]
		internal void ShowPlayerSelectUI(uint minimumPlayers, uint maxiumPlayers, bool allowAutomatching, Action<PlayerSelectUIResponse> callback)
		{
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x488A08", Offset = "0x488A08", VA = "0x6488A08")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x186FF4", Offset = "0x186FF4")]
		internal static void InternalPlayerSelectUIcallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x48940C", Offset = "0x48940C", VA = "0x648940C")]
		internal void GetAllTurnbasedMatches(Action<TurnBasedManager.TurnBasedMatchesResponse> callback)
		{
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x488AB4", Offset = "0x488AB4", VA = "0x6488AB4")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18706C", Offset = "0x18706C")]
		internal static void InternalTurnBasedMatchesCallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x4895DC", Offset = "0x4895DC", VA = "0x64895DC")]
		internal void AcceptInvitation(MultiplayerInvitation invitation, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
		{
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x4897FC", Offset = "0x4897FC", VA = "0x64897FC")]
		internal void DeclineInvitation(MultiplayerInvitation invitation)
		{
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x489864", Offset = "0x489864", VA = "0x6489864")]
		internal void TakeTurn(NativeTurnBasedMatch match, byte[] data, MultiplayerParticipant nextParticipant, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
		{
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x488B60", Offset = "0x488B60", VA = "0x6488B60")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1870E4", Offset = "0x1870E4")]
		internal static void InternalMatchInboxUICallback(IntPtr response, IntPtr data)
		{
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x489A4C", Offset = "0x489A4C", VA = "0x6489A4C")]
		internal void ShowInboxUI(Action<TurnBasedManager.MatchInboxUIResponse> callback)
		{
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x488C0C", Offset = "0x488C0C", VA = "0x6488C0C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18715C", Offset = "0x18715C")]
		internal static void InternalMultiplayerStatusCallback(CommonErrorStatus.MultiplayerStatus status, IntPtr data)
		{
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x489C1C", Offset = "0x489C1C", VA = "0x6489C1C")]
		internal void LeaveDuringMyTurn(NativeTurnBasedMatch match, MultiplayerParticipant nextParticipant, Action<CommonErrorStatus.MultiplayerStatus> callback)
		{
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x489DB8", Offset = "0x489DB8", VA = "0x6489DB8")]
		internal void FinishMatchDuringMyTurn(NativeTurnBasedMatch match, byte[] data, ParticipantResults results, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
		{
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x489F5C", Offset = "0x489F5C", VA = "0x6489F5C")]
		internal void ConfirmPendingCompletion(NativeTurnBasedMatch match, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
		{
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x48A0A0", Offset = "0x48A0A0", VA = "0x648A0A0")]
		internal void LeaveMatchDuringTheirTurn(NativeTurnBasedMatch match, Action<CommonErrorStatus.MultiplayerStatus> callback)
		{
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x48A214", Offset = "0x48A214", VA = "0x648A214")]
		internal void CancelMatch(NativeTurnBasedMatch match, Action<CommonErrorStatus.MultiplayerStatus> callback)
		{
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x48A388", Offset = "0x48A388", VA = "0x648A388")]
		internal void DismissMatch(NativeTurnBasedMatch match)
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x48A3F0", Offset = "0x48A3F0", VA = "0x648A3F0")]
		internal void Rematch(NativeTurnBasedMatch match, Action<TurnBasedManager.TurnBasedMatchResponse> callback)
		{
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x000064F8 File Offset: 0x000046F8
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x488FC8", Offset = "0x488FC8", VA = "0x6488FC8")]
		private static IntPtr ToCallbackPointer(Action<TurnBasedManager.TurnBasedMatchResponse> callback)
		{
			return 0;
		}

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly GameServices mGameServices;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1813A0", Offset = "0x1813A0")]
		private static TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cache0;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1813B0", Offset = "0x1813B0")]
		private static TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cache1;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1813C0", Offset = "0x1813C0")]
		private static Func<IntPtr, PlayerSelectUIResponse> <>f__mg$cache2;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1813D0", Offset = "0x1813D0")]
		private static TurnBasedMultiplayerManager.PlayerSelectUICallback <>f__mg$cache3;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1813E0", Offset = "0x1813E0")]
		private static Func<IntPtr, TurnBasedManager.TurnBasedMatchesResponse> <>f__mg$cache4;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1813F0", Offset = "0x1813F0")]
		private static TurnBasedMultiplayerManager.TurnBasedMatchesCallback <>f__mg$cache5;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181400", Offset = "0x181400")]
		private static TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cache6;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181410", Offset = "0x181410")]
		private static TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cache7;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181420", Offset = "0x181420")]
		private static Func<IntPtr, TurnBasedManager.MatchInboxUIResponse> <>f__mg$cache8;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181430", Offset = "0x181430")]
		private static TurnBasedMultiplayerManager.MatchInboxUICallback <>f__mg$cache9;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181440", Offset = "0x181440")]
		private static TurnBasedMultiplayerManager.MultiplayerStatusCallback <>f__mg$cacheA;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181450", Offset = "0x181450")]
		private static TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cacheB;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181460", Offset = "0x181460")]
		private static TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cacheC;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181470", Offset = "0x181470")]
		private static TurnBasedMultiplayerManager.MultiplayerStatusCallback <>f__mg$cacheD;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181480", Offset = "0x181480")]
		private static TurnBasedMultiplayerManager.MultiplayerStatusCallback <>f__mg$cacheE;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181490", Offset = "0x181490")]
		private static TurnBasedMultiplayerManager.TurnBasedMatchCallback <>f__mg$cacheF;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1814A0", Offset = "0x1814A0")]
		private static Func<IntPtr, TurnBasedManager.TurnBasedMatchResponse> <>f__mg$cache10;

		// Token: 0x02000211 RID: 529
		// (Invoke) Token: 0x06000E0C RID: 3596
		[Token(Token = "0x200018A")]
		internal delegate void TurnBasedMatchCallback(TurnBasedManager.TurnBasedMatchResponse response);

		// Token: 0x02000212 RID: 530
		[Token(Token = "0x200018B")]
		internal class MatchInboxUIResponse : BaseReferenceHolder
		{
			// Token: 0x06000E0F RID: 3599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x48A534", Offset = "0x48A534", VA = "0x648A534")]
			internal MatchInboxUIResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000E10 RID: 3600 RVA: 0x00006510 File Offset: 0x00004710
			[Token(Token = "0x6000CC4")]
			[Address(RVA = "0x48A5C0", Offset = "0x48A5C0", VA = "0x648A5C0")]
			internal CommonErrorStatus.UIStatus UiStatus()
			{
				return (CommonErrorStatus.UIStatus)0;
			}

			// Token: 0x06000E11 RID: 3601 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x48A5F0", Offset = "0x48A5F0", VA = "0x648A5F0")]
			internal NativeTurnBasedMatch Match()
			{
				return null;
			}

			// Token: 0x06000E12 RID: 3602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x48A6B0", Offset = "0x48A6B0", VA = "0x648A6B0", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000E13 RID: 3603 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x48A6C0", Offset = "0x48A6C0", VA = "0x648A6C0")]
			internal static TurnBasedManager.MatchInboxUIResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		// Token: 0x02000213 RID: 531
		[Token(Token = "0x200018C")]
		internal class TurnBasedMatchResponse : BaseReferenceHolder
		{
			// Token: 0x06000E14 RID: 3604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x48AB50", Offset = "0x48AB50", VA = "0x648AB50")]
			internal TurnBasedMatchResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000E15 RID: 3605 RVA: 0x00006528 File Offset: 0x00004728
			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x48ABDC", Offset = "0x48ABDC", VA = "0x648ABDC")]
			internal CommonErrorStatus.MultiplayerStatus ResponseStatus()
			{
				return (CommonErrorStatus.MultiplayerStatus)0;
			}

			// Token: 0x06000E16 RID: 3606 RVA: 0x00006540 File Offset: 0x00004740
			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x48AC0C", Offset = "0x48AC0C", VA = "0x648AC0C")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			// Token: 0x06000E17 RID: 3607 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x48AC4C", Offset = "0x48AC4C", VA = "0x648AC4C")]
			internal NativeTurnBasedMatch Match()
			{
				return null;
			}

			// Token: 0x06000E18 RID: 3608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x48ACF8", Offset = "0x48ACF8", VA = "0x648ACF8", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000E19 RID: 3609 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x48AD08", Offset = "0x48AD08", VA = "0x648AD08")]
			internal static TurnBasedManager.TurnBasedMatchResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		// Token: 0x02000214 RID: 532
		[Token(Token = "0x200018D")]
		internal class TurnBasedMatchesResponse : BaseReferenceHolder
		{
			// Token: 0x06000E1A RID: 3610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CCE")]
			[Address(RVA = "0x48ADBC", Offset = "0x48ADBC", VA = "0x648ADBC")]
			internal TurnBasedMatchesResponse(IntPtr selfPointer)
			{
			}

			// Token: 0x06000E1B RID: 3611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x48AE48", Offset = "0x48AE48", VA = "0x648AE48", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			// Token: 0x06000E1C RID: 3612 RVA: 0x00006558 File Offset: 0x00004758
			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x48AE78", Offset = "0x48AE78", VA = "0x648AE78")]
			internal CommonErrorStatus.MultiplayerStatus Status()
			{
				return (CommonErrorStatus.MultiplayerStatus)0;
			}

			// Token: 0x06000E1D RID: 3613 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x48AEA8", Offset = "0x48AEA8", VA = "0x648AEA8")]
			internal IEnumerable<MultiplayerInvitation> Invitations()
			{
				return null;
			}

			// Token: 0x06000E1E RID: 3614 RVA: 0x00006570 File Offset: 0x00004770
			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x48AFA8", Offset = "0x48AFA8", VA = "0x648AFA8")]
			internal int InvitationCount()
			{
				return 0;
			}

			// Token: 0x06000E1F RID: 3615 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0x48AFE8", Offset = "0x48AFE8", VA = "0x648AFE8")]
			internal IEnumerable<NativeTurnBasedMatch> MyTurnMatches()
			{
				return null;
			}

			// Token: 0x06000E20 RID: 3616 RVA: 0x00006588 File Offset: 0x00004788
			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x48B0E8", Offset = "0x48B0E8", VA = "0x648B0E8")]
			internal int MyTurnMatchesCount()
			{
				return 0;
			}

			// Token: 0x06000E21 RID: 3617 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x48B128", Offset = "0x48B128", VA = "0x648B128")]
			internal IEnumerable<NativeTurnBasedMatch> TheirTurnMatches()
			{
				return null;
			}

			// Token: 0x06000E22 RID: 3618 RVA: 0x000065A0 File Offset: 0x000047A0
			[Token(Token = "0x6000CD6")]
			[Address(RVA = "0x48B228", Offset = "0x48B228", VA = "0x648B228")]
			internal int TheirTurnMatchesCount()
			{
				return 0;
			}

			// Token: 0x06000E23 RID: 3619 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x48B268", Offset = "0x48B268", VA = "0x648B268")]
			internal IEnumerable<NativeTurnBasedMatch> CompletedMatches()
			{
				return null;
			}

			// Token: 0x06000E24 RID: 3620 RVA: 0x000065B8 File Offset: 0x000047B8
			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x48B368", Offset = "0x48B368", VA = "0x648B368")]
			internal int CompletedMatchesCount()
			{
				return 0;
			}

			// Token: 0x06000E25 RID: 3621 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x48B3A8", Offset = "0x48B3A8", VA = "0x648B3A8")]
			internal static TurnBasedManager.TurnBasedMatchesResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			// Token: 0x06000E26 RID: 3622 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x48B458", Offset = "0x48B458", VA = "0x648B458")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1871D4", Offset = "0x1871D4")]
			private MultiplayerInvitation <Invitations>m__0(UIntPtr index)
			{
				return null;
			}

			// Token: 0x06000E27 RID: 3623 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x48B4FC", Offset = "0x48B4FC", VA = "0x648B4FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1871E4", Offset = "0x1871E4")]
			private NativeTurnBasedMatch <MyTurnMatches>m__1(UIntPtr index)
			{
				return null;
			}

			// Token: 0x06000E28 RID: 3624 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CDC")]
			[Address(RVA = "0x48B59C", Offset = "0x48B59C", VA = "0x648B59C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1871F4", Offset = "0x1871F4")]
			private NativeTurnBasedMatch <TheirTurnMatches>m__2(UIntPtr index)
			{
				return null;
			}

			// Token: 0x06000E29 RID: 3625 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x48B63C", Offset = "0x48B63C", VA = "0x648B63C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187204", Offset = "0x187204")]
			private NativeTurnBasedMatch <CompletedMatches>m__3(UIntPtr index)
			{
				return null;
			}
		}
	}
}
