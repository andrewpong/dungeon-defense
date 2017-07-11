// Decompiled with JetBrains decompiler
// Type: Thinksquirrel.CShake.Internal.CameraShakeDocumentationName
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;

namespace Thinksquirrel.CShake.Internal
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
  public sealed class CameraShakeDocumentationName : Attribute
  {
    private string m_Name;

    public string name
    {
      get
      {
        return this.m_Name;
      }
    }

    public CameraShakeDocumentationName(string name)
    {
      this.m_Name = name;
    }
  }
}
