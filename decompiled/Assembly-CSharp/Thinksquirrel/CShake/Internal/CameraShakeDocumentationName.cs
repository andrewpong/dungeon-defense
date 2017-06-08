// Decompiled with JetBrains decompiler
// Type: Thinksquirrel.CShake.Internal.CameraShakeDocumentationName
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
