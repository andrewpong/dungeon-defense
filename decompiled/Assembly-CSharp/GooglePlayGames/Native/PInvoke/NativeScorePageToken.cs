// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeScorePageToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

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
