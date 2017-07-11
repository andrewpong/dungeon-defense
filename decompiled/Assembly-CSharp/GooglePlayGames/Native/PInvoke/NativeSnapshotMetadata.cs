// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.Native.Cwrapper;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativeSnapshotMetadata : BaseReferenceHolder, ISavedGameMetadata
  {
    public bool IsOpen
    {
      get
      {
        return SnapshotMetadata.SnapshotMetadata_IsOpen(this.SelfPtr());
      }
    }

    public string Filename
    {
      get
      {
        return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_string, out_size) => SnapshotMetadata.SnapshotMetadata_FileName(this.SelfPtr(), out_string, out_size)));
      }
    }

    public string Description
    {
      get
      {
        return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_string, out_size) => SnapshotMetadata.SnapshotMetadata_Description(this.SelfPtr(), out_string, out_size)));
      }
    }

    public string CoverImageURL
    {
      get
      {
        return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_string, out_size) => SnapshotMetadata.SnapshotMetadata_CoverImageURL(this.SelfPtr(), out_string, out_size)));
      }
    }

    public TimeSpan TotalTimePlayed
    {
      get
      {
        long num = SnapshotMetadata.SnapshotMetadata_PlayedTime(this.SelfPtr());
        if (num < 0L)
          return TimeSpan.FromMilliseconds(0.0);
        return TimeSpan.FromMilliseconds((double) num);
      }
    }

    public DateTime LastModifiedTimestamp
    {
      get
      {
        return PInvokeUtilities.FromMillisSinceUnixEpoch(SnapshotMetadata.SnapshotMetadata_LastModifiedTime(this.SelfPtr()));
      }
    }

    internal NativeSnapshotMetadata(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    public override string ToString()
    {
      if (this.IsDisposed())
        return "[NativeSnapshotMetadata: DELETED]";
      return string.Format("[NativeSnapshotMetadata: IsOpen={0}, Filename={1}, Description={2}, CoverImageUrl={3}, TotalTimePlayed={4}, LastModifiedTimestamp={5}]", (object) this.IsOpen, (object) this.Filename, (object) this.Description, (object) this.CoverImageURL, (object) this.TotalTimePlayed, (object) this.LastModifiedTimestamp);
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      SnapshotMetadata.SnapshotMetadata_Dispose(this.SelfPtr());
    }
  }
}
