using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000366 RID: 870
[Token(Token = "0x20002AC")]
public class RSMgr : MonoBehaviour
{
	// Token: 0x06001640 RID: 5696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EE")]
	[Address(RVA = "0xC9A688", Offset = "0xC9A688", VA = "0x6C9A688")]
	public RSMgr()
	{
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EF")]
	[Address(RVA = "0xC9A890", Offset = "0xC9A890", VA = "0x6C9A890")]
	private void Awake()
	{
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F0")]
	[Address(RVA = "0xC9BFD8", Offset = "0xC9BFD8", VA = "0x6C9BFD8")]
	private void Start()
	{
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013F1")]
	[Address(RVA = "0xC9C0B8", Offset = "0xC9C0B8", VA = "0x6C9C0B8")]
	public static Sprite GetSprite(string strName)
	{
		return null;
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013F2")]
	[Address(RVA = "0xC9C238", Offset = "0xC9C238", VA = "0x6C9C238")]
	public static Texture GetTexture(string strName)
	{
		return null;
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013F3")]
	[Address(RVA = "0xC9C3B8", Offset = "0xC9C3B8", VA = "0x6C9C3B8")]
	public static GameObject GetPrefab(string strName)
	{
		return null;
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013F4")]
	[Address(RVA = "0xC9C538", Offset = "0xC9C538", VA = "0x6C9C538")]
	public static AudioClip GetAudio(string strName)
	{
		return null;
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013F5")]
	[Address(RVA = "0xC9C6B8", Offset = "0xC9C6B8", VA = "0x6C9C6B8")]
	public static Font GetFont(string strName)
	{
		return null;
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013F6")]
	[Address(RVA = "0xC9C794", Offset = "0xC9C794", VA = "0x6C9C794")]
	public static RuntimeAnimatorController GetController(string strName)
	{
		return null;
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013F7")]
	[Address(RVA = "0xC9C914", Offset = "0xC9C914", VA = "0x6C9C914")]
	public static RuntimeAnimatorController GetRandomController()
	{
		return null;
	}

	// Token: 0x04001568 RID: 5480
	[Token(Token = "0x4001286")]
	[FieldOffset(Offset = "0x0")]
	public static RSMgr single;

	// Token: 0x04001569 RID: 5481
	[Token(Token = "0x4001287")]
	[FieldOffset(Offset = "0x4")]
	public static bool created;

	// Token: 0x0400156A RID: 5482
	[Token(Token = "0x4001288")]
	[FieldOffset(Offset = "0x5")]
	public static bool loaded;

	// Token: 0x0400156B RID: 5483
	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0xC")]
	public List<Texture> listTexture;

	// Token: 0x0400156C RID: 5484
	[Token(Token = "0x400128A")]
	[FieldOffset(Offset = "0x10")]
	public List<Sprite> listUnitSprite;

	// Token: 0x0400156D RID: 5485
	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0x14")]
	public List<Sprite> listWeaponSprite;

	// Token: 0x0400156E RID: 5486
	[Token(Token = "0x400128C")]
	[FieldOffset(Offset = "0x18")]
	public List<Sprite> listSkillSprite;

	// Token: 0x0400156F RID: 5487
	[Token(Token = "0x400128D")]
	[FieldOffset(Offset = "0x1C")]
	public List<Sprite> listBGSprite;

	// Token: 0x04001570 RID: 5488
	[Token(Token = "0x400128E")]
	[FieldOffset(Offset = "0x20")]
	public List<Sprite> listGUISprite;

	// Token: 0x04001571 RID: 5489
	[Token(Token = "0x400128F")]
	[FieldOffset(Offset = "0x24")]
	public List<GameObject> listPrefab;

	// Token: 0x04001572 RID: 5490
	[Token(Token = "0x4001290")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> listEffect;

	// Token: 0x04001573 RID: 5491
	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0x2C")]
	public List<AudioClip> listAudio;

	// Token: 0x04001574 RID: 5492
	[Token(Token = "0x4001292")]
	[FieldOffset(Offset = "0x30")]
	public List<Font> listFont;

	// Token: 0x04001575 RID: 5493
	[Token(Token = "0x4001293")]
	[FieldOffset(Offset = "0x34")]
	public List<RuntimeAnimatorController> listController;

	// Token: 0x04001576 RID: 5494
	[Token(Token = "0x4001294")]
	[FieldOffset(Offset = "0x8")]
	protected static Dictionary<string, Texture> dicTexture;

	// Token: 0x04001577 RID: 5495
	[Token(Token = "0x4001295")]
	[FieldOffset(Offset = "0xC")]
	protected static Dictionary<string, Sprite> dicSprite;

	// Token: 0x04001578 RID: 5496
	[Token(Token = "0x4001296")]
	[FieldOffset(Offset = "0x10")]
	protected static Dictionary<string, GameObject> dicPrefab;

	// Token: 0x04001579 RID: 5497
	[Token(Token = "0x4001297")]
	[FieldOffset(Offset = "0x14")]
	protected static Dictionary<string, AudioClip> dicAudio;

	// Token: 0x0400157A RID: 5498
	[Token(Token = "0x4001298")]
	[FieldOffset(Offset = "0x18")]
	protected static Dictionary<string, Font> dicfont;

	// Token: 0x0400157B RID: 5499
	[Token(Token = "0x4001299")]
	[FieldOffset(Offset = "0x1C")]
	protected static Dictionary<string, RuntimeAnimatorController> dicController;
}
