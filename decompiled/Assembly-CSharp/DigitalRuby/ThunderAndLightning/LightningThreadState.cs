// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningThreadState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningThreadState
  {
    private AutoResetEvent lightningThreadEvent = new AutoResetEvent(false);
    private readonly Queue<Action> actionsForBackgroundThread = new Queue<Action>();
    private readonly Queue<KeyValuePair<Action, ManualResetEvent>> actionsForMainThread = new Queue<KeyValuePair<Action, ManualResetEvent>>();
    public bool Running = true;
    private Thread lightningThread;

    public LightningThreadState()
    {
      this.lightningThread = new Thread(new ThreadStart(this.BackgroundThreadMethod))
      {
        IsBackground = true,
        Name = "LightningBoltScriptThread"
      };
      this.lightningThread.Start();
    }

    private void BackgroundThreadMethod()
    {
      Action action = (Action) null;
label_9:
      while (this.Running)
      {
        try
        {
          if (this.lightningThreadEvent.WaitOne(500))
          {
            while (true)
            {
              lock ((object) this.actionsForBackgroundThread)
              {
                if (this.actionsForBackgroundThread.Count != 0)
                  action = this.actionsForBackgroundThread.Dequeue();
                else
                  goto label_9;
              }
              action();
            }
          }
        }
        catch (Exception ex)
        {
          Debug.LogErrorFormat("Lightning thread exception: {0}", (object) ex);
        }
      }
    }

    public void UpdateMainThreadActions()
    {
      while (true)
      {
        KeyValuePair<Action, ManualResetEvent> keyValuePair;
        do
        {
          lock ((object) this.actionsForMainThread)
          {
            if (this.actionsForMainThread.Count == 0)
              return;
            keyValuePair = this.actionsForMainThread.Dequeue();
          }
          keyValuePair.Key();
        }
        while (keyValuePair.Value == null);
        keyValuePair.Value.Set();
      }
    }

    public void AddActionForMainThread(Action a, bool waitForAction = false)
    {
      ManualResetEvent manualResetEvent = !waitForAction ? (ManualResetEvent) null : new ManualResetEvent(false);
      lock ((object) this.actionsForMainThread)
        this.actionsForMainThread.Enqueue(new KeyValuePair<Action, ManualResetEvent>(a, manualResetEvent));
      if (manualResetEvent == null)
        return;
      manualResetEvent.WaitOne(10000);
    }

    public void AddActionForBackgroundThread(Action a)
    {
      lock ((object) this.actionsForBackgroundThread)
        this.actionsForBackgroundThread.Enqueue(a);
      this.lightningThreadEvent.Set();
    }
  }
}
