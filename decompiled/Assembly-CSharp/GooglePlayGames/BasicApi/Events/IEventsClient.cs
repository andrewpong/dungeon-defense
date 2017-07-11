// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Events.IEventsClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Events
{
  public interface IEventsClient
  {
    void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback);

    void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback);

    void IncrementEvent(string eventId, uint stepsToIncrement);
  }
}
