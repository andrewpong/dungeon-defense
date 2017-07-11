// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.SingleLineClampAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

namespace DigitalRuby.ThunderAndLightning
{
  public class SingleLineClampAttribute : SingleLineAttribute
  {
    public double MinValue { get; private set; }

    public double MaxValue { get; private set; }

    public SingleLineClampAttribute(string tooltip, double minValue, double maxValue)
      : base(tooltip)
    {
      this.MinValue = minValue;
      this.MaxValue = maxValue;
    }
  }
}
