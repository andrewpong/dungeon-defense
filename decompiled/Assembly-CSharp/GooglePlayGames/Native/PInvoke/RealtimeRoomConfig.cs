// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.RealtimeRoomConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class RealtimeRoomConfig : BaseReferenceHolder
  {
    internal RealtimeRoomConfig(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      RealTimeRoomConfig.RealTimeRoomConfig_Dispose(selfPointer);
    }

    internal static RealtimeRoomConfig FromPointer(IntPtr selfPointer)
    {
      if (selfPointer.Equals((object) IntPtr.Zero))
        return (RealtimeRoomConfig) null;
      return new RealtimeRoomConfig(selfPointer);
    }
  }
}
