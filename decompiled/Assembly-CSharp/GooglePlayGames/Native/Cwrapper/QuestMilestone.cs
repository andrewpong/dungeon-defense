// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.Cwrapper.QuestMilestone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GooglePlayGames.Native.Cwrapper
{
  internal static class QuestMilestone
  {
    [DllImport("gpg")]
    internal static extern UIntPtr QuestMilestone_EventId(HandleRef self, StringBuilder out_arg, UIntPtr out_size);

    [DllImport("gpg")]
    internal static extern ulong QuestMilestone_CurrentCount(HandleRef self);

    [DllImport("gpg")]
    internal static extern IntPtr QuestMilestone_Copy(HandleRef self);

    [DllImport("gpg")]
    internal static extern void QuestMilestone_Dispose(HandleRef self);

    [DllImport("gpg")]
    internal static extern ulong QuestMilestone_TargetCount(HandleRef self);

    [DllImport("gpg")]
    internal static extern UIntPtr QuestMilestone_QuestId(HandleRef self, StringBuilder out_arg, UIntPtr out_size);

    [DllImport("gpg")]
    internal static extern UIntPtr QuestMilestone_CompletionRewardData(HandleRef self, [In, Out] byte[] out_arg, UIntPtr out_size);

    [DllImport("gpg")]
    internal static extern Types.QuestMilestoneState QuestMilestone_State(HandleRef self);

    [DllImport("gpg")]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static extern bool QuestMilestone_Valid(HandleRef self);

    [DllImport("gpg")]
    internal static extern UIntPtr QuestMilestone_Id(HandleRef self, StringBuilder out_arg, UIntPtr out_size);
  }
}
