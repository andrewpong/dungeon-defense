// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Events.IEventsClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
