// Decompiled with JetBrains decompiler
// Type: Purchaser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CC;
using CodeStage.AntiCheat.ObscuredTypes;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Security;

public class Purchaser : MonoBehaviour, IStoreListener
{
  private static string kIDFeaturePackage = "featurepackage";
  private static string kIDMagicalPackage = "magicalpackage";
  private static string kIDTotalPackage = "totalpackage";
  private static string kIDFirst660 = "first_660";
  private static string kIDFirst1100 = "first_1100";
  private static string kIDFirst2400 = "first_2400";
  private static string kIDFirst8400 = "first_8400";
  private static string kIDFirst18000 = "first_18000";
  private static string kIDStone330 = "stone_330";
  private static string kIDStone550 = "stone_550";
  private static string kIDStone1200 = "stone_1200";
  private static string kIDStone4200 = "stone_4200";
  private static string kIDStone9000 = "stone_9000";
  private static string kIDRemoveAds = "removeads";
  private static string kIDAutoPackage = "autopackage";
  private static string kIDRingPackage = "ringpackage";
  private static string kIDRubyFirst180 = "ruby_first_180";
  private static string kIDRubyFirst300 = "ruby_first_300";
  private static string kIDRubyFirst660 = "ruby_first_660";
  private static string kIDRubyFirst2160 = "ruby_first_2160";
  private static string kIDRubyFirst4200 = "ruby_first_4200";
  private static string kIDRubyRepeat90 = "ruby_repeat_90";
  private static string kIDRubyRepeat150 = "ruby_repeat_150";
  private static string kIDRubyRepeat330 = "ruby_repeat_330";
  private static string kIDRubyRepeat1080 = "ruby_repeat_1080";
  private static string kIDRubyRepeat2100 = "ruby_repeat_2100";
  private static string kIDAwakenPackage = "awakenpackage";
  private static string kIDHellPackage = "hellpackage";
  private static string kIDSuccubusPackage = "succubuspackage";
  private static string kIDHellFirst60 = "hell_first_60";
  private static string kIDHellFirst240 = "hell_first_240";
  private static string kIDHellFirst500 = "hell_first_500";
  private static string kIDHellRepeat30 = "hell_first_30";
  private static string kIDHellRepeat120 = "hell_first_120";
  private static string kIDHellRepeat250 = "hell_first_250";
  private static string kIDElementalPackage = "elementalpackage";
  private static string kGoogleNonCSFeaturePackage = "dd_featurepackage";
  private static string kGoogleNonCSMagicalPacakage = "dd_magicalpackage";
  private static string kGoogleNonCSTotalPackage = "dd_totalpackage";
  private static string kGoogleCSFirst660 = "dd_first_660";
  private static string kGoogleCSFirst1100 = "dd_first_1100";
  private static string kGoogleCSFirst2400 = "dd_first_2400";
  private static string kGoogleCSFirst8400 = "dd_first_8400";
  private static string kGoogleCSFirst18000 = "dd_first_18000";
  private static string kGoogleCSStone330 = "dd_stone_330";
  private static string kGoogleCSStone550 = "dd_stone_550";
  private static string kGoogleCSStone1200 = "dd_stone_1200";
  private static string kGoogleCSStone4200 = "dd_stone_4200";
  private static string kGoogleCSStone9000 = "dd_stone_9000";
  private static string kGoogleNonCSRemoveAds = "dd_removeads";
  private static string kGoogleAutoPackage = "dd_autopackage";
  private static string kGoogleRingPackage = "dd_ringpackage";
  private static string kGoogleRubyFirst180 = "dd_ruby_first_180";
  private static string kGoogleRubyFirst300 = "dd_ruby_first_300";
  private static string kGoogleRubyFirst660 = "dd_ruby_first_660";
  private static string kGoogleRubyFirst2160 = "dd_ruby_first_2160";
  private static string kGoogleRubyFirst4200 = "dd_ruby_first_4200";
  private static string kGoogleRubyRepeat90 = "dd_ruby_repeat_90";
  private static string kGoogleRubyRepeat150 = "dd_ruby_repeat_150";
  private static string kGoogleRubyRepeat330 = "dd_ruby_repeat_330";
  private static string kGoogleRubyRepeat1080 = "dd_ruby_repeat_1080";
  private static string kGoogleRubyRepeat2100 = "dd_ruby_repeat_2100";
  private static string kGoogleAwakenPackage = "dd_awakenpackage";
  private static string kGoogleHellPackage = "dd_hellpackage";
  private static string kGoogleSuccubusPackage = "dd_succubuspackage";
  private static string kGoogleHellFirst60 = "dd_hell_first_60";
  private static string kGoogleHellFirst240 = "dd_hell_first_240";
  private static string kGoogleHellFirst500 = "dd_hell_first_500";
  private static string kGoogleHellRepeat30 = "dd_hell_repeat_30";
  private static string kGoogleHellRepeat120 = "dd_hell_repeat_120";
  private static string kGoogleHellRepeat250 = "dd_hell_repeat_250";
  private static string kGoogleElementalPackage = "dd_elementalpackage";
  public static Purchaser single;
  private static IStoreController m_StoreController;
  private static IExtensionProvider m_StoreExtensionProvider;

