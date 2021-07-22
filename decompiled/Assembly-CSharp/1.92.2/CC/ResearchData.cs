// Decompiled with JetBrains decompiler
// Type: CC.ResearchData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System.Collections.Generic;

namespace CC
{
  public class ResearchData
  {
    public ResearchID eID;
    public string strName;
    public string strDesc;
    public string strIcon;
    public float fFactor;
    public int nCost;
    public bool bRepeat;
    public List<ResearchID> listPre;
  }
}
