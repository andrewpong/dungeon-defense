// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.ResponseStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

namespace GooglePlayGames.BasicApi
{
  public enum ResponseStatus
  {
    Timeout = -5,
    VersionUpdateRequired = -4,
    NotAuthorized = -3,
    InternalError = -2,
    LicenseCheckFailed = -1,
    Success = 1,
    SuccessWithStale = 2,
  }
}
