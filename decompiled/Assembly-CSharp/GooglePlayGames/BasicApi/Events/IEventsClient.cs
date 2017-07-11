// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Events.IEventsClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

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
