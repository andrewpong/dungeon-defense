// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.SingleLineClampAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
