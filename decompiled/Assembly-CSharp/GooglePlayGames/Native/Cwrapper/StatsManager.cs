// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.StatsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class StatsManager
  {
    [DllImport("gpg")]
    internal static extern void StatsManager_FetchForPlayer(HandleRef self, Types.DataSource data_source, StatsManager.FetchForPlayerCallback callback, IntPtr callback_arg);

    [DllImport("gpg")]
    internal static extern void StatsManager_FetchForPlayerResponse_Dispose(HandleRef self);

    [DllImport("gpg")]
    internal static extern CommonErrorStatus.ResponseStatus StatsManager_FetchForPlayerResponse_GetStatus(HandleRef self);

    [DllImport("gpg")]
    internal static extern IntPtr StatsManager_FetchForPlayerResponse_GetData(HandleRef self);

    internal delegate void FetchForPlayerCallback(IntPtr arg0, IntPtr arg1);
  }
}
