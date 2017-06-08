﻿// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class NativeSnapshotMetadataChange : BaseReferenceHolder
  {
    internal NativeSnapshotMetadataChange(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      SnapshotMetadataChange.SnapshotMetadataChange_Dispose(selfPointer);
    }

    internal static NativeSnapshotMetadataChange FromPointer(IntPtr pointer)
    {
      if (pointer.Equals((object) IntPtr.Zero))
        return (NativeSnapshotMetadataChange) null;
      return new NativeSnapshotMetadataChange(pointer);
    }

    internal class Builder : BaseReferenceHolder
    {
      internal Builder()
        : base(SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_Construct())
      {
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_Dispose(selfPointer);
      }

      internal NativeSnapshotMetadataChange.Builder SetDescription(string description)
      {
        SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetDescription(this.SelfPtr(), description);
        return this;
      }

      internal NativeSnapshotMetadataChange.Builder SetPlayedTime(ulong playedTime)
      {
        SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetPlayedTime(this.SelfPtr(), playedTime);
        return this;
      }

      internal NativeSnapshotMetadataChange.Builder SetCoverImageFromPngData(byte[] pngData)
      {
        Misc.CheckNotNull<byte[]>(pngData);
        SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetCoverImageFromPngData(this.SelfPtr(), pngData, new UIntPtr((ulong) pngData.LongLength));
        return this;
      }

      internal NativeSnapshotMetadataChange Build()
      {
        return NativeSnapshotMetadataChange.FromPointer(SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_Create(this.SelfPtr()));
      }
    }
  }
}
