﻿// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningBoltPathScriptBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public abstract class LightningBoltPathScriptBase : LightningBoltPrefabScriptBase
  {
    private readonly List<GameObject> currentPathObjects = new List<GameObject>();
    [Header("Lightning Path Properties")]
    [ReorderableList("The game objects to follow for the lightning path")]
    public ReorderableList_GameObject LightningPath;

    protected List<GameObject> GetCurrentPathObjects()
    {
      this.currentPathObjects.Clear();
      if (this.LightningPath != null && this.LightningPath.List != null)
      {
        foreach (GameObject gameObject in this.LightningPath.List)
        {
          if ((Object) gameObject != (Object) null && gameObject.activeInHierarchy)
            this.currentPathObjects.Add(gameObject);
        }
      }
      return this.currentPathObjects;
    }

    protected override LightningBoltParameters OnCreateParameters()
    {
      LightningBoltParameters parameters = base.OnCreateParameters();
      parameters.Generator = LightningGenerator.GeneratorInstance;
      return parameters;
    }
  }
}
