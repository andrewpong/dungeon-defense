// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeEndpointDetails
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativeEndpointDetails : BaseReferenceHolder
  {
    internal NativeEndpointDetails(IntPtr pointer)
      : base(pointer)
    {
    }

    internal string EndpointId()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_arg, out_size) => NearbyConnectionTypes.EndpointDetails_GetEndpointId(this.SelfPtr(), out_arg, out_size)));
    }

    internal string DeviceId()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_arg, out_size) => NearbyConnectionTypes.EndpointDetails_GetDeviceId(this.SelfPtr(), out_arg, out_size)));
    }

    internal string Name()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_arg, out_size) => NearbyConnectionTypes.EndpointDetails_GetName(this.SelfPtr(), out_arg, out_size)));
    }

    internal string ServiceId()
    {
      return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_arg, out_size) => NearbyConnectionTypes.EndpointDetails_GetServiceId(this.SelfPtr(), out_arg, out_size)));
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      NearbyConnectionTypes.EndpointDetails_Dispose(selfPointer);
    }

    internal EndpointDetails ToDetails()
    {
      return new EndpointDetails(this.EndpointId(), this.DeviceId(), this.Name(), this.ServiceId());
    }

    internal static NativeEndpointDetails FromPointer(IntPtr pointer)
    {
      if (pointer.Equals((object) IntPtr.Zero))
        return (NativeEndpointDetails) null;
      return new NativeEndpointDetails(pointer);
    }
  }
}
