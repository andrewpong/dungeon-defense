// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeAppIdentifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativeAppIdentifier : BaseReferenceHolder
  {
    internal NativeAppIdentifier(IntPtr pointer)
      : base(pointer)
    {
    }

    [DllImport("gpg")]
    internal static extern IntPtr NearbyUtils_ConstructAppIdentifier(string appId);

    internal string Id()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_arg, out_size) => NearbyConnectionTypes.AppIdentifier_GetIdentifier(this.SelfPtr(), out_arg, out_size)));
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      NearbyConnectionTypes.AppIdentifier_Dispose(selfPointer);
    }

    internal static NativeAppIdentifier FromString(string appId)
    {
      return new NativeAppIdentifier(NativeAppIdentifier.NearbyUtils_ConstructAppIdentifier(appId));
    }
  }
}
