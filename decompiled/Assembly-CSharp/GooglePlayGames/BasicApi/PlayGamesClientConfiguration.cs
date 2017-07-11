// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.PlayGamesClientConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.OurUtils;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi
{
  public struct PlayGamesClientConfiguration
  {
    public static readonly PlayGamesClientConfiguration DefaultConfiguration = new PlayGamesClientConfiguration.Builder().WithPermissionRationale("Select email address to send to this game or hit cancel to not share.").Build();
    private readonly bool mEnableSavedGames;
    private readonly bool mRequireGooglePlus;
    private readonly string[] mScopes;
    private readonly InvitationReceivedDelegate mInvitationDelegate;
    private readonly MatchDelegate mMatchDelegate;
    private readonly string mPermissionRationale;

    public bool EnableSavedGames
    {
      get
      {
        return this.mEnableSavedGames;
      }
    }

    public bool RequireGooglePlus
    {
      get
      {
        return this.mRequireGooglePlus;
      }
    }

    public string[] Scopes
    {
      get
      {
        return this.mScopes;
      }
    }

    public InvitationReceivedDelegate InvitationDelegate
    {
      get
      {
        return this.mInvitationDelegate;
      }
    }

    public MatchDelegate MatchDelegate
    {
      get
      {
        return this.mMatchDelegate;
      }
    }

    public string PermissionRationale
    {
      get
      {
        return this.mPermissionRationale;
      }
    }

    private PlayGamesClientConfiguration(PlayGamesClientConfiguration.Builder builder)
    {
      this.mEnableSavedGames = builder.HasEnableSaveGames();
      this.mInvitationDelegate = builder.GetInvitationDelegate();
      this.mMatchDelegate = builder.GetMatchDelegate();
      this.mPermissionRationale = builder.GetPermissionRationale();
      this.mRequireGooglePlus = builder.HasRequireGooglePlus();
      this.mScopes = builder.getScopes();
    }

    public class Builder
    {
      private InvitationReceivedDelegate mInvitationDelegate = (InvitationReceivedDelegate) ((param0, param1) => {});
      private MatchDelegate mMatchDelegate = (MatchDelegate) ((param0, param1) => {});
      private bool mEnableSaveGames;
      private bool mRequireGooglePlus;
      private List<string> mScopes;
      private string mRationale;

      public PlayGamesClientConfiguration.Builder EnableSavedGames()
      {
        this.mEnableSaveGames = true;
        return this;
      }

      public PlayGamesClientConfiguration.Builder RequireGooglePlus()
      {
        this.mRequireGooglePlus = true;
        return this;
      }

      public PlayGamesClientConfiguration.Builder AddOauthScope(string scope)
      {
        if (this.mScopes == null)
          this.mScopes = new List<string>();
        this.mScopes.Add(scope);
        return this;
      }

      public PlayGamesClientConfiguration.Builder WithInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
      {
        this.mInvitationDelegate = Misc.CheckNotNull<InvitationReceivedDelegate>(invitationDelegate);
        return this;
      }

      public PlayGamesClientConfiguration.Builder WithMatchDelegate(MatchDelegate matchDelegate)
      {
        this.mMatchDelegate = Misc.CheckNotNull<MatchDelegate>(matchDelegate);
        return this;
      }

      public PlayGamesClientConfiguration.Builder WithPermissionRationale(string rationale)
      {
        this.mRationale = rationale;
        return this;
      }

      public PlayGamesClientConfiguration Build()
      {
        this.mRequireGooglePlus = GameInfo.RequireGooglePlus();
        return new PlayGamesClientConfiguration(this);
      }

      internal bool HasEnableSaveGames()
      {
        return this.mEnableSaveGames;
      }

      internal bool HasRequireGooglePlus()
      {
        return this.mRequireGooglePlus;
      }

      internal string[] getScopes()
      {
        if (this.mScopes == null)
          return new string[0];
        return this.mScopes.ToArray();
      }

      internal MatchDelegate GetMatchDelegate()
      {
        return this.mMatchDelegate;
      }

      internal InvitationReceivedDelegate GetInvitationDelegate()
      {
        return this.mInvitationDelegate;
      }

      internal string GetPermissionRationale()
      {
        return this.mRationale;
      }
    }
  }
}
