using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x0200033F RID: 831
[Token(Token = "0x200028A")]
public class PopupBatch : UIPage
{
	// Token: 0x060014B6 RID: 5302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x372304", Offset = "0x372304", VA = "0x6372304")]
	public PopupBatch()
	{
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001277")]
	[Address(RVA = "0x37230C", Offset = "0x37230C", VA = "0x637230C", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001278")]
	[Address(RVA = "0x3729AC", Offset = "0x3729AC", VA = "0x63729AC", Slot = "6")]
	protected override void Update()
	{
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001279")]
	[Address(RVA = "0x372B24", Offset = "0x372B24", VA = "0x6372B24")]
	public void OnChangeDown(int nPos)
	{
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600127A")]
	[Address(RVA = "0x372E4C", Offset = "0x372E4C", VA = "0x6372E4C")]
	public void OnChangeUp(int nPos)
	{
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600127B")]
	[Address(RVA = "0x372BD0", Offset = "0x372BD0", VA = "0x6372BD0")]
	private void ChangePos(int nPre, int nNext)
	{
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600127C")]
	[Address(RVA = "0x3723E0", Offset = "0x3723E0", VA = "0x63723E0")]
	private void RefreshImage()
	{
	}

	// Token: 0x060014BD RID: 5309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600127D")]
	[Address(RVA = "0x372AA8", Offset = "0x372AA8", VA = "0x6372AA8")]
	public void OnClose()
	{
	}

	// Token: 0x04001303 RID: 4867
	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0x1C")]
	public Image[] imgMon;

	// Token: 0x04001304 RID: 4868
	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x20")]
	public Image[] imgDown;

	// Token: 0x04001305 RID: 4869
	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0x24")]
	public Image[] imgUp;

	// Token: 0x04001306 RID: 4870
	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0x28")]
	public Text textTitle;
}
