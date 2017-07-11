// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.FetchResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class FetchResponse : BaseReferenceHolder
  {
    internal FetchResponse(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_Dispose(this.SelfPtr());
    }

    internal NativeLeaderboard Leaderboard()
    {
      return NativeLeaderboard.FromPointer(GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_GetData(this.SelfPtr()));
    }

    internal CommonErrorStatus.ResponseStatus GetStatus()
    {
      return GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_GetStatus(this.SelfPtr());
    }

    internal static FetchResponse FromPointer(IntPtr pointer)
    {
      if (pointer.Equals((object) IntPtr.Zero))
        return (FetchResponse) null;
      return new FetchResponse(pointer);
    }
  }
}
