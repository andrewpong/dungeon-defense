// Decompiled with JetBrains decompiler
// Type: CC.CloudSavedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;

namespace CC
{
  [Serializable]
  public class CloudSavedData
  {
    public SavedData[] savedData = new SavedData[9];
    public SavedAchievement achievement = new SavedAchievement();
    public SavedRebirth rebirth = new SavedRebirth();
  }
}
