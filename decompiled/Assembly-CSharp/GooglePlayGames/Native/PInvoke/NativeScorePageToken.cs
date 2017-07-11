// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeScorePageToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativeScorePageToken : BaseReferenceHolder
  {
    internal NativeScorePageToken(IntPtr selfPtr)
      : base(selfPtr)
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      ScorePage.ScorePage_ScorePageToken_Dispose(selfPointer);
    }
  }
}