  private void Awake()
  {
    if ((UnityEngine.Object) Purchaser.single != (UnityEngine.Object) null)
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
    }
    else
    {
      Purchaser.single = this;
      UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) this.gameObject);
    }
  }

  public void TryInitialize()
  {
    if (Purchaser.m_StoreController != null)
      return;
    this.InitializePurchasing();
  }

  public void InitializePurchasing()
  {
    if (this.IsInitialized())
      return;
    ConfigurationBuilder builder = ConfigurationBuilder.Instance((IPurchasingModule) StandardPurchasingModule.Instance());
    builder.AddProduct(Purchaser.kIDFeaturePackage, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleNonCSFeaturePackage,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleNonCSFeaturePackage,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDMagicalPackage, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleNonCSMagicalPacakage,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleNonCSMagicalPacakage,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDTotalPackage, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleNonCSTotalPackage,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleNonCSTotalPackage,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDFirst660, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleCSFirst660,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSFirst660,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDFirst1100, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleCSFirst1100,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSFirst1100,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDFirst2400, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleCSFirst2400,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSFirst2400,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDFirst8400, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleCSFirst8400,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSFirst8400,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDFirst18000, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleCSFirst18000,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSFirst18000,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDStone330, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleCSStone330,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSStone330,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDStone550, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleCSStone550,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSStone550,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDStone1200, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleCSStone1200,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSStone1200,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDStone4200, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleCSStone4200,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSStone4200,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDStone9000, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleCSStone9000,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleCSStone9000,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRemoveAds, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleNonCSRemoveAds,
        new string[1]{ "GooglePlay" }
      }
    });
    builder.AddProduct(Purchaser.kIDAutoPackage, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleAutoPackage,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleAutoPackage,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRingPackage, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleRingPackage,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRingPackage,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyFirst180, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyFirst180,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyFirst180,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyFirst300, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyFirst300,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyFirst300,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyFirst660, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyFirst660,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyFirst660,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyFirst2160, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyFirst2160,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyFirst2160,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyFirst4200, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyFirst4200,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyFirst4200,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyRepeat90, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyRepeat90,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyRepeat90,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyRepeat150, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyRepeat150,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyRepeat150,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyRepeat330, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyRepeat330,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyRepeat330,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyRepeat1080, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyRepeat1080,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyRepeat1080,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDRubyRepeat2100, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleRubyRepeat2100,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleRubyRepeat2100,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDAwakenPackage, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleAwakenPackage,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleAwakenPackage,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDHellPackage, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleHellPackage,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleHellPackage,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDSuccubusPackage, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleSuccubusPackage,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleSuccubusPackage,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDHellFirst60, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleHellFirst60,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleHellFirst60,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDHellFirst240, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleHellFirst240,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleHellFirst240,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDHellFirst500, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleHellFirst500,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleHellFirst500,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDHellRepeat30, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleHellRepeat30,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleHellRepeat30,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDHellRepeat120, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleHellRepeat120,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleHellRepeat120,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDHellRepeat250, ProductType.Consumable, new IDs()
    {
      {
        Purchaser.kGoogleHellRepeat250,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleHellRepeat250,
        new string[1]{ "AppleAppStore" }
      }
    });
    builder.AddProduct(Purchaser.kIDElementalPackage, ProductType.NonConsumable, new IDs()
    {
      {
        Purchaser.kGoogleElementalPackage,
        new string[1]{ "GooglePlay" }
      },
      {
        Purchaser.kGoogleElementalPackage,
        new string[1]{ "AppleAppStore" }
      }
    });
    UnityPurchasing.Initialize((IStoreListener) this, builder);
  }

  private bool IsInitialized()
  {
    if (Purchaser.m_StoreController != null)
      return Purchaser.m_StoreExtensionProvider != null;
    return false;
  }

  public void BuyProductByShopID(ShopID eID)
  {
    if ((bool) Info.rebirth.bVIP)
      Debug.LogError((object) "VIP Try to purchase products");
    else
      this.BuyProductID(this.GetIDFromShopID(eID));
  }

  public string GetIDFromShopID(ShopID eID)
  {
    switch (eID)
    {
      case ShopID.eFeaturePackage:
        return Purchaser.kIDFeaturePackage;
      case ShopID.eMagicalPackage:
        return Purchaser.kIDMagicalPackage;
      case ShopID.eTotalPackage:
        return Purchaser.kIDTotalPackage;
      case ShopID.eFirst660:
        return Purchaser.kIDFirst660;
      case ShopID.eFirst1100:
        return Purchaser.kIDFirst1100;
      case ShopID.eFirst2400:
        return Purchaser.kIDFirst2400;
      case ShopID.eFirst8400:
        return Purchaser.kIDFirst8400;
      case ShopID.eFirst18000:
        return Purchaser.kIDFirst18000;
      case ShopID.eRepeat330:
        return Purchaser.kIDStone330;
      case ShopID.eRepeat550:
        return Purchaser.kIDStone550;
      case ShopID.eRepeat1200:
        return Purchaser.kIDStone1200;
      case ShopID.eRepeat4200:
        return Purchaser.kIDStone4200;
      case ShopID.eRepeat9000:
        return Purchaser.kIDStone9000;
      case ShopID.eRemoveAds:
        return Purchaser.kIDRemoveAds;
      case ShopID.eAutoPackage:
        return Purchaser.kIDAutoPackage;
      case ShopID.eRingPackage:
        return Purchaser.kIDRingPackage;
      case ShopID.eRubyF180:
        return Purchaser.kIDRubyFirst180;
      case ShopID.eRubyF300:
        return Purchaser.kIDRubyFirst300;
      case ShopID.eRubyF660:
        return Purchaser.kIDRubyFirst660;
      case ShopID.eRubyF2160:
        return Purchaser.kIDRubyFirst2160;
      case ShopID.eRubyF4200:
        return Purchaser.kIDRubyFirst4200;
      case ShopID.eRubyR90:
        return Purchaser.kIDRubyRepeat90;
      case ShopID.eRubyR150:
        return Purchaser.kIDRubyRepeat150;
      case ShopID.eRubyR330:
        return Purchaser.kIDRubyRepeat330;
      case ShopID.eRubyR1080:
        return Purchaser.kIDRubyRepeat1080;
      case ShopID.eRubyR2100:
        return Purchaser.kIDRubyRepeat2100;
      case ShopID.eAwakenPackage:
        return Purchaser.kIDAwakenPackage;
      case ShopID.eHellPackage:
        return Purchaser.kIDHellPackage;
      case ShopID.eSuccubusPackage:
        return Purchaser.kIDSuccubusPackage;
      case ShopID.eHellF60:
        return Purchaser.kIDHellFirst60;
      case ShopID.eHellF240:
        return Purchaser.kIDHellFirst240;
      case ShopID.eHellF500:
        return Purchaser.kIDHellFirst500;
      case ShopID.eHellR30:
        return Purchaser.kIDHellRepeat30;
      case ShopID.eHellR120:
        return Purchaser.kIDHellRepeat120;
      case ShopID.eHellR250:
        return Purchaser.kIDHellRepeat250;
      case ShopID.eElementalPackage:
        return Purchaser.kIDElementalPackage;
      default:
        return string.Empty;
    }
  }

  public void BuyNonConsumable()
  {
  }

  public void BuySubscription()
  {
  }

  private void BuyProductID(string productId)
  {
    try
    {
      if (this.IsInitialized())
      {
        Product product = Purchaser.m_StoreController.products.WithID(productId);
        if (product != null && product.availableToPurchase)
        {
          Debug.Log((object) string.Format("Purchasing product asychronously: '{0}'", (object) product.definition.id));
          Purchaser.m_StoreController.InitiatePurchase(product);
        }
        else
          Debug.Log((object) "BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
      }
      else
        Debug.Log((object) "BuyProductID FAIL. Not initialized.");
    }
    catch (Exception ex)
    {
      Debug.Log((object) ("BuyProductID: FAIL. Exception during purchase. " + (object) ex));
    }
  }

  public string GetProductPrice(ShopID eID)
  {
    if (this.IsInitialized())
      return Purchaser.m_StoreController.products.WithID(this.GetIDFromShopID(eID)).metadata.localizedPriceString;
    return "Error";
  }

  public void RestorePurchases()
  {
    if (!this.IsInitialized())
      Debug.Log((object) "RestorePurchases FAIL. Not initialized.");
    else if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.OSXPlayer)
    {
      Debug.Log((object) "RestorePurchases started ...");
      Purchaser.m_StoreExtensionProvider.GetExtension<IAppleExtensions>().RestoreTransactions((Action<bool>) (result => Debug.Log((object) ("RestorePurchases continuing: " + (object) result + ". If no further messages, no purchases available to restore."))));
    }
    else
      Debug.Log((object) ("RestorePurchases FAIL. Not supported on this platform. Current = " + (object) Application.platform));
  }

  public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
  {
    Debug.Log((object) "OnInitialized: PASS");
    Purchaser.m_StoreController = controller;
    Purchaser.m_StoreExtensionProvider = extensions;
  }

  public void OnInitializeFailed(InitializationFailureReason error)
  {
    Debug.Log((object) ("OnInitializeFailed InitializationFailureReason:" + (object) error));
  }

  public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
  {
    bool flag = true;
    CrossPlatformValidator platformValidator = new CrossPlatformValidator(GooglePlayTangle.Data(), AppleTangle.Data(), Application.identifier);
    try
    {
      IPurchaseReceipt[] purchaseReceiptArray = platformValidator.Validate(args.purchasedProduct.receipt);
      Debug.Log((object) "Receipt is valid. Contents:");
      foreach (IPurchaseReceipt purchaseReceipt in purchaseReceiptArray)
      {
        Debug.Log((object) purchaseReceipt.productID);
        Debug.Log((object) purchaseReceipt.purchaseDate);
        Debug.Log((object) purchaseReceipt.transactionID);
      }
    }
    catch (IAPSecurityException ex)
    {
      Debug.Log((object) "Invalid receipt, not unlocking content");
      flag = false;
    }
    if (flag)
      this.RealProcess(args.purchasedProduct.definition.id);
    return PurchaseProcessingResult.Complete;
  }

  protected void RealProcess(string strID)
  {
    if (string.Equals(strID, Purchaser.kIDFeaturePackage, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eFeaturePackage))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eFeaturePackage);
        if (Info.CheckRebirth(RebirthID.eDoubleSpeed))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eDoubleSpeed).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eDoubleSpeed, 1);
        if (Info.CheckRebirth(RebirthID.eAutoBattle))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eAutoBattle).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoBattle, 1);
        if (Info.CheckRebirth(RebirthID.eWaveRush))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eWaveRush).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eWaveRush, 1);
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eFeaturePackage).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDMagicalPackage, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eMagicalPackage))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eMagicalPackage);
        if (Info.CheckRebirth(RebirthID.eMagicalGirl))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eMagicalGirl).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eMagicalGirl, 1);
        if (Info.CheckRebirth(RebirthID.eDoubleSpeed))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eDoubleSpeed).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eDoubleSpeed, 1);
        if (Info.CheckRebirth(RebirthID.eAutoBattle))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eAutoBattle).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoBattle, 1);
        if (Info.CheckRebirth(RebirthID.eWaveRush))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eWaveRush).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eWaveRush, 1);
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eMagicalPackage).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDTotalPackage, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eTotalPackage))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eTotalPackage);
        if (Info.CheckRebirth(RebirthID.eMagicalGirl))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eMagicalGirl).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eMagicalGirl, 1);
        if (Info.CheckRebirth(RebirthID.eDoubleSpeed))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eDoubleSpeed).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eDoubleSpeed, 1);
        if (Info.CheckRebirth(RebirthID.eAutoBattle))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eAutoBattle).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoBattle, 1);
        if (Info.CheckRebirth(RebirthID.eWaveRush))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eWaveRush).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eWaveRush, 1);
        SavedRebirth rebirth1 = Info.rebirth;
        ObscuredLong obscuredLong1 = (ObscuredLong) ((long) rebirth1.nNewStone + 3000L);
        rebirth1.nNewStone = obscuredLong1;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eTotalPackage).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDFirst660, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eFirst660))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eFirst660);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 660L);
        rebirth.nNewStone = obscuredLong;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eFirst660).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDFirst1100, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eFirst1100))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eFirst1100);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 1100L);
        rebirth.nNewStone = obscuredLong;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eFirst1100).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDFirst2400, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eFirst2400))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eFirst2400);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 2400L);
        rebirth.nNewStone = obscuredLong;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eFirst2400).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDFirst8400, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eFirst8400))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eFirst8400);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 8400L);
        rebirth.nNewStone = obscuredLong;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eFirst8400).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDFirst18000, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eFirst18000))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eFirst18000);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 18000L);
        rebirth.nNewStone = obscuredLong;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eFirst18000).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDStone330, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRepeat330);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 330L);
      rebirth.nNewStone = obscuredLong;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
        PopupRebirth.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRepeat330).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDStone550, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRepeat550);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 550L);
      rebirth.nNewStone = obscuredLong;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
        PopupRebirth.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRepeat550).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDStone1200, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRepeat1200);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 1200L);
      rebirth.nNewStone = obscuredLong;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
        PopupRebirth.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRepeat1200).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDStone4200, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRepeat4200);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 4200L);
      rebirth.nNewStone = obscuredLong;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
        PopupRebirth.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRepeat4200).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDStone9000, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRepeat9000);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + 9000L);
      rebirth.nNewStone = obscuredLong;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
        PopupRebirth.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRepeat9000).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDRemoveAds, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eRemoveAds))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eRemoveAds);
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRemoveAds).strName)).Replace("[2]", BData.GetString("UI0227")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDAutoPackage, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eAutoPackage))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eAutoPackage);
        if (Info.CheckRebirth(RebirthID.eStoneStatMax))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eStoneStatMax).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eStoneStatMax, 1);
        if (Info.CheckRebirth(RebirthID.eAutoItemSell))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoItemSell).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoItemSell, 1);
        if (Info.CheckRebirth(RebirthID.eAutoEnchant))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoEnchant).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoEnchant, 1);
        if (Info.CheckRebirth(RebirthID.eAutoResearch))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoResearch).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoResearch, 1);
        if (Info.CheckRebirth(RebirthID.eAutoRepair))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoRepair).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoRepair, 1);
        if (Info.CheckRebirth(RebirthID.eAutoSkillSelect))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoSkillSelect).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoSkillSelect, 1);
        if (Info.CheckRebirth(RebirthID.eAutoActiveSkill))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoActiveSkill).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoActiveSkill, 1);
        if (Info.CheckRebirth(RebirthID.eAutoBattle))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eAutoBattle).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoBattle, 1);
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
          PopupRubyShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eAutoPackage).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDRingPackage, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eRingPackage))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eRingPackage);
        if (Info.CheckRebirth(RebirthID.eStoneStatMax))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eStoneStatMax).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eStoneStatMax, 1);
        if (Info.CheckRebirth(RebirthID.eAutoItemSell))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoItemSell).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoItemSell, 1);
        if (Info.CheckRebirth(RebirthID.eAutoEnchant))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoEnchant).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoEnchant, 1);
        if (Info.CheckRebirth(RebirthID.eAutoResearch))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoResearch).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoResearch, 1);
        if (Info.CheckRebirth(RebirthID.eAutoRepair))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoRepair).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoRepair, 1);
        if (Info.CheckRebirth(RebirthID.eAutoSkillSelect))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoSkillSelect).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoSkillSelect, 1);
        if (Info.CheckRebirth(RebirthID.eAutoActiveSkill))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eAutoActiveSkill).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoActiveSkill, 1);
        if (Info.CheckRebirth(RebirthID.eRingUnlock))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(RebirthID.eRingUnlock).nCost);
          rebirth.nRuby = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eRingUnlock, 1);
        if (Info.CheckRebirth(RebirthID.eAutoBattle))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredLong obscuredLong = (ObscuredLong) ((long) rebirth.nNewStone + (long) BData.GetRebirth(RebirthID.eAutoBattle).nCost);
          rebirth.nNewStone = obscuredLong;
        }
        else
          Info.UpgRebirth(RebirthID.eAutoBattle, 1);
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
          PopupRubyShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRingPackage).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDRubyFirst180, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eRubyF180))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eRubyF180);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 180);
        rebirth.nRuby = obscuredInt;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
          PopupRubyShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyF180).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDRubyFirst300, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eRubyF300))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eRubyF300);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 300);
        rebirth.nRuby = obscuredInt;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
          PopupRubyShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyF300).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDRubyFirst660, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eRubyF660))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eRubyF660);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 660);
        rebirth.nRuby = obscuredInt;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
          PopupRubyShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyF660).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDRubyFirst2160, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eRubyF2160))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eRubyF2160);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 2160);
        rebirth.nRuby = obscuredInt;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
          PopupRubyShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyF2160).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDRubyFirst4200, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eRubyF4200))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eRubyF4200);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 4200);
        rebirth.nRuby = obscuredInt;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
          PopupRubyShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyF4200).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDRubyRepeat90, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRubyR90);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 90);
      rebirth.nRuby = obscuredInt;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
        PopupRubyShop.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyR90).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDRubyRepeat150, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRubyR150);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 150);
      rebirth.nRuby = obscuredInt;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
        PopupRubyShop.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyR150).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDRubyRepeat330, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRubyR330);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 330);
      rebirth.nRuby = obscuredInt;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
        PopupRubyShop.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyR330).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDRubyRepeat1080, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRubyR1080);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 1080);
      rebirth.nRuby = obscuredInt;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
        PopupRubyShop.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyR1080).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDRubyRepeat2100, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eRubyR2100);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + 2100);
      rebirth.nRuby = obscuredInt;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
        PopupRubyShop.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eRubyR2100).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDAwakenPackage, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eAwakenPackage))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eAwakenPackage);
        List<RebirthID> rebirthIdList = new List<RebirthID>();
        rebirthIdList.Add(RebirthID.eSkeletonAwk);
        rebirthIdList.Add(RebirthID.eGoblinAwk);
        rebirthIdList.Add(RebirthID.eOgreAwk);
        rebirthIdList.Add(RebirthID.eOrcAwk);
        rebirthIdList.Add(RebirthID.eSlimeAwk);
        rebirthIdList.Add(RebirthID.eWraithAwk);
        rebirthIdList.Add(RebirthID.eSnakeAwk);
        rebirthIdList.Add(RebirthID.eSwordAwk);
        rebirthIdList.Add(RebirthID.eSummonerAwk);
        rebirthIdList.Add(RebirthID.eMagicalGirlAwk);
        rebirthIdList.Add(RebirthID.eDarkKnightAwk);
        rebirthIdList.Add(RebirthID.eEyeAwk);
        rebirthIdList.Add(RebirthID.eSoulAwk);
        rebirthIdList.Add(RebirthID.eBladeAwk);
        rebirthIdList.Add(RebirthID.eSuccubusAwk);
        rebirthIdList.Add(RebirthID.eFireAwk);
        rebirthIdList.Add(RebirthID.eWaterAwk);
        rebirthIdList.Add(RebirthID.eNatureAwk);
        rebirthIdList.Add(RebirthID.eLightAwk);
        rebirthIdList.Add(RebirthID.eDarkAwk);
        for (int index = 0; index < rebirthIdList.Count; ++index)
        {
          if (Info.CheckRebirth(rebirthIdList[index]))
          {
            SavedRebirth rebirth = Info.rebirth;
            ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nRuby + BData.GetRebirth(rebirthIdList[index]).nCost);
            rebirth.nRuby = obscuredInt;
          }
          else
            Info.UpgRebirth(rebirthIdList[index], 1);
        }
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRubyShop.obj))
          PopupRubyShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eAwakenPackage).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDHellPackage, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eHellPackage))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eHellPackage);
        if (Info.CheckRebirth(RebirthID.ePreventModFail))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.ePreventModFail).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.ePreventModFail, 1);
        if (Info.CheckRebirth(RebirthID.eEnchantManage))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.eEnchantManage).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eEnchantManage, 1);
        if (Info.CheckRebirth(RebirthID.eItemEnchantPlus))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.eItemEnchantPlus).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eItemEnchantPlus, 1);
        if (Info.CheckRebirth(RebirthID.eAIBuilder))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.eAIBuilder).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAIBuilder, 1);
        if (Info.CheckRebirth(RebirthID.eQuickBattleOver))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.eQuickBattleOver).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eQuickBattleOver, 1);
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupHellShop.obj))
          PopupHellShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eHellPackage).strName)).Replace("[2]", BData.GetString("UI0338")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDSuccubusPackage, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eSuccubusPackage))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eSuccubusPackage);
        if (Info.CheckRebirth(RebirthID.eSuccubus))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.eSuccubus).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eSuccubus, 1);
        if (Info.CheckRebirth(RebirthID.ePreventModFail))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.ePreventModFail).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.ePreventModFail, 1);
        if (Info.CheckRebirth(RebirthID.eEnchantManage))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.eEnchantManage).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eEnchantManage, 1);
        if (Info.CheckRebirth(RebirthID.eItemEnchantPlus))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.eItemEnchantPlus).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eItemEnchantPlus, 1);
        if (Info.CheckRebirth(RebirthID.eAIBuilder))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.eAIBuilder).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eAIBuilder, 1);
        if (Info.CheckRebirth(RebirthID.eQuickBattleOver))
        {
          SavedRebirth rebirth = Info.rebirth;
          ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + BData.GetRebirth(RebirthID.eQuickBattleOver).nCost);
          rebirth.nHell = obscuredInt;
        }
        else
          Info.UpgRebirth(RebirthID.eQuickBattleOver, 1);
        SavedRebirth rebirth1 = Info.rebirth;
        ObscuredInt obscuredInt1 = (ObscuredInt) ((int) rebirth1.nHell + 200);
        rebirth1.nHell = obscuredInt1;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupHellShop.obj))
          PopupHellShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eSuccubusPackage).strName)).Replace("[2]", BData.GetString("UI0338")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDHellFirst60, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eHellF60))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eHellF60);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + 60);
        rebirth.nHell = obscuredInt;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupHellShop.obj))
          PopupHellShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eHellF60).strName)).Replace("[2]", BData.GetString("UI0338")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDHellFirst240, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eHellF240))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eHellF240);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + 240);
        rebirth.nHell = obscuredInt;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupHellShop.obj))
          PopupHellShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eHellF240).strName)).Replace("[2]", BData.GetString("UI0338")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDHellFirst500, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eHellF500))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eHellF500);
        SavedRebirth rebirth = Info.rebirth;
        ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + 500);
        rebirth.nHell = obscuredInt;
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupHellShop.obj))
          PopupHellShop.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eHellF500).strName)).Replace("[2]", BData.GetString("UI0338")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else if (string.Equals(strID, Purchaser.kIDHellRepeat30, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eHellR30);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + 30);
      rebirth.nHell = obscuredInt;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupHellShop.obj))
        PopupHellShop.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eHellR30).strName)).Replace("[2]", BData.GetString("UI0338")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDHellRepeat120, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eHellR120);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + 120);
      rebirth.nHell = obscuredInt;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupHellShop.obj))
        PopupHellShop.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eHellR120).strName)).Replace("[2]", BData.GetString("UI0338")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDHellRepeat250, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      Info.rebirth.listPurchase.Add(ShopID.eHellR250);
      SavedRebirth rebirth = Info.rebirth;
      ObscuredInt obscuredInt = (ObscuredInt) ((int) rebirth.nHell + 250);
      rebirth.nHell = obscuredInt;
      SaveManager.SaveRebirth();
      if ((bool) ((UnityEngine.Object) PopupHellShop.obj))
        PopupHellShop.obj.RefreshFromPurchase();
      UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eHellR250).strName)).Replace("[2]", BData.GetString("UI0338")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
    }
    else if (string.Equals(strID, Purchaser.kIDElementalPackage, StringComparison.Ordinal))
    {
      Debug.Log((object) string.Format("ProcessPurchase: PASS. Product: '{0}'", (object) strID));
      if (Info.rebirth.listPurchase.Contains(ShopID.eElementalPackage))
      {
        Debug.Log((object) ("Already Have" + strID));
      }
      else
      {
        Info.rebirth.listPurchase.Add(ShopID.eElementalPackage);
        if (!Info.CheckElementalTrait(ElementalID.eFireBase1))
          Info.UpgElementalTrait(ElementalID.eFireBase1);
        if (!Info.CheckElementalTrait(ElementalID.eWaterBase1))
          Info.UpgElementalTrait(ElementalID.eWaterBase1);
        if (!Info.CheckElementalTrait(ElementalID.eNatureBase1))
          Info.UpgElementalTrait(ElementalID.eNatureBase1);
        if (!Info.CheckElementalTrait(ElementalID.eLightBase1))
          Info.UpgElementalTrait(ElementalID.eLightBase1);
        if (!Info.CheckElementalTrait(ElementalID.eDarkBase1))
          Info.UpgElementalTrait(ElementalID.eDarkBase1);
        if (!Info.CheckRebirth(RebirthID.eFireDungeon))
          Info.UpgRebirth(RebirthID.eFireDungeon, 1);
        if (!Info.CheckRebirth(RebirthID.eWaterDungeon))
          Info.UpgRebirth(RebirthID.eWaterDungeon, 1);
        if (!Info.CheckRebirth(RebirthID.eNatureDungeon))
          Info.UpgRebirth(RebirthID.eNatureDungeon, 1);
        if (!Info.CheckRebirth(RebirthID.eLightDungeon))
          Info.UpgRebirth(RebirthID.eLightDungeon, 1);
        if (!Info.CheckRebirth(RebirthID.eDarkDungeon))
          Info.UpgRebirth(RebirthID.eDarkDungeon, 1);
        if (!Info.CheckElementalTrait(ElementalID.eFireSeed))
        {
          Info.UpgElementalTrait(ElementalID.eFireSeed);
          Info.AddElementalExp(1, Info.GetElementalAllExp(1)[3]);
        }
        if (!Info.CheckElementalTrait(ElementalID.eWaterSeed))
        {
          Info.UpgElementalTrait(ElementalID.eWaterSeed);
          Info.AddElementalExp(2, Info.GetElementalAllExp(2)[3]);
        }
        if (!Info.CheckElementalTrait(ElementalID.eNatureSeed))
        {
          Info.UpgElementalTrait(ElementalID.eNatureSeed);
          Info.AddElementalExp(3, Info.GetElementalAllExp(3)[3]);
        }
        if (!Info.CheckElementalTrait(ElementalID.eLightSeed))
        {
          Info.UpgElementalTrait(ElementalID.eLightSeed);
          Info.AddElementalExp(4, Info.GetElementalAllExp(4)[3]);
        }
        if (!Info.CheckElementalTrait(ElementalID.eDarkSeed))
        {
          Info.UpgElementalTrait(ElementalID.eDarkSeed);
          Info.AddElementalExp(5, Info.GetElementalAllExp(5)[3]);
        }
        SaveManager.SaveRebirth();
        if ((bool) ((UnityEngine.Object) PopupRebirth.obj))
          PopupRebirth.obj.RefreshFromPurchase();
        UIMgr.popupMsg.SetMsg(BData.GetString("UI0197").Replace("[1]", BData.GetString(BData.GetShop(ShopID.eElementalPackage).strName)).Replace("[2]", BData.GetString("UI0282")) + "\n\n" + BData.GetString("UI0331"), true, false, string.Empty);
      }
    }
    else
      Debug.Log((object) string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", (object) strID));
  }

  public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
  {
    Debug.Log((object) string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", (object) product.definition.storeSpecificId, (object) failureReason));
  }
}
