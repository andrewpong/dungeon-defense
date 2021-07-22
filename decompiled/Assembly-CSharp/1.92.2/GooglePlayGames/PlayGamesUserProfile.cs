// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.PlayGamesUserProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.OurUtils;
using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
  public class PlayGamesUserProfile : IUserProfile
  {
    private string mDisplayName;
    private string mPlayerId;
    private string mAvatarUrl;
    private volatile bool mImageLoading;
    private Texture2D mImage;

    public string userName
    {
      get
      {
        return this.mDisplayName;
      }
    }

    public string id
    {
      get
      {
        return this.mPlayerId;
      }
    }

    public bool isFriend
    {
      get
      {
        return true;
      }
    }

    public UserState state
    {
      get
      {
        return UserState.Online;
      }
    }

    public Texture2D image
    {
      get
      {
        if (!this.mImageLoading && (UnityEngine.Object) this.mImage == (UnityEngine.Object) null && !string.IsNullOrEmpty(this.AvatarURL))
        {
          UnityEngine.Debug.Log((object) ("Starting to load image: " + this.AvatarURL));
          this.mImageLoading = true;
          PlayGamesHelperObject.RunCoroutine(this.LoadImage());
        }
        return this.mImage;
      }
    }

    public string AvatarURL
    {
      get
      {
        return this.mAvatarUrl;
      }
    }

    internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
    {
      this.mDisplayName = displayName;
      this.mPlayerId = playerId;
      this.mAvatarUrl = avatarUrl;
      this.mImageLoading = false;
    }

    protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
    {
      this.mDisplayName = displayName;
      this.mPlayerId = playerId;
      if (this.mAvatarUrl != avatarUrl)
      {
        this.mImage = (Texture2D) null;
        this.mAvatarUrl = avatarUrl;
      }
      this.mImageLoading = false;
    }

    [DebuggerHidden]
    internal IEnumerator LoadImage()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new PlayGamesUserProfile.\u003CLoadImage\u003Ec__Iterator0()
      {
        \u0024this = this
      };
    }

    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if (object.ReferenceEquals((object) this, obj))
        return true;
      PlayGamesUserProfile gamesUserProfile = obj as PlayGamesUserProfile;
      if (gamesUserProfile == null)
        return false;
      return StringComparer.Ordinal.Equals(this.mPlayerId, gamesUserProfile.mPlayerId);
    }

    public override int GetHashCode()
    {
      return typeof (PlayGamesUserProfile).GetHashCode() ^ this.mPlayerId.GetHashCode();
    }

    public override string ToString()
    {
      return string.Format("[Player: '{0}' (id {1})]", (object) this.mDisplayName, (object) this.mPlayerId);
    }
  }
}
