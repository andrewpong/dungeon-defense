// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativePlayer : BaseReferenceHolder
  {
    internal NativePlayer(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    internal string Id()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_string, out_size) => GooglePlayGames.Native.Cwrapper.Player.Player_Id(this.SelfPtr(), out_string, out_size)));
    }

    internal string Name()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_string, out_size) => GooglePlayGames.Native.Cwrapper.Player.Player_Name(this.SelfPtr(), out_string, out_size)));
    }

    internal string AvatarURL()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_string, out_size) => GooglePlayGames.Native.Cwrapper.Player.Player_AvatarUrl(this.SelfPtr(), Types.ImageResolution.ICON, out_string, out_size)));
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      GooglePlayGames.Native.Cwrapper.Player.Player_Dispose(selfPointer);
    }

    internal GooglePlayGames.BasicApi.Multiplayer.Player AsPlayer()
    {
      return new GooglePlayGames.BasicApi.Multiplayer.Player(this.Name(), this.Id(), this.AvatarURL());
    }
  }
}
