using System;
using System.Collections.Generic;
using CC;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C9 RID: 713
[Token(Token = "0x2000235")]
public class BData : MonoBehaviour
{
	// Token: 0x06001109 RID: 4361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x284530", Offset = "0x284530", VA = "0x6284530")]
	public BData()
	{
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x284538", Offset = "0x284538", VA = "0x6284538")]
	public void Awake()
	{
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F85")]
	[Address(RVA = "0x28BB90", Offset = "0x28BB90", VA = "0x628BB90")]
	private void Start()
	{
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F86")]
	[Address(RVA = "0x284658", Offset = "0x284658", VA = "0x6284658")]
	private void LoadData()
	{
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x28BD84", Offset = "0x28BD84", VA = "0x628BD84")]
	public static MonsterData GetMonster(short sID)
	{
		return null;
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x28BE40", Offset = "0x28BE40", VA = "0x628BE40")]
	public static EnemyData GetEnemy(short sID)
	{
		return null;
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x28BEFC", Offset = "0x28BEFC", VA = "0x628BEFC")]
	public static ItemData GetWeapon(short sID)
	{
		return null;
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x2829D8", Offset = "0x2829D8", VA = "0x62829D8")]
	public static SkillData GetSkill(SkillKey eSkill)
	{
		return null;
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x28BFB8", Offset = "0x28BFB8", VA = "0x628BFB8")]
	public static DungeonData GetDungeon(DungeonType eID)
	{
		return null;
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x2825FC", Offset = "0x2825FC", VA = "0x62825FC")]
	public static AchievementData GetAchievement(AchievementType eID)
	{
		return null;
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x28C074", Offset = "0x28C074", VA = "0x628C074")]
	public static ModData GetMod(ModType eID)
	{
		return null;
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x28C130", Offset = "0x28C130", VA = "0x628C130")]
	public static MutationData GetMutate(MutateType eID)
	{
		return null;
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x281D48", Offset = "0x281D48", VA = "0x6281D48")]
	public static string GetString(string strName)
	{
		return null;
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x28C1EC", Offset = "0x28C1EC", VA = "0x628C1EC")]
	public static List<short> GetRandomEnemy(int nDay)
	{
		return null;
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00006E28 File Offset: 0x00005028
	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x28C514", Offset = "0x28C514", VA = "0x628C514")]
	public static short GetRandomBoss(int nDay)
	{
		return 0;
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x28C908", Offset = "0x28C908", VA = "0x628C908")]
	public static ResearchData GetResearch(ResearchID eID)
	{
		return null;
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x28C9C4", Offset = "0x28C9C4", VA = "0x628C9C4")]
	public static RebirthData GetRebirth(RebirthID eID)
	{
		return null;
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x28CA80", Offset = "0x28CA80", VA = "0x628CA80")]
	public static ShopData GetShop(ShopID eID)
	{
		return null;
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x28CB3C", Offset = "0x28CB3C", VA = "0x628CB3C")]
	public static StoneData GetStone(int nDay)
	{
		return null;
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x28CBF8", Offset = "0x28CBF8", VA = "0x628CBF8")]
	public static RubyData GetRuby(int nWave)
	{
		return null;
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x28CCB4", Offset = "0x28CCB4", VA = "0x628CCB4")]
	public static TrialData GetTrial(int nFloor)
	{
		return null;
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x281054", Offset = "0x281054", VA = "0x6281054")]
	public static AccData GetAccessory(short sID)
	{
		return null;
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x28CD70", Offset = "0x28CD70", VA = "0x628CD70")]
	public static QuestData GetQuest(QuestID eID)
	{
		return null;
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x28CE2C", Offset = "0x28CE2C", VA = "0x628CE2C")]
	public static ElementalData GetElemental(ElementalID eID)
	{
		return null;
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x28CEE8", Offset = "0x28CEE8", VA = "0x628CEE8")]
	public static MonTraitData GetMonTrait(MonTraitID eID)
	{
		return null;
	}

	// Token: 0x040009E3 RID: 2531
	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x0")]
	public static BData single;

	// Token: 0x040009E4 RID: 2532
	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0xC")]
	public DataMonster _monster;

	// Token: 0x040009E5 RID: 2533
	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x10")]
	public DataEnemy _enemy;

	// Token: 0x040009E6 RID: 2534
	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x14")]
	public DataWeapon _weapon;

	// Token: 0x040009E7 RID: 2535
	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x18")]
	public DataSkill _skill;

	// Token: 0x040009E8 RID: 2536
	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x1C")]
	public DataDungeon _dungeon;

	// Token: 0x040009E9 RID: 2537
	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x20")]
	public DataMod _mod;

	// Token: 0x040009EA RID: 2538
	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x24")]
	public DataMutation _mutation;

	// Token: 0x040009EB RID: 2539
	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x28")]
	public DataAchievement _achievement;

	// Token: 0x040009EC RID: 2540
	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x2C")]
	public DataResearch _research;

	// Token: 0x040009ED RID: 2541
	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0x30")]
	public DataRebirth _rebirth;

	// Token: 0x040009EE RID: 2542
	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0x34")]
	public DataShop _shop;

	// Token: 0x040009EF RID: 2543
	[Token(Token = "0x4000846")]
	[FieldOffset(Offset = "0x38")]
	public DataStone _stone;

	// Token: 0x040009F0 RID: 2544
	[Token(Token = "0x4000847")]
	[FieldOffset(Offset = "0x3C")]
	public DataTrial _trial;

	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x4000848")]
	[FieldOffset(Offset = "0x40")]
	public DataAccessory _acc;

	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0x44")]
	public DataRuby _ruby;

	// Token: 0x040009F3 RID: 2547
	[Token(Token = "0x400084A")]
	[FieldOffset(Offset = "0x48")]
	public DataQuest _quest;

	// Token: 0x040009F4 RID: 2548
	[Token(Token = "0x400084B")]
	[FieldOffset(Offset = "0x4C")]
	public DataElemental _elemental;

	// Token: 0x040009F5 RID: 2549
	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0x50")]
	public DataMonTrait _montrait;

	// Token: 0x040009F6 RID: 2550
	[Token(Token = "0x400084D")]
	[FieldOffset(Offset = "0x54")]
	public Strings _string;

	// Token: 0x040009F7 RID: 2551
	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0x4")]
	public static Dictionary<short, MonsterData> dictMonster;

	// Token: 0x040009F8 RID: 2552
	[Token(Token = "0x400084F")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<short, ItemData> dictWeapon;

	// Token: 0x040009F9 RID: 2553
	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0xC")]
	public static Dictionary<short, EnemyData> dictEnemy;

	// Token: 0x040009FA RID: 2554
	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0x10")]
	public static Dictionary<SkillKey, SkillData> dictSkill;

	// Token: 0x040009FB RID: 2555
	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0x14")]
	public static Dictionary<DungeonType, DungeonData> dictDungeon;

	// Token: 0x040009FC RID: 2556
	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0x18")]
	public static Dictionary<ModType, ModData> dictMod;

	// Token: 0x040009FD RID: 2557
	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0x1C")]
	public static Dictionary<MutateType, MutationData> dictMutation;

	// Token: 0x040009FE RID: 2558
	[Token(Token = "0x4000855")]
	[FieldOffset(Offset = "0x20")]
	public static Dictionary<AchievementType, AchievementData> dictAcv;

	// Token: 0x040009FF RID: 2559
	[Token(Token = "0x4000856")]
	[FieldOffset(Offset = "0x24")]
	public static Dictionary<ResearchID, ResearchData> dictRsc;

	// Token: 0x04000A00 RID: 2560
	[Token(Token = "0x4000857")]
	[FieldOffset(Offset = "0x28")]
	public static Dictionary<RebirthID, RebirthData> dictRebirth;

	// Token: 0x04000A01 RID: 2561
	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0x2C")]
	public static Dictionary<ShopID, ShopData> dictShop;

	// Token: 0x04000A02 RID: 2562
	[Token(Token = "0x4000859")]
	[FieldOffset(Offset = "0x30")]
	public static Dictionary<int, StoneData> dictStone;

	// Token: 0x04000A03 RID: 2563
	[Token(Token = "0x400085A")]
	[FieldOffset(Offset = "0x34")]
	public static Dictionary<short, AccData> dictAcc;

	// Token: 0x04000A04 RID: 2564
	[Token(Token = "0x400085B")]
	[FieldOffset(Offset = "0x38")]
	public static Dictionary<int, RubyData> dictRuby;

	// Token: 0x04000A05 RID: 2565
	[Token(Token = "0x400085C")]
	[FieldOffset(Offset = "0x3C")]
	public static Dictionary<QuestID, QuestData> dictQuest;

	// Token: 0x04000A06 RID: 2566
	[Token(Token = "0x400085D")]
	[FieldOffset(Offset = "0x40")]
	public static Dictionary<ElementalID, ElementalData> dictElemental;

	// Token: 0x04000A07 RID: 2567
	[Token(Token = "0x400085E")]
	[FieldOffset(Offset = "0x44")]
	public static Dictionary<int, TrialData> dictTrial;

	// Token: 0x04000A08 RID: 2568
	[Token(Token = "0x400085F")]
	[FieldOffset(Offset = "0x48")]
	public static Dictionary<MonTraitID, MonTraitData> dictMonTrait;

	// Token: 0x04000A09 RID: 2569
	[Token(Token = "0x4000860")]
	[FieldOffset(Offset = "0x4C")]
	public static Dictionary<string, List<string>> dictString;

	// Token: 0x04000A0A RID: 2570
	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0x50")]
	public static List<MutateType> listMutation;

	// Token: 0x04000A0B RID: 2571
	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0x54")]
	public static List<MutateType> listBossMutation;

	// Token: 0x04000A0C RID: 2572
	[Token(Token = "0x4000863")]
	[FieldOffset(Offset = "0x58")]
	public static bool bLoaded;
}
