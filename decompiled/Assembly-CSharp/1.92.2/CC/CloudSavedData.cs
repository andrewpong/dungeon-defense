// Decompiled with JetBrains decompiler
// Type: CC.CloudSavedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
