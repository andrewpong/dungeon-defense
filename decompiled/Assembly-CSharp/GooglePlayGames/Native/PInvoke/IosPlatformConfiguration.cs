// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.IosPlatformConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal sealed class IosPlatformConfiguration : PlatformConfiguration
  {
    private IosPlatformConfiguration(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    internal void SetClientId(string clientId)
    {
      Misc.CheckNotNull<string>(clientId);
      GooglePlayGames.Native.Cwrapper.IosPlatformConfiguration.IosPlatformConfiguration_SetClientID(this.SelfPtr(), clientId);
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      GooglePlayGames.Native.Cwrapper.IosPlatformConfiguration.IosPlatformConfiguration_Dispose(selfPointer);
    }

    internal static IosPlatformConfiguration Create()
    {
      return new IosPlatformConfiguration(GooglePlayGames.Native.Cwrapper.IosPlatformConfiguration.IosPlatformConfiguration_Construct());
    }
  }
}
