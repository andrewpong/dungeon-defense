// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class FetchScoreSummaryResponse : BaseReferenceHolder
  {
    internal FetchScoreSummaryResponse(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummaryResponse_Dispose(selfPointer);
    }

    internal CommonErrorStatus.ResponseStatus GetStatus()
    {
      return GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummaryResponse_GetStatus(this.SelfPtr());
    }

    internal NativeScoreSummary GetScoreSummary()
    {
      return NativeScoreSummary.FromPointer(GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummaryResponse_GetData(this.SelfPtr()));
    }

    internal static FetchScoreSummaryResponse FromPointer(IntPtr pointer)
    {
      if (pointer.Equals((object) IntPtr.Zero))
        return (FetchScoreSummaryResponse) null;
      return new FetchScoreSummaryResponse(pointer);
    }
  }
}
