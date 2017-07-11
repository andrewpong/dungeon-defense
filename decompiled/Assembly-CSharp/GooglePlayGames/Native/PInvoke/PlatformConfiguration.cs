// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.PlatformConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal abstract class PlatformConfiguration : BaseReferenceHolder
  {
    protected PlatformConfiguration(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    internal HandleRef AsHandle()
    {
      return this.SelfPtr();
    }
  }
}
