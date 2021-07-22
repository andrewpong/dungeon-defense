using System;
using CC;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000367 RID: 871
[Token(Token = "0x20002AD")]
public class SaveManager : MonoBehaviour
{
	// Token: 0x0600164B RID: 5707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F9")]
	[Address(RVA = "0xC9D20C", Offset = "0xC9D20C", VA = "0x6C9D20C")]
	public SaveManager()
	{
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FA")]
	[Address(RVA = "0xC9D214", Offset = "0xC9D214", VA = "0x6C9D214")]
	private void Awake()
	{
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FB")]
	[Address(RVA = "0xC9D2C0", Offset = "0xC9D2C0", VA = "0x6C9D2C0")]
	public static void Save()
	{
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FC")]
	[Address(RVA = "0xC9D430", Offset = "0xC9D430", VA = "0x6C9D430")]
	public static void Save(byte bySlot)
	{
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x000087A8 File Offset: 0x000069A8
	[Token(Token = "0x60013FD")]
	[Address(RVA = "0xC9D7E4", Offset = "0xC9D7E4", VA = "0x6C9D7E4")]
	public static bool SaveBak(byte bySlot)
	{
		return default(bool);
	}

	// Token: 0x06001650 RID: 5712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FE")]
	[Address(RVA = "0xC9D7EC", Offset = "0xC9D7EC", VA = "0x6C9D7EC")]
	public static void SaveOption()
	{
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FF")]
	[Address(RVA = "0xC9DB44", Offset = "0xC9DB44", VA = "0x6C9DB44")]
	public static void SaveAchievement()
	{
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001400")]
	[Address(RVA = "0xC998E4", Offset = "0xC998E4", VA = "0x6C998E4")]
	public static void SaveRebirth()
	{
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001401")]
	[Address(RVA = "0xC9DE9C", Offset = "0xC9DE9C", VA = "0x6C9DE9C")]
	public static SavedData Load(byte bySlot)
	{
		return null;
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001402")]
	[Address(RVA = "0xC9F938", Offset = "0xC9F938", VA = "0x6C9F938")]
	public static void LoadOption()
	{
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001403")]
	[Address(RVA = "0xCA0364", Offset = "0xCA0364", VA = "0x6CA0364")]
	public static void LoadAchievement()
	{
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001404")]
	[Address(RVA = "0xCA0B10", Offset = "0xCA0B10", VA = "0x6CA0B10")]
	public static void LoadRebirth()
	{
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001405")]
	[Address(RVA = "0xCA159C", Offset = "0xCA159C", VA = "0x6CA159C")]
	private static void CheckRebirthInit()
	{
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001406")]
	[Address(RVA = "0xCA2984", Offset = "0xCA2984", VA = "0x6CA2984")]
	public static byte[] GetSaveData()
	{
		return null;
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001407")]
	[Address(RVA = "0xCA2C64", Offset = "0xCA2C64", VA = "0x6CA2C64")]
	public static void GetLoadData(byte[] bytes)
	{
	}

	// Token: 0x0400157C RID: 5500
	[Token(Token = "0x400129A")]
	[FieldOffset(Offset = "0x0")]
	public static SaveManager obj;
}
