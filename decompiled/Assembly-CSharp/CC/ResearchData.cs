// Decompiled with JetBrains decompiler
// Type: CC.ResearchData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
