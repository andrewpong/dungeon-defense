// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Nearby.EndpointDetails
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.OurUtils;

namespace GooglePlayGames.BasicApi.Nearby
{
  public struct EndpointDetails
  {
    private readonly string mEndpointId;
    private readonly string mDeviceId;
    private readonly string mName;
    private readonly string mServiceId;

    public string EndpointId
    {
      get
      {
        return this.mEndpointId;
      }
    }

    public string DeviceId
    {
      get
      {
        return this.mDeviceId;
      }
    }

    public string Name
    {
      get
      {
        return this.mName;
      }
    }

    public string ServiceId
    {
      get
      {
        return this.mServiceId;
      }
    }

    public EndpointDetails(string endpointId, string deviceId, string name, string serviceId)
    {
      this.mEndpointId = Misc.CheckNotNull<string>(endpointId);
      this.mDeviceId = Misc.CheckNotNull<string>(deviceId);
      this.mName = Misc.CheckNotNull<string>(name);
      this.mServiceId = Misc.CheckNotNull<string>(serviceId);
    }
  }
}
