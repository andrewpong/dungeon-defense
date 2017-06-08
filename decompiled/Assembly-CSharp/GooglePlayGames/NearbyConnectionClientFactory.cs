// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.NearbyConnectionClientFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native;
using GooglePlayGames.Native.Cwrapper;
using System;
using UnityEngine;

namespace GooglePlayGames
{
  public static class NearbyConnectionClientFactory
  {
    public static void Create(Action<INearbyConnectionClient> callback)
    {
      if (Application.isEditor)
      {
        GooglePlayGames.OurUtils.Logger.d("Creating INearbyConnection in editor, using DummyClient.");
        callback((INearbyConnectionClient) new DummyNearbyConnectionClient());
      }
      GooglePlayGames.OurUtils.Logger.d("Creating real INearbyConnectionClient");
      NativeNearbyConnectionClientFactory.Create(callback);
    }

    private static GooglePlayGames.BasicApi.Nearby.InitializationStatus ToStatus(NearbyConnectionsStatus.InitializationStatus status)
    {
      switch (status + 4)
      {
        case ~(NearbyConnectionsStatus.InitializationStatus.ERROR_INTERNAL | NearbyConnectionsStatus.InitializationStatus.VALID):
          return GooglePlayGames.BasicApi.Nearby.InitializationStatus.VersionUpdateRequired;
        case ~(NearbyConnectionsStatus.InitializationStatus.ERROR_VERSION_UPDATE_REQUIRED | NearbyConnectionsStatus.InitializationStatus.VALID):
          return GooglePlayGames.BasicApi.Nearby.InitializationStatus.InternalError;
        case (NearbyConnectionsStatus.InitializationStatus) 5:
          return GooglePlayGames.BasicApi.Nearby.InitializationStatus.Success;
        default:
          GooglePlayGames.OurUtils.Logger.w("Unknown initialization status: " + (object) status);
          return GooglePlayGames.BasicApi.Nearby.InitializationStatus.InternalError;
      }
    }
  }
}
