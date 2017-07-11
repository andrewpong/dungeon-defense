// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.PlayGamesLocalUser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.BasicApi;
using System;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
  public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
  {
    internal PlayGamesPlatform mPlatform;
    private string emailAddress;
    private PlayerStats mStats;

    public IUserProfile[] friends
    {
      get
      {
        return this.mPlatform.GetFriends();
      }
    }

    public bool authenticated
    {
      get
      {
        return this.mPlatform.IsAuthenticated();
      }
    }

    public bool underage
    {
      get
      {
        return true;
      }
    }

    public new string userName
    {
      get
      {
        string displayName = string.Empty;
        if (this.authenticated)
        {
          displayName = this.mPlatform.GetUserDisplayName();
          if (!base.userName.Equals(displayName))
            this.ResetIdentity(displayName, this.mPlatform.GetUserId(), this.mPlatform.GetUserImageUrl());
        }
        return displayName;
      }
    }

    public new string id
    {
      get
      {
        string playerId = string.Empty;
        if (this.authenticated)
        {
          playerId = this.mPlatform.GetUserId();
          if (!base.id.Equals(playerId))
            this.ResetIdentity(this.mPlatform.GetUserDisplayName(), playerId, this.mPlatform.GetUserImageUrl());
        }
        return playerId;
      }
    }

    [Obsolete("Use PlayGamesPlatform.GetServerAuthCode()")]
    public string accessToken
    {
      get
      {
        if (this.authenticated)
          return this.mPlatform.GetAccessToken();
        return string.Empty;
      }
    }

    public new bool isFriend
    {
      get
      {
        return true;
      }
    }

    public new UserState state
    {
      get
      {
        return UserState.Online;
      }
    }

    public new string AvatarURL
    {
      get
      {
        string avatarUrl = string.Empty;
        if (this.authenticated)
        {
          avatarUrl = this.mPlatform.GetUserImageUrl();
          if (!base.id.Equals(avatarUrl))
            this.ResetIdentity(this.mPlatform.GetUserDisplayName(), this.mPlatform.GetUserId(), avatarUrl);
        }
        return avatarUrl;
      }
    }

    public string Email
    {
      get
      {
        if (this.authenticated && string.IsNullOrEmpty(this.emailAddress))
        {
          this.emailAddress = this.mPlatform.GetUserEmail();
          this.emailAddress = this.emailAddress ?? string.Empty;
        }
        if (this.authenticated)
          return this.emailAddress;
        return string.Empty;
      }
    }

    internal PlayGamesLocalUser(PlayGamesPlatform plaf)
      : base("localUser", string.Empty, string.Empty)
    {
      this.mPlatform = plaf;
      this.emailAddress = (string) null;
      this.mStats = (PlayerStats) null;
    }

    public void Authenticate(Action<bool> callback)
    {
      this.mPlatform.Authenticate(callback);
    }

    public void Authenticate(Action<bool, string> callback)
    {
      this.mPlatform.Authenticate(callback);
    }

    public void Authenticate(Action<bool> callback, bool silent)
    {
      this.mPlatform.Authenticate(callback, silent);
    }

    public void Authenticate(Action<bool, string> callback, bool silent)
    {
      this.mPlatform.Authenticate(callback, silent);
    }

    public void LoadFriends(Action<bool> callback)
    {
      this.mPlatform.LoadFriends((ILocalUser) this, callback);
    }

    [Obsolete("Use PlayGamesPlatform.GetServerAuthCode()")]
    public void GetIdToken(Action<string> idTokenCallback)
    {
      if (this.authenticated)
        this.mPlatform.GetIdToken(idTokenCallback);
      else
        idTokenCallback((string) null);
    }

    public void GetStats(Action<CommonStatusCodes, PlayerStats> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlayGamesLocalUser.\u003CGetStats\u003Ec__AnonStorey0 statsCAnonStorey0 = new PlayGamesLocalUser.\u003CGetStats\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      statsCAnonStorey0.callback = callback;
      // ISSUE: reference to a compiler-generated field
      statsCAnonStorey0.\u0024this = this;
      if (this.mStats == null || !this.mStats.Valid)
      {
        // ISSUE: reference to a compiler-generated method
        this.mPlatform.GetPlayerStats(new Action<CommonStatusCodes, PlayerStats>(statsCAnonStorey0.\u003C\u003Em__0));
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        statsCAnonStorey0.callback(CommonStatusCodes.Success, this.mStats);
      }
    }
  }
}
