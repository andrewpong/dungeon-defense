// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.Events.IEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

namespace GooglePlayGames.BasicApi.Events
{
  public interface IEvent
  {
    string Id { get; }

    string Name { get; }

    string Description { get; }

    string ImageUrl { get; }

    ulong CurrentCount { get; }

    EventVisibility Visibility { get; }
  }
}
