// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Android.AndroidTokenClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      AndroidTokenClient.\u003CFetch\u003Ec__AnonStorey0 fetchCAnonStorey0 = new AndroidTokenClient.\u003CFetch\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey0.scope = scope;
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey0.fetchEmail = fetchEmail;
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey0.fetchAccessToken = fetchAccessToken;
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey0.fetchIdToken = fetchIdToken;
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey0.doneCallback = doneCallback;
      // ISSUE: reference to a compiler-generated field
      fetchCAnonStorey0.\u0024this = this;
      if (this.apiAccessDenied)
      {
        if (this.apiWarningCount++ % this.apiWarningFreq == 0)
        {
          GooglePlayGames.OurUtils.Logger.w("Access to API denied");
          this.apiWarningCount = this.apiWarningCount / this.apiWarningFreq + 1;
        }
        // ISSUE: reference to a compiler-generated field
        fetchCAnonStorey0.doneCallback(CommonStatusCodes.AuthApiAccessForbidden);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        PlayGamesHelperObject.RunOnGameThread(new Action(fetchCAnonStorey0.\u003C\u003Em__0));
      }
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
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      AndroidTokenClient.\u003CGetAccountName\u003Ec__AnonStorey1 nameCAnonStorey1 = new AndroidTokenClient.\u003CGetAccountName\u003Ec__AnonStorey1();
      // ISSUE: reference to a compiler-generated field
      nameCAnonStorey1.callback = callback;
      // ISSUE: reference to a compiler-generated field
      nameCAnonStorey1.\u0024this = this;
      if (string.IsNullOrEmpty(this.accountName))
      {
        if (!this.fetchingEmail)
        {
          this.fetchingEmail = true;
          // ISSUE: reference to a compiler-generated method
          this.Fetch(this.idTokenScope, true, false, false, new Action<CommonStatusCodes>(nameCAnonStorey1.\u003C\u003Em__0));
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (nameCAnonStorey1.callback != null)
        {
          // ISSUE: reference to a compiler-generated field
          nameCAnonStorey1.callback(CommonStatusCodes.Success, this.accountName);
        }
      }
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
