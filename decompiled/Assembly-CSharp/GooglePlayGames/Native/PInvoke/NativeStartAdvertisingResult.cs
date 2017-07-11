// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativeStartAdvertisingResult : BaseReferenceHolder
  {
    internal NativeStartAdvertisingResult(IntPtr pointer)
      : base(pointer)
    {
    }

    internal int GetStatus()
    {
      return NearbyConnectionTypes.StartAdvertisingResult_GetStatus(this.SelfPtr());
    }

    internal string LocalEndpointName()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_arg, out_size) => NearbyConnectionTypes.StartAdvertisingResult_GetLocalEndpointName(this.SelfPtr(), out_arg, out_size)));
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      NearbyConnectionTypes.StartAdvertisingResult_Dispose(selfPointer);
    }

    internal AdvertisingResult AsResult()
    {
      return new AdvertisingResult((GooglePlayGames.BasicApi.ResponseStatus) Enum.ToObject(typeof (GooglePlayGames.BasicApi.ResponseStatus), this.GetStatus()), this.LocalEndpointName());
    }

    internal static NativeStartAdvertisingResult FromPointer(IntPtr pointer)
    {
      if (pointer == IntPtr.Zero)
        return (NativeStartAdvertisingResult) null;
      return new NativeStartAdvertisingResult(pointer);
    }
  }
}
