﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class TurnBasedMatchConfig : BaseReferenceHolder
  {
    internal TurnBasedMatchConfig(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    private string PlayerIdAtIndex(UIntPtr index)
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_string, size) => GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_PlayerIdsToInvite_GetElement(this.SelfPtr(), index, out_string, size)));
    }

    internal IEnumerator<string> PlayerIdsToInvite()
    {
      return PInvokeUtilities.ToEnumerator<string>(GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_PlayerIdsToInvite_Length(this.SelfPtr()), new Func<UIntPtr, string>(this.PlayerIdAtIndex));
    }

    internal uint Variant()
    {
      return GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_Variant(this.SelfPtr());
    }

    internal long ExclusiveBitMask()
    {
      return GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_ExclusiveBitMask(this.SelfPtr());
    }

    internal uint MinimumAutomatchingPlayers()
    {
      return GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_MinimumAutomatchingPlayers(this.SelfPtr());
    }

    internal uint MaximumAutomatchingPlayers()
    {
      return GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_MaximumAutomatchingPlayers(this.SelfPtr());
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_Dispose(selfPointer);
    }
  }
}
