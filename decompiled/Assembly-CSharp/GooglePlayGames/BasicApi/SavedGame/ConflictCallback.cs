// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.BasicApi.SavedGame.ConflictCallback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.SavedGame
{
  public delegate void ConflictCallback(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData);
}
