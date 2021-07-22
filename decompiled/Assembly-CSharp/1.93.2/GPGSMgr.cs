using System;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200030E RID: 782
[Token(Token = "0x2000279")]
public class GPGSMgr : MonoBehaviour
{
	// Token: 0x0600119C RID: 4508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001010")]
	[Address(RVA = "0x2F6F04", Offset = "0x2F6F04", VA = "0x62F6F04")]
	public GPGSMgr()
	{
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001011")]
	[Address(RVA = "0x2F6F70", Offset = "0x2F6F70", VA = "0x62F6F70")]
	private void Awake()
	{
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x0600119E RID: 4510 RVA: 0x00007098 File Offset: 0x00005298
	// (set) Token: 0x0600119F RID: 4511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000153")]
	public bool bLogin
	{
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x2F70C4", Offset = "0x2F70C4", VA = "0x62F70C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1876FC", Offset = "0x1876FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001013")]
		[Address(RVA = "0x2F70CC", Offset = "0x2F70CC", VA = "0x62F70CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18770C", Offset = "0x18770C")]
		set
		{
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x060011A0 RID: 4512 RVA: 0x000070B0 File Offset: 0x000052B0
	// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000154")]
	public bool bInit
	{
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x2F70D4", Offset = "0x2F70D4", VA = "0x62F70D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18771C", Offset = "0x18771C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x2F70DC", Offset = "0x2F70DC", VA = "0x62F70DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18772C", Offset = "0x18772C")]
		set
		{
		}
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001016")]
	[Address(RVA = "0x2F70E4", Offset = "0x2F70E4", VA = "0x62F70E4")]
	public void InitializeGPGS()
	{
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001017")]
	[Address(RVA = "0x2F7298", Offset = "0x2F7298", VA = "0x62F7298")]
	public void LoginGPGS()
	{
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001018")]
	[Address(RVA = "0x2F745C", Offset = "0x2F745C", VA = "0x62F745C")]
	public void LoginCallBackGPGS(bool result)
	{
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x060011A5 RID: 4517 RVA: 0x000070C8 File Offset: 0x000052C8
	[Token(Token = "0x17000155")]
	public bool isLogin
	{
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x2F7464", Offset = "0x2F7464", VA = "0x62F7464")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101A")]
	[Address(RVA = "0x2F7560", Offset = "0x2F7560", VA = "0x62F7560")]
	public void LogoutGPGS()
	{
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600101B")]
	[Address(RVA = "0x2F7714", Offset = "0x2F7714", VA = "0x62F7714")]
	public Texture2D GetImageGPGS()
	{
		return null;
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600101C")]
	[Address(RVA = "0x2F7894", Offset = "0x2F7894", VA = "0x62F7894")]
	public string GetNameGPGS()
	{
		return null;
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101D")]
	[Address(RVA = "0x2F7AE8", Offset = "0x2F7AE8", VA = "0x62F7AE8")]
	public void ShowAchievement()
	{
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x2F7AF0", Offset = "0x2F7AF0", VA = "0x62F7AF0")]
	public void ShowLeaderboardUI()
	{
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x2F7AF8", Offset = "0x2F7AF8", VA = "0x62F7AF8")]
	public void CheckAchievementDayPass()
	{
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x2F9050", Offset = "0x2F9050", VA = "0x62F9050")]
	public void CheckAchievementRebirth()
	{
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001021")]
	[Address(RVA = "0x2F92BC", Offset = "0x2F92BC", VA = "0x62F92BC")]
	public void ReportLeaderBoard()
	{
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001022")]
	[Address(RVA = "0x2FD930", Offset = "0x2FD930", VA = "0x62FD930")]
	public void ShowCloudData(bool bSave)
	{
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001023")]
	[Address(RVA = "0x2FDB84", Offset = "0x2FDB84", VA = "0x62FDB84")]
	public void CloudSave()
	{
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001024")]
	[Address(RVA = "0x2FDDF8", Offset = "0x2FDDF8", VA = "0x62FDDF8")]
	public void CloudLoad()
	{
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001025")]
	[Address(RVA = "0x2FDE04", Offset = "0x2FDE04", VA = "0x62FDE04")]
	public void SavedGameSelected(SelectUIStatus _status, ISavedGameMetadata _game)
	{
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001026")]
	[Address(RVA = "0x2FE360", Offset = "0x2FE360", VA = "0x62FE360")]
	public void SavedGameOpened(SavedGameRequestStatus _status, ISavedGameMetadata _game)
	{
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001027")]
	[Address(RVA = "0x2FDB90", Offset = "0x2FDB90", VA = "0x62FDB90")]
	private void OpenSavedGame(string filename, bool bSave)
	{
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001028")]
	[Address(RVA = "0x2FE998", Offset = "0x2FE998", VA = "0x62FE998")]
	public void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
	{
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001029")]
	[Address(RVA = "0x2FF0E0", Offset = "0x2FF0E0", VA = "0x62FF0E0")]
	public void OnSavedLoadOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
	{
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102A")]
	[Address(RVA = "0x2FF3D8", Offset = "0x2FF3D8", VA = "0x62FF3D8")]
	private void LoadGameData(ISavedGameMetadata game)
	{
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102B")]
	[Address(RVA = "0x2FF554", Offset = "0x2FF554", VA = "0x62FF554")]
	public void OnSavedGameDataRead(SavedGameRequestStatus status, byte[] data)
	{
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102C")]
	[Address(RVA = "0x2FEB88", Offset = "0x2FEB88", VA = "0x62FEB88")]
	private void SaveGame(ISavedGameMetadata game, byte[] savedData, TimeSpan totalPlaytime)
	{
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102D")]
	[Address(RVA = "0x2FF848", Offset = "0x2FF848", VA = "0x62FF848")]
	public void OnSavedGameWritten(SavedGameRequestStatus status, ISavedGameMetadata game)
	{
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102E")]
	[Address(RVA = "0x2FFB74", Offset = "0x2FFB74", VA = "0x62FFB74")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18773C", Offset = "0x18773C")]
	private static void <CheckAchievementDayPass>m__0(bool success)
	{
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102F")]
	[Address(RVA = "0x2FFB78", Offset = "0x2FFB78", VA = "0x62FFB78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18774C", Offset = "0x18774C")]
	private static void <CheckAchievementDayPass>m__1(bool success)
	{
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001030")]
	[Address(RVA = "0x2FFB7C", Offset = "0x2FFB7C", VA = "0x62FFB7C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18775C", Offset = "0x18775C")]
	private static void <CheckAchievementDayPass>m__2(bool success)
	{
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001031")]
	[Address(RVA = "0x2FFB80", Offset = "0x2FFB80", VA = "0x62FFB80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18776C", Offset = "0x18776C")]
	private static void <CheckAchievementDayPass>m__3(bool success)
	{
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001032")]
	[Address(RVA = "0x2FFB84", Offset = "0x2FFB84", VA = "0x62FFB84")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18777C", Offset = "0x18777C")]
	private static void <CheckAchievementDayPass>m__4(bool success)
	{
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001033")]
	[Address(RVA = "0x2FFB88", Offset = "0x2FFB88", VA = "0x62FFB88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18778C", Offset = "0x18778C")]
	private static void <CheckAchievementDayPass>m__5(bool success)
	{
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001034")]
	[Address(RVA = "0x2FFB8C", Offset = "0x2FFB8C", VA = "0x62FFB8C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18779C", Offset = "0x18779C")]
	private static void <CheckAchievementDayPass>m__6(bool success)
	{
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001035")]
	[Address(RVA = "0x2FFB90", Offset = "0x2FFB90", VA = "0x62FFB90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1877AC", Offset = "0x1877AC")]
	private static void <CheckAchievementDayPass>m__7(bool success)
	{
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001036")]
	[Address(RVA = "0x2FFB94", Offset = "0x2FFB94", VA = "0x62FFB94")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1877BC", Offset = "0x1877BC")]
	private static void <CheckAchievementDayPass>m__8(bool success)
	{
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001037")]
	[Address(RVA = "0x2FFB98", Offset = "0x2FFB98", VA = "0x62FFB98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1877CC", Offset = "0x1877CC")]
	private static void <CheckAchievementDayPass>m__9(bool success)
	{
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001038")]
	[Address(RVA = "0x2FFB9C", Offset = "0x2FFB9C", VA = "0x62FFB9C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1877DC", Offset = "0x1877DC")]
	private static void <CheckAchievementRebirth>m__A(bool success)
	{
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001039")]
	[Address(RVA = "0x2FFBA0", Offset = "0x2FFBA0", VA = "0x62FFBA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1877EC", Offset = "0x1877EC")]
	private static void <ReportLeaderBoard>m__B(bool obj)
	{
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103A")]
	[Address(RVA = "0x2FFBA4", Offset = "0x2FFBA4", VA = "0x62FFBA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1877FC", Offset = "0x1877FC")]
	private static void <ReportLeaderBoard>m__C(bool obj)
	{
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103B")]
	[Address(RVA = "0x2FFBA8", Offset = "0x2FFBA8", VA = "0x62FFBA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18780C", Offset = "0x18780C")]
	private static void <ReportLeaderBoard>m__D(bool obj)
	{
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103C")]
	[Address(RVA = "0x2FFBAC", Offset = "0x2FFBAC", VA = "0x62FFBAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18781C", Offset = "0x18781C")]
	private static void <ReportLeaderBoard>m__E(bool obj)
	{
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103D")]
	[Address(RVA = "0x2FFBB0", Offset = "0x2FFBB0", VA = "0x62FFBB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18782C", Offset = "0x18782C")]
	private static void <ReportLeaderBoard>m__F(bool obj)
	{
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103E")]
	[Address(RVA = "0x2FFBB4", Offset = "0x2FFBB4", VA = "0x62FFBB4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18783C", Offset = "0x18783C")]
	private static void <ReportLeaderBoard>m__10(bool obj)
	{
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600103F")]
	[Address(RVA = "0x2FFBB8", Offset = "0x2FFBB8", VA = "0x62FFBB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18784C", Offset = "0x18784C")]
	private static void <ReportLeaderBoard>m__11(bool obj)
	{
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001040")]
	[Address(RVA = "0x2FFBBC", Offset = "0x2FFBBC", VA = "0x62FFBBC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18785C", Offset = "0x18785C")]
	private static void <ReportLeaderBoard>m__12(bool obj)
	{
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001041")]
	[Address(RVA = "0x2FFBC0", Offset = "0x2FFBC0", VA = "0x62FFBC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18786C", Offset = "0x18786C")]
	private static void <ReportLeaderBoard>m__13(bool obj)
	{
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001042")]
	[Address(RVA = "0x2FFBC4", Offset = "0x2FFBC4", VA = "0x62FFBC4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18787C", Offset = "0x18787C")]
	private static void <ReportLeaderBoard>m__14(bool obj)
	{
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001043")]
	[Address(RVA = "0x2FFBC8", Offset = "0x2FFBC8", VA = "0x62FFBC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18788C", Offset = "0x18788C")]
	private static void <ReportLeaderBoard>m__15(bool obj)
	{
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001044")]
	[Address(RVA = "0x2FFBCC", Offset = "0x2FFBCC", VA = "0x62FFBCC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18789C", Offset = "0x18789C")]
	private static void <ReportLeaderBoard>m__16(bool obj)
	{
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001045")]
	[Address(RVA = "0x2FFBD0", Offset = "0x2FFBD0", VA = "0x62FFBD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878AC", Offset = "0x1878AC")]
	private static void <ReportLeaderBoard>m__17(bool obj)
	{
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001046")]
	[Address(RVA = "0x2FFBD4", Offset = "0x2FFBD4", VA = "0x62FFBD4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878BC", Offset = "0x1878BC")]
	private static void <ReportLeaderBoard>m__18(bool obj)
	{
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001047")]
	[Address(RVA = "0x2FFBD8", Offset = "0x2FFBD8", VA = "0x62FFBD8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878CC", Offset = "0x1878CC")]
	private static void <ReportLeaderBoard>m__19(bool obj)
	{
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001048")]
	[Address(RVA = "0x2FFBDC", Offset = "0x2FFBDC", VA = "0x62FFBDC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878DC", Offset = "0x1878DC")]
	private static void <ReportLeaderBoard>m__1A(bool obj)
	{
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001049")]
	[Address(RVA = "0x2FFBE0", Offset = "0x2FFBE0", VA = "0x62FFBE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878EC", Offset = "0x1878EC")]
	private static void <ReportLeaderBoard>m__1B(bool obj)
	{
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104A")]
	[Address(RVA = "0x2FFBE4", Offset = "0x2FFBE4", VA = "0x62FFBE4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878FC", Offset = "0x1878FC")]
	private static void <ReportLeaderBoard>m__1C(bool obj)
	{
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104B")]
	[Address(RVA = "0x2FFBE8", Offset = "0x2FFBE8", VA = "0x62FFBE8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18790C", Offset = "0x18790C")]
	private static void <ReportLeaderBoard>m__1D(bool obj)
	{
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104C")]
	[Address(RVA = "0x2FFBEC", Offset = "0x2FFBEC", VA = "0x62FFBEC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18791C", Offset = "0x18791C")]
	private static void <ReportLeaderBoard>m__1E(bool obj)
	{
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104D")]
	[Address(RVA = "0x2FFBF0", Offset = "0x2FFBF0", VA = "0x62FFBF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18792C", Offset = "0x18792C")]
	private static void <ReportLeaderBoard>m__1F(bool obj)
	{
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104E")]
	[Address(RVA = "0x2FFBF4", Offset = "0x2FFBF4", VA = "0x62FFBF4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18793C", Offset = "0x18793C")]
	private static void <ReportLeaderBoard>m__20(bool obj)
	{
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104F")]
	[Address(RVA = "0x2FFBF8", Offset = "0x2FFBF8", VA = "0x62FFBF8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18794C", Offset = "0x18794C")]
	private static void <ReportLeaderBoard>m__21(bool obj)
	{
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001050")]
	[Address(RVA = "0x2FFBFC", Offset = "0x2FFBFC", VA = "0x62FFBFC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18795C", Offset = "0x18795C")]
	private static void <ReportLeaderBoard>m__22(bool obj)
	{
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001051")]
	[Address(RVA = "0x2FFC00", Offset = "0x2FFC00", VA = "0x62FFC00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18796C", Offset = "0x18796C")]
	private static void <ReportLeaderBoard>m__23(bool obj)
	{
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001052")]
	[Address(RVA = "0x2FFC04", Offset = "0x2FFC04", VA = "0x62FFC04")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18797C", Offset = "0x18797C")]
	private static void <ReportLeaderBoard>m__24(bool obj)
	{
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001053")]
	[Address(RVA = "0x2FFC08", Offset = "0x2FFC08", VA = "0x62FFC08")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18798C", Offset = "0x18798C")]
	private static void <ReportLeaderBoard>m__25(bool obj)
	{
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001054")]
	[Address(RVA = "0x2FFC0C", Offset = "0x2FFC0C", VA = "0x62FFC0C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18799C", Offset = "0x18799C")]
	private static void <ReportLeaderBoard>m__26(bool obj)
	{
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001055")]
	[Address(RVA = "0x2FFC10", Offset = "0x2FFC10", VA = "0x62FFC10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879AC", Offset = "0x1879AC")]
	private static void <ReportLeaderBoard>m__27(bool obj)
	{
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001056")]
	[Address(RVA = "0x2FFC14", Offset = "0x2FFC14", VA = "0x62FFC14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879BC", Offset = "0x1879BC")]
	private static void <ReportLeaderBoard>m__28(bool obj)
	{
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001057")]
	[Address(RVA = "0x2FFC18", Offset = "0x2FFC18", VA = "0x62FFC18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879CC", Offset = "0x1879CC")]
	private static void <ReportLeaderBoard>m__29(bool obj)
	{
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001058")]
	[Address(RVA = "0x2FFC1C", Offset = "0x2FFC1C", VA = "0x62FFC1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879DC", Offset = "0x1879DC")]
	private static void <ReportLeaderBoard>m__2A(bool obj)
	{
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001059")]
	[Address(RVA = "0x2FFC20", Offset = "0x2FFC20", VA = "0x62FFC20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879EC", Offset = "0x1879EC")]
	private static void <ReportLeaderBoard>m__2B(bool obj)
	{
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105A")]
	[Address(RVA = "0x2FFC24", Offset = "0x2FFC24", VA = "0x62FFC24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879FC", Offset = "0x1879FC")]
	private static void <ReportLeaderBoard>m__2C(bool obj)
	{
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105B")]
	[Address(RVA = "0x2FFC28", Offset = "0x2FFC28", VA = "0x62FFC28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A0C", Offset = "0x187A0C")]
	private static void <ReportLeaderBoard>m__2D(bool obj)
	{
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x2FFC2C", Offset = "0x2FFC2C", VA = "0x62FFC2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A1C", Offset = "0x187A1C")]
	private static void <ReportLeaderBoard>m__2E(bool obj)
	{
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x2FFC30", Offset = "0x2FFC30", VA = "0x62FFC30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A2C", Offset = "0x187A2C")]
	private static void <ReportLeaderBoard>m__2F(bool obj)
	{
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105E")]
	[Address(RVA = "0x2FFC34", Offset = "0x2FFC34", VA = "0x62FFC34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A3C", Offset = "0x187A3C")]
	private static void <ReportLeaderBoard>m__30(bool obj)
	{
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105F")]
	[Address(RVA = "0x2FFC38", Offset = "0x2FFC38", VA = "0x62FFC38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A4C", Offset = "0x187A4C")]
	private static void <ReportLeaderBoard>m__31(bool obj)
	{
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001060")]
	[Address(RVA = "0x2FFC3C", Offset = "0x2FFC3C", VA = "0x62FFC3C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A5C", Offset = "0x187A5C")]
	private static void <ReportLeaderBoard>m__32(bool obj)
	{
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001061")]
	[Address(RVA = "0x2FFC40", Offset = "0x2FFC40", VA = "0x62FFC40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A6C", Offset = "0x187A6C")]
	private static void <ReportLeaderBoard>m__33(bool obj)
	{
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x2FFC44", Offset = "0x2FFC44", VA = "0x62FFC44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A7C", Offset = "0x187A7C")]
	private static void <ReportLeaderBoard>m__34(bool obj)
	{
	}

	// Token: 0x04000F93 RID: 3987
	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x0")]
	public static GPGSMgr single;

	// Token: 0x04000F94 RID: 3988
	[Token(Token = "0x4000DE5")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184B90", Offset = "0x184B90")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x184B90", Offset = "0x184B90")]
	private bool <bLogin>k__BackingField;

	// Token: 0x04000F95 RID: 3989
	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0xD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184BC4", Offset = "0x184BC4")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x184BC4", Offset = "0x184BC4")]
	private bool <bInit>k__BackingField;

	// Token: 0x04000F96 RID: 3990
	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0x10")]
	private string strCloud;

	// Token: 0x04000F97 RID: 3991
	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x14")]
	private bool isSaving;

	// Token: 0x04000F98 RID: 3992
	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184BF8", Offset = "0x184BF8")]
	private static Action<bool> <>f__am$cache0;

	// Token: 0x04000F99 RID: 3993
	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C08", Offset = "0x184C08")]
	private static Action<bool> <>f__am$cache1;

	// Token: 0x04000F9A RID: 3994
	[Token(Token = "0x4000DEB")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C18", Offset = "0x184C18")]
	private static Action<bool> <>f__am$cache2;

	// Token: 0x04000F9B RID: 3995
	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C28", Offset = "0x184C28")]
	private static Action<bool> <>f__am$cache3;

	// Token: 0x04000F9C RID: 3996
	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C38", Offset = "0x184C38")]
	private static Action<bool> <>f__am$cache4;

	// Token: 0x04000F9D RID: 3997
	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C48", Offset = "0x184C48")]
	private static Action<bool> <>f__am$cache5;

	// Token: 0x04000F9E RID: 3998
	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C58", Offset = "0x184C58")]
	private static Action<bool> <>f__am$cache6;

	// Token: 0x04000F9F RID: 3999
	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C68", Offset = "0x184C68")]
	private static Action<bool> <>f__am$cache7;

	// Token: 0x04000FA0 RID: 4000
	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C78", Offset = "0x184C78")]
	private static Action<bool> <>f__am$cache8;

	// Token: 0x04000FA1 RID: 4001
	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C88", Offset = "0x184C88")]
	private static Action<bool> <>f__am$cache9;

	// Token: 0x04000FA2 RID: 4002
	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184C98", Offset = "0x184C98")]
	private static Action<bool> <>f__am$cacheA;

	// Token: 0x04000FA3 RID: 4003
	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184CA8", Offset = "0x184CA8")]
	private static Action<bool> <>f__am$cacheB;

	// Token: 0x04000FA4 RID: 4004
	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184CB8", Offset = "0x184CB8")]
	private static Action<bool> <>f__am$cacheC;

	// Token: 0x04000FA5 RID: 4005
	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184CC8", Offset = "0x184CC8")]
	private static Action<bool> <>f__am$cacheD;

	// Token: 0x04000FA6 RID: 4006
	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184CD8", Offset = "0x184CD8")]
	private static Action<bool> <>f__am$cacheE;

	// Token: 0x04000FA7 RID: 4007
	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184CE8", Offset = "0x184CE8")]
	private static Action<bool> <>f__am$cacheF;

	// Token: 0x04000FA8 RID: 4008
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184CF8", Offset = "0x184CF8")]
	private static Action<bool> <>f__am$cache10;

	// Token: 0x04000FA9 RID: 4009
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D08", Offset = "0x184D08")]
	private static Action<bool> <>f__am$cache11;

	// Token: 0x04000FAA RID: 4010
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D18", Offset = "0x184D18")]
	private static Action<bool> <>f__am$cache12;

	// Token: 0x04000FAB RID: 4011
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D28", Offset = "0x184D28")]
	private static Action<bool> <>f__am$cache13;

	// Token: 0x04000FAC RID: 4012
	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D38", Offset = "0x184D38")]
	private static Action<bool> <>f__am$cache14;

	// Token: 0x04000FAD RID: 4013
	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D48", Offset = "0x184D48")]
	private static Action<bool> <>f__am$cache15;

	// Token: 0x04000FAE RID: 4014
	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D58", Offset = "0x184D58")]
	private static Action<bool> <>f__am$cache16;

	// Token: 0x04000FAF RID: 4015
	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D68", Offset = "0x184D68")]
	private static Action<bool> <>f__am$cache17;

	// Token: 0x04000FB0 RID: 4016
	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D78", Offset = "0x184D78")]
	private static Action<bool> <>f__am$cache18;

	// Token: 0x04000FB1 RID: 4017
	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D88", Offset = "0x184D88")]
	private static Action<bool> <>f__am$cache19;

	// Token: 0x04000FB2 RID: 4018
	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184D98", Offset = "0x184D98")]
	private static Action<bool> <>f__am$cache1A;

	// Token: 0x04000FB3 RID: 4019
	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184DA8", Offset = "0x184DA8")]
	private static Action<bool> <>f__am$cache1B;

	// Token: 0x04000FB4 RID: 4020
	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184DB8", Offset = "0x184DB8")]
	private static Action<bool> <>f__am$cache1C;

	// Token: 0x04000FB5 RID: 4021
	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184DC8", Offset = "0x184DC8")]
	private static Action<bool> <>f__am$cache1D;

	// Token: 0x04000FB6 RID: 4022
	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184DD8", Offset = "0x184DD8")]
	private static Action<bool> <>f__am$cache1E;

	// Token: 0x04000FB7 RID: 4023
	[Token(Token = "0x4000E08")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184DE8", Offset = "0x184DE8")]
	private static Action<bool> <>f__am$cache1F;

	// Token: 0x04000FB8 RID: 4024
	[Token(Token = "0x4000E09")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184DF8", Offset = "0x184DF8")]
	private static Action<bool> <>f__am$cache20;

	// Token: 0x04000FB9 RID: 4025
	[Token(Token = "0x4000E0A")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E08", Offset = "0x184E08")]
	private static Action<bool> <>f__am$cache21;

	// Token: 0x04000FBA RID: 4026
	[Token(Token = "0x4000E0B")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E18", Offset = "0x184E18")]
	private static Action<bool> <>f__am$cache22;

	// Token: 0x04000FBB RID: 4027
	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E28", Offset = "0x184E28")]
	private static Action<bool> <>f__am$cache23;

	// Token: 0x04000FBC RID: 4028
	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E38", Offset = "0x184E38")]
	private static Action<bool> <>f__am$cache24;

	// Token: 0x04000FBD RID: 4029
	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E48", Offset = "0x184E48")]
	private static Action<bool> <>f__am$cache25;

	// Token: 0x04000FBE RID: 4030
	[Token(Token = "0x4000E0F")]
	[FieldOffset(Offset = "0x9C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E58", Offset = "0x184E58")]
	private static Action<bool> <>f__am$cache26;

	// Token: 0x04000FBF RID: 4031
	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E68", Offset = "0x184E68")]
	private static Action<bool> <>f__am$cache27;

	// Token: 0x04000FC0 RID: 4032
	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E78", Offset = "0x184E78")]
	private static Action<bool> <>f__am$cache28;

	// Token: 0x04000FC1 RID: 4033
	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E88", Offset = "0x184E88")]
	private static Action<bool> <>f__am$cache29;

	// Token: 0x04000FC2 RID: 4034
	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184E98", Offset = "0x184E98")]
	private static Action<bool> <>f__am$cache2A;

	// Token: 0x04000FC3 RID: 4035
	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184EA8", Offset = "0x184EA8")]
	private static Action<bool> <>f__am$cache2B;

	// Token: 0x04000FC4 RID: 4036
	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184EB8", Offset = "0x184EB8")]
	private static Action<bool> <>f__am$cache2C;

	// Token: 0x04000FC5 RID: 4037
	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184EC8", Offset = "0x184EC8")]
	private static Action<bool> <>f__am$cache2D;

	// Token: 0x04000FC6 RID: 4038
	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0xBC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184ED8", Offset = "0x184ED8")]
	private static Action<bool> <>f__am$cache2E;

	// Token: 0x04000FC7 RID: 4039
	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184EE8", Offset = "0x184EE8")]
	private static Action<bool> <>f__am$cache2F;

	// Token: 0x04000FC8 RID: 4040
	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0xC4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184EF8", Offset = "0x184EF8")]
	private static Action<bool> <>f__am$cache30;

	// Token: 0x04000FC9 RID: 4041
	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184F08", Offset = "0x184F08")]
	private static Action<bool> <>f__am$cache31;

	// Token: 0x04000FCA RID: 4042
	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0xCC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184F18", Offset = "0x184F18")]
	private static Action<bool> <>f__am$cache32;

	// Token: 0x04000FCB RID: 4043
	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184F28", Offset = "0x184F28")]
	private static Action<bool> <>f__am$cache33;

	// Token: 0x04000FCC RID: 4044
	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0xD4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184F38", Offset = "0x184F38")]
	private static Action<bool> <>f__am$cache34;
}
