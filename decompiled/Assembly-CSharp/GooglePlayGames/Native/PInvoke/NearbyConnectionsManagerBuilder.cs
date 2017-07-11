// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NearbyConnectionsManagerBuilder : BaseReferenceHolder
  {
    internal NearbyConnectionsManagerBuilder()
      : base(NearbyConnectionsBuilder.NearbyConnections_Builder_Construct())
    {
    }

    internal NearbyConnectionsManagerBuilder SetOnInitializationFinished(Action<NearbyConnectionsStatus.InitializationStatus> callback)
    {
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (NearbyConnectionsManagerBuilder.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NearbyConnectionsManagerBuilder.\u003C\u003Ef__mg\u0024cache0 = new NearbyConnectionsBuilder.OnInitializationFinishedCallback(NearbyConnectionsManagerBuilder.InternalOnInitializationFinishedCallback);
      }
      // ISSUE: reference to a compiler-generated field
      NearbyConnectionsBuilder.OnInitializationFinishedCallback fMgCache0 = NearbyConnectionsManagerBuilder.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) callback);
      NearbyConnectionsBuilder.NearbyConnections_Builder_SetOnInitializationFinished(self, fMgCache0, intPtr);
      return this;
    }

    [MonoPInvokeCallback(typeof (NearbyConnectionsBuilder.OnInitializationFinishedCallback))]
    private static void InternalOnInitializationFinishedCallback(NearbyConnectionsStatus.InitializationStatus status, IntPtr userData)
    {
      Action<NearbyConnectionsStatus.InitializationStatus> permanentCallback = Callbacks.IntPtrToPermanentCallback<Action<NearbyConnectionsStatus.InitializationStatus>>(userData);
      if (permanentCallback == null)
      {
        Logger.w("Callback for Initialization is null. Received status: " + (object) status);
      }
      else
      {
        try
        {
          permanentCallback(status);
        }
        catch (Exception ex)
        {
          Logger.e("Error encountered executing NearbyConnectionsManagerBuilder#InternalOnInitializationFinishedCallback. Smothering exception: " + (object) ex);
        }
      }
    }

    internal NearbyConnectionsManagerBuilder SetLocalClientId(long localClientId)
    {
      NearbyConnectionsBuilder.NearbyConnections_Builder_SetClientId(this.SelfPtr(), localClientId);
      return this;
    }

    internal NearbyConnectionsManagerBuilder SetDefaultLogLevel(Types.LogLevel minLevel)
    {
      NearbyConnectionsBuilder.NearbyConnections_Builder_SetDefaultOnLog(this.SelfPtr(), minLevel);
      return this;
    }

    internal NearbyConnectionsManager Build(PlatformConfiguration configuration)
    {
      return new NearbyConnectionsManager(NearbyConnectionsBuilder.NearbyConnections_Builder_Create(this.SelfPtr(), configuration.AsPointer()));
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      NearbyConnectionsBuilder.NearbyConnections_Builder_Dispose(selfPointer);
    }
  }
}
