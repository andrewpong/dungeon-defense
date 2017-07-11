// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeScoreSummary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativeScoreSummary : BaseReferenceHolder
  {
    internal NativeScoreSummary(IntPtr selfPtr)
      : base(selfPtr)
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      ScoreSummary.ScoreSummary_Dispose(selfPointer);
    }

    internal ulong ApproximateResults()
    {
      return ScoreSummary.ScoreSummary_ApproximateNumberOfScores(this.SelfPtr());
    }

    internal NativeScore LocalUserScore()
    {
      return NativeScore.FromPointer(ScoreSummary.ScoreSummary_CurrentPlayerScore(this.SelfPtr()));
    }

    internal static NativeScoreSummary FromPointer(IntPtr pointer)
    {
      if (pointer.Equals((object) IntPtr.Zero))
        return (NativeScoreSummary) null;
      return new NativeScoreSummary(pointer);
    }
  }
}
