// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.Native.Cwrapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class PlayerSelectUIResponse : BaseReferenceHolder, IEnumerable<string>, IEnumerable
  {
    internal PlayerSelectUIResponse(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    internal CommonErrorStatus.UIStatus Status()
    {
      return TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetStatus(this.SelfPtr());
    }

    private string PlayerIdAtIndex(UIntPtr index)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return PInvokeUtilities.OutParamsToString(new PInvokeUtilities.OutStringMethod(new PlayerSelectUIResponse.\u003CPlayerIdAtIndex\u003Ec__AnonStorey0() { index = index, \u0024this = this }.\u003C\u003Em__0));
    }

    public IEnumerator<string> GetEnumerator()
    {
      return PInvokeUtilities.ToEnumerator<string>(TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetPlayerIds_Length(this.SelfPtr()), new Func<UIntPtr, string>(this.PlayerIdAtIndex));
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    internal uint MinimumAutomatchingPlayers()
    {
      return TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMinimumAutomatchingPlayers(this.SelfPtr());
    }

    internal uint MaximumAutomatchingPlayers()
    {
      return TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMaximumAutomatchingPlayers(this.SelfPtr());
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_Dispose(selfPointer);
    }

    internal static PlayerSelectUIResponse FromPointer(IntPtr pointer)
    {
      if (PInvokeUtilities.IsNull(pointer))
        return (PlayerSelectUIResponse) null;
      return new PlayerSelectUIResponse(pointer);
    }
  }
}
