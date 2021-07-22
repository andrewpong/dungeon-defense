// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.GameServices
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class GameServices : BaseReferenceHolder
  {
    internal GameServices(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    internal bool IsAuthenticated()
    {
      return GooglePlayGames.Native.Cwrapper.GameServices.GameServices_IsAuthorized(this.SelfPtr());
    }

    internal void SignOut()
    {
      GooglePlayGames.Native.Cwrapper.GameServices.GameServices_SignOut(this.SelfPtr());
    }

    internal void StartAuthorizationUI()
    {
      GooglePlayGames.Native.Cwrapper.GameServices.GameServices_StartAuthorizationUI(this.SelfPtr());
    }

    public AchievementManager AchievementManager()
    {
      return new AchievementManager(this);
    }

    public LeaderboardManager LeaderboardManager()
    {
      return new LeaderboardManager(this);
    }

    public PlayerManager PlayerManager()
    {
      return new PlayerManager(this);
    }

    public StatsManager StatsManager()
    {
      return new StatsManager(this);
    }

    internal HandleRef AsHandle()
    {
      return this.SelfPtr();
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      GooglePlayGames.Native.Cwrapper.GameServices.GameServices_Dispose(selfPointer);
    }

    internal void FetchServerAuthCode(string server_client_id, Action<GameServices.FetchServerAuthCodeResponse> callback)
    {
      Misc.CheckNotNull<Action<GameServices.FetchServerAuthCodeResponse>>(callback);
      Misc.CheckNotNull<string>(server_client_id);
      HandleRef self = this.AsHandle();
      string server_client_id1 = server_client_id;
      // ISSUE: reference to a compiler-generated field
      if (GameServices.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        GameServices.\u003C\u003Ef__mg\u0024cache1 = new GooglePlayGames.Native.Cwrapper.GameServices.FetchServerAuthCodeCallback(GameServices.InternalFetchServerAuthCodeCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.GameServices.FetchServerAuthCodeCallback fMgCache1 = GameServices.\u003C\u003Ef__mg\u0024cache1;
      Action<GameServices.FetchServerAuthCodeResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (GameServices.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        GameServices.\u003C\u003Ef__mg\u0024cache0 = new Func<IntPtr, GameServices.FetchServerAuthCodeResponse>(GameServices.FetchServerAuthCodeResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, GameServices.FetchServerAuthCodeResponse> fMgCache0 = GameServices.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr<GameServices.FetchServerAuthCodeResponse>(callback1, fMgCache0);
      GooglePlayGames.Native.Cwrapper.GameServices.GameServices_FetchServerAuthCode(self, server_client_id1, fMgCache1, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.GameServices.FetchServerAuthCodeCallback))]
    private static void InternalFetchServerAuthCodeCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("GameServices#InternalFetchServerAuthCodeCallback", Callbacks.Type.Temporary, response, data);
    }

    internal class FetchServerAuthCodeResponse : BaseReferenceHolder
    {
      internal FetchServerAuthCodeResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus Status()
      {
        return GooglePlayGames.Native.Cwrapper.GameServices.GameServices_FetchServerAuthCodeResponse_GetStatus(this.SelfPtr());
      }

      internal string Code()
      {
        return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_string, out_size) => GooglePlayGames.Native.Cwrapper.GameServices.GameServices_FetchServerAuthCodeResponse_GetCode(this.SelfPtr(), out_string, out_size)));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.GameServices.GameServices_FetchServerAuthCodeResponse_Dispose(selfPointer);
      }

      internal static GameServices.FetchServerAuthCodeResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (GameServices.FetchServerAuthCodeResponse) null;
        return new GameServices.FetchServerAuthCodeResponse(pointer);
      }
    }
  }
}
