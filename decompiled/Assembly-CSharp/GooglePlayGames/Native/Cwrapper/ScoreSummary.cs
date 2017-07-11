﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.ScoreSummary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class ScoreSummary
  {
    [DllImport("gpg")]
    internal static extern ulong ScoreSummary_ApproximateNumberOfScores(HandleRef self);

    [DllImport("gpg")]
    internal static extern Types.LeaderboardTimeSpan ScoreSummary_TimeSpan(HandleRef self);

    [DllImport("gpg")]
    internal static extern UIntPtr ScoreSummary_LeaderboardId(HandleRef self, StringBuilder out_arg, UIntPtr out_size);

    [DllImport("gpg")]
    internal static extern Types.LeaderboardCollection ScoreSummary_Collection(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool ScoreSummary_Valid(HandleRef self);

    [DllImport("gpg")]
    internal static extern IntPtr ScoreSummary_CurrentPlayerScore(HandleRef self);

    [DllImport("gpg")]
    internal static extern void ScoreSummary_Dispose(HandleRef self);
  }
}
