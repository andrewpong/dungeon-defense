// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.SingleLineAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class SingleLineAttribute : PropertyAttribute
  {
    public string Tooltip { get; private set; }

    public SingleLineAttribute(string tooltip)
    {
      this.Tooltip = tooltip;
    }
  }
}
