// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.GameInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

namespace GooglePlayGames
{
  public static class GameInfo
  {
    private const string UnescapedApplicationId = "APP_ID";
    private const string UnescapedIosClientId = "IOS_CLIENTID";
    private const string UnescapedWebClientId = "WEB_CLIENTID";
    private const string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";
    private const string UnescapedRequireGooglePlus = "REQUIRE_GOOGLE_PLUS";
    public const string ApplicationId = "92295695547";
    public const string IosClientId = "";
    public const string WebClientId = "";
    public const string NearbyConnectionServiceId = "";

    public static bool RequireGooglePlus()
    {
      return false;
    }

    public static bool ApplicationIdInitialized()
    {
      if (!string.IsNullOrEmpty("92295695547"))
        return !"92295695547".Equals(GameInfo.ToEscapedToken("APP_ID"));
      return false;
    }

    public static bool IosClientIdInitialized()
    {
      if (!string.IsNullOrEmpty(string.Empty))
        return !string.Empty.Equals(GameInfo.ToEscapedToken("IOS_CLIENTID"));
      return false;
    }

    public static bool WebClientIdInitialized()
    {
      if (!string.IsNullOrEmpty(string.Empty))
        return !string.Empty.Equals(GameInfo.ToEscapedToken("WEB_CLIENTID"));
      return false;
    }

    public static bool NearbyConnectionsInitialized()
    {
      if (!string.IsNullOrEmpty(string.Empty))
        return !string.Empty.Equals(GameInfo.ToEscapedToken("NEARBY_SERVICE_ID"));
      return false;
    }

    private static string ToEscapedToken(string token)
    {
      return string.Format("__{0}__", (object) token);
    }
  }
}
