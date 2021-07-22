// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.SnapshotManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal class SnapshotManager
  {
    private readonly GameServices mServices;

    internal SnapshotManager(GameServices services)
    {
      this.mServices = Misc.CheckNotNull<GameServices>(services);
    }

    internal void FetchAll(Types.DataSource source, Action<SnapshotManager.FetchAllResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      int num = (int) source;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache1 = new GooglePlayGames.Native.Cwrapper.SnapshotManager.FetchAllCallback(SnapshotManager.InternalFetchAllCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.SnapshotManager.FetchAllCallback fMgCache1 = SnapshotManager.\u003C\u003Ef__mg\u0024cache1;
      Action<SnapshotManager.FetchAllResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache0 = new Func<IntPtr, SnapshotManager.FetchAllResponse>(SnapshotManager.FetchAllResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, SnapshotManager.FetchAllResponse> fMgCache0 = SnapshotManager.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr<SnapshotManager.FetchAllResponse>(callback1, fMgCache0);
      GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAll(self, (Types.DataSource) num, fMgCache1, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.SnapshotManager.FetchAllCallback))]
    internal static void InternalFetchAllCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("SnapshotManager#FetchAllCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void SnapshotSelectUI(bool allowCreate, bool allowDelete, uint maxSnapshots, string uiTitle, Action<SnapshotManager.SnapshotSelectUIResponse> callback)
    {
      HandleRef self = this.mServices.AsHandle();
      int num1 = allowCreate ? 1 : 0;
      int num2 = allowDelete ? 1 : 0;
      int num3 = (int) maxSnapshots;
      string title = uiTitle;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache3 = new GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotSelectUICallback(SnapshotManager.InternalSnapshotSelectUICallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotSelectUICallback fMgCache3 = SnapshotManager.\u003C\u003Ef__mg\u0024cache3;
      Action<SnapshotManager.SnapshotSelectUIResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache2 = new Func<IntPtr, SnapshotManager.SnapshotSelectUIResponse>(SnapshotManager.SnapshotSelectUIResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, SnapshotManager.SnapshotSelectUIResponse> fMgCache2 = SnapshotManager.\u003C\u003Ef__mg\u0024cache2;
      IntPtr intPtr = Callbacks.ToIntPtr<SnapshotManager.SnapshotSelectUIResponse>(callback1, fMgCache2);
      GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_ShowSelectUIOperation(self, num1 != 0, num2 != 0, (uint) num3, title, fMgCache3, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotSelectUICallback))]
    internal static void InternalSnapshotSelectUICallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("SnapshotManager#SnapshotSelectUICallback", Callbacks.Type.Temporary, response, data);
    }

    internal void Open(string fileName, Types.DataSource source, Types.SnapshotConflictPolicy conflictPolicy, Action<SnapshotManager.OpenResponse> callback)
    {
      Misc.CheckNotNull<string>(fileName);
      Misc.CheckNotNull<Action<SnapshotManager.OpenResponse>>(callback);
      HandleRef self = this.mServices.AsHandle();
      int num1 = (int) source;
      string file_name = fileName;
      int num2 = (int) conflictPolicy;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache5 = new GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback(SnapshotManager.InternalOpenCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback fMgCache5 = SnapshotManager.\u003C\u003Ef__mg\u0024cache5;
      Action<SnapshotManager.OpenResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache4 = new Func<IntPtr, SnapshotManager.OpenResponse>(SnapshotManager.OpenResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, SnapshotManager.OpenResponse> fMgCache4 = SnapshotManager.\u003C\u003Ef__mg\u0024cache4;
      IntPtr intPtr = Callbacks.ToIntPtr<SnapshotManager.OpenResponse>(callback1, fMgCache4);
      GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_Open(self, (Types.DataSource) num1, file_name, (Types.SnapshotConflictPolicy) num2, fMgCache5, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback))]
    internal static void InternalOpenCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("SnapshotManager#OpenCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void Commit(NativeSnapshotMetadata metadata, NativeSnapshotMetadataChange metadataChange, byte[] updatedData, Action<SnapshotManager.CommitResponse> callback)
    {
      Misc.CheckNotNull<NativeSnapshotMetadata>(metadata);
      Misc.CheckNotNull<NativeSnapshotMetadataChange>(metadataChange);
      HandleRef self = this.mServices.AsHandle();
      IntPtr snapshot_metadata = metadata.AsPointer();
      IntPtr metadata_change = metadataChange.AsPointer();
      byte[] data = updatedData;
      IntPtr num = (IntPtr) new UIntPtr((ulong) updatedData.Length);
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache7 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache7 = new GooglePlayGames.Native.Cwrapper.SnapshotManager.CommitCallback(SnapshotManager.InternalCommitCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.SnapshotManager.CommitCallback fMgCache7 = SnapshotManager.\u003C\u003Ef__mg\u0024cache7;
      Action<SnapshotManager.CommitResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache6 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache6 = new Func<IntPtr, SnapshotManager.CommitResponse>(SnapshotManager.CommitResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, SnapshotManager.CommitResponse> fMgCache6 = SnapshotManager.\u003C\u003Ef__mg\u0024cache6;
      IntPtr intPtr = Callbacks.ToIntPtr<SnapshotManager.CommitResponse>(callback1, fMgCache6);
      GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_Commit(self, snapshot_metadata, metadata_change, data, (UIntPtr) num, fMgCache7, intPtr);
    }

    internal void Resolve(NativeSnapshotMetadata metadata, NativeSnapshotMetadataChange metadataChange, string conflictId, Action<SnapshotManager.CommitResponse> callback)
    {
      Misc.CheckNotNull<NativeSnapshotMetadata>(metadata);
      Misc.CheckNotNull<NativeSnapshotMetadataChange>(metadataChange);
      Misc.CheckNotNull<string>(conflictId);
      HandleRef self = this.mServices.AsHandle();
      IntPtr snapshot_metadata = metadata.AsPointer();
      IntPtr metadata_change = metadataChange.AsPointer();
      string conflict_id = conflictId;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache9 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache9 = new GooglePlayGames.Native.Cwrapper.SnapshotManager.CommitCallback(SnapshotManager.InternalCommitCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.SnapshotManager.CommitCallback fMgCache9 = SnapshotManager.\u003C\u003Ef__mg\u0024cache9;
      Action<SnapshotManager.CommitResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cache8 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cache8 = new Func<IntPtr, SnapshotManager.CommitResponse>(SnapshotManager.CommitResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, SnapshotManager.CommitResponse> fMgCache8 = SnapshotManager.\u003C\u003Ef__mg\u0024cache8;
      IntPtr intPtr = Callbacks.ToIntPtr<SnapshotManager.CommitResponse>(callback1, fMgCache8);
      GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_ResolveConflict(self, snapshot_metadata, metadata_change, conflict_id, fMgCache9, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.SnapshotManager.CommitCallback))]
    internal static void InternalCommitCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("SnapshotManager#CommitCallback", Callbacks.Type.Temporary, response, data);
    }

    internal void Delete(NativeSnapshotMetadata metadata)
    {
      Misc.CheckNotNull<NativeSnapshotMetadata>(metadata);
      GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_Delete(this.mServices.AsHandle(), metadata.AsPointer());
    }

    internal void Read(NativeSnapshotMetadata metadata, Action<SnapshotManager.ReadResponse> callback)
    {
      Misc.CheckNotNull<NativeSnapshotMetadata>(metadata);
      Misc.CheckNotNull<Action<SnapshotManager.ReadResponse>>(callback);
      HandleRef self = this.mServices.AsHandle();
      IntPtr snapshot_metadata = metadata.AsPointer();
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cacheB == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cacheB = new GooglePlayGames.Native.Cwrapper.SnapshotManager.ReadCallback(SnapshotManager.InternalReadCallback);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.SnapshotManager.ReadCallback fMgCacheB = SnapshotManager.\u003C\u003Ef__mg\u0024cacheB;
      Action<SnapshotManager.ReadResponse> callback1 = callback;
      // ISSUE: reference to a compiler-generated field
      if (SnapshotManager.\u003C\u003Ef__mg\u0024cacheA == null)
      {
        // ISSUE: reference to a compiler-generated field
        SnapshotManager.\u003C\u003Ef__mg\u0024cacheA = new Func<IntPtr, SnapshotManager.ReadResponse>(SnapshotManager.ReadResponse.FromPointer);
      }
      // ISSUE: reference to a compiler-generated field
      Func<IntPtr, SnapshotManager.ReadResponse> fMgCacheA = SnapshotManager.\u003C\u003Ef__mg\u0024cacheA;
      IntPtr intPtr = Callbacks.ToIntPtr<SnapshotManager.ReadResponse>(callback1, fMgCacheA);
      GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_Read(self, snapshot_metadata, fMgCacheB, intPtr);
    }

    [MonoPInvokeCallback(typeof (GooglePlayGames.Native.Cwrapper.SnapshotManager.ReadCallback))]
    internal static void InternalReadCallback(IntPtr response, IntPtr data)
    {
      Callbacks.PerformInternalCallback("SnapshotManager#ReadCallback", Callbacks.Type.Temporary, response, data);
    }

    internal class OpenResponse : BaseReferenceHolder
    {
      internal OpenResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~(CommonErrorStatus.SnapshotOpenStatus.ERROR_INTERNAL | CommonErrorStatus.SnapshotOpenStatus.VALID);
      }

      internal CommonErrorStatus.SnapshotOpenStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetStatus(this.SelfPtr());
      }

      internal string ConflictId()
      {
        if (this.ResponseStatus() != CommonErrorStatus.SnapshotOpenStatus.VALID_WITH_CONFLICT)
          throw new InvalidOperationException("OpenResponse did not have a conflict");
        return PInvokeUtilities.OutParamsToString((PInvokeUtilities.OutStringMethod) ((out_string, out_size) => GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetConflictId(this.SelfPtr(), out_string, out_size)));
      }

      internal NativeSnapshotMetadata Data()
      {
        if (this.ResponseStatus() != CommonErrorStatus.SnapshotOpenStatus.VALID)
          throw new InvalidOperationException("OpenResponse had a conflict");
        return new NativeSnapshotMetadata(GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetData(this.SelfPtr()));
      }

      internal NativeSnapshotMetadata ConflictOriginal()
      {
        if (this.ResponseStatus() != CommonErrorStatus.SnapshotOpenStatus.VALID_WITH_CONFLICT)
          throw new InvalidOperationException("OpenResponse did not have a conflict");
        return new NativeSnapshotMetadata(GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetConflictOriginal(this.SelfPtr()));
      }

      internal NativeSnapshotMetadata ConflictUnmerged()
      {
        if (this.ResponseStatus() != CommonErrorStatus.SnapshotOpenStatus.VALID_WITH_CONFLICT)
          throw new InvalidOperationException("OpenResponse did not have a conflict");
        return new NativeSnapshotMetadata(GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_GetConflictUnmerged(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_OpenResponse_Dispose(selfPointer);
      }

      internal static SnapshotManager.OpenResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (SnapshotManager.OpenResponse) null;
        return new SnapshotManager.OpenResponse(pointer);
      }
    }

    internal class FetchAllResponse : BaseReferenceHolder
    {
      internal FetchAllResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAllResponse_GetStatus(this.SelfPtr());
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~CommonErrorStatus.ResponseStatus.ERROR_LICENSE_CHECK_FAILED;
      }

      internal IEnumerable<NativeSnapshotMetadata> Data()
      {
        return PInvokeUtilities.ToEnumerable<NativeSnapshotMetadata>(GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAllResponse_GetData_Length(this.SelfPtr()), (Func<UIntPtr, NativeSnapshotMetadata>) (index => new NativeSnapshotMetadata(GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAllResponse_GetData_GetElement(this.SelfPtr(), index))));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAllResponse_Dispose(selfPointer);
      }

      internal static SnapshotManager.FetchAllResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (SnapshotManager.FetchAllResponse) null;
        return new SnapshotManager.FetchAllResponse(pointer);
      }
    }

    internal class CommitResponse : BaseReferenceHolder
    {
      internal CommitResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_GetStatus(this.SelfPtr());
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~CommonErrorStatus.ResponseStatus.ERROR_LICENSE_CHECK_FAILED;
      }

      internal NativeSnapshotMetadata Data()
      {
        if (!this.RequestSucceeded())
          throw new InvalidOperationException("Request did not succeed");
        return new NativeSnapshotMetadata(GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_GetData(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_Dispose(selfPointer);
      }

      internal static SnapshotManager.CommitResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (SnapshotManager.CommitResponse) null;
        return new SnapshotManager.CommitResponse(pointer);
      }
    }

    internal class ReadResponse : BaseReferenceHolder
    {
      internal ReadResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.ResponseStatus ResponseStatus()
      {
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_CommitResponse_GetStatus(this.SelfPtr());
      }

      internal bool RequestSucceeded()
      {
        return this.ResponseStatus() > ~CommonErrorStatus.ResponseStatus.ERROR_LICENSE_CHECK_FAILED;
      }

      internal byte[] Data()
      {
        if (!this.RequestSucceeded())
          throw new InvalidOperationException("Request did not succeed");
        return PInvokeUtilities.OutParamsToArray<byte>((PInvokeUtilities.OutMethod<byte>) ((out_bytes, out_size) => GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_ReadResponse_GetData(this.SelfPtr(), out_bytes, out_size)));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_ReadResponse_Dispose(selfPointer);
      }

      internal static SnapshotManager.ReadResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (SnapshotManager.ReadResponse) null;
        return new SnapshotManager.ReadResponse(pointer);
      }
    }

    internal class SnapshotSelectUIResponse : BaseReferenceHolder
    {
      internal SnapshotSelectUIResponse(IntPtr selfPointer)
        : base(selfPointer)
      {
      }

      internal CommonErrorStatus.UIStatus RequestStatus()
      {
        return GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_SnapshotSelectUIResponse_GetStatus(this.SelfPtr());
      }

      internal bool RequestSucceeded()
      {
        return this.RequestStatus() > ~(CommonErrorStatus.UIStatus.ERROR_INTERNAL | CommonErrorStatus.UIStatus.VALID);
      }

      internal NativeSnapshotMetadata Data()
      {
        if (!this.RequestSucceeded())
          throw new InvalidOperationException("Request did not succeed");
        return new NativeSnapshotMetadata(GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_SnapshotSelectUIResponse_GetData(this.SelfPtr()));
      }

      protected override void CallDispose(HandleRef selfPointer)
      {
        GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_SnapshotSelectUIResponse_Dispose(selfPointer);
      }

      internal static SnapshotManager.SnapshotSelectUIResponse FromPointer(IntPtr pointer)
      {
        if (pointer.Equals((object) IntPtr.Zero))
          return (SnapshotManager.SnapshotSelectUIResponse) null;
        return new SnapshotManager.SnapshotSelectUIResponse(pointer);
      }
    }
  }
}
