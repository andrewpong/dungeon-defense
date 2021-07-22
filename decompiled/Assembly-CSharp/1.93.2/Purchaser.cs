using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Purchasing;

// Token: 0x02000363 RID: 867
[Token(Token = "0x20002A9")]
public class Purchaser : MonoBehaviour, IStoreListener
{
	// Token: 0x06001624 RID: 5668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D2")]
	[Address(RVA = "0xC7F960", Offset = "0xC7F960", VA = "0x6C7F960")]
	public Purchaser()
	{
	}

	// Token: 0x06001625 RID: 5669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D3")]
	[Address(RVA = "0xC7F968", Offset = "0xC7F968", VA = "0x6C7F968")]
	private void Awake()
	{
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D4")]
	[Address(RVA = "0xC7FB14", Offset = "0xC7FB14", VA = "0x6C7FB14")]
	public void TryInitialize()
	{
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D5")]
	[Address(RVA = "0xC7FBB4", Offset = "0xC7FBB4", VA = "0x6C7FBB4")]
	public void InitializePurchasing()
	{
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x00008778 File Offset: 0x00006978
	[Token(Token = "0x60013D6")]
	[Address(RVA = "0xC84E00", Offset = "0xC84E00", VA = "0x6C84E00")]
	private bool IsInitialized()
	{
		return default(bool);
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D7")]
	[Address(RVA = "0xC84ED4", Offset = "0xC84ED4", VA = "0x6C84ED4")]
	public void BuyProductByShopID(ShopID eID)
	{
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013D8")]
	[Address(RVA = "0xC8501C", Offset = "0xC8501C", VA = "0x6C8501C")]
	public string GetIDFromShopID(ShopID eID)
	{
		return null;
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D9")]
	[Address(RVA = "0xC86198", Offset = "0xC86198", VA = "0x6C86198")]
	public void BuyNonConsumable()
	{
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DA")]
	[Address(RVA = "0xC8619C", Offset = "0xC8619C", VA = "0x6C8619C")]
	public void BuySubscription()
	{
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DB")]
	[Address(RVA = "0xC85CF0", Offset = "0xC85CF0", VA = "0x6C85CF0")]
	private void BuyProductID(string productId)
	{
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013DC")]
	[Address(RVA = "0xC861A0", Offset = "0xC861A0", VA = "0x6C861A0")]
	public string GetProductPrice(ShopID eID)
	{
		return null;
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DD")]
	[Address(RVA = "0xC86348", Offset = "0xC86348", VA = "0x6C86348")]
	public void RestorePurchases()
	{
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DE")]
	[Address(RVA = "0xC86758", Offset = "0xC86758", VA = "0x6C86758", Slot = "7")]
	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DF")]
	[Address(RVA = "0xC86838", Offset = "0xC86838", VA = "0x6C86838", Slot = "4")]
	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x00008790 File Offset: 0x00006990
	[Token(Token = "0x60013E0")]
	[Address(RVA = "0xC86930", Offset = "0xC86930", VA = "0x6C86930", Slot = "5")]
	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
	{
		return PurchaseProcessingResult.Complete;
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E1")]
	[Address(RVA = "0xC86EC0", Offset = "0xC86EC0", VA = "0x6C86EC0")]
	public void RealProcess(string strID, bool bSave = true)
	{
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E2")]
	[Address(RVA = "0xC99C28", Offset = "0xC99C28", VA = "0x6C99C28", Slot = "6")]
	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
	{
	}

	// Token: 0x06001636 RID: 5686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E4")]
	[Address(RVA = "0xC9A580", Offset = "0xC9A580", VA = "0x6C9A580")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187D1C", Offset = "0x187D1C")]
	private static void <RestorePurchases>m__0(bool result)
	{
	}

	// Token: 0x0400150C RID: 5388
	[Token(Token = "0x400122A")]
	[FieldOffset(Offset = "0x0")]
	public static Purchaser single;

	// Token: 0x0400150D RID: 5389
	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0x4")]
	private static IStoreController m_StoreController;

	// Token: 0x0400150E RID: 5390
	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0x8")]
	private static IExtensionProvider m_StoreExtensionProvider;

	// Token: 0x0400150F RID: 5391
	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0xC")]
	private static string kIDFeaturePackage;

	// Token: 0x04001510 RID: 5392
	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x10")]
	private static string kIDMagicalPackage;

	// Token: 0x04001511 RID: 5393
	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0x14")]
	private static string kIDTotalPackage;

	// Token: 0x04001512 RID: 5394
	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x18")]
	private static string kIDFirst660;

	// Token: 0x04001513 RID: 5395
	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x1C")]
	private static string kIDFirst1100;

	// Token: 0x04001514 RID: 5396
	[Token(Token = "0x4001232")]
	[FieldOffset(Offset = "0x20")]
	private static string kIDFirst2400;

	// Token: 0x04001515 RID: 5397
	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x24")]
	private static string kIDFirst8400;

	// Token: 0x04001516 RID: 5398
	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x28")]
	private static string kIDFirst18000;

	// Token: 0x04001517 RID: 5399
	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x2C")]
	private static string kIDStone330;

	// Token: 0x04001518 RID: 5400
	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x30")]
	private static string kIDStone550;

	// Token: 0x04001519 RID: 5401
	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x34")]
	private static string kIDStone1200;

	// Token: 0x0400151A RID: 5402
	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x38")]
	private static string kIDStone4200;

	// Token: 0x0400151B RID: 5403
	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x3C")]
	private static string kIDStone9000;

	// Token: 0x0400151C RID: 5404
	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0x40")]
	private static string kIDRemoveAds;

	// Token: 0x0400151D RID: 5405
	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x44")]
	private static string kIDAutoPackage;

	// Token: 0x0400151E RID: 5406
	[Token(Token = "0x400123C")]
	[FieldOffset(Offset = "0x48")]
	private static string kIDRingPackage;

	// Token: 0x0400151F RID: 5407
	[Token(Token = "0x400123D")]
	[FieldOffset(Offset = "0x4C")]
	private static string kIDRubyFirst180;

	// Token: 0x04001520 RID: 5408
	[Token(Token = "0x400123E")]
	[FieldOffset(Offset = "0x50")]
	private static string kIDRubyFirst300;

	// Token: 0x04001521 RID: 5409
	[Token(Token = "0x400123F")]
	[FieldOffset(Offset = "0x54")]
	private static string kIDRubyFirst660;

	// Token: 0x04001522 RID: 5410
	[Token(Token = "0x4001240")]
	[FieldOffset(Offset = "0x58")]
	private static string kIDRubyFirst2160;

	// Token: 0x04001523 RID: 5411
	[Token(Token = "0x4001241")]
	[FieldOffset(Offset = "0x5C")]
	private static string kIDRubyFirst4200;

	// Token: 0x04001524 RID: 5412
	[Token(Token = "0x4001242")]
	[FieldOffset(Offset = "0x60")]
	private static string kIDRubyRepeat90;

	// Token: 0x04001525 RID: 5413
	[Token(Token = "0x4001243")]
	[FieldOffset(Offset = "0x64")]
	private static string kIDRubyRepeat150;

	// Token: 0x04001526 RID: 5414
	[Token(Token = "0x4001244")]
	[FieldOffset(Offset = "0x68")]
	private static string kIDRubyRepeat330;

	// Token: 0x04001527 RID: 5415
	[Token(Token = "0x4001245")]
	[FieldOffset(Offset = "0x6C")]
	private static string kIDRubyRepeat1080;

	// Token: 0x04001528 RID: 5416
	[Token(Token = "0x4001246")]
	[FieldOffset(Offset = "0x70")]
	private static string kIDRubyRepeat2100;

	// Token: 0x04001529 RID: 5417
	[Token(Token = "0x4001247")]
	[FieldOffset(Offset = "0x74")]
	private static string kIDAwakenPackage;

	// Token: 0x0400152A RID: 5418
	[Token(Token = "0x4001248")]
	[FieldOffset(Offset = "0x78")]
	private static string kIDHellPackage;

	// Token: 0x0400152B RID: 5419
	[Token(Token = "0x4001249")]
	[FieldOffset(Offset = "0x7C")]
	private static string kIDSuccubusPackage;

	// Token: 0x0400152C RID: 5420
	[Token(Token = "0x400124A")]
	[FieldOffset(Offset = "0x80")]
	private static string kIDHellFirst60;

	// Token: 0x0400152D RID: 5421
	[Token(Token = "0x400124B")]
	[FieldOffset(Offset = "0x84")]
	private static string kIDHellFirst240;

	// Token: 0x0400152E RID: 5422
	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x88")]
	private static string kIDHellFirst500;

	// Token: 0x0400152F RID: 5423
	[Token(Token = "0x400124D")]
	[FieldOffset(Offset = "0x8C")]
	private static string kIDHellRepeat30;

	// Token: 0x04001530 RID: 5424
	[Token(Token = "0x400124E")]
	[FieldOffset(Offset = "0x90")]
	private static string kIDHellRepeat120;

	// Token: 0x04001531 RID: 5425
	[Token(Token = "0x400124F")]
	[FieldOffset(Offset = "0x94")]
	private static string kIDHellRepeat250;

	// Token: 0x04001532 RID: 5426
	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x98")]
	private static string kIDElementalPackage;

	// Token: 0x04001533 RID: 5427
	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x9C")]
	private static string kIDRebirthPackage;

	// Token: 0x04001534 RID: 5428
	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0xA0")]
	private static string kIDRebirthExp;

	// Token: 0x04001535 RID: 5429
	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0xA4")]
	private static string kIDElementalExp;

	// Token: 0x04001536 RID: 5430
	[Token(Token = "0x4001254")]
	[FieldOffset(Offset = "0xA8")]
	private static string kIDFirst50000;

	// Token: 0x04001537 RID: 5431
	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0xAC")]
	private static string kIDRubyFirst12000;

	// Token: 0x04001538 RID: 5432
	[Token(Token = "0x4001256")]
	[FieldOffset(Offset = "0xB0")]
	private static string kGoogleNonCSFeaturePackage;

	// Token: 0x04001539 RID: 5433
	[Token(Token = "0x4001257")]
	[FieldOffset(Offset = "0xB4")]
	private static string kGoogleNonCSMagicalPacakage;

	// Token: 0x0400153A RID: 5434
	[Token(Token = "0x4001258")]
	[FieldOffset(Offset = "0xB8")]
	private static string kGoogleNonCSTotalPackage;

	// Token: 0x0400153B RID: 5435
	[Token(Token = "0x4001259")]
	[FieldOffset(Offset = "0xBC")]
	private static string kGoogleCSFirst660;

	// Token: 0x0400153C RID: 5436
	[Token(Token = "0x400125A")]
	[FieldOffset(Offset = "0xC0")]
	private static string kGoogleCSFirst1100;

	// Token: 0x0400153D RID: 5437
	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0xC4")]
	private static string kGoogleCSFirst2400;

	// Token: 0x0400153E RID: 5438
	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0xC8")]
	private static string kGoogleCSFirst8400;

	// Token: 0x0400153F RID: 5439
	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0xCC")]
	private static string kGoogleCSFirst18000;

	// Token: 0x04001540 RID: 5440
	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0xD0")]
	private static string kGoogleCSStone330;

	// Token: 0x04001541 RID: 5441
	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0xD4")]
	private static string kGoogleCSStone550;

	// Token: 0x04001542 RID: 5442
	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0xD8")]
	private static string kGoogleCSStone1200;

	// Token: 0x04001543 RID: 5443
	[Token(Token = "0x4001261")]
	[FieldOffset(Offset = "0xDC")]
	private static string kGoogleCSStone4200;

	// Token: 0x04001544 RID: 5444
	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0xE0")]
	private static string kGoogleCSStone9000;

	// Token: 0x04001545 RID: 5445
	[Token(Token = "0x4001263")]
	[FieldOffset(Offset = "0xE4")]
	private static string kGoogleNonCSRemoveAds;

	// Token: 0x04001546 RID: 5446
	[Token(Token = "0x4001264")]
	[FieldOffset(Offset = "0xE8")]
	private static string kGoogleAutoPackage;

	// Token: 0x04001547 RID: 5447
	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0xEC")]
	private static string kGoogleRingPackage;

	// Token: 0x04001548 RID: 5448
	[Token(Token = "0x4001266")]
	[FieldOffset(Offset = "0xF0")]
	private static string kGoogleRubyFirst180;

	// Token: 0x04001549 RID: 5449
	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0xF4")]
	private static string kGoogleRubyFirst300;

	// Token: 0x0400154A RID: 5450
	[Token(Token = "0x4001268")]
	[FieldOffset(Offset = "0xF8")]
	private static string kGoogleRubyFirst660;

	// Token: 0x0400154B RID: 5451
	[Token(Token = "0x4001269")]
	[FieldOffset(Offset = "0xFC")]
	private static string kGoogleRubyFirst2160;

	// Token: 0x0400154C RID: 5452
	[Token(Token = "0x400126A")]
	[FieldOffset(Offset = "0x100")]
	private static string kGoogleRubyFirst4200;

	// Token: 0x0400154D RID: 5453
	[Token(Token = "0x400126B")]
	[FieldOffset(Offset = "0x104")]
	private static string kGoogleRubyRepeat90;

	// Token: 0x0400154E RID: 5454
	[Token(Token = "0x400126C")]
	[FieldOffset(Offset = "0x108")]
	private static string kGoogleRubyRepeat150;

	// Token: 0x0400154F RID: 5455
	[Token(Token = "0x400126D")]
	[FieldOffset(Offset = "0x10C")]
	private static string kGoogleRubyRepeat330;

	// Token: 0x04001550 RID: 5456
	[Token(Token = "0x400126E")]
	[FieldOffset(Offset = "0x110")]
	private static string kGoogleRubyRepeat1080;

	// Token: 0x04001551 RID: 5457
	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0x114")]
	private static string kGoogleRubyRepeat2100;

	// Token: 0x04001552 RID: 5458
	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0x118")]
	private static string kGoogleAwakenPackage;

	// Token: 0x04001553 RID: 5459
	[Token(Token = "0x4001271")]
	[FieldOffset(Offset = "0x11C")]
	private static string kGoogleHellPackage;

	// Token: 0x04001554 RID: 5460
	[Token(Token = "0x4001272")]
	[FieldOffset(Offset = "0x120")]
	private static string kGoogleSuccubusPackage;

	// Token: 0x04001555 RID: 5461
	[Token(Token = "0x4001273")]
	[FieldOffset(Offset = "0x124")]
	private static string kGoogleHellFirst60;

	// Token: 0x04001556 RID: 5462
	[Token(Token = "0x4001274")]
	[FieldOffset(Offset = "0x128")]
	private static string kGoogleHellFirst240;

	// Token: 0x04001557 RID: 5463
	[Token(Token = "0x4001275")]
	[FieldOffset(Offset = "0x12C")]
	private static string kGoogleHellFirst500;

	// Token: 0x04001558 RID: 5464
	[Token(Token = "0x4001276")]
	[FieldOffset(Offset = "0x130")]
	private static string kGoogleHellRepeat30;

	// Token: 0x04001559 RID: 5465
	[Token(Token = "0x4001277")]
	[FieldOffset(Offset = "0x134")]
	private static string kGoogleHellRepeat120;

	// Token: 0x0400155A RID: 5466
	[Token(Token = "0x4001278")]
	[FieldOffset(Offset = "0x138")]
	private static string kGoogleHellRepeat250;

	// Token: 0x0400155B RID: 5467
	[Token(Token = "0x4001279")]
	[FieldOffset(Offset = "0x13C")]
	private static string kGoogleElementalPackage;

	// Token: 0x0400155C RID: 5468
	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0x140")]
	private static string kGoogleRebirthPackage;

	// Token: 0x0400155D RID: 5469
	[Token(Token = "0x400127B")]
	[FieldOffset(Offset = "0x144")]
	private static string kGoogleRebirthExp;

	// Token: 0x0400155E RID: 5470
	[Token(Token = "0x400127C")]
	[FieldOffset(Offset = "0x148")]
	private static string kGoogleElementalExp;

	// Token: 0x0400155F RID: 5471
	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x14C")]
	private static string kGoogleCSFirst50000;

	// Token: 0x04001560 RID: 5472
	[Token(Token = "0x400127E")]
	[FieldOffset(Offset = "0x150")]
	private static string kGoogleRubyFirst12000;

	// Token: 0x04001561 RID: 5473
	[Token(Token = "0x400127F")]
	[FieldOffset(Offset = "0x154")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x185248", Offset = "0x185248")]
	private static Action<bool> <>f__am$cache0;
}
