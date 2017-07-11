﻿// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Detectors.ActDetectorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

namespace CodeStage.AntiCheat.Detectors
{
  [AddComponentMenu("")]
  public abstract class ActDetectorBase : MonoBehaviour
  {
    [Tooltip("Automatically start detector. Detection Event will be called on detection.")]
    public bool autoStart = true;
    [Tooltip("Detector will survive new level (scene) load if checked.")]
    public bool keepAlive = true;
    [Tooltip("Automatically dispose Detector after firing callback.")]
    public bool autoDispose = true;
    protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";
    protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";
    protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";
    protected static GameObject detectorsContainer;
    [SerializeField]
    protected UnityEvent detectionEvent;
    protected UnityAction detectionAction;
    [SerializeField]
    protected bool detectionEventHasListener;
    protected bool isRunning;
    protected bool started;

    private void Start()
    {
      if ((Object) ActDetectorBase.detectorsContainer == (Object) null && this.gameObject.name == "Anti-Cheat Toolkit Detectors")
        ActDetectorBase.detectorsContainer = this.gameObject;
      if (!this.autoStart || this.started)
        return;
      this.StartDetectionAutomatically();
    }

    private void OnEnable()
    {
      if (!this.started || !this.detectionEventHasListener && this.detectionAction == null && !this.DetectorHasAdditionalCallbacks())
        return;
      this.ResumeDetector();
    }

    private void OnDisable()
    {
      if (!this.started)
        return;
      this.PauseDetector();
    }

    private void OnApplicationQuit()
    {
      this.DisposeInternal();
    }

    protected virtual void OnDestroy()
    {
      this.StopDetectionInternal();
      if (this.transform.childCount == 0 && this.GetComponentsInChildren<Component>().Length <= 2)
      {
        Object.Destroy((Object) this.gameObject);
      }
      else
      {
        if (!(this.name == "Anti-Cheat Toolkit Detectors") || this.GetComponentsInChildren<ActDetectorBase>().Length > 1)
          return;
        Object.Destroy((Object) this.gameObject);
      }
    }

    protected virtual bool Init(ActDetectorBase instance, string detectorName)
    {
      if ((Object) instance != (Object) null && (Object) instance != (Object) this && instance.keepAlive)
      {
        Debug.LogWarning((object) ("[ACTk] " + this.name + ": self-destroying, other instance already exists & only one instance allowed!"), (Object) this.gameObject);
        Object.Destroy((Object) this);
        return false;
      }
      Object.DontDestroyOnLoad((Object) this.gameObject);
      return true;
    }

    protected virtual void DisposeInternal()
    {
      Object.Destroy((Object) this);
    }

    protected virtual bool DetectorHasAdditionalCallbacks()
    {
      return false;
    }

    internal virtual void OnCheatingDetected()
    {
      if (this.detectionAction != null)
        this.detectionAction();
      if (this.detectionEventHasListener)
        this.detectionEvent.Invoke();
      if (this.autoDispose)
        this.DisposeInternal();
      else
        this.StopDetectionInternal();
    }

    protected abstract void StartDetectionAutomatically();

    protected abstract void StopDetectionInternal();

    protected abstract void PauseDetector();

    protected abstract void ResumeDetector();
  }
}
