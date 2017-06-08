// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.PlayerStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class PlayerStats
  {
    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool PlayerStats_Valid(HandleRef self);

    [DllImport("gpg")]
    internal static extern void PlayerStats_Dispose(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool PlayerStats_HasAverageSessionLength(HandleRef self);

    [DllImport("gpg")]
    internal static extern float PlayerStats_AverageSessionLength(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool PlayerStats_HasChurnProbability(HandleRef self);

    [DllImport("gpg")]
    internal static extern float PlayerStats_ChurnProbability(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool PlayerStats_HasDaysSinceLastPlayed(HandleRef self);

    [DllImport("gpg")]
    internal static extern int PlayerStats_DaysSinceLastPlayed(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool PlayerStats_HasNumberOfPurchases(HandleRef self);

    [DllImport("gpg")]
    internal static extern int PlayerStats_NumberOfPurchases(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool PlayerStats_HasNumberOfSessions(HandleRef self);

    [DllImport("gpg")]
    internal static extern int PlayerStats_NumberOfSessions(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool PlayerStats_HasSessionPercentile(HandleRef self);

    [DllImport("gpg")]
    internal static extern float PlayerStats_SessionPercentile(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool PlayerStats_HasSpendPercentile(HandleRef self);

    [DllImport("gpg")]
    internal static extern float PlayerStats_SpendPercentile(HandleRef self);
  }
}
