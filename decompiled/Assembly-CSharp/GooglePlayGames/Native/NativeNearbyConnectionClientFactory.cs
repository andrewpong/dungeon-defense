// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.NativeNearbyConnectionClientFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.Android;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using GooglePlayGames.OurUtils;
using System;
using UnityEngine;

namespace GooglePlayGames.Native
{
  public class NativeNearbyConnectionClientFactory
  {
    private static volatile NearbyConnectionsManager sManager;
    private static Action<INearbyConnectionClient> sCreationCallback;

    internal static NearbyConnectionsManager GetManager()
    {
      return NativeNearbyConnectionClientFactory.sManager;
    }

    public static void Create(Action<INearbyConnectionClient> callback)
    {
      if (NativeNearbyConnectionClientFactory.sManager == null)
      {
        NativeNearbyConnectionClientFactory.sCreationCallback = callback;
        NativeNearbyConnectionClientFactory.InitializeFactory();
      }
      else
        callback((INearbyConnectionClient) new NativeNearbyConnectionsClient(NativeNearbyConnectionClientFactory.GetManager()));
    }

    internal static void InitializeFactory()
    {
      PlayGamesHelperObject.CreateObject();
      NearbyConnectionsManager.ReadServiceId();
      NearbyConnectionsManagerBuilder connectionsManagerBuilder1 = new NearbyConnectionsManagerBuilder();
      NearbyConnectionsManagerBuilder connectionsManagerBuilder2 = connectionsManagerBuilder1;
      // ISSUE: reference to a compiler-generated field
      if (NativeNearbyConnectionClientFactory.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        NativeNearbyConnectionClientFactory.\u003C\u003Ef__mg\u0024cache0 = new Action<NearbyConnectionsStatus.InitializationStatus>(NativeNearbyConnectionClientFactory.OnManagerInitialized);
      }
      // ISSUE: reference to a compiler-generated field
      Action<NearbyConnectionsStatus.InitializationStatus> fMgCache0 = NativeNearbyConnectionClientFactory.\u003C\u003Ef__mg\u0024cache0;
      connectionsManagerBuilder2.SetOnInitializationFinished(fMgCache0);
      PlatformConfiguration platformConfiguration = new AndroidClient().CreatePlatformConfiguration();
      Debug.Log((object) "Building manager Now");
      NativeNearbyConnectionClientFactory.sManager = connectionsManagerBuilder1.Build(platformConfiguration);
    }

    internal static void OnManagerInitialized(NearbyConnectionsStatus.InitializationStatus status)
    {
      Debug.Log((object) ("Nearby Init Complete: " + (object) status + " sManager = " + (object) NativeNearbyConnectionClientFactory.sManager));
      if (status == NearbyConnectionsStatus.InitializationStatus.VALID)
      {
        if (NativeNearbyConnectionClientFactory.sCreationCallback == null)
          return;
        NativeNearbyConnectionClientFactory.sCreationCallback((INearbyConnectionClient) new NativeNearbyConnectionsClient(NativeNearbyConnectionClientFactory.GetManager()));
        NativeNearbyConnectionClientFactory.sCreationCallback = (Action<INearbyConnectionClient>) null;
      }
      else
        Debug.LogError((object) ("ERROR: NearbyConnectionManager not initialized: " + (object) status));
    }
  }
}
