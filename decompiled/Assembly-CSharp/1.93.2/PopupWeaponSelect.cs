using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000361 RID: 865
[Token(Token = "0x20002A7")]
public class PopupWeaponSelect : UIPage
{
	// Token: 0x060015E2 RID: 5602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001390")]
	[Address(RVA = "0x420920", Offset = "0x420920", VA = "0x6420920")]
	public PopupWeaponSelect()
	{
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00008670 File Offset: 0x00006870
	// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019C")]
	private long nGold
	{
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x420A28", Offset = "0x420A28", VA = "0x6420A28")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x420B2C", Offset = "0x420B2C", VA = "0x6420B2C")]
		set
		{
		}
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00008688 File Offset: 0x00006888
	// (set) Token: 0x060015E6 RID: 5606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019D")]
	private int nInven
	{
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x420DCC", Offset = "0x420DCC", VA = "0x6420DCC")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x420E94", Offset = "0x420E94", VA = "0x6420E94")]
		set
		{
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x060015E7 RID: 5607 RVA: 0x000086A0 File Offset: 0x000068A0
	[Token(Token = "0x1700019E")]
	private int nMaxInherit
	{
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x42105C", Offset = "0x42105C", VA = "0x642105C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x060015E8 RID: 5608 RVA: 0x000086B8 File Offset: 0x000068B8
	// (set) Token: 0x060015E9 RID: 5609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019F")]
	private int nInheritInven
	{
		[Token(Token = "0x6001396")]
		[Address(RVA = "0x4210DC", Offset = "0x4210DC", VA = "0x64210DC")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001397")]
		[Address(RVA = "0x421154", Offset = "0x421154", VA = "0x6421154")]
		set
		{
		}
	}

	// Token: 0x060015EA RID: 5610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001398")]
	[Address(RVA = "0x42132C", Offset = "0x42132C", VA = "0x642132C", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060015EB RID: 5611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001399")]
	[Address(RVA = "0x421A8C", Offset = "0x421A8C", VA = "0x6421A8C", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139A")]
	[Address(RVA = "0x421ED8", Offset = "0x421ED8", VA = "0x6421ED8")]
	public void WeaponSelectMode()
	{
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139B")]
	[Address(RVA = "0x427EEC", Offset = "0x427EEC", VA = "0x6427EEC")]
	public void LootItemMode(bool bSort = false)
	{
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139C")]
	[Address(RVA = "0x428110", Offset = "0x428110", VA = "0x6428110")]
	private void RefreshLootItem(bool bSort = false)
	{
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139D")]
	[Address(RVA = "0x42AA90", Offset = "0x42AA90", VA = "0x642AA90")]
	public void ShopMode()
	{
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139E")]
	[Address(RVA = "0x42B060", Offset = "0x42B060", VA = "0x642B060")]
	public void SellMode(bool bSort = false)
	{
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139F")]
	[Address(RVA = "0x42B8E0", Offset = "0x42B8E0", VA = "0x642B8E0")]
	public void ModifyMode()
	{
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A0")]
	[Address(RVA = "0x42C174", Offset = "0x42C174", VA = "0x642C174")]
	public void EnchantMode(long nWeapon = -1L)
	{
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x411B14", Offset = "0x411B14", VA = "0x6411B14")]
	public void InheritMode()
	{
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x427654", Offset = "0x427654", VA = "0x6427654")]
	private void RefreshButton()
	{
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A3")]
	[Address(RVA = "0x4228F0", Offset = "0x4228F0", VA = "0x64228F0")]
	private void ReallocElt(int nCount)
	{
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A4")]
	[Address(RVA = "0x422F10", Offset = "0x422F10", VA = "0x6422F10")]
	public void RefreshDetailRight(long uid)
	{
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A5")]
	[Address(RVA = "0x4208A8", Offset = "0x4208A8", VA = "0x64208A8")]
	public void RefreshMod()
	{
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013A6")]
	[Address(RVA = "0x42C95C", Offset = "0x42C95C", VA = "0x642C95C")]
	private string[] MakeItemDesc(PlayerItemData pData, [Optional] PlayerItemData lData)
	{
		return null;
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A7")]
	[Address(RVA = "0x4274EC", Offset = "0x4274EC", VA = "0x64274EC")]
	private void RefreshHighlight()
	{
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A8")]
	[Address(RVA = "0x42BE9C", Offset = "0x42BE9C", VA = "0x642BE9C")]
	private void RefreshModHighlight()
	{
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A9")]
	[Address(RVA = "0x4320F0", Offset = "0x4320F0", VA = "0x64320F0")]
	public void OnClick(long uid)
	{
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AA")]
	[Address(RVA = "0x421BB8", Offset = "0x421BB8", VA = "0x6421BB8")]
	public void OnClose()
	{
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AB")]
	[Address(RVA = "0x43212C", Offset = "0x43212C", VA = "0x643212C")]
	public void OnModClick(int nSlot)
	{
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AC")]
	[Address(RVA = "0x421CB8", Offset = "0x421CB8", VA = "0x6421CB8")]
	public void OnNext()
	{
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AD")]
	[Address(RVA = "0x4288E8", Offset = "0x4288E8", VA = "0x64288E8")]
	public void OnSellAuto()
	{
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AE")]
	[Address(RVA = "0x42A150", Offset = "0x42A150", VA = "0x642A150")]
	public void OnSellOnlyLegend()
	{
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AF")]
	[Address(RVA = "0x4296E0", Offset = "0x4296E0", VA = "0x64296E0")]
	public void OnSellAll()
	{
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B0")]
	[Address(RVA = "0x4321E8", Offset = "0x4321E8", VA = "0x64321E8")]
	public void OnButtonA()
	{
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B1")]
	[Address(RVA = "0x434208", Offset = "0x434208", VA = "0x6434208")]
	public void OnButtonB()
	{
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B2")]
	[Address(RVA = "0x434A84", Offset = "0x434A84", VA = "0x6434A84")]
	public void OnButtonC()
	{
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x434C60", Offset = "0x434C60", VA = "0x6434C60")]
	public void OnButtonD()
	{
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x434ED0", Offset = "0x434ED0", VA = "0x6434ED0")]
	public void OnButtonE()
	{
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x435114", Offset = "0x435114", VA = "0x6435114")]
	private void RefreshItemSellMode()
	{
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x432BCC", Offset = "0x432BCC", VA = "0x6432BCC")]
	private void PlayerItemSell()
	{
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x434C74", Offset = "0x434C74", VA = "0x6434C74")]
	private void OnPlayerItemProtect()
	{
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x433550", Offset = "0x433550", VA = "0x6433550")]
	private void ItemPurchase()
	{
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x435130", Offset = "0x435130", VA = "0x6435130")]
	private void LootItemSell()
	{
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x43223C", Offset = "0x43223C", VA = "0x643223C")]
	private void EquipOrUnequip()
	{
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x4359A0", Offset = "0x4359A0", VA = "0x64359A0")]
	public void OnRealMod()
	{
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013BC")]
	[Address(RVA = "0x4366A8", Offset = "0x4366A8", VA = "0x64366A8")]
	public void OnMod()
	{
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013BD")]
	[Address(RVA = "0x436790", Offset = "0x436790", VA = "0x6436790")]
	public void OnAddModSlot()
	{
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x436B10", Offset = "0x436B10", VA = "0x6436B10")]
	public void OnEnchant()
	{
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x436BB8", Offset = "0x436BB8", VA = "0x6436BB8")]
	public void OnSimpleEnchant()
	{
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x436C64", Offset = "0x436C64", VA = "0x6436C64")]
	public void OnMonDiff(int n)
	{
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x436C88", Offset = "0x436C88", VA = "0x6436C88")]
	public void OnSpecEquip(int n)
	{
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x437988", Offset = "0x437988", VA = "0x6437988")]
	public void OnCancelDiff()
	{
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x433EE8", Offset = "0x433EE8", VA = "0x6433EE8")]
	public void OnInherit()
	{
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x434254", Offset = "0x434254", VA = "0x6434254")]
	public void OnRebirth()
	{
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x4379BC", Offset = "0x4379BC", VA = "0x64379BC")]
	public void OnRealRebirth()
	{
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x42C798", Offset = "0x42C798", VA = "0x642C798")]
	public void RefreshChecker()
	{
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x437ACC", Offset = "0x437ACC", VA = "0x6437ACC")]
	public void RefreshSpecial()
	{
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x434460", Offset = "0x434460", VA = "0x6434460")]
	public void OnSpecialEnchant()
	{
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x437D2C", Offset = "0x437D2C", VA = "0x6437D2C")]
	public void OnItemFilter()
	{
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x000086D0 File Offset: 0x000068D0
	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x437F4C", Offset = "0x437F4C", VA = "0x6437F4C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187CAC", Offset = "0x187CAC")]
	private static int <WeaponSelectMode>m__0(PlayerItemData x, PlayerItemData y)
	{
		return 0;
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x000086E8 File Offset: 0x000068E8
	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x438F88", Offset = "0x438F88", VA = "0x6438F88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187CBC", Offset = "0x187CBC")]
	private static int <RefreshLootItem>m__1(PlayerItemData x, PlayerItemData y)
	{
		return 0;
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x00008700 File Offset: 0x00006900
	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x439B68", Offset = "0x439B68", VA = "0x6439B68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187CCC", Offset = "0x187CCC")]
	private static int <ShopMode>m__2(PlayerItemData x, PlayerItemData y)
	{
		return 0;
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x00008718 File Offset: 0x00006918
	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x43A24C", Offset = "0x43A24C", VA = "0x643A24C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187CDC", Offset = "0x187CDC")]
	private static int <SellMode>m__3(PlayerItemData x, PlayerItemData y)
	{
		return 0;
	}

	// Token: 0x06001621 RID: 5665 RVA: 0x00008730 File Offset: 0x00006930
	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x43AC4C", Offset = "0x43AC4C", VA = "0x643AC4C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187CEC", Offset = "0x187CEC")]
	private static int <ModifyMode>m__4(PlayerItemData x, PlayerItemData y)
	{
		return 0;
	}

	// Token: 0x06001622 RID: 5666 RVA: 0x00008748 File Offset: 0x00006948
	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x43B64C", Offset = "0x43B64C", VA = "0x643B64C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187CFC", Offset = "0x187CFC")]
	private static int <EnchantMode>m__5(PlayerItemData x, PlayerItemData y)
	{
		return 0;
	}

	// Token: 0x06001623 RID: 5667 RVA: 0x00008760 File Offset: 0x00006960
	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x43C04C", Offset = "0x43C04C", VA = "0x643C04C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187D0C", Offset = "0x187D0C")]
	private static int <InheritMode>m__6(PlayerItemData x, PlayerItemData y)
	{
		return 0;
	}

	// Token: 0x040014A6 RID: 5286
	[Token(Token = "0x40011C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PopupWeaponSelect obj;

	// Token: 0x040014A7 RID: 5287
	[Token(Token = "0x40011C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public StringTooltip strTooltip;

	// Token: 0x040014A8 RID: 5288
	[Token(Token = "0x40011C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject goLeftItem;

	// Token: 0x040014A9 RID: 5289
	[Token(Token = "0x40011C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public GameObject goRightItem;

	// Token: 0x040014AA RID: 5290
	[Token(Token = "0x40011C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject goModPanel;

	// Token: 0x040014AB RID: 5291
	[Token(Token = "0x40011C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public GameObject goEnchantPanel;

	// Token: 0x040014AC RID: 5292
	[Token(Token = "0x40011CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public WeaponElt eltWeaponDetailL;

	// Token: 0x040014AD RID: 5293
	[Token(Token = "0x40011CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public WeaponElt eltWeaponDetailR;

	// Token: 0x040014AE RID: 5294
	[Token(Token = "0x40011CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text textItemNameL;

	// Token: 0x040014AF RID: 5295
	[Token(Token = "0x40011CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Text textItemNameR;

	// Token: 0x040014B0 RID: 5296
	[Token(Token = "0x40011CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text textItemGradeL;

	// Token: 0x040014B1 RID: 5297
	[Token(Token = "0x40011CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Text textItemGradeR;

	// Token: 0x040014B2 RID: 5298
	[Token(Token = "0x40011D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text textItemLevelL;

	// Token: 0x040014B3 RID: 5299
	[Token(Token = "0x40011D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Text textItemLevelR;

	// Token: 0x040014B4 RID: 5300
	[Token(Token = "0x40011D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text textItemTypeL;

	// Token: 0x040014B5 RID: 5301
	[Token(Token = "0x40011D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Text textItemTypeR;

	// Token: 0x040014B6 RID: 5302
	[Token(Token = "0x40011D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text textItemDescL;

	// Token: 0x040014B7 RID: 5303
	[Token(Token = "0x40011D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Text textItemDescR;

	// Token: 0x040014B8 RID: 5304
	[Token(Token = "0x40011D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text textItemStatL;

	// Token: 0x040014B9 RID: 5305
	[Token(Token = "0x40011D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Text textItemStatR;

	// Token: 0x040014BA RID: 5306
	[Token(Token = "0x40011D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Text textBtnA;

	// Token: 0x040014BB RID: 5307
	[Token(Token = "0x40011D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Text textBtnB;

	// Token: 0x040014BC RID: 5308
	[Token(Token = "0x40011DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Text textBtnC;

	// Token: 0x040014BD RID: 5309
	[Token(Token = "0x40011DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public Text textBtnD;

	// Token: 0x040014BE RID: 5310
	[Token(Token = "0x40011DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text textBtnE;

	// Token: 0x040014BF RID: 5311
	[Token(Token = "0x40011DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Text textGold;

	// Token: 0x040014C0 RID: 5312
	[Token(Token = "0x40011DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text textInven;

	// Token: 0x040014C1 RID: 5313
	[Token(Token = "0x40011DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Text textTitle;

	// Token: 0x040014C2 RID: 5314
	[Token(Token = "0x40011E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject objElt;

	// Token: 0x040014C3 RID: 5315
	[Token(Token = "0x40011E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public GameObject goGold;

	// Token: 0x040014C4 RID: 5316
	[Token(Token = "0x40011E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject goInven;

	// Token: 0x040014C5 RID: 5317
	[Token(Token = "0x40011E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public GameObject goBtnA;

	// Token: 0x040014C6 RID: 5318
	[Token(Token = "0x40011E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject goBtnB;

	// Token: 0x040014C7 RID: 5319
	[Token(Token = "0x40011E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public GameObject goBtnC;

	// Token: 0x040014C8 RID: 5320
	[Token(Token = "0x40011E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject goBtnD;

	// Token: 0x040014C9 RID: 5321
	[Token(Token = "0x40011E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public GameObject goBtnE;

	// Token: 0x040014CA RID: 5322
	[Token(Token = "0x40011E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Button btnA;

	// Token: 0x040014CB RID: 5323
	[Token(Token = "0x40011E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public Button btnB;

	// Token: 0x040014CC RID: 5324
	[Token(Token = "0x40011EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Image[] imgModCheckOn;

	// Token: 0x040014CD RID: 5325
	[Token(Token = "0x40011EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public Image[] imgModCheckOff;

	// Token: 0x040014CE RID: 5326
	[Token(Token = "0x40011EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image[] imgModPanel;

	// Token: 0x040014CF RID: 5327
	[Token(Token = "0x40011ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public Button[] btnModPanel;

	// Token: 0x040014D0 RID: 5328
	[Token(Token = "0x40011EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Text[] textModName;

	// Token: 0x040014D1 RID: 5329
	[Token(Token = "0x40011EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Text textModBtnA;

	// Token: 0x040014D2 RID: 5330
	[Token(Token = "0x40011F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Text textModBtnB;

	// Token: 0x040014D3 RID: 5331
	[Token(Token = "0x40011F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public Text textModTitle;

	// Token: 0x040014D4 RID: 5332
	[Token(Token = "0x40011F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Text textModCost;

	// Token: 0x040014D5 RID: 5333
	[Token(Token = "0x40011F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public Button btnModA;

	// Token: 0x040014D6 RID: 5334
	[Token(Token = "0x40011F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Button btnModB;

	// Token: 0x040014D7 RID: 5335
	[Token(Token = "0x40011F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public Button btnBackPanel;

	// Token: 0x040014D8 RID: 5336
	[Token(Token = "0x40011F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public RectTransform rtWeaponList;

	// Token: 0x040014D9 RID: 5337
	[Token(Token = "0x40011F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private List<WeaponElt> listWeapon;

	// Token: 0x040014DA RID: 5338
	[Token(Token = "0x40011F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private PopupWeaponSelect.Mode eMode;

	// Token: 0x040014DB RID: 5339
	[Token(Token = "0x40011F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public WeaponElt eltEnchantL;

	// Token: 0x040014DC RID: 5340
	[Token(Token = "0x40011FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public WeaponElt eltEnchantR;

	// Token: 0x040014DD RID: 5341
	[Token(Token = "0x40011FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public Text textEnchantTitle;

	// Token: 0x040014DE RID: 5342
	[Token(Token = "0x40011FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Text textEnchantCost;

	// Token: 0x040014DF RID: 5343
	[Token(Token = "0x40011FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public Text textEnchantBtn;

	// Token: 0x040014E0 RID: 5344
	[Token(Token = "0x40011FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Text textEnchantOver;

	// Token: 0x040014E1 RID: 5345
	[Token(Token = "0x40011FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public Text textEnchantSimple;

	// Token: 0x040014E2 RID: 5346
	[Token(Token = "0x4001200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public GameObject goSpec;

	// Token: 0x040014E3 RID: 5347
	[Token(Token = "0x4001201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public GameObject[] goSpecChar;

	// Token: 0x040014E4 RID: 5348
	[Token(Token = "0x4001202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Image[] imgSpecChar;

	// Token: 0x040014E5 RID: 5349
	[Token(Token = "0x4001203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public GameObject[] goSpecUp;

	// Token: 0x040014E6 RID: 5350
	[Token(Token = "0x4001204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject[] goSpecDown;

	// Token: 0x040014E7 RID: 5351
	[Token(Token = "0x4001205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public GameObject[] goSpecEqual;

	// Token: 0x040014E8 RID: 5352
	[Token(Token = "0x4001206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject[] goSpecCant;

	// Token: 0x040014E9 RID: 5353
	[Token(Token = "0x4001207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public Button[] btnSpecDiff;

	// Token: 0x040014EA RID: 5354
	[Token(Token = "0x4001208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Text[] textSpecDiff;

	// Token: 0x040014EB RID: 5355
	[Token(Token = "0x4001209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public Button[] btnSpecEquip;

	// Token: 0x040014EC RID: 5356
	[Token(Token = "0x400120A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Text[] textSpecEquip;

	// Token: 0x040014ED RID: 5357
	[Token(Token = "0x400120B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public Text[] textSpecMasLv;

	// Token: 0x040014EE RID: 5358
	[Token(Token = "0x400120C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public GameObject goSpecDiffClose;

	// Token: 0x040014EF RID: 5359
	[Token(Token = "0x400120D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[Attribute(Name = "HideInInspector", RVA = "0x1851C8", Offset = "0x1851C8")]
	public long nSelectedWeapon;

	// Token: 0x040014F0 RID: 5360
	[Token(Token = "0x400120E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int nSelectModSlot;

	// Token: 0x040014F1 RID: 5361
	[Token(Token = "0x400120F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private int nSelectMonSlot;

	// Token: 0x040014F2 RID: 5362
	[Token(Token = "0x4001210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private bool bAutoSell;

	// Token: 0x040014F3 RID: 5363
	[Token(Token = "0x4001211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private List<PlayerItemData> listInherit;

	// Token: 0x040014F4 RID: 5364
	[Token(Token = "0x4001212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private string[] arrStrItemDescL;

	// Token: 0x040014F5 RID: 5365
	[Token(Token = "0x4001213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private string[] arrStrItemDescR;

	// Token: 0x040014F6 RID: 5366
	[Token(Token = "0x4001214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static string red;

	// Token: 0x040014F7 RID: 5367
	[Token(Token = "0x4001215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string white;

	// Token: 0x040014F8 RID: 5368
	[Token(Token = "0x4001216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static string strGood;

	// Token: 0x040014F9 RID: 5369
	[Token(Token = "0x4001217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string strBad;

	// Token: 0x040014FA RID: 5370
	[Token(Token = "0x4001218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static string strGoodArw;

	// Token: 0x040014FB RID: 5371
	[Token(Token = "0x4001219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string strBadArw;

	// Token: 0x040014FC RID: 5372
	[Token(Token = "0x400121A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static string strEnd;

	// Token: 0x040014FD RID: 5373
	[Token(Token = "0x400121B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1851D8", Offset = "0x1851D8")]
	private static Comparison<PlayerItemData> <>f__am$cache0;

	// Token: 0x040014FE RID: 5374
	[Token(Token = "0x400121C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1851E8", Offset = "0x1851E8")]
	private static Comparison<PlayerItemData> <>f__am$cache1;

	// Token: 0x040014FF RID: 5375
	[Token(Token = "0x400121D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1851F8", Offset = "0x1851F8")]
	private static Comparison<PlayerItemData> <>f__am$cache2;

	// Token: 0x04001500 RID: 5376
	[Token(Token = "0x400121E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185208", Offset = "0x185208")]
	private static Comparison<PlayerItemData> <>f__am$cache3;

	// Token: 0x04001501 RID: 5377
	[Token(Token = "0x400121F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185218", Offset = "0x185218")]
	private static Comparison<PlayerItemData> <>f__am$cache4;

	// Token: 0x04001502 RID: 5378
	[Token(Token = "0x4001220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185228", Offset = "0x185228")]
	private static Comparison<PlayerItemData> <>f__am$cache5;

	// Token: 0x04001503 RID: 5379
	[Token(Token = "0x4001221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185238", Offset = "0x185238")]
	private static Comparison<PlayerItemData> <>f__am$cache6;

	// Token: 0x02000362 RID: 866
	[Token(Token = "0x20002A8")]
	private enum Mode
	{
		// Token: 0x04001505 RID: 5381
		[Token(Token = "0x4001223")]
		eWeaponSelect,
		// Token: 0x04001506 RID: 5382
		[Token(Token = "0x4001224")]
		eLootItem,
		// Token: 0x04001507 RID: 5383
		[Token(Token = "0x4001225")]
		eShop,
		// Token: 0x04001508 RID: 5384
		[Token(Token = "0x4001226")]
		eSellItem,
		// Token: 0x04001509 RID: 5385
		[Token(Token = "0x4001227")]
		eModify,
		// Token: 0x0400150A RID: 5386
		[Token(Token = "0x4001228")]
		eEnchant,
		// Token: 0x0400150B RID: 5387
		[Token(Token = "0x4001229")]
		eInherit
	}
}
