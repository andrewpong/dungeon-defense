using System;
using System.Collections.Generic;
using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200030F RID: 783
[Token(Token = "0x200027A")]
public class Info
{
	// Token: 0x060011EF RID: 4591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x33092C", Offset = "0x33092C", VA = "0x633092C")]
	public Info()
	{
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x060011F0 RID: 4592 RVA: 0x000070E0 File Offset: 0x000052E0
	[Token(Token = "0x17000156")]
	public static float fDifficult
	{
		[Token(Token = "0x6001064")]
		[Address(RVA = "0x330934", Offset = "0x330934", VA = "0x6330934")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x330A64", Offset = "0x330A64", VA = "0x6330A64")]
	public static PlayerMonsterData GetPlayerMon(int nPos)
	{
		return null;
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x000070F8 File Offset: 0x000052F8
	[Token(Token = "0x6001066")]
	[Address(RVA = "0x330BB8", Offset = "0x330BB8", VA = "0x6330BB8")]
	public static int GetMonPos(PlayerMonsterData pData)
	{
		return 0;
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000157")]
	public static PlayerMonsterData currentMon
	{
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x330D28", Offset = "0x330D28", VA = "0x6330D28")]
		get
		{
			return null;
		}
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001068")]
	[Address(RVA = "0x330E0C", Offset = "0x330E0C", VA = "0x6330E0C")]
	public static PlayerItemData GetPlayerWeapon(long uid)
	{
		return null;
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001069")]
	[Address(RVA = "0x331068", Offset = "0x331068", VA = "0x6331068")]
	public static PlayerAccData GetPlayerAcc(long uid)
	{
		return null;
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00007110 File Offset: 0x00005310
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x3312C4", Offset = "0x3312C4", VA = "0x63312C4")]
	public static int GetDungeon(DungeonType eID)
	{
		return 0;
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x00007128 File Offset: 0x00005328
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x331544", Offset = "0x331544", VA = "0x6331544")]
	public static int GetSkill(int nPos, SkillKey eSkill)
	{
		return 0;
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00007140 File Offset: 0x00005340
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x3315D4", Offset = "0x3315D4", VA = "0x63315D4")]
	public static int GetSkill(PlayerMonsterData pData, SkillKey eSkill, bool bOriginal = false)
	{
		return 0;
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x00007158 File Offset: 0x00005358
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x331A18", Offset = "0x331A18", VA = "0x6331A18")]
	public static float GetAccModFac(ModType eID)
	{
		return 0f;
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00007170 File Offset: 0x00005370
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x331B40", Offset = "0x331B40", VA = "0x6331B40")]
	public static float GetAccModFac(int nPos, ModType eID)
	{
		return 0f;
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x00007188 File Offset: 0x00005388
	[Token(Token = "0x600106F")]
	[Address(RVA = "0x331954", Offset = "0x331954", VA = "0x6331954")]
	public static int GetAccModFacToInt(int nPos, ModType eID)
	{
		return 0;
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x000071A0 File Offset: 0x000053A0
	[Token(Token = "0x6001070")]
	[Address(RVA = "0x331CA8", Offset = "0x331CA8", VA = "0x6331CA8")]
	public static float GetSkillFac(int nPos, SkillKey eKey)
	{
		return 0f;
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x000071B8 File Offset: 0x000053B8
	[Token(Token = "0x6001071")]
	[Address(RVA = "0x331D34", Offset = "0x331D34", VA = "0x6331D34")]
	public static float GetSkillFac(PlayerMonsterData pData, SkillKey eKey)
	{
		return 0f;
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x000071D0 File Offset: 0x000053D0
	[Token(Token = "0x6001072")]
	[Address(RVA = "0x331EB8", Offset = "0x331EB8", VA = "0x6331EB8")]
	public static float GetSkillFac2(int nPos, SkillKey eKey)
	{
		return 0f;
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x000071E8 File Offset: 0x000053E8
	[Token(Token = "0x6001073")]
	[Address(RVA = "0x331F44", Offset = "0x331F44", VA = "0x6331F44")]
	public static float GetSkillFac2(PlayerMonsterData pData, SkillKey eKey)
	{
		return 0f;
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001074")]
	[Address(RVA = "0x33206C", Offset = "0x33206C", VA = "0x633206C")]
	public static void HireMonster(short sID)
	{
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06001201 RID: 4609 RVA: 0x00007200 File Offset: 0x00005400
	[Token(Token = "0x17000158")]
	public static int nCurHire
	{
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x3338DC", Offset = "0x3338DC", VA = "0x63338DC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06001202 RID: 4610 RVA: 0x00007218 File Offset: 0x00005418
	[Token(Token = "0x17000159")]
	public static int nMaxHire
	{
		[Token(Token = "0x6001076")]
		[Address(RVA = "0x333A48", Offset = "0x333A48", VA = "0x6333A48")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x00007230 File Offset: 0x00005430
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x333008", Offset = "0x333008", VA = "0x6333008")]
	public static int HireMonster(PlayerMonsterData data)
	{
		return 0;
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001078")]
	[Address(RVA = "0x3341AC", Offset = "0x3341AC", VA = "0x63341AC")]
	public static void DismissMonster(int nPos)
	{
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00007248 File Offset: 0x00005448
	[Token(Token = "0x6001079")]
	[Address(RVA = "0x3344F4", Offset = "0x3344F4", VA = "0x63344F4")]
	public static bool CanHireMonster()
	{
		return default(bool);
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107A")]
	[Address(RVA = "0x334584", Offset = "0x334584", VA = "0x6334584")]
	public static void RefreshHireMonster()
	{
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600107B")]
	[Address(RVA = "0x3320F8", Offset = "0x3320F8", VA = "0x63320F8")]
	public static PlayerMonsterData GetNewPlayerMon(short sID, bool bLevel = false, bool bStartLv = true)
	{
		return null;
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x00007260 File Offset: 0x00005460
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x3358FC", Offset = "0x3358FC", VA = "0x63358FC")]
	public static bool CanUpgDungeon(DungeonType eID, int nNum = 1)
	{
		return default(bool);
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x00007278 File Offset: 0x00005478
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x335DA4", Offset = "0x335DA4", VA = "0x6335DA4")]
	public static bool UpgDungeon(DungeonType eID, int nNum = 1)
	{
		return default(bool);
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107E")]
	[Address(RVA = "0x336710", Offset = "0x336710", VA = "0x6336710")]
	public static void RefreshDungeonHP()
	{
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x00007290 File Offset: 0x00005490
	[Token(Token = "0x600107F")]
	[Address(RVA = "0x335AC0", Offset = "0x335AC0", VA = "0x6335AC0")]
	public static int GetCostDungeon(DungeonType eID, int nNum = 1)
	{
		return 0;
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x000072A8 File Offset: 0x000054A8
	[Token(Token = "0x6001080")]
	[Address(RVA = "0x333AD4", Offset = "0x333AD4", VA = "0x6333AD4")]
	public static float GetDungeonFactor(DungeonType eID, int nLv = -1)
	{
		return 0f;
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x000072C0 File Offset: 0x000054C0
	[Token(Token = "0x6001081")]
	[Address(RVA = "0x337684", Offset = "0x337684", VA = "0x6337684")]
	public static ObscuredLong AddRandomDropWeapon()
	{
		return default(ObscuredLong);
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x000072D8 File Offset: 0x000054D8
	[Token(Token = "0x6001082")]
	[Address(RVA = "0x337A08", Offset = "0x337A08", VA = "0x6337A08")]
	public static short GetRandomWeapon(int nItemLv, bool bShop)
	{
		return 0;
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001083")]
	[Address(RVA = "0x338238", Offset = "0x338238", VA = "0x6338238")]
	public static void AddWeaponToInventory(PlayerItemData pData)
	{
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x000072F0 File Offset: 0x000054F0
	[Token(Token = "0x6001084")]
	[Address(RVA = "0x334054", Offset = "0x334054", VA = "0x6334054")]
	public static ObscuredLong AddPlayerWeapon(short sID, int nLv)
	{
		return default(ObscuredLong);
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x00007308 File Offset: 0x00005508
	[Token(Token = "0x6001085")]
	[Address(RVA = "0x337FB0", Offset = "0x337FB0", VA = "0x6337FB0")]
	public static ObscuredLong AddDropWeapon(short sID, int nLv = 1)
	{
		return default(ObscuredLong);
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x00007320 File Offset: 0x00005520
	[Token(Token = "0x6001086")]
	[Address(RVA = "0x33A8AC", Offset = "0x33A8AC", VA = "0x633A8AC")]
	public static int GetWage(int nPos)
	{
		return 0;
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x00007338 File Offset: 0x00005538
	[Token(Token = "0x6001087")]
	[Address(RVA = "0x33A9B4", Offset = "0x33A9B4", VA = "0x633A9B4")]
	public static int GetWageByLv(int nLv)
	{
		return 0;
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00007350 File Offset: 0x00005550
	[Token(Token = "0x6001088")]
	[Address(RVA = "0x33A9C4", Offset = "0x33A9C4", VA = "0x633A9C4")]
	public static bool IsEquipped(long uid)
	{
		return default(bool);
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x00007368 File Offset: 0x00005568
	[Token(Token = "0x6001089")]
	[Address(RVA = "0x33ACA0", Offset = "0x33ACA0", VA = "0x633ACA0")]
	public static bool IsEquippedAcc(long uid)
	{
		return default(bool);
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00007380 File Offset: 0x00005580
	[Token(Token = "0x600108A")]
	[Address(RVA = "0x33B0E0", Offset = "0x33B0E0", VA = "0x633B0E0")]
	public static bool IsEquippedAcc(int mon, long uid)
	{
		return default(bool);
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x00007398 File Offset: 0x00005598
	[Token(Token = "0x600108B")]
	[Address(RVA = "0x33B344", Offset = "0x33B344", VA = "0x633B344")]
	public static bool IsEquipped(int mon, long uid)
	{
		return default(bool);
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108C")]
	[Address(RVA = "0x33B4C8", Offset = "0x33B4C8", VA = "0x633B4C8")]
	public static void SetWave(int _nDay)
	{
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108D")]
	[Address(RVA = "0x33BB40", Offset = "0x33BB40", VA = "0x633BB40")]
	public static void NextDay()
	{
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x000073B0 File Offset: 0x000055B0
	[Token(Token = "0x600108E")]
	[Address(RVA = "0x33DDD8", Offset = "0x33DDD8", VA = "0x633DDD8")]
	public static int CalcLevelUp()
	{
		return 0;
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108F")]
	[Address(RVA = "0x3414B4", Offset = "0x3414B4", VA = "0x63414B4")]
	public static void CalcExp(bool bClear)
	{
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x341B84", Offset = "0x341B84", VA = "0x6341B84")]
	public static string GetWeaponTypeName(WeaponType type)
	{
		return null;
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x000073C8 File Offset: 0x000055C8
	[Token(Token = "0x6001091")]
	[Address(RVA = "0x341C84", Offset = "0x341C84", VA = "0x6341C84")]
	public static bool CheckWeaponMastery(int nPos, long uid)
	{
		return default(bool);
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x000073E0 File Offset: 0x000055E0
	[Token(Token = "0x6001092")]
	[Address(RVA = "0x341F7C", Offset = "0x341F7C", VA = "0x6341F7C")]
	public static int LearnSkill(int nPos, SkillKey eSkill)
	{
		return 0;
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x000073F8 File Offset: 0x000055F8
	[Token(Token = "0x6001093")]
	[Address(RVA = "0x33543C", Offset = "0x33543C", VA = "0x633543C")]
	public static int LearnSkill(PlayerMonsterData pData, SkillKey eSkill)
	{
		return 0;
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001094")]
	[Address(RVA = "0x340F84", Offset = "0x340F84", VA = "0x6340F84")]
	public static List<SkillKey> GetLearnableSkill(int nPos)
	{
		return null;
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001095")]
	[Address(RVA = "0x334E10", Offset = "0x334E10", VA = "0x6334E10")]
	public static List<SkillKey> GetLearnableSkill(PlayerMonsterData pData)
	{
		return null;
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x00007410 File Offset: 0x00005610
	[Token(Token = "0x6001096")]
	[Address(RVA = "0x341430", Offset = "0x341430", VA = "0x6341430")]
	public static SkillKey GetRandomMastery(int nPos)
	{
		return SkillKey.eReloading;
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x00007428 File Offset: 0x00005628
	[Token(Token = "0x6001097")]
	[Address(RVA = "0x335674", Offset = "0x335674", VA = "0x6335674")]
	public static SkillKey GetRandomMastery(PlayerMonsterData pData)
	{
		return SkillKey.eReloading;
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001098")]
	[Address(RVA = "0x342188", Offset = "0x342188", VA = "0x6342188")]
	public static void RefreshPartySkill()
	{
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x00007440 File Offset: 0x00005640
	[Token(Token = "0x6001099")]
	[Address(RVA = "0x342F20", Offset = "0x342F20", VA = "0x6342F20")]
	public static float GetPartySkill(SkillKey eSkill)
	{
		return 0f;
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x00007458 File Offset: 0x00005658
	[Token(Token = "0x600109A")]
	[Address(RVA = "0x337210", Offset = "0x337210", VA = "0x6337210")]
	public static float GetPartySkillFac(SkillKey eSkill)
	{
		return 0f;
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x00007470 File Offset: 0x00005670
	[Token(Token = "0x600109B")]
	[Address(RVA = "0x343170", Offset = "0x343170", VA = "0x6343170")]
	public static float GetPartySkillFac2(SkillKey eSkill)
	{
		return 0f;
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06001228 RID: 4648 RVA: 0x00007488 File Offset: 0x00005688
	[Token(Token = "0x1700015A")]
	public static int nRepairCostOnePoint
	{
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x34327C", Offset = "0x34327C", VA = "0x634327C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06001229 RID: 4649 RVA: 0x000074A0 File Offset: 0x000056A0
	[Token(Token = "0x1700015B")]
	public static int nRepairCost
	{
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x3433BC", Offset = "0x3433BC", VA = "0x63433BC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600109E")]
	[Address(RVA = "0x341008", Offset = "0x341008", VA = "0x6341008")]
	public static void AddSummaryMessageLv(int nPos, int nLv)
	{
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600109F")]
	[Address(RVA = "0x341254", Offset = "0x341254", VA = "0x6341254")]
	public static void AddSummaryMessageSkill(SkillKey eSkill, int nSkillLv)
	{
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x33E80C", Offset = "0x33E80C", VA = "0x633E80C")]
	public static void RefreshShopItem()
	{
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A1")]
	[Address(RVA = "0x338360", Offset = "0x338360", VA = "0x6338360")]
	public static PlayerItemData NewPlayerItem(short sID, int nLv, bool bShop = false)
	{
		return null;
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x000074B8 File Offset: 0x000056B8
	[Token(Token = "0x60010A2")]
	[Address(RVA = "0x343638", Offset = "0x343638", VA = "0x6343638")]
	public static int GetItemPrice(PlayerItemData data)
	{
		return 0;
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x000074D0 File Offset: 0x000056D0
	[Token(Token = "0x60010A3")]
	[Address(RVA = "0x343768", Offset = "0x343768", VA = "0x6343768")]
	public static int GetItemPriceByLv(int nLv)
	{
		return 0;
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x000074E8 File Offset: 0x000056E8
	[Token(Token = "0x60010A4")]
	[Address(RVA = "0x343778", Offset = "0x343778", VA = "0x6343778")]
	public static float GetItemPower(int nLv)
	{
		return 0f;
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x00007500 File Offset: 0x00005700
	[Token(Token = "0x60010A5")]
	[Address(RVA = "0x34395C", Offset = "0x34395C", VA = "0x634395C")]
	public static float GetItemPower(int nLv, float fPow)
	{
		return 0f;
	}

	// Token: 0x06001232 RID: 4658 RVA: 0x00007518 File Offset: 0x00005718
	[Token(Token = "0x60010A6")]
	[Address(RVA = "0x3439F8", Offset = "0x3439F8", VA = "0x63439F8")]
	public static float GetItemPower(int nLv, float fPow, float fPow2)
	{
		return 0f;
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06001233 RID: 4659 RVA: 0x00007530 File Offset: 0x00005730
	[Token(Token = "0x1700015C")]
	public static long nTodayStone
	{
		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x343A9C", Offset = "0x343A9C", VA = "0x6343A9C")]
		get
		{
			return 0L;
		}
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00007548 File Offset: 0x00005748
	[Token(Token = "0x60010A8")]
	[Address(RVA = "0x343BD8", Offset = "0x343BD8", VA = "0x6343BD8")]
	public static long GetStone(int nDay, int nDiff)
	{
		return 0L;
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06001235 RID: 4661 RVA: 0x00007560 File Offset: 0x00005760
	[Token(Token = "0x1700015D")]
	public static int nTodayRuby
	{
		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x343FC4", Offset = "0x343FC4", VA = "0x6343FC4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00007578 File Offset: 0x00005778
	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x344100", Offset = "0x344100", VA = "0x6344100")]
	public static int GetRuby(int nWave, int nDiff)
	{
		return 0;
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x00007590 File Offset: 0x00005790
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x3445C8", Offset = "0x3445C8", VA = "0x63445C8")]
	public static double GetMonHP(int nLv)
	{
		return 0.0;
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x000075A8 File Offset: 0x000057A8
	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x347068", Offset = "0x347068", VA = "0x6347068")]
	public static float GetMonDmg(int nLv)
	{
		return 0f;
	}

	// Token: 0x06001239 RID: 4665 RVA: 0x000075C0 File Offset: 0x000057C0
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x347324", Offset = "0x347324", VA = "0x6347324")]
	public static Color GetGradeColor(byte byGrade)
	{
		return default(Color);
	}

	// Token: 0x0600123A RID: 4666 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x3473F4", Offset = "0x3473F4", VA = "0x63473F4")]
	public static string GetGradeString(byte byGrade, bool bColor = false)
	{
		return null;
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x000075D8 File Offset: 0x000057D8
	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x347640", Offset = "0x347640", VA = "0x6347640")]
	public static bool CheckBattleItem(long uid)
	{
		return default(bool);
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x341EAC", Offset = "0x341EAC", VA = "0x6341EAC")]
	public static BattleItemData GetBattleItem(long uid)
	{
		return null;
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x347710", Offset = "0x347710", VA = "0x6347710")]
	public static void RefreshBattleItemData()
	{
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x000075F0 File Offset: 0x000057F0
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x347AD0", Offset = "0x347AD0", VA = "0x6347AD0")]
	public static int CalcMasteryLv(int nLv)
	{
		return 0;
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x338D78", Offset = "0x338D78", VA = "0x6338D78")]
	public static void RefreshBattleItemData(PlayerItemData pData)
	{
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00007608 File Offset: 0x00005808
	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x347BD4", Offset = "0x347BD4", VA = "0x6347BD4")]
	public static int GetModCost(long uid, int nSlot)
	{
		return 0;
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00007620 File Offset: 0x00005820
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x347EC8", Offset = "0x347EC8", VA = "0x6347EC8")]
	public static int GetEnchantCost(long uid)
	{
		return 0;
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00007638 File Offset: 0x00005838
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x348158", Offset = "0x348158", VA = "0x6348158")]
	public static int GetSellPrice(int nLv, byte byGrade)
	{
		return 0;
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x00007650 File Offset: 0x00005850
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x348278", Offset = "0x348278", VA = "0x6348278")]
	public static int GetItemPurchasePrice(int nLv, byte byGrade)
	{
		return 0;
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x348348", Offset = "0x348348", VA = "0x6348348")]
	public static ItemModData GetRandomMod(long uid, int nSlot)
	{
		return null;
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x339E60", Offset = "0x339E60", VA = "0x6339E60")]
	public static ItemModData GetRandomMod(PlayerItemData pData, int nSlot = -1, bool bSmith = false)
	{
		return null;
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x33EC88", Offset = "0x33EC88", VA = "0x633EC88")]
	public static void CheckAcvSurvive()
	{
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x00007668 File Offset: 0x00005868
	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x3484C4", Offset = "0x3484C4", VA = "0x63484C4")]
	public static bool IsAchievement(AchievementType eID)
	{
		return default(bool);
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x336958", Offset = "0x336958", VA = "0x6336958")]
	public static void CheckAchievement(AchievementType eID)
	{
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x336E0C", Offset = "0x336E0C", VA = "0x6336E0C")]
	public static void TrySaveAchievement()
	{
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x3483E0", Offset = "0x3483E0", VA = "0x63483E0")]
	public static void TrySaveRebirth()
	{
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x348A54", Offset = "0x348A54", VA = "0x6348A54")]
	public static void RefreshAcvReward()
	{
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00007680 File Offset: 0x00005880
	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x3374FC", Offset = "0x3374FC", VA = "0x63374FC")]
	public static int GetAcvReward(AcvRewardType eID)
	{
		return 0;
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x348F48", Offset = "0x348F48", VA = "0x6348F48")]
	public static string GetAcvRewardDesc(AcvRewardType eID, int nReward)
	{
		return null;
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x349980", Offset = "0x349980", VA = "0x6349980")]
	public static void CheckOneShotAcv(int nKill)
	{
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x0600124F RID: 4687 RVA: 0x00007698 File Offset: 0x00005898
	[Token(Token = "0x1700015E")]
	public static int nMaxEnchant
	{
		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x349A88", Offset = "0x349A88", VA = "0x6349A88")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06001250 RID: 4688 RVA: 0x000076B0 File Offset: 0x000058B0
	[Token(Token = "0x1700015F")]
	public static int nMaxInven
	{
		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x349B54", Offset = "0x349B54", VA = "0x6349B54")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x000076C8 File Offset: 0x000058C8
	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x340E94", Offset = "0x340E94", VA = "0x6340E94")]
	public static int GetNeedExp(int nPos)
	{
		return 0;
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x000076E0 File Offset: 0x000058E0
	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x349C30", Offset = "0x349C30", VA = "0x6349C30")]
	public static int GetNeedExpByLv(int nLv)
	{
		return 0;
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x000076F8 File Offset: 0x000058F8
	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x334C74", Offset = "0x334C74", VA = "0x6334C74")]
	public static bool CheckResearch(ResearchID eID)
	{
		return default(bool);
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x00007710 File Offset: 0x00005910
	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x349CCC", Offset = "0x349CCC", VA = "0x6349CCC")]
	public static bool LearnableResearch(ResearchID eID)
	{
		return default(bool);
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x336F78", Offset = "0x336F78", VA = "0x6336F78")]
	public static void RefreshResearchPower()
	{
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x00007728 File Offset: 0x00005928
	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x337128", Offset = "0x337128", VA = "0x6337128")]
	public static float GetResearchFac(ResearchID eID)
	{
		return 0f;
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x00007740 File Offset: 0x00005940
	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x34357C", Offset = "0x34357C", VA = "0x634357C")]
	public static int GetResearchFacInt(ResearchID eID)
	{
		return 0;
	}

	// Token: 0x06001258 RID: 4696 RVA: 0x00007758 File Offset: 0x00005958
	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x334B14", Offset = "0x334B14", VA = "0x6334B14")]
	public static bool CheckRebirth(RebirthID eID)
	{
		return default(bool);
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x00007770 File Offset: 0x00005970
	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x349E58", Offset = "0x349E58", VA = "0x6349E58")]
	public static int GetRebirth(RebirthID eID)
	{
		return 0;
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x00007788 File Offset: 0x00005988
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x334D44", Offset = "0x334D44", VA = "0x6334D44")]
	public static float GetRebirthFac(RebirthID eID)
	{
		return 0f;
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x000077A0 File Offset: 0x000059A0
	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x34A008", Offset = "0x34A008", VA = "0x634A008")]
	public static float GetRebirthFac(RebirthID eID, int nLv)
	{
		return 0f;
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x000077B8 File Offset: 0x000059B8
	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x33706C", Offset = "0x33706C", VA = "0x633706C")]
	public static int GetRebirthFacToInt(RebirthID eID)
	{
		return 0;
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x000077D0 File Offset: 0x000059D0
	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x34A12C", Offset = "0x34A12C", VA = "0x634A12C")]
	public static int GetCostRebirth(RebirthID eID)
	{
		return 0;
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x000077E8 File Offset: 0x000059E8
	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x34A1B8", Offset = "0x34A1B8", VA = "0x634A1B8")]
	public static int GetCostRebirth(RebirthID eID, int nLv)
	{
		return 0;
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x34A29C", Offset = "0x34A29C", VA = "0x634A29C")]
	public static void UpgRebirth(RebirthID eID, int nPlus = 1)
	{
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x00007800 File Offset: 0x00005A00
	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x34A53C", Offset = "0x34A53C", VA = "0x634A53C")]
	public static bool CheckShop(ShopID eID)
	{
		return default(bool);
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x00007818 File Offset: 0x00005A18
	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x34A60C", Offset = "0x34A60C", VA = "0x634A60C")]
	public static float GetDamage(Monster pMon)
	{
		return 0f;
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x00007830 File Offset: 0x00005A30
	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x34A754", Offset = "0x34A754", VA = "0x634A754")]
	public static float GetDamage(Monster pMon, Enemy em, BattleItemData bData)
	{
		return 0f;
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x34AE1C", Offset = "0x34AE1C", VA = "0x634AE1C")]
	public static void Rebirth(SavedData savedata, short sNewChar, int nNewDiff, bool bMain, List<PlayerItemData> listInherit)
	{
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x34B1DC", Offset = "0x34B1DC", VA = "0x634B1DC")]
	public static void Rebirth(int nNewDiff, int nDiff, short sID, byte bySlot, bool bMain, int nDay, long uID, List<PlayerItemData> listInherit, List<short> listChar, int nMaxEndless = 0, bool bElmAddExp = false)
	{
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x352CA0", Offset = "0x352CA0", VA = "0x6352CA0")]
	public static void CheckLevelAchievement()
	{
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x00007848 File Offset: 0x00005A48
	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x353170", Offset = "0x353170", VA = "0x6353170")]
	public static float GetMuation1(MutateType eType, int nDay)
	{
		return 0f;
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x00007860 File Offset: 0x00005A60
	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x353310", Offset = "0x353310", VA = "0x6353310")]
	public static float GetMuation2(MutateType eType, int nDay)
	{
		return 0f;
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x353494", Offset = "0x353494", VA = "0x6353494")]
	public static string GetMutationDesc(MutateType eType, int nDay)
	{
		return null;
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010DD")]
	[Address(RVA = "0x353624", Offset = "0x353624", VA = "0x6353624")]
	public static string GetMutationDescCustom(MutateType eType, float fFac1, float fFac2)
	{
		return null;
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00007878 File Offset: 0x00005A78
	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x353760", Offset = "0x353760", VA = "0x6353760")]
	public static bool IsSoloPlay(MutateType eType)
	{
		return default(bool);
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x3487D8", Offset = "0x3487D8", VA = "0x63487D8")]
	public static PlayerAccData GetNewAcc(short sID)
	{
		return null;
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x353780", Offset = "0x353780", VA = "0x6353780")]
	public static PlayerAccData GetNewAcc(int nDropMin, int nDropMax, bool bRing)
	{
		return null;
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x34944C", Offset = "0x34944C", VA = "0x634944C")]
	public static string GetAccDesc(short sID, int nLv = 0)
	{
		return null;
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x34EDF8", Offset = "0x34EDF8", VA = "0x634EDF8")]
	public static void RefreshAccMod()
	{
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x00007890 File Offset: 0x00005A90
	[Token(Token = "0x60010E3")]
	[Address(RVA = "0x350EEC", Offset = "0x350EEC", VA = "0x6350EEC")]
	public static int GetTrialClear(long uid)
	{
		return 0;
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010E4")]
	[Address(RVA = "0x353CD8", Offset = "0x353CD8", VA = "0x6353CD8")]
	public static void SetTrialClear(long uid, int nClear)
	{
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x000078A8 File Offset: 0x00005AA8
	[Token(Token = "0x60010E5")]
	[Address(RVA = "0x348594", Offset = "0x348594", VA = "0x6348594")]
	public static bool CheckAchieveAcc(short sID)
	{
		return default(bool);
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010E6")]
	[Address(RVA = "0x3486A8", Offset = "0x3486A8", VA = "0x63486A8")]
	public static void SetAchieveAcc(short sID)
	{
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010E7")]
	[Address(RVA = "0x3540E8", Offset = "0x3540E8", VA = "0x63540E8")]
	public static void OnSpecialEnchant(int nLv, int nInc)
	{
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010E8")]
	[Address(RVA = "0x354724", Offset = "0x354724", VA = "0x6354724")]
	public static void OnWeaponEnchant(long uid)
	{
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010E9")]
	[Address(RVA = "0x355C24", Offset = "0x355C24", VA = "0x6355C24")]
	public static void OnWeaponSimpleEnchant(long uid, bool bAuto = false)
	{
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010EA")]
	[Address(RVA = "0x356978", Offset = "0x356978", VA = "0x6356978")]
	public static void OnWeaponEqualEnchant(bool bAuto = false)
	{
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010EB")]
	[Address(RVA = "0x355444", Offset = "0x355444", VA = "0x6355444")]
	public static void OnAfterEnchant(bool bAuto = false)
	{
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x000078C0 File Offset: 0x00005AC0
	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x357974", Offset = "0x357974", VA = "0x6357974")]
	public static int GetContinueWave(int nWave)
	{
		return 0;
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x000078D8 File Offset: 0x00005AD8
	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x357A18", Offset = "0x357A18", VA = "0x6357A18")]
	public static bool IsOwnedAcc(short sID)
	{
		return default(bool);
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x000078F0 File Offset: 0x00005AF0
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x357BF4", Offset = "0x357BF4", VA = "0x6357BF4")]
	public static bool OnSellAll()
	{
		return default(bool);
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x00007908 File Offset: 0x00005B08
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x3584DC", Offset = "0x3584DC", VA = "0x63584DC")]
	public static bool OnSellAllWithoutLengend()
	{
		return default(bool);
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x00007920 File Offset: 0x00005B20
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x35178C", Offset = "0x35178C", VA = "0x635178C")]
	public static bool OnAutoEquip()
	{
		return default(bool);
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x00007938 File Offset: 0x00005B38
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x34DC04", Offset = "0x34DC04", VA = "0x634DC04")]
	public static bool OnAutoAccEquip()
	{
		return default(bool);
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x00007950 File Offset: 0x00005B50
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x358D68", Offset = "0x358D68", VA = "0x6358D68")]
	public static bool isAwaken(int nPos)
	{
		return default(bool);
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x00007968 File Offset: 0x00005B68
	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x342008", Offset = "0x342008", VA = "0x6342008")]
	public static bool isAwaken(PlayerMonsterData pData)
	{
		return default(bool);
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x00007980 File Offset: 0x00005B80
	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x358DEC", Offset = "0x358DEC", VA = "0x6358DEC")]
	public static int GetCostHire(PlayerMonsterData pData)
	{
		return 0;
	}

	// Token: 0x06001281 RID: 4737 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x358EF8", Offset = "0x358EF8", VA = "0x6358EF8")]
	public static string GetDiffText(int nDiff, bool bShowPercent)
	{
		return null;
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x359760", Offset = "0x359760", VA = "0x6359760")]
	public static int[] GetAllClearHellStone(int nDiff)
	{
		return null;
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x00007998 File Offset: 0x00005B98
	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x35984C", Offset = "0x35984C", VA = "0x635984C")]
	public static int GetClearHellStone(int nDiff, int nNum)
	{
		return 0;
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x359E04", Offset = "0x359E04", VA = "0x6359E04")]
	public static void AddClearHellStone(int nDiff, int nNum)
	{
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x000079B0 File Offset: 0x00005BB0
	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x359FB0", Offset = "0x359FB0", VA = "0x6359FB0")]
	public static int GetRebirthTime(int nDiff, int nDay)
	{
		return 0;
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x000079C8 File Offset: 0x00005BC8
	[Token(Token = "0x60010FA")]
	[Address(RVA = "0x35A354", Offset = "0x35A354", VA = "0x635A354")]
	public static long GetElementalExp(int i)
	{
		return 0L;
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x352A58", Offset = "0x352A58", VA = "0x6352A58")]
	public static void AddElementalExp(int i, long nExp)
	{
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x000079E0 File Offset: 0x00005BE0
	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x352C10", Offset = "0x352C10", VA = "0x6352C10")]
	public static bool CheckElementalTrait(ElementalID eID)
	{
		return default(bool);
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x000079F8 File Offset: 0x00005BF8
	[Token(Token = "0x60010FD")]
	[Address(RVA = "0x35A6FC", Offset = "0x35A6FC", VA = "0x635A6FC")]
	public static int GetElementalTrait(ElementalID eID)
	{
		return 0;
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010FE")]
	[Address(RVA = "0x35A8AC", Offset = "0x35A8AC", VA = "0x635A8AC")]
	public static void UpgElementalTrait(ElementalID eID)
	{
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x00007A10 File Offset: 0x00005C10
	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x35ADF4", Offset = "0x35ADF4", VA = "0x635ADF4")]
	public static bool CanUpgElementalTrait(ElementalID eID, bool bCheckAvailable = true)
	{
		return default(bool);
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x00007A28 File Offset: 0x00005C28
	[Token(Token = "0x6001100")]
	[Address(RVA = "0x35B484", Offset = "0x35B484", VA = "0x635B484")]
	public static int GetTraitNumberByElement(int n)
	{
		return 0;
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x00007A40 File Offset: 0x00005C40
	[Token(Token = "0x6001101")]
	[Address(RVA = "0x35AF78", Offset = "0x35AF78", VA = "0x635AF78")]
	public static int GetTraitNumberByElement(Element eID)
	{
		return 0;
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x00007A58 File Offset: 0x00005C58
	[Token(Token = "0x6001102")]
	[Address(RVA = "0x35B260", Offset = "0x35B260", VA = "0x635B260")]
	public static int GetElementalLevel(int nElm)
	{
		return 0;
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001103")]
	[Address(RVA = "0x35B504", Offset = "0x35B504", VA = "0x635B504")]
	public static long[] GetElementalAllExp(int nElement)
	{
		return null;
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x00007A70 File Offset: 0x00005C70
	[Token(Token = "0x6001104")]
	[Address(RVA = "0x35B6AC", Offset = "0x35B6AC", VA = "0x635B6AC")]
	public static ElementalID GetElementalBase(int nElement)
	{
		return (ElementalID)0;
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x00007A88 File Offset: 0x00005C88
	[Token(Token = "0x6001105")]
	[Address(RVA = "0x35B6CC", Offset = "0x35B6CC", VA = "0x635B6CC")]
	public static ElementalID GetElementalBase2(int nElement)
	{
		return (ElementalID)0;
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x00007AA0 File Offset: 0x00005CA0
	[Token(Token = "0x6001106")]
	[Address(RVA = "0x35B6EC", Offset = "0x35B6EC", VA = "0x635B6EC")]
	public static ElementalID GetElementalBase3(int nElement)
	{
		return (ElementalID)0;
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001107")]
	[Address(RVA = "0x35B70C", Offset = "0x35B70C", VA = "0x635B70C")]
	public static void RefreshElementalFac()
	{
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x00007AB8 File Offset: 0x00005CB8
	[Token(Token = "0x6001108")]
	[Address(RVA = "0x33731C", Offset = "0x33731C", VA = "0x633731C")]
	public static float GetElementalFac(ElementalID eID, int n = 0)
	{
		return 0f;
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x00007AD0 File Offset: 0x00005CD0
	[Token(Token = "0x6001109")]
	[Address(RVA = "0x35C834", Offset = "0x35C834", VA = "0x635C834")]
	public static long GetNeedMedalPromote(long nLv)
	{
		return 0L;
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x00007AE8 File Offset: 0x00005CE8
	[Token(Token = "0x600110A")]
	[Address(RVA = "0x35C880", Offset = "0x35C880", VA = "0x635C880")]
	public static int GetPromoteLevel(short sID)
	{
		return 0;
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110B")]
	[Address(RVA = "0x35CBBC", Offset = "0x35CBBC", VA = "0x635CBBC")]
	public static void UpgPromoteLevel(short sID)
	{
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x35CD38", Offset = "0x35CD38", VA = "0x635CD38")]
	public static void InitPromoteLevel(short sID)
	{
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00007B00 File Offset: 0x00005D00
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x35CE4C", Offset = "0x35CE4C", VA = "0x635CE4C")]
	public static int GetRepeatResearch(ResearchID eID)
	{
		return 0;
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110E")]
	[Address(RVA = "0x35D0CC", Offset = "0x35D0CC", VA = "0x635D0CC")]
	public static void UpgRepeatResearch(ResearchID eID)
	{
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00007B18 File Offset: 0x00005D18
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x35D204", Offset = "0x35D204", VA = "0x635D204")]
	public static int GetResearchCost(ResearchID eID)
	{
		return 0;
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x00007B30 File Offset: 0x00005D30
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x334BE4", Offset = "0x334BE4", VA = "0x6334BE4")]
	public static bool CheckMonTrait(short sID, MonTraitID eID)
	{
		return default(bool);
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x00007B48 File Offset: 0x00005D48
	[Token(Token = "0x6001111")]
	[Address(RVA = "0x35118C", Offset = "0x35118C", VA = "0x635118C")]
	public static int GetMonTrait(short sID, MonTraitID eID)
	{
		return 0;
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x00007B60 File Offset: 0x00005D60
	[Token(Token = "0x6001112")]
	[Address(RVA = "0x341A54", Offset = "0x341A54", VA = "0x6341A54")]
	public static float GetMonTraitCalc1(short sID, MonTraitID eID)
	{
		return 0f;
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x00007B78 File Offset: 0x00005D78
	[Token(Token = "0x6001113")]
	[Address(RVA = "0x35D30C", Offset = "0x35D30C", VA = "0x635D30C")]
	public static float GetMonTraitCalc2(short sID, MonTraitID eID)
	{
		return 0f;
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x00007B90 File Offset: 0x00005D90
	[Token(Token = "0x6001114")]
	[Address(RVA = "0x35D43C", Offset = "0x35D43C", VA = "0x635D43C")]
	public static float GetMonTraitCalc3(short sID, MonTraitID eID)
	{
		return 0f;
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001115")]
	[Address(RVA = "0x35D56C", Offset = "0x35D56C", VA = "0x635D56C")]
	public static void AddMonTrait(short sID, MonTraitID eID)
	{
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x00007BA8 File Offset: 0x00005DA8
	[Token(Token = "0x6001116")]
	[Address(RVA = "0x35D960", Offset = "0x35D960", VA = "0x635D960")]
	public static long GetRebirthExp(short sID)
	{
		return 0L;
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001117")]
	[Address(RVA = "0x3515E8", Offset = "0x3515E8", VA = "0x63515E8")]
	public static void AddRebirthExp(short sID, long nExp)
	{
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x00007BC0 File Offset: 0x00005DC0
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x35DCE8", Offset = "0x35DCE8", VA = "0x635DCE8")]
	public static int GetRebirthLevel(short sID)
	{
		return 0;
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x00007BD8 File Offset: 0x00005DD8
	[Token(Token = "0x6001119")]
	[Address(RVA = "0x35DDBC", Offset = "0x35DDBC", VA = "0x635DDBC")]
	public static float GetNeedRebirthExpRate(short sID)
	{
		return 0f;
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x00007BF0 File Offset: 0x00005DF0
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x35DECC", Offset = "0x35DECC", VA = "0x635DECC")]
	public static int GetSpendRebirthPoint(short sID)
	{
		return 0;
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x00007C08 File Offset: 0x00005E08
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x35E3B8", Offset = "0x35E3B8", VA = "0x635E3B8")]
	public static bool CanUpgMonTrait(short sID, MonTraitElt elt)
	{
		return default(bool);
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x00007C20 File Offset: 0x00005E20
	[Token(Token = "0x600111C")]
	[Address(RVA = "0x343D2C", Offset = "0x343D2C", VA = "0x6343D2C")]
	public static float GetStoneBonus()
	{
		return 0f;
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x00007C38 File Offset: 0x00005E38
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x344330", Offset = "0x344330", VA = "0x6344330")]
	public static float GetRubyBonus()
	{
		return 0f;
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x00007C50 File Offset: 0x00005E50
	[Token(Token = "0x600111F")]
	[Address(RVA = "0x3634CC", Offset = "0x3634CC", VA = "0x63634CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A8C", Offset = "0x187A8C")]
	private static int <RefreshShopItem>m__0(PlayerItemData x, PlayerItemData y)
	{
		return 0;
	}

	// Token: 0x04000FCD RID: 4045
	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0x0")]
	public static Ads eAds;

	// Token: 0x04000FCE RID: 4046
	[Token(Token = "0x4000E1F")]
	[FieldOffset(Offset = "0x4")]
	public static WaveData wave;

	// Token: 0x04000FCF RID: 4047
	[Token(Token = "0x4000E20")]
	[FieldOffset(Offset = "0x8")]
	public static SavedData currentSave;

	// Token: 0x04000FD0 RID: 4048
	[Token(Token = "0x4000E21")]
	[FieldOffset(Offset = "0xC")]
	public static SavedOption option;

	// Token: 0x04000FD1 RID: 4049
	[Token(Token = "0x4000E22")]
	[FieldOffset(Offset = "0x10")]
	public static SavedAchievement achievement;

	// Token: 0x04000FD2 RID: 4050
	[Token(Token = "0x4000E23")]
	[FieldOffset(Offset = "0x14")]
	public static SavedRebirth rebirth;

	// Token: 0x04000FD3 RID: 4051
	[Token(Token = "0x4000E24")]
	[FieldOffset(Offset = "0x18")]
	public static List<PlayerItemData> listDropItem;

	// Token: 0x04000FD4 RID: 4052
	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0x1C")]
	public static Dictionary<SkillKey, ObscuredInt> dictPartySkill;

	// Token: 0x04000FD5 RID: 4053
	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0x20")]
	public static Dictionary<SkillKey, ObscuredFloat> dictPSkillFac1;

	// Token: 0x04000FD6 RID: 4054
	[Token(Token = "0x4000E27")]
	[FieldOffset(Offset = "0x24")]
	public static Dictionary<SkillKey, ObscuredFloat> dictPSkillFac2;

	// Token: 0x04000FD7 RID: 4055
	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0x28")]
	public static Dictionary<long, BattleItemData> dictBattleItem;

	// Token: 0x04000FD8 RID: 4056
	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x2C")]
	public static ObscuredInt nBattleGold;

	// Token: 0x04000FD9 RID: 4057
	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0x3C")]
	public static ObscuredInt nBattleExp;

	// Token: 0x04000FDA RID: 4058
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x50")]
	public static ObscuredDouble nGem;

	// Token: 0x04000FDB RID: 4059
	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x78")]
	public static List<AchievementType> listCheck;

	// Token: 0x04000FDC RID: 4060
	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x7C")]
	public static Dictionary<AcvRewardType, ObscuredInt> dictAcvReward;

	// Token: 0x04000FDD RID: 4061
	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x80")]
	public static ObscuredFloat[,] fPlayerAccMod;

	// Token: 0x04000FDE RID: 4062
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x84")]
	public static ObscuredFloat[] fAllAccMod;

	// Token: 0x04000FDF RID: 4063
	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x88")]
	public static BattleType eBattle;

	// Token: 0x04000FE0 RID: 4064
	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x8C")]
	public static ObscuredByte byCurrentSaveSlot;

	// Token: 0x04000FE1 RID: 4065
	[Token(Token = "0x4000E32")]
	[FieldOffset(Offset = "0x90")]
	public static ObscuredInt nSelectedMonster;

	// Token: 0x04000FE2 RID: 4066
	[Token(Token = "0x4000E33")]
	[FieldOffset(Offset = "0xA0")]
	public static bool bAcvChanged;

	// Token: 0x04000FE3 RID: 4067
	[Token(Token = "0x4000E34")]
	[FieldOffset(Offset = "0xA4")]
	public static ObscuredFloat fDunMaxHP;

	// Token: 0x04000FE4 RID: 4068
	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0xB8")]
	public static ObscuredFloat fDunRegen;

	// Token: 0x04000FE5 RID: 4069
	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0xCC")]
	public static ObscuredFloat[] fTrialCharge;

	// Token: 0x04000FE6 RID: 4070
	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0xD0")]
	public static ObscuredFloat fTrialAwakenCharge;

	// Token: 0x04000FE7 RID: 4071
	[Token(Token = "0x4000E38")]
	[FieldOffset(Offset = "0xE4")]
	public static ObscuredFloat fAtkBonus;

	// Token: 0x04000FE8 RID: 4072
	[Token(Token = "0x4000E39")]
	[FieldOffset(Offset = "0xF8")]
	public static ObscuredFloat fEmAtkBonus;

	// Token: 0x04000FE9 RID: 4073
	[Token(Token = "0x4000E3A")]
	[FieldOffset(Offset = "0x10C")]
	public static ObscuredFloat fEmAspBonus;

	// Token: 0x04000FEA RID: 4074
	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0x120")]
	public static ObscuredFloat fResearchPower;

	// Token: 0x04000FEB RID: 4075
	[Token(Token = "0x4000E3C")]
	[FieldOffset(Offset = "0x134")]
	public static ObscuredInt nAwakenCost;

	// Token: 0x04000FEC RID: 4076
	[Token(Token = "0x4000E3D")]
	[FieldOffset(Offset = "0x144")]
	public static ObscuredInt nDiffTrial;

	// Token: 0x04000FED RID: 4077
	[Token(Token = "0x4000E3E")]
	[FieldOffset(Offset = "0x154")]
	public static ObscuredInt nStartEndless;

	// Token: 0x04000FEE RID: 4078
	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0x164")]
	public static float fDiffTrialDayFac;

	// Token: 0x04000FEF RID: 4079
	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0x168")]
	public static float[] fDiffTrialDiffFac;

	// Token: 0x04000FF0 RID: 4080
	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x16C")]
	public static int[] nDiffTrialDiffDay;

	// Token: 0x04000FF1 RID: 4081
	[Token(Token = "0x4000E42")]
	[FieldOffset(Offset = "0x170")]
	public static float[] fDiffTrialDiffDmg;

	// Token: 0x04000FF2 RID: 4082
	[Token(Token = "0x4000E43")]
	[FieldOffset(Offset = "0x174")]
	public static float[] fDiffTrialReward;

	// Token: 0x04000FF3 RID: 4083
	[Token(Token = "0x4000E44")]
	[FieldOffset(Offset = "0x178")]
	public static float[] fDiffSpd;

	// Token: 0x04000FF4 RID: 4084
	[Token(Token = "0x4000E45")]
	[FieldOffset(Offset = "0x17C")]
	public static float[] fDiffFac;

	// Token: 0x04000FF5 RID: 4085
	[Token(Token = "0x4000E46")]
	[FieldOffset(Offset = "0x180")]
	public static float[] fDiffEmDmgFac;

	// Token: 0x04000FF6 RID: 4086
	[Token(Token = "0x4000E47")]
	[FieldOffset(Offset = "0x184")]
	public static double[] fDiffEmHpFac;

	// Token: 0x04000FF7 RID: 4087
	[Token(Token = "0x4000E48")]
	[FieldOffset(Offset = "0x188")]
	public static float[] fDiffMutGrow;

	// Token: 0x04000FF8 RID: 4088
	[Token(Token = "0x4000E49")]
	[FieldOffset(Offset = "0x18C")]
	public static ObscuredInt[] nEndlessMutationDay;

	// Token: 0x04000FF9 RID: 4089
	[Token(Token = "0x4000E4A")]
	[FieldOffset(Offset = "0x190")]
	public static ObscuredInt[] nMutateStartDay;

	// Token: 0x04000FFA RID: 4090
	[Token(Token = "0x4000E4B")]
	[FieldOffset(Offset = "0x194")]
	public static ObscuredInt[] nDiffRepairCost;

	// Token: 0x04000FFB RID: 4091
	[Token(Token = "0x4000E4C")]
	[FieldOffset(Offset = "0x198")]
	public static ObscuredByte[] byInitBatch;

	// Token: 0x04000FFC RID: 4092
	[Token(Token = "0x4000E4D")]
	[FieldOffset(Offset = "0x19C")]
	public static ResearchID eSelectedResearch;

	// Token: 0x04000FFD RID: 4093
	[Token(Token = "0x4000E4E")]
	[FieldOffset(Offset = "0x1A0")]
	public static List<PlayerAccData> listGetAcc;

	// Token: 0x04000FFE RID: 4094
	[Token(Token = "0x4000E4F")]
	[FieldOffset(Offset = "0x1A4")]
	public static bool bRebirthChanged;

	// Token: 0x04000FFF RID: 4095
	[Token(Token = "0x4000E50")]
	[FieldOffset(Offset = "0x1A5")]
	public static bool bTempQuitBattle;

	// Token: 0x04001000 RID: 4096
	[Token(Token = "0x4000E51")]
	[FieldOffset(Offset = "0x1A8")]
	public static int[] nMulStone;

	// Token: 0x04001001 RID: 4097
	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x1AC")]
	public static int nSelectedDiff;

	// Token: 0x04001002 RID: 4098
	[Token(Token = "0x4000E53")]
	[FieldOffset(Offset = "0x1B0")]
	public static ObscuredShort sSelectedRebirthCharID;

	// Token: 0x04001003 RID: 4099
	[Token(Token = "0x4000E54")]
	[FieldOffset(Offset = "0x1B8")]
	public static bool bForceQuit;

	// Token: 0x04001004 RID: 4100
	[Token(Token = "0x4000E55")]
	[FieldOffset(Offset = "0x1B9")]
	public static bool bBattleFail;

	// Token: 0x04001005 RID: 4101
	[Token(Token = "0x4000E56")]
	[FieldOffset(Offset = "0x1BC")]
	public static ObscuredFloat fDoubleDayPass;

	// Token: 0x04001006 RID: 4102
	[Token(Token = "0x4000E57")]
	[FieldOffset(Offset = "0x1D0")]
	public static Dictionary<ElementalID, ObscuredFloat[]> dictElementalFac;

	// Token: 0x04001007 RID: 4103
	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x1D4")]
	public static ObscuredInt nSelectedElementalView;

	// Token: 0x04001008 RID: 4104
	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x1E4")]
	public static ObscuredInt[,] nAccEnchantMedal;

	// Token: 0x04001009 RID: 4105
	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x1E8")]
	public static ObscuredInt[,] nAccEnchantStone;

	// Token: 0x0400100A RID: 4106
	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x1EC")]
	private static float[] fGradeRate;

	// Token: 0x0400100B RID: 4107
	[Token(Token = "0x4000E5C")]
	[FieldOffset(Offset = "0x1F0")]
	public static Dictionary<int, float> dictItemPower;

	// Token: 0x0400100C RID: 4108
	[Token(Token = "0x4000E5D")]
	[FieldOffset(Offset = "0x1F4")]
	public static Dictionary<int, double> dictMonHP;

	// Token: 0x0400100D RID: 4109
	[Token(Token = "0x4000E5E")]
	[FieldOffset(Offset = "0x1F8")]
	public static Dictionary<int, float> dictMonDmg;

	// Token: 0x0400100E RID: 4110
	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x1FC")]
	private static Color[] clGrade;

	// Token: 0x0400100F RID: 4111
	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x200")]
	private static string[] strClGrade;

	// Token: 0x04001010 RID: 4112
	[Token(Token = "0x4000E61")]
	[FieldOffset(Offset = "0x208")]
	public static long nNewRuby;

	// Token: 0x04001011 RID: 4113
	[Token(Token = "0x4000E62")]
	[FieldOffset(Offset = "0x210")]
	public static long nNewStone;

	// Token: 0x04001012 RID: 4114
	[Token(Token = "0x4000E63")]
	[FieldOffset(Offset = "0x218")]
	public static float[] fAccDropFactor;

	// Token: 0x04001013 RID: 4115
	[Token(Token = "0x4000E64")]
	[FieldOffset(Offset = "0x21C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x184F48", Offset = "0x184F48")]
	private static Comparison<PlayerItemData> <>f__am$cache0;
}
