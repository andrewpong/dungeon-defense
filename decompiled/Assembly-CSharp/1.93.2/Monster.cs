using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000313 RID: 787
[Token(Token = "0x200027E")]
[Attribute(Name = "RequireComponent", RVA = "0x17F548", Offset = "0x17F548")]
public class Monster : MonoBehaviour
{
	// Token: 0x060012B5 RID: 4789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x2A9280", Offset = "0x2A9280", VA = "0x62A9280")]
	public Monster()
	{
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000161")]
	public PlayerMonsterData pData
	{
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x2A967C", Offset = "0x2A967C", VA = "0x62A967C")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00007C80 File Offset: 0x00005E80
	[Token(Token = "0x17000162")]
	public bool bRage
	{
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x2A9704", Offset = "0x2A9704", VA = "0x62A9704")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00007C98 File Offset: 0x00005E98
	// (set) Token: 0x060012B9 RID: 4793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000163")]
	public float fRage
	{
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x2A971C", Offset = "0x2A971C", VA = "0x62A971C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x2A9724", Offset = "0x2A9724", VA = "0x62A9724")]
		set
		{
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x060012BA RID: 4794 RVA: 0x00007CB0 File Offset: 0x00005EB0
	[Token(Token = "0x17000164")]
	public float fFixAtkBonus
	{
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x2A9C20", Offset = "0x2A9C20", VA = "0x62A9C20")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x060012BB RID: 4795 RVA: 0x00007CC8 File Offset: 0x00005EC8
	[Token(Token = "0x17000165")]
	public float fFixAspBonus
	{
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x2A9D3C", Offset = "0x2A9D3C", VA = "0x62A9D3C")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x060012BC RID: 4796 RVA: 0x00007CE0 File Offset: 0x00005EE0
	[Token(Token = "0x17000166")]
	public float fFixReloadBonus
	{
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x2A9E40", Offset = "0x2A9E40", VA = "0x62A9E40")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x060012BD RID: 4797 RVA: 0x00007CF8 File Offset: 0x00005EF8
	[Token(Token = "0x17000167")]
	public bool bInstantReload
	{
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x2A9F2C", Offset = "0x2A9F2C", VA = "0x62A9F2C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x060012BE RID: 4798 RVA: 0x00007D10 File Offset: 0x00005F10
	[Token(Token = "0x17000168")]
	public float fCriRate
	{
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x2A9F44", Offset = "0x2A9F44", VA = "0x62A9F44")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x060012BF RID: 4799 RVA: 0x00007D28 File Offset: 0x00005F28
	[Token(Token = "0x17000169")]
	public float fFixCriDmg
	{
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x2AA2B4", Offset = "0x2AA2B4", VA = "0x62AA2B4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001134")]
	[Address(RVA = "0x2AA388", Offset = "0x2AA388", VA = "0x62AA388")]
	private void Awake()
	{
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001135")]
	[Address(RVA = "0x2A9744", Offset = "0x2A9744", VA = "0x62A9744")]
	private void OnRageStart()
	{
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001136")]
	[Address(RVA = "0x2AA7BC", Offset = "0x2AA7BC", VA = "0x62AA7BC")]
	private void OnRageEnd()
	{
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001137")]
	[Address(RVA = "0x2AA8D0", Offset = "0x2AA8D0", VA = "0x62AA8D0")]
	public void SetCharacter(int _nPos, bool _bNPC)
	{
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001138")]
	[Address(RVA = "0x2AD6F0", Offset = "0x2AD6F0", VA = "0x62AD6F0")]
	public void Update()
	{
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00007D40 File Offset: 0x00005F40
	[Token(Token = "0x1700016A")]
	public bool isLaser
	{
		[Token(Token = "0x6001139")]
		[Address(RVA = "0x2B4C64", Offset = "0x2B4C64", VA = "0x62B4C64")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00007D58 File Offset: 0x00005F58
	[Token(Token = "0x1700016B")]
	public bool canShoot
	{
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x2B4B94", Offset = "0x2B4B94", VA = "0x62B4B94")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00007D70 File Offset: 0x00005F70
	[Token(Token = "0x1700016C")]
	public int nAtkTime
	{
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x2AE114", Offset = "0x2AE114", VA = "0x62AE114")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x2ACD4C", Offset = "0x2ACD4C", VA = "0x62ACD4C")]
	public void Reload(bool _bReload, float fTime = 0f)
	{
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x2B4D24", Offset = "0x2B4D24", VA = "0x62B4D24")]
	public void Reload()
	{
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600113E")]
	[Address(RVA = "0x2B4C78", Offset = "0x2B4C78", VA = "0x62B4C78")]
	[DebuggerHidden]
	private IEnumerator Reload(float fTime)
	{
		return null;
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113F")]
	[Address(RVA = "0x2B4E80", Offset = "0x2B4E80", VA = "0x62B4E80")]
	public void SetStun(float fTime)
	{
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x060012CC RID: 4812 RVA: 0x00007D88 File Offset: 0x00005F88
	[Token(Token = "0x1700016D")]
	public bool isStun
	{
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x2AE0F8", Offset = "0x2AE0F8", VA = "0x62AE0F8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001141")]
	[Address(RVA = "0x2B4F6C", Offset = "0x2B4F6C", VA = "0x62B4F6C")]
	[DebuggerHidden]
	private IEnumerator StartStun()
	{
		return null;
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001142")]
	[Address(RVA = "0x2AE03C", Offset = "0x2AE03C", VA = "0x62AE03C")]
	private void OnReloadComplete()
	{
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x060012CF RID: 4815 RVA: 0x00007DA0 File Offset: 0x00005FA0
	[Token(Token = "0x1700016E")]
	public bool isReloading
	{
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x2AE034", Offset = "0x2AE034", VA = "0x62AE034")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001144")]
	[Address(RVA = "0x2B5114", Offset = "0x2B5114", VA = "0x62B5114")]
	public void Animate(string strName)
	{
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001145")]
	[Address(RVA = "0x2AD5F8", Offset = "0x2AD5F8", VA = "0x62AD5F8")]
	public void SetSpeed(long uid)
	{
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001146")]
	[Address(RVA = "0x2B5148", Offset = "0x2B5148", VA = "0x62B5148")]
	public void Shoot()
	{
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001147")]
	[Address(RVA = "0x2B514C", Offset = "0x2B514C", VA = "0x62B514C")]
	public void OnWarcryBuff(float fTime, float fFactor)
	{
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001148")]
	[Address(RVA = "0x2B51BC", Offset = "0x2B51BC", VA = "0x62B51BC")]
	public void OnDarkBuff(float fTime, float fFactor)
	{
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001149")]
	[Address(RVA = "0x2B5208", Offset = "0x2B5208", VA = "0x62B5208")]
	public void OnSwiftBuff(float fTime, float fFactor)
	{
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114A")]
	[Address(RVA = "0x2B5278", Offset = "0x2B5278", VA = "0x62B5278")]
	public void OnReloadBuff(float fTime)
	{
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114B")]
	[Address(RVA = "0x2B52E0", Offset = "0x2B52E0", VA = "0x62B52E0")]
	public void OnCastComplete()
	{
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114C")]
	[Address(RVA = "0x2B52E4", Offset = "0x2B52E4", VA = "0x62B52E4")]
	public void OnCastEffect()
	{
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114D")]
	[Address(RVA = "0x2B52E8", Offset = "0x2B52E8", VA = "0x62B52E8")]
	public void OnCrit()
	{
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114E")]
	[Address(RVA = "0x2B544C", Offset = "0x2B544C", VA = "0x62B544C")]
	public void OnKill()
	{
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114F")]
	[Address(RVA = "0x2B5408", Offset = "0x2B5408", VA = "0x62B5408")]
	public void AddRage(float fFac)
	{
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001150")]
	[Address(RVA = "0x2B55E0", Offset = "0x2B55E0", VA = "0x62B55E0")]
	public void OnShootEnd(int nShot, int nAtkTime)
	{
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001151")]
	[Address(RVA = "0x2B5D6C", Offset = "0x2B5D6C", VA = "0x62B5D6C")]
	public void OnAssasinate()
	{
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001152")]
	[Address(RVA = "0x2B5E28", Offset = "0x2B5E28", VA = "0x62B5E28")]
	public void OnRicochet()
	{
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x060012DF RID: 4831 RVA: 0x00007DB8 File Offset: 0x00005FB8
	[Token(Token = "0x1700016F")]
	public float fAssinatePower
	{
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x2B5EE4", Offset = "0x2B5EE4", VA = "0x62B5EE4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x060012E0 RID: 4832 RVA: 0x00007DD0 File Offset: 0x00005FD0
	[Token(Token = "0x17000170")]
	public float fRicochetPower
	{
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x2B60A4", Offset = "0x2B60A4", VA = "0x62B60A4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00007DE8 File Offset: 0x00005FE8
	[Token(Token = "0x17000171")]
	public float fCriPower
	{
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x2B6264", Offset = "0x2B6264", VA = "0x62B6264")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001156")]
	[Address(RVA = "0x2AD2D0", Offset = "0x2AD2D0", VA = "0x62AD2D0")]
	public void SetNpcAtkBonus(bool _bNpc)
	{
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00007E00 File Offset: 0x00006000
	[Token(Token = "0x17000172")]
	public bool isHugeWeapon
	{
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x2B65BC", Offset = "0x2B65BC", VA = "0x62B65BC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00007E18 File Offset: 0x00006018
	[Token(Token = "0x17000173")]
	public bool isFireBall
	{
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x2B679C", Offset = "0x2B679C", VA = "0x62B679C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00007E30 File Offset: 0x00006030
	[Token(Token = "0x17000174")]
	public bool isFireLance
	{
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x2B697C", Offset = "0x2B697C", VA = "0x62B697C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00007E48 File Offset: 0x00006048
	[Token(Token = "0x17000175")]
	public bool isSoulBomb
	{
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x2B6B5C", Offset = "0x2B6B5C", VA = "0x62B6B5C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00007E60 File Offset: 0x00006060
	[Token(Token = "0x17000176")]
	public bool isMultiShot
	{
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x2B6CAC", Offset = "0x2B6CAC", VA = "0x62B6CAC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00007E78 File Offset: 0x00006078
	[Token(Token = "0x17000177")]
	public bool isTripleSword
	{
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x2B6DFC", Offset = "0x2B6DFC", VA = "0x62B6DFC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00007E90 File Offset: 0x00006090
	[Token(Token = "0x17000178")]
	public bool isStrongKick
	{
		[Token(Token = "0x600115D")]
		[Address(RVA = "0x2B6F4C", Offset = "0x2B6F4C", VA = "0x62B6F4C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x060012EA RID: 4842 RVA: 0x00007EA8 File Offset: 0x000060A8
	[Token(Token = "0x17000179")]
	public bool isBigSlash
	{
		[Token(Token = "0x600115E")]
		[Address(RVA = "0x2B709C", Offset = "0x2B709C", VA = "0x62B709C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x060012EB RID: 4843 RVA: 0x00007EC0 File Offset: 0x000060C0
	[Token(Token = "0x1700017A")]
	public bool isSubLaser
	{
		[Token(Token = "0x600115F")]
		[Address(RVA = "0x2B71EC", Offset = "0x2B71EC", VA = "0x62B71EC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x060012EC RID: 4844 RVA: 0x00007ED8 File Offset: 0x000060D8
	[Token(Token = "0x1700017B")]
	public bool isFrost
	{
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x2B733C", Offset = "0x2B733C", VA = "0x62B733C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x060012ED RID: 4845 RVA: 0x00007EF0 File Offset: 0x000060F0
	[Token(Token = "0x1700017C")]
	public bool isChainLightning
	{
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x2B748C", Offset = "0x2B748C", VA = "0x62B748C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x060012EE RID: 4846 RVA: 0x00007F08 File Offset: 0x00006108
	[Token(Token = "0x1700017D")]
	public bool isRicochet
	{
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x2B75DC", Offset = "0x2B75DC", VA = "0x62B75DC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x060012EF RID: 4847 RVA: 0x00007F20 File Offset: 0x00006120
	[Token(Token = "0x1700017E")]
	public bool isExplosion
	{
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x2B772C", Offset = "0x2B772C", VA = "0x62B772C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00007F38 File Offset: 0x00006138
	[Token(Token = "0x1700017F")]
	public bool isRandomDmg
	{
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x2B787C", Offset = "0x2B787C", VA = "0x62B787C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0400101F RID: 4127
	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer reload;

	// Token: 0x04001020 RID: 4128
	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer reloadBack;

	// Token: 0x04001021 RID: 4129
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer sprite;

	// Token: 0x04001022 RID: 4130
	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goAtkBuff;

	// Token: 0x04001023 RID: 4131
	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goAspBuff;

	// Token: 0x04001024 RID: 4132
	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goReloadBuff;

	// Token: 0x04001025 RID: 4133
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goDarkBuff;

	// Token: 0x04001026 RID: 4134
	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x184F58", Offset = "0x184F58")]
	public short sWeapon;

	// Token: 0x04001027 RID: 4135
	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HideInInspector", RVA = "0x184F68", Offset = "0x184F68")]
	public long nEquip;

	// Token: 0x04001028 RID: 4136
	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HideInInspector", RVA = "0x184F78", Offset = "0x184F78")]
	public bool bNPC;

	// Token: 0x04001029 RID: 4137
	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "HideInInspector", RVA = "0x184F88", Offset = "0x184F88")]
	public ObscuredInt nAmmo;

	// Token: 0x0400102A RID: 4138
	[Token(Token = "0x4000E7B")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "HideInInspector", RVA = "0x184F98", Offset = "0x184F98")]
	public ObscuredInt nMaxAmmo;

	// Token: 0x0400102B RID: 4139
	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "HideInInspector", RVA = "0x184FA8", Offset = "0x184FA8")]
	public Enemy target;

	// Token: 0x0400102C RID: 4140
	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "HideInInspector", RVA = "0x184FB8", Offset = "0x184FB8")]
	public ObscuredFloat fCool;

	// Token: 0x0400102D RID: 4141
	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "HideInInspector", RVA = "0x184FC8", Offset = "0x184FC8")]
	public ObscuredFloat fAccBonus;

	// Token: 0x0400102E RID: 4142
	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "HideInInspector", RVA = "0x184FD8", Offset = "0x184FD8")]
	public double fDmgDealt;

	// Token: 0x0400102F RID: 4143
	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x90")]
	public ParticleElt psRage;

	// Token: 0x04001030 RID: 4144
	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x94")]
	public ParticleElt psWarcry;

	// Token: 0x04001031 RID: 4145
	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x98")]
	public ParticleElt psSwift;

	// Token: 0x04001032 RID: 4146
	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x9C")]
	public ParticleElt psConcen;

	// Token: 0x04001033 RID: 4147
	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0xA0")]
	private ObscuredFloat fAtkBonus;

	// Token: 0x04001034 RID: 4148
	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0xB4")]
	private ObscuredFloat fAfterAtkBonus;

	// Token: 0x04001035 RID: 4149
	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0xC8")]
	private ObscuredFloat fRageAtkBonus;

	// Token: 0x04001036 RID: 4150
	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0xDC")]
	private ObscuredFloat fAspBonus;

	// Token: 0x04001037 RID: 4151
	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0xF0")]
	private ObscuredFloat fAfterAspBonus;

	// Token: 0x04001038 RID: 4152
	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x104")]
	private ObscuredFloat fRageAspBonus;

	// Token: 0x04001039 RID: 4153
	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x118")]
	private ObscuredFloat fReloadBonus;

	// Token: 0x0400103A RID: 4154
	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x12C")]
	private ObscuredFloat fRageReloadBonus;

	// Token: 0x0400103B RID: 4155
	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x140")]
	public ObscuredInt nCharge;

	// Token: 0x0400103C RID: 4156
	[Token(Token = "0x4000E8D")]
	[FieldOffset(Offset = "0x150")]
	[Attribute(Name = "HideInInspector", RVA = "0x184FE8", Offset = "0x184FE8")]
	public ObscuredFloat fRange;

	// Token: 0x0400103D RID: 4157
	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x164")]
	[Attribute(Name = "HideInInspector", RVA = "0x184FF8", Offset = "0x184FF8")]
	public ObscuredFloat fRecoil;

	// Token: 0x0400103E RID: 4158
	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x178")]
	[Attribute(Name = "HideInInspector", RVA = "0x185008", Offset = "0x185008")]
	public ObscuredFloat fFrenzyBonus;

	// Token: 0x0400103F RID: 4159
	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x0")]
	private static float fMaxRecoil;

	// Token: 0x04001040 RID: 4160
	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x4")]
	private static float fMinRecoil;

	// Token: 0x04001041 RID: 4161
	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x8")]
	private static float fIncRecoil;

	// Token: 0x04001042 RID: 4162
	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x18C")]
	private ObscuredFloat fRdcRecoil;

	// Token: 0x04001043 RID: 4163
	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x1A0")]
	private float fAddRecoil;

	// Token: 0x04001044 RID: 4164
	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x1A4")]
	[Attribute(Name = "HideInInspector", RVA = "0x185018", Offset = "0x185018")]
	public short sID;

	// Token: 0x04001045 RID: 4165
	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x1A8")]
	[Attribute(Name = "HideInInspector", RVA = "0x185028", Offset = "0x185028")]
	public int nPos;

	// Token: 0x04001046 RID: 4166
	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x1AC")]
	private Animator animator;

	// Token: 0x04001047 RID: 4167
	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x1B0")]
	private float fTime;

	// Token: 0x04001048 RID: 4168
	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x1B4")]
	private float fRageChg;

	// Token: 0x04001049 RID: 4169
	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0x1B8")]
	private float fRageDur;

	// Token: 0x0400104A RID: 4170
	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x1BC")]
	private ObscuredFloat fCri;

	// Token: 0x0400104B RID: 4171
	[Token(Token = "0x4000E9C")]
	[FieldOffset(Offset = "0x1D0")]
	private ObscuredFloat fCriDmg;

	// Token: 0x0400104C RID: 4172
	[Token(Token = "0x4000E9D")]
	[FieldOffset(Offset = "0x1E4")]
	private float fReloadBuffTime;

	// Token: 0x0400104D RID: 4173
	[Token(Token = "0x4000E9E")]
	[FieldOffset(Offset = "0x1E8")]
	private float fSwiftBuffTime;

	// Token: 0x0400104E RID: 4174
	[Token(Token = "0x4000E9F")]
	[FieldOffset(Offset = "0x1EC")]
	private float fSwiftFactor;

	// Token: 0x0400104F RID: 4175
	[Token(Token = "0x4000EA0")]
	[FieldOffset(Offset = "0x1F0")]
	private float fWarcryBuffTime;

	// Token: 0x04001050 RID: 4176
	[Token(Token = "0x4000EA1")]
	[FieldOffset(Offset = "0x1F4")]
	private float fWarcryFactor;

	// Token: 0x04001051 RID: 4177
	[Token(Token = "0x4000EA2")]
	[FieldOffset(Offset = "0x1F8")]
	private float fDarkBuffTime;

	// Token: 0x04001052 RID: 4178
	[Token(Token = "0x4000EA3")]
	[FieldOffset(Offset = "0x1FC")]
	private float fDarkFactor;

	// Token: 0x04001053 RID: 4179
	[Token(Token = "0x4000EA4")]
	[FieldOffset(Offset = "0x200")]
	private float fRageGetBonus;

	// Token: 0x04001054 RID: 4180
	[Token(Token = "0x4000EA5")]
	[FieldOffset(Offset = "0x204")]
	private float fRageCriRate;

	// Token: 0x04001055 RID: 4181
	[Token(Token = "0x4000EA6")]
	[FieldOffset(Offset = "0x208")]
	private float fRageCriDmg;

	// Token: 0x04001056 RID: 4182
	[Token(Token = "0x4000EA7")]
	[FieldOffset(Offset = "0x20C")]
	private ObscuredInt nAssCnt;

	// Token: 0x04001057 RID: 4183
	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x21C")]
	private ObscuredInt nRicCnt;

	// Token: 0x04001058 RID: 4184
	[Token(Token = "0x4000EA9")]
	[FieldOffset(Offset = "0x22C")]
	private ObscuredInt nCriCnt;

	// Token: 0x04001059 RID: 4185
	[Token(Token = "0x4000EAA")]
	[FieldOffset(Offset = "0x23C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185038", Offset = "0x185038")]
	public ObscuredInt nMustMultishot;

	// Token: 0x0400105A RID: 4186
	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x24C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185048", Offset = "0x185048")]
	public ObscuredInt nMustBigshot;

	// Token: 0x0400105B RID: 4187
	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x25C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185058", Offset = "0x185058")]
	public ObscuredInt nMustFireball;

	// Token: 0x0400105C RID: 4188
	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0x26C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185068", Offset = "0x185068")]
	public ObscuredInt nMustFirelance;

	// Token: 0x0400105D RID: 4189
	[Token(Token = "0x4000EAE")]
	[FieldOffset(Offset = "0x27C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185078", Offset = "0x185078")]
	public ObscuredInt nMustRandomDmg;

	// Token: 0x0400105E RID: 4190
	[Token(Token = "0x4000EAF")]
	[FieldOffset(Offset = "0x28C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185088", Offset = "0x185088")]
	public ObscuredInt nMustRicochet;

	// Token: 0x0400105F RID: 4191
	[Token(Token = "0x4000EB0")]
	[FieldOffset(Offset = "0x29C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185098", Offset = "0x185098")]
	public ObscuredInt nMustSoulBall;

	// Token: 0x04001060 RID: 4192
	[Token(Token = "0x4000EB1")]
	[FieldOffset(Offset = "0x2AC")]
	[Attribute(Name = "HideInInspector", RVA = "0x1850A8", Offset = "0x1850A8")]
	public ObscuredInt nMustStrongKick;

	// Token: 0x04001061 RID: 4193
	[Token(Token = "0x4000EB2")]
	[FieldOffset(Offset = "0x2BC")]
	[Attribute(Name = "HideInInspector", RVA = "0x1850B8", Offset = "0x1850B8")]
	public ObscuredInt nMustTripleSword;

	// Token: 0x04001062 RID: 4194
	[Token(Token = "0x4000EB3")]
	[FieldOffset(Offset = "0x2CC")]
	[Attribute(Name = "HideInInspector", RVA = "0x1850C8", Offset = "0x1850C8")]
	public ObscuredInt nMustSubLaser;

	// Token: 0x04001063 RID: 4195
	[Token(Token = "0x4000EB4")]
	[FieldOffset(Offset = "0x2DC")]
	[Attribute(Name = "HideInInspector", RVA = "0x1850D8", Offset = "0x1850D8")]
	public ObscuredInt nMustCri;

	// Token: 0x04001064 RID: 4196
	[Token(Token = "0x4000EB5")]
	[FieldOffset(Offset = "0x2EC")]
	[Attribute(Name = "HideInInspector", RVA = "0x1850E8", Offset = "0x1850E8")]
	public ObscuredInt nMustFrost;

	// Token: 0x04001065 RID: 4197
	[Token(Token = "0x4000EB6")]
	[FieldOffset(Offset = "0x2FC")]
	[Attribute(Name = "HideInInspector", RVA = "0x1850F8", Offset = "0x1850F8")]
	public ObscuredInt nMustBigSlash;

	// Token: 0x04001066 RID: 4198
	[Token(Token = "0x4000EB7")]
	[FieldOffset(Offset = "0x30C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185108", Offset = "0x185108")]
	public ObscuredInt nMustChain;

	// Token: 0x04001067 RID: 4199
	[Token(Token = "0x4000EB8")]
	[FieldOffset(Offset = "0x31C")]
	[Attribute(Name = "HideInInspector", RVA = "0x185118", Offset = "0x185118")]
	public ObscuredInt nMustElementalExposion;

	// Token: 0x04001068 RID: 4200
	[Token(Token = "0x4000EB9")]
	[FieldOffset(Offset = "0x32C")]
	private WeaponType eWeapon;

	// Token: 0x04001069 RID: 4201
	[Token(Token = "0x4000EBA")]
	[FieldOffset(Offset = "0x330")]
	private bool bReload;

	// Token: 0x0400106A RID: 4202
	[Token(Token = "0x4000EBB")]
	[FieldOffset(Offset = "0x334")]
	private Coroutine cr;

	// Token: 0x0400106B RID: 4203
	[Token(Token = "0x4000EBC")]
	[FieldOffset(Offset = "0x338")]
	private float fStunTime;

	// Token: 0x0400106C RID: 4204
	[Token(Token = "0x4000EBD")]
	[FieldOffset(Offset = "0x33C")]
	private float fStunDur;

	// Token: 0x0400106D RID: 4205
	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x340")]
	private Coroutine crStun;

	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000350")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FE20", Offset = "0x17FE20")]
	private sealed class <Reload>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x2B4E78", Offset = "0x2B4E78", VA = "0x62B4E78")]
		[DebuggerHidden]
		public <Reload>c__Iterator0()
		{
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x2B79B8", Offset = "0x2B79B8", VA = "0x62B79B8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001C7")]
		private object Current
		{
			[Token(Token = "0x60015CE")]
			[Address(RVA = "0x2B7E5C", Offset = "0x2B7E5C", VA = "0x62B7E5C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001C8")]
		private object Current
		{
			[Token(Token = "0x60015CF")]
			[Address(RVA = "0x2B7E64", Offset = "0x2B7E64", VA = "0x62B7E64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x2B7E6C", Offset = "0x2B7E6C", VA = "0x62B7E6C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x2B7E80", Offset = "0x2B7E80", VA = "0x62B7E80", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400147F")]
		[FieldOffset(Offset = "0x8")]
		internal float <fLoad>__0;

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x4001480")]
		[FieldOffset(Offset = "0xC")]
		internal float <fRate>__0;

		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001481")]
		[FieldOffset(Offset = "0x10")]
		internal float fTime;

		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0x14")]
		internal Monster $this;

		// Token: 0x04001072 RID: 4210
		[Token(Token = "0x4001483")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x04001073 RID: 4211
		[Token(Token = "0x4001484")]
		[FieldOffset(Offset = "0x1C")]
		internal bool $disposing;

		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001485")]
		[FieldOffset(Offset = "0x20")]
		internal int $PC;
	}

	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000351")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FE30", Offset = "0x17FE30")]
	private sealed class <StartStun>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060012F8 RID: 4856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x2B4FF0", Offset = "0x2B4FF0", VA = "0x62B4FF0")]
		[DebuggerHidden]
		public <StartStun>c__Iterator1()
		{
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x2B7F08", Offset = "0x2B7F08", VA = "0x62B7F08", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001C9")]
		private object Current
		{
			[Token(Token = "0x60015D4")]
			[Address(RVA = "0x2B8154", Offset = "0x2B8154", VA = "0x62B8154", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001CA")]
		private object Current
		{
			[Token(Token = "0x60015D5")]
			[Address(RVA = "0x2B815C", Offset = "0x2B815C", VA = "0x62B815C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x2B8164", Offset = "0x2B8164", VA = "0x62B8164", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x2B8178", Offset = "0x2B8178", VA = "0x62B8178", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001075 RID: 4213
		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0x8")]
		internal float <fLastFlip>__0;

		// Token: 0x04001076 RID: 4214
		[Token(Token = "0x4001487")]
		[FieldOffset(Offset = "0xC")]
		internal Monster $this;

		// Token: 0x04001077 RID: 4215
		[Token(Token = "0x4001488")]
		[FieldOffset(Offset = "0x10")]
		internal object $current;

		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001489")]
		[FieldOffset(Offset = "0x14")]
		internal bool $disposing;

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x18")]
		internal int $PC;
	}
}
