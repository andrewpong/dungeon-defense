using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x20000E9")]
	internal static class SnapshotManager
	{
		// Token: 0x0600088C RID: 2188
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x6CD6F8", Offset = "0x6CD6F8", VA = "0x66CD6F8")]
		[PreserveSig]
		internal static extern void SnapshotManager_FetchAll(HandleRef self, Types.DataSource data_source, SnapshotManager.FetchAllCallback callback, IntPtr callback_arg);

		// Token: 0x0600088D RID: 2189
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x6CD838", Offset = "0x6CD838", VA = "0x66CD838")]
		[PreserveSig]
		internal static extern void SnapshotManager_ShowSelectUIOperation(HandleRef self, bool allow_create, bool allow_delete, uint max_snapshots, string title, SnapshotManager.SnapshotSelectUICallback callback, IntPtr callback_arg);

		// Token: 0x0600088E RID: 2190
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x6CD968", Offset = "0x6CD968", VA = "0x66CD968")]
		[PreserveSig]
		internal static extern void SnapshotManager_Read(HandleRef self, IntPtr snapshot_metadata, SnapshotManager.ReadCallback callback, IntPtr callback_arg);

		// Token: 0x0600088F RID: 2191
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x6CDAA0", Offset = "0x6CDAA0", VA = "0x66CDAA0")]
		[PreserveSig]
		internal static extern void SnapshotManager_Commit(HandleRef self, IntPtr snapshot_metadata, IntPtr metadata_change, byte[] data, UIntPtr data_size, SnapshotManager.CommitCallback callback, IntPtr callback_arg);

		// Token: 0x06000890 RID: 2192
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x6CDBF0", Offset = "0x6CDBF0", VA = "0x66CDBF0")]
		[PreserveSig]
		internal static extern void SnapshotManager_Open(HandleRef self, Types.DataSource data_source, string file_name, Types.SnapshotConflictPolicy conflict_policy, SnapshotManager.OpenCallback callback, IntPtr callback_arg);

		// Token: 0x06000891 RID: 2193
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x6CDD48", Offset = "0x6CDD48", VA = "0x66CDD48")]
		[PreserveSig]
		internal static extern void SnapshotManager_ResolveConflict(HandleRef self, string conflict_id, IntPtr snapshot_metadata, IntPtr metadata_change, SnapshotManager.OpenCallback callback, IntPtr callback_arg);

		// Token: 0x06000892 RID: 2194
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x6CDE58", Offset = "0x6CDE58", VA = "0x66CDE58")]
		[PreserveSig]
		internal static extern void SnapshotManager_ResolveConflict(HandleRef self, string conflict_id, IntPtr snapshot_metadata, IntPtr metadata_change, byte[] data, UIntPtr data_size, SnapshotManager.OpenCallback callback, IntPtr callback_arg);

		// Token: 0x06000893 RID: 2195
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x6CDF78", Offset = "0x6CDF78", VA = "0x66CDF78")]
		[PreserveSig]
		internal static extern void SnapshotManager_ResolveConflict(HandleRef self, string conflict_id, IntPtr snapshot_metadata, SnapshotManager.OpenCallback callback, IntPtr callback_arg);

		// Token: 0x06000894 RID: 2196
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x6CE080", Offset = "0x6CE080", VA = "0x66CE080")]
		[PreserveSig]
		internal static extern void SnapshotManager_Delete(HandleRef self, IntPtr snapshot_metadata);

		// Token: 0x06000895 RID: 2197
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x6CE198", Offset = "0x6CE198", VA = "0x66CE198")]
		[PreserveSig]
		internal static extern void SnapshotManager_FetchAllResponse_Dispose(HandleRef self);

		// Token: 0x06000896 RID: 2198
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x6CE288", Offset = "0x6CE288", VA = "0x66CE288")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus SnapshotManager_FetchAllResponse_GetStatus(HandleRef self);

		// Token: 0x06000897 RID: 2199
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x6CE378", Offset = "0x6CE378", VA = "0x66CE378")]
		[PreserveSig]
		internal static extern UIntPtr SnapshotManager_FetchAllResponse_GetData_Length(HandleRef self);

		// Token: 0x06000898 RID: 2200
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x6CE468", Offset = "0x6CE468", VA = "0x66CE468")]
		[PreserveSig]
		internal static extern IntPtr SnapshotManager_FetchAllResponse_GetData_GetElement(HandleRef self, UIntPtr index);

		// Token: 0x06000899 RID: 2201
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x6CE568", Offset = "0x6CE568", VA = "0x66CE568")]
		[PreserveSig]
		internal static extern void SnapshotManager_OpenResponse_Dispose(HandleRef self);

		// Token: 0x0600089A RID: 2202
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x6CE650", Offset = "0x6CE650", VA = "0x66CE650")]
		[PreserveSig]
		internal static extern CommonErrorStatus.SnapshotOpenStatus SnapshotManager_OpenResponse_GetStatus(HandleRef self);

		// Token: 0x0600089B RID: 2203
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x6CE738", Offset = "0x6CE738", VA = "0x66CE738")]
		[PreserveSig]
		internal static extern IntPtr SnapshotManager_OpenResponse_GetData(HandleRef self);

		// Token: 0x0600089C RID: 2204
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x6CE820", Offset = "0x6CE820", VA = "0x66CE820")]
		[PreserveSig]
		internal static extern UIntPtr SnapshotManager_OpenResponse_GetConflictId(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x0600089D RID: 2205
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x6CE928", Offset = "0x6CE928", VA = "0x66CE928")]
		[PreserveSig]
		internal static extern IntPtr SnapshotManager_OpenResponse_GetConflictOriginal(HandleRef self);

		// Token: 0x0600089E RID: 2206
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x6CEA20", Offset = "0x6CEA20", VA = "0x66CEA20")]
		[PreserveSig]
		internal static extern IntPtr SnapshotManager_OpenResponse_GetConflictUnmerged(HandleRef self);

		// Token: 0x0600089F RID: 2207
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x6CEB18", Offset = "0x6CEB18", VA = "0x66CEB18")]
		[PreserveSig]
		internal static extern void SnapshotManager_CommitResponse_Dispose(HandleRef self);

		// Token: 0x060008A0 RID: 2208
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x6CEC00", Offset = "0x6CEC00", VA = "0x66CEC00")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus SnapshotManager_CommitResponse_GetStatus(HandleRef self);

		// Token: 0x060008A1 RID: 2209
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x6CECF0", Offset = "0x6CECF0", VA = "0x66CECF0")]
		[PreserveSig]
		internal static extern IntPtr SnapshotManager_CommitResponse_GetData(HandleRef self);

		// Token: 0x060008A2 RID: 2210
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x6CEDD8", Offset = "0x6CEDD8", VA = "0x66CEDD8")]
		[PreserveSig]
		internal static extern void SnapshotManager_ReadResponse_Dispose(HandleRef self);

		// Token: 0x060008A3 RID: 2211
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x6CEEC0", Offset = "0x6CEEC0", VA = "0x66CEEC0")]
		[PreserveSig]
		internal static extern CommonErrorStatus.ResponseStatus SnapshotManager_ReadResponse_GetStatus(HandleRef self);

		// Token: 0x060008A4 RID: 2212
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x6CEFA8", Offset = "0x6CEFA8", VA = "0x66CEFA8")]
		[PreserveSig]
		internal static extern UIntPtr SnapshotManager_ReadResponse_GetData(HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size);

		// Token: 0x060008A5 RID: 2213
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x6CF0A8", Offset = "0x6CF0A8", VA = "0x66CF0A8")]
		[PreserveSig]
		internal static extern void SnapshotManager_SnapshotSelectUIResponse_Dispose(HandleRef self);

		// Token: 0x060008A6 RID: 2214
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x6CF1A0", Offset = "0x6CF1A0", VA = "0x66CF1A0")]
		[PreserveSig]
		internal static extern CommonErrorStatus.UIStatus SnapshotManager_SnapshotSelectUIResponse_GetStatus(HandleRef self);

		// Token: 0x060008A7 RID: 2215
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x6CF298", Offset = "0x6CF298", VA = "0x66CF298")]
		[PreserveSig]
		internal static extern IntPtr SnapshotManager_SnapshotSelectUIResponse_GetData(HandleRef self);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x060008A9 RID: 2217
		[Token(Token = "0x20000EA")]
		internal delegate void FetchAllCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x060008AD RID: 2221
		[Token(Token = "0x20000EB")]
		internal delegate void OpenCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x060008B1 RID: 2225
		[Token(Token = "0x20000EC")]
		internal delegate void CommitCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060008B5 RID: 2229
		[Token(Token = "0x20000ED")]
		internal delegate void ReadCallback(IntPtr arg0, IntPtr arg1);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x060008B9 RID: 2233
		[Token(Token = "0x20000EE")]
		internal delegate void SnapshotSelectUICallback(IntPtr arg0, IntPtr arg1);
	}
}
