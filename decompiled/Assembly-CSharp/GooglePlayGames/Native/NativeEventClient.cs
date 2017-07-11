// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.NativeEventClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.Native.PInvoke;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;

namespace GooglePlayGames.Native
{
  internal class NativeEventClient : IEventsClient
  {
    private readonly EventManager mEventManager;

    internal NativeEventClient(EventManager manager)
    {
      this.mEventManager = Misc.CheckNotNull<EventManager>(manager);
    }

    public void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeEventClient.\u003CFetchAllEvents\u003Ec__AnonStorey0 eventsCAnonStorey0 = new NativeEventClient.\u003CFetchAllEvents\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      eventsCAnonStorey0.callback = callback;
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<ResponseStatus, List<IEvent>>>(eventsCAnonStorey0.callback);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      eventsCAnonStorey0.callback = CallbackUtils.ToOnGameThread<ResponseStatus, List<IEvent>>(eventsCAnonStorey0.callback);
      // ISSUE: reference to a compiler-generated method
      this.mEventManager.FetchAll(ConversionUtils.AsDataSource(source), new Action<EventManager.FetchAllResponse>(eventsCAnonStorey0.\u003C\u003Em__0));
    }

    public void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NativeEventClient.\u003CFetchEvent\u003Ec__AnonStorey1 eventCAnonStorey1 = new NativeEventClient.\u003CFetchEvent\u003Ec__AnonStorey1();
      // ISSUE: reference to a compiler-generated field
      eventCAnonStorey1.callback = callback;
      Misc.CheckNotNull<string>(eventId);
      // ISSUE: reference to a compiler-generated field
      Misc.CheckNotNull<Action<ResponseStatus, IEvent>>(eventCAnonStorey1.callback);
      // ISSUE: reference to a compiler-generated method
      this.mEventManager.Fetch(ConversionUtils.AsDataSource(source), eventId, new Action<EventManager.FetchResponse>(eventCAnonStorey1.\u003C\u003Em__0));
    }

    public void IncrementEvent(string eventId, uint stepsToIncrement)
    {
      Misc.CheckNotNull<string>(eventId);
      this.mEventManager.Increment(eventId, stepsToIncrement);
    }
  }
}
