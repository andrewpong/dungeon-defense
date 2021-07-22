// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Android.AndroidTokenClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using Com.Google.Android.Gms.Common.Api;
using GooglePlayGames.BasicApi;
using GooglePlayGames.OurUtils;
using System;
using UnityEngine;

namespace GooglePlayGames.Android
{
  internal class AndroidTokenClient : TokenClient
  {
    private int apiWarningFreq = 100000;
    private int webClientWarningFreq = 100000;
    private const string TokenFragmentClass = "com.google.games.bridge.TokenFragment";
    private const string FetchTokenSignature = "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;ZZZLjava/lang/String;)Lcom/google/android/gms/common/api/PendingResult;";
    private const string FetchTokenMethod = "fetchToken";
    private string playerId;
    private bool fetchingEmail;
    private bool fetchingAccessToken;
    private bool fetchingIdToken;
    private string accountName;
    private string accessToken;
    private string idToken;
    private string idTokenScope;
    private Action<string> idTokenCb;
    private string rationale;
    private bool apiAccessDenied;
    private int apiWarningCount;
    private int webClientWarningCount;

    public AndroidTokenClient(string playerId)
    {
      this.playerId = playerId;
    }

    public static AndroidJavaObject GetActivity()
    {
      using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        return androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
    }

    public void SetRationale(string rationale)
    {
      this.rationale = rationale;
    }

    internal void Fetch(string scope, bool fetchEmail, bool fetchAccessToken, bool fetchIdToken, Action<CommonStatusCodes> doneCallback)
    {
      if (this.apiAccessDenied)
      {
        if (this.apiWarningCount++ % this.apiWarningFreq == 0)
        {
          GooglePlayGames.OurUtils.Logger.w("Access to API denied");
          this.apiWarningCount = this.apiWarningCount / this.apiWarningFreq + 1;
        }
        doneCallback(CommonStatusCodes.AuthApiAccessForbidden);
      }
      else
        PlayGamesHelperObject.RunOnGameThread((Action) (() => AndroidTokenClient.FetchToken(scope, this.playerId, this.rationale, fetchEmail, fetchAccessToken, fetchIdToken, (Action<int, string, string, string>) ((rc, access, id, email) =>
        {
          if (rc != 0)
          {
            this.apiAccessDenied = rc == 3001 || rc == 16;
            GooglePlayGames.OurUtils.Logger.w("Non-success returned from fetch: " + (object) rc);
            doneCallback(CommonStatusCodes.AuthApiAccessForbidden);
          }
          else
          {
            if (fetchAccessToken)
              GooglePlayGames.OurUtils.Logger.d("a = " + access);
            if (fetchEmail)
              GooglePlayGames.OurUtils.Logger.d("email = " + email);
            if (fetchIdToken)
              GooglePlayGames.OurUtils.Logger.d("idt = " + id);
            if (fetchAccessToken && !string.IsNullOrEmpty(access))
              this.accessToken = access;
            if (fetchIdToken && !string.IsNullOrEmpty(id))
            {
              this.idToken = id;
              this.idTokenCb(this.idToken);
            }
            if (fetchEmail && !string.IsNullOrEmpty(email))
              this.accountName = email;
            doneCallback(CommonStatusCodes.Success);
          }
        }))));
    }

    internal static void FetchToken(string scope, string playerId, string rationale, bool fetchEmail, bool fetchAccessToken, bool fetchIdToken, Action<int, string, string, string> callback)
    {
      object[] args = new object[7];
      jvalue[] jniArgArray = AndroidJNIHelper.CreateJNIArgArray(args);
      try
      {
        using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.games.bridge.TokenFragment"))
        {
          using (AndroidJavaObject activity = AndroidTokenClient.GetActivity())
          {
            IntPtr staticMethodId = AndroidJNI.GetStaticMethodID(androidJavaClass.GetRawClass(), "fetchToken", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;ZZZLjava/lang/String;)Lcom/google/android/gms/common/api/PendingResult;");
            jniArgArray[0].l = activity.GetRawObject();
            jniArgArray[1].l = AndroidJNI.NewStringUTF(playerId);
            jniArgArray[2].l = AndroidJNI.NewStringUTF(rationale);
            jniArgArray[3].z = fetchEmail;
            jniArgArray[4].z = fetchAccessToken;
            jniArgArray[5].z = fetchIdToken;
            jniArgArray[6].l = AndroidJNI.NewStringUTF(scope);
            new PendingResult<TokenResult>(AndroidJNI.CallStaticObjectMethod(androidJavaClass.GetRawClass(), staticMethodId, jniArgArray)).setResultCallback((ResultCallback<TokenResult>) new TokenResultCallback(callback));
          }
        }
      }
      catch (Exception ex)
      {
        GooglePlayGames.OurUtils.Logger.e("Exception launching token request: " + ex.Message);
        GooglePlayGames.OurUtils.Logger.e(ex.ToString());
      }
      finally
      {
        AndroidJNIHelper.DeleteJNIArgArray(args, jniArgArray);
      }
    }

    private string GetAccountName(Action<CommonStatusCodes, string> callback)
    {
      if (string.IsNullOrEmpty(this.accountName))
      {
        if (!this.fetchingEmail)
        {
          this.fetchingEmail = true;
          this.Fetch(this.idTokenScope, true, false, false, (Action<CommonStatusCodes>) (status =>
          {
            this.fetchingEmail = false;
            if (callback == null)
              return;
            callback(status, this.accountName);
          }));
        }
      }
      else if (callback != null)
        callback(CommonStatusCodes.Success, this.accountName);
      return this.accountName;
    }

    public string GetEmail()
    {
      return this.GetAccountName((Action<CommonStatusCodes, string>) null);
    }

    public void GetEmail(Action<CommonStatusCodes, string> callback)
    {
      this.GetAccountName(callback);
    }

    [Obsolete("Use PlayGamesPlatform.GetServerAuthCode()")]
    public string GetAccessToken()
    {
      if (string.IsNullOrEmpty(this.accessToken) && !this.fetchingAccessToken)
      {
        this.fetchingAccessToken = true;
        this.Fetch(this.idTokenScope, false, true, false, (Action<CommonStatusCodes>) (rc => this.fetchingAccessToken = false));
      }
      return this.accessToken;
    }

    [Obsolete("Use PlayGamesPlatform.GetServerAuthCode()")]
    public void GetIdToken(string serverClientId, Action<string> idTokenCallback)
    {
      if (string.IsNullOrEmpty(serverClientId))
      {
        if (this.webClientWarningCount++ % this.webClientWarningFreq == 0)
        {
          GooglePlayGames.OurUtils.Logger.w("serverClientId is empty, cannot get Id Token");
          this.webClientWarningCount = this.webClientWarningCount / this.webClientWarningFreq + 1;
        }
        idTokenCallback((string) null);
      }
      else
      {
        string str = "audience:server:client_id:" + serverClientId;
        if (string.IsNullOrEmpty(this.idToken) || str != this.idTokenScope)
        {
          if (this.fetchingIdToken)
            return;
          this.fetchingIdToken = true;
          this.idTokenScope = str;
          this.idTokenCb = idTokenCallback;
          this.Fetch(this.idTokenScope, false, false, true, (Action<CommonStatusCodes>) (status =>
          {
            this.fetchingIdToken = false;
            if (status == CommonStatusCodes.Success)
              this.idTokenCb((string) null);
            else
              this.idTokenCb(this.idToken);
          }));
        }
        else
          idTokenCallback(this.idToken);
      }
    }
  }
}
