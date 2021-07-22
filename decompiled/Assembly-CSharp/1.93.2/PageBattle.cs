using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using DigitalRuby.ThunderAndLightning;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000317 RID: 791
[Token(Token = "0x2000280")]
public class PageBattle : UIMgr
{
	// Token: 0x06001306 RID: 4870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116E")]
	[Address(RVA = "0x2B8200", Offset = "0x2B8200", VA = "0x62B8200")]
	public PageBattle()
	{
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06001307 RID: 4871 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000182")]
	public Monster mainMonster
	{
		[Token(Token = "0x600116F")]
		[Address(RVA = "0x2B8910", Offset = "0x2B8910", VA = "0x62B8910")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06001308 RID: 4872 RVA: 0x00007F80 File Offset: 0x00006180
	[Token(Token = "0x17000183")]
	public static int nMutationDay
	{
		[Token(Token = "0x6001170")]
		[Address(RVA = "0x2B8990", Offset = "0x2B8990", VA = "0x62B8990")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06001309 RID: 4873 RVA: 0x00007F98 File Offset: 0x00006198
	[Token(Token = "0x17000184")]
	private bool isInvincible
	{
		[Token(Token = "0x6001171")]
		[Address(RVA = "0x2B8AD0", Offset = "0x2B8AD0", VA = "0x62B8AD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x0600130A RID: 4874 RVA: 0x00007FB0 File Offset: 0x000061B0
	// (set) Token: 0x0600130B RID: 4875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000185")]
	public ObscuredInt nExp
	{
		[Token(Token = "0x6001172")]
		[Address(RVA = "0x2B8B94", Offset = "0x2B8B94", VA = "0x62B8B94")]
		get
		{
			return default(ObscuredInt);
		}
		[Token(Token = "0x6001173")]
		[Address(RVA = "0x2B8C2C", Offset = "0x2B8C2C", VA = "0x62B8C2C")]
		set
		{
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x0600130C RID: 4876 RVA: 0x00007FC8 File Offset: 0x000061C8
	// (set) Token: 0x0600130D RID: 4877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000186")]
	public ObscuredInt nGold
	{
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x2B8CD4", Offset = "0x2B8CD4", VA = "0x62B8CD4")]
		get
		{
			return default(ObscuredInt);
		}
		[Token(Token = "0x6001175")]
		[Address(RVA = "0x2B8D6C", Offset = "0x2B8D6C", VA = "0x62B8D6C")]
		set
		{
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x0600130E RID: 4878 RVA: 0x00007FE0 File Offset: 0x000061E0
	[Token(Token = "0x17000187")]
	public ObscuredInt nItem
	{
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x2B8E14", Offset = "0x2B8E14", VA = "0x62B8E14")]
		get
		{
			return default(ObscuredInt);
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x0600130F RID: 4879 RVA: 0x00007FF8 File Offset: 0x000061F8
	// (set) Token: 0x06001310 RID: 4880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000188")]
	public ObscuredInt nWave
	{
		[Token(Token = "0x6001177")]
		[Address(RVA = "0x2B8F0C", Offset = "0x2B8F0C", VA = "0x62B8F0C")]
		get
		{
			return default(ObscuredInt);
		}
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x2B8FB8", Offset = "0x2B8FB8", VA = "0x62B8FB8")]
		set
		{
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06001311 RID: 4881 RVA: 0x00008010 File Offset: 0x00006210
	// (set) Token: 0x06001312 RID: 4882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000189")]
	public ObscuredFloat fHP
	{
		[Token(Token = "0x6001179")]
		[Address(RVA = "0x2B9BB8", Offset = "0x2B9BB8", VA = "0x62B9BB8")]
		get
		{
			return default(ObscuredFloat);
		}
		[Token(Token = "0x600117A")]
		[Address(RVA = "0x2B9CBC", Offset = "0x2B9CBC", VA = "0x62B9CBC")]
		set
		{
		}
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600117B")]
	[Address(RVA = "0x2BA2B8", Offset = "0x2BA2B8", VA = "0x62BA2B8", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600117C")]
	[Address(RVA = "0x2BD3A0", Offset = "0x2BD3A0", VA = "0x62BD3A0")]
	private void SetMutation()
	{
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600117D")]
	[Address(RVA = "0x2BC994", Offset = "0x2BC994", VA = "0x62BC994")]
	private Enemy CreateEnemy()
	{
		return null;
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600117E")]
	[Address(RVA = "0x2BCC84", Offset = "0x2BCC84", VA = "0x62BCC84")]
	private BattleCoinElt CreateCoin()
	{
		return null;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600117F")]
	[Address(RVA = "0x2BF4F8", Offset = "0x2BF4F8", VA = "0x62BF4F8", Slot = "5")]
	protected override void Start()
	{
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x00008028 File Offset: 0x00006228
	[Token(Token = "0x6001180")]
	[Address(RVA = "0x2AA3F0", Offset = "0x2AA3F0", VA = "0x62AA3F0")]
	public float GetSkillFac(int i, SkillKey eKey)
	{
		return 0f;
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00008040 File Offset: 0x00006240
	[Token(Token = "0x6001181")]
	[Address(RVA = "0x2ACDFC", Offset = "0x2ACDFC", VA = "0x62ACDFC")]
	public float GetSkillFac2(int i, SkillKey eKey)
	{
		return 0f;
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00008058 File Offset: 0x00006258
	[Token(Token = "0x6001182")]
	[Address(RVA = "0x2C3C48", Offset = "0x2C3C48", VA = "0x62C3C48")]
	public float GetSkillFac3(int i, SkillKey eKey)
	{
		return 0f;
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00008070 File Offset: 0x00006270
	[Token(Token = "0x6001183")]
	[Address(RVA = "0x2ACF98", Offset = "0x2ACF98", VA = "0x62ACF98")]
	public float GetMonTrait(int i, MonTraitID eKey)
	{
		return 0f;
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x00008088 File Offset: 0x00006288
	[Token(Token = "0x6001184")]
	[Address(RVA = "0x2AD134", Offset = "0x2AD134", VA = "0x62AD134")]
	public float GetMonTrait2(int i, MonTraitID eKey)
	{
		return 0f;
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x000080A0 File Offset: 0x000062A0
	[Token(Token = "0x6001185")]
	[Address(RVA = "0x2C3DE4", Offset = "0x2C3DE4", VA = "0x62C3DE4")]
	public float GetMonTrait3(int i, MonTraitID eKey)
	{
		return 0f;
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x000080B8 File Offset: 0x000062B8
	[Token(Token = "0x6001186")]
	[Address(RVA = "0x2AA6C0", Offset = "0x2AA6C0", VA = "0x62AA6C0")]
	public float GetPartyMonTrait(MonTraitID eKey)
	{
		return 0f;
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x000080D0 File Offset: 0x000062D0
	[Token(Token = "0x6001187")]
	[Address(RVA = "0x2C3F80", Offset = "0x2C3F80", VA = "0x62C3F80")]
	public float GetPartyMonTrait2(MonTraitID eKey)
	{
		return 0f;
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x000080E8 File Offset: 0x000062E8
	[Token(Token = "0x6001188")]
	[Address(RVA = "0x2C407C", Offset = "0x2C407C", VA = "0x62C407C")]
	public float GetPartyMonTrait3(MonTraitID eKey)
	{
		return 0f;
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001189")]
	[Address(RVA = "0x2C3BC4", Offset = "0x2C3BC4", VA = "0x62C3BC4")]
	[DebuggerHidden]
	private IEnumerator StartNatureMoat2()
	{
		return null;
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118A")]
	[Address(RVA = "0x2C3B40", Offset = "0x2C3B40", VA = "0x62C3B40")]
	[DebuggerHidden]
	private IEnumerator StartAutoHeal()
	{
		return null;
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118B")]
	[Address(RVA = "0x2C3ABC", Offset = "0x2C3ABC", VA = "0x62C3ABC")]
	[DebuggerHidden]
	private IEnumerator StartWaterMoat()
	{
		return null;
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118C")]
	[Address(RVA = "0x2C4178", Offset = "0x2C4178", VA = "0x62C4178")]
	[DebuggerHidden]
	private IEnumerator StartCountDown()
	{
		return null;
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118D")]
	[Address(RVA = "0x2C41FC", Offset = "0x2C41FC", VA = "0x62C41FC")]
	[DebuggerHidden]
	private IEnumerator StartNumQuiz()
	{
		return null;
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118E")]
	[Address(RVA = "0x2C4280", Offset = "0x2C4280", VA = "0x62C4280")]
	[DebuggerHidden]
	private IEnumerator StartTFNumQuiz()
	{
		return null;
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600118F")]
	[Address(RVA = "0x2C4304", Offset = "0x2C4304", VA = "0x62C4304")]
	public void nChooseAnswer(int nNum)
	{
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001190")]
	[Address(RVA = "0x2C5750", Offset = "0x2C5750", VA = "0x62C5750", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001191")]
	[Address(RVA = "0x2C718C", Offset = "0x2C718C", VA = "0x62C718C")]
	[DebuggerHidden]
	private IEnumerator UpdateTarget()
	{
		return null;
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x0600132A RID: 4906 RVA: 0x00008100 File Offset: 0x00006300
	[Token(Token = "0x1700018A")]
	private short sRandomEnemy
	{
		[Token(Token = "0x6001192")]
		[Address(RVA = "0x2C7210", Offset = "0x2C7210", VA = "0x62C7210")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001193")]
	[Address(RVA = "0x2C3A38", Offset = "0x2C3A38", VA = "0x62C3A38")]
	[DebuggerHidden]
	private IEnumerator UpdateWave()
	{
		return null;
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001194")]
	[Address(RVA = "0x2C72C8", Offset = "0x2C72C8", VA = "0x62C72C8")]
	public void MoveToDropItem()
	{
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001195")]
	[Address(RVA = "0x2C7904", Offset = "0x2C7904", VA = "0x62C7904")]
	private void ClearMutation()
	{
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001196")]
	[Address(RVA = "0x2C7A38", Offset = "0x2C7A38", VA = "0x62C7A38")]
	private void AddMutation(MutateType eID, float fFac1, float fFac2)
	{
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001197")]
	[Address(RVA = "0x2C77DC", Offset = "0x2C77DC", VA = "0x62C77DC")]
	public void MoveToNextDay()
	{
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001198")]
	[Address(RVA = "0x2C7C18", Offset = "0x2C7C18", VA = "0x62C7C18")]
	private void SpawnEnemyWave(short sID, int nDiff, int nDay)
	{
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001199")]
	[Address(RVA = "0x2C7CF4", Offset = "0x2C7CF4", VA = "0x62C7CF4")]
	private Enemy SpawnEnemy(short sID, float fX, float fY, int nDiff, int nDay, bool bBoss)
	{
		return null;
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06001332 RID: 4914 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700018B")]
	private BattleItemData currentWeapon
	{
		[Token(Token = "0x600119A")]
		[Address(RVA = "0x2C7FA4", Offset = "0x2C7FA4", VA = "0x62C7FA4")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06001333 RID: 4915 RVA: 0x00008118 File Offset: 0x00006318
	[Token(Token = "0x1700018C")]
	private ObscuredInt crAmmo
	{
		[Token(Token = "0x600119B")]
		[Address(RVA = "0x2C804C", Offset = "0x2C804C", VA = "0x62C804C")]
		get
		{
			return default(ObscuredInt);
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06001334 RID: 4916 RVA: 0x00008130 File Offset: 0x00006330
	[Token(Token = "0x1700018D")]
	private ObscuredInt crMaxAmmo
	{
		[Token(Token = "0x600119C")]
		[Address(RVA = "0x2C8084", Offset = "0x2C8084", VA = "0x62C8084")]
		get
		{
			return default(ObscuredInt);
		}
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600119D")]
	[Address(RVA = "0x2C80BC", Offset = "0x2C80BC", VA = "0x62C80BC")]
	private DmgText GetDmgText()
	{
		return null;
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600119E")]
	[Address(RVA = "0x2C7E64", Offset = "0x2C7E64", VA = "0x62C7E64")]
	private Enemy GetEnemy()
	{
		return null;
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600119F")]
	[Address(RVA = "0x2C8180", Offset = "0x2C8180", VA = "0x62C8180")]
	private void MakeCoin(BattleCoinElt.Type eType, float fGold, Vector3 vOri, float fSize)
	{
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x2BC894", Offset = "0x2BC894", VA = "0x62BC894")]
	private void ClearAllEnemy()
	{
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x2C84F0", Offset = "0x2C84F0", VA = "0x62C84F0")]
	private void ClearAllEnemyByDamage()
	{
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x2CB2B4", Offset = "0x2CB2B4", VA = "0x62CB2B4")]
	private void NextWave()
	{
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x0600133B RID: 4923 RVA: 0x00008148 File Offset: 0x00006348
	[Token(Token = "0x1700018E")]
	private bool isClear
	{
		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x2CB408", Offset = "0x2CB408", VA = "0x62CB408")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x2CB518", Offset = "0x2CB518", VA = "0x62CB518")]
	public void OnCollisionBullet(Bullet bul, Enemy em)
	{
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x2CDB4C", Offset = "0x2CDB4C", VA = "0x62CDB4C")]
	[DebuggerHidden]
	private IEnumerator ShootFireLift(Monster mon, bool bCri, Vector2 vStart, Vector2 vDiff, float fDmg)
	{
		return null;
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x2CD098", Offset = "0x2CD098", VA = "0x62CD098")]
	[DebuggerHidden]
	private IEnumerator CheckFireBall(int nNum, Vector2 vPos, float fAddSize, Enemy em, Bullet bul)
	{
		return null;
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x2CD2B8", Offset = "0x2CD2B8", VA = "0x62CD2B8")]
	[DebuggerHidden]
	private IEnumerator CheckSnowBall(int nNum, Vector2 vPos, float fAddSize, Enemy em, Bullet bul)
	{
		return null;
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x2CD198", Offset = "0x2CD198", VA = "0x62CD198")]
	[DebuggerHidden]
	private IEnumerator CheckFireLance(int nNum, Vector2 vPos, float fAddSize, Enemy em, Bullet bul)
	{
		return null;
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x2AE274", Offset = "0x2AE274", VA = "0x62AE274")]
	public void OnShooting(Monster mon, Vector3 targetPos, long nEquip, bool bAuto, int nAtkTime)
	{
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x2CF73C", Offset = "0x2CF73C", VA = "0x62CF73C")]
	private void PlayWeaponThrowSound(WeaponType eWeapon)
	{
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x2CF260", Offset = "0x2CF260", VA = "0x62CF260")]
	[DebuggerHidden]
	private IEnumerator StartChainLightning(Monster mon, Enemy em, BattleItemData bData, Vector2 vLastPos, float fPlus, bool bThunder, bool bCri, int nTimes, bool bBig)
	{
		return null;
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x2CE9F4", Offset = "0x2CE9F4", VA = "0x62CE9F4")]
	private void HitThunder(Vector2 v2Pos, Monster mon, BattleItemData bData, float fPlus, bool bCri, bool bBig)
	{
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x2CFA40", Offset = "0x2CFA40", VA = "0x62CFA40")]
	[DebuggerHidden]
	private IEnumerator StartUnlimitedSword(Monster mon, BattleItemData bData, float fDmg, int nTimes)
	{
		return null;
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x2CF5B4", Offset = "0x2CF5B4", VA = "0x62CF5B4")]
	[DebuggerHidden]
	private IEnumerator StartSummonSword(Monster mon, Vector3 vTgtPos, BattleItemData bData, float fDmg, int nShot, bool bCri, bool bThree, bool bLeft, bool bGap)
	{
		return null;
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x2C36F4", Offset = "0x2C36F4", VA = "0x62C36F4")]
	private void RefreshAmmo()
	{
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x2CF3EC", Offset = "0x2CF3EC", VA = "0x62CF3EC")]
	[DebuggerHidden]
	private IEnumerator HitArea(Vector2 v2Pos, Monster mon, long nEquip, float fPlus, bool bCri, string strFX, float fHitSize, float fAddSize, float fTimeGap, bool bBig, bool bSlash = false)
	{
		return null;
	}

	// Token: 0x06001349 RID: 4937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x2CDC80", Offset = "0x2CDC80", VA = "0x62CDC80")]
	public void OnShootLaser(Monster mon, Vector3 vStart, Vector3 vEnd, float fSize, float fPlus, int nLaserNum, bool bDmg, bool bCri)
	{
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x2BCF58", Offset = "0x2BCF58", VA = "0x62BCF58")]
	public Bullet GetBullet(Vector3 vPos)
	{
		return null;
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x2CFB34", Offset = "0x2CFB34", VA = "0x62CFB34")]
	public EnemyBullet GetEnemyBullet(Vector3 vPos)
	{
		return null;
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x2BD28C", Offset = "0x2BD28C", VA = "0x62BD28C")]
	public void OnBulletDiabled(Bullet bul)
	{
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x2CFE34", Offset = "0x2CFE34", VA = "0x62CFE34")]
	public void OnBulletRicochet(Bullet bul, Enemy pPreEnemy)
	{
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x00008160 File Offset: 0x00006360
	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x2CC924", Offset = "0x2CC924", VA = "0x62CC924")]
	private bool MonsterDamage(Enemy em, Bullet bul, float fDmgPlus = 1f)
	{
		return default(bool);
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x2CD3B8", Offset = "0x2CD3B8", VA = "0x62CD3B8")]
	[DebuggerHidden]
	private IEnumerator OnSoulExplosion(float fDmg, Vector3 vPos, float fSize = 1f)
	{
		return null;
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x2C8770", Offset = "0x2C8770", VA = "0x62C8770")]
	private void MonsterDamage(Enemy em, double dDmg, bool bCri, [Optional] Monster pMon, bool bForce = false, bool bCalc = true)
	{
	}

	// Token: 0x06001351 RID: 4945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x2D060C", Offset = "0x2D060C", VA = "0x62D060C")]
	private void ShowText(Vector3 vPos, string strMsg, Color clText, float fDist = 80f)
	{
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x2D0780", Offset = "0x2D0780", VA = "0x62D0780")]
	public void SetFlash(float r, float g, float b, float a = 0.25f, float fSpd = 2f)
	{
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x2D07FC", Offset = "0x2D07FC", VA = "0x62D07FC")]
	public void OnEnemyDead(Enemy em)
	{
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x2D1DE0", Offset = "0x2D1DE0", VA = "0x62D1DE0")]
	public void OnEnemyDisable(Enemy em)
	{
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x2D1E30", Offset = "0x2D1E30", VA = "0x62D1E30")]
	public void OnEnemyShooting(Enemy em)
	{
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x2C4730", Offset = "0x2C4730", VA = "0x62C4730")]
	public void DungeonDamage(float fDmg)
	{
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x2D03EC", Offset = "0x2D03EC", VA = "0x62D03EC")]
	public void DungeonHeal(float fHeal, bool isRegen = false)
	{
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x2D1FDC", Offset = "0x2D1FDC", VA = "0x62D1FDC")]
	public void OnEnemyBulletCollision(EnemyBullet bul)
	{
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x2D2FE0", Offset = "0x2D2FE0", VA = "0x62D2FE0")]
	public void OnEnemyAttack(Enemy em)
	{
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x00008178 File Offset: 0x00006378
	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x2D2A1C", Offset = "0x2D2A1C", VA = "0x62D2A1C")]
	public float GetReducedDamage(Enemy em, float fDmg)
	{
		return 0f;
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x2B4FF8", Offset = "0x2B4FF8", VA = "0x62B4FF8")]
	public void OnReload(Monster mon)
	{
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x2B7D94", Offset = "0x2B7D94", VA = "0x62B7D94")]
	public void OnMainReloading(float fFill)
	{
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00008190 File Offset: 0x00006390
	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x2D3990", Offset = "0x2D3990", VA = "0x62D3990")]
	private float GetMonDPS(int nPos)
	{
		return 0f;
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x000081A8 File Offset: 0x000063A8
	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x2D3B94", Offset = "0x2D3B94", VA = "0x62D3B94")]
	public bool CanUseAutoSkill()
	{
		return default(bool);
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x2D3D40", Offset = "0x2D3D40", VA = "0x62D3D40")]
	public void OnActiveSkill(int nPos, SkillKey eSkill)
	{
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C8")]
	[Address(RVA = "0x2D6E2C", Offset = "0x2D6E2C", VA = "0x62D6E2C")]
	public void OnAwakenSkill(int nPos, SkillKey eSkill, AwakenSkillElt elt)
	{
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x2D6B4C", Offset = "0x2D6B4C", VA = "0x62D6B4C")]
	[DebuggerHidden]
	private IEnumerator ShowFireStorm(string strFX)
	{
		return null;
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x2D6CCC", Offset = "0x2D6CCC", VA = "0x62D6CCC")]
	[DebuggerHidden]
	private IEnumerator ShowMoonCrystal()
	{
		return null;
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x2D6BEC", Offset = "0x2D6BEC", VA = "0x62D6BEC")]
	[DebuggerHidden]
	private IEnumerator StartPoisonMyst(Monster mon, float fDmg, float fDur)
	{
		return null;
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x2D785C", Offset = "0x2D785C", VA = "0x62D785C")]
	[DebuggerHidden]
	private IEnumerator ShowPoisonMyst()
	{
		return null;
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x2D6980", Offset = "0x2D6980", VA = "0x62D6980")]
	[DebuggerHidden]
	private IEnumerator ThrowBoneParty(Monster mon, int nNum, float fDmg)
	{
		return null;
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x2C396C", Offset = "0x2C396C", VA = "0x62C396C")]
	public void SetAlarm(string strTitle, string strSub, float fFadeIn, float fShow, float fFadeOut)
	{
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x2BF448", Offset = "0x2BF448", VA = "0x62BF448")]
	public void SetMutationAlarm(string strTitle, string strSub, float fFadeIn, float fShow, float fFadeOut)
	{
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x2B9B38", Offset = "0x2B9B38", VA = "0x62B9B38")]
	public void SetWaveAlarm(string strWave, float fFadeIn, float fShow, float fFadeOut)
	{
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x2D79A8", Offset = "0x2D79A8", VA = "0x62D79A8")]
	[DebuggerHidden]
	private IEnumerator ShowBalanceGuage()
	{
		return null;
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x2D78C8", Offset = "0x2D78C8", VA = "0x62D78C8")]
	[DebuggerHidden]
	private IEnumerator ShowAlarm(CanvasGroup cg, float fFadeIn, float fShow, float fFadeOut)
	{
		return null;
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x2D6A5C", Offset = "0x2D6A5C", VA = "0x62D6A5C")]
	[DebuggerHidden]
	private IEnumerator HighSlash(bool bAll, int nPos, int nMax, float fDmg)
	{
		return null;
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x2D6D50", Offset = "0x2D6D50", VA = "0x62D6D50")]
	[DebuggerHidden]
	private IEnumerator StartFireExplosion(Monster mon, int nMax, float fPlus)
	{
		return null;
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x2CE93C", Offset = "0x2CE93C", VA = "0x62CE93C")]
	private Enemy GetRandomEnemy(Enemy em)
	{
		return null;
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x2CE564", Offset = "0x2CE564", VA = "0x62CE564")]
	private Enemy GetRandomEnemy(List<Enemy> listAlready)
	{
		return null;
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x000081C0 File Offset: 0x000063C0
	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x2AA58C", Offset = "0x2AA58C", VA = "0x62AA58C")]
	public static bool CheckMutation(MutateType eType)
	{
		return default(bool);
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x000081D8 File Offset: 0x000063D8
	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x2AA11C", Offset = "0x2AA11C", VA = "0x62AA11C")]
	public static float GetMutation1(MutateType eType)
	{
		return 0f;
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x000081F0 File Offset: 0x000063F0
	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x2B6424", Offset = "0x2B6424", VA = "0x62B6424")]
	public static float GetMutation2(MutateType eType)
	{
		return 0f;
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x2D7A2C", Offset = "0x2D7A2C", VA = "0x62D7A2C")]
	public void OnGoldReach(BattleCoinElt elt)
	{
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x2CD4A4", Offset = "0x2CD4A4", VA = "0x62CD4A4")]
	public void OnItemReach(BattleCoinElt.Type eType, float fGold = -1f)
	{
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x2C6FD0", Offset = "0x2C6FD0", VA = "0x62C6FD0")]
	public void OnPause()
	{
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x2D7B60", Offset = "0x2D7B60", VA = "0x62D7B60")]
	public void OnToggleAutoBattleStart()
	{
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x2D7C80", Offset = "0x2D7C80", VA = "0x62D7C80")]
	public void OnResume()
	{
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x2D81E0", Offset = "0x2D81E0", VA = "0x62D81E0")]
	public void OnHealerActive(Enemy em)
	{
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x2D8520", Offset = "0x2D8520", VA = "0x62D8520")]
	public void OnCorruptActive(Enemy em)
	{
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x2D8768", Offset = "0x2D8768", VA = "0x62D8768")]
	public void OnForceReloadActive(Enemy em)
	{
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x2D89D8", Offset = "0x2D89D8", VA = "0x62D89D8")]
	public void OnClockOver()
	{
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x2D8DD0", Offset = "0x2D8DD0", VA = "0x62D8DD0")]
	public void OnStoneClick(int nStone)
	{
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x2D9150", Offset = "0x2D9150", VA = "0x62D9150")]
	private void RefreshStone()
	{
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x2D92B8", Offset = "0x2D92B8", VA = "0x62D92B8")]
	public void OnMoveBalance(bool bUp)
	{
	}

	// Token: 0x04001082 RID: 4226
	[Token(Token = "0x4000EC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PageBattle obj;

	// Token: 0x04001083 RID: 4227
	[Token(Token = "0x4000EC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource _asMusic;

	// Token: 0x04001084 RID: 4228
	[Token(Token = "0x4000EC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public List<Monster> listMonster;

	// Token: 0x04001085 RID: 4229
	[Token(Token = "0x4000ECA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Enemy> listEnemy;

	// Token: 0x04001086 RID: 4230
	[Token(Token = "0x4000ECB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Text textGold;

	// Token: 0x04001087 RID: 4231
	[Token(Token = "0x4000ECC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text textWave;

	// Token: 0x04001088 RID: 4232
	[Token(Token = "0x4000ECD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Text textHP;

	// Token: 0x04001089 RID: 4233
	[Token(Token = "0x4000ECE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text textItem;

	// Token: 0x0400108A RID: 4234
	[Token(Token = "0x4000ECF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Text textDay;

	// Token: 0x0400108B RID: 4235
	[Token(Token = "0x4000ED0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text textDiff;

	// Token: 0x0400108C RID: 4236
	[Token(Token = "0x4000ED1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public GameObject eltEnemy;

	// Token: 0x0400108D RID: 4237
	[Token(Token = "0x4000ED2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform trBattle;

	// Token: 0x0400108E RID: 4238
	[Token(Token = "0x4000ED3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public DmgText dmgText;

	// Token: 0x0400108F RID: 4239
	[Token(Token = "0x4000ED4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform trDmgTextList;

	// Token: 0x04001090 RID: 4240
	[Token(Token = "0x4000ED5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public GameObject goBullet;

	// Token: 0x04001091 RID: 4241
	[Token(Token = "0x4000ED6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject goEnemyBullet;

	// Token: 0x04001092 RID: 4242
	[Token(Token = "0x4000ED7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Image imgFillAmmo;

	// Token: 0x04001093 RID: 4243
	[Token(Token = "0x4000ED8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image imgAmmoIcon;

	// Token: 0x04001094 RID: 4244
	[Token(Token = "0x4000ED9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Text textAmmo;

	// Token: 0x04001095 RID: 4245
	[Token(Token = "0x4000EDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ActiveSkillElt[] arrActiveSkill;

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4000EDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public RectTransform rtLeftSkill;

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4000EDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject goLeftSkill;

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4000EDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public GameObject goBotSkill;

	// Token: 0x04001099 RID: 4249
	[Token(Token = "0x4000EDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ActiveSkillElt[] arrActiveSkillLeft;

	// Token: 0x0400109A RID: 4250
	[Token(Token = "0x4000EDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public AwakenSkillElt eltAwakenBot;

	// Token: 0x0400109B RID: 4251
	[Token(Token = "0x4000EE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AwakenSkillElt eltAwakenLeft;

	// Token: 0x0400109C RID: 4252
	[Token(Token = "0x4000EE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public CanvasGroup cgAlarm;

	// Token: 0x0400109D RID: 4253
	[Token(Token = "0x4000EE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text textAlarmTitle;

	// Token: 0x0400109E RID: 4254
	[Token(Token = "0x4000EE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public Text textAlarmSub;

	// Token: 0x0400109F RID: 4255
	[Token(Token = "0x4000EE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public CanvasGroup cgMutationAlarm;

	// Token: 0x040010A0 RID: 4256
	[Token(Token = "0x4000EE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public Text textMutAlarmTitle;

	// Token: 0x040010A1 RID: 4257
	[Token(Token = "0x4000EE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Text textMutAlarmSub;

	// Token: 0x040010A2 RID: 4258
	[Token(Token = "0x4000EE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Text textMutDesc;

	// Token: 0x040010A3 RID: 4259
	[Token(Token = "0x4000EE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public CanvasGroup cgWaveAlarm;

	// Token: 0x040010A4 RID: 4260
	[Token(Token = "0x4000EE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public Text texWaveAlarm;

	// Token: 0x040010A5 RID: 4261
	[Token(Token = "0x4000EEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Image imgGoldIcon;

	// Token: 0x040010A6 RID: 4262
	[Token(Token = "0x4000EEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public Image imgItemIcon;

	// Token: 0x040010A7 RID: 4263
	[Token(Token = "0x4000EEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public ParticleElt psGold;

	// Token: 0x040010A8 RID: 4264
	[Token(Token = "0x4000EED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public ParticleElt psItem;

	// Token: 0x040010A9 RID: 4265
	[Token(Token = "0x4000EEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ParticleElt psHp;

	// Token: 0x040010AA RID: 4266
	[Token(Token = "0x4000EEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public GameObject goCoin;

	// Token: 0x040010AB RID: 4267
	[Token(Token = "0x4000EF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject goBoss;

	// Token: 0x040010AC RID: 4268
	[Token(Token = "0x4000EF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Image imgBossHP;

	// Token: 0x040010AD RID: 4269
	[Token(Token = "0x4000EF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Image imgDunHP;

	// Token: 0x040010AE RID: 4270
	[Token(Token = "0x4000EF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public GameObject goDarkMyst;

	// Token: 0x040010AF RID: 4271
	[Token(Token = "0x4000EF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject goNumQuiz;

	// Token: 0x040010B0 RID: 4272
	[Token(Token = "0x4000EF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public GameObject goClock;

	// Token: 0x040010B1 RID: 4273
	[Token(Token = "0x4000EF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject goStone;

	// Token: 0x040010B2 RID: 4274
	[Token(Token = "0x4000EF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public GameObject[] arrStoneActive;

	// Token: 0x040010B3 RID: 4275
	[Token(Token = "0x4000EF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public BattleLaserElt[] arrLaser;

	// Token: 0x040010B4 RID: 4276
	[Token(Token = "0x4000EF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public AudioSource asLaser;

	// Token: 0x040010B5 RID: 4277
	[Token(Token = "0x4000EFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Text[] textNumQuiz;

	// Token: 0x040010B6 RID: 4278
	[Token(Token = "0x4000EFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public GameObject goDmgMeter;

	// Token: 0x040010B7 RID: 4279
	[Token(Token = "0x4000EFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Text textDmgMeter;

	// Token: 0x040010B8 RID: 4280
	[Token(Token = "0x4000EFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public GameObject[] goDmgMeterUnit;

	// Token: 0x040010B9 RID: 4281
	[Token(Token = "0x4000EFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Image[] arrDmgMeterFill;

	// Token: 0x040010BA RID: 4282
	[Token(Token = "0x4000EFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public Text[] arrDmgMeterName;

	// Token: 0x040010BB RID: 4283
	[Token(Token = "0x4000F00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Text[] arrDmgMeterAmount;

	// Token: 0x040010BC RID: 4284
	[Token(Token = "0x4000F01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public GameObject[] goBattleBG;

	// Token: 0x040010BD RID: 4285
	[Token(Token = "0x4000F02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public LightningBoltPrefabScript pLightning;

	// Token: 0x040010BE RID: 4286
	[Token(Token = "0x4000F03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public ParticleElt psBlizzard;

	// Token: 0x040010BF RID: 4287
	[Token(Token = "0x4000F04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public ParticleElt psDivine;

	// Token: 0x040010C0 RID: 4288
	[Token(Token = "0x4000F05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public Text textAutoBattleStart;

	// Token: 0x040010C1 RID: 4289
	[Token(Token = "0x4000F06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject goAutoBattleStart;

	// Token: 0x040010C2 RID: 4290
	[Token(Token = "0x4000F07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public GameObject goAutoBattleStartOn;

	// Token: 0x040010C3 RID: 4291
	[Token(Token = "0x4000F08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public SpriteRenderer srBlockGradient;

	// Token: 0x040010C4 RID: 4292
	[Token(Token = "0x4000F09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public SpriteRenderer srBlockLeft;

	// Token: 0x040010C5 RID: 4293
	[Token(Token = "0x4000F0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private List<Bullet> listBulletAlive;

	// Token: 0x040010C6 RID: 4294
	[Token(Token = "0x4000F0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private List<Bullet> listBulletDead;

	// Token: 0x040010C7 RID: 4295
	[Token(Token = "0x4000F0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private List<EnemyBullet> listEnemyBulletAlive;

	// Token: 0x040010C8 RID: 4296
	[Token(Token = "0x4000F0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private List<EnemyBullet> listEnemyBulletDead;

	// Token: 0x040010C9 RID: 4297
	[Token(Token = "0x4000F0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private List<BattleCoinElt> listCoinAlive;

	// Token: 0x040010CA RID: 4298
	[Token(Token = "0x4000F0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private List<BattleCoinElt> listCoinDead;

	// Token: 0x040010CB RID: 4299
	[Token(Token = "0x4000F10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private float fShowGold;

	// Token: 0x040010CC RID: 4300
	[Token(Token = "0x4000F11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private float fTargetGold;

	// Token: 0x040010CD RID: 4301
	[Token(Token = "0x4000F12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int nTargetItemCnt;

	// Token: 0x040010CE RID: 4302
	[Token(Token = "0x4000F13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private int nMainMon;

	// Token: 0x040010CF RID: 4303
	[Token(Token = "0x4000F14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private int nAnswer;

	// Token: 0x040010D0 RID: 4304
	[Token(Token = "0x4000F15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private int nQuizTime;

	// Token: 0x040010D1 RID: 4305
	[Token(Token = "0x4000F16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public short sBossID;

	// Token: 0x040010D2 RID: 4306
	[Token(Token = "0x4000F17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public Enemy[] emTrialBoss;

	// Token: 0x040010D3 RID: 4307
	[Token(Token = "0x4000F18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Image imgBalanceGuage;

	// Token: 0x040010D4 RID: 4308
	[Token(Token = "0x4000F19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public GameObject goBalanceGuage;

	// Token: 0x040010D5 RID: 4309
	[Token(Token = "0x4000F1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private float fSoulBombDps;

	// Token: 0x040010D6 RID: 4310
	[Token(Token = "0x4000F1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private Material matLaser;

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x4000F1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private List<DmgText> listDmgText;

	// Token: 0x040010D8 RID: 4312
	[Token(Token = "0x4000F1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private int nDmgText;

	// Token: 0x040010D9 RID: 4313
	[Token(Token = "0x4000F1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[Attribute(Name = "HideInInspector", RVA = "0x185128", Offset = "0x185128")]
	public ObscuredBool bBattleOver;

	// Token: 0x040010DA RID: 4314
	[Token(Token = "0x4000F1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	[Attribute(Name = "HideInInspector", RVA = "0x185138", Offset = "0x185138")]
	public ObscuredBool bGameOver;

	// Token: 0x040010DB RID: 4315
	[Token(Token = "0x4000F20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Image imgScreenFX;

	// Token: 0x040010DC RID: 4316
	[Token(Token = "0x4000F21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	[Attribute(Name = "HideInInspector", RVA = "0x185148", Offset = "0x185148")]
	public Vector2 vScreen;

	// Token: 0x040010DD RID: 4317
	[Token(Token = "0x4000F22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185158", Offset = "0x185158")]
	public Vector3 vGoldPos;

	// Token: 0x040010DE RID: 4318
	[Token(Token = "0x4000F23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[Attribute(Name = "HideInInspector", RVA = "0x185168", Offset = "0x185168")]
	public Vector3 vItemPos;

	// Token: 0x040010DF RID: 4319
	[Token(Token = "0x4000F24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	[Attribute(Name = "HideInInspector", RVA = "0x185178", Offset = "0x185178")]
	public Vector3 vHpPos;

	// Token: 0x040010E0 RID: 4320
	[Token(Token = "0x4000F25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static List<MutateType> listMutation;

	// Token: 0x040010E1 RID: 4321
	[Token(Token = "0x4000F26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<MutateType, ObscuredFloat> dictMutation1;

	// Token: 0x040010E2 RID: 4322
	[Token(Token = "0x4000F27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static Dictionary<MutateType, ObscuredFloat> dictMutation2;

	// Token: 0x040010E3 RID: 4323
	[Token(Token = "0x4000F28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float fDropRate;

	// Token: 0x040010E4 RID: 4324
	[Token(Token = "0x4000F29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private ObscuredFloat fInvincibleDur;

	// Token: 0x040010E5 RID: 4325
	[Token(Token = "0x4000F2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private ObscuredInt nHarvestNum;

	// Token: 0x040010E6 RID: 4326
	[Token(Token = "0x4000F2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private ObscuredInt nDamagedNum;

	// Token: 0x040010E7 RID: 4327
	[Token(Token = "0x4000F2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private ObscuredFloat fBigShieldHP;

	// Token: 0x040010E8 RID: 4328
	[Token(Token = "0x4000F2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private List<short> listRandomSpawn;

	// Token: 0x040010E9 RID: 4329
	[Token(Token = "0x4000F2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private Color clScreen;

	// Token: 0x040010EA RID: 4330
	[Token(Token = "0x4000F2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private float fScreenSpd;

	// Token: 0x040010EB RID: 4331
	[Token(Token = "0x4000F30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static float fSpawnX;

	// Token: 0x040010EC RID: 4332
	[Token(Token = "0x4000F31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public float fSuperLaserTime;

	// Token: 0x040010ED RID: 4333
	[Token(Token = "0x4000F32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	public float fSuperBladeTime;

	// Token: 0x040010EE RID: 4334
	[Token(Token = "0x4000F33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public float fSuperLightningTime;

	// Token: 0x040010EF RID: 4335
	[Token(Token = "0x4000F34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	public ObscuredInt nMustReduced;

	// Token: 0x040010F0 RID: 4336
	[Token(Token = "0x4000F35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	public ObscuredFloat fLightShield;

	// Token: 0x040010F1 RID: 4337
	[Token(Token = "0x4000F36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public ObscuredBool bLightShield;

	// Token: 0x040010F2 RID: 4338
	[Token(Token = "0x4000F37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	public ObscuredFloat fPainKillerDur;

	// Token: 0x040010F3 RID: 4339
	[Token(Token = "0x4000F38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public ObscuredFloat fPainKillerCool;

	// Token: 0x040010F4 RID: 4340
	[Token(Token = "0x4000F39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	public ObscuredBool bCanRevive;

	// Token: 0x040010F5 RID: 4341
	[Token(Token = "0x4000F3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public ObscuredFloat fDarkMutDmg;

	// Token: 0x040010F6 RID: 4342
	[Token(Token = "0x4000F3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	public float fCurrentBalanceGuage;

	// Token: 0x040010F7 RID: 4343
	[Token(Token = "0x4000F3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public float fAddBalanceGuage;

	// Token: 0x040010F8 RID: 4344
	[Token(Token = "0x4000F3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
	public MutateType eTrial;

	// Token: 0x040010F9 RID: 4345
	[Token(Token = "0x4000F3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private ObscuredFloat fTrialHP;

	// Token: 0x040010FA RID: 4346
	[Token(Token = "0x4000F3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
	private float fHPRate;

	// Token: 0x040010FB RID: 4347
	[Token(Token = "0x4000F40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private ObscuredInt nDiff;

	// Token: 0x040010FC RID: 4348
	[Token(Token = "0x4000F41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private ObscuredInt nDay;

	// Token: 0x040010FD RID: 4349
	[Token(Token = "0x4000F42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Vector3 vShakePos;

	// Token: 0x040010FE RID: 4350
	[Token(Token = "0x4000F43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private RaycastHit2D[] hits;

	// Token: 0x040010FF RID: 4351
	[Token(Token = "0x4000F44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
	private ObscuredFloat fDungeonDef;

	// Token: 0x04001100 RID: 4352
	[Token(Token = "0x4000F45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private ObscuredFloat fNatureShell;

	// Token: 0x04001101 RID: 4353
	[Token(Token = "0x4000F46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	protected Dictionary<int, Dictionary<SkillKey, float[]>> dictSkillFac;

	// Token: 0x04001102 RID: 4354
	[Token(Token = "0x4000F47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	protected Dictionary<int, Dictionary<MonTraitID, float[]>> dictMonTraitFac;

	// Token: 0x04001103 RID: 4355
	[Token(Token = "0x4000F48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
	protected Dictionary<MonTraitID, float[]> dictMonTraitPartyFac;

	// Token: 0x04001104 RID: 4356
	[Token(Token = "0x4000F49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private bool bMutate;

	// Token: 0x04001105 RID: 4357
	[Token(Token = "0x4000F4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x321")]
	private bool bBossMutate;

	// Token: 0x04001106 RID: 4358
	[Token(Token = "0x4000F4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
	private string strMutation;

	// Token: 0x04001107 RID: 4359
	[Token(Token = "0x4000F4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	private string strMutationDesc;

	// Token: 0x04001108 RID: 4360
	[Token(Token = "0x4000F4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
	private Monster pSoulMon;

	// Token: 0x04001109 RID: 4361
	[Token(Token = "0x4000F4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	private Vector3 vTargetPos;

	// Token: 0x0400110A RID: 4362
	[Token(Token = "0x4000F4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
	private bool bSummon;

	// Token: 0x0400110B RID: 4363
	[Token(Token = "0x4000F50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	private float fWaveTime;

	// Token: 0x0400110C RID: 4364
	[Token(Token = "0x4000F51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	private int nWaveTarget;

	// Token: 0x0400110D RID: 4365
	[Token(Token = "0x4000F52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	private bool bNoWeapon;

	// Token: 0x0400110E RID: 4366
	[Token(Token = "0x4000F53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
	private Rect rtBox;

	// Token: 0x0400110F RID: 4367
	[Token(Token = "0x4000F54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static float[] fDegreeFireLance;

	// Token: 0x04001110 RID: 4368
	[Token(Token = "0x4000F55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
	private Vector3 vFirePos;

	// Token: 0x04001111 RID: 4369
	[Token(Token = "0x4000F56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	private Vector3 vLaserPos;

	// Token: 0x04001112 RID: 4370
	[Token(Token = "0x4000F57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	private Vector3 vLightningPos;

	// Token: 0x04001113 RID: 4371
	[Token(Token = "0x4000F58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	private int nLaserOrder;

	// Token: 0x04001114 RID: 4372
	[Token(Token = "0x4000F59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
	private RaycastHit2D[] arrRayHits;

	// Token: 0x04001115 RID: 4373
	[Token(Token = "0x4000F5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static Vector3 vEnemyFirePos;

	// Token: 0x04001116 RID: 4374
	[Token(Token = "0x4000F5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	private Vector3 vHitPos;

	// Token: 0x04001117 RID: 4375
	[Token(Token = "0x4000F5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x394")]
	private bool bLastEnemyAlive;

	// Token: 0x04001118 RID: 4376
	[Token(Token = "0x4000F5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	private float fLastCheckTime;

	// Token: 0x04001119 RID: 4377
	[Token(Token = "0x4000F5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
	private Coroutine crAlarm;

	// Token: 0x0400111A RID: 4378
	[Token(Token = "0x4000F5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	private int[] nStoneOrder;

	// Token: 0x0400111B RID: 4379
	[Token(Token = "0x4000F60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
	private int nNowStoneOrder;

	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000352")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FE40", Offset = "0x17FE40")]
	private sealed class <StartNatureMoat2>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x0600137F RID: 4991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x307224", Offset = "0x307224", VA = "0x6307224")]
		[DebuggerHidden]
		public <StartNatureMoat2>c__Iterator0()
		{
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x30722C", Offset = "0x30722C", VA = "0x630722C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001CB")]
		private object Current
		{
			[Token(Token = "0x60015DA")]
			[Address(RVA = "0x307480", Offset = "0x307480", VA = "0x6307480", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001CC")]
		private object Current
		{
			[Token(Token = "0x60015DB")]
			[Address(RVA = "0x307488", Offset = "0x307488", VA = "0x6307488", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x307490", Offset = "0x307490", VA = "0x6307490", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x3074A4", Offset = "0x3074A4", VA = "0x63074A4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400111C RID: 4380
		[Token(Token = "0x400148B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float <fInterval>__0;

		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400148C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal List<Enemy> <list>__0;

		// Token: 0x0400111E RID: 4382
		[Token(Token = "0x400148D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Enemy <em>__1;

		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400148E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal PageBattle $this;

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x400148F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal bool $disposing;

		// Token: 0x04001122 RID: 4386
		[Token(Token = "0x4001491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int $PC;
	}

	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000353")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FE50", Offset = "0x17FE50")]
	private sealed class <StartAutoHeal>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001385 RID: 4997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x305B74", Offset = "0x305B74", VA = "0x6305B74")]
		[DebuggerHidden]
		public <StartAutoHeal>c__Iterator1()
		{
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00008220 File Offset: 0x00006420
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x305B7C", Offset = "0x305B7C", VA = "0x6305B7C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001CD")]
		private object Current
		{
			[Token(Token = "0x60015E0")]
			[Address(RVA = "0x305DDC", Offset = "0x305DDC", VA = "0x6305DDC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001CE")]
		private object Current
		{
			[Token(Token = "0x60015E1")]
			[Address(RVA = "0x305DE4", Offset = "0x305DE4", VA = "0x6305DE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x305DEC", Offset = "0x305DEC", VA = "0x6305DEC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x305E00", Offset = "0x305E00", VA = "0x6305E00", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float <fHeal>__0;

		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal PageBattle $this;

		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object $current;

		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool $disposing;

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int $PC;
	}

	// Token: 0x0200031A RID: 794
	[Token(Token = "0x2000354")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FE60", Offset = "0x17FE60")]
	private sealed class <StartWaterMoat>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x0600138B RID: 5003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x30A5AC", Offset = "0x30A5AC", VA = "0x630A5AC")]
		[DebuggerHidden]
		public <StartWaterMoat>c__Iterator2()
		{
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00008238 File Offset: 0x00006438
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x30A5B8", Offset = "0x30A5B8", VA = "0x630A5B8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001CF")]
		private object Current
		{
			[Token(Token = "0x60015E6")]
			[Address(RVA = "0x30AC60", Offset = "0x30AC60", VA = "0x630AC60", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D0")]
		private object Current
		{
			[Token(Token = "0x60015E7")]
			[Address(RVA = "0x30AC68", Offset = "0x30AC68", VA = "0x630AC68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x30AC70", Offset = "0x30AC70", VA = "0x630AC70", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x30AC84", Offset = "0x30AC84", VA = "0x630AC84", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal double <fClose>__0;

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal double <fAll>__0;

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x4001499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal bool <bAll>__0;

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400149A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal PageBattle $this;

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400149B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal object $current;

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400149C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool $disposing;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400149D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int $PC;
	}

	// Token: 0x0200031B RID: 795
	[Token(Token = "0x2000355")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FE70", Offset = "0x17FE70")]
	private sealed class <StartCountDown>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x3066EC", Offset = "0x3066EC", VA = "0x63066EC")]
		[DebuggerHidden]
		public <StartCountDown>c__Iterator3()
		{
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00008250 File Offset: 0x00006450
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x3066F4", Offset = "0x3066F4", VA = "0x63066F4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D1")]
		private object Current
		{
			[Token(Token = "0x60015EC")]
			[Address(RVA = "0x306940", Offset = "0x306940", VA = "0x6306940", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D2")]
		private object Current
		{
			[Token(Token = "0x60015ED")]
			[Address(RVA = "0x306948", Offset = "0x306948", VA = "0x6306948", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x306950", Offset = "0x306950", VA = "0x6306950", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x306964", Offset = "0x306964", VA = "0x6306964", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400149E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float <fTime>__0;

		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x400149F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal PageBattle $this;

		// Token: 0x04001131 RID: 4401
		[Token(Token = "0x40014A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object $current;

		// Token: 0x04001132 RID: 4402
		[Token(Token = "0x40014A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool $disposing;

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x40014A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int $PC;
	}

	// Token: 0x0200031C RID: 796
	[Token(Token = "0x2000356")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FE80", Offset = "0x17FE80")]
	private sealed class <StartNumQuiz>c__Iterator4 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x30752C", Offset = "0x30752C", VA = "0x630752C")]
		[DebuggerHidden]
		public <StartNumQuiz>c__Iterator4()
		{
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x307534", Offset = "0x307534", VA = "0x6307534", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D3")]
		private object Current
		{
			[Token(Token = "0x60015F2")]
			[Address(RVA = "0x308144", Offset = "0x308144", VA = "0x6308144", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D4")]
		private object Current
		{
			[Token(Token = "0x60015F3")]
			[Address(RVA = "0x30814C", Offset = "0x30814C", VA = "0x630814C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x308154", Offset = "0x308154", VA = "0x6308154", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x308168", Offset = "0x308168", VA = "0x6308168", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x40014A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int <nLeft>__0;

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x40014A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int <nRight>__0;

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x40014A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int <nRealAnswer>__0;

		// Token: 0x04001137 RID: 4407
		[Token(Token = "0x40014A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int[] <arrAnswer>__0;

		// Token: 0x04001138 RID: 4408
		[Token(Token = "0x40014A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal PageBattle $this;

		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x40014A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal object $current;

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x40014A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x40014AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int $PC;
	}

	// Token: 0x0200031D RID: 797
	[Token(Token = "0x2000357")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FE90", Offset = "0x17FE90")]
	private sealed class <StartTFNumQuiz>c__Iterator5 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x308F88", Offset = "0x308F88", VA = "0x6308F88")]
		[DebuggerHidden]
		public <StartTFNumQuiz>c__Iterator5()
		{
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x308F90", Offset = "0x308F90", VA = "0x6308F90", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D5")]
		private object Current
		{
			[Token(Token = "0x60015F8")]
			[Address(RVA = "0x309EC0", Offset = "0x309EC0", VA = "0x6309EC0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D6")]
		private object Current
		{
			[Token(Token = "0x60015F9")]
			[Address(RVA = "0x309EC8", Offset = "0x309EC8", VA = "0x6309EC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x309ED0", Offset = "0x309ED0", VA = "0x6309ED0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x309EE4", Offset = "0x309EE4", VA = "0x6309EE4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x40014AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int <nNum1>__0;

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x40014AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int <nNum2>__0;

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x40014AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int <nNum3>__0;

		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x40014AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int <nRealAnswer>__0;

		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x40014AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int[] <nAdder>__0;

		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x40014B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal PageBattle $this;

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x40014B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal object $current;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x40014B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool $disposing;

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x40014B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int $PC;
	}

	// Token: 0x0200031E RID: 798
	[Token(Token = "0x2000358")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FEA0", Offset = "0x17FEA0")]
	private sealed class <UpdateTarget>c__Iterator6 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x30B0C0", Offset = "0x30B0C0", VA = "0x630B0C0")]
		[DebuggerHidden]
		public <UpdateTarget>c__Iterator6()
		{
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x30B0C8", Offset = "0x30B0C8", VA = "0x630B0C8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D7")]
		private object Current
		{
			[Token(Token = "0x60015FE")]
			[Address(RVA = "0x30BC84", Offset = "0x30BC84", VA = "0x630BC84", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D8")]
		private object Current
		{
			[Token(Token = "0x60015FF")]
			[Address(RVA = "0x30BC8C", Offset = "0x30BC8C", VA = "0x630BC8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x30BC94", Offset = "0x30BC94", VA = "0x630BC94", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x30BCA8", Offset = "0x30BCA8", VA = "0x630BCA8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x40014B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float <fMin>__0;

		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x40014B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float <fDist>__0;

		// Token: 0x04001147 RID: 4423
		[Token(Token = "0x40014B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Enemy <em>__0;

		// Token: 0x04001148 RID: 4424
		[Token(Token = "0x40014B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float[] <fTargetRefresh>__0;

		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x40014B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal PageBattle $this;

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x40014B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal object $current;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x40014BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x40014BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int $PC;
	}

	// Token: 0x0200031F RID: 799
	[Token(Token = "0x2000359")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FEB0", Offset = "0x17FEB0")]
	private sealed class <UpdateWave>c__Iterator7 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x30BD30", Offset = "0x30BD30", VA = "0x630BD30")]
		[DebuggerHidden]
		public <UpdateWave>c__Iterator7()
		{
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x30BD38", Offset = "0x30BD38", VA = "0x630BD38", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001D9")]
		private object Current
		{
			[Token(Token = "0x6001604")]
			[Address(RVA = "0x316AE0", Offset = "0x316AE0", VA = "0x6316AE0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001DA")]
		private object Current
		{
			[Token(Token = "0x6001605")]
			[Address(RVA = "0x316AE8", Offset = "0x316AE8", VA = "0x6316AE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x316AF0", Offset = "0x316AF0", VA = "0x6316AF0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x316B04", Offset = "0x316B04", VA = "0x6316B04", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x40014BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal bool <bClear>__0;

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x40014BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int <nSpawn>__1;

		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x40014BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int <nBossWave>__1;

		// Token: 0x04001150 RID: 4432
		[Token(Token = "0x40014BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float <fWaveGap>__2;

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x40014C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int <nSpawn>__3;

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x40014C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float <fWaveGap>__3;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x40014C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal TrialData <tData>__4;

		// Token: 0x04001154 RID: 4436
		[Token(Token = "0x40014C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal MutationData <eMut>__4;

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x40014C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal float <fTimer>__4;

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x40014C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal MutateType $locvar0;

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x40014C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal List<int> <listOrder>__5;

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x40014C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal double <dMaxDmg>__0;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x40014C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal int <nCnt>__6;

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x40014C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal PageBattle $this;

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x40014CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal object $current;

		// Token: 0x0400115C RID: 4444
		[Token(Token = "0x40014CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal bool $disposing;

		// Token: 0x0400115D RID: 4445
		[Token(Token = "0x40014CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal int $PC;
	}

	// Token: 0x02000320 RID: 800
	[Token(Token = "0x200035A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FEC0", Offset = "0x17FEC0")]
	private sealed class <MakeCoin>c__AnonStorey1A
	{
		// Token: 0x060013AF RID: 5039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x3035B8", Offset = "0x3035B8", VA = "0x63035B8")]
		public <MakeCoin>c__AnonStorey1A()
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x3035C0", Offset = "0x3035C0", VA = "0x63035C0")]
		internal bool <>m__0(BattleCoinElt e)
		{
			return default(bool);
		}

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x40014CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal BattleCoinElt elt;
	}

	// Token: 0x02000321 RID: 801
	[Token(Token = "0x200035B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FED0", Offset = "0x17FED0")]
	private sealed class <ShootFireLift>c__Iterator8 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013B1 RID: 5041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x304398", Offset = "0x304398", VA = "0x6304398")]
		[DebuggerHidden]
		public <ShootFireLift>c__Iterator8()
		{
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x3043A0", Offset = "0x3043A0", VA = "0x63043A0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001DB")]
		private object Current
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x304A9C", Offset = "0x304A9C", VA = "0x6304A9C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001DC")]
		private object Current
		{
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x304AA4", Offset = "0x304AA4", VA = "0x6304AA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x304AAC", Offset = "0x304AAC", VA = "0x6304AAC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x304AC0", Offset = "0x304AC0", VA = "0x6304AC0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400115F RID: 4447
		[Token(Token = "0x40014CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int <nHit>__0;

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x40014CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int <nCnt>__0;

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x40014D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Monster mon;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x40014D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float <fAddSize>__0;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x40014D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Vector2 vDiff;

		// Token: 0x04001164 RID: 4452
		[Token(Token = "0x40014D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Vector2 vStart;

		// Token: 0x04001165 RID: 4453
		[Token(Token = "0x40014D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Enemy <temp>__1;

		// Token: 0x04001166 RID: 4454
		[Token(Token = "0x40014D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal float fDmg;

		// Token: 0x04001167 RID: 4455
		[Token(Token = "0x40014D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal bool bCri;

		// Token: 0x04001168 RID: 4456
		[Token(Token = "0x40014D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal PageBattle $this;

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x40014D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal object $current;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x40014D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal bool $disposing;

		// Token: 0x0400116B RID: 4459
		[Token(Token = "0x40014DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal int $PC;
	}

	// Token: 0x02000322 RID: 802
	[Token(Token = "0x200035C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FEE0", Offset = "0x17FEE0")]
	private sealed class <CheckFireBall>c__Iterator9 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x2FFC48", Offset = "0x2FFC48", VA = "0x62FFC48")]
		[DebuggerHidden]
		public <CheckFireBall>c__Iterator9()
		{
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x2FFC50", Offset = "0x2FFC50", VA = "0x62FFC50", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001DD")]
		private object Current
		{
			[Token(Token = "0x6001612")]
			[Address(RVA = "0x300318", Offset = "0x300318", VA = "0x6300318", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001DE")]
		private object Current
		{
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x300320", Offset = "0x300320", VA = "0x6300320", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x300328", Offset = "0x300328", VA = "0x6300328", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x30032C", Offset = "0x30032C", VA = "0x630032C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x40014DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Vector2 vPos;

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x40014DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int nNum;

		// Token: 0x0400116E RID: 4462
		[Token(Token = "0x40014DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float fAddSize;

		// Token: 0x0400116F RID: 4463
		[Token(Token = "0x40014DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Bullet bul;

		// Token: 0x04001170 RID: 4464
		[Token(Token = "0x40014DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal PageBattle $this;

		// Token: 0x04001171 RID: 4465
		[Token(Token = "0x40014E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal object $current;

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x40014E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool $disposing;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x40014E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int $PC;
	}

	// Token: 0x02000323 RID: 803
	[Token(Token = "0x200035D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FEF0", Offset = "0x17FEF0")]
	private sealed class <CheckSnowBall>c__IteratorA : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013BD RID: 5053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x301BAC", Offset = "0x301BAC", VA = "0x6301BAC")]
		[DebuggerHidden]
		public <CheckSnowBall>c__IteratorA()
		{
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x301BB4", Offset = "0x301BB4", VA = "0x6301BB4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001DF")]
		private object Current
		{
			[Token(Token = "0x6001618")]
			[Address(RVA = "0x302130", Offset = "0x302130", VA = "0x6302130", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E0")]
		private object Current
		{
			[Token(Token = "0x6001619")]
			[Address(RVA = "0x302138", Offset = "0x302138", VA = "0x6302138", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x302140", Offset = "0x302140", VA = "0x6302140", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x302144", Offset = "0x302144", VA = "0x6302144", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x40014E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Vector2 vPos;

		// Token: 0x04001175 RID: 4469
		[Token(Token = "0x40014E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int nNum;

		// Token: 0x04001176 RID: 4470
		[Token(Token = "0x40014E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float fAddSize;

		// Token: 0x04001177 RID: 4471
		[Token(Token = "0x40014E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Bullet bul;

		// Token: 0x04001178 RID: 4472
		[Token(Token = "0x40014E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal PageBattle $this;

		// Token: 0x04001179 RID: 4473
		[Token(Token = "0x40014E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal object $current;

		// Token: 0x0400117A RID: 4474
		[Token(Token = "0x40014E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool $disposing;

		// Token: 0x0400117B RID: 4475
		[Token(Token = "0x40014EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int $PC;
	}

	// Token: 0x02000324 RID: 804
	[Token(Token = "0x200035E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF00", Offset = "0x17FF00")]
	private sealed class <CheckFireLance>c__IteratorB : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013C3 RID: 5059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x3003B4", Offset = "0x3003B4", VA = "0x63003B4")]
		[DebuggerHidden]
		public <CheckFireLance>c__IteratorB()
		{
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x3003BC", Offset = "0x3003BC", VA = "0x63003BC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E1")]
		private object Current
		{
			[Token(Token = "0x600161E")]
			[Address(RVA = "0x301AE4", Offset = "0x301AE4", VA = "0x6301AE4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E2")]
		private object Current
		{
			[Token(Token = "0x600161F")]
			[Address(RVA = "0x301AEC", Offset = "0x301AEC", VA = "0x6301AEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x301AF4", Offset = "0x301AF4", VA = "0x6301AF4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x301B08", Offset = "0x301B08", VA = "0x6301B08", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400117C RID: 4476
		[Token(Token = "0x40014EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int <nHit>__0;

		// Token: 0x0400117D RID: 4477
		[Token(Token = "0x40014EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Bullet bul;

		// Token: 0x0400117E RID: 4478
		[Token(Token = "0x40014ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Vector3 <vAngle>__0;

		// Token: 0x0400117F RID: 4479
		[Token(Token = "0x40014EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float <fDmgPlus>__0;

		// Token: 0x04001180 RID: 4480
		[Token(Token = "0x40014EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Vector2 <vDir>__0;

		// Token: 0x04001181 RID: 4481
		[Token(Token = "0x40014F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Vector2 <vCalcDir>__0;

		// Token: 0x04001182 RID: 4482
		[Token(Token = "0x40014F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal int nNum;

		// Token: 0x04001183 RID: 4483
		[Token(Token = "0x40014F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal bool <bReverse>__0;

		// Token: 0x04001184 RID: 4484
		[Token(Token = "0x40014F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal float fAddSize;

		// Token: 0x04001185 RID: 4485
		[Token(Token = "0x40014F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal Vector2 vPos;

		// Token: 0x04001186 RID: 4486
		[Token(Token = "0x40014F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal Enemy <temp>__1;

		// Token: 0x04001187 RID: 4487
		[Token(Token = "0x40014F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Enemy em;

		// Token: 0x04001188 RID: 4488
		[Token(Token = "0x40014F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal PageBattle $this;

		// Token: 0x04001189 RID: 4489
		[Token(Token = "0x40014F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal object $current;

		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x40014F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal bool $disposing;

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x40014FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int $PC;
	}

	// Token: 0x02000325 RID: 805
	[Token(Token = "0x200035F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF10", Offset = "0x17FF10")]
	private sealed class <StartChainLightning>c__IteratorC : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013C9 RID: 5065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x305E88", Offset = "0x305E88", VA = "0x6305E88")]
		[DebuggerHidden]
		public <StartChainLightning>c__IteratorC()
		{
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x305E90", Offset = "0x305E90", VA = "0x6305E90", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E3")]
		private object Current
		{
			[Token(Token = "0x6001624")]
			[Address(RVA = "0x306640", Offset = "0x306640", VA = "0x6306640", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E4")]
		private object Current
		{
			[Token(Token = "0x6001625")]
			[Address(RVA = "0x306648", Offset = "0x306648", VA = "0x6306648", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x306650", Offset = "0x306650", VA = "0x6306650", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x306664", Offset = "0x306664", VA = "0x6306664", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x40014FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal List<Enemy> <list>__0;

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x40014FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Enemy em;

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x40014FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool <bDead>__0;

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x40014FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int <i>__1;

		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x40014FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int nTimes;

		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal Monster mon;

		// Token: 0x04001192 RID: 4498
		[Token(Token = "0x4001501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float fPlus;

		// Token: 0x04001193 RID: 4499
		[Token(Token = "0x4001502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool bThunder;

		// Token: 0x04001194 RID: 4500
		[Token(Token = "0x4001503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal BattleItemData bData;

		// Token: 0x04001195 RID: 4501
		[Token(Token = "0x4001504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal bool bCri;

		// Token: 0x04001196 RID: 4502
		[Token(Token = "0x4001505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		internal bool bBig;

		// Token: 0x04001197 RID: 4503
		[Token(Token = "0x4001506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Vector2 vLastPos;

		// Token: 0x04001198 RID: 4504
		[Token(Token = "0x4001507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal PageBattle $this;

		// Token: 0x04001199 RID: 4505
		[Token(Token = "0x4001508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal object $current;

		// Token: 0x0400119A RID: 4506
		[Token(Token = "0x4001509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool $disposing;

		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400150A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal int $PC;
	}

	// Token: 0x02000326 RID: 806
	[Token(Token = "0x2000360")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF20", Offset = "0x17FF20")]
	private sealed class <StartUnlimitedSword>c__IteratorD : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013CF RID: 5071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x309F6C", Offset = "0x309F6C", VA = "0x6309F6C")]
		[DebuggerHidden]
		public <StartUnlimitedSword>c__IteratorD()
		{
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x309F74", Offset = "0x309F74", VA = "0x6309F74", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E5")]
		private object Current
		{
			[Token(Token = "0x600162A")]
			[Address(RVA = "0x30A500", Offset = "0x30A500", VA = "0x630A500", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E6")]
		private object Current
		{
			[Token(Token = "0x600162B")]
			[Address(RVA = "0x30A508", Offset = "0x30A508", VA = "0x630A508", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x30A510", Offset = "0x30A510", VA = "0x630A510", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x30A524", Offset = "0x30A524", VA = "0x630A524", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400150B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal List<Enemy> <list>__0;

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400150C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Vector3 <vTarget>__0;

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400150D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int <x>__1;

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400150E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int nTimes;

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x400150F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Enemy <em>__2;

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x4001510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal Monster mon;

		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x4001511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal BattleItemData bData;

		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x4001512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal float fDmg;

		// Token: 0x040011A4 RID: 4516
		[Token(Token = "0x4001513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal PageBattle $this;

		// Token: 0x040011A5 RID: 4517
		[Token(Token = "0x4001514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal object $current;

		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x4001515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal bool $disposing;

		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x4001516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal int $PC;
	}

	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000361")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF30", Offset = "0x17FF30")]
	private sealed class <StartSummonSword>c__IteratorE : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x30871C", Offset = "0x30871C", VA = "0x630871C")]
		[DebuggerHidden]
		public <StartSummonSword>c__IteratorE()
		{
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x308724", Offset = "0x308724", VA = "0x6308724", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E7")]
		private object Current
		{
			[Token(Token = "0x6001630")]
			[Address(RVA = "0x308EDC", Offset = "0x308EDC", VA = "0x6308EDC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E8")]
		private object Current
		{
			[Token(Token = "0x6001631")]
			[Address(RVA = "0x308EE4", Offset = "0x308EE4", VA = "0x6308EE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x308EEC", Offset = "0x308EEC", VA = "0x6308EEC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x308F00", Offset = "0x308F00", VA = "0x6308F00", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x4001517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Vector2 <vDiff>__0;

		// Token: 0x040011A9 RID: 4521
		[Token(Token = "0x4001518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Vector3 <vSummon>__0;

		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x4001519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int <nSummonPos>__0;

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x400151A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int <nRicochet>__0;

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x400151B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int nShot;

		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x400151C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal float <fGap>__0;

		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x400151D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal bool <bHuge>__0;

		// Token: 0x040011AF RID: 4527
		[Token(Token = "0x400151E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Monster mon;

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x400151F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal bool <bSpinning>__0;

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x4001520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal float fDmg;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x4001521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal int <i>__1;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x4001522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool bLeft;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x4001523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		internal bool bThree;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x4001524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal Vector3 vTgtPos;

		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x4001525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal BattleItemData bData;

		// Token: 0x040011B7 RID: 4535
		[Token(Token = "0x4001526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal bool bCri;

		// Token: 0x040011B8 RID: 4536
		[Token(Token = "0x4001527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		internal bool bGap;

		// Token: 0x040011B9 RID: 4537
		[Token(Token = "0x4001528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal PageBattle $this;

		// Token: 0x040011BA RID: 4538
		[Token(Token = "0x4001529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal object $current;

		// Token: 0x040011BB RID: 4539
		[Token(Token = "0x400152A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal bool $disposing;

		// Token: 0x040011BC RID: 4540
		[Token(Token = "0x400152B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		internal int $PC;
	}

	// Token: 0x02000328 RID: 808
	[Token(Token = "0x2000362")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF40", Offset = "0x17FF40")]
	private sealed class <HitArea>c__IteratorF : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013DB RID: 5083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x302990", Offset = "0x302990", VA = "0x6302990")]
		[DebuggerHidden]
		public <HitArea>c__IteratorF()
		{
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x302998", Offset = "0x302998", VA = "0x6302998", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E9")]
		private object Current
		{
			[Token(Token = "0x6001636")]
			[Address(RVA = "0x30350C", Offset = "0x30350C", VA = "0x630350C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EA")]
		private object Current
		{
			[Token(Token = "0x6001637")]
			[Address(RVA = "0x303514", Offset = "0x303514", VA = "0x6303514", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x30351C", Offset = "0x30351C", VA = "0x630351C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x303530", Offset = "0x303530", VA = "0x6303530", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040011BD RID: 4541
		[Token(Token = "0x400152C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float fTimeGap;

		// Token: 0x040011BE RID: 4542
		[Token(Token = "0x400152D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float fAddSize;

		// Token: 0x040011BF RID: 4543
		[Token(Token = "0x400152E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float fHitSize;

		// Token: 0x040011C0 RID: 4544
		[Token(Token = "0x400152F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal Vector3 <vSize>__0;

		// Token: 0x040011C1 RID: 4545
		[Token(Token = "0x4001530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool bBig;

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x4001531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		internal bool bCri;

		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x4001532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		internal bool bSlash;

		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x4001533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal string strFX;

		// Token: 0x040011C5 RID: 4549
		[Token(Token = "0x4001534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Vector2 v2Pos;

		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x4001535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal int <nHit>__0;

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x4001536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal bool <bDead>__0;

		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x4001537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Enemy <temp>__1;

		// Token: 0x040011C9 RID: 4553
		[Token(Token = "0x4001538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal Monster mon;

		// Token: 0x040011CA RID: 4554
		[Token(Token = "0x4001539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal long nEquip;

		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x400153A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal float fPlus;

		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x400153B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal PageBattle $this;

		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x400153C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal object $current;

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x400153D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal bool $disposing;

		// Token: 0x040011CF RID: 4559
		[Token(Token = "0x400153E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int $PC;
	}

	// Token: 0x02000329 RID: 809
	[Token(Token = "0x2000363")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF50", Offset = "0x17FF50")]
	private sealed class <OnSoulExplosion>c__Iterator10 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013E1 RID: 5089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x303650", Offset = "0x303650", VA = "0x6303650")]
		[DebuggerHidden]
		public <OnSoulExplosion>c__Iterator10()
		{
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x303658", Offset = "0x303658", VA = "0x6303658", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EB")]
		private object Current
		{
			[Token(Token = "0x600163C")]
			[Address(RVA = "0x3042EC", Offset = "0x3042EC", VA = "0x63042EC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EC")]
		private object Current
		{
			[Token(Token = "0x600163D")]
			[Address(RVA = "0x3042F4", Offset = "0x3042F4", VA = "0x63042F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x3042FC", Offset = "0x3042FC", VA = "0x63042FC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x304310", Offset = "0x304310", VA = "0x6304310", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x400153F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Vector3 vPos;

		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x4001540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal Vector2 <vExpPos>__0;

		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x4001541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal Enemy <temp>__0;

		// Token: 0x040011D3 RID: 4563
		[Token(Token = "0x4001542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float fDmg;

		// Token: 0x040011D4 RID: 4564
		[Token(Token = "0x4001543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int <x>__1;

		// Token: 0x040011D5 RID: 4565
		[Token(Token = "0x4001544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal float fSize;

		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x4001545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int <nHit>__2;

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x4001546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal PageBattle $this;

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x4001547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal object $current;

		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x4001548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal bool $disposing;

		// Token: 0x040011DA RID: 4570
		[Token(Token = "0x4001549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal int $PC;
	}

	// Token: 0x0200032A RID: 810
	[Token(Token = "0x2000364")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF60", Offset = "0x17FF60")]
	private sealed class <ShowFireStorm>c__Iterator11 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013E7 RID: 5095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x3053DC", Offset = "0x3053DC", VA = "0x63053DC")]
		[DebuggerHidden]
		public <ShowFireStorm>c__Iterator11()
		{
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x3053E4", Offset = "0x3053E4", VA = "0x63053E4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001ED")]
		private object Current
		{
			[Token(Token = "0x6001642")]
			[Address(RVA = "0x3055C8", Offset = "0x3055C8", VA = "0x63055C8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EE")]
		private object Current
		{
			[Token(Token = "0x6001643")]
			[Address(RVA = "0x3055D0", Offset = "0x3055D0", VA = "0x63055D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x3055D8", Offset = "0x3055D8", VA = "0x63055D8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x3055EC", Offset = "0x3055EC", VA = "0x63055EC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040011DB RID: 4571
		[Token(Token = "0x400154A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Vector3 <vPos>__0;

		// Token: 0x040011DC RID: 4572
		[Token(Token = "0x400154B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int <i>__0;

		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x400154C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string strFX;

		// Token: 0x040011DE RID: 4574
		[Token(Token = "0x400154D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal PageBattle $this;

		// Token: 0x040011DF RID: 4575
		[Token(Token = "0x400154E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal object $current;

		// Token: 0x040011E0 RID: 4576
		[Token(Token = "0x400154F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool $disposing;

		// Token: 0x040011E1 RID: 4577
		[Token(Token = "0x4001550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int $PC;
	}

	// Token: 0x0200032B RID: 811
	[Token(Token = "0x2000365")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF70", Offset = "0x17FF70")]
	private sealed class <ShowMoonCrystal>c__Iterator12 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013ED RID: 5101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x305674", Offset = "0x305674", VA = "0x6305674")]
		[DebuggerHidden]
		public <ShowMoonCrystal>c__Iterator12()
		{
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x30567C", Offset = "0x30567C", VA = "0x630567C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EF")]
		private object Current
		{
			[Token(Token = "0x6001648")]
			[Address(RVA = "0x305868", Offset = "0x305868", VA = "0x6305868", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F0")]
		private object Current
		{
			[Token(Token = "0x6001649")]
			[Address(RVA = "0x305870", Offset = "0x305870", VA = "0x6305870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x305878", Offset = "0x305878", VA = "0x6305878", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x30588C", Offset = "0x30588C", VA = "0x630588C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040011E2 RID: 4578
		[Token(Token = "0x4001551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Vector3 <vPos>__0;

		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x4001552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int <i>__0;

		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x4001553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal PageBattle $this;

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x4001554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal object $current;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x4001555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x4001556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int $PC;
	}

	// Token: 0x0200032C RID: 812
	[Token(Token = "0x2000366")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF80", Offset = "0x17FF80")]
	private sealed class <StartPoisonMyst>c__Iterator13 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013F3 RID: 5107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x3081F0", Offset = "0x3081F0", VA = "0x63081F0")]
		[DebuggerHidden]
		public <StartPoisonMyst>c__Iterator13()
		{
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x3081F8", Offset = "0x3081F8", VA = "0x63081F8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F1")]
		private object Current
		{
			[Token(Token = "0x600164E")]
			[Address(RVA = "0x308670", Offset = "0x308670", VA = "0x6308670", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F2")]
		private object Current
		{
			[Token(Token = "0x600164F")]
			[Address(RVA = "0x308678", Offset = "0x308678", VA = "0x6308678", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x308680", Offset = "0x308680", VA = "0x6308680", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x308694", Offset = "0x308694", VA = "0x6308694", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x4001557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float <fTime>__0;

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x4001558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float <fGap>__0;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x4001559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float fDmg;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x400155A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal Monster mon;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x400155B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal float <fHeal>__0;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x400155C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float fDur;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x400155D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal PageBattle $this;

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x400155E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal object $current;

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x400155F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal bool $disposing;

		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x4001560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int $PC;
	}

	// Token: 0x0200032D RID: 813
	[Token(Token = "0x2000367")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FF90", Offset = "0x17FF90")]
	private sealed class <ShowPoisonMyst>c__Iterator14 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013F9 RID: 5113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x305914", Offset = "0x305914", VA = "0x6305914")]
		[DebuggerHidden]
		public <ShowPoisonMyst>c__Iterator14()
		{
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x30591C", Offset = "0x30591C", VA = "0x630591C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F3")]
		private object Current
		{
			[Token(Token = "0x6001654")]
			[Address(RVA = "0x305AC8", Offset = "0x305AC8", VA = "0x6305AC8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F4")]
		private object Current
		{
			[Token(Token = "0x6001655")]
			[Address(RVA = "0x305AD0", Offset = "0x305AD0", VA = "0x6305AD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x305AD8", Offset = "0x305AD8", VA = "0x6305AD8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x305AEC", Offset = "0x305AEC", VA = "0x6305AEC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x4001561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Vector3 <vPos>__0;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x4001562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int <i>__0;

		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x4001563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x040011F5 RID: 4597
		[Token(Token = "0x4001564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal bool $disposing;

		// Token: 0x040011F6 RID: 4598
		[Token(Token = "0x4001565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int $PC;
	}

	// Token: 0x0200032E RID: 814
	[Token(Token = "0x2000368")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FFA0", Offset = "0x17FFA0")]
	private sealed class <ThrowBoneParty>c__Iterator15 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x30AD0C", Offset = "0x30AD0C", VA = "0x630AD0C")]
		[DebuggerHidden]
		public <ThrowBoneParty>c__Iterator15()
		{
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x30AD14", Offset = "0x30AD14", VA = "0x630AD14", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F5")]
		private object Current
		{
			[Token(Token = "0x600165A")]
			[Address(RVA = "0x30B014", Offset = "0x30B014", VA = "0x630B014", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F6")]
		private object Current
		{
			[Token(Token = "0x600165B")]
			[Address(RVA = "0x30B01C", Offset = "0x30B01C", VA = "0x630B01C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x30B024", Offset = "0x30B024", VA = "0x630B024", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165D")]
		[Address(RVA = "0x30B038", Offset = "0x30B038", VA = "0x630B038", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x4001566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal ItemData <data>__0;

		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x4001567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Vector3 <vTarget>__0;

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x4001568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Vector3 <vShoot>__0;

		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x4001569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int <nCnt>__0;

		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x400156A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int nNum;

		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x400156B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal Monster mon;

		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x400156C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal float fDmg;

		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x400156D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal PageBattle $this;

		// Token: 0x040011FF RID: 4607
		[Token(Token = "0x400156E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal object $current;

		// Token: 0x04001200 RID: 4608
		[Token(Token = "0x400156F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal bool $disposing;

		// Token: 0x04001201 RID: 4609
		[Token(Token = "0x4001570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal int $PC;
	}

	// Token: 0x0200032F RID: 815
	[Token(Token = "0x2000369")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FFB0", Offset = "0x17FFB0")]
	private sealed class <ShowBalanceGuage>c__Iterator16 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001405 RID: 5125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x304EEC", Offset = "0x304EEC", VA = "0x6304EEC")]
		[DebuggerHidden]
		public <ShowBalanceGuage>c__Iterator16()
		{
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x304EF4", Offset = "0x304EF4", VA = "0x6304EF4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F7")]
		private object Current
		{
			[Token(Token = "0x6001660")]
			[Address(RVA = "0x305330", Offset = "0x305330", VA = "0x6305330", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F8")]
		private object Current
		{
			[Token(Token = "0x6001661")]
			[Address(RVA = "0x305338", Offset = "0x305338", VA = "0x6305338", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x305340", Offset = "0x305340", VA = "0x6305340", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x305354", Offset = "0x305354", VA = "0x6305354", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001202 RID: 4610
		[Token(Token = "0x4001571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float <fRate>__0;

		// Token: 0x04001203 RID: 4611
		[Token(Token = "0x4001572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal PageBattle $this;

		// Token: 0x04001204 RID: 4612
		[Token(Token = "0x4001573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object $current;

		// Token: 0x04001205 RID: 4613
		[Token(Token = "0x4001574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool $disposing;

		// Token: 0x04001206 RID: 4614
		[Token(Token = "0x4001575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int $PC;
	}

	// Token: 0x02000330 RID: 816
	[Token(Token = "0x200036A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FFC0", Offset = "0x17FFC0")]
	private sealed class <ShowAlarm>c__Iterator17 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x304B48", Offset = "0x304B48", VA = "0x6304B48")]
		[DebuggerHidden]
		public <ShowAlarm>c__Iterator17()
		{
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x304B50", Offset = "0x304B50", VA = "0x6304B50", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F9")]
		private object Current
		{
			[Token(Token = "0x6001666")]
			[Address(RVA = "0x304E40", Offset = "0x304E40", VA = "0x6304E40", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FA")]
		private object Current
		{
			[Token(Token = "0x6001667")]
			[Address(RVA = "0x304E48", Offset = "0x304E48", VA = "0x6304E48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x304E50", Offset = "0x304E50", VA = "0x6304E50", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x304E64", Offset = "0x304E64", VA = "0x6304E64", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001207 RID: 4615
		[Token(Token = "0x4001576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float <fTime>__0;

		// Token: 0x04001208 RID: 4616
		[Token(Token = "0x4001577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float <fRate>__0;

		// Token: 0x04001209 RID: 4617
		[Token(Token = "0x4001578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal CanvasGroup cg;

		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x4001579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float fFadeIn;

		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400157A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal float fShow;

		// Token: 0x0400120C RID: 4620
		[Token(Token = "0x400157B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float fFadeOut;

		// Token: 0x0400120D RID: 4621
		[Token(Token = "0x400157C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal object $current;

		// Token: 0x0400120E RID: 4622
		[Token(Token = "0x400157D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool $disposing;

		// Token: 0x0400120F RID: 4623
		[Token(Token = "0x400157E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int $PC;
	}

	// Token: 0x02000331 RID: 817
	[Token(Token = "0x200036B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FFD0", Offset = "0x17FFD0")]
	private sealed class <HighSlash>c__Iterator18 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001411 RID: 5137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600166A")]
		[Address(RVA = "0x3022AC", Offset = "0x3022AC", VA = "0x63022AC")]
		[DebuggerHidden]
		public <HighSlash>c__Iterator18()
		{
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00008460 File Offset: 0x00006660
		[Token(Token = "0x600166B")]
		[Address(RVA = "0x3022B4", Offset = "0x3022B4", VA = "0x63022B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FB")]
		private object Current
		{
			[Token(Token = "0x600166C")]
			[Address(RVA = "0x3028E4", Offset = "0x3028E4", VA = "0x63028E4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FC")]
		private object Current
		{
			[Token(Token = "0x600166D")]
			[Address(RVA = "0x3028EC", Offset = "0x3028EC", VA = "0x63028EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x3028F4", Offset = "0x3028F4", VA = "0x63028F4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x302908", Offset = "0x302908", VA = "0x6302908", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x400157F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int <nCnt>__0;

		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int nPos;

		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Monster <mon>__0;

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal Enemy <em>__0;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal List<Enemy> <list>__0;

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int nMax;

		// Token: 0x04001216 RID: 4630
		[Token(Token = "0x4001585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool bAll;

		// Token: 0x04001217 RID: 4631
		[Token(Token = "0x4001586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float fDmg;

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal PageBattle $this;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal object $current;

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x4001589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal bool $disposing;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400158A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal int $PC;
	}

	// Token: 0x02000332 RID: 818
	[Token(Token = "0x200036C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FFE0", Offset = "0x17FFE0")]
	private sealed class <StartFireExplosion>c__Iterator19 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x3069EC", Offset = "0x3069EC", VA = "0x63069EC")]
		[DebuggerHidden]
		public <StartFireExplosion>c__Iterator19()
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00008478 File Offset: 0x00006678
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x3069F4", Offset = "0x3069F4", VA = "0x63069F4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FD")]
		private object Current
		{
			[Token(Token = "0x6001672")]
			[Address(RVA = "0x307178", Offset = "0x307178", VA = "0x6307178", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FE")]
		private object Current
		{
			[Token(Token = "0x6001673")]
			[Address(RVA = "0x307180", Offset = "0x307180", VA = "0x6307180", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x307188", Offset = "0x307188", VA = "0x6307188", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x30719C", Offset = "0x30719C", VA = "0x630719C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400158B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int <nCnt>__0;

		// Token: 0x0400121D RID: 4637
		[Token(Token = "0x400158C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float fPlus;

		// Token: 0x0400121E RID: 4638
		[Token(Token = "0x400158D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Enemy <em>__0;

		// Token: 0x0400121F RID: 4639
		[Token(Token = "0x400158E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal Enemy <temp>__0;

		// Token: 0x04001220 RID: 4640
		[Token(Token = "0x400158F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal List<Enemy> <list>__0;

		// Token: 0x04001221 RID: 4641
		[Token(Token = "0x4001590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int nMax;

		// Token: 0x04001222 RID: 4642
		[Token(Token = "0x4001591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Monster mon;

		// Token: 0x04001223 RID: 4643
		[Token(Token = "0x4001592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal PageBattle $this;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal object $current;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal bool $disposing;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal int $PC;
	}

	// Token: 0x02000333 RID: 819
	[Token(Token = "0x200036D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FFF0", Offset = "0x17FFF0")]
	private sealed class <GetRandomEnemy>c__AnonStorey1B
	{
		// Token: 0x0600141D RID: 5149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x3021CC", Offset = "0x3021CC", VA = "0x63021CC")]
		public <GetRandomEnemy>c__AnonStorey1B()
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x3021D4", Offset = "0x3021D4", VA = "0x63021D4")]
		internal bool <>m__0(Enemy e)
		{
			return default(bool);
		}

		// Token: 0x04001227 RID: 4647
		[Token(Token = "0x4001596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int i;

		// Token: 0x04001228 RID: 4648
		[Token(Token = "0x4001597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal PageBattle $this;
	}

	// Token: 0x02000334 RID: 820
	[Token(Token = "0x200036E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180000", Offset = "0x180000")]
	private sealed class <CheckMutation>c__AnonStorey1C
	{
		// Token: 0x0600141F RID: 5151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001678")]
		[Address(RVA = "0x301B90", Offset = "0x301B90", VA = "0x6301B90")]
		public <CheckMutation>c__AnonStorey1C()
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x6001679")]
		[Address(RVA = "0x301B98", Offset = "0x301B98", VA = "0x6301B98")]
		internal bool <>m__0(MutateType e)
		{
			return default(bool);
		}

		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4001598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal MutateType eType;
	}
}
