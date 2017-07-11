// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.FetchResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
