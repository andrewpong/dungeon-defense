// Decompiled with JetBrains decompiler
// Type: DungeonElt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CC;
using UnityEngine;
using UnityEngine.UI;

public class DungeonElt : MonoBehaviour
{
  public Image imgIcon;
  public Button btnBuild;
  public Button btnBuild10;
  public Text textName;
  public Text textDesc;
  public Text textGold;
  public Text textLevel;
  public Text textBuild;
  public Text textBuild10;
  private DungeonType eID;

  public void Refresh(DungeonType _eID)
  {
    this.eID = _eID;
    DungeonData dungeon1 = BData.GetDungeon(this.eID);
    int dungeon2 = Info.GetDungeon(this.eID);
    int costDungeon = Info.GetCostDungeon(this.eID, 1);
    int nNum = Mathf.Min(dungeon1.nMax - dungeon2, 10);
    bool flag1 = Info.CanUpgDungeon(this.eID, 1);
    bool flag2 = Info.CanUpgDungeon(this.eID, nNum);
    bool flag3 = dungeon2 >= dungeon1.nMax;
    float dungeonFactor1 = Info.GetDungeonFactor(this.eID, dungeon2);
    float dungeonFactor2 = Info.GetDungeonFactor(this.eID, dungeon2 + 1);
    this.imgIcon.sprite = RSMgr.GetSprite(dungeon1.strIcon);
    this.textName.text = BData.GetString(dungeon1.strName);
    this.textLevel.text = "Lv." + dungeon2.ToString("###0") + "\nMax." + dungeon1.nMax.ToString();
    this.textDesc.text = BData.GetString(dungeon1.strDesc).Replace("[1]", dungeonFactor1.ToString("###0.##")) + "\n( " + (!flag3 ? BData.GetString("UI0031") + " : " + dungeonFactor2.ToString("###0.##") : BData.GetString("UI0032")) + " )";
    this.textBuild.text = BData.GetString("UI0030");
    this.textBuild10.text = BData.GetString("UI0030") + "x" + nNum.ToString();
    this.textGold.text = !flag3 ? costDungeon.ToString("N0") + " G" : string.Empty;
    this.btnBuild.interactable = flag1;
    this.btnBuild10.interactable = flag2;
  }

  public void OnBuild()
  {
    PageLobby.obj.OnDungeonBuild(this.eID, 1);
  }

  public void OnBuildMulti()
  {
    int nNum = Mathf.Min(BData.GetDungeon(this.eID).nMax - Info.GetDungeon(this.eID), 10);
    PageLobby.obj.OnDungeonBuild(this.eID, nNum);
  }
}
